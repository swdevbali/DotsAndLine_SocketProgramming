<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGameDots
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGameDots))
        Me.PB_Paper = New System.Windows.Forms.PictureBox()
        Me.btnPetunjuk = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.pbxPemain1 = New System.Windows.Forms.PictureBox()
        Me.pbxPemain2 = New System.Windows.Forms.PictureBox()
        Me.lblPemain1 = New System.Windows.Forms.Label()
        Me.lblPemain2 = New System.Windows.Forms.Label()
        Me.scorePemain1 = New System.Windows.Forms.Label()
        Me.scorePemain2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtInputChat2 = New System.Windows.Forms.TextBox()
        Me.btnKirimChat2 = New System.Windows.Forms.Button()
        Me.lstChat2 = New System.Windows.Forms.ListBox()
        Me.grpbxChat = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PB_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPemain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPemain2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxChat.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_Paper
        '
        Me.PB_Paper.BackColor = System.Drawing.Color.White
        Me.PB_Paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_Paper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_Paper.Location = New System.Drawing.Point(207, 23)
        Me.PB_Paper.Name = "PB_Paper"
        Me.PB_Paper.Size = New System.Drawing.Size(366, 360)
        Me.PB_Paper.TabIndex = 0
        Me.PB_Paper.TabStop = False
        '
        'btnPetunjuk
        '
        Me.btnPetunjuk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPetunjuk.Location = New System.Drawing.Point(582, 159)
        Me.btnPetunjuk.Name = "btnPetunjuk"
        Me.btnPetunjuk.Size = New System.Drawing.Size(88, 31)
        Me.btnPetunjuk.TabIndex = 2
        Me.btnPetunjuk.Text = "Petunjuk"
        Me.btnPetunjuk.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnKeluar.Location = New System.Drawing.Point(582, 215)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(88, 31)
        Me.btnKeluar.TabIndex = 3
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'pbxPemain1
        '
        Me.pbxPemain1.BackColor = System.Drawing.Color.Red
        Me.pbxPemain1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPemain1.Location = New System.Drawing.Point(20, 145)
        Me.pbxPemain1.Name = "pbxPemain1"
        Me.pbxPemain1.Size = New System.Drawing.Size(39, 34)
        Me.pbxPemain1.TabIndex = 4
        Me.pbxPemain1.TabStop = False
        '
        'pbxPemain2
        '
        Me.pbxPemain2.BackColor = System.Drawing.Color.Blue
        Me.pbxPemain2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPemain2.Location = New System.Drawing.Point(20, 202)
        Me.pbxPemain2.Name = "pbxPemain2"
        Me.pbxPemain2.Size = New System.Drawing.Size(39, 34)
        Me.pbxPemain2.TabIndex = 5
        Me.pbxPemain2.TabStop = False
        '
        'lblPemain1
        '
        Me.lblPemain1.AutoSize = True
        Me.lblPemain1.BackColor = System.Drawing.Color.Transparent
        Me.lblPemain1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemain1.ForeColor = System.Drawing.Color.Red
        Me.lblPemain1.Location = New System.Drawing.Point(74, 154)
        Me.lblPemain1.Name = "lblPemain1"
        Me.lblPemain1.Size = New System.Drawing.Size(61, 22)
        Me.lblPemain1.TabIndex = 9
        Me.lblPemain1.Text = "Merah"
        '
        'lblPemain2
        '
        Me.lblPemain2.AutoSize = True
        Me.lblPemain2.BackColor = System.Drawing.Color.Transparent
        Me.lblPemain2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemain2.ForeColor = System.Drawing.Color.Blue
        Me.lblPemain2.Location = New System.Drawing.Point(75, 211)
        Me.lblPemain2.Name = "lblPemain2"
        Me.lblPemain2.Size = New System.Drawing.Size(44, 22)
        Me.lblPemain2.TabIndex = 10
        Me.lblPemain2.Text = "Biru"
        '
        'scorePemain1
        '
        Me.scorePemain1.AutoSize = True
        Me.scorePemain1.BackColor = System.Drawing.Color.Transparent
        Me.scorePemain1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorePemain1.ForeColor = System.Drawing.Color.Red
        Me.scorePemain1.Location = New System.Drawing.Point(155, 154)
        Me.scorePemain1.Name = "scorePemain1"
        Me.scorePemain1.Size = New System.Drawing.Size(30, 22)
        Me.scorePemain1.TabIndex = 13
        Me.scorePemain1.Text = "00"
        '
        'scorePemain2
        '
        Me.scorePemain2.AutoSize = True
        Me.scorePemain2.BackColor = System.Drawing.Color.Transparent
        Me.scorePemain2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorePemain2.ForeColor = System.Drawing.Color.Blue
        Me.scorePemain2.Location = New System.Drawing.Point(155, 211)
        Me.scorePemain2.Name = "scorePemain2"
        Me.scorePemain2.Size = New System.Drawing.Size(30, 22)
        Me.scorePemain2.TabIndex = 14
        Me.scorePemain2.Text = "00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(66, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 22)
        Me.Label9.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(18, 290)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        '
        'txtInputChat2
        '
        Me.txtInputChat2.Location = New System.Drawing.Point(6, 136)
        Me.txtInputChat2.Name = "txtInputChat2"
        Me.txtInputChat2.Size = New System.Drawing.Size(452, 21)
        Me.txtInputChat2.TabIndex = 1
        '
        'btnKirimChat2
        '
        Me.btnKirimChat2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnKirimChat2.Location = New System.Drawing.Point(464, 134)
        Me.btnKirimChat2.Name = "btnKirimChat2"
        Me.btnKirimChat2.Size = New System.Drawing.Size(85, 23)
        Me.btnKirimChat2.TabIndex = 2
        Me.btnKirimChat2.Text = "Kirim"
        Me.btnKirimChat2.UseVisualStyleBackColor = True
        '
        'lstChat2
        '
        Me.lstChat2.FormattingEnabled = True
        Me.lstChat2.Location = New System.Drawing.Point(6, 19)
        Me.lstChat2.Name = "lstChat2"
        Me.lstChat2.Size = New System.Drawing.Size(538, 108)
        Me.lstChat2.TabIndex = 3
        '
        'grpbxChat
        '
        Me.grpbxChat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpbxChat.Controls.Add(Me.lstChat2)
        Me.grpbxChat.Controls.Add(Me.btnKirimChat2)
        Me.grpbxChat.Controls.Add(Me.txtInputChat2)
        Me.grpbxChat.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxChat.ForeColor = System.Drawing.Color.White
        Me.grpbxChat.Location = New System.Drawing.Point(115, 389)
        Me.grpbxChat.Name = "grpbxChat"
        Me.grpbxChat.Size = New System.Drawing.Size(555, 162)
        Me.grpbxChat.TabIndex = 24
        Me.grpbxChat.TabStop = False
        Me.grpbxChat.Text = "Chat"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GameDots.My.Resources.Resources.gorilla
        Me.PictureBox1.Location = New System.Drawing.Point(20, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 118)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 256)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Giliran Pemain"
        '
        'FormGameDots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(707, 567)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpbxChat)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.scorePemain2)
        Me.Controls.Add(Me.scorePemain1)
        Me.Controls.Add(Me.lblPemain2)
        Me.Controls.Add(Me.lblPemain1)
        Me.Controls.Add(Me.pbxPemain2)
        Me.Controls.Add(Me.pbxPemain1)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnPetunjuk)
        Me.Controls.Add(Me.PB_Paper)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormGameDots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Dots"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.PB_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPemain1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPemain2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxChat.ResumeLayout(False)
        Me.grpbxChat.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB_Paper As System.Windows.Forms.PictureBox
    Friend WithEvents btnPetunjuk As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents pbxPemain1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPemain2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPemain1 As System.Windows.Forms.Label
    Friend WithEvents lblPemain2 As System.Windows.Forms.Label
    Friend WithEvents scorePemain1 As System.Windows.Forms.Label
    Friend WithEvents scorePemain2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtInputChat2 As System.Windows.Forms.TextBox
    Friend WithEvents btnKirimChat2 As System.Windows.Forms.Button
    Friend WithEvents lstChat2 As System.Windows.Forms.ListBox
    Friend WithEvents grpbxChat As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
