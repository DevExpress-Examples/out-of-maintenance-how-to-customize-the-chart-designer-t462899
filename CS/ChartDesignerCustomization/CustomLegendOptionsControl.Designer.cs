namespace CrosshairOptions {
    partial class CustomLegendOptionsControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.cbeVerticalAlignment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ceVisible = new DevExpress.XtraEditors.CheckEdit();
            this.cbeHorizontalAlignment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciVerticalAlignment = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.cbeVerticalAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceVisible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeHorizontalAlignment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVerticalAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // cbeVerticalAlignment
            // 
            this.cbeVerticalAlignment.Location = new System.Drawing.Point(113, 36);
            this.cbeVerticalAlignment.Name = "cbeVerticalAlignment";
            this.cbeVerticalAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeVerticalAlignment.Size = new System.Drawing.Size(454, 20);
            this.cbeVerticalAlignment.StyleController = this.layoutControl1;
            this.cbeVerticalAlignment.TabIndex = 0;
            this.cbeVerticalAlignment.SelectedIndexChanged += OnVerticalAlignmentChanged;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ceVisible);
            this.layoutControl1.Controls.Add(this.cbeVerticalAlignment);
            this.layoutControl1.Controls.Add(this.cbeHorizontalAlignment);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(579, 613);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ceVisible
            // 
            this.ceVisible.Location = new System.Drawing.Point(12, 60);
            this.ceVisible.Name = "ceVisible";
            this.ceVisible.Properties.AllowGrayed = true;
            this.ceVisible.Properties.Caption = "Visible";
            this.ceVisible.Size = new System.Drawing.Size(555, 19);
            this.ceVisible.StyleController = this.layoutControl1;
            this.ceVisible.TabIndex = 4;
            this.ceVisible.CheckStateChanged += OnVisibilityChanged;
            // 
            // cbeHorizontalAlignment
            // 
            this.cbeHorizontalAlignment.Location = new System.Drawing.Point(113, 12);
            this.cbeHorizontalAlignment.Name = "cbeHorizontalAlignment";
            this.cbeHorizontalAlignment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeHorizontalAlignment.Size = new System.Drawing.Size(454, 20);
            this.cbeHorizontalAlignment.StyleController = this.layoutControl1;
            this.cbeHorizontalAlignment.TabIndex = 1;
            this.cbeHorizontalAlignment.SelectedIndexChanged += OnHorizontalAlignmentChanged;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.lciVerticalAlignment,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(579, 613);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbeHorizontalAlignment;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(559, 24);
            this.layoutControlItem1.Text = "Horizontal Alignment";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(98, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 71);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(559, 522);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciVerticalAlignment
            // 
            this.lciVerticalAlignment.Control = this.cbeVerticalAlignment;
            this.lciVerticalAlignment.Location = new System.Drawing.Point(0, 24);
            this.lciVerticalAlignment.Name = "lciVerticalAlignment";
            this.lciVerticalAlignment.Size = new System.Drawing.Size(559, 24);
            this.lciVerticalAlignment.Text = "Vertical Alignment";
            this.lciVerticalAlignment.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceVisible;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(559, 23);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(579, 613);
            ((System.ComponentModel.ISupportInitialize)(this.cbeVerticalAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceVisible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeHorizontalAlignment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVerticalAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbeVerticalAlignment;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit ceVisible;
        private DevExpress.XtraEditors.ComboBoxEdit cbeHorizontalAlignment;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciVerticalAlignment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}
