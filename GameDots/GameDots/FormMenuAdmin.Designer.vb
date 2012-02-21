<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuAdmin
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
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnDataAdmin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDataPemain = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKeluar
        '
        Me.btnKeluar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnKeluar.Location = New System.Drawing.Point(184, 298)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(99, 41)
        Me.btnKeluar.TabIndex = 16
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnDataAdmin
        '
        Me.btnDataAdmin.Location = New System.Drawing.Point(184, 251)
        Me.btnDataAdmin.Name = "btnDataAdmin"
        Me.btnDataAdmin.Size = New System.Drawing.Size(99, 41)
        Me.btnDataAdmin.TabIndex = 15
        Me.btnDataAdmin.Text = "Data Admin"
        Me.btnDataAdmin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GameDots.My.Resources.Resources.admin
        Me.PictureBox1.Location = New System.Drawing.Point(156, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'btnDataPemain
        '
        Me.btnDataPemain.Location = New System.Drawing.Point(184, 204)
        Me.btnDataPemain.Name = "btnDataPemain"
        Me.btnDataPemain.Size = New System.Drawing.Size(99, 41)
        Me.btnDataPemain.TabIndex = 19
        Me.btnDataPemain.Text = "Data Pemain"
        Me.btnDataPemain.UseVisualStyleBackColor = True
        '
        'FormMenuAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.GameDots.My.Resources.Resources.leo99
        Me.ClientSize = New System.Drawing.Size(472, 370)
        Me.Controls.Add(Me.btnDataPemain)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnDataAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormMenuAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Admin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnDataAdmin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDataPemain As System.Windows.Forms.Button
End Class
