Public Class clsDatabase

    'Klassenweite Eigenschaften
    Private objConnection As New OleDb.OleDbConnection
    Private objCommand As New OleDb.OleDbCommand
    Private isOK As Boolean

    'Definition Dataset und DataAdapter
    Private objDataAdapter As New OleDb.OleDbDataAdapter
    Private objCmdBuilder As New OleDb.OleDbCommandBuilder(objDataAdapter)
    Private objDataset As New DataSet

    Public Sub New()

        isOK = False
        objConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Dir("*.accdb")
        'String für Excel als Datenbasis
        'objConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Vereinsverwaltung.xlsx;Extended Properties=""Excel 12.0 Xml;HDR=YES"""
        objCommand.Connection = objConnection

    End Sub

    Public Function readData(Optional selectString As String = "") As Boolean

        If selectString = "" Then
            'erneute Statusabfrage ohne SQL
            readData = isOK
        Else
            'Neues Lesen von Daten angefragt
            'Boolean-Wert meldet zurück, ob es Fehler gab.
            readData = True

            'SQL-Statement in die Übergabestruktur aufnehmen
            objCommand.CommandText = selectString
            objDataAdapter.SelectCommand = objCommand

            'Abfrage ausführen
            Try
                objDataset.Clear()
                objDataAdapter.Fill(objDataset)
            Catch ex As Exception
                readData = False
                MsgBox("Entwicklerhilfe: " & getHelp(ex.Message) & vbNewLine & vbNewLine & ex.Message & vbNewLine & vbNewLine & selectString, vbCritical + vbOKOnly, "Database Read Error")
            End Try
            isOK = readData
        End If

    End Function

    Public Function getTable() As DataTable

        'Rückgabe des Datasets an den Aufruf
        If isOK Then
            getTable = objDataset.Tables(0)
        Else
            getTable = Nothing
        End If

    End Function

    Public Function saveTable(tblNew As DataTable) As Boolean

        'Speichern des Datasets
        saveTable = True
        Try
            'Speichern der Daten
            objDataAdapter.Update(tblNew)
        Catch ex As Exception
            saveTable = False
            Try
                'objDataAdapter.SelectCommand.CommandText ist vorhanden
                MsgBox("Entwicklerhilfe: " & getHelp(ex.Message) & vbNewLine & vbNewLine & ex.Message & vbNewLine & vbNewLine & objDataAdapter.SelectCommand.CommandText, vbCritical + vbOKOnly, "Database Save Error")
            Catch e As Exception
                ' objDataAdapter.SelectCommand.CommandText fehlt/geht nicht
                MsgBox("Entwicklerhilfe: " & getHelp(ex.Message) & vbNewLine & vbNewLine & ex.Message, vbCritical + vbOKOnly, "Database Save Error")
            End Try
        End Try
    End Function

    Private Function getHelp(meldung As String) As String

        getHelp = "Keine Hilfe hinterlegt."
        If InStr(meldung, "Parameter") > 0 Then getHelp = "Sie haben einen Spaltennamen in Ihrem SQL-Statement falsch geschrieben. Das kann in jedem Teil des Statements sein."
        If InStr(meldung, "Eingabetabelle") > 0 Then getHelp = "Sie haben den Tabellennamen in Ihrem SQL-Statement falsch geschrieben."
        If InStr(meldung, "Syntaxfehler (fehlender Operator) in Abfrageausdruck") > 0 Then getHelp = "Option1: Sie haben das Wort FROM falsch geschrieben." & vbNewLine & "Option 2: Sie filtern auf eine Spalte, übergeben aber keinen Wert, nachdem gesucht werden soll. Hinter dem Vergleichsoperator muss was stehen."
        If InStr(meldung, "Datentypenkonflikt in Kriterienausdruck") > 0 Then getHelp = "Sie vergleichen eine Zahlvariable mit einem String oder eine Textvariable mit einer Zahl. Überprüfen Sie die gesetzten SQL-Anführungszeichen ' in Ihrem WHERE-Statement."
        If InStr(meldung, "Unzulässige SQL-Anweisung") > 0 Then getHelp = "Sie haben eines der Worte SELECT, WHERE, GROUP, ORDER falsch geschrieben."
        If InStr(meldung, "FROM-Klausel") > 0 Then getHelp = "Sie haben entweder wirklich eine Fehler bei Angabe der Tabellen oder das Wort WHERE falsch gechrieben."
        If InStr(meldung, "Primärschlüssel") > 0 Then getHelp = "Sie versuchen, einen neuen Datensatz zu speichern, dessen ID schon vergeben ist."
        If InStr(meldung, "Der Objektverweis wurde nicht auf eine Objektinstanz festgelegt.") > 0 Then getHelp = "Ihr Dataset ist nicht mehr mit Daten gefüllt."
        If InStr(meldung, "Tabelle 0") > 0 Then getHelp = "Es wurden aufgrund eines technischen Fehlers keine Daten geladen. An eine nicht vorhandene Tabelle können auch keine Daten angefügt werden. Beseitigen Sie den Fehler beim Laden der Daten, dann sollte dieser Folgefehler weg sein."
        If InStr(meldung, "Zeichenfolge in Abfrageausdruck") > 0 Then getHelp = "Sie haben einen Schreibfehler im WHERE-Statement. Dies kann ein fehlendes oder überschüssiges Anführungszeichen sein oder ein Vergleichs- oder Rechenoperator."
        If InStr(meldung, "Dynamische SQL-Generierung für den UpdateCommand") > 0 Then getHelp = "Ihre geladenen Daten müssen einen Primärschlüssel beinhalten, sonst kann nicht zurückgeschrieben werden. Der Fehler ist nicht hier beim Speichern, sondern schon vorher beim Laden gewesen."
        If InStr(meldung, "Datei") > 0 Then getHelp = "Sie haben Ihre Access-Datenbank noch nicht am angegebenen Ort hinterlegt oder falsch benannt."
        If InStr(meldung, "SEC_E_AUTH") > 0 Then getHelp = "Sie haben keine Access-Datenbank im Debug-Ordner hinterlegt."
        If InStr(meldung, "Provider ist nicht auf dem lokalen Computer registriert") > 0 Then getHelp = "Installieren Sie die ""2007 Office System Driver Data Connectivity Components"" von der Microsoft Homepage in der 32Bit-Version."
        If InStr(meldung, "INSERT INTO") > 0 Then getHelp = "Haben Sie Leerzeichen in Spaltennamen in Access benutzt? Das ist verboten!"
        If InStr(meldung, "= ?") > 0 Then getHelp = "Haben Sie Leerzeichen in Spaltennamen in Access benutzt? Das ist verboten!"
    End Function

End Class
