Public Class frmSuche
    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Dispose()
    End Sub

    Private Sub FrmSuche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbsKlasse As New clsDatabase

        If Not dbsKlasse.readData("SELECT * FROM tblBeitragsklassen") Then
            Stop
        Else
            ' Angezeigter Wert
            cmbKlasse.DisplayMember = "txtBezeichnung"
            ' Zurückzugebende ID
            cmbKlasse.ValueMember = "pkyBeitragsklasse"
            ' Datenübergabe
            cmbKlasse.DataSource = dbsKlasse.getTable
            ' Nur gültige Werte, keien freie Eingabe zulassen
            cmbKlasse.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub CmbKlasse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbKlasse.SelectedIndexChanged

        Dim dbsMitglieder As New clsDatabase
        Dim strRichtung As String

        ' Festlegung der Soriterrichtung
        If radASC.Checked Then
            strRichtung = "ASC"
        Else
            strRichtung = "DESC"
        End If

        If Not dbsMitglieder.readData("SELECT * FROM qryMitglieder WHERE fkyBeitragsklasse=" & cmbKlasse.SelectedValue &
                                                                       " AND txtName LIKE '%" & txtName.Text & "%'" &
                                                                       " ORDER BY txtName " & strRichtung) Then
            Stop
        Else
            ' Datenübergabe
            dgvMitglieder.DataSource = dbsMitglieder.getTable

            ' DGV vor Änderungen und Mehrfachauswahl schützen
            ' sowie Eingabezeile ausblenden
            dgvMitglieder.ReadOnly = True
            dgvMitglieder.AllowUserToAddRows = False
            dgvMitglieder.MultiSelect = False
            ' Zeilenköpfe weg
            dgvMitglieder.RowHeadersVisible = False
            ' Spalten ausblenden
            dgvMitglieder.Columns("fkyBeitragsklasse").Visible = False
            dgvMitglieder.Columns("txtBezeichnung").Visible = False
            'Spaltentitel ändern
            dgvMitglieder.Columns("pkyMitglied").HeaderText = "MgNr"
            dgvMitglieder.Columns("txtName").HeaderText = "Name"
            dgvMitglieder.Columns("datGeburt").HeaderText = "Geburtsdatum"
            dgvMitglieder.Columns("datEintritt").HeaderText = "Eintrittsdatum"
            'Euro-Formatierung
            dgvMitglieder.Columns("dblBeitrag").HeaderText = "Beitrag"
            dgvMitglieder.Columns("dblBeitrag").DefaultCellStyle.Format = "c"
            dgvMitglieder.Columns("dblBeitrag").DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight
            'Spaltenbreite
            dgvMitglieder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            dgvMitglieder.AutoResizeColumns()
        End If
    End Sub

    Private Sub dgvMitglieder_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvMitglieder.CellDoubleClick

        ' Nicht reagieren, wenn die Titelzeile geklickt wurde
        If e.RowIndex > -1 Then
            ' Laden des Mitglieds ins Unterformular und öffnen
            frmMitgliedAnzeigen.txtID.Text = dgvMitglieder.Rows(e.RowIndex).Cells(0).Value
            frmMitgliedAnzeigen.ShowDialog()
        End If

    End Sub
End Class
