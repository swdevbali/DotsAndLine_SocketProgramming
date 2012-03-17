<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBuatRoom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBuatRoom))
        Me.lblNamaRoom = New System.Windows.Forms.Label()
        Me.lblUkuranPapan = New System.Windows.Forms.Label()
        Me.txtNamaRoom = New System.Windows.Forms.TextBox()
        Me.cbxPapan = New System.Windows.Forms.ComboBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNamaRoom
        '
        Me.lblNamaRoom.AutoSize = True
        Me.lblNamaRoom.BackColor = System.Drawing.Color.Transparent
        Me.lblNamaRoom.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamaRoom.ForeColor = System.Drawing.Color.White
        Me.lblNamaRoom.Location = New System.Drawing.Point(82, 105)
        Me.lblNamaRoom.Name = "lblNamaRoom"
        Me.lblNamaRoom.Size = New System.Drawing.Size(83, 20)
        Me.lblNamaRoom.TabIndex = 0
        Me.lblNamaRoom.Text = "Nama Room"
        '
        'lblUkuranPapan
        '
        Me.lblUkuranPapan.AutoSize = True
        Me.lblUkuranPapan.BackColor = System.Drawing.Color.Transparent
        Me.lblUkuranPapan.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUkuranPapan.ForeColor = System.Drawing.Color.White
        Me.lblUkuranPapan.Location = New System.Drawing.Point(82, 148)
        Me.lblUkuranPapan.Name = "lblUkuranPapan"
        Me.lblUkuranPapan.Size = New System.Drawing.Size(92, 20)
        Me.lblUkuranPapan.TabIndex = 2
        Me.lblUkuranPapan.Text = "Ukuran Papan"
        '
        'txtNamaRoom
        '
        Me.txtNamaRoom.Location = New System.Drawing.Point(233, 105)
        Me.txtNamaRoom.Name = "txtNamaRoom"
        Me.txtNamaRoom.Size = New System.Drawing.Size(121, 20)
        Me.txtNamaRoom.TabIndex = 3
        '
        'cbxPapan
        '
        Me.cbxPapan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPapan.DropDownWidth = 64
        Me.cbxPapan.FormattingEnabled = True
        Me.cbxPapan.Items.AddRange(New Object() {"4", "5", "6", "7", "8", "9", "10"})
        Me.cbxPapan.Location = New System.Drawing.Point(233, 147)
        Me.cbxPapan.Name = "cbxPapan"
        Me.cbxPapan.Size = New System.Drawing.Size(121, 21)
        Me.cbxPapan.TabIndex = 12
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(92, 196)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(88, 31)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "OK"
        Me.btnOk.UseMnemonic = False
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(266, 196)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(88, 31)
        Me.btnKembali.TabIndex = 7
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxClose.Location = New System.Drawing.Point(322, 19)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxClose.TabIndex = 8
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMinimize.BackgroundImage = CType(resources.GetObject("PictureBoxMinimize.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(359, 19)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxMinimize.TabIndex = 9
        Me.PictureBoxMinimize.TabStop = False
        '
        'FormBuatRoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(421, 299)
        Me.Controls.Add(Me.PictureBoxMinimize)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbxPapan)
        Me.Controls.Add(Me.txtNamaRoom)
        Me.Controls.Add(Me.lblUkuranPapan)
        Me.Controls.Add(Me.lblNamaRoom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBuatRoom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buat Room"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNamaRoom As System.Windows.Forms.Label
    Friend WithEvents lblUkuranPapan As System.Windows.Forms.Label
    Friend WithEvents txtNamaRoom As System.Windows.Forms.TextBox
    Friend WithEvents cbxPapan As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxMinimize As System.Windows.Forms.PictureBox
End Class
