<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLobiGame
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLobiGame))
        Me.grpbxDftrPemain = New System.Windows.Forms.GroupBox()
        Me.lstInfoPemain = New System.Windows.Forms.ListBox()
        Me.BtnInfo = New System.Windows.Forms.Button()
        Me.AdidotsDataSet = New GameDots.adidotsDataSet()
        Me.grpbxDftrLobi = New System.Windows.Forms.GroupBox()
        Me.lstRoom = New System.Windows.Forms.ListBox()
        Me.btnJoin = New System.Windows.Forms.Button()
        Me.btnBuatRoom = New System.Windows.Forms.Button()
        Me.grpbxChat = New System.Windows.Forms.GroupBox()
        Me.lstChat = New System.Windows.Forms.ListBox()
        Me.btnKirimChat = New System.Windows.Forms.Button()
        Me.txtInputChat = New System.Windows.Forms.TextBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPemainLogin = New System.Windows.Forms.Label()
        Me.grpbxDftrPemain.SuspendLayout()
        CType(Me.AdidotsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbxDftrLobi.SuspendLayout()
        Me.grpbxChat.SuspendLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbxDftrPemain
        '
        Me.grpbxDftrPemain.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDftrPemain.Controls.Add(Me.lstInfoPemain)
        Me.grpbxDftrPemain.Controls.Add(Me.BtnInfo)
        Me.grpbxDftrPemain.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDftrPemain.ForeColor = System.Drawing.Color.White
        Me.grpbxDftrPemain.Location = New System.Drawing.Point(36, 95)
        Me.grpbxDftrPemain.Name = "grpbxDftrPemain"
        Me.grpbxDftrPemain.Size = New System.Drawing.Size(214, 276)
        Me.grpbxDftrPemain.TabIndex = 0
        Me.grpbxDftrPemain.TabStop = False
        Me.grpbxDftrPemain.Text = "Daftar Pemain"
        '
        'lstInfoPemain
        '
        Me.lstInfoPemain.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInfoPemain.FormattingEnabled = True
        Me.lstInfoPemain.ItemHeight = 14
        Me.lstInfoPemain.Location = New System.Drawing.Point(6, 48)
        Me.lstInfoPemain.Name = "lstInfoPemain"
        Me.lstInfoPemain.Size = New System.Drawing.Size(202, 214)
        Me.lstInfoPemain.TabIndex = 3
        '
        'BtnInfo
        '
        Me.BtnInfo.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfo.ForeColor = System.Drawing.Color.Black
        Me.BtnInfo.Location = New System.Drawing.Point(8, 19)
        Me.BtnInfo.Name = "BtnInfo"
        Me.BtnInfo.Size = New System.Drawing.Size(75, 23)
        Me.BtnInfo.TabIndex = 2
        Me.BtnInfo.Text = "Info"
        Me.BtnInfo.UseVisualStyleBackColor = True
        '
        'AdidotsDataSet
        '
        Me.AdidotsDataSet.DataSetName = "adidotsDataSet"
        Me.AdidotsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpbxDftrLobi
        '
        Me.grpbxDftrLobi.BackColor = System.Drawing.Color.Transparent
        Me.grpbxDftrLobi.Controls.Add(Me.lstRoom)
        Me.grpbxDftrLobi.Controls.Add(Me.btnJoin)
        Me.grpbxDftrLobi.Controls.Add(Me.btnBuatRoom)
        Me.grpbxDftrLobi.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDftrLobi.ForeColor = System.Drawing.Color.White
        Me.grpbxDftrLobi.Location = New System.Drawing.Point(280, 95)
        Me.grpbxDftrLobi.Name = "grpbxDftrLobi"
        Me.grpbxDftrLobi.Size = New System.Drawing.Size(311, 276)
        Me.grpbxDftrLobi.TabIndex = 1
        Me.grpbxDftrLobi.TabStop = False
        Me.grpbxDftrLobi.Text = "Daftar Room"
        '
        'lstRoom
        '
        Me.lstRoom.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRoom.FormattingEnabled = True
        Me.lstRoom.ItemHeight = 14
        Me.lstRoom.Location = New System.Drawing.Point(6, 48)
        Me.lstRoom.Name = "lstRoom"
        Me.lstRoom.Size = New System.Drawing.Size(299, 214)
        Me.lstRoom.TabIndex = 5
        '
        'btnJoin
        '
        Me.btnJoin.ForeColor = System.Drawing.Color.Black
        Me.btnJoin.Location = New System.Drawing.Point(87, 19)
        Me.btnJoin.Name = "btnJoin"
        Me.btnJoin.Size = New System.Drawing.Size(75, 23)
        Me.btnJoin.TabIndex = 4
        Me.btnJoin.Text = "Join"
        Me.btnJoin.UseVisualStyleBackColor = True
        '
        'btnBuatRoom
        '
        Me.btnBuatRoom.BackColor = System.Drawing.Color.Transparent
        Me.btnBuatRoom.ForeColor = System.Drawing.Color.Black
        Me.btnBuatRoom.Location = New System.Drawing.Point(6, 19)
        Me.btnBuatRoom.Name = "btnBuatRoom"
        Me.btnBuatRoom.Size = New System.Drawing.Size(75, 23)
        Me.btnBuatRoom.TabIndex = 3
        Me.btnBuatRoom.Text = "Buat Room"
        Me.btnBuatRoom.UseVisualStyleBackColor = False
        '
        'grpbxChat
        '
        Me.grpbxChat.BackColor = System.Drawing.Color.Transparent
        Me.grpbxChat.Controls.Add(Me.lstChat)
        Me.grpbxChat.Controls.Add(Me.btnKirimChat)
        Me.grpbxChat.Controls.Add(Me.txtInputChat)
        Me.grpbxChat.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxChat.ForeColor = System.Drawing.Color.White
        Me.grpbxChat.Location = New System.Drawing.Point(36, 377)
        Me.grpbxChat.Name = "grpbxChat"
        Me.grpbxChat.Size = New System.Drawing.Size(555, 162)
        Me.grpbxChat.TabIndex = 2
        Me.grpbxChat.TabStop = False
        Me.grpbxChat.Text = "Chat"
        '
        'lstChat
        '
        Me.lstChat.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstChat.FormattingEnabled = True
        Me.lstChat.ItemHeight = 14
        Me.lstChat.Location = New System.Drawing.Point(6, 19)
        Me.lstChat.Name = "lstChat"
        Me.lstChat.Size = New System.Drawing.Size(538, 102)
        Me.lstChat.TabIndex = 3
        '
        'btnKirimChat
        '
        Me.btnKirimChat.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnKirimChat.Location = New System.Drawing.Point(464, 134)
        Me.btnKirimChat.Name = "btnKirimChat"
        Me.btnKirimChat.Size = New System.Drawing.Size(85, 23)
        Me.btnKirimChat.TabIndex = 2
        Me.btnKirimChat.Text = "Kirim"
        Me.btnKirimChat.UseVisualStyleBackColor = True
        '
        'txtInputChat
        '
        Me.txtInputChat.Location = New System.Drawing.Point(6, 136)
        Me.txtInputChat.Name = "txtInputChat"
        Me.txtInputChat.Size = New System.Drawing.Size(452, 22)
        Me.txtInputChat.TabIndex = 1
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.Location = New System.Drawing.Point(510, 40)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxClose.TabIndex = 5
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMinimize.BackgroundImage = CType(resources.GetObject("PictureBoxMinimize.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(548, 40)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxMinimize.TabIndex = 6
        Me.PictureBoxMinimize.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(140, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Selamat Bergabung Di Lobi Game Bung "
        '
        'lblPemainLogin
        '
        Me.lblPemainLogin.AutoSize = True
        Me.lblPemainLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblPemainLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPemainLogin.ForeColor = System.Drawing.Color.White
        Me.lblPemainLogin.Location = New System.Drawing.Point(418, 75)
        Me.lblPemainLogin.Name = "lblPemainLogin"
        Me.lblPemainLogin.Size = New System.Drawing.Size(55, 16)
        Me.lblPemainLogin.TabIndex = 8
        Me.lblPemainLogin.Text = "Label2"
        '
        'FormLobiGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(613, 570)
        Me.Controls.Add(Me.lblPemainLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBoxMinimize)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.grpbxChat)
        Me.Controls.Add(Me.grpbxDftrLobi)
        Me.Controls.Add(Me.grpbxDftrPemain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormLobiGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LobiGame"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        Me.grpbxDftrPemain.ResumeLayout(False)
        CType(Me.AdidotsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbxDftrLobi.ResumeLayout(False)
        Me.grpbxChat.ResumeLayout(False)
        Me.grpbxChat.PerformLayout()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpbxDftrPemain As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxDftrLobi As System.Windows.Forms.GroupBox
    Friend WithEvents grpbxChat As System.Windows.Forms.GroupBox
    Friend WithEvents btnKirimChat As System.Windows.Forms.Button
    Friend WithEvents txtInputChat As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents BtnInfo As System.Windows.Forms.Button
    Friend WithEvents btnJoin As System.Windows.Forms.Button
    Friend WithEvents btnBuatRoom As System.Windows.Forms.Button
    Friend WithEvents lstChat As System.Windows.Forms.ListBox
    Friend WithEvents lstInfoPemain As System.Windows.Forms.ListBox
    Friend WithEvents lstRoom As System.Windows.Forms.ListBox
    Friend WithEvents AdidotsDataSet As GameDots.adidotsDataSet
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPemainLogin As System.Windows.Forms.Label
End Class
