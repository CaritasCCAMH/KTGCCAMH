Public Class FormClientRegistration
    Dim ccamh_client As New DSCClientRegistrationTableAdapters.CCAMH_CLIENTSTableAdapter
    Dim province As New DSCClientRegistrationTableAdapters.tblProvincesTableAdapter
    Dim district As New DSCClientRegistrationTableAdapters.tblDistrictsTableAdapter
    Dim communce As New DSCClientRegistrationTableAdapters.tblCommunesTableAdapter
    Dim occupation As New DSCClientRegistrationTableAdapters.TblOccupationTableAdapter
    Dim education As New DSCClientRegistrationTableAdapters.tblEducationTableAdapter
    Dim village As New DSCClientRegistrationTableAdapters.tblVillagesTableAdapter
    Dim sibling As Integer
    Dim maleSibling As Integer
    Dim femaleSibling As Integer
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub resetCCAMHClientReg()
        ResetFormClientRegistration()
        TxtPatientName.Focus()
        TxtPatientName.Select()
        TxtPatientName.SelectAll()
        TxtPatientName.Text = ""
        txtBroghtBy.Text = ""
        txtReferBy.Text = ""
        CboSex.SelectedIndex = -1
        txtAge.Text = ""
        rbtSchoolGoingYes.Checked = False
        rbtSchoolGoingNo.Checked = False
        rbtSchoolGoingYes.Checked = False
        cboLevelEducation.SelectedIndex = -1
        txtSibling.Text = ""
        txtMaleSibling.Text = ""
        txtFemaleSibling.Text = ""
        cboSiblingPosition.SelectedIndex = -1
        txtFatherName.Text = ""
        cboFatherEducation.SelectedIndex = -1
        cboFatherCoccupation.SelectedIndex = -1
        txtMotherName.Text = ""
        cboMotherEducation.SelectedIndex = -1
        cboMotherCoccupation.SelectedIndex = -1
        txtPhoneNo.Text = ""
        cboProvince.SelectedIndex = -1
        cboDistrict.SelectedIndex = -1
        cboCommune.SelectedIndex = -1
        cboVillage.SelectedIndex = -1
        txtStreet.Text = ""
        txtHouseNo.Text = ""
        txtAdvisedRegis.Text = ""
        txtReferredElswhere.Text = ""
        txtPurpose.Text = ""
        chxImpressNeuro.Checked = False
        chxImpressDev.Checked = False
        chxImpressPsycho.Checked = False
        txtSubtype.Text = ""


        'TxtPatientName.Focus()
        'TxtPatientName.Select()
        'TxtPatientName.SelectAll()
        'TxtPatientName.Text = ""
        'TxtPatientNameKh.Text = ""
        'CboSex.SelectedIndex = -1
        'txtAge.Text = ""
        'TxtTel.Text = ""
        ''TxtFullAddress.Text = ""
        'ChHearing.Checked = False
        'ChUnderstanding.Checked = False
        'ChPhysicalDisability.Checked = False
        'ChSeeing.Checked = False
        'ChIsOld.Checked = False
        'ChReferral.Checked = False
        'RadReferAndPickup.Checked = False
        'RadReferAndComeBySelf.Checked = False
        'ChRefraction.Checked = False
        'ChOpticalshop.Checked = False
        'TxtRegisterNote.Text = ""
        'TxtReferencePatientNote.Text = ""
        'LoadDefaultAddressSetting()
    End Sub

    Private Sub FormClientRegistration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        resetCCAMHClientReg()
        With cboProvince
            .DataSource = province.GetData
            .ValueMember = "IDProvCode"
            .DisplayMember = "Province"
        End With
        With cboSiblingPosition
            .DataSource = occupation.GetData
            .ValueMember = "OccNo"
            .DisplayMember = "Occupation"
        End With
        With cboFatherCoccupation
            .DataSource = occupation.GetData
            .ValueMember = "OccNo"
            .DisplayMember = "Occupation"
        End With
        With cboMotherCoccupation
            .DataSource = occupation.GetData
            .ValueMember = "OccNo"
            .DisplayMember = "Occupation"
        End With
        With cboLevelEducation
            .DataSource = education.GetData
            .ValueMember = "eduNo"
            .DisplayMember = "Education"
        End With
        With cboFatherEducation
            .DataSource = education.GetData
            .ValueMember = "eduNo"
            .DisplayMember = "Education"
        End With
        With cboMotherEducation
            .DataSource = education.GetData
            .ValueMember = "eduNo"
            .DisplayMember = "Education"
        End With
    End Sub

    Private Sub CboProNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvince.SelectedIndexChanged
        Try
            With cboDistrict
                .DataSource = district.getDistrict(cboProvince.SelectedValue)
                .ValueMember = "SrokCode"
                .DisplayMember = "DISTRICT"
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CboDisNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDistrict.SelectedIndexChanged
        Try
            With cboCommune
                .DataSource = communce.getCommunce(cboDistrict.SelectedValue)
                .ValueMember = "KhumCode"
                .DisplayMember = "Commune"
            End With
        Catch ex As Exception
            'Msg(ex.Message)
        End Try
    End Sub
    Private Sub CboCommNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCommune.SelectedIndexChanged
        Try
            With cboVillage
                .DataSource = village.getVillage(cboCommune.SelectedValue)
                .ValueMember = "PhumCode"
                .DisplayMember = "VILLAGE"
            End With
        Catch ex As Exception

        End Try
    End Sub
    'Private Sub cbxVillage_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxVillage.SelectedIndexChanged

    '    Try
    '        With cbxVillage
    '            .DataSource = village.getVillage(CboCommNo.SelectedValue)
    '            .ValueMember = "PhumCode"
    '            .DisplayMember = "VILLAGE"
    '        End With
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotherOccupation.Click
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmOccupation As New FrmNewOccupation
        frmOccupation.ShowDialog()
    End Sub
    Sub LoadNewClientNo()
        txtClientNo.Text = ModCommon.GeneratePatientNoForScreening("CLIENT_ID", "CCAMH_CLIENTS")
    End Sub
    Sub ResetFormClientRegistration()
        LoadNewClientNo()
    End Sub
    Private Sub btnEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEducation.Click
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnMotherEducaiton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMotherEducaiton.Click
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    Private Sub btnFatherEducation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFatherEducation.Click
        Dim frmEducation As New Education
        frmEducation.ShowDialog()
    End Sub

    
    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click

    End Sub

    Private Sub btnAddProvince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddProvince.Click
        Dim frmProvince As New FrmNewProvince
        frmProvince.ShowDialog()
    End Sub

    Private Sub btnAddDistrict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDistrict.Click
        Dim frmDistrict As New FrmNewDistrict
        frmDistrict.ShowDialog()
    End Sub

    Private Sub btnAddCommune_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCommune.Click
        Dim frmCommune As New FNewCommune
        frmCommune.ShowDialog()
    End Sub

    Private Sub btnAddVillage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddVillage.Click
        Dim frmVillage As New FrmNewProvince

    End Sub

    Private Sub txtReferredElswhere_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReferredElswhere.TextChanged

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If ValidateTextField(txtClientNo, "Client No", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(TxtPatientName, "Patient Name", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtBroghtBy, "Brought By", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtReferBy, "Referred By", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(CboSex, "Gender", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtAge, "Age", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboLevelEducation, "Level of Education", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtSibling, "Sibling No", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtMaleSibling, "Male Sibling", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtFemaleSibling, "Female Sibling", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboSiblingPosition, "Position", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtFatherName, "Client Father", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboFatherEducation, "Father Education", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboFatherCoccupation, "Father Occupation", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtMotherName, "Client Mother", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboMotherEducation, "Mother Education", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboMotherCoccupation, "Mother Occupation", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtPhoneNo, "Phone Number", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboProvince, "Province", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboDistrict, "District", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboCommune, "Commun", ErrClientRegis) = False Then Exit Sub
        If ValidateCombobox(cboVillage, "Village", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtStreet, "Street", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtHouseNo, "House No", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtAdvisedRegis, "Advised Registration", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtPurpose, "Purpose of Consultation", ErrClientRegis) = False Then Exit Sub
        If ValidateTextField(txtReferredElswhere, "Referred Elsewhere", ErrClientRegis) = False Then Exit Sub


        If MessageBox.Show("Do you really want to save the client information?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

            ' Function save new pateint register and screening book

            If saveCCAMHClientInfo() = True Then
                MessageBox.Show("Client successfully saved!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'If IS_ONSCRENNING = True Then
                '    Me.DashScreeningRegis.RefreshAfterScreenRegis(DateRegis.Value.Date, DateRegis.Value.Date, PatientNo.Text)
                'End If
                'If ChPrintRegistration.Checked = True Then
                '    UIMainScreening.StatusLoading(True, "Loading")
                '    BgLoadingform.RunWorkerAsync()
                'Else
                '    ResetFormRegister()
                'End If

            Else
                MessageBox.Show("Error Client Information. Please verify data and enter it again!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        resetCCAMHClientReg()

    End Sub

    Function saveCCAMHClientInfo() As Boolean
        'Dim schoolGoing As String
        'Dim clientSex As String
        'Dim imprNeuro As Char
        'Dim imprDevDisorder As Char
        'Dim imprPsycho As Char
        'Dim clientAge As Integer
        'Dim dob As Date
        'Dim curDate As Date
        'dob = dtpDOB.Text
        'curDate = Now
        'clientAge = DateDiff(DateInterval.Year, curDate, dob)

        'If rbtSchoolGoingYes.Checked = True Then
        '    schoolGoing = "Y"
        'ElseIf rbtSchoolGoingNo.Checked = True Then
        '    schoolGoing = "N"
        'Else
        '    schoolGoing = "NA"
        'End If

        'If CboSex.SelectedValue = "F" Then
        '    clientSex = "F"
        'Else
        '    clientSex = "M"

        'End If
        'txtAge.Text = clientAge
        Try
            If ModCommon.CheckDuplicateClientNo(txtClientNo.Text, "CCAMH_CLIENTS") = True Then
                LoadNewClientNo()
            End If
            Dim DateServer As Date = ModGlobleVariable.GeteDateServer
            Dim schoolgoing As Char = ""
            Dim imprNeuro As Boolean
            Dim imprDeve As Boolean
            Dim imprPsycho As Boolean
            Dim years As Integer = DateServer.Year
            Dim sibling As Integer
            Dim maleSibling As Integer
            Dim femaleSibling As Integer
            sibling = txtSibling.Text
            maleSibling = txtMaleSibling.Text
            If (IsNumeric(sibling) And sibling > 0) And (IsNumeric(maleSibling) And sibling > 0) Then
                femaleSibling = sibling - maleSibling
            End If

            If rbtSchoolGoingYes.Checked = True Then
                schoolgoing = "Y"
            ElseIf rbtSchoolGoingNo.Checked = True Then
                schoolgoing = "N"
            Else
                schoolgoing = "NA"
            End If
            If chxImpressDev.Checked Then
                imprDeve = 1
            Else
                imprDeve = 0
            End If
            If chxImpressNeuro.Checked = True Then
                imprNeuro = 1
            Else
                imprNeuro = 0
            End If
            If chxImpressPsycho.Checked Then
                imprPsycho = 1
            Else
                imprPsycho = 0
            End If
            ccamh_client.insertClient(txtClientNo.Text, TxtPatientName.Text, CboSex.Text, txtAge.Text, dtpDOB.Value, txtBroghtBy.Text, txtReferBy.Text, sibling, maleSibling, femaleSibling, dtpEstimate.Value, schoolgoing, cboLevelEducation.Text, txtFatherName.Text, cboFatherEducation.Text, cboFatherCoccupation.Text, txtMotherName.Text, cboMotherEducation.Text, cboMotherCoccupation.Text, txtHouseNo.Text, txtStreet.Text, cboVillage.Text, cboCommune.Text, cboDistrict.Text, cboProvince.Text, txtPhoneNo.Text, txtPurpose.Text, imprNeuro, imprDeve, imprPsycho, txtSubtype.Text, txtAdvisedRegis.Text, txtReferredElswhere.Text, years, DateRegis.Value)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
       




        'Dim Con As SqlClient.SqlConnection = ModGlobleVariable.GENERAL_DAO.getConnection
        'Dim sqlComm As SqlClient.SqlCommand = Con.CreateCommand
        'Dim Transaction As SqlClient.SqlTransaction = Nothing
        'Transaction = Con.BeginTransaction
        'sqlComm.Transaction = Transaction
        'Try
        '    sqlComm.CommandText = SqlPatientInformation()
        '    sqlComm.ExecuteNonQuery()
        '    Transaction.Commit()
        '    Transaction.Dispose()
        '    Return True
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '    Transaction.Rollback()
        '    'EnableFormControl()
        '    Return False
        'Finally
        '    Con.Close()
        '    Con.Dispose()
        'End Try
    End Function

    Private Sub txtMaleSibling_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMaleSibling.Leave
        sibling = txtSibling.Text
        maleSibling = txtMaleSibling.Text
        If (IsNumeric(sibling) And sibling > 0) And (IsNumeric(maleSibling) And sibling > 0) Then
            femaleSibling = sibling - maleSibling
        End If
        txtFemaleSibling.Text = femaleSibling
    End Sub

    'Function SqlPatientInformation() As String
    '    Return StringClientInformation(txtClientNo.Text, TxtPatientName.Text,CboSex.Text,


    '    'DateRegis.Value.Date, CboProNo.Text, _
    '    'CboDisNo.Text, CboCommNo.Text, TxtPatientName.Text, _
    '    'TxtPatientNameKh.Text, txtAge.Text, CboSex.Text, _
    '    'TxtFullAddress.Text, "", TxtTel.Text, "", _
    '    'GetDateServer.Date.Year, ModGlobleVariable.ACHIEVE, False, GetTextReferralV1, Format(GetDateServer, "hh:mm:ss tt"
    '    ).ToString)
    'End Function

    'Function StringClientInformation( _
    ' ByVal PatientNo As String, _
    ' ByVal CreateDate As String, _
    ' ByVal province As String, _
    ' ByVal District As String, _
    ' ByVal Commune As String, _
    ' ByVal NameEng As String, _
    ' ByVal NameKh As String, _
    ' ByVal Age As String, _
    ' ByVal Sex As String, _
    ' ByVal address As String, _
    ' ByVal Occupation As String, _
    ' ByVal Tel As String, _
    ' ByVal neighbor As String, _
    ' ByVal Years As Integer, _
    ' ByVal Achieve As Boolean, _
    ' ByVal Is_MoPoTsyo As Boolean, ByVal ComBindRefferal As String, ByVal TIME_CREATE As String) As String
    '    Dim Field As String = ""
    '    If Sex = "M" Then
    '        Field = "Male"
    '    Else
    '        Field = "Female"
    '    End If
    '    Dim sql As String = "INSERT INTO TblPatients (" & _
    '    "PatientNo," & _
    '    "CreateDate," & _
    '    "Province," & _
    '    "District," & _
    '    "Commune," & _
    '    "NameEng," & _
    '    "NameKhmer," & _
    '    "Age," & Field & " ," & _
    '    "Sex," & _
    '    "Address," & _
    '    "Occupation," & _
    '    "Telephone," & _
    '    "Neighborly," & _
    '    "Years,Achieve,Is_MoPoTsyo,ComBindRefferal,TIME_CREATE) " & _
    '    " VALUES(" & PatientNo & " ,'" & _
    '    CreateDate & "','" & _
    '    province.Replace("'", "''") & "','" & _
    '    District.Replace("'", "''") & "','" & _
    '    Commune.Replace("'", "''") & "',N'" & _
    '    NameEng.Replace("'", "''") & "',N'" & _
    '    NameKh.Replace("'", "''") & "'," & _
    '    Age & ",'" & _
    '    Sex & "','" & _
    '    Sex & "','" & _
    '    address.Replace("'", "''") & "','" & _
    '    Occupation.Replace("'", "''") & "','" & _
    '    Tel.Replace("'", "''") & "','" & _
    '    neighbor.Replace("'", "''") & "'," & Years & ",'" & Achieve & "','" & Is_MoPoTsyo & "','" & ComBindRefferal & "','" & TIME_CREATE & "')"
    '    Return sql
    'End Function

    'Private Sub dtpDOB_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.TextChanged
    '    Dim dob As Date
    '    Dim curDate As Date
    '    dob = CDate(dtpDOB.Value)
    '    curDate = CDate(Now)
    '    Try
    '        clientAge = Math.Round(DateDiff(DateInterval.Day, dob, curDate)) / 365
    '        If clientAge < 1 Then
    '            clientAge = (clientAge * 365) / 30
    '        Else
    '            clientAge = clientAge
    '        End If
    '        txtAge.Text = clientAge
    '    Catch ex As Exception
    '        MsgBox(ex)
    '    End Try

    'End Sub

    Private Sub txtMaleSibling_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMaleSibling.TextChanged
        
        
    End Sub
End Class