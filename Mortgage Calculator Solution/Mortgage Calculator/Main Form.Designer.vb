<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lstvAmortization = New System.Windows.Forms.ListView()
        Me.clmTerm = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmPayment = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmInterest = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblHomeVal = New System.Windows.Forms.Label()
        Me.lblDownPmt = New System.Windows.Forms.Label()
        Me.txtHomeVal = New System.Windows.Forms.TextBox()
        Me.lblLoanAmt = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.cmbLoanTerm = New System.Windows.Forms.ComboBox()
        Me.cmbInterestRate = New System.Windows.Forms.ComboBox()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.lblPMI = New System.Windows.Forms.Label()
        Me.lblPMIAmt = New System.Windows.Forms.Label()
        Me.tltpPMI = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbDownpayment = New System.Windows.Forms.ComboBox()
        Me.grpAmortization = New System.Windows.Forms.GroupBox()
        Me.radMonthly = New System.Windows.Forms.RadioButton()
        Me.radYearly = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDownpaymentAmt = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDownPercent = New System.Windows.Forms.Label()
        Me.lblRatePercent = New System.Windows.Forms.Label()
        Me.lblTotalInterest = New System.Windows.Forms.Label()
        Me.lblInterestAmt = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblPaymentAmt = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblMonthlyAmt = New System.Windows.Forms.Label()
        Me.lblDownpayment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpAmortization.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstvAmortization
        '
        Me.lstvAmortization.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmTerm, Me.clmPayment, Me.clmInterest, Me.clmBalance})
        Me.lstvAmortization.FullRowSelect = True
        Me.lstvAmortization.GridLines = True
        Me.lstvAmortization.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstvAmortization.HoverSelection = True
        Me.lstvAmortization.Location = New System.Drawing.Point(268, 73)
        Me.lstvAmortization.MultiSelect = False
        Me.lstvAmortization.Name = "lstvAmortization"
        Me.lstvAmortization.Size = New System.Drawing.Size(516, 304)
        Me.lstvAmortization.TabIndex = 17
        Me.lstvAmortization.UseCompatibleStateImageBehavior = False
        Me.lstvAmortization.View = System.Windows.Forms.View.Details
        '
        'clmTerm
        '
        Me.clmTerm.Text = "Term"
        Me.clmTerm.Width = 129
        '
        'clmPayment
        '
        Me.clmPayment.Text = "Payment"
        Me.clmPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmPayment.Width = 129
        '
        'clmInterest
        '
        Me.clmInterest.Text = "Interest"
        Me.clmInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmInterest.Width = 129
        '
        'clmBalance
        '
        Me.clmBalance.Text = "Balance"
        Me.clmBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.clmBalance.Width = 129
        '
        'lblHomeVal
        '
        Me.lblHomeVal.Location = New System.Drawing.Point(12, 12)
        Me.lblHomeVal.Name = "lblHomeVal"
        Me.lblHomeVal.Size = New System.Drawing.Size(120, 23)
        Me.lblHomeVal.TabIndex = 0
        Me.lblHomeVal.Text = "Home &Value:"
        Me.lblHomeVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDownPmt
        '
        Me.lblDownPmt.Location = New System.Drawing.Point(12, 42)
        Me.lblDownPmt.Name = "lblDownPmt"
        Me.lblDownPmt.Size = New System.Drawing.Size(120, 23)
        Me.lblDownPmt.TabIndex = 2
        Me.lblDownPmt.Text = "&Downpayment:"
        Me.lblDownPmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHomeVal
        '
        Me.txtHomeVal.Location = New System.Drawing.Point(137, 12)
        Me.txtHomeVal.Name = "txtHomeVal"
        Me.txtHomeVal.Size = New System.Drawing.Size(125, 24)
        Me.txtHomeVal.TabIndex = 1
        '
        'lblLoanAmt
        '
        Me.lblLoanAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmt.Location = New System.Drawing.Point(150, 79)
        Me.lblLoanAmt.Name = "lblLoanAmt"
        Me.lblLoanAmt.Size = New System.Drawing.Size(112, 40)
        Me.lblLoanAmt.TabIndex = 21
        Me.lblLoanAmt.Text = "$0"
        Me.lblLoanAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTerm
        '
        Me.lblTerm.Location = New System.Drawing.Point(12, 203)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(120, 23)
        Me.lblTerm.TabIndex = 4
        Me.lblTerm.Text = "Loan &Term:"
        Me.lblTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbLoanTerm
        '
        Me.cmbLoanTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoanTerm.FormattingEnabled = True
        Me.cmbLoanTerm.Items.AddRange(New Object() {"10", "15", "20", "25", "30"})
        Me.cmbLoanTerm.Location = New System.Drawing.Point(16, 230)
        Me.cmbLoanTerm.Name = "cmbLoanTerm"
        Me.cmbLoanTerm.Size = New System.Drawing.Size(60, 26)
        Me.cmbLoanTerm.TabIndex = 5
        '
        'cmbInterestRate
        '
        Me.cmbInterestRate.FormattingEnabled = True
        Me.cmbInterestRate.Items.AddRange(New Object() {"2.68", "3.85", "4.18"})
        Me.cmbInterestRate.Location = New System.Drawing.Point(142, 230)
        Me.cmbInterestRate.Name = "cmbInterestRate"
        Me.cmbInterestRate.Size = New System.Drawing.Size(100, 26)
        Me.cmbInterestRate.TabIndex = 7
        '
        'lblInterestRate
        '
        Me.lblInterestRate.Location = New System.Drawing.Point(138, 203)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(120, 23)
        Me.lblInterestRate.TabIndex = 6
        Me.lblInterestRate.Text = "Interest &Rate:"
        Me.lblInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPMI
        '
        Me.lblPMI.AutoSize = True
        Me.lblPMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPMI.Location = New System.Drawing.Point(52, 172)
        Me.lblPMI.Name = "lblPMI"
        Me.lblPMI.Size = New System.Drawing.Size(172, 16)
        Me.lblPMI.TabIndex = 24
        Me.lblPMI.Text = "Private Mortgage Insurance"
        Me.lblPMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPMIAmt
        '
        Me.lblPMIAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPMIAmt.Location = New System.Drawing.Point(82, 140)
        Me.lblPMIAmt.Name = "lblPMIAmt"
        Me.lblPMIAmt.Size = New System.Drawing.Size(112, 40)
        Me.lblPMIAmt.TabIndex = 23
        Me.lblPMIAmt.Text = "$0"
        Me.lblPMIAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tltpPMI
        '
        Me.tltpPMI.AutoPopDelay = 12000
        Me.tltpPMI.InitialDelay = 500
        Me.tltpPMI.IsBalloon = True
        Me.tltpPMI.ReshowDelay = 100
        Me.tltpPMI.ToolTipTitle = "Private Mortgage Insurance (PMI)"
        '
        'cmbDownpayment
        '
        Me.cmbDownpayment.FormattingEnabled = True
        Me.cmbDownpayment.Items.AddRange(New Object() {"10", "15", "20", "25", "30"})
        Me.cmbDownpayment.Location = New System.Drawing.Point(137, 41)
        Me.cmbDownpayment.Name = "cmbDownpayment"
        Me.cmbDownpayment.Size = New System.Drawing.Size(100, 26)
        Me.cmbDownpayment.TabIndex = 3
        '
        'grpAmortization
        '
        Me.grpAmortization.Controls.Add(Me.radMonthly)
        Me.grpAmortization.Controls.Add(Me.radYearly)
        Me.grpAmortization.Location = New System.Drawing.Point(13, 266)
        Me.grpAmortization.Name = "grpAmortization"
        Me.grpAmortization.Size = New System.Drawing.Size(249, 65)
        Me.grpAmortization.TabIndex = 8
        Me.grpAmortization.TabStop = False
        Me.grpAmortization.Text = "Amortization Schedule"
        '
        'radMonthly
        '
        Me.radMonthly.Location = New System.Drawing.Point(124, 29)
        Me.radMonthly.Name = "radMonthly"
        Me.radMonthly.Size = New System.Drawing.Size(78, 22)
        Me.radMonthly.TabIndex = 1
        Me.radMonthly.Text = "&Monthly"
        Me.radMonthly.UseVisualStyleBackColor = True
        '
        'radYearly
        '
        Me.radYearly.Checked = True
        Me.radYearly.Location = New System.Drawing.Point(7, 29)
        Me.radYearly.Name = "radYearly"
        Me.radYearly.Size = New System.Drawing.Size(66, 22)
        Me.radYearly.TabIndex = 0
        Me.radYearly.TabStop = True
        Me.radYearly.Text = "&Yearly"
        Me.radYearly.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(13, 337)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(118, 40)
        Me.btnCalc.TabIndex = 9
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(144, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 40)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDownpaymentAmt
        '
        Me.lblDownpaymentAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownpaymentAmt.Location = New System.Drawing.Point(12, 79)
        Me.lblDownpaymentAmt.Name = "lblDownpaymentAmt"
        Me.lblDownpaymentAmt.Size = New System.Drawing.Size(112, 40)
        Me.lblDownpaymentAmt.TabIndex = 19
        Me.lblDownpaymentAmt.Text = "$0"
        Me.lblDownpaymentAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(83, 230)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(49, 26)
        Me.lblYear.TabIndex = 25
        Me.lblYear.Text = "Years"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDownPercent
        '
        Me.lblDownPercent.Location = New System.Drawing.Point(240, 41)
        Me.lblDownPercent.Name = "lblDownPercent"
        Me.lblDownPercent.Size = New System.Drawing.Size(22, 26)
        Me.lblDownPercent.TabIndex = 18
        Me.lblDownPercent.Text = "%"
        Me.lblDownPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRatePercent
        '
        Me.lblRatePercent.Location = New System.Drawing.Point(244, 229)
        Me.lblRatePercent.Name = "lblRatePercent"
        Me.lblRatePercent.Size = New System.Drawing.Size(22, 26)
        Me.lblRatePercent.TabIndex = 26
        Me.lblRatePercent.Text = "%"
        Me.lblRatePercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotalInterest
        '
        Me.lblTotalInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalInterest.Location = New System.Drawing.Point(610, 47)
        Me.lblTotalInterest.Name = "lblTotalInterest"
        Me.lblTotalInterest.Size = New System.Drawing.Size(110, 16)
        Me.lblTotalInterest.TabIndex = 16
        Me.lblTotalInterest.Text = "Total Interest"
        '
        'lblInterestAmt
        '
        Me.lblInterestAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestAmt.Location = New System.Drawing.Point(608, 12)
        Me.lblInterestAmt.Name = "lblInterestAmt"
        Me.lblInterestAmt.Size = New System.Drawing.Size(155, 40)
        Me.lblInterestAmt.TabIndex = 15
        Me.lblInterestAmt.Text = "$0"
        Me.lblInterestAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPayment
        '
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(445, 47)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(110, 16)
        Me.lblPayment.TabIndex = 14
        Me.lblPayment.Text = "Total Payment"
        '
        'lblPaymentAmt
        '
        Me.lblPaymentAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentAmt.Location = New System.Drawing.Point(443, 12)
        Me.lblPaymentAmt.Name = "lblPaymentAmt"
        Me.lblPaymentAmt.Size = New System.Drawing.Size(155, 40)
        Me.lblPaymentAmt.TabIndex = 13
        Me.lblPaymentAmt.Text = "$0"
        Me.lblPaymentAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMonthly
        '
        Me.lblMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthly.Location = New System.Drawing.Point(281, 47)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(110, 16)
        Me.lblMonthly.TabIndex = 12
        Me.lblMonthly.Text = "Monthly Payment"
        '
        'lblMonthlyAmt
        '
        Me.lblMonthlyAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyAmt.Location = New System.Drawing.Point(278, 12)
        Me.lblMonthlyAmt.Name = "lblMonthlyAmt"
        Me.lblMonthlyAmt.Size = New System.Drawing.Size(155, 40)
        Me.lblMonthlyAmt.TabIndex = 11
        Me.lblMonthlyAmt.Text = "$0"
        Me.lblMonthlyAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDownpayment
        '
        Me.lblDownpayment.AutoSize = True
        Me.lblDownpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownpayment.Location = New System.Drawing.Point(21, 111)
        Me.lblDownpayment.Name = "lblDownpayment"
        Me.lblDownpayment.Size = New System.Drawing.Size(94, 16)
        Me.lblDownpayment.TabIndex = 20
        Me.lblDownpayment.Text = "Downpayment"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Loan Amount"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 387)
        Me.Controls.Add(Me.lblPMI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDownpayment)
        Me.Controls.Add(Me.lblMonthly)
        Me.Controls.Add(Me.lblMonthlyAmt)
        Me.Controls.Add(Me.lblPayment)
        Me.Controls.Add(Me.lblPaymentAmt)
        Me.Controls.Add(Me.lblTotalInterest)
        Me.Controls.Add(Me.lblInterestAmt)
        Me.Controls.Add(Me.lblRatePercent)
        Me.Controls.Add(Me.lblDownPercent)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDownpaymentAmt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpAmortization)
        Me.Controls.Add(Me.cmbDownpayment)
        Me.Controls.Add(Me.lblPMIAmt)
        Me.Controls.Add(Me.cmbInterestRate)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.cmbLoanTerm)
        Me.Controls.Add(Me.lblTerm)
        Me.Controls.Add(Me.lblLoanAmt)
        Me.Controls.Add(Me.txtHomeVal)
        Me.Controls.Add(Me.lblDownPmt)
        Me.Controls.Add(Me.lblHomeVal)
        Me.Controls.Add(Me.lstvAmortization)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mortgage Calculator"
        Me.grpAmortization.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstvAmortization As System.Windows.Forms.ListView
    Friend WithEvents lblHomeVal As System.Windows.Forms.Label
    Friend WithEvents lblDownPmt As System.Windows.Forms.Label
    Friend WithEvents txtHomeVal As System.Windows.Forms.TextBox
    Friend WithEvents lblLoanAmt As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents cmbLoanTerm As System.Windows.Forms.ComboBox
    Friend WithEvents cmbInterestRate As System.Windows.Forms.ComboBox
    Friend WithEvents lblInterestRate As System.Windows.Forms.Label
    Friend WithEvents lblPMI As System.Windows.Forms.Label
    Friend WithEvents lblPMIAmt As System.Windows.Forms.Label
    Friend WithEvents tltpPMI As System.Windows.Forms.ToolTip
    Friend WithEvents cmbDownpayment As System.Windows.Forms.ComboBox
    Friend WithEvents grpAmortization As System.Windows.Forms.GroupBox
    Friend WithEvents radMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents radYearly As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDownpaymentAmt As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblDownPercent As System.Windows.Forms.Label
    Friend WithEvents lblRatePercent As System.Windows.Forms.Label
    Friend WithEvents clmTerm As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmPayment As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmInterest As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmBalance As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblTotalInterest As System.Windows.Forms.Label
    Friend WithEvents lblInterestAmt As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblPaymentAmt As System.Windows.Forms.Label
    Friend WithEvents lblMonthly As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyAmt As System.Windows.Forms.Label
    Friend WithEvents lblDownpayment As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
