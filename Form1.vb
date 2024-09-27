Public Class Form1
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtSubTotal.TextChanged

    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnAmount_Click(sender As Object, e As EventArgs) Handles btnAmount.Click
        'Calculate the amount of each item
        Dim qty1 As Decimal = CDec(txtQty1.Text)
        Dim qty2 As Decimal = CDec(txtQty2.Text)
        Dim qty3 As Decimal = CDec(txtQty3.Text)
        Dim qty4 As Decimal = CDec(txtQty4.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim amount1 As Decimal = (qty1 * price1)
        'display results in the amount1 textbox
        txtAmount1.Text = amount1.ToString()
        Dim amount2 As Decimal = (qty2 * price2)
        'display results in the amount2 textbox
        txtAmount2.Text = amount2.ToString()
        Dim amount3 As Decimal = (qty3 * price3)
        'display results in the amount3 textbox
        txtAmount3.Text = amount3.ToString()
        Dim amount4 As Decimal = (qty4 * price4)
        'display results in the amount4 textbox
        txtAmount4.Text = amount4.ToString()




    End Sub

    Private Sub btnSubTotal_Click(sender As Object, e As EventArgs) Handles btnSubTotal.Click
        Dim qty1 As Decimal = CDec(txtQty1.Text)
        Dim qty2 As Decimal = CDec(txtQty2.Text)
        Dim qty3 As Decimal = CDec(txtQty3.Text)
        Dim qty4 As Decimal = CDec(txtQty4.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim amount1 As Decimal = (qty1 * price1)
        Dim amount2 As Decimal = (qty2 * price2)
        Dim amount3 As Decimal = (qty3 * price3)
        Dim amount4 As Decimal = (qty4 * price4)
        'Calculate the sub total
        Dim subtotal = (amount1 + amount2 + amount3 + amount4)
        'Display subtotal results in the subtotal textbox
        txtSubTotal.Text = subtotal.ToString()

    End Sub

    Private Sub btntax_Click(sender As Object, e As EventArgs) Handles btntax.Click
        'Calculate tax
        Dim qty1 As Decimal = CDec(txtQty1.Text)
        Dim qty2 As Decimal = CDec(txtQty2.Text)
        Dim qty3 As Decimal = CDec(txtQty3.Text)
        Dim qty4 As Decimal = CDec(txtQty4.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim amount1 As Decimal = (qty1 * price1)
        Dim amount2 As Decimal = (qty2 * price2)
        Dim amount3 As Decimal = (qty3 * price3)
        Dim amount4 As Decimal = (qty4 * price4)
        Dim subtotal = (amount1 + amount2 + amount3 + amount4)
        Dim tax As Decimal = (0.18 * subtotal)
        ' Display tax results in the tax textbox
        txtTax.Text = tax.ToString()
    End Sub

    Private Sub btndiscount_Click(sender As Object, e As EventArgs) Handles btndiscount.Click
        'calc Discount
        Dim qty1 As Decimal = CDec(txtQty1.Text)
        Dim qty2 As Decimal = CDec(txtQty2.Text)
        Dim qty3 As Decimal = CDec(txtQty3.Text)
        Dim qty4 As Decimal = CDec(txtQty4.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim amount1 As Decimal = (qty1 * price1)
        Dim amount2 As Decimal = (qty2 * price2)
        Dim amount3 As Decimal = (qty3 * price3)
        Dim amount4 As Decimal = (qty4 * price4)
        Dim subtotal = (amount1 + amount2 + amount3 + amount4)
        Dim Discount As Decimal = (0.1 * subtotal)
        'Display Discount results in the discount  text box
        txtDiscount.Text = Discount.ToString()
    End Sub

    Private Sub btnTotalAmount_Click(sender As Object, e As EventArgs) Handles btnTotalAmount.Click
        'calculate the total amount
        Dim qty1 As Decimal = CDec(txtQty1.Text)
        Dim qty2 As Decimal = CDec(txtQty2.Text)
        Dim qty3 As Decimal = CDec(txtQty3.Text)
        Dim qty4 As Decimal = CDec(txtQty4.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim amount1 As Decimal = (qty1 * price1)
        Dim amount2 As Decimal = (qty2 * price2)
        Dim amount3 As Decimal = (qty3 * price3)
        Dim amount4 As Decimal = (qty4 * price4)
        Dim subtotal = (amount1 + amount2 + amount3 + amount4)
        Dim Discount As Decimal = (0.1 * subtotal)
        Dim Totalamount As Decimal = (subtotal - Discount)
        'display TotalAmount results in the total amount text box
        txtTotalAmount.Text = Totalamount.ToString()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnDate_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim datetime As String
        datetime = DateAndTime.Now.ToString()
        txtDateTime.Text = datetime







    End Sub
End Class
