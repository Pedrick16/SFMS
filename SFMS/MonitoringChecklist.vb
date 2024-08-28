Public Class MonitoringChecklist
    Private Sub MonitoringChecklist_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.Rows.Add("7:00")
        DataGridView1.Rows.Add("8:00")
        DataGridView1.Rows.Add("9:00")
        DataGridView1.Rows.Add("10:00")
        DataGridView1.Rows.Add("11:00")
        DataGridView1.Rows.Add("12:00")
        DataGridView1.Rows.Add("01:00")
        DataGridView1.Rows.Add("02:00")
        DataGridView1.Rows.Add("03:00")
        DataGridView1.Rows.Add("04:00")
        DataGridView1.Rows.Add("05:00")
        DataGridView1.Rows.Add("06:00")


    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class