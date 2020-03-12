Public Class Ingreso

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Consultas.ClientesTableAdapter.Insert(DateTimePicker1.Value, TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox11.Text)
        Consultas.MotorTableAdapter.Insert(DateTimePicker1.Value, TextBox4.Text, CheckBox1.Checked, CheckBox2.Checked, CheckBox3.Checked, CheckBox4.Checked, CheckBox5.Checked, TextBox9.Text)
        Consultas.ElectricidadTableAdapter.Insert(DateTimePicker1.Value, TextBox4.Text, CheckBox8.Checked, CheckBox9.Checked, CheckBox10.Checked, CheckBox26.Checked, CheckBox27.Checked, CheckBox28.Checked, TextBox10.Text)
        Consultas.FrenosTableAdapter.Insert(DateTimePicker1.Value, TextBox4.Text, CheckBox13.Checked, CheckBox14.Checked, CheckBox15.Checked, CheckBox16.Checked, TextBox12.Text)
        Consultas.OtrosTableAdapter.Insert(DateTimePicker1.Value, TextBox4.Text, CheckBox17.Checked, CheckBox18.Checked, CheckBox19.Checked, CheckBox20.Checked, CheckBox21.Checked, CheckBox22.Checked, CheckBox23.Checked, TextBox13.Text)
        Consultas.NeumaticosTableAdapter.Insert(DateTimePicker1.Value, TextBox4.Text, TextBox14.Text, CheckBox6.Checked, CheckBox7.Checked, CheckBox24.Checked, CheckBox25.Checked, TextBox15.Text)
        MsgBox("VEHICULO INGRESADO EXITOSAMENTE")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Consultas.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        limpiarCampos(Me)

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
        CheckBox21.Checked = False
        CheckBox22.Checked = False
        CheckBox23.Checked = False
        CheckBox24.Checked = False
        CheckBox25.Checked = False
        CheckBox26.Checked = False
        CheckBox27.Checked = False
        CheckBox28.Checked = False
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class