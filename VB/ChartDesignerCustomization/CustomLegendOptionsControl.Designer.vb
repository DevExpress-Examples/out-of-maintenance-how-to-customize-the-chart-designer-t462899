Namespace CrosshairOptions
    Partial Friend Class CustomLegendOptionsControl
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

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.cbeVerticalAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.cbeHorizontalAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.lciVerticalAlignment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.cbeVerticalAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.ceVisible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbeHorizontalAlignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciVerticalAlignment, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' cbeVerticalAlignment
            ' 
            Me.cbeVerticalAlignment.Location = New System.Drawing.Point(113, 36)
            Me.cbeVerticalAlignment.Name = "cbeVerticalAlignment"
            Me.cbeVerticalAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeVerticalAlignment.Size = New System.Drawing.Size(454, 20)
            Me.cbeVerticalAlignment.StyleController = Me.layoutControl1
            Me.cbeVerticalAlignment.TabIndex = 0
            AddHandler Me.cbeVerticalAlignment.SelectedIndexChanged, AddressOf Me.OnVerticalAlignmentChanged
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.ceVisible)
            Me.layoutControl1.Controls.Add(Me.cbeVerticalAlignment)
            Me.layoutControl1.Controls.Add(Me.cbeHorizontalAlignment)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(579, 613)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceVisible
            ' 
            Me.ceVisible.Location = New System.Drawing.Point(12, 60)
            Me.ceVisible.Name = "ceVisible"
            Me.ceVisible.Properties.AllowGrayed = True
            Me.ceVisible.Properties.Caption = "Visible"
            Me.ceVisible.Size = New System.Drawing.Size(555, 19)
            Me.ceVisible.StyleController = Me.layoutControl1
            Me.ceVisible.TabIndex = 4
            AddHandler Me.ceVisible.CheckStateChanged, AddressOf Me.OnVisibilityChanged
            ' 
            ' cbeHorizontalAlignment
            ' 
            Me.cbeHorizontalAlignment.Location = New System.Drawing.Point(113, 12)
            Me.cbeHorizontalAlignment.Name = "cbeHorizontalAlignment"
            Me.cbeHorizontalAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeHorizontalAlignment.Size = New System.Drawing.Size(454, 20)
            Me.cbeHorizontalAlignment.StyleController = Me.layoutControl1
            Me.cbeHorizontalAlignment.TabIndex = 1
            AddHandler Me.cbeHorizontalAlignment.SelectedIndexChanged, AddressOf Me.OnHorizontalAlignmentChanged
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.emptySpaceItem1, Me.lciVerticalAlignment, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(579, 613)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbeHorizontalAlignment
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(559, 24)
            Me.layoutControlItem1.Text = "Horizontal Alignment"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 71)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(559, 522)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' lciVerticalAlignment
            ' 
            Me.lciVerticalAlignment.Control = Me.cbeVerticalAlignment
            Me.lciVerticalAlignment.Location = New System.Drawing.Point(0, 24)
            Me.lciVerticalAlignment.Name = "lciVerticalAlignment"
            Me.lciVerticalAlignment.Size = New System.Drawing.Size(559, 24)
            Me.lciVerticalAlignment.Text = "Vertical Alignment"
            Me.lciVerticalAlignment.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceVisible
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(559, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' UserControl1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "UserControl1"
            Me.Size = New System.Drawing.Size(579, 613)
            DirectCast(Me.cbeVerticalAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.ceVisible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbeHorizontalAlignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciVerticalAlignment, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private cbeVerticalAlignment As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private ceVisible As DevExpress.XtraEditors.CheckEdit
        Private cbeHorizontalAlignment As DevExpress.XtraEditors.ComboBoxEdit
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
        Private lciVerticalAlignment As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
