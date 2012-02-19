<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Lbl_ScoreRed = New System.Windows.Forms.Label
        Me.Lbl_ScoreBlue = New System.Windows.Forms.Label
        Me.Lbl_BluePlayer = New System.Windows.Forms.Label
        Me.Lbl_RedPlayer = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GridCombo = New System.Windows.Forms.ComboBox
        Me.PB_Paper = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Paper, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Grid:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(335, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Lbl_ScoreRed
        '
        Me.Lbl_ScoreRed.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ScoreRed.Location = New System.Drawing.Point(148, 3)
        Me.Lbl_ScoreRed.Name = "Lbl_ScoreRed"
        Me.Lbl_ScoreRed.Size = New System.Drawing.Size(32, 28)
        Me.Lbl_ScoreRed.TabIndex = 17
        Me.Lbl_ScoreRed.Text = "00"
        Me.Lbl_ScoreRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_ScoreBlue
        '
        Me.Lbl_ScoreBlue.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_ScoreBlue.Location = New System.Drawing.Point(208, 3)
        Me.Lbl_ScoreBlue.Name = "Lbl_ScoreBlue"
        Me.Lbl_ScoreBlue.Size = New System.Drawing.Size(32, 28)
        Me.Lbl_ScoreBlue.TabIndex = 16
        Me.Lbl_ScoreBlue.Text = "00"
        Me.Lbl_ScoreBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_BluePlayer
        '
        Me.Lbl_BluePlayer.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_BluePlayer.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_BluePlayer.Location = New System.Drawing.Point(240, 3)
        Me.Lbl_BluePlayer.Name = "Lbl_BluePlayer"
        Me.Lbl_BluePlayer.Size = New System.Drawing.Size(44, 28)
        Me.Lbl_BluePlayer.TabIndex = 15
        Me.Lbl_BluePlayer.Text = "Blue"
        Me.Lbl_BluePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_RedPlayer
        '
        Me.Lbl_RedPlayer.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_RedPlayer.ForeColor = System.Drawing.Color.Red
        Me.Lbl_RedPlayer.Location = New System.Drawing.Point(108, 3)
        Me.Lbl_RedPlayer.Name = "Lbl_RedPlayer"
        Me.Lbl_RedPlayer.Size = New System.Drawing.Size(44, 28)
        Me.Lbl_RedPlayer.TabIndex = 14
        Me.Lbl_RedPlayer.Text = "Red"
        Me.Lbl_RedPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Location = New System.Drawing.Point(180, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'GridCombo
        '
        Me.GridCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GridCombo.FormattingEnabled = True
        Me.GridCombo.Location = New System.Drawing.Point(40, 7)
        Me.GridCombo.Name = "GridCombo"
        Me.GridCombo.Size = New System.Drawing.Size(64, 21)
        Me.GridCombo.TabIndex = 12
        '
        'PB_Paper
        '
        Me.PB_Paper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PB_Paper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PB_Paper.Location = New System.Drawing.Point(7, 34)
        Me.PB_Paper.Margin = New System.Windows.Forms.Padding(0)
        Me.PB_Paper.Name = "PB_Paper"
        Me.PB_Paper.Size = New System.Drawing.Size(360, 360)
        Me.PB_Paper.TabIndex = 11
        Me.PB_Paper.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 399)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Lbl_ScoreRed)
        Me.Controls.Add(Me.Lbl_ScoreBlue)
        Me.Controls.Add(Me.Lbl_BluePlayer)
        Me.Controls.Add(Me.Lbl_RedPlayer)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GridCombo)
        Me.Controls.Add(Me.PB_Paper)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Dots & Boxes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Paper, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_ScoreRed As System.Windows.Forms.Label
    Friend WithEvents Lbl_ScoreBlue As System.Windows.Forms.Label
    Friend WithEvents Lbl_BluePlayer As System.Windows.Forms.Label
    Friend WithEvents Lbl_RedPlayer As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GridCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PB_Paper As System.Windows.Forms.PictureBox

End Class
