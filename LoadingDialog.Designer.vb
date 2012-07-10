<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadingDialog
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
        Me.pb_cprog = New System.Windows.Forms.ProgressBar()
        Me.bttn_Cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pb_cprog
        '
        Me.pb_cprog.Location = New System.Drawing.Point(13, 13)
        Me.pb_cprog.Name = "pb_cprog"
        Me.pb_cprog.Size = New System.Drawing.Size(339, 23)
        Me.pb_cprog.TabIndex = 0
        '
        'bttn_Cancel
        '
        Me.bttn_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.bttn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttn_Cancel.Location = New System.Drawing.Point(259, 42)
        Me.bttn_Cancel.Name = "bttn_Cancel"
        Me.bttn_Cancel.Size = New System.Drawing.Size(93, 23)
        Me.bttn_Cancel.TabIndex = 7
        Me.bttn_Cancel.Text = "Cancel"
        Me.bttn_Cancel.UseVisualStyleBackColor = False
        '
        'LoadingDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 78)
        Me.Controls.Add(Me.bttn_Cancel)
        Me.Controls.Add(Me.pb_cprog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoadingDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Exporting"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb_cprog As System.Windows.Forms.ProgressBar
    Friend WithEvents bttn_Cancel As System.Windows.Forms.Button

End Class
