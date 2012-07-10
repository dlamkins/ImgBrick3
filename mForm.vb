Imports System.Drawing.Imaging
Imports System.Text

Public Class mForm

    Private LoadedImage As Image = Nothing
    Friend Canceled As Boolean = False

    Private Sub bttn_LoadImage_Click(sender As Object, e As EventArgs) Handles bttn_LoadImage.Click
        Using oi_ofd As New OpenFileDialog
            ''
            ''MODIFIED FROM: http://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            ''
            Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageEncoders()
            oi_ofd.Filter = "All Image Files|"
            For Each c As ImageCodecInfo In codecs
                oi_ofd.Filter = String.Format("{0}{1};", oi_ofd.Filter, c.FilenameExtension)
            Next
            oi_ofd.Filter = oi_ofd.Filter.Remove(oi_ofd.Filter.Length - 1)
            oi_ofd.Filter = String.Format("{0}|{1} ({2})|{2}", oi_ofd.Filter, "All Files", "*.*")
            ''
            ''
            ''  
            If oi_ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    LoadedImage = Image.FromFile(oi_ofd.FileName)
                Catch ex As Exception
                    LoadedImage = Nothing
                    MsgBox("There was an error loading the image.  It may be corrupt or not a true image file.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error!")
                End Try
            End If
            pb_Display.Image = LoadedImage
        End Using
    End Sub

    Private Sub bttn_ExportImage_Click(sender As Object, e As EventArgs) Handles bttn_ExportImage.Click

        Using oi_sfd As New SaveFileDialog
            oi_sfd.Filter = "Roblox Model File (*.rbxm)|*.rbxm"

            If oi_sfd.ShowDialog = Windows.Forms.DialogResult.OK Then

                Dim mTim As New Stopwatch
                mTim.Start()

                Canceled = False

                bttn_LoadImage.Enabled = False
                bttn_About.Enabled = False
                bttn_ExportImage.Enabled = False

                LoadingDialog.Show()

                Dim ExportXML As New StringBuilder

                Dim width As Integer = LoadedImage.Width
                Dim height As Integer = LoadedImage.Height

                LoadingDialog.pb_cprog.Value = 0
                LoadingDialog.pb_cprog.Maximum = width * height
                LoadingDialog.pb_cprog.Step = 1

                Dim bitImage As New Bitmap(LoadedImage)
                pb_Display.Image = bitImage

                ExportXML.Append(My.Resources.ExportXML_S)

                For x As Integer = 0 To width - 1
                    For y As Integer = 0 To height - 1
                        If Canceled Then
                            bttn_LoadImage.Enabled = True
                            bttn_About.Enabled = True
                            bttn_ExportImage.Enabled = True
                            LoadingDialog.pb_cprog.Value = 0
                            LoadingDialog.Hide()
                            MsgBox("Export Canceled!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Export Canceled.")
                            Return
                        End If
                        Dim px_clr As Color = bitImage.GetPixel(x, y)
                        Dim r As Double = px_clr.R / 255
                        Dim g As Double = px_clr.G / 255
                        Dim b As Double = px_clr.B / 255
                        Dim a As Double = 1 - px_clr.A / 255

                        If a <> 1 Then

                            ExportXML.Append( _
                                My.Resources.ExportXML_Part.Replace("$r", r).Replace("$g", g).Replace("$b", b).Replace("$x", x).Replace("$y", 1).Replace("$z", y).Replace("$height", 1).Replace("$t", a)
                            )

                        End If

                        LoadingDialog.pb_cprog.PerformStep()
                        Application.DoEvents()
                    Next
                Next

                LoadingDialog.pb_cprog.Value = LoadingDialog.pb_cprog.Maximum
                Application.DoEvents()

                ExportXML.Append(My.Resources.ExportXML_E)

                My.Computer.FileSystem.WriteAllText(oi_sfd.FileName, ExportXML.ToString(), False)

                LoadingDialog.Hide()

                bttn_LoadImage.Enabled = True
                bttn_About.Enabled = True
                bttn_ExportImage.Enabled = True

                mTim.Stop()
                MsgBox("Process Complete: " & vbCrLf & mTim.ElapsedMilliseconds & " milliseconds.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Complete.")

            End If

        End Using

    End Sub

    Private Sub bttn_About_Click(sender As Object, e As EventArgs) Handles bttn_About.Click
        Dim tmpL As String = My.Computer.FileSystem.GetTempFileName
        My.Computer.FileSystem.WriteAllText(tmpL & ".txt", My.Resources.Help, False)
        Dim nProc As New Process
        nProc.StartInfo.FileName = tmpL & ".txt"
        nProc.StartInfo.ErrorDialog = True
        Try
            nProc.Start()
        Catch ex As Exception
            ''
        End Try
    End Sub

End Class
