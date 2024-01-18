Public Class Form1
    Dim Num1 As Decimal
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pic1.BorderStyle = BorderStyle.FixedSingle
        Pic2.BorderStyle = BorderStyle.FixedSingle
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or
                     Asc(e.KeyChar) = 8 Or
                     (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub
    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Com1.SelectedIndexChanged
        If Com1.SelectedIndex = 0 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\America.gif")
        ElseIf Com1.SelectedIndex = 1 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\Europe.gif")
        ElseIf Com1.SelectedIndex = 2 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\US.gif")
        ElseIf Com1.SelectedIndex = 3 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\Japan.gif")
        ElseIf Com1.SelectedIndex = 4 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\Philippines.gif")
        ElseIf Com1.SelectedIndex = 5 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\Arab.gif")
        ElseIf Com1.SelectedIndex = 6 Then
            Pic1.Image = Image.FromFile(Application.StartupPath + "\Pics\China.gif")
        End If
    End Sub
    Private Sub CB2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Com2.SelectedIndexChanged
        If Com2.SelectedIndex = 0 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\America.gif")
        ElseIf Com2.SelectedIndex = 1 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\Eunion.gif")
        ElseIf Com2.SelectedIndex = 2 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\ukay.gif")
        ElseIf Com2.SelectedIndex = 3 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\jap.gif")
        ElseIf Com2.SelectedIndex = 4 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\Philippines.gif")
        ElseIf Com2.SelectedIndex = 5 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\Arab.gif")
        ElseIf Com2.SelectedIndex = 6 Then
            Pic2.Image = Image.FromFile(Application.StartupPath + "\Pics\Chine.gif")
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        If TextBox1.Text = "" Then
            MessageBox.Show("Enter a number to convert!")
            Num1 = 0
        Else
            Num1 = TextBox1.Text
        End If
        'USD'
        If Com1.SelectedIndex = 0 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Num1 * 1)
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.95, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.82, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 149.39, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 56.81, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 3.75, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 7.23, 2))
            End If
            'EURO'
        ElseIf Com1.SelectedIndex = 1 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Math.Round(Num1 * 1.05, 2))
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 1, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.87, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 157.28, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 59.82, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 3.95, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 7.56, 2))
            End If
            'GBP'
        ElseIf Com1.SelectedIndex = 2 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Math.Round(Num1 * 1.22, 2))
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 1.16, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 1, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 181.73, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 69.09, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 4.56, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 8.73, 2))
            End If
            'JPY'
        ElseIf Com1.SelectedIndex = 3 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.0067, 2))
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.0064, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.0055, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 1, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.38, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.025, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.048, 2))
            End If

            'PHP'
        ElseIf Com1.SelectedIndex = 4 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.018, 2))
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.017, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.014, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 2.63, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 1, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.066, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.13, 2))
            End If
            'SAR'
        ElseIf Com1.SelectedIndex = 5 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.27, 2))
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.25, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.22, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 39.84, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 15.15, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 1, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 1.91, 2))
            End If

            'CNY'
        ElseIf Com1.SelectedIndex = 6 Then
            If Com2.SelectedIndex = 0 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.14, 2))
            ElseIf Com2.SelectedIndex = 1 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.13, 2))
            ElseIf Com2.SelectedIndex = 2 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.11, 2))
            ElseIf Com2.SelectedIndex = 3 Then
                TextBox2.AppendText(Math.Round(Num1 * 20.82, 2))
            ElseIf Com2.SelectedIndex = 4 Then
                TextBox2.AppendText(Math.Round(Num1 * 7.92, 2))
            ElseIf Com2.SelectedIndex = 5 Then
                TextBox2.AppendText(Math.Round(Num1 * 0.52, 2))
            ElseIf Com2.SelectedIndex = 6 Then
                TextBox2.AppendText(Math.Round(Num1 * 1, 2))
            End If
        Else
            MessageBox.Show("Select a currency!")
        End If

        If Num1 = 0 Then
            TextBox2.Clear()
        End If

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Button1.BackColor = System.Drawing.Color.LightBlue
    End Sub
    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.BackColor = System.Drawing.Color.Transparent
    End Sub
End Class
