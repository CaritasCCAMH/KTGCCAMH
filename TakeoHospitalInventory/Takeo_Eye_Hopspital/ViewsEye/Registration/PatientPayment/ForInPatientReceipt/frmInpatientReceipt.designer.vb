<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInpatientReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInpatientReceipt))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPatient = New System.Windows.Forms.TextBox
        Me.txtAmountWord = New System.Windows.Forms.TextBox
        Me.txtAmountFigureR = New System.Windows.Forms.TextBox
        Me.txtOperationFee = New System.Windows.Forms.TextBox
        Me.txtAritificialEyeFee = New System.Windows.Forms.TextBox
        Me.txtOtherFee = New System.Windows.Forms.TextBox
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtAmountFigureD = New System.Windows.Forms.TextBox
        Me.chkRiel = New System.Windows.Forms.CheckBox
        Me.chkDollar = New System.Windows.Forms.CheckBox
        Me.dtpDateIn = New System.Windows.Forms.DateTimePicker
        Me.txtReceiptNumber = New System.Windows.Forms.TextBox
        Me.txtHN = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtReturnD = New System.Windows.Forms.TextBox
        Me.txtReturnR = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.rdOperationR = New System.Windows.Forms.RadioButton
        Me.rdOperationD = New System.Windows.Forms.RadioButton
        Me.rdArtificialEyeR = New System.Windows.Forms.RadioButton
        Me.rdArtificialEyeD = New System.Windows.Forms.RadioButton
        Me.rdOtherR = New System.Windows.Forms.RadioButton
        Me.rdOtherD = New System.Windows.Forms.RadioButton
        Me.lblRielDolar = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdAddRate = New System.Windows.Forms.Button
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.lblFees = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblCashier = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkSocialFee = New System.Windows.Forms.CheckBox
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.lblReceiptToPrintID = New System.Windows.Forms.Label
        Me.cmdNew = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblCashierLogin = New System.Windows.Forms.Label
        Me.txtOperation = New System.Windows.Forms.ComboBox
        Me.ChPrintPreveiw = New System.Windows.Forms.CheckBox
        Me.cmdFinHN = New System.Windows.Forms.Button
        Me.lblID = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.CashierSave1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.UpdateReceipt1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.PrintReceiptAgain = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TxtExchangeDolar = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtExchangeRiel = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.TxtDonationPay = New System.Windows.Forms.TextBox
        Me.TxtDonateNote = New System.Windows.Forms.TextBox
        Me.BtnDonation = New System.Windows.Forms.Button
        Me.CboDonation = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.ChDonation = New System.Windows.Forms.CheckBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.TxtHospitalFee = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(344, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "In-Patient Receipt"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(499, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "elxvikáybRt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(514, 56)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "kalbriecäT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "HN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = ")anTTYlBI"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 142)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 31)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "cMnYnTwkR)ak;"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 201)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Amount in figure"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 253)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 31)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "cMNayeTAelI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 279)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 31)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "vHkat;"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 329)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 31)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "EPñksb,nimiµt"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 387)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 31)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "epSg²"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 441)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 31)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "srub"
        '
        'txtPatient
        '
        Me.txtPatient.BackColor = System.Drawing.SystemColors.Window
        Me.txtPatient.Font = New System.Drawing.Font("Wat Phnom T3", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatient.Location = New System.Drawing.Point(155, 95)
        Me.txtPatient.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.Size = New System.Drawing.Size(802, 37)
        Me.txtPatient.TabIndex = 4
        '
        'txtAmountWord
        '
        Me.txtAmountWord.BackColor = System.Drawing.Color.Linen
        Me.txtAmountWord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountWord.Location = New System.Drawing.Point(155, 145)
        Me.txtAmountWord.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountWord.Name = "txtAmountWord"
        Me.txtAmountWord.ReadOnly = True
        Me.txtAmountWord.Size = New System.Drawing.Size(802, 26)
        Me.txtAmountWord.TabIndex = 5
        '
        'txtAmountFigureR
        '
        Me.txtAmountFigureR.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtAmountFigureR.Enabled = False
        Me.txtAmountFigureR.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureR.Location = New System.Drawing.Point(169, 188)
        Me.txtAmountFigureR.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountFigureR.Name = "txtAmountFigureR"
        Me.txtAmountFigureR.Size = New System.Drawing.Size(247, 48)
        Me.txtAmountFigureR.TabIndex = 6
        Me.txtAmountFigureR.Text = "0"
        Me.txtAmountFigureR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOperationFee
        '
        Me.txtOperationFee.BackColor = System.Drawing.Color.Azure
        Me.txtOperationFee.Enabled = False
        Me.txtOperationFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperationFee.Location = New System.Drawing.Point(155, 272)
        Me.txtOperationFee.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtOperationFee.Name = "txtOperationFee"
        Me.txtOperationFee.Size = New System.Drawing.Size(261, 36)
        Me.txtOperationFee.TabIndex = 10
        Me.txtOperationFee.Text = "0"
        Me.txtOperationFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAritificialEyeFee
        '
        Me.txtAritificialEyeFee.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtAritificialEyeFee.Enabled = False
        Me.txtAritificialEyeFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAritificialEyeFee.Location = New System.Drawing.Point(155, 324)
        Me.txtAritificialEyeFee.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAritificialEyeFee.Name = "txtAritificialEyeFee"
        Me.txtAritificialEyeFee.Size = New System.Drawing.Size(261, 36)
        Me.txtAritificialEyeFee.TabIndex = 13
        Me.txtAritificialEyeFee.Text = "0"
        Me.txtAritificialEyeFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOtherFee
        '
        Me.txtOtherFee.BackColor = System.Drawing.Color.Wheat
        Me.txtOtherFee.Enabled = False
        Me.txtOtherFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherFee.Location = New System.Drawing.Point(155, 377)
        Me.txtOtherFee.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtOtherFee.Name = "txtOtherFee"
        Me.txtOtherFee.Size = New System.Drawing.Size(261, 36)
        Me.txtOtherFee.TabIndex = 16
        Me.txtOtherFee.Text = "0"
        Me.txtOtherFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotal.Font = New System.Drawing.Font("Arial Black", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal.Location = New System.Drawing.Point(155, 432)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(261, 43)
        Me.txtTotal.TabIndex = 19
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmountFigureD
        '
        Me.txtAmountFigureD.BackColor = System.Drawing.Color.LightYellow
        Me.txtAmountFigureD.Enabled = False
        Me.txtAmountFigureD.Font = New System.Drawing.Font("Arial Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountFigureD.ForeColor = System.Drawing.Color.Navy
        Me.txtAmountFigureD.Location = New System.Drawing.Point(436, 188)
        Me.txtAmountFigureD.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.txtAmountFigureD.Name = "txtAmountFigureD"
        Me.txtAmountFigureD.Size = New System.Drawing.Size(247, 48)
        Me.txtAmountFigureD.TabIndex = 7
        Me.txtAmountFigureD.Text = "0"
        Me.txtAmountFigureD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkRiel
        '
        Me.chkRiel.AutoSize = True
        Me.chkRiel.BackColor = System.Drawing.Color.Transparent
        Me.chkRiel.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRiel.Location = New System.Drawing.Point(693, 194)
        Me.chkRiel.Margin = New System.Windows.Forms.Padding(6, 3, 6, 3)
        Me.chkRiel.Name = "chkRiel"
        Me.chkRiel.Size = New System.Drawing.Size(60, 35)
        Me.chkRiel.TabIndex = 8
        Me.chkRiel.Text = "erol"
        Me.chkRiel.UseVisualStyleBackColor = False
        '
        'chkDollar
        '
        Me.chkDollar.AutoSize = True
        Me.chkDollar.BackColor = System.Drawing.Color.Transparent
        Me.chkDollar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDollar.Location = New System.Drawing.Point(771, 194)
        Me.chkDollar.Name = "chkDollar"
        Me.chkDollar.Size = New System.Drawing.Size(62, 35)
        Me.chkDollar.TabIndex = 9
        Me.chkDollar.Text = "duløar"
        Me.chkDollar.UseVisualStyleBackColor = False
        '
        'dtpDateIn
        '
        Me.dtpDateIn.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateIn.Location = New System.Drawing.Point(607, 57)
        Me.dtpDateIn.Name = "dtpDateIn"
        Me.dtpDateIn.ShowCheckBox = True
        Me.dtpDateIn.Size = New System.Drawing.Size(189, 29)
        Me.dtpDateIn.TabIndex = 3
        '
        'txtReceiptNumber
        '
        Me.txtReceiptNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtReceiptNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNumber.Location = New System.Drawing.Point(607, 16)
        Me.txtReceiptNumber.Name = "txtReceiptNumber"
        Me.txtReceiptNumber.Size = New System.Drawing.Size(257, 31)
        Me.txtReceiptNumber.TabIndex = 1
        '
        'txtHN
        '
        Me.txtHN.BackColor = System.Drawing.SystemColors.Window
        Me.txtHN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHN.Location = New System.Drawing.Point(155, 52)
        Me.txtHN.Name = "txtHN"
        Me.txtHN.Size = New System.Drawing.Size(263, 31)
        Me.txtHN.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtReturnD)
        Me.GroupBox1.Controls.Add(Me.txtReturnR)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Limon S1", 20.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 489)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 127)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "R)ak;Gab;"
        '
        'txtReturnD
        '
        Me.txtReturnD.BackColor = System.Drawing.SystemColors.Window
        Me.txtReturnD.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnD.Location = New System.Drawing.Point(81, 76)
        Me.txtReturnD.Name = "txtReturnD"
        Me.txtReturnD.ReadOnly = True
        Me.txtReturnD.Size = New System.Drawing.Size(355, 36)
        Me.txtReturnD.TabIndex = 1
        Me.txtReturnD.Text = "0"
        Me.txtReturnD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReturnR
        '
        Me.txtReturnR.BackColor = System.Drawing.SystemColors.Window
        Me.txtReturnR.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReturnR.Location = New System.Drawing.Point(81, 28)
        Me.txtReturnR.Name = "txtReturnR"
        Me.txtReturnR.ReadOnly = True
        Me.txtReturnR.Size = New System.Drawing.Size(355, 36)
        Me.txtReturnR.TabIndex = 0
        Me.txtReturnR.Text = "0"
        Me.txtReturnR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(16, 78)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 33)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "duløar"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 33)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "erol"
        '
        'rdOperationR
        '
        Me.rdOperationR.AutoSize = True
        Me.rdOperationR.BackColor = System.Drawing.Color.Transparent
        Me.rdOperationR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOperationR.Location = New System.Drawing.Point(423, 272)
        Me.rdOperationR.Name = "rdOperationR"
        Me.rdOperationR.Size = New System.Drawing.Size(55, 31)
        Me.rdOperationR.TabIndex = 11
        Me.rdOperationR.TabStop = True
        Me.rdOperationR.Text = "erol"
        Me.rdOperationR.UseVisualStyleBackColor = False
        '
        'rdOperationD
        '
        Me.rdOperationD.AutoSize = True
        Me.rdOperationD.BackColor = System.Drawing.Color.Transparent
        Me.rdOperationD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOperationD.Location = New System.Drawing.Point(492, 272)
        Me.rdOperationD.Name = "rdOperationD"
        Me.rdOperationD.Size = New System.Drawing.Size(57, 31)
        Me.rdOperationD.TabIndex = 12
        Me.rdOperationD.TabStop = True
        Me.rdOperationD.Text = "duløar"
        Me.rdOperationD.UseVisualStyleBackColor = False
        '
        'rdArtificialEyeR
        '
        Me.rdArtificialEyeR.AutoSize = True
        Me.rdArtificialEyeR.BackColor = System.Drawing.Color.Transparent
        Me.rdArtificialEyeR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdArtificialEyeR.Location = New System.Drawing.Point(423, 329)
        Me.rdArtificialEyeR.Name = "rdArtificialEyeR"
        Me.rdArtificialEyeR.Size = New System.Drawing.Size(55, 31)
        Me.rdArtificialEyeR.TabIndex = 14
        Me.rdArtificialEyeR.TabStop = True
        Me.rdArtificialEyeR.Text = "erol"
        Me.rdArtificialEyeR.UseVisualStyleBackColor = False
        '
        'rdArtificialEyeD
        '
        Me.rdArtificialEyeD.AutoSize = True
        Me.rdArtificialEyeD.BackColor = System.Drawing.Color.Transparent
        Me.rdArtificialEyeD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdArtificialEyeD.Location = New System.Drawing.Point(492, 330)
        Me.rdArtificialEyeD.Name = "rdArtificialEyeD"
        Me.rdArtificialEyeD.Size = New System.Drawing.Size(57, 31)
        Me.rdArtificialEyeD.TabIndex = 15
        Me.rdArtificialEyeD.TabStop = True
        Me.rdArtificialEyeD.Text = "duløar"
        Me.rdArtificialEyeD.UseVisualStyleBackColor = False
        '
        'rdOtherR
        '
        Me.rdOtherR.AutoSize = True
        Me.rdOtherR.BackColor = System.Drawing.Color.Transparent
        Me.rdOtherR.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOtherR.Location = New System.Drawing.Point(423, 383)
        Me.rdOtherR.Name = "rdOtherR"
        Me.rdOtherR.Size = New System.Drawing.Size(55, 31)
        Me.rdOtherR.TabIndex = 17
        Me.rdOtherR.TabStop = True
        Me.rdOtherR.Text = "erol"
        Me.rdOtherR.UseVisualStyleBackColor = False
        '
        'rdOtherD
        '
        Me.rdOtherD.AutoSize = True
        Me.rdOtherD.BackColor = System.Drawing.Color.Transparent
        Me.rdOtherD.Font = New System.Drawing.Font("Limon S1", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOtherD.Location = New System.Drawing.Point(492, 383)
        Me.rdOtherD.Name = "rdOtherD"
        Me.rdOtherD.Size = New System.Drawing.Size(57, 31)
        Me.rdOtherD.TabIndex = 18
        Me.rdOtherD.TabStop = True
        Me.rdOtherD.Text = "duløar"
        Me.rdOtherD.UseVisualStyleBackColor = False
        '
        'lblRielDolar
        '
        Me.lblRielDolar.AutoSize = True
        Me.lblRielDolar.BackColor = System.Drawing.Color.Transparent
        Me.lblRielDolar.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRielDolar.Location = New System.Drawing.Point(420, 443)
        Me.lblRielDolar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRielDolar.Name = "lblRielDolar"
        Me.lblRielDolar.Size = New System.Drawing.Size(74, 31)
        Me.lblRielDolar.TabIndex = 20
        Me.lblRielDolar.Text = "erol duløar"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cmdAddRate)
        Me.GroupBox2.Controls.Add(Me.txtRate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(966, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(223, 108)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        '
        'cmdAddRate
        '
        Me.cmdAddRate.Enabled = False
        Me.cmdAddRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddRate.Image = Global.KTGSYS.My.Resources.Resources.plus_circle
        Me.cmdAddRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAddRate.Location = New System.Drawing.Point(162, 40)
        Me.cmdAddRate.Name = "cmdAddRate"
        Me.cmdAddRate.Size = New System.Drawing.Size(44, 44)
        Me.cmdAddRate.TabIndex = 1
        Me.cmdAddRate.Text = "..."
        Me.cmdAddRate.UseVisualStyleBackColor = True
        Me.cmdAddRate.Visible = False
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.ForeColor = System.Drawing.Color.Navy
        Me.txtRate.Location = New System.Drawing.Point(18, 40)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(138, 44)
        Me.txtRate.TabIndex = 0
        Me.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFees
        '
        Me.lblFees.AutoSize = True
        Me.lblFees.Location = New System.Drawing.Point(858, 30)
        Me.lblFees.Name = "lblFees"
        Me.lblFees.Size = New System.Drawing.Size(0, 13)
        Me.lblFees.TabIndex = 22
        Me.lblFees.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.lblFees)
        Me.Panel1.Location = New System.Drawing.Point(9, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 72)
        Me.Panel1.TabIndex = 23
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(81, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 20)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Cashier:"
        '
        'lblCashier
        '
        Me.lblCashier.AutoSize = True
        Me.lblCashier.BackColor = System.Drawing.Color.Transparent
        Me.lblCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashier.Location = New System.Drawing.Point(154, 19)
        Me.lblCashier.Name = "lblCashier"
        Me.lblCashier.Size = New System.Drawing.Size(0, 20)
        Me.lblCashier.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSocialFee)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(725, 683)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 91)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Free Fees"
        Me.GroupBox3.Visible = False
        '
        'chkSocialFee
        '
        Me.chkSocialFee.Location = New System.Drawing.Point(18, 26)
        Me.chkSocialFee.Name = "chkSocialFee"
        Me.chkSocialFee.Size = New System.Drawing.Size(83, 24)
        Me.chkSocialFee.TabIndex = 0
        Me.chkSocialFee.Text = "Fees"
        Me.chkSocialFee.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Image = Global.KTGSYS.My.Resources.Resources.search
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(870, 16)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(84, 32)
        Me.cmdSearch.TabIndex = 2
        Me.cmdSearch.Text = "&Find"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'lblReceiptToPrintID
        '
        Me.lblReceiptToPrintID.AutoSize = True
        Me.lblReceiptToPrintID.BackColor = System.Drawing.Color.Transparent
        Me.lblReceiptToPrintID.Location = New System.Drawing.Point(595, 715)
        Me.lblReceiptToPrintID.Name = "lblReceiptToPrintID"
        Me.lblReceiptToPrintID.Size = New System.Drawing.Size(85, 13)
        Me.lblReceiptToPrintID.TabIndex = 29
        Me.lblReceiptToPrintID.Text = "ReceiptIDtoPrint"
        Me.lblReceiptToPrintID.Visible = False
        '
        'cmdNew
        '
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = Global.KTGSYS.My.Resources.Resources.report
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.Location = New System.Drawing.Point(262, 691)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(133, 40)
        Me.cmdNew.TabIndex = 21
        Me.cmdNew.Text = "&New"
        Me.cmdNew.UseVisualStyleBackColor = True
        Me.cmdNew.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Limon S1", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 16)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 31)
        Me.Label16.TabIndex = 141
        Me.Label16.Text = "vHkat;eTAelI ³"
        '
        'lblCashierLogin
        '
        Me.lblCashierLogin.AutoSize = True
        Me.lblCashierLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblCashierLogin.Location = New System.Drawing.Point(436, 691)
        Me.lblCashierLogin.Name = "lblCashierLogin"
        Me.lblCashierLogin.Size = New System.Drawing.Size(68, 13)
        Me.lblCashierLogin.TabIndex = 142
        Me.lblCashierLogin.Text = "CashierLogin"
        Me.lblCashierLogin.Visible = False
        '
        'txtOperation
        '
        Me.txtOperation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtOperation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtOperation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperation.FormattingEnabled = True
        Me.txtOperation.Location = New System.Drawing.Point(101, 19)
        Me.txtOperation.Name = "txtOperation"
        Me.txtOperation.Size = New System.Drawing.Size(225, 28)
        Me.txtOperation.TabIndex = 0
        '
        'ChPrintPreveiw
        '
        Me.ChPrintPreveiw.AutoSize = True
        Me.ChPrintPreveiw.BackColor = System.Drawing.Color.Transparent
        Me.ChPrintPreveiw.Location = New System.Drawing.Point(571, 286)
        Me.ChPrintPreveiw.Name = "ChPrintPreveiw"
        Me.ChPrintPreveiw.Size = New System.Drawing.Size(118, 17)
        Me.ChPrintPreveiw.TabIndex = 153
        Me.ChPrintPreveiw.Text = "Show Print Preveiw"
        Me.ChPrintPreveiw.UseVisualStyleBackColor = False
        Me.ChPrintPreveiw.Visible = False
        '
        'cmdFinHN
        '
        Me.cmdFinHN.Location = New System.Drawing.Point(424, 52)
        Me.cmdFinHN.Name = "cmdFinHN"
        Me.cmdFinHN.Size = New System.Drawing.Size(75, 33)
        Me.cmdFinHN.TabIndex = 154
        Me.cmdFinHN.Text = "Fi&nd HN"
        Me.cmdFinHN.UseVisualStyleBackColor = True
        Me.cmdFinHN.Visible = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Location = New System.Drawing.Point(984, 212)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 155
        Me.lblID.Text = "0"
        Me.lblID.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashierSave1, Me.ToolStripSeparator1, Me.UpdateReceipt1, Me.ToolStripSeparator2, Me.PrintReceiptAgain, Me.ToolStripSeparator3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1147, 26)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CashierSave1
        '
        Me.CashierSave1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.CashierSave1.Image = CType(resources.GetObject("CashierSave1.Image"), System.Drawing.Image)
        Me.CashierSave1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CashierSave1.Name = "CashierSave1"
        Me.CashierSave1.Size = New System.Drawing.Size(103, 23)
        Me.CashierSave1.Text = "&Cashier Save"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'UpdateReceipt1
        '
        Me.UpdateReceipt1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.UpdateReceipt1.Image = CType(resources.GetObject("UpdateReceipt1.Image"), System.Drawing.Image)
        Me.UpdateReceipt1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UpdateReceipt1.Name = "UpdateReceipt1"
        Me.UpdateReceipt1.Size = New System.Drawing.Size(119, 23)
        Me.UpdateReceipt1.Text = "Update Receipt"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        '
        'PrintReceiptAgain
        '
        Me.PrintReceiptAgain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.PrintReceiptAgain.Image = CType(resources.GetObject("PrintReceiptAgain.Image"), System.Drawing.Image)
        Me.PrintReceiptAgain.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintReceiptAgain.Name = "PrintReceiptAgain"
        Me.PrintReceiptAgain.Size = New System.Drawing.Size(102, 23)
        Me.PrintReceiptAgain.Text = "Print Receipt"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(51, 23)
        Me.ToolStripButton4.Text = "Close"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.GroupBox5)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.TxtDonationPay)
        Me.GroupBox8.Controls.Add(Me.TxtDonateNote)
        Me.GroupBox8.Controls.Add(Me.BtnDonation)
        Me.GroupBox8.Controls.Add(Me.CboDonation)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label19)
        Me.GroupBox8.Location = New System.Drawing.Point(492, 448)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(468, 169)
        Me.GroupBox8.TabIndex = 22
        Me.GroupBox8.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TxtExchangeDolar)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.TxtExchangeRiel)
        Me.GroupBox5.Controls.Add(Me.Label26)
        Me.GroupBox5.Location = New System.Drawing.Point(42, 89)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(349, 59)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Donate Supported"
        '
        'TxtExchangeDolar
        '
        Me.TxtExchangeDolar.BackColor = System.Drawing.Color.White
        Me.TxtExchangeDolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExchangeDolar.Location = New System.Drawing.Point(28, 20)
        Me.TxtExchangeDolar.Name = "TxtExchangeDolar"
        Me.TxtExchangeDolar.ReadOnly = True
        Me.TxtExchangeDolar.Size = New System.Drawing.Size(122, 26)
        Me.TxtExchangeDolar.TabIndex = 0
        Me.TxtExchangeDolar.Text = "0"
        Me.TxtExchangeDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(315, 24)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 17)
        Me.Label25.TabIndex = 216
        Me.Label25.Text = "R"
        '
        'TxtExchangeRiel
        '
        Me.TxtExchangeRiel.BackColor = System.Drawing.Color.White
        Me.TxtExchangeRiel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtExchangeRiel.Location = New System.Drawing.Point(188, 20)
        Me.TxtExchangeRiel.Name = "TxtExchangeRiel"
        Me.TxtExchangeRiel.ReadOnly = True
        Me.TxtExchangeRiel.Size = New System.Drawing.Size(122, 26)
        Me.TxtExchangeRiel.TabIndex = 1
        Me.TxtExchangeRiel.Text = "0"
        Me.TxtExchangeRiel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(150, 27)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 17)
        Me.Label26.TabIndex = 216
        Me.Label26.Text = "$"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(375, 61)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(16, 17)
        Me.Label23.TabIndex = 216
        Me.Label23.Text = "$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 61)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(42, 13)
        Me.Label24.TabIndex = 215
        Me.Label24.Text = "Donate"
        '
        'TxtDonationPay
        '
        Me.TxtDonationPay.Enabled = False
        Me.TxtDonationPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDonationPay.Location = New System.Drawing.Point(100, 53)
        Me.TxtDonationPay.Name = "TxtDonationPay"
        Me.TxtDonationPay.Size = New System.Drawing.Size(262, 26)
        Me.TxtDonationPay.TabIndex = 1
        Me.TxtDonationPay.Text = "0"
        Me.TxtDonationPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDonateNote
        '
        Me.TxtDonateNote.Location = New System.Drawing.Point(417, 86)
        Me.TxtDonateNote.Multiline = True
        Me.TxtDonateNote.Name = "TxtDonateNote"
        Me.TxtDonateNote.Size = New System.Drawing.Size(23, 10)
        Me.TxtDonateNote.TabIndex = 2
        Me.TxtDonateNote.Visible = False
        '
        'BtnDonation
        '
        Me.BtnDonation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDonation.Enabled = False
        Me.BtnDonation.Location = New System.Drawing.Point(386, 21)
        Me.BtnDonation.Name = "BtnDonation"
        Me.BtnDonation.Size = New System.Drawing.Size(40, 31)
        Me.BtnDonation.TabIndex = 2
        Me.BtnDonation.Text = "..."
        Me.BtnDonation.UseVisualStyleBackColor = True
        Me.BtnDonation.Visible = False
        '
        'CboDonation
        '
        Me.CboDonation.Enabled = False
        Me.CboDonation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDonation.FormattingEnabled = True
        Me.CboDonation.Location = New System.Drawing.Point(100, 19)
        Me.CboDonation.Name = "CboDonation"
        Me.CboDonation.Size = New System.Drawing.Size(262, 28)
        Me.CboDonation.TabIndex = 0
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(429, 65)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 212
        Me.Label17.Text = "Note:"
        Me.Label17.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 26)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 13)
        Me.Label19.TabIndex = 212
        Me.Label19.Text = "Donate:"
        '
        'ChDonation
        '
        Me.ChDonation.AutoSize = True
        Me.ChDonation.BackColor = System.Drawing.Color.Transparent
        Me.ChDonation.Location = New System.Drawing.Point(496, 433)
        Me.ChDonation.Name = "ChDonation"
        Me.ChDonation.Size = New System.Drawing.Size(69, 17)
        Me.ChDonation.TabIndex = 0
        Me.ChDonation.Text = "Donation"
        Me.ChDonation.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1159, 683)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 17)
        Me.Label21.TabIndex = 213
        Me.Label21.Text = "$"
        Me.Label21.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 691)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 13)
        Me.Label20.TabIndex = 212
        Me.Label20.Text = "Pay:"
        Me.Label20.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.TxtHospitalFee)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtOperation)
        Me.GroupBox4.Location = New System.Drawing.Point(571, 320)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(389, 93)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hos.Fee"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Limon S1", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(332, 51)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(44, 33)
        Me.Label22.TabIndex = 144
        Me.Label22.Text = "erol"
        '
        'TxtHospitalFee
        '
        Me.TxtHospitalFee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHospitalFee.Location = New System.Drawing.Point(101, 52)
        Me.TxtHospitalFee.Name = "TxtHospitalFee"
        Me.TxtHospitalFee.Size = New System.Drawing.Size(227, 30)
        Me.TxtHospitalFee.TabIndex = 1
        Me.TxtHospitalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 56)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 20)
        Me.Label18.TabIndex = 142
        Me.Label18.Text = "Hos.Fee"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Controls.Add(Me.cmdFinHN)
        Me.Panel2.Controls.Add(Me.ChPrintPreveiw)
        Me.Panel2.Controls.Add(Me.ChDonation)
        Me.Panel2.Controls.Add(Me.cmdSearch)
        Me.Panel2.Controls.Add(Me.lblCashier)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.rdOtherD)
        Me.Panel2.Controls.Add(Me.rdOtherR)
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.rdArtificialEyeD)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.rdArtificialEyeR)
        Me.Panel2.Controls.Add(Me.rdOperationD)
        Me.Panel2.Controls.Add(Me.rdOperationR)
        Me.Panel2.Controls.Add(Me.txtHN)
        Me.Panel2.Controls.Add(Me.txtReceiptNumber)
        Me.Panel2.Controls.Add(Me.dtpDateIn)
        Me.Panel2.Controls.Add(Me.chkDollar)
        Me.Panel2.Controls.Add(Me.chkRiel)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.txtOtherFee)
        Me.Panel2.Controls.Add(Me.txtAritificialEyeFee)
        Me.Panel2.Controls.Add(Me.txtOperationFee)
        Me.Panel2.Controls.Add(Me.txtAmountFigureD)
        Me.Panel2.Controls.Add(Me.txtAmountFigureR)
        Me.Panel2.Controls.Add(Me.txtAmountWord)
        Me.Panel2.Controls.Add(Me.txtPatient)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblRielDolar)
        Me.Panel2.Location = New System.Drawing.Point(3, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1195, 645)
        Me.Panel2.TabIndex = 214
        '
        'frmInpatientReceipt
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1147, 659)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblCashierLogin)
        Me.Controls.Add(Me.lblReceiptToPrintID)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmInpatientReceipt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "In-Patient Receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPatient As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountWord As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureR As System.Windows.Forms.TextBox
    Friend WithEvents txtOperationFee As System.Windows.Forms.TextBox
    Friend WithEvents txtAritificialEyeFee As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherFee As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAmountFigureD As System.Windows.Forms.TextBox
    Friend WithEvents chkRiel As System.Windows.Forms.CheckBox
    Friend WithEvents chkDollar As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDateIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtHN As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtReturnD As System.Windows.Forms.TextBox
    Friend WithEvents txtReturnR As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents rdOperationR As System.Windows.Forms.RadioButton
    Friend WithEvents rdOperationD As System.Windows.Forms.RadioButton
    Friend WithEvents rdArtificialEyeR As System.Windows.Forms.RadioButton
    Friend WithEvents rdArtificialEyeD As System.Windows.Forms.RadioButton
    Friend WithEvents rdOtherR As System.Windows.Forms.RadioButton
    Friend WithEvents rdOtherD As System.Windows.Forms.RadioButton
    Friend WithEvents lblRielDolar As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddRate As System.Windows.Forms.Button
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents lblFees As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblCashier As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSocialFee As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblReceiptToPrintID As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblCashierLogin As System.Windows.Forms.Label
    Friend WithEvents txtOperation As System.Windows.Forms.ComboBox
    Friend WithEvents ChPrintPreveiw As System.Windows.Forms.CheckBox
    Friend WithEvents cmdFinHN As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents CashierSave1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateReceipt1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintReceiptAgain As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TxtDonationPay As System.Windows.Forms.TextBox
    Friend WithEvents BtnDonation As System.Windows.Forms.Button
    Friend WithEvents CboDonation As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ChDonation As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtDonateNote As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TxtHospitalFee As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtExchangeRiel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtExchangeDolar As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
