<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMitgliedAnzeigen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.calEintritt = New System.Windows.Forms.MonthCalendar()
        Me.dtpGebDat = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGebDat = New System.Windows.Forms.Label()
        Me.lblEintritt = New System.Windows.Forms.Label()
        Me.lblKlasse = New System.Windows.Forms.Label()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.dgvSparten = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSparten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calEintritt
        '
        Me.calEintritt.Location = New System.Drawing.Point(141, 113)
        Me.calEintritt.Name = "calEintritt"
        Me.calEintritt.TabIndex = 0
        '
        'dtpGebDat
        '
        Me.dtpGebDat.Location = New System.Drawing.Point(141, 74)
        Me.dtpGebDat.Name = "dtpGebDat"
        Me.dtpGebDat.Size = New System.Drawing.Size(313, 27)
        Me.dtpGebDat.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(141, 8)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(56, 27)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(141, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(178, 27)
        Me.txtName.TabIndex = 3
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(141, 287)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(178, 26)
        Me.cmbKlasse.TabIndex = 4
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(7, 11)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(49, 18)
        Me.lblID.TabIndex = 5
        Me.lblID.Text = "MgNr"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(7, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 18)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'lblGebDat
        '
        Me.lblGebDat.AutoSize = True
        Me.lblGebDat.Location = New System.Drawing.Point(7, 80)
        Me.lblGebDat.Name = "lblGebDat"
        Me.lblGebDat.Size = New System.Drawing.Size(76, 18)
        Me.lblGebDat.TabIndex = 7
        Me.lblGebDat.Text = "Geboren"
        '
        'lblEintritt
        '
        Me.lblEintritt.AutoSize = True
        Me.lblEintritt.Location = New System.Drawing.Point(7, 113)
        Me.lblEintritt.Name = "lblEintritt"
        Me.lblEintritt.Size = New System.Drawing.Size(65, 18)
        Me.lblEintritt.TabIndex = 8
        Me.lblEintritt.Text = "Eintritt"
        '
        'lblKlasse
        '
        Me.lblKlasse.AutoSize = True
        Me.lblKlasse.Location = New System.Drawing.Point(7, 290)
        Me.lblKlasse.Name = "lblKlasse"
        Me.lblKlasse.Size = New System.Drawing.Size(128, 18)
        Me.lblKlasse.TabIndex = 9
        Me.lblKlasse.Text = "Beitragsklasse"
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(303, 370)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(158, 47)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Schließen"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'dgvSparten
        '
        Me.dgvSparten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSparten.Location = New System.Drawing.Point(460, 8)
        Me.dgvSparten.Name = "dgvSparten"
        Me.dgvSparten.Size = New System.Drawing.Size(568, 305)
        Me.dgvSparten.TabIndex = 11
        '
        'frmMitgliedAnzeigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1040, 429)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvSparten)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblKlasse)
        Me.Controls.Add(Me.lblEintritt)
        Me.Controls.Add(Me.lblGebDat)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.dtpGebDat)
        Me.Controls.Add(Me.calEintritt)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMitgliedAnzeigen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mitglied anzeigen"
        CType(Me.dgvSparten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calEintritt As MonthCalendar
    Friend WithEvents dtpGebDat As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGebDat As Label
    Friend WithEvents lblEintritt As Label
    Friend WithEvents lblKlasse As Label
    Friend WithEvents btnQuit As Button
    Friend WithEvents dgvSparten As DataGridView
End Class
