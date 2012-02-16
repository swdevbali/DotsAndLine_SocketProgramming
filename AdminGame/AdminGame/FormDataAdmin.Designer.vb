<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAdmin
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
        Dim User_adminLabel As System.Windows.Forms.Label
        Dim Id_adminLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDataAdmin))
        Me.AdidotsDataSet = New AdminGame.adidotsDataSet
        Me.AdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminTableAdapter = New AdminGame.adidotsDataSetTableAdapters.adminTableAdapter
        Me.AdminBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.AdminBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.TableAdapterManager1 = New AdminGame.adidotsDataSetTableAdapters.TableAdapterManager
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.User_adminTextBox = New System.Windows.Forms.TextBox
        Me.Id_adminTextBox = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.AdminDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        PasswordLabel = New System.Windows.Forms.Label
        User_adminLabel = New System.Windows.Forms.Label
        Id_adminLabel = New System.Windows.Forms.Label
        CType(Me.AdidotsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(145, 94)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 11
        PasswordLabel.Text = "password:"
        '
        'User_adminLabel
        '
        User_adminLabel.AutoSize = True
        User_adminLabel.Location = New System.Drawing.Point(145, 56)
        User_adminLabel.Name = "User_adminLabel"
        User_adminLabel.Size = New System.Drawing.Size(61, 13)
        User_adminLabel.TabIndex = 9
        User_adminLabel.Text = "user admin:"
        '
        'Id_adminLabel
        '
        Id_adminLabel.AutoSize = True
        Id_adminLabel.Location = New System.Drawing.Point(145, 17)
        Id_adminLabel.Name = "Id_adminLabel"
        Id_adminLabel.Size = New System.Drawing.Size(49, 13)
        Id_adminLabel.TabIndex = 7
        Id_adminLabel.Text = "id admin:"
        '
        'AdidotsDataSet
        '
        Me.AdidotsDataSet.DataSetName = "adidotsDataSet"
        Me.AdidotsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminBindingSource
        '
        Me.AdminBindingSource.DataMember = "admin"
        Me.AdminBindingSource.DataSource = Me.AdidotsDataSet
        '
        'AdminTableAdapter
        '
        Me.AdminTableAdapter.ClearBeforeFill = True
        '
        'AdminBindingNavigator
        '
        Me.AdminBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AdminBindingNavigator.BindingSource = Me.AdminBindingSource
        Me.AdminBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AdminBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AdminBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AdminBindingNavigatorSaveItem})
        Me.AdminBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AdminBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AdminBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AdminBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AdminBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AdminBindingNavigator.Name = "AdminBindingNavigator"
        Me.AdminBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AdminBindingNavigator.Size = New System.Drawing.Size(462, 25)
        Me.AdminBindingNavigator.TabIndex = 0
        Me.AdminBindingNavigator.Text = "BindingNavigator1"
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
        'AdminBindingNavigatorSaveItem
        '
        Me.AdminBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AdminBindingNavigatorSaveItem.Image = CType(resources.GetObject("AdminBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AdminBindingNavigatorSaveItem.Name = "AdminBindingNavigatorSaveItem"
        Me.AdminBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AdminBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.adminTableAdapter = Me.AdminTableAdapter
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.pemainTableAdapter = Nothing
        Me.TableAdapterManager1.statistikTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = AdminGame.adidotsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.03167!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.96832!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(462, 442)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PasswordTextBox)
        Me.Panel1.Controls.Add(User_adminLabel)
        Me.Panel1.Controls.Add(Me.User_adminTextBox)
        Me.Panel1.Controls.Add(Id_adminLabel)
        Me.Panel1.Controls.Add(Me.Id_adminTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(456, 139)
        Me.Panel1.TabIndex = 0
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(212, 91)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 12
        '
        'User_adminTextBox
        '
        Me.User_adminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "user_admin", True))
        Me.User_adminTextBox.Location = New System.Drawing.Point(212, 53)
        Me.User_adminTextBox.Name = "User_adminTextBox"
        Me.User_adminTextBox.Size = New System.Drawing.Size(100, 20)
        Me.User_adminTextBox.TabIndex = 10
        '
        'Id_adminTextBox
        '
        Me.Id_adminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdminBindingSource, "id_admin", True))
        Me.Id_adminTextBox.Location = New System.Drawing.Point(212, 14)
        Me.Id_adminTextBox.Name = "Id_adminTextBox"
        Me.Id_adminTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_adminTextBox.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AdminDataGridView)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 148)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(456, 291)
        Me.Panel2.TabIndex = 1
        '
        'AdminDataGridView
        '
        Me.AdminDataGridView.AutoGenerateColumns = False
        Me.AdminDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.AdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AdminDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.AdminDataGridView.DataSource = Me.AdminBindingSource
        Me.AdminDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdminDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.AdminDataGridView.Name = "AdminDataGridView"
        Me.AdminDataGridView.Size = New System.Drawing.Size(456, 291)
        Me.AdminDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_admin"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_admin"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 74
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "user_admin"
        Me.DataGridViewTextBoxColumn2.HeaderText = "user_admin"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FormDataAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 470)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.AdminBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormDataAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Admin"
        CType(Me.AdidotsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminBindingNavigator.ResumeLayout(False)
        Me.AdminBindingNavigator.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.AdminDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdidotsDataSet As AdminGame.adidotsDataSet
    Friend WithEvents AdminBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdminTableAdapter As AdminGame.adidotsDataSetTableAdapters.adminTableAdapter
    Friend WithEvents AdminBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents AdminBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TableAdapterManager1 As AdminGame.adidotsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents User_adminTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_adminTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AdminDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
