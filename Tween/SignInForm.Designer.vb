<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignInForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textboxPassword = New System.Windows.Forms.TextBox()
        Me.textboxUsername = New System.Windows.Forms.TextBox()
        Me.buttonSignIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(13, 47)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(56, 12)
        Me.label2.TabIndex = 11
        Me.label2.Text = "Password:"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(13, 15)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(103, 12)
        Me.label1.TabIndex = 10
        Me.label1.Text = "Username or email:"
        '
        'textboxPassword
        '
        Me.textboxPassword.Location = New System.Drawing.Point(122, 44)
        Me.textboxPassword.Name = "textboxPassword"
        Me.textboxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.textboxPassword.Size = New System.Drawing.Size(152, 19)
        Me.textboxPassword.TabIndex = 9
        '
        'textboxUsername
        '
        Me.textboxUsername.Location = New System.Drawing.Point(122, 12)
        Me.textboxUsername.Name = "textboxUsername"
        Me.textboxUsername.Size = New System.Drawing.Size(152, 19)
        Me.textboxUsername.TabIndex = 8
        '
        'buttonSignIn
        '
        Me.buttonSignIn.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.buttonSignIn.Location = New System.Drawing.Point(199, 69)
        Me.buttonSignIn.Name = "buttonSignIn"
        Me.buttonSignIn.Size = New System.Drawing.Size(75, 23)
        Me.buttonSignIn.TabIndex = 7
        Me.buttonSignIn.Text = "Sign in"
        Me.buttonSignIn.UseVisualStyleBackColor = True
        '
        'SignInForm
        '
        Me.AcceptButton = Me.buttonSignIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 105)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textboxPassword)
        Me.Controls.Add(Me.textboxUsername)
        Me.Controls.Add(Me.buttonSignIn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignInForm"
        Me.Text = "Sign in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents textboxPassword As System.Windows.Forms.TextBox
    Private WithEvents textboxUsername As System.Windows.Forms.TextBox
    Private WithEvents buttonSignIn As System.Windows.Forms.Button
End Class
