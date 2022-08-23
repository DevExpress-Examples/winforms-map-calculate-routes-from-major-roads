Namespace CalculateRoutesFromMajorRoads

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageTilesLayer1 As DevExpress.XtraMap.ImageTilesLayer = New DevExpress.XtraMap.ImageTilesLayer()
            Dim bingMapDataProvider1 As DevExpress.XtraMap.BingMapDataProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Dim informationLayer1 As DevExpress.XtraMap.InformationLayer = New DevExpress.XtraMap.InformationLayer()
            Dim bingRouteDataProvider1 As DevExpress.XtraMap.BingRouteDataProvider = New DevExpress.XtraMap.BingRouteDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.bCalculateRoutes = New System.Windows.Forms.Button()
            Me.tbLongitude = New System.Windows.Forms.TextBox()
            Me.tbLatitude = New System.Windows.Forms.TextBox()
            Me.lbRouteOptimization = New System.Windows.Forms.ListBox()
            Me.lbTravelMode = New System.Windows.Forms.ListBox()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTravelMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciRouteOptimization = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLatitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLongitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.rtbResults = New System.Windows.Forms.RichTextBox()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTravelMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciRouteOptimization), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLatitude), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLongitude), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.rtbResults)
            Me.layoutControl1.Controls.Add(Me.bCalculateRoutes)
            Me.layoutControl1.Controls.Add(Me.tbLongitude)
            Me.layoutControl1.Controls.Add(Me.tbLatitude)
            Me.layoutControl1.Controls.Add(Me.lbRouteOptimization)
            Me.layoutControl1.Controls.Add(Me.lbTravelMode)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Tahoma", 10.25F)
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(784, 561)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' bCalculateRoutes
            ' 
            Me.bCalculateRoutes.Location = New System.Drawing.Point(577, 252)
            Me.bCalculateRoutes.Name = "bCalculateRoutes"
            Me.bCalculateRoutes.Size = New System.Drawing.Size(195, 20)
            Me.bCalculateRoutes.TabIndex = 10
            Me.bCalculateRoutes.Text = "Calculate Routes From Major Roads"
            Me.bCalculateRoutes.UseVisualStyleBackColor = True
            AddHandler Me.bCalculateRoutes.Click, New System.EventHandler(AddressOf Me.bCalculateRoutes_Click)
            ' 
            ' tbLongitude
            ' 
            Me.tbLongitude.Location = New System.Drawing.Point(577, 68)
            Me.tbLongitude.Name = "tbLongitude"
            Me.tbLongitude.Size = New System.Drawing.Size(195, 20)
            Me.tbLongitude.TabIndex = 8
            AddHandler Me.tbLongitude.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.tbLongitude_Validating)
            ' 
            ' tbLatitude
            ' 
            Me.tbLatitude.Location = New System.Drawing.Point(577, 28)
            Me.tbLatitude.Name = "tbLatitude"
            Me.tbLatitude.Size = New System.Drawing.Size(195, 20)
            Me.tbLatitude.TabIndex = 7
            AddHandler Me.tbLatitude.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.tbLatitude_Validating)
            ' 
            ' lbRouteOptimization
            ' 
            Me.lbRouteOptimization.FormattingEnabled = True
            Me.lbRouteOptimization.Location = New System.Drawing.Point(577, 186)
            Me.lbRouteOptimization.Name = "lbRouteOptimization"
            Me.lbRouteOptimization.Size = New System.Drawing.Size(195, 56)
            Me.lbRouteOptimization.TabIndex = 6
            AddHandler Me.lbRouteOptimization.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lbRouteOptimization_SelectedIndexChanged)
            ' 
            ' lbTravelMode
            ' 
            Me.lbTravelMode.FormattingEnabled = True
            Me.lbTravelMode.Location = New System.Drawing.Point(577, 108)
            Me.lbTravelMode.Name = "lbTravelMode"
            Me.lbTravelMode.Size = New System.Drawing.Size(195, 56)
            Me.lbTravelMode.TabIndex = 5
            AddHandler Me.lbTravelMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.lbTravelMode_SelectedIndexChanged)
            ' 
            ' mapControl1
            ' 
            imageTilesLayer1.DataProvider = bingMapDataProvider1
            informationLayer1.DataProvider = bingRouteDataProvider1
            informationLayer1.Name = "RouteLayer"
            Me.mapControl1.Layers.Add(imageTilesLayer1)
            Me.mapControl1.Layers.Add(informationLayer1)
            Me.mapControl1.Location = New System.Drawing.Point(12, 12)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New System.Drawing.Size(561, 537)
            Me.mapControl1.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.lciTravelMode, Me.lciRouteOptimization, Me.lciLatitude, Me.lciLongitude, Me.layoutControlItem3, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(784, 561)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(565, 541)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciTravelMode
            ' 
            Me.lciTravelMode.Control = Me.lbTravelMode
            Me.lciTravelMode.Location = New System.Drawing.Point(565, 80)
            Me.lciTravelMode.Name = "lciTravelMode"
            Me.lciTravelMode.Size = New System.Drawing.Size(199, 78)
            Me.lciTravelMode.Text = "Travel Mode:"
            Me.lciTravelMode.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciTravelMode.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' lciRouteOptimization
            ' 
            Me.lciRouteOptimization.Control = Me.lbRouteOptimization
            Me.lciRouteOptimization.Location = New System.Drawing.Point(565, 158)
            Me.lciRouteOptimization.Name = "lciRouteOptimization"
            Me.lciRouteOptimization.Size = New System.Drawing.Size(199, 82)
            Me.lciRouteOptimization.Text = "Route Optimization:"
            Me.lciRouteOptimization.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciRouteOptimization.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' lciLatitude
            ' 
            Me.lciLatitude.Control = Me.tbLatitude
            Me.lciLatitude.Location = New System.Drawing.Point(565, 0)
            Me.lciLatitude.Name = "lciLatitude"
            Me.lciLatitude.Size = New System.Drawing.Size(199, 40)
            Me.lciLatitude.Text = "Latitude:"
            Me.lciLatitude.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciLatitude.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' lciLongitude
            ' 
            Me.lciLongitude.Control = Me.tbLongitude
            Me.lciLongitude.Location = New System.Drawing.Point(565, 40)
            Me.lciLongitude.Name = "lciLongitude"
            Me.lciLongitude.Size = New System.Drawing.Size(199, 40)
            Me.lciLongitude.Text = "Longitude:"
            Me.lciLongitude.TextLocation = DevExpress.Utils.Locations.Top
            Me.lciLongitude.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.bCalculateRoutes
            Me.layoutControlItem3.Location = New System.Drawing.Point(565, 240)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(199, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' rtbResults
            ' 
            Me.rtbResults.Location = New System.Drawing.Point(577, 292)
            Me.rtbResults.Name = "rtbResults"
            Me.rtbResults.Size = New System.Drawing.Size(195, 257)
            Me.rtbResults.TabIndex = 11
            Me.rtbResults.Text = ""
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.rtbResults
            Me.layoutControlItem2.Location = New System.Drawing.Point(565, 264)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(199, 277)
            Me.layoutControlItem2.Text = "Results:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(95, 13)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.mapControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTravelMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciRouteOptimization), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLatitude), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLongitude), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private lbRouteOptimization As System.Windows.Forms.ListBox

        Private lciRouteOptimization As DevExpress.XtraLayout.LayoutControlItem

        Private tbLongitude As System.Windows.Forms.TextBox

        Private tbLatitude As System.Windows.Forms.TextBox

        Private lciLatitude As DevExpress.XtraLayout.LayoutControlItem

        Private lciLongitude As DevExpress.XtraLayout.LayoutControlItem

        Private bCalculateRoutes As System.Windows.Forms.Button

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private lbTravelMode As System.Windows.Forms.ListBox

        Private lciTravelMode As DevExpress.XtraLayout.LayoutControlItem

        Private rtbResults As System.Windows.Forms.RichTextBox

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
