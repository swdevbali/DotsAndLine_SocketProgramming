<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataPemain
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
        Me.components = New System.ComponentModel.Container
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim User_pemainLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataPemain))
        Me.AdidotsDataSet = New AdminGame.adidotsDataSet
        Me.PemainBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PemainBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PemainBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.PemainTableAdapter = New AdminGame.adidotsDataSetTableAdapters.pemainTableAdapter
        Me.TableAdapterManager = New AdminGame.adidotsDataSetTableAdapters.TableAdapterManager
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.User_pemainTextBox = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PemainDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        PasswordLabel = New System.Windows.Forms.Label
        User_pemainLabel = New System.Windows.Forms.Label
        CType(Me.AdidotsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemainBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PemainBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PemainBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PemainDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(157, 79)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "password:"
        '
        'User_pemainLabel
        '
        User_pemainLabel.AutoSize = True
        User_pemainLabel.Location = New System.Drawing.Point(157, 39)
        User_pemainLabel.Name = "User_pemainLabel"
        User_pemainLabel.Size = New System.Drawing.Size(79, 13)
        User_pemainLabel.TabIndex = 5
        User_pemainLabel.Text = "Nama Pemain :"
        '
        'AdidotsDataSet
        '
        Me.AdidotsDataSet.DataSetName = "adidotsDataSet"
        Me.AdidotsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PemainBindingSource
        '
        Me.PemainBindingSource.DataMember = "pemain"
        Me.PemainBindingSource.DataSource = Me.AdidotsDataSet
        '
        'PemainBindingNavigator
        '
        Me.PemainBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PemainBindingNavigator.BindingSource = Me.PemainBindingSource
        Me.PemainBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PemainBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PemainBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PemainBindingNavigatorSaveItem})
        Me.PemainBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PemainBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PemainBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PemainBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PemainBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PemainBindingNavigator.Name = "PemainBindingNavigator"
        Me.PemainBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PemainBindingNavigator.Size = New System.Drawing.Size(501, 25)
        Me.PemainBindingNavigator.TabIndex = 0
        Me.PemainBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PemainBindingNavigatorSaveItem
        '
        Me.PemainBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PemainBindingNavigatorSaveItem.Image = CType(resources.GetObject("PemainBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PemainBindingNavigatorSaveItem.Name = "PemainBindingNavigatorSaveItem"
        Me.PemainBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PemainBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PemainTableAdapter
        '
        Me.PemainTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.pemainTableAdapter = Me.PemainTableAdapter
        Me.TableAdapterManager.statistikTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AdminGame.adidotsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.96227!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.03773!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(499, 424)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(User_pemainLabel)
        Me.Panel1.Controls.Add(Me.User_pemainTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 138)
        Me.Panel1.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemainBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(242, 79)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 8
        '
        'User_pemainTextBox
        '
        Me.User_pemainTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PemainBindingSource, "user_pemain", True))
        Me.User_pemainTextBox.Location = New System.Drawing.Point(242, 36)
        Me.User_pemainTextBox.Name = "User_pemainTextBox"
        Me.User_pemainTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_pemainTextBox.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PemainDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 147)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 274)
        Me.Panel2.TabIndex = 1
        '
        'PemainDataGridView
        '
        Me.PemainDataGridView.AutoGenerateColumns = False
        Me.PemainDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PemainDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PemainDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.PemainDataGridView.DataSource = Me.PemainBindingSource
        Me.PemainDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PemainDataGridView.GridColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PemainDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.PemainDataGridView.Name = "PemainDataGridView"
        Me.PemainDataGridView.Size = New System.Drawing.Size(493, 274)
        Me.PemainDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "user_pemain"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nama Pemain"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'FormDataPemain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 451)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PemainBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDataPemain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Pemain"
        CType(Me.AdidotsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemainBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PemainBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PemainBindingNavigator.ResumeLayout(False)
        Me.PemainBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PemainDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdidotsDataSet As AdminGame.adidotsDataSet
    Friend WithEvents PemainBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PemainBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PemainBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PemainTableAdapter As AdminGame.adidotsDataSetTableAdapters.pemainTableAdapter
    Friend WithEvents TableAdapterManager As AdminGame.adidotsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_pemainTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PemainDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
