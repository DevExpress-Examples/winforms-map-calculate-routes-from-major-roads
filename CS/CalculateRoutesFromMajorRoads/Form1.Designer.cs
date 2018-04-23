// Developer Express Code Central Example:
// How to calculate routes from major roads using the Bing Map Route web service
// 
// This example demonstrates how to calculate routes to the destination point from
// major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
// method.
// Before route calculation, specify destination point coordinates
// (GeoPoint.Latitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
// and GeoPoint.Longitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
// In addition, you can specify optional parameters: the destination name, driving
// or walking route travel mode using the BingRouteOptions.Mode
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
// property and route optimization options to calculate an optimal route either by
// time or by distance via the BingRouteOptions.RouteOptimization
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
// property.
// 
// To start the application, click the Calculate Routes From Major
// Roads button. All parameters are passed to the CalculateMajorRouteRequest
// method, and you can see the results in the rich text box element and calculated
// routes on a map. The requested results contain the total distance of a route,
// itinerary item (BingRouteResult.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
// BingRouteLeg.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
// BingItineraryItem.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
// the time required to follow the calculated route (BingRouteResult.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
// and pass the rout leg and itinerary item (BingRouteLeg.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
// BingItineraryItem.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
// You can also see the maneuvers associated with the itinerary item
// (BingItineraryItem.Maneuver
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Maneuvertopic))
// and other parameters.
// Note that if you run this sample as is, you will get a
// warning message informing that the specified Bing Maps key is invalid. To learn
// how to register a Bing Maps account and create a key for it, refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5064

// Developer Express Code Central Example:
// How to calculate routes from major roads using the Bing Map Route web service
// 
// This example demonstrates how to calculate routes to the destination point from
// major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
// method.
// Before route calculation, specify destination point coordinates
// (GeoPoint.Latitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
// and GeoPoint.Longitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
// In addition, you can specify optional parameters: the destination name, driving
// or walking route travel mode using the BingRouteOptions.Mode
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
// property and route optimization options to calculate an optimal route either by
// time or by distance via the BingRouteOptions.RouteOptimization
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
// property.
// 
// To start the application, click the Calculate Routes From Major
// Roads button. All parameters are passed to the CalculateMajorRouteRequest
// method, and you can see the results in the rich text box element and calculated
// routes on a map. The requested results contain the total distance of a route,
// itinerary item (BingRouteResult.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
// BingRouteLeg.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
// BingItineraryItem.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
// the time required to follow the calculated route (BingRouteResult.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
// and pass the rout leg and itinerary item (BingRouteLeg.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
// BingItineraryItem.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
// You can also see the maneuvers associated with the itinerary item
// (BingItineraryItem.Maneuver
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Maneuvertopic))
// and other parameters.
// Note that if you run this sample as is, you will get a
// warning message informing that the specified Bing Maps key is invalid. To learn
// how to register a Bing Maps account and create a key for it, refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5064

// Developer Express Code Central Example:
// How to get routes to the destination point using the Bing Map Route data service
// 
// This example demonstrates how to calculate routes to the destination point from
// major roads using the BingRouteDataProvider.CalculateRoutesFromMajorRoads
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_CalculateRoutesFromMajorRoadstopic)
// method.
// Before route calculation, specify destination point coordinates
// (GeoPoint.Latitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Latitudetopic)
// and GeoPoint.Longitude
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapGeoPoint_Longitudetopic)).
// In addition, you can specify optional parameters: the destination name, driving
// or walking route travel mode using the BingRouteOptions.Mode
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_Modetopic)
// property and route optimization options to calculate an optimal route either by
// time or by distance via the BingRouteOptions.RouteOptimization
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteOptions_RouteOptimizationtopic)
// property.
// 
// To start the application, click the Calculate Routes From Major
// Roads button, which handles the calculateRoutes_Click event. All parameters are
// passed to the CalculateMajorRouteRequest method, and you can see the results in
// the rich text box element and calculated routes on a map. The requested results
// contain the total distance of a route, route leg, itinerary item
// (BingRouteResult.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Distancetopic),
// BingRouteLeg.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Distancetopic),
// BingItineraryItem.Distance
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Distancetopic)),
// the time required to follow the calculated route (BingRouteResult.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_Timetopic))
// and pass the rout leg and itinerary item (BingRouteLeg.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteLeg_Timetopic),
// BingItineraryItem.Time
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_Timetopic)).
// You can also see the maneuver instructions associated with the itinerary item
// (BingItineraryItem.ManeuverInstruction
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingItineraryItem_ManeuverInstructiontopic))
// and other parameters.
// Note that if you run this sample as is, you will get a
// warning message informing that the specified Bing Maps key is invalid. To learn
// how to register a Bing Maps account and create a key for it, refer to the How
// to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5064

namespace CalculateRoutesFromMajorRoads {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.calculateRoutes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOptimize = new System.Windows.Forms.ComboBox();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbResults = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(552, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 474);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbMode);
            this.panel3.Controls.Add(this.calculateRoutes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cbOptimize);
            this.panel3.Controls.Add(this.tbLongitude);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tbLatitude);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(472, 204);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bing Travel Mode";
            // 
            // cbMode
            // 
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Driving",
            "Walking"});
            this.cbMode.Location = new System.Drawing.Point(176, 10);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(121, 21);
            this.cbMode.TabIndex = 1;
            // 
            // calculateRoutes
            // 
            this.calculateRoutes.Location = new System.Drawing.Point(118, 156);
            this.calculateRoutes.Name = "calculateRoutes";
            this.calculateRoutes.Size = new System.Drawing.Size(202, 29);
            this.calculateRoutes.TabIndex = 10;
            this.calculateRoutes.Text = "Calculate Routes From Major Roads";
            this.calculateRoutes.UseVisualStyleBackColor = true;
            this.calculateRoutes.Click += new System.EventHandler(this.calculateRoutes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Route Optimization";
            // 
            // cbOptimize
            // 
            this.cbOptimize.FormattingEnabled = true;
            this.cbOptimize.Items.AddRange(new object[] {
            "Minimize Time",
            "Minimize Distance"});
            this.cbOptimize.Location = new System.Drawing.Point(176, 47);
            this.cbOptimize.Name = "cbOptimize";
            this.cbOptimize.Size = new System.Drawing.Size(121, 21);
            this.cbOptimize.TabIndex = 4;
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(176, 111);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(100, 20);
            this.tbLongitude.TabIndex = 8;
            this.tbLongitude.Text = "-120";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Latitude";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(176, 79);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(100, 20);
            this.tbLatitude.TabIndex = 5;
            this.tbLatitude.Text = "40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Longitude";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbResults);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 474);
            this.panel2.TabIndex = 12;
            // 
            // tbResults
            // 
            this.tbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResults.Location = new System.Drawing.Point(0, 0);
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.Size = new System.Drawing.Size(472, 474);
            this.tbResults.TabIndex = 11;
            this.tbResults.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 474);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button calculateRoutes;    
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.ComboBox cbOptimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbResults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
       
    }
}

