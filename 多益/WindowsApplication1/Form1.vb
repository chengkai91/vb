Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer




        a = Val(TextBox1.Text)
        Select Case a
            Case 860 To 990
                Label1.Text = "金色(860~990)"
                Label1.BackColor = System.Drawing.Color.FromName("Gold")
            Case 730 To 855
                Label1.Text = "藍色(730~855)"
                Label1.BackColor = System.Drawing.Color.FromName("SteelBlue")
            Case 470 To 725
                Label1.Text = "綠色(470~725)"
                Label1.BackColor = System.Drawing.Color.FromName("SpringGreen")
            Case 220 To 465
                Label1.Text = "棕色(220~465)"
                Label1.BackColor = System.Drawing.Color.FromName("Maroon")
            Case 10 To 215
                Label1.Text = "橘色(10~215)"
                Label1.BackColor = System.Drawing.Color.FromName("OrangeRed")


        End Select



    End Sub
End Class
