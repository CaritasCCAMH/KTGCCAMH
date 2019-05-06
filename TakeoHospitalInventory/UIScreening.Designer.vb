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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Group_1 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Item_1_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim ButtonBar1_Item_1_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim ButtonBar1_Item_1_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem
        Dim ButtonBar1_Group_2 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UIScreening))
        Me.ButtonBarContainerControl1 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BtnDashboardRegistration = New System.Windows.Forms.Button
        Me.VSMInterface = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.PanelMainDetail = New System.Windows.Forms.Panel
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.MainPanelNavegation = New Janus.Windows.UI.Dock.UIPanel
        Me.MainPanelNavegationContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.UiPanelCaptionContainer1 = New Janus.Windows.UI.Dock.UIPanelCaptionContainer
        Me.UiPanelCaptionContainer2 = New Janus.Windows.UI.Dock.UIPanelCaptionContainer
        Me.BtnClientReports = New System.Windows.Forms.Button
        Me.BtnClientsConference = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.ButtonBarContainerControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.ButtonBarContainerControl1.Size = New System.Drawing.Size(223, 764)
        Me.ButtonBarContainerControl1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BtnClientsConference)
        Me.Panel1.Controls.Add(Me.BtnDashboardRegistration)
        Me.Panel1.Controls.Add(Me.BtnClientReports)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 764)
        Me.Panel1.TabIndex = 0
        '
        'BtnDashboardRegistration
        '
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
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBar1.FlatBorderColor = System.Drawing.Color.FloralWhite
        ButtonBar1_Group_0.Container = True
        ButtonBar1_Group_0.ContainerControl = Me.ButtonBarContainerControl1
        ButtonBar1_Group_0.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_0.Image = CType(resources.GetObject("ButtonBar1_Group_0.Image"), System.Drawing.Image)
        ButtonBar1_Group_0.Key = "Registration"
        ButtonBar1_Group_0.Text = "Registration"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_1.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_1.Image = CType(resources.GetObject("ButtonBar1_Group_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_1_0.Key = "Item1"
        ButtonBar1_Item_1_0.StateStyles.FormatStyle.FontSize = 10.0!
        ButtonBar1_Item_1_0.StateStyles.FormatStyle.ForeColorAlphaMode = Janus.Windows.ButtonBar.AlphaMode.Opaque
        ButtonBar1_Item_1_0.StateStyles.HotFormatStyle.ForeColor = System.Drawing.Color.Gray
        ButtonBar1_Item_1_0.Text = "New Item"
        ButtonBar1_Item_1_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Center
        ButtonBar1_Item_1_1.Key = "Item2"
        ButtonBar1_Item_1_1.Text = "New Item"
        ButtonBar1_Item_1_2.Key = "Item3"
        ButtonBar1_Item_1_2.Text = "New Item"
        ButtonBar1_Group_1.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_1_0, ButtonBar1_Item_1_1, ButtonBar1_Item_1_2})
        ButtonBar1_Group_1.Key = "Cash-Flow"
        ButtonBar1_Group_1.Text = "Cash-Flow"
        ButtonBar1_Group_1.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_2.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_2.Image = CType(resources.GetObject("ButtonBar1_Group_2.Image"), System.Drawing.Image)
        ButtonBar1_Group_2.Key = "Thearapy"
        ButtonBar1_Group_2.Text = "Thearapy"
        ButtonBar1_Group_2.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0, ButtonBar1_Group_1, ButtonBar1_Group_2})
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
        'BtnClientReports
        '
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
        'BtnClientsConference
        '
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
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(18, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 114)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Client Conferent"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(18, 532)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(172, 114)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Client Conferent"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(18, 652)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 114)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Client Conferent"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
