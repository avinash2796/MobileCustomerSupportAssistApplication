<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MobileDataSet = New WindowsApplication1.MobileDataSet()
        Me.MobnetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MobnetTableAdapter = New WindowsApplication1.MobileDataSetTableAdapters.MobnetTableAdapter()
        Me.NSlnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OperatorNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USSDCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobnetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NSlnoDataGridViewTextBoxColumn, Me.OperatorNameDataGridViewTextBoxColumn, Me.USSDCodeDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MobnetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 342)
        Me.DataGridView1.TabIndex = 0
        '
        'MobileDataSet
        '
        Me.MobileDataSet.DataSetName = "MobileDataSet"
        Me.MobileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MobnetBindingSource
        '
        Me.MobnetBindingSource.DataMember = "Mobnet"
        Me.MobnetBindingSource.DataSource = Me.MobileDataSet
        '
        'MobnetTableAdapter
        '
        Me.MobnetTableAdapter.ClearBeforeFill = True
        '
        'NSlnoDataGridViewTextBoxColumn
        '
        Me.NSlnoDataGridViewTextBoxColumn.DataPropertyName = "NSlno"
        Me.NSlnoDataGridViewTextBoxColumn.HeaderText = "NSlno"
        Me.NSlnoDataGridViewTextBoxColumn.Name = "NSlnoDataGridViewTextBoxColumn"
        '
        'OperatorNameDataGridViewTextBoxColumn
        '
        Me.OperatorNameDataGridViewTextBoxColumn.DataPropertyName = "Operator Name"
        Me.OperatorNameDataGridViewTextBoxColumn.HeaderText = "Operator Name"
        Me.OperatorNameDataGridViewTextBoxColumn.Name = "OperatorNameDataGridViewTextBoxColumn"
        '
        'USSDCodeDataGridViewTextBoxColumn
        '
        Me.USSDCodeDataGridViewTextBoxColumn.DataPropertyName = "USSD Code"
        Me.USSDCodeDataGridViewTextBoxColumn.HeaderText = "USSD Code"
        Me.USSDCodeDataGridViewTextBoxColumn.Name = "USSDCodeDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'Form20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 342)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form20"
        Me.Text = "Form20"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobnetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MobileDataSet As MobileDataSet
    Friend WithEvents MobnetBindingSource As BindingSource
    Friend WithEvents MobnetTableAdapter As MobileDataSetTableAdapters.MobnetTableAdapter
    Friend WithEvents NSlnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OperatorNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents USSDCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
