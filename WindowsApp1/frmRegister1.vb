Public Class frmRegister1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblRegister.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub lblLastName_Click(sender As Object, e As EventArgs) Handles lblLastName.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtbLastName.TextChanged

    End Sub

    Private Sub lblPassword_Click(sender As Object, e As EventArgs) Handles lblPassword.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub lblConfirmPass_Click(sender As Object, e As EventArgs) Handles lblConfirmPass.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPass.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtbLastName.Clear()
        txtFirstName.Clear()
        txtEmail.Clear()
        txtConfirmPass.Clear()
        txtUser.Clear()
        txtPass.Clear()
        cmbGender.SelectedIndex = -1
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
End Class
