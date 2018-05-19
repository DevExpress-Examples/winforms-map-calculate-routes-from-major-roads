Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CalculateRoutesFromMajorRoads
    Partial Public Class Form1
        Inherits Form

        Private Const minLat As Double = -90
        Private Const maxLat As Double = 90
        Private Const minLon As Double = -180
        Private Const maxLon As Double = 180

        Private Const yourBingKey As String = "Insert Your Bing Key Here" '"Your Bing Key";

        Private lat As Double = 40
        Private lon As Double = -120
        Private routeProvider As BingRouteDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            imageProvider.BingKey = yourBingKey

            routeProvider = New BingRouteDataProvider With {.BingKey = yourBingKey}
            AddHandler routeProvider.LayerItemsGenerating, AddressOf OnLayerItemsGenerating
            AddHandler routeProvider.RouteCalculated, AddressOf OnRouteCalculated
            informationLayer.DataProvider = routeProvider
            AddHandler informationLayer.DataRequestCompleted, AddressOf OnDataRequestCompleted

            teLatitude.Text = lat.ToString()
            teLongitude.Text = lon.ToString()
'            #Region "#InitBingRouteOptions"
            cbeTravelMode.Properties.Items.AddRange(System.Enum.GetValues(GetType(BingTravelMode)))
            cbeTravelMode.SelectedIndex = 0
            cbeRouteOptimization.Properties.Items.AddRange(System.Enum.GetValues(GetType(BingRouteOptimization)))
            cbeRouteOptimization.SelectedIndex = 0
'            #End Region ' #InitBingRouteOptions
        End Sub

        #Region "#LayerItemsGenerating"
        Private Sub OnLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            For Each item As MapItem In e.Items
                Dim polyline As MapPolyline = TryCast(item, MapPolyline)
                If polyline IsNot Nothing Then
                    polyline.Stroke = Color.FromArgb(&HFF, &H0, &H72, &HC6)
                    polyline.StrokeWidth = 4
                End If
            Next item
        End Sub
        #End Region ' #LayerItemsGenerating

        #Region "#DataRequestCompleted"
        Private Sub OnDataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl.ZoomToFitLayerItems(0.4)
        End Sub
        #End Region ' #DataRequestCompleted

        #Region "#BingRouteOptionsChanged"
        Private Sub OnTravelModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeTravelMode.SelectedIndexChanged
            routeProvider.RouteOptions.Mode = CType(cbeTravelMode.SelectedItem, BingTravelMode)
        End Sub

        Private Sub OnRouteOptimizationSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeRouteOptimization.SelectedIndexChanged
            routeProvider.RouteOptions.RouteOptimization = CType(cbeRouteOptimization.SelectedItem, BingRouteOptimization)
        End Sub
        #End Region ' #BingRouteOptionsChanged

        Private Sub ShowErrorMessage(ByVal variable As String, ByVal minVal As Double, ByVal maxVal As Double)
            MessageBox.Show(Me, String.Format("The {0} value shoud be larger or equals {1} and less or equals {2}.", variable, minVal, maxVal), variable)
        End Sub

        Private Sub OnLatitudeValidating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles teLatitude.Validating
            If (Not Double.TryParse(teLatitude.Text, lat)) OrElse (lat > maxLat) OrElse (lat < minLat) Then
                e.Cancel = True
                ShowErrorMessage("Latitude", minLat, maxLat)
            End If
        End Sub

        Private Sub OnLongitudeValidating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles teLongitude.Validating
            If (Not Double.TryParse(teLongitude.Text, lon)) OrElse (lon > maxLon) OrElse (lon < minLon) Then
                e.Cancel = True
                ShowErrorMessage("Longitude", minLon, maxLon)
            End If
        End Sub

        Private Sub OnCalculateRoutesClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculateRoutes.Click
            Dim targetPoint As New RouteWaypoint("Searched location", New GeoPoint(lat, lon))
            routeProvider.CalculateRoutesFromMajorRoads(targetPoint)
        End Sub

        #Region "#RouteCalculated"
        Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
            Dim result As RouteCalculationResult = e.CalculationResult
            If (result.RouteResults Is Nothing) OrElse (result.ResultCode = RequestResultCode.BadRequest) Then
                rtbResults.Text = "The Bing Route service does not work for this location."
                Return
            End If

            Dim resultList As New StringBuilder("")

            If result.IntermediatePoints IsNot Nothing Then
                resultList.Append(String.Format("_________________________" & ControlChars.Lf))

                For i As Integer = 0 To e.CalculationResult.IntermediatePoints.Count - 1
                    resultList.Append(String.Format("Starting point {0}: {1} ({2})" & ControlChars.Lf, i + 1, e.CalculationResult.IntermediatePoints(i).Description, e.CalculationResult.IntermediatePoints(i).Location))
                Next i
            End If

            If (result.RouteResults IsNot Nothing) And (result.ResultCode = RequestResultCode.Success) Then

                For rnum As Integer = 0 To e.CalculationResult.RouteResults.Count - 1
                    resultList.Append(String.Format("_________________________" & ControlChars.Lf))
                    resultList.Append(String.Format("Path {0}:" & ControlChars.Lf, rnum + 1))
                    resultList.Append(String.Format("Distance: {0}" & ControlChars.Lf, e.CalculationResult.RouteResults(rnum).Distance))
                    resultList.Append(String.Format("Time: {0}" & ControlChars.Lf, e.CalculationResult.RouteResults(0).Time))

                    If e.CalculationResult.RouteResults(rnum).Legs IsNot Nothing Then
                        Dim legNum As Integer = 1
                        For Each leg As BingRouteLeg In e.CalculationResult.RouteResults(rnum).Legs
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
                Next rnum
            End If
            rtbResults.Text = resultList.ToString()
        End Sub
        #End Region ' #RouteCalculated
    End Class
End Namespace