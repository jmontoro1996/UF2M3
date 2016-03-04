Public Class LLamarFuncion
    Public Sub hello(ByVal Name As String)

        MessageBox.Show("Hello, " & Name & "!")

    End Sub
    Public Sub hello2(ByRef Name As String)
        Name = Name + "modificado"
    End Sub

    Public Sub suma(ByVal op1 As Integer, ByVal op2 As Integer)
        Dim suma As Integer
        suma = op1 + op2
        MessageBox.Show(suma)
    End Sub

    Public Sub suma1(ByVal op1 As Integer, ByVal op2 As Integer, ByRef res As Integer)
        res = op1 + op2

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.hello("watsup")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.hello("try")
    End Sub
    Private Function suma3(ByVal op1 As Integer, ByVal op2 As Integer) As Integer
        Return op1 + op2
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim jose As String = " "
        Me.hello("hello!ItsME")

        Me.hello2(jose)
        Me.hello(jose)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim res As Integer
        Me.suma1(3, 4, res)
        MessageBox.Show(res)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim res As Integer
        res = Me.suma3(4, 3)
    End Sub
End Class