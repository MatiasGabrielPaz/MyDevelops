
Public Class Form1
    <System.Runtime.InteropServices.DllImport("user32")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function
    Public Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal X As Integer, ByVal Y As Integer)
    Dim Count As Integer = 0
    Declare Sub mouse_event Lib "user32" Alias "mouse_event" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    Private Const MouseClickUp = &H2
    Private Const MouseClickDown = &H4
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Windows.Forms.Cursor.Position = New Point(Windows.Forms.Cursor.Position.X, Windows.Forms.Cursor.Position.Y)
        LinkLabel1.Text = Windows.Forms.Cursor.Position.X
        LinkLabel2.Text = Windows.Forms.Cursor.Position.Y
        Timer1.Interval = NumericUpDown1.Value
        Windows.Forms.Cursor.Position = New Point(TextBox1.Text, TextBox2.Text)
        mouse_event(MouseClickUp, 0, 0, 0, 0)
        mouse_event(MouseClickDown, 0, 0, 0, 0)

        mouse_event(MouseClickUp, 0, 0, 0, 0)
        mouse_event(MouseClickDown, 0, 0, 0, 0)

        mouse_event(MouseClickUp, 0, 0, 0, 0)
        mouse_event(MouseClickDown, 0, 0, 0, 0)
       



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim Tecla As Boolean
        Tecla = GetAsyncKeyState(Keys.F1)
        If Tecla = True Then Timer1.Start()
        Dim Tecla1 As Boolean
        Tecla1 = GetAsyncKeyState(Keys.F2)
        If Tecla1 = True Then Timer1.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim SetPoint As Boolean
        SetPoint = GetAsyncKeyState(Keys.F3)
        If SetPoint = True Then TextBox1.Text = MousePosition.X : TextBox2.Text = MousePosition.Y
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Start[F1] Stop[F2] Mouse position reference [F3] ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label4.Text = Label4.Text + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Text = 0
    End Sub

   
    
End Class
