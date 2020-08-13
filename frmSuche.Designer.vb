<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuche
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
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.lblKlasse = New System.Windows.Forms.Label()
        Me.dgvMitglieder = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpSortierung = New System.Windows.Forms.GroupBox()
        Me.radDESC = New System.Windows.Forms.RadioButton()
        Me.radASC = New System.Windows.Forms.RadioButton()
        CType(Me.dgvMitglieder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSortierung.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(164, 8)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(247, 26)
        Me.cmbKlasse.TabIndex = 0
        '
        'lblKlasse
        '
        Me.lblKlasse.AutoSize = True
        Me.lblKlasse.Location = New System.Drawing.Point(9, 8)
        Me.lblKlasse.Name = "lblKlasse"
        Me.lblKlasse.Size = New System.Drawing.Size(128, 18)
        Me.lblKlasse.TabIndex = 1
        Me.lblKlasse.Text = "Beitragsklasse"
        '
        'dgvMitglieder
        '
        Me.dgvMitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMitglieder.Location = New System.Drawing.Point(13, 76)
        Me.dgvMitglieder.Name = "dgvMitglieder"
        Me.dgvMitglieder.Size = New System.Drawing.Size(604, 230)
        Me.dgvMitglieder.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(13, 311)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 47)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Neues Mitglied"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(450, 311)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(168, 47)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Beenden"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 27)
        Me.txtName.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 44)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 18)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name"
        '
        'grpSortierung
        '
        Me.grpSortierung.Controls.Add(Me.radDESC)
        Me.grpSortierung.Controls.Add(Me.radASC)
        Me.grpSortierung.Location = New System.Drawing.Point(417, -2)
        Me.grpSortierung.Name = "grpSortierung"
        Me.grpSortierung.Size = New System.Drawing.Size(201, 72)
        Me.grpSortierung.TabIndex = 7
        Me.grpSortierung.TabStop = False
        '
        'radDESC
        '
        Me.radDESC.AutoSize = True
        Me.radDESC.Location = New System.Drawing.Point(19, 42)
        Me.radDESC.Name = "radDESC"
        Me.radDESC.Size = New System.Drawing.Size(117, 22)
        Me.radDESC.TabIndex = 1
        Me.radDESC.Text = "absteigend"
        Me.radDESC.UseVisualStyleBackColor = True
        '
        'radASC
        '
        Me.radASC.AutoSize = True
        Me.radASC.Checked = True
        Me.radASC.Location = New System.Drawing.Point(19, 14)
        Me.radASC.Name = "radASC"
        Me.radASC.Size = New System.Drawing.Size(123, 22)
        Me.radASC.TabIndex = 0
        Me.radASC.TabStop = True
        Me.radASC.Text = "aufsteigend"
        Me.radASC.UseVisualStyleBackColor = True
        '
        'frmSuche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(632, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.grpSortierung)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvMitglieder)
        Me.Controls.Add(Me.lblKlasse)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSuche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mitgliedssuche"
        CType(Me.dgvMitglieder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSortierung.ResumeLayout(False)
        Me.grpSortierung.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents lblKlasse As Label
    Friend WithEvents dgvMitglieder As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents grpSortierung As GroupBox
    Friend WithEvents radDESC As RadioButton
    Friend WithEvents radASC As RadioButton
End Class
