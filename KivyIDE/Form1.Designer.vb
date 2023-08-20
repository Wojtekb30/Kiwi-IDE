<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.prefixbox = New System.Windows.Forms.TextBox()
        Me.FileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.browseprefixfilebtn = New System.Windows.Forms.Button()
        Me.testbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loadbtn = New System.Windows.Forms.Button()
        Me.newbtn = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.nametextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'prefixbox
        '
        Me.prefixbox.Location = New System.Drawing.Point(12, 502)
        Me.prefixbox.Name = "prefixbox"
        Me.prefixbox.Size = New System.Drawing.Size(774, 38)
        Me.prefixbox.TabIndex = 0
        '
        'FileDialog1
        '
        Me.FileDialog1.DefaultExt = "exe"
        Me.FileDialog1.FileName = "python.exe"
        Me.FileDialog1.Title = "Choose Python interpreter"
        '
        'browseprefixfilebtn
        '
        Me.browseprefixfilebtn.Enabled = False
        Me.browseprefixfilebtn.Location = New System.Drawing.Point(812, 502)
        Me.browseprefixfilebtn.Name = "browseprefixfilebtn"
        Me.browseprefixfilebtn.Size = New System.Drawing.Size(217, 64)
        Me.browseprefixfilebtn.TabIndex = 1
        Me.browseprefixfilebtn.Text = "File browser"
        Me.browseprefixfilebtn.UseVisualStyleBackColor = True
        '
        'testbtn
        '
        Me.testbtn.Location = New System.Drawing.Point(1036, 502)
        Me.testbtn.Name = "testbtn"
        Me.testbtn.Size = New System.Drawing.Size(116, 64)
        Me.testbtn.TabIndex = 2
        Me.testbtn.Text = "Test"
        Me.testbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1909, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Python command prefix:  ---------------------------------------------------------" &
    "--------------------------------------------------------------------------------" &
    "--------------------------------------"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.HorizontalScrollbar = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 68)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(1149, 389)
        Me.CheckedListBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last projects:"
        '
        'loadbtn
        '
        Me.loadbtn.Location = New System.Drawing.Point(215, 4)
        Me.loadbtn.Name = "loadbtn"
        Me.loadbtn.Size = New System.Drawing.Size(107, 58)
        Me.loadbtn.TabIndex = 6
        Me.loadbtn.Text = "Load"
        Me.loadbtn.UseVisualStyleBackColor = True
        '
        'newbtn
        '
        Me.newbtn.Location = New System.Drawing.Point(965, 7)
        Me.newbtn.Name = "newbtn"
        Me.newbtn.Size = New System.Drawing.Size(196, 54)
        Me.newbtn.TabIndex = 7
        Me.newbtn.Text = "New project"
        Me.newbtn.UseVisualStyleBackColor = True
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Choose where to create new project (subfolder will be created)"
        '
        'nametextbox
        '
        Me.nametextbox.Location = New System.Drawing.Point(702, 13)
        Me.nametextbox.Name = "nametextbox"
        Me.nametextbox.Size = New System.Drawing.Size(257, 38)
        Me.nametextbox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "New project name:"
        '
        'clearbtn
        '
        Me.clearbtn.Location = New System.Drawing.Point(329, 4)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(121, 58)
        Me.clearbtn.TabIndex = 10
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 578)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nametextbox)
        Me.Controls.Add(Me.newbtn)
        Me.Controls.Add(Me.loadbtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.testbtn)
        Me.Controls.Add(Me.browseprefixfilebtn)
        Me.Controls.Add(Me.prefixbox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Kiwi IDE v0.1 by Wojtekb30"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents prefixbox As TextBox
    Friend WithEvents FileDialog1 As OpenFileDialog
    Friend WithEvents browseprefixfilebtn As Button
    Friend WithEvents testbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents loadbtn As Button
    Friend WithEvents newbtn As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents nametextbox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents clearbtn As Button
End Class
