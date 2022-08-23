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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.imageLayer = New DevExpress.XtraMap.ImageLayer()
            Me.imageProvider = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer = New DevExpress.XtraMap.InformationLayer()
            Me.bingRouteDataProvider1 = New DevExpress.XtraMap.BingRouteDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.teLongitude = New DevExpress.XtraEditors.TextEdit()
            Me.teLatitude = New DevExpress.XtraEditors.TextEdit()
            Me.btnCalculateRoutes = New DevExpress.XtraEditors.SimpleButton()
            Me.cbeRouteOptimization = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbeTravelMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.rtbResults = New System.Windows.Forms.RichTextBox()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTravelMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciRouteOptimization = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLatitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLongitude = New DevExpress.XtraLayout.LayoutControlItem()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.teLongitude.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teLatitude.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeRouteOptimization.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeTravelMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTravelMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciRouteOptimization), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLatitude), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLongitude), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageLayer
            ' 
            Me.imageLayer.DataProvider = Me.imageProvider
            ' 
            ' informationLayer
            ' 
            Me.informationLayer.DataProvider = Me.bingRouteDataProvider1
            Me.informationLayer.Name = "RouteLayer"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.teLongitude)
            Me.layoutControl1.Controls.Add(Me.teLatitude)
            Me.layoutControl1.Controls.Add(Me.btnCalculateRoutes)
            Me.layoutControl1.Controls.Add(Me.cbeRouteOptimization)
            Me.layoutControl1.Controls.Add(Me.cbeTravelMode)
            Me.layoutControl1.Controls.Add(Me.rtbResults)
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(638, 328)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' teLongitude
            ' 
            Me.teLongitude.Location = New System.Drawing.Point(534, 30)
            Me.teLongitude.Name = "teLongitude"
            Me.teLongitude.Size = New System.Drawing.Size(98, 20)
            Me.teLongitude.StyleController = Me.layoutControl1
            Me.teLongitude.TabIndex = 16
            AddHandler Me.teLongitude.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.OnLongitudeValidating)
            ' 
            ' teLatitude
            ' 
            Me.teLatitude.Location = New System.Drawing.Point(534, 6)
            Me.teLatitude.Name = "teLatitude"
            Me.teLatitude.Size = New System.Drawing.Size(98, 20)
            Me.teLatitude.StyleController = Me.layoutControl1
            Me.teLatitude.TabIndex = 15
            AddHandler Me.teLatitude.Validating, New System.ComponentModel.CancelEventHandler(AddressOf Me.OnLatitudeValidating)
            ' 
            ' btnCalculateRoutes
            ' 
            Me.btnCalculateRoutes.Location = New System.Drawing.Point(439, 102)
            Me.btnCalculateRoutes.Name = "btnCalculateRoutes"
            Me.btnCalculateRoutes.Size = New System.Drawing.Size(193, 22)
            Me.btnCalculateRoutes.StyleController = Me.layoutControl1
            Me.btnCalculateRoutes.TabIndex = 14
            Me.btnCalculateRoutes.Text = "Calculate Routes From Major Roads"
            AddHandler Me.btnCalculateRoutes.Click, New System.EventHandler(AddressOf Me.OnCalculateRoutesClick)
            ' 
            ' cbeRouteOptimization
            ' 
            Me.cbeRouteOptimization.Location = New System.Drawing.Point(534, 78)
            Me.cbeRouteOptimization.Name = "cbeRouteOptimization"
            Me.cbeRouteOptimization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeRouteOptimization.Size = New System.Drawing.Size(98, 20)
            Me.cbeRouteOptimization.StyleController = Me.layoutControl1
            Me.cbeRouteOptimization.TabIndex = 13
            AddHandler Me.cbeRouteOptimization.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnRouteOptimizationSelectedIndexChanged)
            ' 
            ' cbeTravelMode
            ' 
            Me.cbeTravelMode.Location = New System.Drawing.Point(534, 54)
            Me.cbeTravelMode.Name = "cbeTravelMode"
            Me.cbeTravelMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeTravelMode.Size = New System.Drawing.Size(98, 20)
            Me.cbeTravelMode.StyleController = Me.layoutControl1
            Me.cbeTravelMode.TabIndex = 12
            AddHandler Me.cbeTravelMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnTravelModeSelectedIndexChanged)
            ' 
            ' rtbResults
            ' 
            Me.rtbResults.Location = New System.Drawing.Point(439, 144)
            Me.rtbResults.Name = "rtbResults"
            Me.rtbResults.Size = New System.Drawing.Size(193, 178)
            Me.rtbResults.TabIndex = 11
            Me.rtbResults.Text = ""
            ' 
            ' mapControl
            ' 
            Me.mapControl.Layers.Add(Me.imageLayer)
            Me.mapControl.Layers.Add(Me.informationLayer)
            Me.mapControl.Location = New System.Drawing.Point(6, 6)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(429, 316)
            Me.mapControl.TabIndex = 4
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.lciTravelMode, Me.lciRouteOptimization, Me.layoutControlItem4, Me.lciLatitude, Me.lciLongitude})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(638, 328)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(433, 320)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.rtbResults
            Me.layoutControlItem2.Location = New System.Drawing.Point(433, 122)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(197, 198)
            Me.layoutControlItem2.Text = "Results:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' lciTravelMode
            ' 
            Me.lciTravelMode.Control = Me.cbeTravelMode
            Me.lciTravelMode.Location = New System.Drawing.Point(433, 48)
            Me.lciTravelMode.Name = "lciTravelMode"
            Me.lciTravelMode.Size = New System.Drawing.Size(197, 24)
            Me.lciTravelMode.Text = "Travel Mode:"
            Me.lciTravelMode.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' lciRouteOptimization
            ' 
            Me.lciRouteOptimization.Control = Me.cbeRouteOptimization
            Me.lciRouteOptimization.Location = New System.Drawing.Point(433, 72)
            Me.lciRouteOptimization.Name = "lciRouteOptimization"
            Me.lciRouteOptimization.Size = New System.Drawing.Size(197, 24)
            Me.lciRouteOptimization.Text = "RouteOptimization:"
            Me.lciRouteOptimization.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.btnCalculateRoutes
            Me.layoutControlItem4.Location = New System.Drawing.Point(433, 96)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(197, 26)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' lciLatitude
            ' 
            Me.lciLatitude.Control = Me.teLatitude
            Me.lciLatitude.Location = New System.Drawing.Point(433, 0)
            Me.lciLatitude.Name = "lciLatitude"
            Me.lciLatitude.Size = New System.Drawing.Size(197, 24)
            Me.lciLatitude.Text = "Latitude:"
            Me.lciLatitude.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' lciLongitude
            ' 
            Me.lciLongitude.Control = Me.teLongitude
            Me.lciLongitude.Location = New System.Drawing.Point(433, 24)
            Me.lciLongitude.Name = "lciLongitude"
            Me.lciLongitude.Size = New System.Drawing.Size(197, 24)
            Me.lciLongitude.Text = "Longitude:"
            Me.lciLongitude.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(638, 328)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Calculate Routes From Major Roads Example"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.teLongitude.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teLatitude.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeRouteOptimization.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeTravelMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTravelMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciRouteOptimization), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLatitude), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLongitude), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private mapControl As DevExpress.XtraMap.MapControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private rtbResults As System.Windows.Forms.RichTextBox

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private cbeTravelMode As DevExpress.XtraEditors.ComboBoxEdit

        Private lciTravelMode As DevExpress.XtraLayout.LayoutControlItem

        Private imageLayer As DevExpress.XtraMap.ImageLayer

        Private imageProvider As DevExpress.XtraMap.BingMapDataProvider

        Private informationLayer As DevExpress.XtraMap.InformationLayer

        Private bingRouteDataProvider1 As DevExpress.XtraMap.BingRouteDataProvider

        Private cbeRouteOptimization As DevExpress.XtraEditors.ComboBoxEdit

        Private lciRouteOptimization As DevExpress.XtraLayout.LayoutControlItem

        Private btnCalculateRoutes As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private teLatitude As DevExpress.XtraEditors.TextEdit

        Private lciLatitude As DevExpress.XtraLayout.LayoutControlItem

        Private teLongitude As DevExpress.XtraEditors.TextEdit

        Private lciLongitude As DevExpress.XtraLayout.LayoutControlItem

        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace
