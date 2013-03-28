' PROGRAM:      Mortgage Calculator - Final Project
' DESCRIPTION:  A mortgage calculator that will calculate montly payments,
'               total payment amount, and total interest.
' CREATE BY:    Ethan S. Lin on March 17, 2013

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ' set tooltip for the PMI labels
        tltpPMI.SetToolTip(lblPMIAmt, "An additional percentage increase applied to the original mortgage loan" &
                           ControlChars.NewLine & "if the downpayment is less than 20% but no more than 20%.")

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
            Dim boolPMIApplied As Boolean
            Dim dblLoanAmt As Double

            Double.TryParse(cmbDownpayment.Text, dblDownpaymentPercent)

            dblDownpayment = dblHomeValue * (dblDownpaymentPercent / 100)

            lblDownpaymentAmt.Text = dblDownpayment.ToString("C2")

            dblLoanAmt = dblHomeValue - dblDownpayment
            lblLoanAmt.Text = dblLoanAmt.ToString("C2")

            If dblDownpaymentPercent < 20 Then
                dblPMI = (20 - dblDownpaymentPercent) / 2
                dblPMIAmt = dblLoanAmt * (dblPMI / 100)
                lblPMIAmt.Text = dblPMIAmt.ToString("C2")
                lblPMI.Text = dblPMI.ToString & "% PMI"
                boolPMIApplied = True
            Else
                lblPMIAmt.Text = "$0.00"
                lblPMI.Text = "PMI"
                boolPMIApplied = False
            End If

            lblTotalLoan.Text = (dblLoanAmt + dblPMIAmt).ToString("C2")

            calculateMonthlyPayment((dblLoanAmt + dblPMIAmt))

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

    Private Sub cmbInterestRate_TextChanged(sender As Object, e As System.EventArgs) Handles cmbInterestRate.TextChanged
        Dim dblInterestPercentage As Double

        Double.TryParse(cmbInterestRate.Text, dblInterestPercentage)

        If dblInterestPercentage < 0 OrElse dblInterestPercentage > 100 Then
            MessageBox.Show("Interest rate percentage must be between 0 and 100.",
                            "Mortgage Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error)

            cmbInterestRate.Text = "0"
            cmbInterestRate.SelectAll()
        End If

    End Sub

    Private Function calculateMonthlyPayment(ByVal dblLoad As Double) As Double
        Dim dblPayment As Double

        Dim dblPrincipal As Double
        Dim dblInterest As Double
        Dim dblRate As Double
        Dim intTerm As Integer
        Dim dblTotalPmt As Double
        Dim dblTotalInterest As Double

        dblPrincipal = dblLoad

        Double.TryParse(cmbInterestRate.Text, dblInterest)
        dblRate = dblInterest / 100

        Integer.TryParse(cmbLoanTerm.SelectedItem.ToString, intTerm)

        dblPayment = -Financial.Pmt(dblRate / 12, intTerm * 12, dblPrincipal)
        lblMonthlyAmt.Text = dblPayment.ToString("C2")

        dblTotalPmt = dblPayment * (intTerm * 12)
        lblPaymentAmt.Text = dblTotalPmt.ToString("C2")
        lblPayment.Text = "Total of " & (intTerm * 12).ToString & " payments"

        dblTotalInterest = dblTotalPmt - dblPrincipal
        lblInterestAmt.Text = dblTotalInterest.ToString("C2")

        populateTheListView(intTerm * 12, dblPayment, dblTotalPmt, dblTotalInterest)

        Return dblPayment
    End Function

    Private Sub populateTheListView(ByVal intTerm As Integer, ByVal dblMPMT As Double,
                                    ByVal dblPMT As Double, ByVal dblInt As Double)
        ' clear the list first
        lstvAmortization.Items.Clear()

        Dim arrRowItem(4) As String
        Dim lstvItem As ListViewItem
        Dim dblBalance As Double
        Dim dblMonthlyInterest As Double

        dblMonthlyInterest = dblMPMT - ((dblPMT - dblInt) / intTerm)

        dblBalance = dblPMT

        For rowCount As Integer = 1 To intTerm Step 1

            ' column 1: month
            arrRowItem(0) = rowCount.ToString()

            ' column 2: balance
            arrRowItem(1) = dblBalance.ToString("N2")

            ' column 3: interest
            arrRowItem(2) = dblMonthlyInterest.ToString("N2")

            ' column 4 : monthly payment
            arrRowItem(3) = dblMPMT.ToString("N2")

            ' column 5: end balance
            arrRowItem(4) = (dblBalance - dblMPMT).ToString("N2")

            ' update balance
            dblBalance -= dblMPMT

            ' add to list view
            lstvItem = New ListViewItem(arrRowItem)
            lstvAmortization.Items.Add(lstvItem)

        Next rowCount

    End Sub

End Class
