' PROGRAM:      Mortgage Calculator with Amortization Schedule - Final Project
' DESCRIPTION:  A mortgage calculator that will calculate montly payments and interest
'               rates in an amortization schedule.
' CREATE BY:    Ethan S. Lin on March 17, 2013

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ' set tooltip for the PMI labels
        tltpPMI.SetToolTip(lblPMIAmt, "An additional percentage increase applied to the original mortgage loan" &
                           ControlChars.NewLine & "if the downpayment is less than 20% but no more than 20%. This increase" &
                           ControlChars.NewLine & "will be dropped once the borrower fulfilled 20% of the mortgage payments.")

        ' initially select the values for downpayment,
        ' loan term, and interest rate
        cmbDownpayment.SelectedIndex = 2
        cmbLoanTerm.SelectedIndex = 1
        cmbInterestRate.SelectedIndex = 0

    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstvAmortization_ColumnWidthChanging(sender As Object, e As System.Windows.Forms.ColumnWidthChangingEventArgs) Handles lstvAmortization.ColumnWidthChanging

        ' Prevent the listview column from resizing
        If Me.lstvAmortization.Columns(e.ColumnIndex).Width < 128 _
            OrElse Me.lstvAmortization.Columns(e.ColumnIndex).Width > 128 Then
            e.Cancel = True
            e.NewWidth = Me.lstvAmortization.Columns(e.ColumnIndex).Width
        End If

    End Sub

    Private Sub btnCalc_Click(sender As System.Object, e As System.EventArgs) Handles btnCalc.Click

        Dim dblHomeValue As Double

        Double.TryParse(txtHomeVal.Text, dblHomeValue)

        If dblHomeValue >= 15000 Then

            Dim dblDownpaymentPercent As Double
            Dim dblDownpayment As Double
            Dim dblPMI As Double
            Dim dblPMIAmt As Double
            Dim dblLoanAmt As Double

            Double.TryParse(cmbDownpayment.Text, dblDownpaymentPercent)

            dblDownpayment = dblHomeValue * (dblDownpaymentPercent / 100)

            lblDownpaymentAmt.Text = dblDownpayment.ToString("C2")

            dblLoanAmt = dblHomeValue - dblDownpayment
            lblLoanAmt.Text = dblLoanAmt.ToString("C2")

            If dblDownpaymentPercent < 20 Then
                dblPMI = 20 - dblDownpaymentPercent
                dblPMIAmt = dblLoanAmt * (dblPMI / 100)
                lblPMIAmt.Text = dblPMIAmt.ToString("C2")
            Else
                lblPMIAmt.Text = "$0.00"
            End If
            
        Else

            MessageBox.Show("Your home value must be greater than or equal to $15,000.",
                            "Mortgage Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtHomeVal.Focus()

        End If
        
    End Sub

    Private Sub cmbDownpayment_TextChanged(sender As Object, e As System.EventArgs) Handles cmbDownpayment.TextChanged

        Dim dblDownpaymentPercentage As Double

        Double.TryParse(cmbDownpayment.Text, dblDownpaymentPercentage)

        If dblDownpaymentPercentage < 0 OrElse dblDownpaymentPercentage > 100 Then
            MessageBox.Show("Downpayment percentage must be between 0 and 100.",
                            "Mortgage Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)

            cmbDownpayment.Text = "0"
            cmbDownpayment.SelectAll()
        End If

    End Sub
End Class
