Public Class Form4

        Dim total As Integer
        Private Sub btnShower_Click(sender As Object, e As EventArgs) Handles btnShower.Click
            total += 40
            lblSelection.Text += "Shower"
        End Sub

        Private Sub btnBath_Click(sender As Object, e As EventArgs) Handles btnBath.Click
            total += 5
            lblSelection.Text += "Bath"
        End Sub

        Private Sub btnToilet_Click(sender As Object, e As EventArgs) Handles btnToilet.Click
            total += 5
            lblSelection.Text += "Toilet"
        End Sub

        Private Sub btnWasher_Click(sender As Object, e As EventArgs) Handles btnWasher.Click
            total += 40
            lblSelection.Text += "Washing Machine"
        End Sub

        Private Sub btnDishwasher_Click(sender As Object, e As EventArgs) Handles btnDishwasher.Click
            total += 5
            lblSelection.Text += "Dishwasher"
        End Sub

        Private Sub btnDishes_Click(sender As Object, e As EventArgs) Handles btnDishes.Click
            total += 25
            lblSelection.Text += "Dishes by Hand"
        End Sub

        Private Sub btnPool_Click(sender As Object, e As EventArgs) Handles btnPool.Click
            total += 50
            lblSelection.Text += "Pool"
        End Sub

        Private Sub btnLawn_Click(sender As Object, e As EventArgs) Handles btnLawn.Click
            total += 30
            lblSelection.Text += "Lawn Watering"
        End Sub

        Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
            lblTotal.Text = total
        End Sub

        Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
            lblSelection.Text += " + "
        End Sub

        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            lblSelection.Text = ""
            total = 0
            lblTotal.Text = 0
        End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class
