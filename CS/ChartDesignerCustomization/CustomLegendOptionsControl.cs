#region #CustomOptionsControl
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraCharts.Designer;
using System;
using System.Windows.Forms;

namespace CrosshairOptions {
    partial class CustomLegendOptionsControl : CustomOptionsControl {
        bool updateStarted = false;

        LegendModel LegendModel { get { return (LegendModel)this.Model; } }

        public CustomLegendOptionsControl(ChartElementModel model) : base(model) {
            InitializeComponent();
            if(!(model is LegendModel)) throw new ArgumentException("The model must have the LegendModel type.");
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            var horizontalAlignments = Enum.GetValues(typeof(LegendAlignmentHorizontal));
            cbeHorizontalAlignment.Properties.Items.AddRange(horizontalAlignments);
            var verticvalAlignments = Enum.GetValues(typeof(LegendAlignmentVertical));
            cbeVerticalAlignment.Properties.Items.AddRange(verticvalAlignments);

            UpdateView();
        }

        public override void OnModelUpdated() {
            UpdateView();
        }

        protected void UpdateView() {
            updateStarted = true;
            cbeHorizontalAlignment.SelectedItem = LegendModel.AlignmentHorizontal;
            cbeVerticalAlignment.SelectedItem = LegendModel.AlignmentVertical;
            ceVisible.CheckState = DefaultBooleanToCheckState(LegendModel.Visibility);
            updateStarted = false;
        }

        protected void OnVerticalAlignmentChanged(object sender, EventArgs args) {
            if(!updateStarted)
                LegendModel.AlignmentVertical = (LegendAlignmentVertical)cbeVerticalAlignment.SelectedItem;
        }

        protected void OnHorizontalAlignmentChanged(object sender, EventArgs args) {
            if(!updateStarted)
                LegendModel.AlignmentHorizontal = (LegendAlignmentHorizontal)cbeHorizontalAlignment.SelectedItem;
        }

        protected void OnVisibilityChanged(object sender, EventArgs args) {
            if(!updateStarted)
                LegendModel.Visibility = CheckStateToDefaultBoolean(ceVisible.CheckState);
        }

        protected static CheckState DefaultBooleanToCheckState(DefaultBoolean b) {
            switch(b) {
                case DefaultBoolean.Default: return CheckState.Indeterminate;
                case DefaultBoolean.False: return CheckState.Unchecked;
                case DefaultBoolean.True: return CheckState.Checked;
                default: throw new Exception("The specified DefaultBoolean value is not supported.");
            }
        }

        protected static DefaultBoolean CheckStateToDefaultBoolean(CheckState b) {
            switch(b) {
                case CheckState.Indeterminate: return DefaultBoolean.Default;
                case CheckState.Unchecked: return DefaultBoolean.False;
                case CheckState.Checked: return DefaultBoolean.True;
                default: throw new Exception("The specified CheckState value is not supported.");
            }
        }

    }
}
#endregion #CustomOptionsControl