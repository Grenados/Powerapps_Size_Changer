<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MetroSet_UI.Forms.MetroSetForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_choose_File = New MetroSet_UI.Controls.MetroSetButton()
        Me.StyleManager1 = New MetroSet_UI.StyleManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cbx_Landscap = New MetroSet_UI.Controls.MetroSetRadioButton()
        Me.cbx_Portrait = New MetroSet_UI.Controls.MetroSetRadioButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txb_custom_width = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.txb_custom_height = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.pn_custom = New Guna.UI2.WinForms.Guna2Panel()
        Me.pn_size = New Guna.UI2.WinForms.Guna2Panel()
        Me.pn_orientation = New Guna.UI2.WinForms.Guna2Panel()
        Me.MetroSetLabel3 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.MetroSetLabel4 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.MetroSetPanel1 = New MetroSet_UI.Controls.MetroSetPanel()
        Me.MetroSetLabel1 = New MetroSet_UI.Controls.MetroSetLabel()
        Me.pn_apptype = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbx_desktop_tablet = New MetroSet_UI.Controls.MetroSetRadioButton()
        Me.cbx_phone = New MetroSet_UI.Controls.MetroSetRadioButton()
        Me.lbl_size = New MetroSet_UI.Controls.MetroSetLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer_abfrage = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgv_old_properties = New System.Windows.Forms.DataGridView()
        Me.col_old_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_old_Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_new_value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_change_file_properties = New MetroSet_UI.Controls.MetroSetButton()
        CType(Me.txb_custom_width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txb_custom_height, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pn_custom.SuspendLayout()
        Me.pn_orientation.SuspendLayout()
        Me.MetroSetPanel1.SuspendLayout()
        Me.pn_apptype.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.dgv_old_properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_choose_File
        '
        Me.btn_choose_File.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_choose_File.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_choose_File.DisabledForeColor = System.Drawing.Color.Gray
        Me.btn_choose_File.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_choose_File.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_choose_File.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_choose_File.HoverTextColor = System.Drawing.Color.White
        Me.btn_choose_File.Location = New System.Drawing.Point(410, 45)
        Me.btn_choose_File.Name = "btn_choose_File"
        Me.btn_choose_File.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_choose_File.NormalColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_choose_File.NormalTextColor = System.Drawing.Color.White
        Me.btn_choose_File.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_choose_File.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_choose_File.PressTextColor = System.Drawing.Color.White
        Me.btn_choose_File.Size = New System.Drawing.Size(367, 36)
        Me.btn_choose_File.Style = MetroSet_UI.Design.Style.Dark
        Me.btn_choose_File.StyleManager = Me.StyleManager1
        Me.btn_choose_File.TabIndex = 0
        Me.btn_choose_File.Text = "Choose File"
        Me.btn_choose_File.ThemeAuthor = "Narwin"
        Me.btn_choose_File.ThemeName = "MetroDark"
        '
        'StyleManager1
        '
        Me.StyleManager1.CustomTheme = "C:\Users\marti\AppData\Roaming\Microsoft\Windows\Templates\ThemeFile.xml"
        Me.StyleManager1.MetroForm = Me
        Me.StyleManager1.Style = MetroSet_UI.Design.Style.Dark
        Me.StyleManager1.ThemeAuthor = "Narwin"
        Me.StyleManager1.ThemeName = "MetroDark"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Microsoft App|*.msapp"
        '
        'cbx_Landscap
        '
        Me.cbx_Landscap.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbx_Landscap.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cbx_Landscap.Checked = False
        Me.cbx_Landscap.CheckSignColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbx_Landscap.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.cbx_Landscap.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cbx_Landscap.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_Landscap.Group = 1
        Me.cbx_Landscap.Location = New System.Drawing.Point(18, 16)
        Me.cbx_Landscap.Name = "cbx_Landscap"
        Me.cbx_Landscap.Size = New System.Drawing.Size(133, 17)
        Me.cbx_Landscap.Style = MetroSet_UI.Design.Style.Dark
        Me.cbx_Landscap.StyleManager = Me.StyleManager1
        Me.cbx_Landscap.TabIndex = 4
        Me.cbx_Landscap.Text = "landscape"
        Me.cbx_Landscap.ThemeAuthor = "Narwin"
        Me.cbx_Landscap.ThemeName = "MetroDark"
        '
        'cbx_Portrait
        '
        Me.cbx_Portrait.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbx_Portrait.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cbx_Portrait.Checked = False
        Me.cbx_Portrait.CheckSignColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbx_Portrait.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.cbx_Portrait.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cbx_Portrait.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_Portrait.Group = 1
        Me.cbx_Portrait.Location = New System.Drawing.Point(18, 39)
        Me.cbx_Portrait.Name = "cbx_Portrait"
        Me.cbx_Portrait.Size = New System.Drawing.Size(133, 17)
        Me.cbx_Portrait.Style = MetroSet_UI.Design.Style.Dark
        Me.cbx_Portrait.StyleManager = Me.StyleManager1
        Me.cbx_Portrait.TabIndex = 5
        Me.cbx_Portrait.Text = "portrait"
        Me.cbx_Portrait.ThemeAuthor = "Narwin"
        Me.cbx_Portrait.ThemeName = "MetroDark"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txb_custom_width
        '
        Me.txb_custom_width.BeforeTouchSize = New System.Drawing.Size(62, 22)
        Me.txb_custom_width.IntegerValue = CType(200, Long)
        Me.txb_custom_width.Location = New System.Drawing.Point(26, 40)
        Me.txb_custom_width.MaxValue = CType(9999, Long)
        Me.txb_custom_width.MinValue = CType(0, Long)
        Me.txb_custom_width.Name = "txb_custom_width"
        Me.txb_custom_width.NullString = "0"
        Me.txb_custom_width.NumberGroupSeparator = ""
        Me.txb_custom_width.Size = New System.Drawing.Size(55, 22)
        Me.txb_custom_width.SpecialCultureValue = Syncfusion.Windows.Forms.Tools.SpecialCultureValues.InstalledCulture
        Me.txb_custom_width.TabIndex = 14
        Me.txb_custom_width.Text = "200"
        '
        'txb_custom_height
        '
        Me.txb_custom_height.BeforeTouchSize = New System.Drawing.Size(62, 22)
        Me.txb_custom_height.IntegerValue = CType(768, Long)
        Me.txb_custom_height.Location = New System.Drawing.Point(87, 40)
        Me.txb_custom_height.MaxValue = CType(9999, Long)
        Me.txb_custom_height.MinValue = CType(0, Long)
        Me.txb_custom_height.Name = "txb_custom_height"
        Me.txb_custom_height.NullString = "0"
        Me.txb_custom_height.NumberGroupSeparator = ""
        Me.txb_custom_height.Size = New System.Drawing.Size(62, 22)
        Me.txb_custom_height.TabIndex = 15
        Me.txb_custom_height.Text = "768"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(26, 12)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(37, 18)
        Me.Guna2HtmlLabel3.TabIndex = 16
        Me.Guna2HtmlLabel3.Text = "Width"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(87, 12)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(42, 18)
        Me.Guna2HtmlLabel4.TabIndex = 17
        Me.Guna2HtmlLabel4.Text = "Height"
        '
        'pn_custom
        '
        Me.pn_custom.BackColor = System.Drawing.Color.Transparent
        Me.pn_custom.Controls.Add(Me.Guna2HtmlLabel3)
        Me.pn_custom.Controls.Add(Me.Guna2HtmlLabel4)
        Me.pn_custom.Controls.Add(Me.txb_custom_width)
        Me.pn_custom.Controls.Add(Me.txb_custom_height)
        Me.pn_custom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pn_custom.Location = New System.Drawing.Point(169, 348)
        Me.pn_custom.Name = "pn_custom"
        Me.pn_custom.ShadowDecoration.Parent = Me.pn_custom
        Me.pn_custom.Size = New System.Drawing.Size(175, 75)
        Me.pn_custom.TabIndex = 18
        Me.pn_custom.Visible = False
        '
        'pn_size
        '
        Me.pn_size.BackColor = System.Drawing.Color.Transparent
        Me.pn_size.Location = New System.Drawing.Point(169, 188)
        Me.pn_size.Name = "pn_size"
        Me.pn_size.ShadowDecoration.Parent = Me.pn_size
        Me.pn_size.Size = New System.Drawing.Size(175, 154)
        Me.pn_size.TabIndex = 19
        '
        'pn_orientation
        '
        Me.pn_orientation.BackColor = System.Drawing.Color.Transparent
        Me.pn_orientation.Controls.Add(Me.cbx_Landscap)
        Me.pn_orientation.Controls.Add(Me.cbx_Portrait)
        Me.pn_orientation.Location = New System.Drawing.Point(9, 188)
        Me.pn_orientation.Name = "pn_orientation"
        Me.pn_orientation.ShadowDecoration.Parent = Me.pn_orientation
        Me.pn_orientation.Size = New System.Drawing.Size(154, 72)
        Me.pn_orientation.TabIndex = 20
        '
        'MetroSetLabel3
        '
        Me.MetroSetLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroSetLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroSetLabel3.Location = New System.Drawing.Point(9, 162)
        Me.MetroSetLabel3.Name = "MetroSetLabel3"
        Me.MetroSetLabel3.Size = New System.Drawing.Size(154, 23)
        Me.MetroSetLabel3.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetLabel3.StyleManager = Me.StyleManager1
        Me.MetroSetLabel3.TabIndex = 21
        Me.MetroSetLabel3.Text = "Orientation"
        Me.MetroSetLabel3.ThemeAuthor = "Narwin"
        Me.MetroSetLabel3.ThemeName = "MetroDark"
        '
        'MetroSetLabel4
        '
        Me.MetroSetLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroSetLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroSetLabel4.Location = New System.Drawing.Point(169, 162)
        Me.MetroSetLabel4.Name = "MetroSetLabel4"
        Me.MetroSetLabel4.Size = New System.Drawing.Size(53, 23)
        Me.MetroSetLabel4.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetLabel4.StyleManager = Me.StyleManager1
        Me.MetroSetLabel4.TabIndex = 22
        Me.MetroSetLabel4.Text = "Size"
        Me.MetroSetLabel4.ThemeAuthor = "Narwin"
        Me.MetroSetLabel4.ThemeName = "MetroDark"
        '
        'MetroSetPanel1
        '
        Me.MetroSetPanel1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MetroSetPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.MetroSetPanel1.BorderThickness = 1
        Me.MetroSetPanel1.Controls.Add(Me.MetroSetLabel1)
        Me.MetroSetPanel1.Controls.Add(Me.pn_apptype)
        Me.MetroSetPanel1.Controls.Add(Me.lbl_size)
        Me.MetroSetPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.MetroSetPanel1.Controls.Add(Me.MetroSetLabel4)
        Me.MetroSetPanel1.Controls.Add(Me.pn_size)
        Me.MetroSetPanel1.Controls.Add(Me.MetroSetLabel3)
        Me.MetroSetPanel1.Controls.Add(Me.pn_orientation)
        Me.MetroSetPanel1.Controls.Add(Me.pn_custom)
        Me.MetroSetPanel1.Location = New System.Drawing.Point(48, 45)
        Me.MetroSetPanel1.Name = "MetroSetPanel1"
        Me.MetroSetPanel1.Size = New System.Drawing.Size(353, 474)
        Me.MetroSetPanel1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetPanel1.StyleManager = Me.StyleManager1
        Me.MetroSetPanel1.TabIndex = 23
        Me.MetroSetPanel1.ThemeAuthor = "Narwin"
        Me.MetroSetPanel1.ThemeName = "MetroDark"
        '
        'MetroSetLabel1
        '
        Me.MetroSetLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MetroSetLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MetroSetLabel1.Location = New System.Drawing.Point(9, 263)
        Me.MetroSetLabel1.Name = "MetroSetLabel1"
        Me.MetroSetLabel1.Size = New System.Drawing.Size(154, 23)
        Me.MetroSetLabel1.Style = MetroSet_UI.Design.Style.Dark
        Me.MetroSetLabel1.StyleManager = Me.StyleManager1
        Me.MetroSetLabel1.TabIndex = 26
        Me.MetroSetLabel1.Text = "AppType"
        Me.MetroSetLabel1.ThemeAuthor = "Narwin"
        Me.MetroSetLabel1.ThemeName = "MetroDark"
        '
        'pn_apptype
        '
        Me.pn_apptype.BackColor = System.Drawing.Color.Transparent
        Me.pn_apptype.Controls.Add(Me.cbx_desktop_tablet)
        Me.pn_apptype.Controls.Add(Me.cbx_phone)
        Me.pn_apptype.Location = New System.Drawing.Point(9, 289)
        Me.pn_apptype.Name = "pn_apptype"
        Me.pn_apptype.ShadowDecoration.Parent = Me.pn_apptype
        Me.pn_apptype.Size = New System.Drawing.Size(154, 72)
        Me.pn_apptype.TabIndex = 25
        '
        'cbx_desktop_tablet
        '
        Me.cbx_desktop_tablet.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbx_desktop_tablet.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cbx_desktop_tablet.Checked = False
        Me.cbx_desktop_tablet.CheckSignColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbx_desktop_tablet.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.cbx_desktop_tablet.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cbx_desktop_tablet.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_desktop_tablet.Group = 3
        Me.cbx_desktop_tablet.Location = New System.Drawing.Point(18, 16)
        Me.cbx_desktop_tablet.Name = "cbx_desktop_tablet"
        Me.cbx_desktop_tablet.Size = New System.Drawing.Size(133, 17)
        Me.cbx_desktop_tablet.Style = MetroSet_UI.Design.Style.Dark
        Me.cbx_desktop_tablet.StyleManager = Me.StyleManager1
        Me.cbx_desktop_tablet.TabIndex = 4
        Me.cbx_desktop_tablet.Text = "DesktopOrTablet"
        Me.cbx_desktop_tablet.ThemeAuthor = "Narwin"
        Me.cbx_desktop_tablet.ThemeName = "MetroDark"
        '
        'cbx_phone
        '
        Me.cbx_phone.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.cbx_phone.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.cbx_phone.Checked = False
        Me.cbx_phone.CheckSignColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.cbx_phone.CheckState = MetroSet_UI.Enums.CheckState.Unchecked
        Me.cbx_phone.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.cbx_phone.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbx_phone.Group = 3
        Me.cbx_phone.Location = New System.Drawing.Point(18, 39)
        Me.cbx_phone.Name = "cbx_phone"
        Me.cbx_phone.Size = New System.Drawing.Size(75, 17)
        Me.cbx_phone.Style = MetroSet_UI.Design.Style.Dark
        Me.cbx_phone.StyleManager = Me.StyleManager1
        Me.cbx_phone.TabIndex = 5
        Me.cbx_phone.Text = "Phone"
        Me.cbx_phone.ThemeAuthor = "Narwin"
        Me.cbx_phone.ThemeName = "MetroDark"
        '
        'lbl_size
        '
        Me.lbl_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_size.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.Location = New System.Drawing.Point(228, 162)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(116, 23)
        Me.lbl_size.Style = MetroSet_UI.Design.Style.Dark
        Me.lbl_size.StyleManager = Me.StyleManager1
        Me.lbl_size.TabIndex = 23
        Me.lbl_size.Text = " width x height"
        Me.lbl_size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_size.ThemeAuthor = "Narwin"
        Me.lbl_size.ThemeName = "MetroDark"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.White
        Me.Guna2PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(335, 145)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 11
        Me.Guna2PictureBox1.TabStop = False
        '
        'Timer_abfrage
        '
        Me.Timer_abfrage.Enabled = True
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Controls.Add(Me.dgv_old_properties)
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(407, 87)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(367, 390)
        Me.Guna2GroupBox1.TabIndex = 25
        Me.Guna2GroupBox1.Text = "Propertieinfo"
        '
        'dgv_old_properties
        '
        Me.dgv_old_properties.AllowUserToAddRows = False
        Me.dgv_old_properties.AllowUserToDeleteRows = False
        Me.dgv_old_properties.AllowUserToResizeColumns = False
        Me.dgv_old_properties.AllowUserToResizeRows = False
        Me.dgv_old_properties.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_old_properties.BackgroundColor = System.Drawing.Color.White
        Me.dgv_old_properties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_old_properties.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_old_name, Me.col_old_Value, Me.col_new_value})
        Me.dgv_old_properties.Location = New System.Drawing.Point(3, 43)
        Me.dgv_old_properties.Name = "dgv_old_properties"
        Me.dgv_old_properties.ReadOnly = True
        Me.dgv_old_properties.RowHeadersVisible = False
        Me.dgv_old_properties.Size = New System.Drawing.Size(358, 344)
        Me.dgv_old_properties.TabIndex = 0
        '
        'col_old_name
        '
        Me.col_old_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.col_old_name.DefaultCellStyle = DataGridViewCellStyle1
        Me.col_old_name.HeaderText = "Name"
        Me.col_old_name.Name = "col_old_name"
        Me.col_old_name.ReadOnly = True
        '
        'col_old_Value
        '
        Me.col_old_Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.col_old_Value.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_old_Value.HeaderText = "Old Value"
        Me.col_old_Value.Name = "col_old_Value"
        Me.col_old_Value.ReadOnly = True
        '
        'col_new_value
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.col_new_value.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_new_value.HeaderText = "New Value"
        Me.col_new_value.Name = "col_new_value"
        Me.col_new_value.ReadOnly = True
        '
        'btn_change_file_properties
        '
        Me.btn_change_file_properties.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_change_file_properties.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_change_file_properties.DisabledForeColor = System.Drawing.Color.Gray
        Me.btn_change_file_properties.Enabled = False
        Me.btn_change_file_properties.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_change_file_properties.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_change_file_properties.HoverColor = System.Drawing.Color.FromArgb(CType(CType(95, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_change_file_properties.HoverTextColor = System.Drawing.Color.White
        Me.btn_change_file_properties.Location = New System.Drawing.Point(407, 483)
        Me.btn_change_file_properties.Name = "btn_change_file_properties"
        Me.btn_change_file_properties.NormalBorderColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_change_file_properties.NormalColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btn_change_file_properties.NormalTextColor = System.Drawing.Color.White
        Me.btn_change_file_properties.PressBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_change_file_properties.PressColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.btn_change_file_properties.PressTextColor = System.Drawing.Color.White
        Me.btn_change_file_properties.Size = New System.Drawing.Size(367, 36)
        Me.btn_change_file_properties.Style = MetroSet_UI.Design.Style.Dark
        Me.btn_change_file_properties.StyleManager = Me.StyleManager1
        Me.btn_change_file_properties.TabIndex = 0
        Me.btn_change_file_properties.Text = "Change File Properties"
        Me.btn_change_file_properties.ThemeAuthor = "Narwin"
        Me.btn_change_file_properties.ThemeName = "MetroDark"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 561)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Controls.Add(Me.MetroSetPanel1)
        Me.Controls.Add(Me.btn_change_file_properties)
        Me.Controls.Add(Me.btn_choose_File)
        Me.Name = "Form1"
        Me.ShowLeftRect = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Style = MetroSet_UI.Design.Style.Dark
        Me.StyleManager = Me.StyleManager1
        Me.Text = "Powerapps SizeChange"
        Me.TextColor = System.Drawing.Color.White
        Me.ThemeName = "MetroDark"
        CType(Me.txb_custom_width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txb_custom_height, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pn_custom.ResumeLayout(False)
        Me.pn_custom.PerformLayout()
        Me.pn_orientation.ResumeLayout(False)
        Me.MetroSetPanel1.ResumeLayout(False)
        Me.pn_apptype.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.dgv_old_properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_choose_File As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cbx_Landscap As MetroSet_UI.Controls.MetroSetRadioButton
    Friend WithEvents cbx_Portrait As MetroSet_UI.Controls.MetroSetRadioButton
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txb_custom_width As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents txb_custom_height As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents pn_custom As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pn_size As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pn_orientation As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents StyleManager1 As MetroSet_UI.StyleManager
    Friend WithEvents MetroSetPanel1 As MetroSet_UI.Controls.MetroSetPanel
    Friend WithEvents MetroSetLabel4 As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents MetroSetLabel3 As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents lbl_size As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents Timer_abfrage As Timer
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgv_old_properties As DataGridView
    Friend WithEvents btn_change_file_properties As MetroSet_UI.Controls.MetroSetButton
    Friend WithEvents col_old_name As DataGridViewTextBoxColumn
    Friend WithEvents col_old_Value As DataGridViewTextBoxColumn
    Friend WithEvents col_new_value As DataGridViewTextBoxColumn
    Friend WithEvents MetroSetLabel1 As MetroSet_UI.Controls.MetroSetLabel
    Friend WithEvents pn_apptype As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbx_desktop_tablet As MetroSet_UI.Controls.MetroSetRadioButton
    Friend WithEvents cbx_phone As MetroSet_UI.Controls.MetroSetRadioButton
End Class
