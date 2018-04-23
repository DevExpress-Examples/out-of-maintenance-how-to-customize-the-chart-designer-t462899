#Region "#CustomOptionsControl"
Imports DevExpress.Utils
Imports DevExpress.XtraCharts
Imports DevExpress.XtraCharts.Designer
Imports System
Imports System.Windows.Forms

Namespace CrosshairOptions
    Partial Friend Class CustomLegendOptionsControl
        Inherits CustomOptionsControl

        Private updateStarted As Boolean = False

        Private ReadOnly Property LegendModel() As LegendModel
            Get
                Return CType(Me.Model, LegendModel)
            End Get
        End Property

        Public Sub New(ByVal model As ChartElementModel)
            MyBase.New(model)
            InitializeComponent()
            If Not(TypeOf model Is LegendModel) Then
                Throw New ArgumentException("The model must have the LegendModel type.")
            End If
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            Dim horizontalAlignments = System.Enum.GetValues(GetType(LegendAlignmentHorizontal))
            cbeHorizontalAlignment.Properties.Items.AddRange(horizontalAlignments)
            Dim verticvalAlignments = System.Enum.GetValues(GetType(LegendAlignmentVertical))
            cbeVerticalAlignment.Properties.Items.AddRange(verticvalAlignments)

            UpdateView()
        End Sub

        Public Overrides Sub OnModelUpdated()
            UpdateView()
        End Sub

        Protected Sub UpdateView()
            updateStarted = True
            cbeHorizontalAlignment.SelectedItem = LegendModel.AlignmentHorizontal
            cbeVerticalAlignment.SelectedItem = LegendModel.AlignmentVertical
            ceVisible.CheckState = DefaultBooleanToCheckState(LegendModel.Visibility)
            updateStarted = False
        End Sub

        Protected Sub OnVerticalAlignmentChanged(ByVal sender As Object, ByVal args As EventArgs)
            If Not updateStarted Then
                LegendModel.AlignmentVertical = CType(cbeVerticalAlignment.SelectedItem, LegendAlignmentVertical)
            End If
        End Sub

        Protected Sub OnHorizontalAlignmentChanged(ByVal sender As Object, ByVal args As EventArgs)
            If Not updateStarted Then
                LegendModel.AlignmentHorizontal = CType(cbeHorizontalAlignment.SelectedItem, LegendAlignmentHorizontal)
            End If
        End Sub

        Protected Sub OnVisibilityChanged(ByVal sender As Object, ByVal args As EventArgs)
            If Not updateStarted Then
                LegendModel.Visibility = CheckStateToDefaultBoolean(ceVisible.CheckState)
            End If
        End Sub

        Protected Shared Function DefaultBooleanToCheckState(ByVal b As DefaultBoolean) As CheckState
            Select Case b
                Case DefaultBoolean.Default
                    Return CheckState.Indeterminate
                Case DefaultBoolean.False
                    Return CheckState.Unchecked
                Case DefaultBoolean.True
                    Return CheckState.Checked
                Case Else
                    Throw New Exception("The specified DefaultBoolean value is not supported.")
            End Select
        End Function

        Protected Shared Function CheckStateToDefaultBoolean(ByVal b As CheckState) As DefaultBoolean
            Select Case b
                Case CheckState.Indeterminate
                    Return DefaultBoolean.Default
                Case CheckState.Unchecked
                    Return DefaultBoolean.False
                Case CheckState.Checked
                    Return DefaultBoolean.True
                Case Else
                    Throw New Exception("The specified CheckState value is not supported.")
            End Select
        End Function

    End Class
End Namespace
#End Region ' #CustomOptionsControl