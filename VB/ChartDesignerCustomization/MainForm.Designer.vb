Namespace CrosshairOptions
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
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(1950R, New Object() { (DirectCast(546R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(1970R, New Object() { (DirectCast(656R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(1990R, New Object() { (DirectCast(721R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(2010R, New Object() { (DirectCast(728R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(2030R, New Object() { (DirectCast(704R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(2050R, New Object() { (DirectCast(650R, Object))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(1960R, New Object() { (DirectCast(417R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(1980R, New Object() { (DirectCast(614R, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(2000R, New Object() { (DirectCast(836R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(2020R, New Object() { (DirectCast(1027R, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(2040R, New Object() { (DirectCast(1178R, Object))})
            Dim lineSeriesView2 As New DevExpress.XtraCharts.LineSeriesView()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.rgChart = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.rpgDesigner = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.CrosshairOptions.ValueSelectionMode = DevExpress.XtraCharts.CrosshairValueSelectionMode.Value
            Me.chartControl1.DataBindings = Nothing
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V:F0}"
            xyDiagram1.AxisY.Title.Text = "Population mid-year, millions"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.EnableAxisYScrolling = True
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Legend.Title.Text = "GDP by Year"
            Me.chartControl1.Location = New System.Drawing.Point(0, 146)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Office"
            series1.Name = "Europe"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6})
            series1.View = lineSeriesView1
            series2.Name = "Americas"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11})
            series2.View = lineSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2}
            Me.chartControl1.Size = New System.Drawing.Size(1278, 552)
            Me.chartControl1.TabIndex = 0
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 2
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.rgChart})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(1278, 146)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Run Designer"
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.ImageOptions.SvgImage = (DirectCast(resources.GetObject("barButtonItem1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage))
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' rgChart
            ' 
            Me.rgChart.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgDesigner})
            Me.rgChart.Name = "rgChart"
            Me.rgChart.Text = "Chart"
            ' 
            ' rpgDesigner
            ' 
            Me.rpgDesigner.ItemLinks.Add(Me.barButtonItem1)
            Me.rpgDesigner.Name = "rpgDesigner"
            Me.rpgDesigner.Text = "Designer"
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 698)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1278, 21)
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "ribbonPage2"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1278, 719)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "Main Form"
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private chartControl1 As DevExpress.XtraCharts.ChartControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private rgChart As DevExpress.XtraBars.Ribbon.RibbonPage
        Private rpgDesigner As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
    End Class
End Namespace

