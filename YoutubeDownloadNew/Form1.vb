Option Strict On
Imports System.IO
Public Class Form1
    Dim Tempfile As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\tempvideop1.flv"
    Dim Tempfile2 As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\tempsong.mp3"
    Dim test As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WaitingCircle1.Start()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub

    Private Sub CommandButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommandButton1.Click
        Label3.Text = "Initialisiere..."
        If PromptedTextBox1.Text.Contains("youtube.com/watch") = True Then
            If CheckBox1.Checked = True Then
                SaveFileDialog1.Filter = "MP3-Audio Datei|*.mp3"
            Else
                SaveFileDialog1.Filter = "Web Video Datei|*.webm"
            End If
            SaveFileDialog1.ShowDialog()
        Else
            dotNetBase.Windows.Forms.messageBoxEx.Show(Me, "Fehler", "Ungültiger URL", "Der eingegebene URL ist nicht gültig, bitte überprüfen sie diesen.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Label3.Text = "Warte..."
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Label3.Text = "Suche Downloadlink..."
        CheckBox1.Enabled = False
        PromptedTextBox1.Enabled = False
        CommandButton1.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim inhalt As String = WebClient1.DownloadString(New Uri(PromptedTextBox1.Text))
        Dim pos1 As Integer = inhalt.IndexOf("url_encoded_fmt_stream_map=url%3D")
        Dim link1 As String = inhalt.Substring(pos1 + 33)
        Dim pos2 As Integer = link1.IndexOf("%26fallback_host")
        link1 = link1.Substring(0, pos2)
        link1 = link1.Replace("%3F", "?").Replace("%3D", "=").Replace("%26", "&").Replace("%25", "%").Replace("%2C", ",").Replace("%25", "%").Replace("%3A", ":").Replace("%2F", "/")
        link1 = link1.Replace("%3F", "?").Replace("%3D", "=").Replace("%26", "&").Replace("%25", "%").Replace("%2C", ",").Replace("%25", "%").Replace("%3A", ":").Replace("%2F", "/")
        If IO.File.Exists(Tempfile) = True Then
            Kill(Tempfile)
        End If
        If IO.File.Exists(Tempfile2) = True Then
            Kill(Tempfile2)
        End If
        Label3.Text = "Download..."
        WebClient1.DownloadFileAsync(New Uri(link1), Tempfile)
    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub WebClient1_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles WebClient1.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Label2.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub WebClient1_DownloadFileCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WebClient1.DownloadFileCompleted
        ProgressBar1.Value = 0
        If CheckBox1.Checked = False Then
            Label3.Text = "Kopiere..."
            FileCopy(Tempfile, SaveFileDialog1.FileName)
            Dim i As Integer = dotNetBase.Windows.Forms.messageBoxEx.Show(Me, "Download erfolgreich", "Video Download erfolgreich", "Das Video wurde erfolgreich heruntergeladen, wollen sie dieses nun öffnen ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If i = 6 Then
                Process.Start(SaveFileDialog1.FileName)
            End If
        Else
            Label3.Text = "Konvertiere..."
            Dim binaryw As New BinaryWriter(New FileStream("ffmpeg.exe", FileMode.Create))
            binaryw.Write(My.Resources.ffmpeg)
            binaryw.Close()
            Dim fs As New IO.StreamWriter("test.bat", False)
            fs.WriteLine("ffmpeg.exe -i " & Chr(34) & Tempfile & Chr(34) & _
                         " -ab 160000 -acodec libmp3lame " & Chr(34) & _
                        Tempfile2 & Chr(34))
            fs.WriteLine("del " + Chr(34) + "ffmpeg.exe" + Chr(34))
            fs.WriteLine("del " + Chr(34) + "video.flv" + Chr(34))
            fs.WriteLine("del " + Chr(34) + "test.bat" + Chr(34))
            fs.Close()
            Dim pinfo As New ProcessStartInfo
            pinfo.UseShellExecute = False
            pinfo.CreateNoWindow = True
            pinfo.FileName = "test.bat"
            Dim p As Process = Process.Start(pinfo)
            test = True
            Do
                If Len(Dir("test.bat")) = 0 Then
                    test = False
                    Label3.Text = "Kopiere..."
                    FileCopy(Tempfile2, SaveFileDialog1.FileName)
                    Dim i As Integer = dotNetBase.Windows.Forms.messageBoxEx.Show(Me, "Download erfolgreich", "Video Download erfolgreich", "Das Video wurde erfolgreich heruntergeladen, wollen sie dieses nun öffnen ? ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If i = 6 Then
                        Process.Start(SaveFileDialog1.FileName)
                    End If
                    Exit Do
                Else
                End If
            Loop
        End If
        PromptedTextBox1.Text = ""
        CommandButton1.Enabled = True
        CheckBox1.Enabled = True
        PromptedTextBox1.Enabled = True
        Label2.Text = "0%"
        Label3.Text = "Warte..."
        Me.Cursor = Cursors.Default
    End Sub
End Class
