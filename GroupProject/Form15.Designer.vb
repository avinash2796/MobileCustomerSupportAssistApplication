<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Me.TarrifBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TarrifTableAdapter = New WindowsApplication1.MobileDataSetTableAdapters.TarrifTableAdapter()
        Me.TSlnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValidityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MobileDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarrifBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TSlnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.ValidityDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TarrifBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 350)
        Me.DataGridView1.TabIndex = 0
        '
        'MobileDataSet
        '
        Me.MobileDataSet.DataSetName = "MobileDataSet"
        Me.MobileDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TarrifBindingSource
        '
        Me.TarrifBindingSource.DataMember = "Tarrif"
        Me.TarrifBindingSource.DataSource = Me.MobileDataSet
        '
        'TarrifTableAdapter
        '
        Me.TarrifTableAdapter.ClearBeforeFill = True
        '
        'TSlnoDataGridViewTextBoxColumn
        '
        Me.TSlnoDataGridViewTextBoxColumn.DataPropertyName = "TSlno"
        Me.TSlnoDataGridViewTextBoxColumn.HeaderText = "TSlno"
        Me.TSlnoDataGridViewTextBoxColumn.Name = "TSlnoDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'ValidityDataGridViewTextBoxColumn
        '
        Me.ValidityDataGridViewTextBoxColumn.DataPropertyName = "Validity"
        Me.ValidityDataGridViewTextBoxColumn.HeaderText = "Validity"
        Me.ValidityDataGridViewTextBoxColumn.Name = "ValidityDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 351)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form15"
        Me.Text = "Form15"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MobileDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarrifBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MobileDataSet As MobileDataSet
    Friend WithEvents TarrifBindingSource As BindingSource
    Friend WithEvents TarrifTableAdapter As MobileDataSetTableAdapters.TarrifTableAdapter
    Friend WithEvents TSlnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValidityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
