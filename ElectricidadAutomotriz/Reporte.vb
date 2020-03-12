Public Class Reporte

    Private Sub Reporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        'TODO: This line of code loads data into the 'carrosDataSet.Electricidad' table. You can move, or remove it, as needed.
        Me.ElectricidadTableAdapter.Fill(Me.carrosDataSet.Electricidad)
        'TODO: This line of code loads data into the 'carrosDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.carrosDataSet.Clientes)
        'TODO: This line of code loads data into the 'carrosDataSet.Frenos' table. You can move, or remove it, as needed.
        Me.FrenosTableAdapter.Fill(Me.carrosDataSet.Frenos)
        'TODO: This line of code loads data into the 'carrosDataSet.Motor' table. You can move, or remove it, as needed.
        Me.MotorTableAdapter.Fill(Me.carrosDataSet.Motor)
        'TODO: This line of code loads data into the 'carrosDataSet.Neumaticos' table. You can move, or remove it, as needed.
        Me.NeumaticosTableAdapter.Fill(Me.carrosDataSet.Neumaticos)
        'TODO: This line of code loads data into the 'carrosDataSet.Otros' table. You can move, or remove it, as needed.
        Me.OtrosTableAdapter.Fill(Me.carrosDataSet.Otros)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consultas.ClientesTableAdapter.FillBy(Me.carrosDataSet.Clientes, TextBox1.Text)
        Consultas.MotorTableAdapter.FillBy(Me.carrosDataSet.Motor, TextBox1.Text)
        Consultas.ElectricidadTableAdapter.FillBy(Me.carrosDataSet.Electricidad, TextBox1.Text)
        Consultas.FrenosTableAdapter.FillBy(Me.carrosDataSet.Frenos, TextBox1.Text)
        Consultas.OtrosTableAdapter.FillBy(Me.carrosDataSet.Otros, TextBox1.Text)
        Consultas.NeumaticosTableAdapter.FillBy(Me.carrosDataSet.Neumaticos, TextBox1.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class