<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bttn_LoadImage = New System.Windows.Forms.Button()
        Me.bttn_About = New System.Windows.Forms.Button()
        Me.bttn_ExportImage = New System.Windows.Forms.Button()
        Me.pb_Display = New System.Windows.Forms.PictureBox()
        CType(Me.pb_Display, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttn_LoadImage
        '
        Me.bttn_LoadImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttn_LoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_LoadImage.Location = New System.Drawing.Point(3, 2)
        Me.bttn_LoadImage.Name = "bttn_LoadImage"
        Me.bttn_LoadImage.Size = New System.Drawing.Size(93, 23)
        Me.bttn_LoadImage.TabIndex = 0
        Me.bttn_LoadImage.Text = "Load Image"
        Me.bttn_LoadImage.UseVisualStyleBackColor = False
        '
        'bttn_About
        '
        Me.bttn_About.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_About.Location = New System.Drawing.Point(3, 46)
        Me.bttn_About.Name = "bttn_About"
        Me.bttn_About.Size = New System.Drawing.Size(93, 23)
        Me.bttn_About.TabIndex = 2
        Me.bttn_About.Text = "About / Help"
        Me.bttn_About.UseVisualStyleBackColor = False
        '
        'bttn_ExportImage
        '
        Me.bttn_ExportImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bttn_ExportImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_ExportImage.Location = New System.Drawing.Point(3, 24)
        Me.bttn_ExportImage.Name = "bttn_ExportImage"
        Me.bttn_ExportImage.Size = New System.Drawing.Size(93, 23)
        Me.bttn_ExportImage.TabIndex = 3
        Me.bttn_ExportImage.Text = "Export Image"
        Me.bttn_ExportImage.UseVisualStyleBackColor = False
        '
        'pb_Display
        '
        Me.pb_Display.BackColor = System.Drawing.Color.White
        Me.pb_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_Display.Location = New System.Drawing.Point(102, 2)
        Me.pb_Display.Name = "pb_Display"
        Me.pb_Display.Size = New System.Drawing.Size(100, 100)
        Me.pb_Display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pb_Display.TabIndex = 4
        Me.pb_Display.TabStop = False
        '
        'mForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(203, 99)
        Me.Controls.Add(Me.pb_Display)
        Me.Controls.Add(Me.bttn_ExportImage)
        Me.Controls.Add(Me.bttn_About)
        Me.Controls.Add(Me.bttn_LoadImage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "mForm"
        Me.Text = "ImgBrick 5"
        CType(Me.pb_Display, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttn_LoadImage As System.Windows.Forms.Button
    Friend WithEvents bttn_About As System.Windows.Forms.Button
    Friend WithEvents bttn_ExportImage As System.Windows.Forms.Button
    Friend WithEvents pb_Display As System.Windows.Forms.PictureBox

End Class
