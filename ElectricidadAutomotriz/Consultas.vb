Public Class Consultas

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarrosDataSet)

    End Sub

    Private Sub Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size 'TODO: This line of code loads data into the 'CarrosDataSet.Otros' table. You can move, or remove it, as needed.
        Me.OtrosTableAdapter.Fill(Me.CarrosDataSet.Otros)
        'TODO: This line of code loads data into the 'CarrosDataSet.Neumaticos' table. You can move, or remove it, as needed.
        Me.NeumaticosTableAdapter.Fill(Me.CarrosDataSet.Neumaticos)
        'TODO: This line of code loads data into the 'CarrosDataSet.Motor' table. You can move, or remove it, as needed.
        Me.MotorTableAdapter.Fill(Me.CarrosDataSet.Motor)
        'TODO: This line of code loads data into the 'CarrosDataSet.Frenos' table. You can move, or remove it, as needed.
        Me.FrenosTableAdapter.Fill(Me.CarrosDataSet.Frenos)
        'TODO: This line of code loads data into the 'CarrosDataSet.Electricidad' table. You can move, or remove it, as needed.
        Me.ElectricidadTableAdapter.Fill(Me.CarrosDataSet.Electricidad)
        'TODO: This line of code loads data into the 'CarrosDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.CarrosDataSet.Clientes)
        ClientesDataGridView.ClearSelection()
        ElectricidadDataGridView.ClearSelection()
        FrenosDataGridView.ClearSelection()
        MotorDataGridView.ClearSelection()
        OtrosDataGridView.ClearSelection()
        NeumaticosDataGridView.ClearSelection()
    End Sub

    Private Sub MotorDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MotorDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClientesTableAdapter.FillBy(Me.CarrosDataSet.Clientes, TextBox1.Text)
        Me.MotorTableAdapter.FillBy(Me.CarrosDataSet.Motor, TextBox1.Text)
        Me.ElectricidadTableAdapter.FillBy(Me.CarrosDataSet.Electricidad, TextBox1.Text)
        Me.FrenosTableAdapter.FillBy(Me.CarrosDataSet.Frenos, TextBox1.Text)
        Me.OtrosTableAdapter.FillBy(Me.CarrosDataSet.Otros, TextBox1.Text)
        Me.NeumaticosTableAdapter.FillBy(Me.CarrosDataSet.Neumaticos, TextBox1.Text)

        ClientesDataGridView.ClearSelection()
        ElectricidadDataGridView.ClearSelection()
        FrenosDataGridView.ClearSelection()
        MotorDataGridView.ClearSelection()
        OtrosDataGridView.ClearSelection()
        NeumaticosDataGridView.ClearSelection()
    End Sub
    Dim CONSULTAELIMINAR As String
    Dim RESPUESTA As Byte
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RESPUESTA = MsgBox("¿SEGURO DESEA ELIMINAR EL REGISTRO?", vbYesNo, "ELIMINAR")
        If RESPUESTA = vbYes Then
            Me.ClientesTableAdapter.DeleteClientes(TextBox1.Text)
            Me.ElectricidadTableAdapter.DeleteElectricidad(TextBox1.Text)
            Me.MotorTableAdapter.DeleteMotor(TextBox1.Text)
            Me.FrenosTableAdapter.DeleteFrenos(TextBox1.Text)
            Me.OtrosTableAdapter.DeleteOtros(TextBox1.Text)
            Me.NeumaticosTableAdapter.DeleteNeumaticos(TextBox1.Text)
            MsgBox("REGISTRO ELIMINADO", vbInformation, "ELIMINADO")
        End If
        Me.ClientesTableAdapter.Fill(Me.CarrosDataSet.Clientes)
        Me.ElectricidadTableAdapter.Fill(Me.CarrosDataSet.Electricidad)
        Me.MotorTableAdapter.Fill(Me.CarrosDataSet.Motor)
        Me.FrenosTableAdapter.Fill(Me.CarrosDataSet.Frenos)
        Me.OtrosTableAdapter.Fill(Me.CarrosDataSet.Otros)
        Me.NeumaticosTableAdapter.Fill(Me.CarrosDataSet.Neumaticos)
        ClientesDataGridView.ClearSelection()
        ElectricidadDataGridView.ClearSelection()
        FrenosDataGridView.ClearSelection()
        MotorDataGridView.ClearSelection()
        OtrosDataGridView.ClearSelection()
        NeumaticosDataGridView.ClearSelection()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ConsultaRut.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Reporte.Show()
    End Sub
End Class