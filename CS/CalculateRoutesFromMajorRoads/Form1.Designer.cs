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
            this.imageLayer = new DevExpress.XtraMap.ImageLayer();
            this.imageProvider = new DevExpress.XtraMap.BingMapDataProvider();
            this.informationLayer = new DevExpress.XtraMap.InformationLayer();
            this.bingRouteDataProvider1 = new DevExpress.XtraMap.BingRouteDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.teLongitude = new DevExpress.XtraEditors.TextEdit();
            this.teLatitude = new DevExpress.XtraEditors.TextEdit();
            this.btnCalculateRoutes = new DevExpress.XtraEditors.SimpleButton();
            this.cbeRouteOptimization = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeTravelMode = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTravelMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRouteOptimization = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLatitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLongitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLongitude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLatitude.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeRouteOptimization.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTravelMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTravelMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRouteOptimization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).BeginInit();
            this.SuspendLayout();
            // 
            // imageLayer
            // 
            this.imageLayer.DataProvider = this.imageProvider;
            // 
            // informationLayer
            // 
            this.informationLayer.DataProvider = this.bingRouteDataProvider1;
            this.informationLayer.Name = "RouteLayer";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teLongitude);
            this.layoutControl1.Controls.Add(this.teLatitude);
            this.layoutControl1.Controls.Add(this.btnCalculateRoutes);
            this.layoutControl1.Controls.Add(this.cbeRouteOptimization);
            this.layoutControl1.Controls.Add(this.cbeTravelMode);
            this.layoutControl1.Controls.Add(this.rtbResults);
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(638, 328);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // teLongitude
            // 
            this.teLongitude.Location = new System.Drawing.Point(534, 30);
            this.teLongitude.Name = "teLongitude";
            this.teLongitude.Size = new System.Drawing.Size(98, 20);
            this.teLongitude.StyleController = this.layoutControl1;
            this.teLongitude.TabIndex = 16;
            this.teLongitude.Validating += new System.ComponentModel.CancelEventHandler(this.OnLongitudeValidating);
            // 
            // teLatitude
            // 
            this.teLatitude.Location = new System.Drawing.Point(534, 6);
            this.teLatitude.Name = "teLatitude";
            this.teLatitude.Size = new System.Drawing.Size(98, 20);
            this.teLatitude.StyleController = this.layoutControl1;
            this.teLatitude.TabIndex = 15;
            this.teLatitude.Validating += new System.ComponentModel.CancelEventHandler(this.OnLatitudeValidating);
            // 
            // btnCalculateRoutes
            // 
            this.btnCalculateRoutes.Location = new System.Drawing.Point(439, 102);
            this.btnCalculateRoutes.Name = "btnCalculateRoutes";
            this.btnCalculateRoutes.Size = new System.Drawing.Size(193, 22);
            this.btnCalculateRoutes.StyleController = this.layoutControl1;
            this.btnCalculateRoutes.TabIndex = 14;
            this.btnCalculateRoutes.Text = "Calculate Routes From Major Roads";
            this.btnCalculateRoutes.Click += new System.EventHandler(this.OnCalculateRoutesClick);
            // 
            // cbeRouteOptimization
            // 
            this.cbeRouteOptimization.Location = new System.Drawing.Point(534, 78);
            this.cbeRouteOptimization.Name = "cbeRouteOptimization";
            this.cbeRouteOptimization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeRouteOptimization.Size = new System.Drawing.Size(98, 20);
            this.cbeRouteOptimization.StyleController = this.layoutControl1;
            this.cbeRouteOptimization.TabIndex = 13;
            this.cbeRouteOptimization.SelectedIndexChanged += new System.EventHandler(this.OnRouteOptimizationSelectedIndexChanged);
            // 
            // cbeTravelMode
            // 
            this.cbeTravelMode.Location = new System.Drawing.Point(534, 54);
            this.cbeTravelMode.Name = "cbeTravelMode";
            this.cbeTravelMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeTravelMode.Size = new System.Drawing.Size(98, 20);
            this.cbeTravelMode.StyleController = this.layoutControl1;
            this.cbeTravelMode.TabIndex = 12;
            this.cbeTravelMode.SelectedIndexChanged += new System.EventHandler(this.OnTravelModeSelectedIndexChanged);
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(439, 144);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(193, 178);
            this.rtbResults.TabIndex = 11;
            this.rtbResults.Text = "";
            // 
            // mapControl
            // 
            this.mapControl.Layers.Add(this.imageLayer);
            this.mapControl.Layers.Add(this.informationLayer);
            this.mapControl.Location = new System.Drawing.Point(6, 6);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(429, 316);
            this.mapControl.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lciTravelMode,
            this.lciRouteOptimization,
            this.layoutControlItem4,
            this.lciLatitude,
            this.lciLongitude});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.layoutControlGroup1.Size = new System.Drawing.Size(638, 328);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(433, 320);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rtbResults;
            this.layoutControlItem2.Location = new System.Drawing.Point(433, 122);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(197, 198);
            this.layoutControlItem2.Text = "Results:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(92, 13);
            // 
            // lciTravelMode
            // 
            this.lciTravelMode.Control = this.cbeTravelMode;
            this.lciTravelMode.Location = new System.Drawing.Point(433, 48);
            this.lciTravelMode.Name = "lciTravelMode";
            this.lciTravelMode.Size = new System.Drawing.Size(197, 24);
            this.lciTravelMode.Text = "Travel Mode:";
            this.lciTravelMode.TextSize = new System.Drawing.Size(92, 13);
            // 
            // lciRouteOptimization
            // 
            this.lciRouteOptimization.Control = this.cbeRouteOptimization;
            this.lciRouteOptimization.Location = new System.Drawing.Point(433, 72);
            this.lciRouteOptimization.Name = "lciRouteOptimization";
            this.lciRouteOptimization.Size = new System.Drawing.Size(197, 24);
            this.lciRouteOptimization.Text = "RouteOptimization:";
            this.lciRouteOptimization.TextSize = new System.Drawing.Size(92, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnCalculateRoutes;
            this.layoutControlItem4.Location = new System.Drawing.Point(433, 96);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(197, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // lciLatitude
            // 
            this.lciLatitude.Control = this.teLatitude;
            this.lciLatitude.Location = new System.Drawing.Point(433, 0);
            this.lciLatitude.Name = "lciLatitude";
            this.lciLatitude.Size = new System.Drawing.Size(197, 24);
            this.lciLatitude.Text = "Latitude:";
            this.lciLatitude.TextSize = new System.Drawing.Size(92, 13);
            // 
            // lciLongitude
            // 
            this.lciLongitude.Control = this.teLongitude;
            this.lciLongitude.Location = new System.Drawing.Point(433, 24);
            this.lciLongitude.Name = "lciLongitude";
            this.lciLongitude.Size = new System.Drawing.Size(197, 24);
            this.lciLongitude.Text = "Longitude:";
            this.lciLongitude.TextSize = new System.Drawing.Size(92, 13);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 328);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Calculate Routes From Major Roads Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teLongitude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLatitude.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeRouteOptimization.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTravelMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTravelMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRouteOptimization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.RichTextBox rtbResults;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cbeTravelMode;
        private DevExpress.XtraLayout.LayoutControlItem lciTravelMode;
        private DevExpress.XtraMap.ImageLayer imageLayer;
        private DevExpress.XtraMap.BingMapDataProvider imageProvider;
        private DevExpress.XtraMap.InformationLayer informationLayer;
        private DevExpress.XtraMap.BingRouteDataProvider bingRouteDataProvider1;
        private DevExpress.XtraEditors.ComboBoxEdit cbeRouteOptimization;
        private DevExpress.XtraLayout.LayoutControlItem lciRouteOptimization;
        private DevExpress.XtraEditors.SimpleButton btnCalculateRoutes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit teLatitude;
        private DevExpress.XtraLayout.LayoutControlItem lciLatitude;
        private DevExpress.XtraEditors.TextEdit teLongitude;
        private DevExpress.XtraLayout.LayoutControlItem lciLongitude;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

