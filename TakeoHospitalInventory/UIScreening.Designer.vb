<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIScreening
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIScreening))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Group_1 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Group_2 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Group_3 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Me.ButtonBarContainerControl1 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnClientsConference = New System.Windows.Forms.Button
        Me.BtnDashboardRegistration = New System.Windows.Forms.Button
        Me.BtnClientReports = New System.Windows.Forms.Button
        Me.ButtonBarContainerControl4 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.ButtonBarContainerControl2 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnPaymentSetting = New System.Windows.Forms.Button
        Me.BtnCashReceive = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ButtonBarContainerControl3 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.PanelMainDetail = New System.Windows.Forms.Panel
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.MainPanelNavegation = New Janus.Windows.UI.Dock.UIPanel
        Me.MainPanelNavegationContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.UiPanelCaptionContainer1 = New Janus.Windows.UI.Dock.UIPanelCaptionContainer
        Me.UiPanelCaptionContainer2 = New Janus.Windows.UI.Dock.UIPanelCaptionContainer
        Me.ButtonBarContainerControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ButtonBarContainerControl4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ButtonBarContainerControl2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ButtonBarContainerControl3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBar1.SuspendLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainPanelNavegation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanelNavegation.SuspendLayout()
        Me.MainPanelNavegationContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBarContainerControl1
        '
        Me.ButtonBarContainerControl1.Controls.Add(Me.Panel1)
        Me.ButtonBarContainerControl1.Location = New System.Drawing.Point(0, 36)
        Me.ButtonBarContainerControl1.Name = "ButtonBarContainerControl1"
        Me.ButtonBarContainerControl1.Size = New System.Drawing.Size(223, 728)
        Me.ButtonBarContainerControl1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnClientsConference)
        Me.Panel1.Controls.Add(Me.BtnDashboardRegistration)
        Me.Panel1.Controls.Add(Me.BtnClientReports)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 728)
        Me.Panel1.TabIndex = 0
        '
        'BtnClientsConference
        '
        Me.BtnClientsConference.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClientsConference.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientsConference.FlatAppearance.BorderSize = 0
        Me.BtnClientsConference.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientsConference.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientsConference.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClientsConference.Image = CType(resources.GetObject("BtnClientsConference.Image"), System.Drawing.Image)
        Me.BtnClientsConference.Location = New System.Drawing.Point(19, 269)
        Me.BtnClientsConference.Name = "BtnClientsConference"
        Me.BtnClientsConference.Size = New System.Drawing.Size(172, 114)
        Me.BtnClientsConference.TabIndex = 9
        Me.BtnClientsConference.Text = "Client Conferent"
        Me.BtnClientsConference.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnClientsConference.UseVisualStyleBackColor = True
        '
        'BtnDashboardRegistration
        '
        Me.BtnDashboardRegistration.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDashboardRegistration.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboardRegistration.FlatAppearance.BorderSize = 0
        Me.BtnDashboardRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboardRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboardRegistration.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDashboardRegistration.Image = CType(resources.GetObject("BtnDashboardRegistration.Image"), System.Drawing.Image)
        Me.BtnDashboardRegistration.Location = New System.Drawing.Point(19, 13)
        Me.BtnDashboardRegistration.Name = "BtnDashboardRegistration"
        Me.BtnDashboardRegistration.Size = New System.Drawing.Size(172, 114)
        Me.BtnDashboardRegistration.TabIndex = 7
        Me.BtnDashboardRegistration.Text = "Dashboard Register Client"
        Me.BtnDashboardRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnDashboardRegistration.UseVisualStyleBackColor = True
        '
        'BtnClientReports
        '
        Me.BtnClientReports.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClientReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientReports.FlatAppearance.BorderSize = 0
        Me.BtnClientReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnClientReports.Image = CType(resources.GetObject("BtnClientReports.Image"), System.Drawing.Image)
        Me.BtnClientReports.Location = New System.Drawing.Point(19, 141)
        Me.BtnClientReports.Name = "BtnClientReports"
        Me.BtnClientReports.Size = New System.Drawing.Size(172, 114)
        Me.BtnClientReports.TabIndex = 8
        Me.BtnClientReports.Text = "Client Report"
        Me.BtnClientReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnClientReports.UseVisualStyleBackColor = True
        '
        'ButtonBarContainerControl4
        '
        Me.ButtonBarContainerControl4.BackColor = System.Drawing.Color.LightGray
        Me.ButtonBarContainerControl4.Controls.Add(Me.Panel4)
        Me.ButtonBarContainerControl4.Location = New System.Drawing.Point(0, 72)
        Me.ButtonBarContainerControl4.Name = "ButtonBarContainerControl4"
        Me.ButtonBarContainerControl4.Size = New System.Drawing.Size(223, 728)
        Me.ButtonBarContainerControl4.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Button8)
        Me.Panel4.Controls.Add(Me.Button9)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(223, 728)
        Me.Panel4.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.Location = New System.Drawing.Point(19, 269)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(172, 114)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "Client Conferent"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(19, 13)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(172, 114)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "List of Client Waiting"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(19, 141)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(172, 114)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Client Report"
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ButtonBarContainerControl2
        '
        Me.ButtonBarContainerControl2.Controls.Add(Me.Panel2)
        Me.ButtonBarContainerControl2.Location = New System.Drawing.Point(0, 108)
        Me.ButtonBarContainerControl2.Name = "ButtonBarContainerControl2"
        Me.ButtonBarContainerControl2.Size = New System.Drawing.Size(223, 728)
        Me.ButtonBarContainerControl2.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BtnPaymentSetting)
        Me.Panel2.Controls.Add(Me.BtnCashReceive)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 728)
        Me.Panel2.TabIndex = 1
        '
        'BtnPaymentSetting
        '
        Me.BtnPaymentSetting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPaymentSetting.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPaymentSetting.FlatAppearance.BorderSize = 0
        Me.BtnPaymentSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaymentSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPaymentSetting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPaymentSetting.Image = CType(resources.GetObject("BtnPaymentSetting.Image"), System.Drawing.Image)
        Me.BtnPaymentSetting.Location = New System.Drawing.Point(19, 269)
        Me.BtnPaymentSetting.Name = "BtnPaymentSetting"
        Me.BtnPaymentSetting.Size = New System.Drawing.Size(172, 114)
        Me.BtnPaymentSetting.TabIndex = 9
        Me.BtnPaymentSetting.Text = "Payment Setting"
        Me.BtnPaymentSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnPaymentSetting.UseVisualStyleBackColor = True
        '
        'BtnCashReceive
        '
        Me.BtnCashReceive.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCashReceive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCashReceive.FlatAppearance.BorderSize = 0
        Me.BtnCashReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCashReceive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCashReceive.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCashReceive.Image = CType(resources.GetObject("BtnCashReceive.Image"), System.Drawing.Image)
        Me.BtnCashReceive.Location = New System.Drawing.Point(19, 13)
        Me.BtnCashReceive.Name = "BtnCashReceive"
        Me.BtnCashReceive.Size = New System.Drawing.Size(172, 114)
        Me.BtnCashReceive.TabIndex = 7
        Me.BtnCashReceive.Text = "Dashboard Register Client"
        Me.BtnCashReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnCashReceive.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(19, 141)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 114)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Client Report"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ButtonBarContainerControl3
        '
        Me.ButtonBarContainerControl3.Controls.Add(Me.Panel3)
        Me.ButtonBarContainerControl3.Location = New System.Drawing.Point(0, 144)
        Me.ButtonBarContainerControl3.Name = "ButtonBarContainerControl3"
        Me.ButtonBarContainerControl3.Size = New System.Drawing.Size(223, 728)
        Me.ButtonBarContainerControl3.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(223, 728)
        Me.Panel3.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(19, 269)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(172, 114)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Client Conferent"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(19, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(172, 114)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Dashboard Register Client"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(19, 141)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(172, 114)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Client Report"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'VSMInterface
        '
        JanusColorScheme1.ActiveCaptionColor = System.Drawing.Color.White
        JanusColorScheme1.ActiveCaptionTextColor = System.Drawing.SystemColors.ActiveCaption
        JanusColorScheme1.ControlColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.ControlDarkColor = System.Drawing.SystemColors.WindowText
        JanusColorScheme1.ControlTextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        JanusColorScheme1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        JanusColorScheme1.GrayTextColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightColor = System.Drawing.Color.FromArgb(CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(126, Byte), Integer))
        JanusColorScheme1.HighlightTextColor = System.Drawing.Color.White
        JanusColorScheme1.InfoColor = System.Drawing.Color.White
        JanusColorScheme1.InfoTextColor = System.Drawing.Color.Black
        JanusColorScheme1.MenuColor = System.Drawing.Color.White
        JanusColorScheme1.MenuTextColor = System.Drawing.Color.Black
        JanusColorScheme1.Name = "DefaultInterface"
        JanusColorScheme1.Office2007CustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.UseThemes = False
        JanusColorScheme1.WindowColor = System.Drawing.Color.FloralWhite
        JanusColorScheme1.WindowTextColor = System.Drawing.Color.Black
        Me.VSMInterface.ColorSchemes.Add(JanusColorScheme1)
        '
        'PanelMainDetail
        '
        Me.PanelMainDetail.AutoScroll = True
        Me.PanelMainDetail.AutoSize = True
        Me.PanelMainDetail.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.PanelMainDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMainDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMainDetail.Location = New System.Drawing.Point(228, 1)
        Me.PanelMainDetail.Name = "PanelMainDetail"
        Me.PanelMainDetail.Size = New System.Drawing.Size(1296, 920)
        Me.PanelMainDetail.TabIndex = 18
        '
        'ButtonBar1
        '
        Me.ButtonBar1.BackColor = System.Drawing.SystemColors.Menu
        Me.ButtonBar1.BlendColor = System.Drawing.SystemColors.WindowFrame
        Me.ButtonBar1.BorderStyle = Janus.Windows.ButtonBar.BorderStyle.None
        Me.ButtonBar1.Controls.Add(Me.ButtonBarContainerControl1)
        Me.ButtonBar1.Controls.Add(Me.ButtonBarContainerControl2)
        Me.ButtonBar1.Controls.Add(Me.ButtonBarContainerControl3)
        Me.ButtonBar1.Controls.Add(Me.ButtonBarContainerControl4)
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBar1.FlatBorderColor = System.Drawing.Color.FloralWhite
        ButtonBar1_Group_0.Container = True
        ButtonBar1_Group_0.ContainerControl = Me.ButtonBarContainerControl1
        ButtonBar1_Group_0.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_0.Image = CType(resources.GetObject("ButtonBar1_Group_0.Image"), System.Drawing.Image)
        ButtonBar1_Group_0.Key = "Registration"
        ButtonBar1_Group_0.Text = "Registration"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_1.Container = True
        ButtonBar1_Group_1.ContainerControl = Me.ButtonBarContainerControl4
        ButtonBar1_Group_1.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_1.Image = CType(resources.GetObject("ButtonBar1_Group_1.Image"), System.Drawing.Image)
        ButtonBar1_Group_1.Key = "Imprestion"
        ButtonBar1_Group_1.Text = "Imprestion Consultation"
        ButtonBar1_Group_1.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_2.Container = True
        ButtonBar1_Group_2.ContainerControl = Me.ButtonBarContainerControl2
        ButtonBar1_Group_2.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_2.Image = CType(resources.GetObject("ButtonBar1_Group_2.Image"), System.Drawing.Image)
        ButtonBar1_Group_2.Key = "Cash-Flow"
        ButtonBar1_Group_2.Text = "Cash-Flow"
        ButtonBar1_Group_2.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_3.Container = True
        ButtonBar1_Group_3.ContainerControl = Me.ButtonBarContainerControl3
        ButtonBar1_Group_3.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_3.Image = CType(resources.GetObject("ButtonBar1_Group_3.Image"), System.Drawing.Image)
        ButtonBar1_Group_3.Key = "Thearapy"
        ButtonBar1_Group_3.Text = "Thearapy"
        ButtonBar1_Group_3.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0, ButtonBar1_Group_1, ButtonBar1_Group_2, ButtonBar1_Group_3})
        Me.ButtonBar1.GroupsStateStyles.FormatStyle.FontSize = 11.0!
        Me.ButtonBar1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(223, 872)
        Me.ButtonBar1.TabIndex = 0
        Me.ButtonBar1.Text = "TabButtonBar"
        Me.ButtonBar1.VisualStyleManager = Me.VSMInterface
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.AllowPanelDrag = False
        Me.UiPanelManager1.AllowPanelDrop = False
        Me.UiPanelManager1.ContainerControl = Me
        Me.UiPanelManager1.PanelPadding.Bottom = 1
        Me.UiPanelManager1.PanelPadding.Left = 1
        Me.UiPanelManager1.PanelPadding.Right = 1
        Me.UiPanelManager1.PanelPadding.Top = 1
        Me.UiPanelManager1.SplitterSize = 2
        Me.UiPanelManager1.TabStripFormatStyle.FontSize = 13.0!
        Me.UiPanelManager1.VisualStyleManager = Me.VSMInterface
        Me.MainPanelNavegation.Id = New System.Guid("abd68bcf-9e79-4348-90a5-509483019e13")
        Me.UiPanelManager1.Panels.Add(Me.MainPanelNavegation)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("abd68bcf-9e79-4348-90a5-509483019e13"), Janus.Windows.UI.Dock.PanelDockStyle.Left, New System.Drawing.Size(227, 920), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("16e47402-a74c-4fd4-b9b6-2016ed36872e"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, New System.Drawing.Point(104, 104), New System.Drawing.Size(200, 200), False)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("cecd169a-8949-4fa6-9d63-20f8ba54e208"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("abd68bcf-9e79-4348-90a5-509483019e13"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'MainPanelNavegation
        '
        Me.MainPanelNavegation.CaptionFormatStyle.FontSize = 13.0!
        Me.MainPanelNavegation.CaptionFormatStyle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MainPanelNavegation.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.MainPanelNavegation.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainPanelNavegation.Image = CType(resources.GetObject("MainPanelNavegation.Image"), System.Drawing.Image)
        Me.MainPanelNavegation.InfoTextFormatStyle.FontSize = 12.0!
        Me.MainPanelNavegation.InnerContainer = Me.MainPanelNavegationContainer
        Me.MainPanelNavegation.Location = New System.Drawing.Point(1, 1)
        Me.MainPanelNavegation.Name = "MainPanelNavegation"
        Me.MainPanelNavegation.Size = New System.Drawing.Size(227, 920)
        Me.MainPanelNavegation.TabIndex = 4
        Me.MainPanelNavegation.TabStateStyles.FormatStyle.FontSize = 11.0!
        Me.MainPanelNavegation.Text = "CCAMH SYSTEM"
        Me.MainPanelNavegation.TextAlignment = Janus.Windows.UI.Dock.PanelTextAlignment.Near
        '
        'MainPanelNavegationContainer
        '
        Me.MainPanelNavegationContainer.Controls.Add(Me.ButtonBar1)
        Me.MainPanelNavegationContainer.Location = New System.Drawing.Point(1, 47)
        Me.MainPanelNavegationContainer.Name = "MainPanelNavegationContainer"
        Me.MainPanelNavegationContainer.Size = New System.Drawing.Size(223, 872)
        Me.MainPanelNavegationContainer.TabIndex = 0
        '
        'UiPanelCaptionContainer1
        '
        Me.UiPanelCaptionContainer1.Location = New System.Drawing.Point(0, 0)
        Me.UiPanelCaptionContainer1.Name = "UiPanelCaptionContainer1"
        Me.UiPanelCaptionContainer1.Panel = Nothing
        Me.UiPanelCaptionContainer1.Size = New System.Drawing.Size(196, 23)
        Me.UiPanelCaptionContainer1.TabIndex = 0
        Me.UiPanelCaptionContainer1.Visible = False
        '
        'UiPanelCaptionContainer2
        '
        Me.UiPanelCaptionContainer2.Location = New System.Drawing.Point(0, 0)
        Me.UiPanelCaptionContainer2.Name = "UiPanelCaptionContainer2"
        Me.UiPanelCaptionContainer2.Panel = Nothing
        Me.UiPanelCaptionContainer2.Size = New System.Drawing.Size(196, 23)
        Me.UiPanelCaptionContainer2.TabIndex = 0
        Me.UiPanelCaptionContainer2.Visible = False
        '
        'UIScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PanelMainDetail)
        Me.Controls.Add(Me.MainPanelNavegation)
        Me.Name = "UIScreening"
        Me.Size = New System.Drawing.Size(1525, 922)
        Me.ButtonBarContainerControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ButtonBarContainerControl4.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ButtonBarContainerControl2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ButtonBarContainerControl3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBar1.ResumeLayout(False)
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainPanelNavegation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanelNavegation.ResumeLayout(False)
        Me.MainPanelNavegationContainer.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelMainDetail As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents ButtonBarContainerControl1 As Janus.Windows.ButtonBar.ButtonBarContainerControl
    Friend WithEvents UiPanelCaptionContainer1 As Janus.Windows.UI.Dock.UIPanelCaptionContainer
    Friend WithEvents UiPanelCaptionContainer2 As Janus.Windows.UI.Dock.UIPanelCaptionContainer
    Friend WithEvents MainPanelNavegation As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents MainPanelNavegationContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents VSMInterface As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents BtnDashboardRegistration As System.Windows.Forms.Button
    Friend WithEvents BtnClientsConference As System.Windows.Forms.Button
    Friend WithEvents BtnClientReports As System.Windows.Forms.Button
    Friend WithEvents ButtonBarContainerControl2 As Janus.Windows.ButtonBar.ButtonBarContainerControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnPaymentSetting As System.Windows.Forms.Button
    Friend WithEvents BtnCashReceive As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ButtonBarContainerControl3 As Janus.Windows.ButtonBar.ButtonBarContainerControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ButtonBarContainerControl4 As Janus.Windows.ButtonBar.ButtonBarContainerControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class
