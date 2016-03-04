Public Class fruteria

    Dim n1, n2, n3 As Decimal
    Dim kg1, kg2, kg3 As Decimal
    Dim euro As Decimal


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim t1 As Decimal = TextBox10.Text
        Dim t2 As Decimal = TextBox11.Text
        Dim t3 As Decimal = TextBox12.Text
        Dim op3 As Double
        Dim op2 As Double = TextBox2.Text
        Dim total As Decimal
        Dim resta As Decimal


        total = Me.multi(kg1, t1) + Me.multi(kg2, t2) + Me.multi(kg3, t3)
        TextBox1.Text = total

        op3 = Me.cambio(op2, total)
        TextBox3.Text = op3

        n1 = Me.cambio(n1, t1)
        TextBox4.Text = n1
        n2 = Me.cambio(n2, t2)
        TextBox5.Text = n2
        n3 = Me.cambio(n3, t3)
        TextBox6.Text = n3

        euro = Me.suma(total, euro)
        TextBox13.Text = euro
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Function cambio(ByVal op1 As Double, ByVal op2 As Double) As Double
        Return op1 - op2
    End Function

    Private Function suma(ByVal op1 As Double, ByVal op2 As Double) As Double
        Return op1 + op2
    End Function


    Private Function multi(ByVal c1 As Decimal, ByVal c2 As Decimal) As Decimal
        Return c1 * c2
    End Function
    Private Sub fruteria_Load(sender As Object, e As EventArgs) Handles Me.Load
        n1 = 40
        n2 = 50
        n3 = 60
        kg1 = 7.1
        kg2 = 4.9
        kg3 = 6.2
        euro = 1000

        TextBox13.Text = euro
        TextBox4.Text = n1
        TextBox5.Text = n2
        TextBox6.Text = n3
        TextBox7.Text = kg1
        TextBox8.Text = kg2
        TextBox9.Text = kg3
    End Sub
End Class