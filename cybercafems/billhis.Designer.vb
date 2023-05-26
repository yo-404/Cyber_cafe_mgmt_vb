<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class billhis
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SessionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SessionsDataSet = New WindowsApp1.sessionsDataSet()
        Me.SessionTableAdapter = New WindowsApp1.sessionsDataSetTableAdapters.sessionTableAdapter()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DATETIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SOURCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BWPRINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLOURPRINTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCANSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDataSet = New WindowsApp1.printDataSet()
        Me.PrintTableAdapter = New WindowsApp1.printDataSetTableAdapters.printTableAdapter()
        Me.BillingDataSet = New WindowsApp1.billingDataSet()
        Me.BillingDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BillTableAdapter = New WindowsApp1.billingDataSetTableAdapters.billTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BILLINGDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCNODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STARTTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOPTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALTIMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BWPRINTPAGESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLORPRINTPAGESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTALDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SessionsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillingDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(61, 37)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(156, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "INTERNET SURFING LOG"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(265, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PRINTING LOG"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.BILLINGDATEDataGridViewTextBoxColumn, Me.PCNODataGridViewTextBoxColumn, Me.CUSTOMERNAMEDataGridViewTextBoxColumn, Me.STARTTIMEDataGridViewTextBoxColumn, Me.STOPTIMEDataGridViewTextBoxColumn, Me.TOTALTIMEDataGridViewTextBoxColumn, Me.BWPRINTPAGESDataGridViewTextBoxColumn, Me.COLORPRINTPAGESDataGridViewTextBoxColumn, Me.SCANDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.BillBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 282)
        Me.DataGridView1.TabIndex = 2
        '
        'SessionBindingSource
        '
        Me.SessionBindingSource.DataMember = "session"
        Me.SessionBindingSource.DataSource = Me.SessionsDataSet
        '
        'SessionsDataSet
        '
        Me.SessionsDataSet.DataSetName = "sessionsDataSet"
        Me.SessionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SessionTableAdapter
        '
        Me.SessionTableAdapter.ClearBeforeFill = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.DATETIMEDataGridViewTextBoxColumn, Me.CUSTOMERNAMEDataGridViewTextBoxColumn1, Me.SOURCEDataGridViewTextBoxColumn, Me.BWPRINTDataGridViewTextBoxColumn, Me.COLOURPRINTDataGridViewTextBoxColumn, Me.SCANSDataGridViewTextBoxColumn, Me.TOTALDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.PrintBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(22, 76)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(643, 282)
        Me.DataGridView2.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        '
        'DATETIMEDataGridViewTextBoxColumn
        '
        Me.DATETIMEDataGridViewTextBoxColumn.DataPropertyName = "DATE-TIME"
        Me.DATETIMEDataGridViewTextBoxColumn.HeaderText = "DATE-TIME"
        Me.DATETIMEDataGridViewTextBoxColumn.Name = "DATETIMEDataGridViewTextBoxColumn"
        '
        'CUSTOMERNAMEDataGridViewTextBoxColumn1
        '
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn1.DataPropertyName = "CUSTOMER NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn1.HeaderText = "CUSTOMER NAME"
        Me.CUSTOMERNAMEDataGridViewTextBoxColumn1.Name = "CUSTOMERNAMEDataGridViewTextBoxColumn1"
        '
        'SOURCEDataGridViewTextBoxColumn
        '
        Me.SOURCEDataGridViewTextBoxColumn.DataPropertyName = "SOURCE"
        Me.SOURCEDataGridViewTextBoxColumn.HeaderText = "SOURCE"
        Me.SOURCEDataGridViewTextBoxColumn.Name = "SOURCEDataGridViewTextBoxColumn"
        '
        'BWPRINTDataGridViewTextBoxColumn
        '
        Me.BWPRINTDataGridViewTextBoxColumn.DataPropertyName = "B/W PRINT"
        Me.BWPRINTDataGridViewTextBoxColumn.HeaderText = "B/W PRINT"
        Me.BWPRINTDataGridViewTextBoxColumn.Name = "BWPRINTDataGridViewTextBoxColumn"
        '
        'COLOURPRINTDataGridViewTextBoxColumn
        '
        Me.COLOURPRINTDataGridViewTextBoxColumn.DataPropertyName = "COLOUR PRINT"
        Me.COLOURPRINTDataGridViewTextBoxColumn.HeaderText = "COLOUR PRINT"
        Me.COLOURPRINTDataGridViewTextBoxColumn.Name = "COLOURPRINTDataGridViewTextBoxColumn"
        '
        'SCANSDataGridViewTextBoxColumn
        '
        Me.SCANSDataGridViewTextBoxColumn.DataPropertyName = "SCANS"
        Me.SCANSDataGridViewTextBoxColumn.HeaderText = "SCANS"
        Me.SCANSDataGridViewTextBoxColumn.Name = "SCANSDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn
        '
        Me.TOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn.Name = "TOTALDataGridViewTextBoxColumn"
        '
        'PrintBindingSource
        '
        Me.PrintBindingSource.DataMember = "print"
        Me.PrintBindingSource.DataSource = Me.PrintDataSet
        '
        'PrintDataSet
        '
        Me.PrintDataSet.DataSetName = "printDataSet"
        Me.PrintDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrintTableAdapter
        '
        Me.PrintTableAdapter.ClearBeforeFill = True
        '
        'BillingDataSet
        '
        Me.BillingDataSet.DataSetName = "billingDataSet"
        Me.BillingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BillingDataSetBindingSource
        '
        Me.BillingDataSetBindingSource.DataSource = Me.BillingDataSet
        Me.BillingDataSetBindingSource.Position = 0
        '
        'BillBindingSource
        '
        Me.BillBindingSource.DataMember = "bill"
        Me.BillBindingSource.DataSource = Me.BillingDataSetBindingSource
        '
        'BillTableAdapter
        '
        Me.BillTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'BILLINGDATEDataGridViewTextBoxColumn
        '
        Me.BILLINGDATEDataGridViewTextBoxColumn.DataPropertyName = "BILLING DATE"
        Me.BILLINGDATEDataGridViewTextBoxColumn.HeaderText = "BILLING DATE"
        Me.BILLINGDATEDataGridViewTextBoxColumn.Name = "BILLINGDATEDataGridViewTextBoxColumn"
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
        'STOPTIMEDataGridViewTextBoxColumn
        '
        Me.STOPTIMEDataGridViewTextBoxColumn.DataPropertyName = "STOP TIME"
        Me.STOPTIMEDataGridViewTextBoxColumn.HeaderText = "STOP TIME"
        Me.STOPTIMEDataGridViewTextBoxColumn.Name = "STOPTIMEDataGridViewTextBoxColumn"
        '
        'TOTALTIMEDataGridViewTextBoxColumn
        '
        Me.TOTALTIMEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL TIME"
        Me.TOTALTIMEDataGridViewTextBoxColumn.HeaderText = "TOTAL TIME"
        Me.TOTALTIMEDataGridViewTextBoxColumn.Name = "TOTALTIMEDataGridViewTextBoxColumn"
        '
        'BWPRINTPAGESDataGridViewTextBoxColumn
        '
        Me.BWPRINTPAGESDataGridViewTextBoxColumn.DataPropertyName = "B/W PRINT PAGE(S)"
        Me.BWPRINTPAGESDataGridViewTextBoxColumn.HeaderText = "B/W PRINT PAGE(S)"
        Me.BWPRINTPAGESDataGridViewTextBoxColumn.Name = "BWPRINTPAGESDataGridViewTextBoxColumn"
        '
        'COLORPRINTPAGESDataGridViewTextBoxColumn
        '
        Me.COLORPRINTPAGESDataGridViewTextBoxColumn.DataPropertyName = "COLOR PRINT PAGE(S)"
        Me.COLORPRINTPAGESDataGridViewTextBoxColumn.HeaderText = "COLOR PRINT PAGE(S)"
        Me.COLORPRINTPAGESDataGridViewTextBoxColumn.Name = "COLORPRINTPAGESDataGridViewTextBoxColumn"
        '
        'SCANDataGridViewTextBoxColumn
        '
        Me.SCANDataGridViewTextBoxColumn.DataPropertyName = "SCAN"
        Me.SCANDataGridViewTextBoxColumn.HeaderText = "SCAN"
        Me.SCANDataGridViewTextBoxColumn.Name = "SCANDataGridViewTextBoxColumn"
        '
        'TOTALDataGridViewTextBoxColumn1
        '
        Me.TOTALDataGridViewTextBoxColumn1.DataPropertyName = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn1.HeaderText = "TOTAL"
        Me.TOTALDataGridViewTextBoxColumn1.Name = "TOTALDataGridViewTextBoxColumn1"
        '
        'billhis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "billhis"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SessionsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillingDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SessionsDataSet As sessionsDataSet
    Friend WithEvents SessionBindingSource As BindingSource
    Friend WithEvents SessionTableAdapter As sessionsDataSetTableAdapters.sessionTableAdapter
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents PrintDataSet As printDataSet
    Friend WithEvents PrintBindingSource As BindingSource
    Friend WithEvents PrintTableAdapter As printDataSetTableAdapters.printTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DATETIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERNAMEDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SOURCEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BWPRINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COLOURPRINTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SCANSDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BillingDataSetBindingSource As BindingSource
    Friend WithEvents BillingDataSet As billingDataSet
    Friend WithEvents BillBindingSource As BindingSource
    Friend WithEvents BillTableAdapter As billingDataSetTableAdapters.billTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BILLINGDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PCNODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUSTOMERNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STARTTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents STOPTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALTIMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BWPRINTPAGESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COLORPRINTPAGESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SCANDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TOTALDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
