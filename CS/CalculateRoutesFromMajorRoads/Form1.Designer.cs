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
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer1 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingRouteDataProvider bingRouteDataProvider1 = new DevExpress.XtraMap.BingRouteDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.bCalculateRoutes = new System.Windows.Forms.Button();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.lbRouteOptimization = new System.Windows.Forms.ListBox();
            this.lbTravelMode = new System.Windows.Forms.ListBox();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTravelMode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRouteOptimization = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLatitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLongitude = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rtbResults = new System.Windows.Forms.RichTextBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTravelMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRouteOptimization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.rtbResults);
            this.layoutControl1.Controls.Add(this.bCalculateRoutes);
            this.layoutControl1.Controls.Add(this.tbLongitude);
            this.layoutControl1.Controls.Add(this.tbLatitude);
            this.layoutControl1.Controls.Add(this.lbRouteOptimization);
            this.layoutControl1.Controls.Add(this.lbTravelMode);
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(784, 561);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bCalculateRoutes
            // 
            this.bCalculateRoutes.Location = new System.Drawing.Point(577, 252);
            this.bCalculateRoutes.Name = "bCalculateRoutes";
            this.bCalculateRoutes.Size = new System.Drawing.Size(195, 20);
            this.bCalculateRoutes.TabIndex = 10;
            this.bCalculateRoutes.Text = "Calculate Routes From Major Roads";
            this.bCalculateRoutes.UseVisualStyleBackColor = true;
            this.bCalculateRoutes.Click += new System.EventHandler(this.bCalculateRoutes_Click);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(577, 68);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(195, 20);
            this.tbLongitude.TabIndex = 8;
            this.tbLongitude.Validating += new System.ComponentModel.CancelEventHandler(this.tbLongitude_Validating);
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(577, 28);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(195, 20);
            this.tbLatitude.TabIndex = 7;
            this.tbLatitude.Validating += new System.ComponentModel.CancelEventHandler(this.tbLatitude_Validating);
            // 
            // lbRouteOptimization
            // 
            this.lbRouteOptimization.FormattingEnabled = true;
            this.lbRouteOptimization.Location = new System.Drawing.Point(577, 186);
            this.lbRouteOptimization.Name = "lbRouteOptimization";
            this.lbRouteOptimization.Size = new System.Drawing.Size(195, 56);
            this.lbRouteOptimization.TabIndex = 6;
            this.lbRouteOptimization.SelectedIndexChanged += new System.EventHandler(this.lbRouteOptimization_SelectedIndexChanged);
            // 
            // lbTravelMode
            // 
            this.lbTravelMode.FormattingEnabled = true;
            this.lbTravelMode.Location = new System.Drawing.Point(577, 108);
            this.lbTravelMode.Name = "lbTravelMode";
            this.lbTravelMode.Size = new System.Drawing.Size(195, 56);
            this.lbTravelMode.TabIndex = 5;
            this.lbTravelMode.SelectedIndexChanged += new System.EventHandler(this.lbTravelMode_SelectedIndexChanged);
            // 
            // mapControl1
            // 
            imageTilesLayer1.DataProvider = bingMapDataProvider1;
            informationLayer1.DataProvider = bingRouteDataProvider1;
            informationLayer1.Name = "RouteLayer";
            this.mapControl1.Layers.Add(imageTilesLayer1);
            this.mapControl1.Layers.Add(informationLayer1);
            this.mapControl1.Location = new System.Drawing.Point(12, 12);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(561, 537);
            this.mapControl1.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciTravelMode,
            this.lciRouteOptimization,
            this.lciLatitude,
            this.lciLongitude,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 561);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(565, 541);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciTravelMode
            // 
            this.lciTravelMode.Control = this.lbTravelMode;
            this.lciTravelMode.Location = new System.Drawing.Point(565, 80);
            this.lciTravelMode.Name = "lciTravelMode";
            this.lciTravelMode.Size = new System.Drawing.Size(199, 78);
            this.lciTravelMode.Text = "Travel Mode:";
            this.lciTravelMode.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciTravelMode.TextSize = new System.Drawing.Size(95, 13);
            // 
            // lciRouteOptimization
            // 
            this.lciRouteOptimization.Control = this.lbRouteOptimization;
            this.lciRouteOptimization.Location = new System.Drawing.Point(565, 158);
            this.lciRouteOptimization.Name = "lciRouteOptimization";
            this.lciRouteOptimization.Size = new System.Drawing.Size(199, 82);
            this.lciRouteOptimization.Text = "Route Optimization:";
            this.lciRouteOptimization.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciRouteOptimization.TextSize = new System.Drawing.Size(95, 13);
            // 
            // lciLatitude
            // 
            this.lciLatitude.Control = this.tbLatitude;
            this.lciLatitude.Location = new System.Drawing.Point(565, 0);
            this.lciLatitude.Name = "lciLatitude";
            this.lciLatitude.Size = new System.Drawing.Size(199, 40);
            this.lciLatitude.Text = "Latitude:";
            this.lciLatitude.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLatitude.TextSize = new System.Drawing.Size(95, 13);
            // 
            // lciLongitude
            // 
            this.lciLongitude.Control = this.tbLongitude;
            this.lciLongitude.Location = new System.Drawing.Point(565, 40);
            this.lciLongitude.Name = "lciLongitude";
            this.lciLongitude.Size = new System.Drawing.Size(199, 40);
            this.lciLongitude.Text = "Longitude:";
            this.lciLongitude.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciLongitude.TextSize = new System.Drawing.Size(95, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.bCalculateRoutes;
            this.layoutControlItem3.Location = new System.Drawing.Point(565, 240);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(199, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // rtbResults
            // 
            this.rtbResults.Location = new System.Drawing.Point(577, 292);
            this.rtbResults.Name = "rtbResults";
            this.rtbResults.Size = new System.Drawing.Size(195, 257);
            this.rtbResults.TabIndex = 11;
            this.rtbResults.Text = "";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.rtbResults;
            this.layoutControlItem2.Location = new System.Drawing.Point(565, 264);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(199, 277);
            this.layoutControlItem2.Text = "Results:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTravelMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRouteOptimization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ListBox lbRouteOptimization;
        private DevExpress.XtraLayout.LayoutControlItem lciRouteOptimization;
        private System.Windows.Forms.TextBox tbLongitude;
        private System.Windows.Forms.TextBox tbLatitude;
        private DevExpress.XtraLayout.LayoutControlItem lciLatitude;
        private DevExpress.XtraLayout.LayoutControlItem lciLongitude;
        private System.Windows.Forms.Button bCalculateRoutes;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ListBox lbTravelMode;
        private DevExpress.XtraLayout.LayoutControlItem lciTravelMode;
        private System.Windows.Forms.RichTextBox rtbResults;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

