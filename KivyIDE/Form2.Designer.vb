<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.runbtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.compilebtn = New System.Windows.Forms.Button()
        Me.autosavecheck = New System.Windows.Forms.CheckBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(13, 87)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(2090, 999)
        Me.TextBox1.TabIndex = 0
        '
        'runbtn
        '
        Me.runbtn.Location = New System.Drawing.Point(13, 13)
        Me.runbtn.Name = "runbtn"
        Me.runbtn.Size = New System.Drawing.Size(165, 68)
        Me.runbtn.TabIndex = 1
        Me.runbtn.Text = "Run"
        Me.runbtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Compile for Windows (pyInstaller) [automatic]", "Compile for Windows (pyInstaller, one file) [auto]", "Compile for Android (buildozer, WSL) [manual]", "Compile for Android (KiwiDroid Compiler) [almost-auto] (coming soon)", "Compile for MacOS (pyInstaller and Docker) [auto] (coming soon)", "Compile for Linux (pyInstaller and Docker) [auto] (coming soon)"})
        Me.ComboBox1.Location = New System.Drawing.Point(196, 29)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(828, 39)
        Me.ComboBox1.TabIndex = 2
        '
        'compilebtn
        '
        Me.compilebtn.Location = New System.Drawing.Point(1042, 13)
        Me.compilebtn.Name = "compilebtn"
        Me.compilebtn.Size = New System.Drawing.Size(163, 68)
        Me.compilebtn.TabIndex = 3
        Me.compilebtn.Text = "Compile"
        Me.compilebtn.UseVisualStyleBackColor = True
        '
        'autosavecheck
        '
        Me.autosavecheck.AutoSize = True
        Me.autosavecheck.Checked = True
        Me.autosavecheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autosavecheck.Location = New System.Drawing.Point(1458, 29)
        Me.autosavecheck.Name = "autosavecheck"
        Me.autosavecheck.Size = New System.Drawing.Size(605, 36)
        Me.autosavecheck.TabIndex = 5
        Me.autosavecheck.Text = "Enable auto save (only way to save for now)"
        Me.autosavecheck.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1211, 13)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(188, 32)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Help (GitHub)"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(1211, 49)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(232, 32)
        Me.LinkLabel2.TabIndex = 7
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Help (birdtech.pl)"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2115, 1111)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.autosavecheck)
        Me.Controls.Add(Me.compilebtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.runbtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Kiwi IDE editor window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents runbtn As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents compilebtn As Button
    Friend WithEvents autosavecheck As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
