<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInvitePemain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInvitePemain))
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btnInvitePemain = New System.Windows.Forms.Button
        Me.btnKembali = New System.Windows.Forms.Button
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 83)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(203, 246)
        Me.TextBox1.TabIndex = 0
        '
        'btnInvitePemain
        '
        Me.btnInvitePemain.Location = New System.Drawing.Point(114, 352)
        Me.btnInvitePemain.Name = "btnInvitePemain"
        Me.btnInvitePemain.Size = New System.Drawing.Size(88, 31)
        Me.btnInvitePemain.TabIndex = 1
        Me.btnInvitePemain.Text = "Invite"
        Me.btnInvitePemain.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(229, 352)
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
        Me.PictureBoxClose.Location = New System.Drawing.Point(333, 29)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxClose.TabIndex = 3
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMinimize.BackgroundImage = CType(resources.GetObject("PictureBoxMinimize.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(365, 29)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxMinimize.TabIndex = 4
        Me.PictureBoxMinimize.TabStop = False
        '
        'FormInvitePemain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(416, 414)
        Me.Controls.Add(Me.PictureBoxMinimize)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.btnInvitePemain)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormInvitePemain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Invite Pemain"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnInvitePemain As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents PictureBoxClose As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxMinimize As System.Windows.Forms.PictureBox
End Class
