Imports KeitaiWebLibrary
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class SignInForm

    Private Sub buttonSignIn_Click(sender As System.Object, e As System.EventArgs) Handles buttonSignIn.Click
        Dim kw As New KeitaiWeb
        CType(Me.Owner, TweenMain).TwitterInstance.keitaiWeb.session = kw.Login(Me.textboxUsername.Text, Me.textboxPassword.Text)
        Dim formatter2 As New BinaryFormatter()
        Dim stream2 As New FileStream("session", FileMode.Create, FileAccess.Write, FileShare.None)
        formatter2.Serialize(stream2, kw.session)
        stream2.Close()

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class