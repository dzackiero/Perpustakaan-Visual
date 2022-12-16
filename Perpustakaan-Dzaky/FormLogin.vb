Public Class FormLogin
    Public Shared Users As Users
    Public Shared Perpustakaan As Perpustakaan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Users = New Users()
        Perpustakaan = New Perpustakaan()

    End Sub
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        Dim username = TextBoxUsername.Text
        Dim password = TextBoxPassword.Text

        Dim authData = Users.CheckAuthDatabase(username, password)

        If authData.Count() > 0 Then
            Users.GSusername = authData(1)
            Perpustakaan.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password")
        End If
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Dim FormRegister = New FormRegister()
        FormRegister.Show()
    End Sub
End Class