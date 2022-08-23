Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace CalculateRoutesFromMajorRoads

    Public Partial Class Form1
        Inherits Form

        Const minLat As Double = -90

        Const maxLat As Double = 90

        Const minLon As Double = -180

        Const maxLon As Double = 180

        Const yourBingKey As String = "Insert Your Bing Key Here" '"Your Bing Key";

        Private lat As Double = 40

        Private lon As Double = -120

        Private routeProvider As BingRouteDataProvider

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            imageProvider.BingKey = yourBingKey
            routeProvider = New BingRouteDataProvider With {.BingKey = yourBingKey}
            AddHandler routeProvider.LayerItemsGenerating, AddressOf OnLayerItemsGenerating
            AddHandler routeProvider.RouteCalculated, AddressOf OnRouteCalculated
            informationLayer.DataProvider = routeProvider
            AddHandler informationLayer.DataRequestCompleted, AddressOf OnDataRequestCompleted
            teLatitude.Text = lat.ToString()
            teLongitude.Text = lon.ToString()
#Region "#InitBingRouteOptions"
            cbeTravelMode.Properties.Items.AddRange([Enum].GetValues(GetType(BingTravelMode)))
            cbeTravelMode.SelectedIndex = 0
            cbeRouteOptimization.Properties.Items.AddRange([Enum].GetValues(GetType(BingRouteOptimization)))
            cbeRouteOptimization.SelectedIndex = 0
#End Region  ' #InitBingRouteOptions
        End Sub

#Region "#LayerItemsGenerating"
        Private Sub OnLayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            For Each item As MapItem In e.Items
                Dim polyline As MapPolyline = TryCast(item, MapPolyline)
                If polyline IsNot Nothing Then
                    polyline.Stroke = Color.FromArgb(&HFF, &H00, &H72, &HC6)
                    polyline.StrokeWidth = 4
                End If
            Next
        End Sub

#End Region  ' #LayerItemsGenerating
#Region "#DataRequestCompleted"
        Private Sub OnDataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl.ZoomToFitLayerItems(0.4)
        End Sub

#End Region  ' #DataRequestCompleted
#Region "#BingRouteOptionsChanged"
        Private Sub OnTravelModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            routeProvider.RouteOptions.Mode = CType(cbeTravelMode.SelectedItem, BingTravelMode)
        End Sub

        Private Sub OnRouteOptimizationSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
            routeProvider.RouteOptions.RouteOptimization = CType(cbeRouteOptimization.SelectedItem, BingRouteOptimization)
        End Sub

#End Region  ' #BingRouteOptionsChanged
        Private Sub ShowErrorMessage(ByVal variable As String, ByVal minVal As Double, ByVal maxVal As Double)
            MessageBox.Show(Me, String.Format("The {0} value shoud be larger or equals {1} and less or equals {2}.", variable, minVal, maxVal), variable)
        End Sub

        Private Sub OnLatitudeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Not Double.TryParse(teLatitude.Text, lat) OrElse lat > maxLat OrElse lat < minLat Then
                e.Cancel = True
                ShowErrorMessage("Latitude", minLat, maxLat)
            End If
        End Sub

        Private Sub OnLongitudeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            If Not Double.TryParse(teLongitude.Text, lon) OrElse lon > maxLon OrElse lon < minLon Then
                e.Cancel = True
                ShowErrorMessage("Longitude", minLon, maxLon)
            End If
        End Sub

        Private Sub OnCalculateRoutesClick(ByVal sender As Object, ByVal e As EventArgs)
            Dim targetPoint As RouteWaypoint = New RouteWaypoint("Searched location", New GeoPoint(lat, lon))
            routeProvider.CalculateRoutesFromMajorRoads(targetPoint)
        End Sub

#Region "#RouteCalculated"
        Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
            Dim result As RouteCalculationResult = e.CalculationResult
            If result.RouteResults Is Nothing OrElse result.ResultCode = RequestResultCode.BadRequest Then
                rtbResults.Text = "The Bing Route service does not work for this location."
                Return
            End If

            Dim resultList As StringBuilder = New StringBuilder("")
            If result.IntermediatePoints IsNot Nothing Then
                resultList.Append(String.Format("_________________________" & Microsoft.VisualBasic.Constants.vbLf))
                For i As Integer = 0 To e.CalculationResult.IntermediatePoints.Count - 1
                    resultList.Append(String.Format("Starting point {0}: {1} ({2})" & Microsoft.VisualBasic.Constants.vbLf, i + 1, e.CalculationResult.IntermediatePoints(CInt(i)).Description, e.CalculationResult.IntermediatePoints(CInt(i)).Location))
                Next
            End If

            If result.RouteResults IsNot Nothing And result.ResultCode = RequestResultCode.Success Then
                For rnum As Integer = 0 To e.CalculationResult.RouteResults.Count - 1
                    resultList.Append(String.Format("_________________________" & Microsoft.VisualBasic.Constants.vbLf))
                    resultList.Append(String.Format("Path {0}:" & Microsoft.VisualBasic.Constants.vbLf, rnum + 1))
                    resultList.Append(String.Format("Distance: {0}" & Microsoft.VisualBasic.Constants.vbLf, e.CalculationResult.RouteResults(CInt(rnum)).Distance))
                    resultList.Append(String.Format("Time: {0}" & Microsoft.VisualBasic.Constants.vbLf, e.CalculationResult.RouteResults(CInt(0)).Time))
                    If e.CalculationResult.RouteResults(rnum).Legs IsNot Nothing Then
                        Dim legNum As Integer = 1
                        For Each leg As BingRouteLeg In e.CalculationResult.RouteResults(rnum).Legs
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

            rtbResults.Text = resultList.ToString()
        End Sub
#End Region  ' #RouteCalculated
    End Class
End Namespace
