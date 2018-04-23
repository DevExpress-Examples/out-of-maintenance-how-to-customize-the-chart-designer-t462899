Imports DevExpress.XtraCharts.Designer

Namespace CrosshairOptions
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()

        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
'            #Region "#DesignerCustomization"
            Dim designer As New ChartDesigner(chartControl1)
            designer.AddElementMenuOptions.ShowAddSeriesMenuItem = False
            designer.AddElementMenuOptions.ShowAddSeriesTitleMenuItem = False
            designer.Caption = "Chart Designer"
            designer.EnableLargeDataSetWarning = True

            AddHandler designer.ChartElementHighlighting, AddressOf OnChartElementHighlighting
            AddHandler designer.ChartElementSelecting, AddressOf OnChartElementSelecting
            AddHandler designer.ChartStructureUpdating, AddressOf OnChartStructureUpdating

            designer.ShowDialog()
'            #End Region ' #DesignerCustomization
        End Sub

        #Region "#BehaviorEvents"
        ' The ChartStructureUpdating event allows for modifying chart model.
        Private Sub OnChartStructureUpdating(ByVal sender As Object, ByVal e As ChartStructureChangingEventArgs)
            e.ChartModel.Series.AllowAddChild = False
            For Each seriesModel As SeriesModel In e.ChartModel.Series
                seriesModel.AllowChangeVisibility = False
                seriesModel.AllowRemove = False
            Next seriesModel
            e.ChartModel.Legends.ShowInStructureControl = False
        End Sub

        ' The ChartElementSelecting event allows for preventing element selection or
        ' modifying the selecting element edit controls.
        Private Sub OnChartElementSelecting(ByVal sender As Object, ByVal e As ChartElementSelectingEventArgs)
            If TypeOf e.ElementModel Is SeriesBaseModel Then
                e.Cancel = True
                Return
            End If
            If TypeOf e.ElementModel Is LegendModel Then
                e.ShowPropertiesTab = False
                e.ShowDataTab = False
                e.CustomOptionsControl = New CustomLegendOptionsControl(e.ElementModel)
            End If
        End Sub

        ' The ChartElementSelecting event allows for preventing element highlight.
        Private Sub OnChartElementHighlighting(ByVal sender As Object, ByVal e As ChartElementHighlightingEventArgs)
            Dim series As SeriesBaseModel = TryCast(e.ElementModel, SeriesBaseModel)
            If series Is Nothing Then
                e.Cancel = True
                Return
            End If

        End Sub
        #End Region ' #BehaviorEvents
    End Class
End Namespace
