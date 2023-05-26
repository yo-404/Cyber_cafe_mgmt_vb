<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SessionsDataSet = New WindowsApp1.sessionsDataSet()
        Me.SessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SessionTableAdapter = New WindowsApp1.sessionsDataSetTableAdapters.sessionTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STARTTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UPTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PCNODataGridViewTextBoxColumn, Me.CUSTOMERNAMEDataGridViewTextBoxColumn, Me.STARTTIMEDataGridViewTextBoxColumn, Me.UPTIMEDataGridViewTextBoxColumn, Me.TOTALTIMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SessionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(59, 100)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(640, 203)
        Me.DataGridView1.TabIndex = 0
        '
        'SessionsDataSet
        '
        Me.SessionsDataSet.DataSetName = "sessionsDataSet"
        Me.SessionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SessionBindingSource
        '
        Me.SessionBindingSource.DataMember = "session"
        Me.SessionBindingSource.DataSource = Me.SessionsDataSet
        '
        'SessionTableAdapter
        '
        Me.SessionTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'PCNODataGridViewTextBoxColumn
        '
        Me.PCNODataGridViewTextBoxColumn.DataPropertyName = "PC NO"
        Me.PCNODataGridViewTextBoxColumn.HeaderText = "PC NO"
        Me.PCNODataGridViewTextBoxColumn.Name = "PCNODataGridViewTextBoxColumn"
        '
        'CUSTOMERNAMEDataGridViewTextBoxColumn
        '
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.DataPropertyName = "CUSTOMER NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.HeaderText = "CUSTOMER NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn.Name = "CUSTOMERNAMEDataGridViewTextBoxColumn"
        '
        'STARTTIMEDataGridViewTextBoxColumn
        '
        Me.STARTTIMEDataGridViewTextBoxColumn.DataPropertyName = "START TIME"
        Me.STARTTIMEDataGridViewTextBoxColumn.HeaderText = "START TIME"
        Me.STARTTIMEDataGridViewTextBoxColumn.Name = "STARTTIMEDataGridViewTextBoxColumn"
        '
        'UPTIMEDataGridViewTextBoxColumn
        '
        Me.UPTIMEDataGridViewTextBoxColumn.DataPropertyName = "UPTIME"
        Me.UPTIMEDataGridViewTextBoxColumn.HeaderText = "UPTIME"
        Me.UPTIMEDataGridViewTextBoxColumn.Name = "UPTIMEDataGridViewTextBoxColumn"
        '
        'TOTALTIMEDataGridViewTextBoxColumn
        '
        Me.TOTALTIMEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL TIME"
        Me.TOTALTIMEDataGridViewTextBoxColumn.HeaderText = "TOTAL TIME"
        Me.TOTALTIMEDataGridViewTextBoxColumn.Name = "TOTALTIMEDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SEARCH BY NAME"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(214, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(215, 24)
        Me.TextBox1.TabIndex = 2
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SessionsDataSet As sessionsDataSet
    Friend WithEvents SessionBindingSource As BindingSource
    Friend WithEvents SessionTableAdapter As sessionsDataSetTableAdapters.sessionTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STARTTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UPTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
