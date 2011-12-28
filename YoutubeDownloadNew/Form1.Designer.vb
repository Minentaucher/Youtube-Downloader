<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WebClient1 = New System.Net.WebClient()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.CommandButton1 = New dotNetBase.Windows.Forms.commandButton()
        Me.WaitingCircle1 = New dotNetBase.Windows.Forms.Aero.waitingCircle()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.PromptedTextBox1 = New dotNetBase.Windows.Forms.promptedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebClient1
        '
        Me.WebClient1.BaseAddress = ""
        Me.WebClient1.CachePolicy = Nothing
        Me.WebClient1.Credentials = Nothing
        Me.WebClient1.Encoding = CType(resources.GetObject("WebClient1.Encoding"), System.Text.Encoding)
        Me.WebClient1.Headers = CType(resources.GetObject("WebClient1.Headers"), System.Net.WebHeaderCollection)
        Me.WebClient1.QueryString = CType(resources.GetObject("WebClient1.QueryString"), System.Collections.Specialized.NameValueCollection)
        Me.WebClient1.UseDefaultCredentials = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(186, 80)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(329, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(186, 51)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 23)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "MP3 Konvertierung"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        '
        'CommandButton1
        '
        Me.CommandButton1.commandButtonIcon = dotNetBase.Windows.Forms.commandButtonIcons.Arrow
        Me.CommandButton1.Description = "Lädt das Video herunter"
        Me.CommandButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CommandButton1.Location = New System.Drawing.Point(12, 51)
        Me.CommandButton1.Name = "CommandButton1"
        Me.CommandButton1.Size = New System.Drawing.Size(168, 52)
        Me.CommandButton1.TabIndex = 4
        Me.CommandButton1.Text = "Download"
        '
        'WaitingCircle1
        '
        Me.WaitingCircle1.Location = New System.Drawing.Point(499, 58)
        Me.WaitingCircle1.MaximumSize = New System.Drawing.Size(16, 16)
        Me.WaitingCircle1.MinimumSize = New System.Drawing.Size(16, 16)
        Me.WaitingCircle1.Name = "WaitingCircle1"
        Me.WaitingCircle1.Size = New System.Drawing.Size(16, 16)
        Me.WaitingCircle1.TabIndex = 5
        Me.WaitingCircle1.Text = "WaitingCircle1"
        Me.WaitingCircle1.Visible = False
        '
        'BackgroundWorker1
        '
        '
        'PromptedTextBox1
        '
        Me.PromptedTextBox1.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptedTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.PromptedTextBox1.Name = "PromptedTextBox1"
        Me.PromptedTextBox1.PromptText = "Youtube URL"
        Me.PromptedTextBox1.Size = New System.Drawing.Size(503, 33)
        Me.PromptedTextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(359, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Version 1.0 ©2011 Validati0n"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(353, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "0%"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Warte..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 127)
        Me.Controls.Add(Me.WaitingCircle1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PromptedTextBox1)
        Me.Controls.Add(Me.CommandButton1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Youtube Downloader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebClient1 As System.Net.WebClient
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents CommandButton1 As dotNetBase.Windows.Forms.commandButton
    Friend WithEvents WaitingCircle1 As dotNetBase.Windows.Forms.Aero.waitingCircle
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PromptedTextBox1 As dotNetBase.Windows.Forms.promptedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
