Imports DevExpress.XtraEditors

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEdit3)
        Me.GroupControl1.Controls.Add(Me.CheckEdit2)
        Me.GroupControl1.Controls.Add(Me.CheckEdit1)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 16)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(216, 160)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "GroupControl1"
        '
        'CheckEdit3
        '
        Me.CheckEdit3.Enabled = False
        Me.CheckEdit3.Location = New System.Drawing.Point(16, 112)
        Me.CheckEdit3.Name = "CheckEdit3"
        Me.CheckEdit3.Properties.Caption = "Choice C"
        Me.CheckEdit3.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CheckEdit3.Properties.RadioGroupIndex = 1
        Me.CheckEdit3.Size = New System.Drawing.Size(128, 19)
        Me.CheckEdit3.TabIndex = 2
        Me.CheckEdit3.TabStop = False
        '
        'CheckEdit2
        '
        Me.CheckEdit2.Location = New System.Drawing.Point(16, 64)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Choice B" & Global.Microsoft.VisualBasic.ChrW(10) & "(recommended)"
        Me.CheckEdit2.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CheckEdit2.Properties.RadioGroupIndex = 1
        Me.CheckEdit2.Size = New System.Drawing.Size(128, 31)
        Me.CheckEdit2.TabIndex = 1
        Me.CheckEdit2.TabStop = False
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(16, 24)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Choice A"
        Me.CheckEdit1.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
        Me.CheckEdit1.Properties.RadioGroupIndex = 1
        Me.CheckEdit1.Size = New System.Drawing.Size(128, 19)
        Me.CheckEdit1.TabIndex = 0
        Me.CheckEdit1.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(256, 24)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(168, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Get Selected Index"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(256, 56)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(120, 23)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "Set Selected Index"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(384, 56)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.Mask.EditMask = "d"
        Me.SpinEdit1.Size = New System.Drawing.Size(40, 20)
        Me.SpinEdit1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(436, 194)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CheckEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ReadOnly Property RadioButtons() As CheckEdit()
        Get
            Dim buttons As CheckEdit()
            ReDim buttons(3 - 1)
            buttons(0) = CheckEdit1
            buttons(1) = CheckEdit2
            buttons(2) = CheckEdit3
            Return buttons
        End Get
    End Property

    Property RadioGroupSelectedIndex() As Integer
        Get
            Dim I As Integer
            For I = 0 To RadioButtons.Length - 1
                If RadioButtons(I).Checked Then
                    Return I
                End If
            Next
            Return -1
        End Get
        Set(ByVal Value As Integer)
            Dim currentIndex As Integer = RadioGroupSelectedIndex
            If currentIndex = Value Then Return
            If Value < -1 Or Value >= RadioButtons.Length Then Return
            If currentIndex <> -1 Then
                RadioButtons(currentIndex).Checked = False
            End If
            If Value <> -1 Then
                RadioButtons(Value).Checked = True
            End If
        End Set
    End Property

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        MessageBox.Show(RadioGroupSelectedIndex.ToString())
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        RadioGroupSelectedIndex = SpinEdit1.Value
    End Sub
End Class
