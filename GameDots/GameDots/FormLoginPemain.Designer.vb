<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoginPemain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLoginPemain))
        Me.txtIpserver = New System.Windows.Forms.TextBox()
        Me.txtNamapemain = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblIpServer = New System.Windows.Forms.Label()
        Me.lblNamaPemain = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIpserver
        '
        Me.txtIpserver.Location = New System.Drawing.Point(303, 112)
        Me.txtIpserver.Name = "txtIpserver"
        Me.txtIpserver.Size = New System.Drawing.Size(119, 20)
        Me.txtIpserver.TabIndex = 2
        Me.txtIpserver.Text = "127.0.0.1"
        '
        'txtNamapemain
        '
        Me.txtNamapemain.Location = New System.Drawing.Point(303, 151)
        Me.txtNamapemain.Name = "txtNamapemain"
        Me.txtNamapemain.Size = New System.Drawing.Size(119, 20)
        Me.txtNamapemain.TabIndex = 3
        Me.txtNamapemain.Text = "adi"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(303, 194)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(119, 20)
        Me.txtPassword.TabIndex = 4
        Me.txtPassword.Text = "adi123"
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblIpServer
        '
        Me.lblIpServer.AutoSize = True
        Me.lblIpServer.BackColor = System.Drawing.Color.Transparent
        Me.lblIpServer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIpServer.ForeColor = System.Drawing.Color.White
        Me.lblIpServer.Location = New System.Drawing.Point(188, 114)
        Me.lblIpServer.Name = "lblIpServer"
        Me.lblIpServer.Size = New System.Drawing.Size(65, 20)
        Me.lblIpServer.TabIndex = 5
        Me.lblIpServer.Text = "IP Server"
        '
        'lblNamaPemain
        '
        Me.lblNamaPemain.AutoSize = True
        Me.lblNamaPemain.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaPemain.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaPemain.ForeColor = System.Drawing.Color.White
        Me.lblNamaPemain.Location = New System.Drawing.Point(188, 151)
        Me.lblNamaPemain.Name = "lblNamaPemain"
        Me.lblNamaPemain.Size = New System.Drawing.Size(92, 20)
        Me.lblNamaPemain.TabIndex = 6
        Me.lblNamaPemain.Text = "Nama Pemain"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(188, 194)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 20)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Password"
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMinimize.Image = CType(resources.GetObject("PictureBoxMinimize.Image"), System.Drawing.Image)
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(412, 43)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxMinimize.TabIndex = 9
        Me.PictureBoxMinimize.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.Image = CType(resources.GetObject("PictureBoxClose.Image"), System.Drawing.Image)
        Me.PictureBoxClose.Location = New System.Drawing.Point(374, 43)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxClose.TabIndex = 8
        Me.PictureBoxClose.TabStop = False
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(192, 240)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(88, 31)
        Me.BtnLogin.TabIndex = 10
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Location = New System.Drawing.Point(334, 240)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(88, 31)
        Me.BtnBatal.TabIndex = 11
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'FormLoginPemain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(466, 323)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.PictureBoxMinimize)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblNamaPemain)
        Me.Controls.Add(Me.lblIpServer)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNamapemain)
        Me.Controls.Add(Me.txtIpserver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLoginPemain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginPemain"
        Me.TransparencyKey = System.Drawing.SystemColors.InactiveBorder
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIpserver As System.Windows.Forms.TextBox
    Friend WithEvents txtNamapemain As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblIpServer As System.Windows.Forms.Label
    Friend WithEvents lblNamaPemain As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents PictureBoxMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents BtnLogin As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
End Class
