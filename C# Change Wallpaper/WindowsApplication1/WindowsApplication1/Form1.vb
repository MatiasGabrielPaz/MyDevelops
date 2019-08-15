Public Class Form1

    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    'Declare two constant
    Private Const SETDESKWALLPAPER = 20
    Private Const UPDATEINIFILE = &H1



    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        Dim dlg As New OpenFileDialog
        dlg.Title = "Choose Desktop background image"
        dlg.Filter = ""
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            TextBoxLocation.Text = dlg.FileName
            PictureBox1.BackgroundImage = Image.FromFile(dlg.FileName)
            PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        End If

    End Sub



    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        SystemParametersInfo(SETDESKWALLPAPER, 0, TextBoxLocation.Text, UPDATEINIFILE)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
