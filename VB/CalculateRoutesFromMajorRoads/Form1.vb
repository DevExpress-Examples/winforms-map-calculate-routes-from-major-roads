Imports System
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CalculateRoutesFromMajorRoads

    Public Partial Class Form1
        Inherits Form

        Private latitude As Double

        Private longitude As Double

        Private description As String = "Route Waypoint"

        Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"

        Private map As MapControl

        Private routeOptions As BingRouteOptions = New BingRouteOptions()

        Private routeProvider As BingRouteDataProvider = New BingRouteDataProvider()

        Private infoLayer As InformationLayer

        Public Sub New()
            InitializeComponent()
            cbMode.SelectedIndex = 0
            cbOptimize.SelectedIndex = 0
            panel2.BringToFront()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            ' Call the PrepareMap method.
            PrepareMap()
            ' Handle the BingRouteCalculated event.
            AddHandler routeProvider.RouteCalculated, New BingRouteCalculatedEventHandler(AddressOf routeDataProvider_RouteCalculated)
        End Sub

        Private Sub calculateRoutes_Click(ByVal sender As Object, ByVal e As EventArgs)
            If GetCalculateRoutesArguments() Then
                ' Call the CalculateMajorRouteRequest method.             
                routeProvider.CalculateRoutesFromMajorRoads(New RouteWaypoint(description, New GeoPoint(latitude, longitude)))
            End If
        End Sub

        Private Function GetCalculateRoutesArguments() As Boolean
            latitude = If(String.IsNullOrEmpty(tbLatitude.Text), 0, Double.Parse(tbLatitude.Text))
            If latitude > 90 OrElse latitude < -90 Then
                MessageBox.Show("Latitude must be less than or equal to 90 and greater" & "than or equal to - 90. Correct the input value.")
                Return False
            End If

            longitude = If(String.IsNullOrEmpty(tbLongitude.Text), 0, Double.Parse(tbLongitude.Text))
            If longitude > 180 OrElse longitude < -180 Then
                MessageBox.Show("Longitude must be less than or equal to 180 and greater" & "than or equal to - 180. Correct the input value.")
                Return False
            End If

            routeProvider.RouteOptions.Mode = routeOptions.Mode
            routeProvider.RouteOptions.RouteOptimization = routeOptions.RouteOptimization
            If cbMode.SelectedIndex = 0 Then
                routeOptions.Mode = BingTravelMode.Driving
            Else
                routeOptions.Mode = BingTravelMode.Walking
            End If

            If cbOptimize.SelectedIndex = 0 Then
                routeOptions.RouteOptimization = BingRouteOptimization.MinimizeTime
            Else
                routeOptions.RouteOptimization = BingRouteOptimization.MinimizeDistance
            End If

            Return True
        End Function

        Public Sub NavigateTo(ByVal geoPoint As GeoPoint)
            map.CenterPoint = geoPoint
            map.ZoomLevel = 11
        End Sub

        Private Sub routeDataProvider_RouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
            Dim result As RouteCalculationResult = e.CalculationResult
            Dim resultList As StringBuilder = New StringBuilder("")
            If result.IntermediatePoints IsNot Nothing Then
                resultList.Append(String.Format("_________________________" & Microsoft.VisualBasic.Constants.vbLf))
                Dim i As Integer = 1
                For Each startingPoint As RouteWaypoint In result.IntermediatePoints
                    resultList.Append(String.Format("Starting point {0}: {1} ({2})" & Microsoft.VisualBasic.Constants.vbLf, Math.Min(Threading.Interlocked.Increment(i), i - 1), startingPoint.Description, startingPoint.Location))
                Next
            End If

            If result.RouteResults IsNot Nothing And result.ResultCode = RequestResultCode.Success Then
                NavigateTo(result.RouteResults(0).RoutePath(0))
                Dim rnum As Integer = 1
                For Each routeResult As BingRouteResult In result.RouteResults
                    resultList.Append(String.Format("_________________________" & Microsoft.VisualBasic.Constants.vbLf))
                    resultList.Append(String.Format("Path {0}:" & Microsoft.VisualBasic.Constants.vbLf, Math.Min(Threading.Interlocked.Increment(rnum), rnum - 1)))
                    resultList.Append(String.Format("Distance: {0}" & Microsoft.VisualBasic.Constants.vbLf, routeResult.Distance))
                    resultList.Append(String.Format("Time: {0}" & Microsoft.VisualBasic.Constants.vbLf, routeResult.Time))
                    If routeResult.Legs IsNot Nothing Then
                        Dim legNum As Integer = 1
                        For Each leg As BingRouteLeg In routeResult.Legs
                            resultList.Append(String.Format(Microsoft.VisualBasic.Constants.vbTab & "Leg {0}:" & Microsoft.VisualBasic.Constants.vbLf, Math.Min(Threading.Interlocked.Increment(legNum), legNum - 1)))
                            resultList.Append(String.Format(Microsoft.VisualBasic.Constants.vbTab & "Distance: {0}" & Microsoft.VisualBasic.Constants.vbLf, leg.Distance))
                            resultList.Append(String.Format(Microsoft.VisualBasic.Constants.vbTab & "Time: {0}" & Microsoft.VisualBasic.Constants.vbLf, leg.Time))
                            If leg.Itinerary IsNot Nothing Then
                                For Each itineraryItem As BingItineraryItem In leg.Itinerary
                                    resultList.Append(String.Format(itineraryItem.Maneuver & Microsoft.VisualBasic.Constants.vbLf))
                                    resultList.Append(String.Format(Microsoft.VisualBasic.Constants.vbTab & Microsoft.VisualBasic.Constants.vbTab & "Location: {0}" & Microsoft.VisualBasic.Constants.vbLf, itineraryItem.Location))
                                Next
                            End If
                        Next
                    End If
                Next
            End If

            If result.RouteResults Is Nothing OrElse result.ResultCode = RequestResultCode.BadRequest Then
                tbResults.Text = "The Bing Route service does not work for this location."
            Else
                tbResults.Text = resultList.ToString()
            End If
        End Sub

        Private Sub PrepareMap()
            ' Create a map control.
            map = New MapControl()
            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill
            ' Add the map control to the window.
            Me.Controls.Add(map)
            ' Bring the map to the front.
            map.BringToFront()
            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As ImageTilesLayer = New ImageTilesLayer()
            map.Layers.Add(tilesLayer)
            ' Create an  information layer and add it to the map.
            infoLayer = New InformationLayer()
            map.Layers.Add(infoLayer)
            ' Create a Bing data provider and specify the Bing key.
            Dim bingProvider As BingMapDataProvider = New BingMapDataProvider()
            tilesLayer.DataProvider = bingProvider
            bingProvider.BingKey = yourBingKey
            ' Create a Bing route data provider and specify the Bing key.
            routeProvider = New BingRouteDataProvider()
            infoLayer.DataProvider = routeProvider
            routeProvider.BingKey = yourBingKey
            ' Customize stroke and stroke width of a route.  
            infoLayer.ItemStyle.Stroke = Color.FromArgb(&HFF, &H8A, &HFB, &HFF)
            infoLayer.ItemStyle.StrokeWidth = 4
        End Sub
    End Class
End Namespace
