<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuLogin
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
        Me.btnLoginAdmin = New System.Windows.Forms.Button()
        Me.btnLoginPemain = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoginAdmin
        '
        Me.btnLoginAdmin.Location = New System.Drawing.Point(49, 103)
        Me.btnLoginAdmin.Name = "btnLoginAdmin"
        Me.btnLoginAdmin.Size = New System.Drawing.Size(100, 35)
        Me.btnLoginAdmin.TabIndex = 0
        Me.btnLoginAdmin.Text = "Login Admin"
        Me.btnLoginAdmin.UseVisualStyleBackColor = True
        '
        'btnLoginPemain
        '
        Me.btnLoginPemain.Location = New System.Drawing.Point(49, 144)
        Me.btnLoginPemain.Name = "btnLoginPemain"
        Me.btnLoginPemain.Size = New System.Drawing.Size(100, 35)
        Me.btnLoginPemain.TabIndex = 1
        Me.btnLoginPemain.Text = "Login Pemain"
        Me.btnLoginPemain.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(49, 185)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(100, 35)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.GameDots.My.Resources.Resources.gorilla
        Me.PictureBox1.Location = New System.Drawing.Point(219, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'FormMenuLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = Global.GameDots.My.Resources.Resources.Menu_Login1
        Me.ClientSize = New System.Drawing.Size(470, 297)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnLoginPemain)
        Me.Controls.Add(Me.btnLoginAdmin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Menu Login"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoginAdmin As System.Windows.Forms.Button
    Friend WithEvents btnLoginPemain As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
