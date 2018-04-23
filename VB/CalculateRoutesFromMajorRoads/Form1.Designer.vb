' Developer Express Code Central Example:
' How to calculate routes from major roads using the Bing Map Route web service
' 
' This example demonstrates how to calculate routes to the destination point from
' major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
' method.
' Before route calculation, specify destination point coordinates
' (GeoPoint.Latitude
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
' and GeoPoint.Longitude
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
' In addition, you can specify optional parameters: the destination name, driving
' or walking route travel mode using the BingRouteOptions.Mode
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
' property and route optimization options to calculate an optimal route either by
' time or by distance via the BingRouteOptions.RouteOptimization
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
' property.
' 
' To start the application, click the Calculate Routes From Major
' Roads button. All parameters are passed to the CalculateMajorRouteRequest
' method, and you can see the results in the rich text box element and calculated
' routes on a map. The requested results contain the total distance of a route,
' itinerary item (BingRouteResult.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
' BingRouteLeg.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
' BingItineraryItem.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
' the time required to follow the calculated route (BingRouteResult.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
' and pass the rout leg and itinerary item (BingRouteLeg.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
' BingItineraryItem.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
' You can also see the maneuvers associated with the itinerary item
' (BingItineraryItem.Maneuver
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Maneuvertopic))
' and other parameters.
' Note that if you run this sample as is, you will get a
' warning message informing that the specified Bing Maps key is invalid. To learn
' how to register a Bing Maps account and create a key for it, refer to the How
' to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5064

' Developer Express Code Central Example:
' How to calculate routes from major roads using the Bing Map Route web service
' 
' This example demonstrates how to calculate routes to the destination point from
' major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
' method.
' Before route calculation, specify destination point coordinates
' (GeoPoint.Latitude
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
' and GeoPoint.Longitude
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
' In addition, you can specify optional parameters: the destination name, driving
' or walking route travel mode using the BingRouteOptions.Mode
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
' property and route optimization options to calculate an optimal route either by
' time or by distance via the BingRouteOptions.RouteOptimization
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
' property.
' 
' To start the application, click the Calculate Routes From Major
' Roads button. All parameters are passed to the CalculateMajorRouteRequest
' method, and you can see the results in the rich text box element and calculated
' routes on a map. The requested results contain the total distance of a route,
' itinerary item (BingRouteResult.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
' BingRouteLeg.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
' BingItineraryItem.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
' the time required to follow the calculated route (BingRouteResult.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
' and pass the rout leg and itinerary item (BingRouteLeg.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
' BingItineraryItem.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
' You can also see the maneuvers associated with the itinerary item
' (BingItineraryItem.Maneuver
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Maneuvertopic))
' and other parameters.
' Note that if you run this sample as is, you will get a
' warning message informing that the specified Bing Maps key is invalid. To learn
' how to register a Bing Maps account and create a key for it, refer to the How
' to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5064

' Developer Express Code Central Example:
' How to get routes to the destination point using the Bing Map Route data service
' 
' This example demonstrates how to calculate routes to the destination point from
' major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
' method.
' Before route calculation, specify destination point coordinates
' (GeoPoint.Latitude
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
' and GeoPoint.Longitude
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
' In addition, you can specify optional parameters: the destination name, driving
' or walking route travel mode using the BingRouteOptions.Mode
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
' property and route optimization options to calculate an optimal route either by
' time or by distance via the BingRouteOptions.RouteOptimization
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
' property.
' 
' To start the application, click the Calculate Routes From Major
' Roads button, which handles the calculateRoutes_Click event. All parameters are
' passed to the CalculateMajorRouteRequest method, and you can see the results in
' the rich text box element and calculated routes on a map. The requested results
' contain the total distance of a route, route leg, itinerary item
' (BingRouteResult.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
' BingRouteLeg.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
' BingItineraryItem.Distance
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
' the time required to follow the calculated route (BingRouteResult.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
' and pass the rout leg and itinerary item (BingRouteLeg.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
' BingItineraryItem.Time
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
' You can also see the maneuver instructions associated with the itinerary item
' (BingItineraryItem.ManeuverInstruction
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_ManeuverInstructiontopic))
' and other parameters.
' Note that if you run this sample as is, you will get a
' warning message informing that the specified Bing Maps key is invalid. To learn
' how to register a Bing Maps account and create a key for it, refer to the How
' to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5064


Imports Microsoft.VisualBasic
Imports System
Namespace CalculateRoutesFromMajorRoads
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel3 = New System.Windows.Forms.Panel()
			Me.label1 = New System.Windows.Forms.Label()
			Me.cbMode = New System.Windows.Forms.ComboBox()
			Me.calculateRoutes = New System.Windows.Forms.Button()
			Me.label2 = New System.Windows.Forms.Label()
			Me.cbOptimize = New System.Windows.Forms.ComboBox()
			Me.tbLongitude = New System.Windows.Forms.TextBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.tbLatitude = New System.Windows.Forms.TextBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.tbResults = New System.Windows.Forms.RichTextBox()
			Me.panel1.SuspendLayout()
			Me.panel3.SuspendLayout()
			Me.panel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.panel3)
			Me.panel1.Controls.Add(Me.panel2)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
			Me.panel1.Location = New System.Drawing.Point(552, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(472, 474)
			Me.panel1.TabIndex = 1
			' 
			' panel3
			' 
			Me.panel3.Controls.Add(Me.label1)
			Me.panel3.Controls.Add(Me.cbMode)
			Me.panel3.Controls.Add(Me.calculateRoutes)
			Me.panel3.Controls.Add(Me.label2)
			Me.panel3.Controls.Add(Me.cbOptimize)
			Me.panel3.Controls.Add(Me.tbLongitude)
			Me.panel3.Controls.Add(Me.label3)
			Me.panel3.Controls.Add(Me.tbLatitude)
			Me.panel3.Controls.Add(Me.label4)
			Me.panel3.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel3.Location = New System.Drawing.Point(0, 0)
			Me.panel3.Name = "panel3"
			Me.panel3.Size = New System.Drawing.Size(472, 204)
			Me.panel3.TabIndex = 13
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(50, 13)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(91, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Bing Travel Mode"
			' 
			' cbMode
			' 
			Me.cbMode.FormattingEnabled = True
			Me.cbMode.Items.AddRange(New Object() { "Driving", "Walking"})
			Me.cbMode.Location = New System.Drawing.Point(176, 10)
			Me.cbMode.Name = "cbMode"
			Me.cbMode.Size = New System.Drawing.Size(121, 21)
			Me.cbMode.TabIndex = 1
			' 
			' calculateRoutes
			' 
			Me.calculateRoutes.Location = New System.Drawing.Point(118, 156)
			Me.calculateRoutes.Name = "calculateRoutes"
			Me.calculateRoutes.Size = New System.Drawing.Size(202, 29)
			Me.calculateRoutes.TabIndex = 10
			Me.calculateRoutes.Text = "Calculate Routes From Major Roads"
			Me.calculateRoutes.UseVisualStyleBackColor = True
'			Me.calculateRoutes.Click += New System.EventHandler(Me.calculateRoutes_Click);
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(50, 50)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(96, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Route Optimization"
			' 
			' cbOptimize
			' 
			Me.cbOptimize.FormattingEnabled = True
			Me.cbOptimize.Items.AddRange(New Object() { "Minimize Time", "Minimize Distance"})
			Me.cbOptimize.Location = New System.Drawing.Point(176, 47)
			Me.cbOptimize.Name = "cbOptimize"
			Me.cbOptimize.Size = New System.Drawing.Size(121, 21)
			Me.cbOptimize.TabIndex = 4
			' 
			' tbLongitude
			' 
			Me.tbLongitude.Location = New System.Drawing.Point(176, 111)
			Me.tbLongitude.Name = "tbLongitude"
			Me.tbLongitude.Size = New System.Drawing.Size(100, 20)
			Me.tbLongitude.TabIndex = 8
			Me.tbLongitude.Text = "-120"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(50, 82)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(45, 13)
			Me.label3.TabIndex = 3
			Me.label3.Text = "Latitude"
			' 
			' tbLatitude
			' 
			Me.tbLatitude.Location = New System.Drawing.Point(176, 79)
			Me.tbLatitude.Name = "tbLatitude"
			Me.tbLatitude.Size = New System.Drawing.Size(100, 20)
			Me.tbLatitude.TabIndex = 5
			Me.tbLatitude.Text = "40"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(50, 118)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(54, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Longitude"
			' 
			' panel2
			' 
			Me.panel2.Controls.Add(Me.tbResults)
			Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panel2.Location = New System.Drawing.Point(0, 0)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(472, 474)
			Me.panel2.TabIndex = 12
			' 
			' tbResults
			' 
			Me.tbResults.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tbResults.Location = New System.Drawing.Point(0, 0)
			Me.tbResults.Name = "tbResults"
			Me.tbResults.ReadOnly = True
			Me.tbResults.Size = New System.Drawing.Size(472, 474)
			Me.tbResults.TabIndex = 11
			Me.tbResults.Text = ""
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1024, 474)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.panel1.ResumeLayout(False)
			Me.panel3.ResumeLayout(False)
			Me.panel3.PerformLayout()
			Me.panel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents calculateRoutes As System.Windows.Forms.Button
		Private tbLongitude As System.Windows.Forms.TextBox
		Private label4 As System.Windows.Forms.Label
		Private tbLatitude As System.Windows.Forms.TextBox
		Private cbOptimize As System.Windows.Forms.ComboBox
		Private label3 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private cbMode As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private tbResults As System.Windows.Forms.RichTextBox
		Private panel2 As System.Windows.Forms.Panel
		Private panel3 As System.Windows.Forms.Panel

	End Class
End Namespace

