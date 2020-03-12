<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ElectricidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.carrosDataSet = New ElectricidadAutomotriz.carrosDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FrenosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MotorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NeumaticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OtrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ElectricidadTableAdapter = New ElectricidadAutomotriz.carrosDataSetTableAdapters.ElectricidadTableAdapter()
        Me.ClientesTableAdapter = New ElectricidadAutomotriz.carrosDataSetTableAdapters.ClientesTableAdapter()
        Me.FrenosTableAdapter = New ElectricidadAutomotriz.carrosDataSetTableAdapters.FrenosTableAdapter()
        Me.MotorTableAdapter = New ElectricidadAutomotriz.carrosDataSetTableAdapters.MotorTableAdapter()
        Me.NeumaticosTableAdapter = New ElectricidadAutomotriz.carrosDataSetTableAdapters.NeumaticosTableAdapter()
        Me.OtrosTableAdapter = New ElectricidadAutomotriz.carrosDataSetTableAdapters.OtrosTableAdapter()
        CType(Me.ElectricidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carrosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FrenosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeumaticosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OtrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElectricidadBindingSource
        '
        Me.ElectricidadBindingSource.DataMember = "Electricidad"
        Me.ElectricidadBindingSource.DataSource = Me.carrosDataSet
        '
        'carrosDataSet
        '
        Me.carrosDataSet.DataSetName = "carrosDataSet"
        Me.carrosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.carrosDataSet
        '
        'FrenosBindingSource
        '
        Me.FrenosBindingSource.DataMember = "Frenos"
        Me.FrenosBindingSource.DataSource = Me.carrosDataSet
        '
        'MotorBindingSource
        '
        Me.MotorBindingSource.DataMember = "Motor"
        Me.MotorBindingSource.DataSource = Me.carrosDataSet
        '
        'NeumaticosBindingSource
        '
        Me.NeumaticosBindingSource.DataMember = "Neumaticos"
        Me.NeumaticosBindingSource.DataSource = Me.carrosDataSet
        '
        'OtrosBindingSource
        '
        Me.OtrosBindingSource.DataMember = "Otros"
        Me.OtrosBindingSource.DataSource = Me.carrosDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ElectricidadBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.ClientesBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.FrenosBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.MotorBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.NeumaticosBindingSource
        ReportDataSource6.Name = "DataSet6"
        ReportDataSource6.Value = Me.OtrosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ElectricidadAutomotriz.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 78)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(782, 386)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(495, 29)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Image = Global.ElectricidadAutomotriz.My.Resources.Resources.lupa_de_busqueda
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(622, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 40)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "BUSCAR"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ElectricidadTableAdapter
        '
        Me.ElectricidadTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'FrenosTableAdapter
        '
        Me.FrenosTableAdapter.ClearBeforeFill = True
        '
        'MotorTableAdapter
        '
        Me.MotorTableAdapter.ClearBeforeFill = True
        '
        'NeumaticosTableAdapter
        '
        Me.NeumaticosTableAdapter.ClearBeforeFill = True
        '
        'OtrosTableAdapter
        '
        Me.OtrosTableAdapter.ClearBeforeFill = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 476)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.ElectricidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carrosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FrenosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeumaticosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OtrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ElectricidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents carrosDataSet As ElectricidadAutomotriz.carrosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FrenosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MotorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NeumaticosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OtrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectricidadTableAdapter As ElectricidadAutomotriz.carrosDataSetTableAdapters.ElectricidadTableAdapter
    Friend WithEvents ClientesTableAdapter As ElectricidadAutomotriz.carrosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents FrenosTableAdapter As ElectricidadAutomotriz.carrosDataSetTableAdapters.FrenosTableAdapter
    Friend WithEvents MotorTableAdapter As ElectricidadAutomotriz.carrosDataSetTableAdapters.MotorTableAdapter
    Friend WithEvents NeumaticosTableAdapter As ElectricidadAutomotriz.carrosDataSetTableAdapters.NeumaticosTableAdapter
    Friend WithEvents OtrosTableAdapter As ElectricidadAutomotriz.carrosDataSetTableAdapters.OtrosTableAdapter
End Class
