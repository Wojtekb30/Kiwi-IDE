Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        prefixbox.Text = My.Settings.pythonprefix
        Me.ShowIcon = True
        Dim tabela As String() = My.Settings.lastprojects.Split(" ")
        For Each i As String In tabela
            If Not i = "" Then
                CheckedListBox1.Items.Add(i)
            End If
        Next





    End Sub

    Private Sub prefixbox_TextChanged(sender As Object, e As EventArgs) Handles prefixbox.TextChanged
        My.Settings.pythonprefix = prefixbox.Text.Trim()
    End Sub

    Private Sub browseprefixfilebtn_Click(sender As Object, e As EventArgs) Handles browseprefixfilebtn.Click
        FileDialog1.ShowDialog()
        prefixbox.Text = FileDialog1.FileName
    End Sub

    Private Sub testbtn_Click(sender As Object, e As EventArgs) Handles testbtn.Click
        MsgBox("If the Python command/interpreter file is correct, Python version will appear in next message window [running: {prefix} --version]")
        Dim MyProcess As New Process
        MyProcess.StartInfo.FileName = "cmd.exe"
        MyProcess.StartInfo.Arguments = " /C " + prefixbox.Text.Trim() + " --version"
        MyProcess.StartInfo.UseShellExecute = False
        MyProcess.StartInfo.RedirectStandardOutput = True
        MyProcess.Start()
        Dim strMyBuffer As String = ""
        strMyBuffer = MyProcess.StandardOutput.ReadToEnd
        MyProcess.WaitForExit()

        MsgBox(strMyBuffer)


    End Sub


    Function IsValidFileNameOrPath(ByVal name As String) As Boolean
        ' Determines if the name is Nothing.
        If name Is Nothing Then
            Return False
        End If

        ' Determines if there are bad characters in the name.
        For Each badChar As Char In System.IO.Path.GetInvalidPathChars
            If InStr(name, badChar) > 0 Then
                Return False
            End If
        Next

        If InStr(name, " ") > 0 Then
            Return False
        End If

        ' The name passes basic validation.
        Return True
    End Function


    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        FolderBrowserDialog1.SelectedPath = ""
        FolderBrowserDialog1.ShowDialog()
        Dim nazwa As String = nametextbox.Text.ToString
        nazwa = nazwa.Trim()
        If FolderBrowserDialog1.SelectedPath.ToString.Length = 0 Then
            MsgBox("Error: no file path was chosen.")
        ElseIf nazwa = "" Then
            MsgBox("Error: no project name was chosen.")
        Else
            nazwa = FolderBrowserDialog1.SelectedPath.ToString + "\" + nazwa

            If IsValidFileNameOrPath(nazwa) = False Then
                MsgBox("Path " + nazwa + " is invalid. Make sure it does not contain spaces or other characters not allowed by Windows filesystem.")
            Else
                Form2.Close()
                My.Settings.lastdir = nazwa
                Try
                    My.Computer.FileSystem.CreateDirectory(nazwa)

                    System.IO.File.Create(nazwa + "\main.py").Dispose()
                    My.Computer.FileSystem.WriteAllText(nazwa + "\main.py", "from kivy.app import App
from kivy.uix.label import Label

class MainApp(App):
	def build(self):
		label = Label(text='Hello world!',
		size_hint=(.5, .5),
		pos_hint={'center_x': .5, 'center_y': .5})
		return label

if __name__ == '__main__':
	app = MainApp()
	app.run()

#if this example code works, after running; window with 'Hello world' will appear.", False)
                    My.Settings.lastprojects = My.Settings.lastprojects + " " + nazwa
                    Form2.Show()
                    Me.Close()


                Catch ex As Exception
                    MsgBox("Error: " + ex.ToString)
                End Try



            End If
        End If

    End Sub

    Private Sub loadbtn_Click(sender As Object, e As EventArgs) Handles loadbtn.Click
        If Not CheckedListBox1.CheckedItems.Count = 1 Then
            MsgBox("Choose (only) one project to load.")
        Else
            Form2.Close()
            My.Settings.lastdir = CheckedListBox1.CheckedItems.Item(0).ToString()
            Form2.Show()
            Me.Close()
        End If
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        CheckedListBox1.Items.Clear()
        My.Settings.lastprojects = ""
    End Sub
End Class
