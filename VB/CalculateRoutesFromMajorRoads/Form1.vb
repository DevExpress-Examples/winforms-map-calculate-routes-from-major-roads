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

        Private lat As Double = 40
        Private lon As Double = -120

        Private ReadOnly Property RouteLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("RouteLayer"), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property RouteProvider() As BingRouteDataProvider
            Get
                Return CType(RouteLayer.DataProvider, BingRouteDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()

            tbLatitude.Text = lat.ToString()
            tbLongitude.Text = lon.ToString()

'            #Region "#InitBingRouteOptions"
            lbTravelMode.DataSource = System.Enum.GetValues(GetType(BingTravelMode))
            lbRouteOptimization.DataSource = System.Enum.GetValues(GetType(BingRouteOptimization))
'            #End Region ' #InitBingRouteOptions

            AddHandler RouteLayer.DataRequestCompleted, AddressOf RouteLayer_DataRequestCompleted
            AddHandler RouteProvider.LayerItemsGenerating, AddressOf RouteProvider_LayerItemsGenerating
            AddHandler RouteProvider.RouteCalculated, AddressOf RouteProvider_RouteCalculated

        End Sub

        #Region "#LayerItemsGenerating"
        Private Sub RouteProvider_LayerItemsGenerating(ByVal sender As Object, ByVal e As LayerItemsGeneratingEventArgs)
            For Each item As MapItem In e.Items
                Dim polyline As MapPolyline = TryCast(item, MapPolyline)
                If polyline IsNot Nothing Then
                    polyline.Stroke = Color.FromArgb(&HFF, &HFE, &H72, &HFF)
                    polyline.StrokeWidth = 4
                End If
            Next item
        End Sub
        #End Region ' #LayerItemsGenerating

        #Region "#DataRequestCompleted"
        Private Sub RouteLayer_DataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl1.ZoomToFitLayerItems(0.4)
        End Sub
        #End Region ' #DataRequestCompleted

        #Region "#BingRouteOptionsChanged"
        Private Sub lbTravelMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbTravelMode.SelectedIndexChanged
            RouteProvider.RouteOptions.Mode = DirectCast(lbTravelMode.SelectedValue, BingTravelMode)
        End Sub

        Private Sub lbRouteOptimization_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lbRouteOptimization.SelectedIndexChanged
            RouteProvider.RouteOptions.RouteOptimization = DirectCast(lbRouteOptimization.SelectedValue, BingRouteOptimization)
        End Sub
        #End Region ' #BingRouteOptionsChanged

        Private Sub ShowErrorMessage(ByVal variable As String, ByVal minVal As Double, ByVal maxVal As Double)
            MessageBox.Show(Me, String.Format("The {0} value shoud be larger or equals {1} and less or equals {2}.", variable, minVal, maxVal), variable)
        End Sub

        Private Sub tbLatitude_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles tbLatitude.Validating
            If (Not Double.TryParse(tbLatitude.Text, lat)) OrElse (lat > maxLat) OrElse (lat < minLat) Then
                e.Cancel = True
                ShowErrorMessage("Latitude", minLat, maxLat)
            End If
        End Sub

        Private Sub tbLongitude_Validating(ByVal sender As Object, ByVal e As CancelEventArgs) Handles tbLongitude.Validating
            If (Not Double.TryParse(tbLongitude.Text, lon)) OrElse (lon > maxLon) OrElse (lon < minLon) Then
                e.Cancel = True
                ShowErrorMessage("Longitude", minLon, maxLon)
            End If
        End Sub

        Private Sub bCalculateRoutes_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bCalculateRoutes.Click
            RouteProvider.CalculateRoutesFromMajorRoads(New RouteWaypoint("Searched location", New GeoPoint(lat, lon)))
        End Sub

        #Region "#RouteCalculated"
        Private Sub RouteProvider_RouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
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