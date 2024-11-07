Public Class Calculator1
    Dim firstNumber, secondNumber As Integer
    Dim operationResult As Double
    Private Sub Calculator1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub secondNum_TextChanged(sender As Object, e As EventArgs) Handles secondInput.TextChanged

    End Sub

    Private Sub firstNum_TextChanged(sender As Object, e As EventArgs) Handles firstInput.TextChanged

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        operationResult = firstNumber + secondNumber
        result.Text = operationResult

    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub substractBtn_Click(sender As Object, e As EventArgs) Handles substractBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        operationResult = firstNumber - secondNumber
        result.Text = operationResult
    End Sub

    Private Sub multipleBtn_Click(sender As Object, e As EventArgs) Handles multipleBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        operationResult = firstNumber * secondNumber
        result.Text = operationResult
    End Sub

    Private Sub divisionBtn_Click(sender As Object, e As EventArgs) Handles divisionBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        operationResult = firstNumber / secondNumber
        result.Text = operationResult
    End Sub

    Private Sub moduloBtn_Click(sender As Object, e As EventArgs) Handles moduloBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        Dim operationResult As Integer = firstNumber Mod secondNumber
        result.Text = operationResult
    End Sub

    Private Sub lessThanBtn_Click(sender As Object, e As EventArgs) Handles lessThanBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        Dim operationResult As Boolean = firstNumber < secondNumber
        result.Text = operationResult
    End Sub

    Private Sub moreThanBtn_Click(sender As Object, e As EventArgs) Handles moreThanBtn.Click
        If firstInput.Text = "" Or secondInput.Text = "" Then
            MessageBox.Show("Harap isi input terlebih dahulu")
            Exit Sub
        End If

        firstNumber = Val(firstInput.Text)
        secondNumber = Val(secondInput.Text)
        Dim operationResult As Boolean = firstNumber > secondNumber
        result.Text = operationResult
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        firstInput.Clear()
        secondInput.Clear()
        result.Clear()
    End Sub
End Class
