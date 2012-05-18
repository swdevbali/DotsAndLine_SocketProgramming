<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGameServer
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
        Me.grpbxChat = New System.Windows.Forms.GroupBox()
        Me.lstChat2 = New System.Windows.Forms.ListBox()
        Me.btnKirimChat2 = New System.Windows.Forms.Button()
        Me.txtInputChat2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.scorePemain2 = New System.Windows.Forms.Label()
        Me.scorePemain1 = New System.Windows.Forms.Label()
        Me.lblPemain2 = New System.Windows.Forms.Label()
        Me.lblPemain1 = New System.Windows.Forms.Label()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnPetunjuk = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbxPemain2 = New System.Windows.Forms.PictureBox()
        Me.pbxPemain1 = New System.Windows.Forms.PictureBox()
        Me.PB_Paper = New System.Windows.Forms.PictureBox()
        Me.grpbxChat.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPemain2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPemain1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbxChat
        '
        Me.grpbxChat.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpbxChat.Controls.Add(Me.lstChat2)
        Me.grpbxChat.Controls.Add(Me.btnKirimChat2)
        Me.grpbxChat.Controls.Add(Me.txtInputChat2)
        Me.grpbxChat.Font = New System.Drawing.Font("Constantia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxChat.ForeColor = System.Drawing.Color.White
        Me.grpbxChat.Location = New System.Drawing.Point(107, 376)
        Me.grpbxChat.Name = "grpbxChat"
        Me.grpbxChat.Size = New System.Drawing.Size(555, 162)
        Me.grpbxChat.TabIndex = 53
        Me.grpbxChat.TabStop = False
        Me.grpbxChat.Text = "Chat"
        '
        'lstChat2
        '
        Me.lstChat2.FormattingEnabled = True
        Me.lstChat2.Location = New System.Drawing.Point(6, 19)
        Me.lstChat2.Name = "lstChat2"
        Me.lstChat2.Size = New System.Drawing.Size(538, 108)
        Me.lstChat2.TabIndex = 3
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
        'txtInputChat2
        '
        Me.txtInputChat2.Location = New System.Drawing.Point(6, 136)
        Me.txtInputChat2.Name = "txtInputChat2"
        Me.txtInputChat2.Size = New System.Drawing.Size(452, 21)
        Me.txtInputChat2.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(57, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 22)
        Me.Label9.TabIndex = 51
        '
        'scorePemain2
        '
        Me.scorePemain2.AutoSize = True
        Me.scorePemain2.BackColor = System.Drawing.Color.Transparent
        Me.scorePemain2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorePemain2.ForeColor = System.Drawing.Color.Blue
        Me.scorePemain2.Location = New System.Drawing.Point(147, 198)
        Me.scorePemain2.Name = "scorePemain2"
        Me.scorePemain2.Size = New System.Drawing.Size(30, 22)
        Me.scorePemain2.TabIndex = 50
        Me.scorePemain2.Text = "00"
        '
        'scorePemain1
        '
        Me.scorePemain1.AutoSize = True
        Me.scorePemain1.BackColor = System.Drawing.Color.Transparent
        Me.scorePemain1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scorePemain1.ForeColor = System.Drawing.Color.Red
        Me.scorePemain1.Location = New System.Drawing.Point(147, 141)
        Me.scorePemain1.Name = "scorePemain1"
        Me.scorePemain1.Size = New System.Drawing.Size(30, 22)
        Me.scorePemain1.TabIndex = 49
        Me.scorePemain1.Text = "00"
        '
        'lblPemain2
        '
        Me.lblPemain2.AutoSize = True
        Me.lblPemain2.BackColor = System.Drawing.Color.Transparent
        Me.lblPemain2.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemain2.ForeColor = System.Drawing.Color.Blue
        Me.lblPemain2.Location = New System.Drawing.Point(67, 198)
        Me.lblPemain2.Name = "lblPemain2"
        Me.lblPemain2.Size = New System.Drawing.Size(44, 22)
        Me.lblPemain2.TabIndex = 48
        Me.lblPemain2.Text = "Biru"
        '
        'lblPemain1
        '
        Me.lblPemain1.AutoSize = True
        Me.lblPemain1.BackColor = System.Drawing.Color.Transparent
        Me.lblPemain1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemain1.ForeColor = System.Drawing.Color.Red
        Me.lblPemain1.Location = New System.Drawing.Point(66, 141)
        Me.lblPemain1.Name = "lblPemain1"
        Me.lblPemain1.Size = New System.Drawing.Size(61, 22)
        Me.lblPemain1.TabIndex = 47
        Me.lblPemain1.Text = "Merah"
        '
        'btnKeluar
        '
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnKeluar.Location = New System.Drawing.Point(574, 234)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(88, 31)
        Me.btnKeluar.TabIndex = 44
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnPetunjuk
        '
        Me.btnPetunjuk.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPetunjuk.Location = New System.Drawing.Point(574, 178)
        Me.btnPetunjuk.Name = "btnPetunjuk"
        Me.btnPetunjuk.Size = New System.Drawing.Size(88, 31)
        Me.btnPetunjuk.TabIndex = 43
        Me.btnPetunjuk.Text = "Petunjuk"
        Me.btnPetunjuk.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(9, 261)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'pbxPemain2
        '
        Me.pbxPemain2.BackColor = System.Drawing.Color.Blue
        Me.pbxPemain2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPemain2.Location = New System.Drawing.Point(12, 189)
        Me.pbxPemain2.Name = "pbxPemain2"
        Me.pbxPemain2.Size = New System.Drawing.Size(39, 34)
        Me.pbxPemain2.TabIndex = 46
        Me.pbxPemain2.TabStop = False
        '
        'pbxPemain1
        '
        Me.pbxPemain1.BackColor = System.Drawing.Color.Red
        Me.pbxPemain1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxPemain1.Location = New System.Drawing.Point(12, 132)
        Me.pbxPemain1.Name = "pbxPemain1"
        Me.pbxPemain1.Size = New System.Drawing.Size(39, 34)
        Me.pbxPemain1.TabIndex = 45
        Me.pbxPemain1.TabStop = False
        '
        'PB_Paper
        '
        Me.PB_Paper.BackColor = System.Drawing.Color.White
        Me.PB_Paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_Paper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_Paper.Location = New System.Drawing.Point(199, 10)
        Me.PB_Paper.Name = "PB_Paper"
        Me.PB_Paper.Size = New System.Drawing.Size(366, 360)
        Me.PB_Paper.TabIndex = 42
        Me.PB_Paper.TabStop = False
        '
        'FormGameServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(691, 549)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FormGameServer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormGameServer"
        Me.grpbxChat.ResumeLayout(False)
        Me.grpbxChat.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPemain2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPemain1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxChat As System.Windows.Forms.GroupBox
    Friend WithEvents lstChat2 As System.Windows.Forms.ListBox
    Friend WithEvents btnKirimChat2 As System.Windows.Forms.Button
    Friend WithEvents txtInputChat2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents scorePemain2 As System.Windows.Forms.Label
    Friend WithEvents scorePemain1 As System.Windows.Forms.Label
    Friend WithEvents lblPemain2 As System.Windows.Forms.Label
    Friend WithEvents lblPemain1 As System.Windows.Forms.Label
    Friend WithEvents pbxPemain2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxPemain1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents btnPetunjuk As System.Windows.Forms.Button
    Friend WithEvents PB_Paper As System.Windows.Forms.PictureBox
End Class
