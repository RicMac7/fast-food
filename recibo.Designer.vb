<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recibo
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TransacaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FastfoodDataSet = New McDonalds.fastfoodDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TransacaoTableAdapter = New McDonalds.fastfoodDataSetTableAdapters.transacaoTableAdapter()
        CType(Me.TransacaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TransacaoBindingSource
        '
        Me.TransacaoBindingSource.DataMember = "transacao"
        Me.TransacaoBindingSource.DataSource = Me.FastfoodDataSet
        '
        'FastfoodDataSet
        '
        Me.FastfoodDataSet.DataSetName = "fastfoodDataSet"
        Me.FastfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TransacaoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "McDonalds.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(463, 890)
        Me.ReportViewer1.TabIndex = 0
        '
        'TransacaoTableAdapter
        '
        Me.TransacaoTableAdapter.ClearBeforeFill = True
        '
        'recibo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(463, 890)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "recibo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo"
        CType(Me.TransacaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FastfoodDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FastfoodDataSet As fastfoodDataSet
    Friend WithEvents TransacaoBindingSource As BindingSource
    Friend WithEvents TransacaoTableAdapter As fastfoodDataSetTableAdapters.transacaoTableAdapter
End Class
