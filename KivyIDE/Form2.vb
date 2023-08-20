Public Class Form2

    Function polecenie(ByVal komenda As String) As String
        Dim MyProcess As New Process
        MyProcess.StartInfo.FileName = "cmd.exe"
        MyProcess.StartInfo.Arguments = " /C " + komenda
        MyProcess.StartInfo.UseShellExecute = False
        MyProcess.StartInfo.RedirectStandardOutput = True
        MyProcess.Start()
        Dim strMyBuffer As String = ""
        strMyBuffer = MyProcess.StandardOutput.ReadToEnd
        MyProcess.WaitForExit()
        Return strMyBuffer
    End Function

    Function proces(ByVal komenda As String) As String
        Try

            Dim MyProcess As New Process
            MyProcess.StartInfo.FileName = "cmd.exe"
            MyProcess.StartInfo.Arguments = komenda
            MyProcess.StartInfo.UseShellExecute = True
            MyProcess.Start()
            MyProcess.WaitForExit()
            Return "Finished Terminal script execution successfully."
        Catch ex As Exception
            Return "Error: " + ex.ToString
        End Try

    End Function


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowIcon = True
        ComboBox1.SelectedIndex = 1
        TextBox1.AcceptsTab = True
        Dim sciezka As String = My.Settings.lastdir
        If System.IO.Directory.Exists(sciezka) Then

            If Not IO.File.Exists(sciezka + "\main.py") Then
                MsgBox("Error loading (no main.py).")
                Close()
            Else
                TextBox1.Text = IO.File.ReadAllText(sciezka + "\main.py")
            End If



            If Not System.IO.Directory.Exists(sciezka + "\kivypywe") Then
                MsgBox("Now Python Virtual Enviroinment will be created and necessary pip packages downloaded. Make sure you are online.")
                Dim m As String = polecenie(My.Settings.pythonprefix + " -m pip install virtualenv")
                MsgBox("Virtualenv install output: " + m)
                m = polecenie(My.Settings.pythonprefix + " -m virtualenv " + sciezka + "\kivypywe")
                MsgBox("Venv output: " + m)
                Dim cudzyslow As String = Chr(34)
                Dim wynik As String = proces(" /C cd " + sciezka + " & .\kivypywe\Scripts\Activate.bat & pip install " + cudzyslow + "kivy[base]" + cudzyslow + " kivy_examples buildozer pyinstaller & deactivate")
                MsgBox(wynik)


            End If





        Else
            MsgBox("Error loading (no folder " + sciezka + ")")
            Close()

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If autosavecheck.Checked = True Then
            My.Computer.FileSystem.WriteAllText(My.Settings.lastdir + "\main.py", TextBox1.Text, False)
        End If

    End Sub

    Private Sub runbtn_Click(sender As Object, e As EventArgs) Handles runbtn.Click
        Dim wynik As String = proces(" /C cd " + My.Settings.lastdir + " & .\kivypywe\Scripts\Activate.bat & python main.py & deactivate & echo done; & pause")
        MsgBox(wynik)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Function kopiujdopodfolderu(ByVal podfolder As String) As Boolean
        Dim sciezka As String = My.Settings.lastdir
        If System.IO.Directory.Exists(sciezka + "\" + podfolder) Then
            System.IO.Directory.Delete(sciezka + "\" + podfolder, True)
        End If
        My.Computer.FileSystem.CreateDirectory(sciezka + "\" + podfolder)
        IO.File.Copy(sciezka + "\main.py", sciezka + "\" + podfolder + "\main.py")
        Return True
    End Function

    Private Sub compilebtn_Click(sender As Object, e As EventArgs) Handles compilebtn.Click
        Dim indeks As Int16 = ComboBox1.SelectedIndex
        If indeks = 0 Then
            kopiujdopodfolderu("WindowsCompile")
            MsgBox(proces(" /C cd " + My.Settings.lastdir + " & .\kivypywe\Scripts\Activate.bat & cd " + My.Settings.lastdir + "\WindowsCompile & python -m PyInstaller main.py & deactivate"))
            Process.Start(My.Settings.lastdir + "\WindowsCompile")
            MsgBox("Done! The .exe will be in the dist folder.")
        ElseIf indeks = 1 Then
            kopiujdopodfolderu("WindowsCompileOneFile")
            MsgBox(proces(" /C cd " + My.Settings.lastdir + " & .\kivypywe\Scripts\Activate.bat & cd " + My.Settings.lastdir + "\WindowsCompileOneFile & python -m PyInstaller --onefile main.py & deactivate"))
            Process.Start(My.Settings.lastdir + "\WindowsCompileOneFile")
            MsgBox("Done! The .exe will be in the dist folder.")
        ElseIf indeks = 2 Then
            MsgBox("Please follow these instructions, the instructions and folder of your Python program will open now.")
            Process.Start("https://buildozer.readthedocs.io/en/latest/installation.html#targeting-android")
            Process.Start(My.Settings.lastdir)

        Else
            MsgBox("Coming soon!")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/Wojtekb30/Kiwi-IDE")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("https://birdtech.pl/manuals/kiwiide-v0-1")
    End Sub
End Class