Public Class ConsultaRut

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CarrosDataSet)

    End Sub

    Private Sub ConsultaRut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CarrosDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.CarrosDataSet.Clientes)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.ClientesTableAdapter.FillBy1(CarrosDataSet.Clientes, TextBox1.Text)
        Me.ClientesDataGridView.ClearSelection()
    End Sub
End Class