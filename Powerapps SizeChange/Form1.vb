Imports System.IO
Imports System.IO.Compression
Imports Guna.UI2.WinForms
Imports MetroSet_UI.Interfaces
Imports Newtonsoft.Json
Imports Svg
Imports Syncfusion.Windows.Forms.Tools

Public Class Form1

    Dim NewlistofScreen As New List(Of Screen) From {
        New Screen With {.Orientation = "landscape", .Size_Name = "16:9 (default)", .Size_Value = New Size(1366, 768), .Thumb = My.Resources.land_AspectRatio_16_9},
        New Screen With {.Orientation = "landscape", .Size_Name = "3:2 (Surface Pro 3)", .Size_Value = New Size(1152, 768), .Thumb = My.Resources.land_AspectRatio_3_2},
        New Screen With {.Orientation = "landscape", .Size_Name = "16:10 (widescreen)", .Size_Value = New Size(1229, 768), .Thumb = My.Resources.land_AspectRatio_16_10},
    New Screen With {.Orientation = "landscape", .Size_Name = "4:3 (iPad)", .Size_Value = New Size(1024, 768), .Thumb = My.Resources.land_AspectRatio_4_3},
    New Screen With {.Orientation = "portrait", .Size_Name = "9:16 (default)", .Size_Value = New Size(768, 1366), .Thumb = My.Resources.port_AspectRatio_9_16},
    New Screen With {.Orientation = "portrait", .Size_Name = "2:3 (Surface Pro 3)", .Size_Value = New Size(768, 1152), .Thumb = My.Resources.port_AspectRatio_2_3},
    New Screen With {.Orientation = "portrait", .Size_Name = "10:16 (widescreen)", .Size_Value = New Size(768, 1229), .Thumb = My.Resources.port_AspectRatio_10_16},
    New Screen With {.Orientation = "portrait", .Size_Name = "3:4 (iPad)", .Size_Value = New Size(768, 1024), .Thumb = My.Resources.port_AspectRatio_3_4},
     New Screen With {.Orientation = "Custom", .Size_Name = "Custom", .Size_Value = New Size(0, 0), .Thumb = My.Resources.port_AspectRatio_3_4}}


    Dim Msapp_File As String

    Private Sub btn_choose_File_Click(sender As Object, e As EventArgs) Handles btn_choose_File.Click

        ' Bereiche leeren
        dgv_old_properties.Rows.Clear()
        Guna2GroupBox1.Text = "Propertieinfo"


        Using _ofd = OpenFileDialog1

            If _ofd.ShowDialog() = DialogResult.OK Then

                Dim Zip_File = ZipFile.OpenRead(_ofd.FileName)

                Guna2GroupBox1.Text = $"Propertieinfo of { Path.GetFileName(_ofd.FileName)}"

                Msapp_File = _ofd.FileName

                Dim Msapp_Entry = From g In Zip_File.Entries Where g.Name = "Properties.json" Select g

                If Msapp_Entry.Count = 1 Then

                    Using sr As New StreamReader(Msapp_Entry.First.Open())

                        Dim Jsonfile = JsonConvert.DeserializeObject(sr.ReadLine)

                        For Each Entrie As Linq.JProperty In Jsonfile
                            dgv_old_properties.Rows.Add(Entrie.Name, Entrie.Value)
                        Next

                    End Using

                End If

                Zip_File.Dispose()

                btn_change_file_properties.Enabled = True

            Else

                MsgBox("Please choose a Zip File")

            End If

        End Using

    End Sub


    Public Class Screen
        Public Orientation As String
        Public Size_Name As String
        Public Size_Value As Size
        Public Thumb As Bitmap
    End Class


    Private Sub Timer_abfrage_Tick(sender As Object, e As EventArgs) Handles Timer_abfrage.Tick

        Dim check_orient = From g As MetroSet_UI.Controls.MetroSetRadioButton In pn_orientation.Controls Where g.Checked = True
        Dim check_size = From g As MetroSet_UI.Controls.MetroSetRadioButton In pn_size.Controls Where g.Checked = True
        Dim check_apptype = From g As MetroSet_UI.Controls.MetroSetRadioButton In pn_apptype.Controls Where g.Checked = True

        If check_orient.Count = 1 And check_size.Count = 1 And check_apptype.Count = 1 Then
            btn_choose_File.Enabled = True
        ElseIf check_apptype.Count = 1 AndAlso check_apptype.First.Text = "Phone" Then
            btn_choose_File.Enabled = True
        Else
            btn_choose_File.Enabled = False
        End If

        Application.DoEvents()
    End Sub

    Private Sub btn_change_file_properties_Click(sender As Object, e As EventArgs) Handles btn_change_file_properties.Click

        Dim ChangeSettingslist As New List(Of String) From {"DocumentLayoutWidth", "DocumentLayoutHeight", "DocumentLayoutOrientation", "DocumentAppType"}

        If MsgBox("Change File Properties?", vbOKCancel) = DialogResult.OK Then

            btn_change_file_properties.Enabled = False

            Dim Zip_File = ZipFile.Open(Msapp_File, ZipArchiveMode.Update)

            Dim Msapp_Entry = From g In Zip_File.Entries Where g.Name = "Properties.json" Select g

            If Msapp_Entry.Count = 1 Then

                Dim Jsonfile As New Object

                Using sr As New StreamReader(Msapp_Entry.First.Open())

                    Jsonfile = JsonConvert.DeserializeObject(sr.ReadToEnd)

                    Dim Document_Changevariables = From val As DataGridViewRow In dgv_old_properties.Rows Where ChangeSettingslist.Contains(val.Cells(0).Value) Select val

                    Document_Changevariables.ToLookup(Function(cur_row)
                                                          cur_row.DefaultCellStyle.BackColor = Color.LightYellow
                                                          Select Case cur_row.Cells(0).Value
                                                              Case ChangeSettingslist.Item(0)
                                                                  cur_row.Cells(2).Value = My.Settings.App_Size.Width
                                                              Case ChangeSettingslist.Item(1)
                                                                  cur_row.Cells(2).Value = My.Settings.App_Size.Height
                                                              Case ChangeSettingslist.Item(2)
                                                                  cur_row.Cells(2).Value = My.Settings.App_Orientation
                                                              Case ChangeSettingslist.Item(3)
                                                                  cur_row.Cells(2).Value = My.Settings.App_AppType
                                                          End Select
                                                      End Function)

                    For Each Json_Line As Linq.JProperty In Jsonfile
                        Select Case Json_Line.Name
                            Case ChangeSettingslist.Item(0)
                                Json_Line.Value = My.Settings.App_Size.Width
                            Case ChangeSettingslist.Item(1)
                                Json_Line.Value = My.Settings.App_Size.Height
                            Case ChangeSettingslist.Item(2)
                                Json_Line.Value = My.Settings.App_Orientation
                            Case ChangeSettingslist.Item(3)
                                Json_Line.Value = My.Settings.App_AppType
                        End Select

                    Next

                End Using

                Dim Jsonfile_SerializeObjec = JsonConvert.SerializeObject(Jsonfile) ' Konvertiert den String wieder in die json Schreibweise

                Using sw As New StreamWriter(Msapp_Entry.First.Open)
                    sw.WriteLine(Jsonfile_SerializeObjec)
                End Using

            End If

            Zip_File.Dispose()

            If MsgBox("Change Successful" + vbNewLine + " Browse to the Folder?", vbOKCancel) = MsgBoxResult.Ok Then
                Process.Start(Path.GetDirectoryName(Msapp_File))
            End If

        End If
    End Sub

    Private Sub cbx_Apptype_checkedchanged(sender As Object) Handles cbx_phone.CheckedChanged, cbx_desktop_tablet.CheckedChanged

        Dim cur_cbx = TryCast(sender, MetroSet_UI.Controls.MetroSetRadioButton)

        If cur_cbx.Checked = True Then

            If cur_cbx.Text = "Phone" Then
                cbx_Landscap.Enabled = False
                cbx_Portrait.Enabled = False
                cbx_Portrait.Checked = True

                pn_size.Visible = False
                pn_custom.Visible = False

                My.Settings.App_Size = New Size(640, 1136)
                lbl_size.Text = My.Settings.App_Size.Width & " x " & My.Settings.App_Size.Height
                My.Settings.App_Orientation = "portrait"
                My.Settings.App_AppType = cur_cbx.Text
                My.Settings.Save()

            Else
                cbx_Landscap.Enabled = True
                cbx_Portrait.Enabled = True
                cbx_Portrait.Checked = True

                pn_size.Visible = True

                Dim default_cbx = From cur As MetroSet_UI.Controls.MetroSetRadioButton In pn_size.Controls Where cur.Text = "9:16 (default)"
                If default_cbx.Count = 1 Then default_cbx.First.Checked = True

                My.Settings.App_AppType = cur_cbx.Text
                My.Settings.Save()
            End If

        End If

    End Sub

    Private Sub txb_custom_width_TextChanged(sender As Object, e As EventArgs) Handles txb_custom_width.TextChanged, txb_custom_height.TextChanged
        Dim cur_txb = TryCast(sender, IntegerTextBox)
        lbl_size.Text = txb_custom_width.Text & " x " & txb_custom_height.Text
        My.Settings.App_Size = New Size(txb_custom_width.Text, txb_custom_height.Text)
        My.Settings.Save()
    End Sub

    Private Sub cbx_Landscap_CheckedChanged(sender As Object) Handles cbx_Portrait.CheckedChanged, cbx_Landscap.CheckedChanged

        pn_custom.Visible = False

        Dim cur_cbx = TryCast(sender, MetroSet_UI.Controls.MetroSetRadioButton)

        If cur_cbx.Checked = True Then
            pn_size.Controls.Clear()

            Dim RdmNr As New Random
            Dim Loc_changer As New Integer

            Loc_changer = 10

            Dim Entrie = From En As Screen In NewlistofScreen Where En.Orientation = cur_cbx.Text Or En.Size_Name = "Custom"

            For Each Entries As Screen In Entrie

                Dim NewSizeradio = New MetroSet_UI.Controls.MetroSetRadioButton With {.Name = $"lbl_size_{RdmNr.Next}", .Text = Entries.Size_Name, .Group = 2, .Style = MetroSet_UI.Design.Style.Dark, .Size = New Point(138, 17), .Location = New Point(pn_size.Width / 2 - .Size.Width / 2, Loc_changer)}
                Loc_changer += NewSizeradio.Size.Height + 10

                RemoveHandler NewSizeradio.CheckedChanged, AddressOf cbx_size_checkedchanged
                AddHandler NewSizeradio.CheckedChanged, AddressOf cbx_size_checkedchanged

                pn_size.Controls.Add(NewSizeradio)

            Next

            My.Settings.App_Orientation = cur_cbx.Text
            My.Settings.Save()

        End If

    End Sub

    Private Sub cbx_size_checkedchanged(sender As Object)

        pn_custom.Visible = False

        Dim cur_cbx = TryCast(sender, MetroSet_UI.Controls.MetroSetRadioButton)

        If cur_cbx.Checked = True Then

            Dim Entrie = From En As Screen In NewlistofScreen Where En.Size_Name = cur_cbx.Text Select En


            Guna2PictureBox1.Image = Entrie.First.Thumb

            If cur_cbx.Text = "Custom" Then
                pn_custom.Visible = True
                lbl_size.Text = txb_custom_width.Text & " x " & txb_custom_height.Text
                My.Settings.App_Size = New Size(txb_custom_width.Text, txb_custom_height.Text)
            Else
                lbl_size.Text = Entrie.First.Size_Value.Width & " x " & Entrie.First.Size_Value.Height
                My.Settings.App_Size = Entrie.First.Size_Value
            End If

            My.Settings.Save()

        End If
    End Sub

End Class
