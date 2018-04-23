using DevExpress.XtraCharts.Designer;

namespace CrosshairOptions {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            #region #DesignerCustomization
            ChartDesigner designer = new ChartDesigner(chartControl1);
            designer.AddElementMenuOptions.ShowAddSeriesMenuItem = false;
            designer.AddElementMenuOptions.ShowAddSeriesTitleMenuItem = false;
            designer.Caption = "Chart Designer";
            designer.EnableLargeDataSetWarning = true;

            designer.ChartElementHighlighting += OnChartElementHighlighting;
            designer.ChartElementSelecting += OnChartElementSelecting;
            designer.ChartStructureUpdating += OnChartStructureUpdating;

            designer.ShowDialog();
            #endregion #DesignerCustomization
        }

        #region #BehaviorEvents
        // The ChartStructureUpdating event allows for modifying chart model.
        private void OnChartStructureUpdating(object sender, ChartStructureChangingEventArgs e) {
            e.ChartModel.Series.AllowAddChild = false;
            foreach(SeriesModel seriesModel in e.ChartModel.Series) { 
                seriesModel.AllowChangeVisibility = false;
                seriesModel.AllowRemove = false;
            }
            e.ChartModel.Legends.ShowInStructureControl = false;
        }

        // The ChartElementSelecting event allows for preventing element selection or
        // modifying the selecting element edit controls.
        private void OnChartElementSelecting(object sender, ChartElementSelectingEventArgs e) {
            if(e.ElementModel is SeriesBaseModel) {
                e.Cancel = true;
                return;
            }
            if (e.ElementModel is LegendModel) {
                e.ShowPropertiesTab = false;
                e.ShowDataTab = false;
                e.CustomOptionsControl = new CustomLegendOptionsControl(e.ElementModel); 
            }
        }

        // The ChartElementSelecting event allows for preventing element highlight.
        private void OnChartElementHighlighting(object sender, ChartElementHighlightingEventArgs e) {
            SeriesBaseModel series = e.ElementModel as SeriesBaseModel;
            if(series == null) {
                e.Cancel = true;
                return;
            }

        }
        #endregion #BehaviorEvents
    }
}
