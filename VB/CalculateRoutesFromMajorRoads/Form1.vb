Imports System
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CalculateRoutesFromMajorRoads
    Partial Public Class Form1
        Inherits Form

        Private latitude As Double
        Private longitude As Double
        Private description As String = "Route Waypoint"
        Private Const yourBingKey As String = "INSERT_YOUR_BING_KEY_HERE"
        Private map As MapControl
        Private routeOptions As New BingRouteOptions()
        Private routeProvider As New BingRouteDataProvider()
        Private infoLayer As InformationLayer

        Public Sub New()
            InitializeComponent()
            cbMode.SelectedIndex = 0
            cbOptimize.SelectedIndex = 0
            Me.panel2.BringToFront()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Call the PrepareMap method.
            PrepareMap()

            ' Handle the BingRouteCalculated event.
            AddHandler routeProvider.RouteCalculated, AddressOf routeDataProvider_RouteCalculated
        End Sub

        Private Sub calculateRoutes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calculateRoutes.Click
            If GetCalculateRoutesArguments() Then

                ' Call the CalculateMajorRouteRequest method.             
                routeProvider.CalculateRoutesFromMajorRoads(New RouteWaypoint(description, New GeoPoint(latitude, longitude)))
            End If
        End Sub

        Private Function GetCalculateRoutesArguments() As Boolean
            latitude = If(String.IsNullOrEmpty(tbLatitude.Text), 0, Double.Parse(tbLatitude.Text))
            If (latitude > 90) OrElse (latitude < -90) Then
                MessageBox.Show("Latitude must be less than or equal to 90 and greater" & "than or equal to - 90. Correct the input value.")
                Return False
            End If

            longitude = If(String.IsNullOrEmpty(tbLongitude.Text), 0, Double.Parse(tbLongitude.Text))
            If (longitude > 180) OrElse (longitude < -180) Then
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
            Dim resultList As New StringBuilder("")

            If result.StartingPoints IsNot Nothing Then
                resultList.Append(String.Format("_________________________" & ControlChars.Lf))
                Dim i As Integer = 1
                For Each startingPoint As RouteWaypoint In result.StartingPoints
                    resultList.Append(String.Format("Starting point {0}: {1} ({2})" & ControlChars.Lf, i, startingPoint.Description, startingPoint.Location))
                Next startingPoint
                    i += 1
            End If

            If (result.RouteResults IsNot Nothing) And (result.ResultCode = RequestResultCode.Success) Then
                NavigateTo(result.RouteResults(0).RoutePath(0))

                Dim rnum As Integer = 1
                For Each routeResult As BingRouteResult In result.RouteResults
                    resultList.Append(String.Format("_________________________" & ControlChars.Lf))
                    resultList.Append(String.Format("Path {0}:" & ControlChars.Lf, rnum))
                    rnum += 1
                    resultList.Append(String.Format("Distance: {0}" & ControlChars.Lf, routeResult.Distance))
                    resultList.Append(String.Format("Time: {0}" & ControlChars.Lf, routeResult.Time))

                    If routeResult.Legs IsNot Nothing Then
                        Dim legNum As Integer = 1
                        For Each leg As BingRouteLeg In routeResult.Legs
                            resultList.Append(String.Format(ControlChars.Tab & "Leg {0}:" & ControlChars.Lf, legNum))
                            legNum += 1
                            resultList.Append(String.Format(ControlChars.Tab & "Distance: {0}" & ControlChars.Lf, leg.Distance))
                            resultList.Append(String.Format(ControlChars.Tab & "Time: {0}" & ControlChars.Lf, leg.Time))
                            If leg.Itinerary IsNot Nothing Then
                                For Each itineraryItem As BingItineraryItem In leg.Itinerary
                                    resultList.Append(String.Format(itineraryItem.Maneuver & ControlChars.Lf))
                                    resultList.Append(String.Format(ControlChars.Tab & ControlChars.Tab & "Location: {0}" & ControlChars.Lf, itineraryItem.Location))
                                Next itineraryItem
                            End If
                        Next leg
                    End If
                Next routeResult
            End If

            If (result.RouteResults Is Nothing) OrElse (result.ResultCode = RequestResultCode.BadRequest) Then
                tbResults.Text = "The Bing Route service does not work for this location."
            Else
                tbResults.Text = resultList.ToString()
            End If
        End Sub

        Private Sub PrepareMap()
            ' Create a map control.
            map = New MapControl()
            map.BeginInit()

            ' Add the map control to the window.
            Me.Controls.Add(map)
            map.EndInit()

            ' Specify the map position on the form.           
            map.Dock = DockStyle.Fill

            ' Bring the map to the front.
            map.BringToFront()

            ' Create an image tiles layer and add it to the map.
            Dim tilesLayer As New ImageTilesLayer()
            map.Layers.Add(tilesLayer)

            ' Create an  information layer and add it to the map.
            infoLayer = New InformationLayer()
            map.Layers.Add(infoLayer)

            ' Create a Bing data provider and specify the Bing key.
            Dim bingProvider As New BingMapDataProvider()
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

