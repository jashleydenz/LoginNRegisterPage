Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set ComboBox1 to DropDownList so user cannot type input
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

        ' Add choices to ComboBox1
        ComboBox1.Items.Add("Daily")
        ComboBox1.Items.Add("Weekly")
        ComboBox1.Items.Add("Monthly")
        ComboBox1.Items.Add("Yearly")


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Get the input from TextBox3
        Dim inputTextBox3 As String = TextBox3.Text

        ' Get the selected item from ComboBox1
        Dim selectedComboBox1 As String = ComboBox1.SelectedItem.ToString()

        ' Display the input in TextBox4 and TextBox5
        TextBox4.Text = inputTextBox3
        TextBox5.Text = selectedComboBox1

        ' Clear TextBox3 and ComboBox1
        TextBox3.Clear()

        ' ComboBox Input Remover '
        ComboBox1.Text = ""
        ComboBox1.SelectedIndex = -1

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress        ' Allow only numeric input ' 
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
