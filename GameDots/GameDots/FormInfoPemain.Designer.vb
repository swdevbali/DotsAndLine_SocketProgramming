<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoPemain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInfoPemain))
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        Me.lblNama_pemain = New System.Windows.Forms.Label()
        Me.lblJum_Menang = New System.Windows.Forms.Label()
        Me.lblJum_Kalah = New System.Windows.Forms.Label()
        Me.lblJum_Imbang = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_jumPoin = New System.Windows.Forms.Label()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(175, 341)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(88, 31)
        Me.btnKembali.TabIndex = 2
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.Location = New System.Drawing.Point(322, 34)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxClose.TabIndex = 15
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMinimize.BackgroundImage = CType(resources.GetObject("PictureBoxMinimize.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(357, 34)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxMinimize.TabIndex = 16
        Me.PictureBoxMinimize.TabStop = False
        '
        'lblNama_pemain
        '
        Me.lblNama_pemain.AutoSize = True
        Me.lblNama_pemain.BackColor = System.Drawing.Color.Transparent
        Me.lblNama_pemain.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama_pemain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNama_pemain.Location = New System.Drawing.Point(254, 100)
        Me.lblNama_pemain.Name = "lblNama_pemain"
        Me.lblNama_pemain.Size = New System.Drawing.Size(61, 23)
        Me.lblNama_pemain.TabIndex = 17
        Me.lblNama_pemain.Text = "Label1"
        '
        'lblJum_Menang
        '
        Me.lblJum_Menang.AutoSize = True
        Me.lblJum_Menang.BackColor = System.Drawing.Color.Transparent
        Me.lblJum_Menang.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJum_Menang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJum_Menang.Location = New System.Drawing.Point(254, 150)
        Me.lblJum_Menang.Name = "lblJum_Menang"
        Me.lblJum_Menang.Size = New System.Drawing.Size(61, 23)
        Me.lblJum_Menang.TabIndex = 18
        Me.lblJum_Menang.Text = "Label1"
        '
        'lblJum_Kalah
        '
        Me.lblJum_Kalah.AutoSize = True
        Me.lblJum_Kalah.BackColor = System.Drawing.Color.Transparent
        Me.lblJum_Kalah.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJum_Kalah.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJum_Kalah.Location = New System.Drawing.Point(254, 250)
        Me.lblJum_Kalah.Name = "lblJum_Kalah"
        Me.lblJum_Kalah.Size = New System.Drawing.Size(61, 23)
        Me.lblJum_Kalah.TabIndex = 19
        Me.lblJum_Kalah.Text = "Label1"
        '
        'lblJum_Imbang
        '
        Me.lblJum_Imbang.AutoSize = True
        Me.lblJum_Imbang.BackColor = System.Drawing.Color.Transparent
        Me.lblJum_Imbang.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJum_Imbang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblJum_Imbang.Location = New System.Drawing.Point(254, 202)
        Me.lblJum_Imbang.Name = "lblJum_Imbang"
        Me.lblJum_Imbang.Size = New System.Drawing.Size(61, 23)
        Me.lblJum_Imbang.TabIndex = 20
        Me.lblJum_Imbang.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(98, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Jumlah Imbang "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(98, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Jumlah Kalah "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(98, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Jumlah Menang "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(98, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nama Pemain "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(101, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Jumlah Poin"
        '
        'lbl_jumPoin
        '
        Me.lbl_jumPoin.AutoSize = True
        Me.lbl_jumPoin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_jumPoin.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_jumPoin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_jumPoin.Location = New System.Drawing.Point(257, 300)
        Me.lbl_jumPoin.Name = "lbl_jumPoin"
        Me.lbl_jumPoin.Size = New System.Drawing.Size(61, 23)
        Me.lbl_jumPoin.TabIndex = 25
        Me.lbl_jumPoin.Text = "Label1"
        '
        'FormInfoPemain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(423, 412)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_jumPoin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblJum_Imbang)
        Me.Controls.Add(Me.lblJum_Kalah)
        Me.Controls.Add(Me.lblJum_Menang)
        Me.Controls.Add(Me.lblNama_pemain)
        Me.Controls.Add(Me.PictureBoxMinimize)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.btnKembali)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInfoPemain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InfoPemain"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxMinimize As System.Windows.Forms.PictureBox
    Friend WithEvents lblNama_pemain As System.Windows.Forms.Label
    Friend WithEvents lblJum_Menang As System.Windows.Forms.Label
    Friend WithEvents lblJum_Kalah As System.Windows.Forms.Label
    Friend WithEvents lblJum_Imbang As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_jumPoin As System.Windows.Forms.Label
End Class
