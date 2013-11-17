<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infoGestionale
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.buttonChiudi = New System.Windows.Forms.Button()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.suggerimentiLink = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.grazieFamFam = New System.Windows.Forms.Label()
        Me.famLink = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonChiudi
        '
        Me.buttonChiudi.Location = New System.Drawing.Point(241, 100)
        Me.buttonChiudi.Name = "buttonChiudi"
        Me.buttonChiudi.Size = New System.Drawing.Size(75, 23)
        Me.buttonChiudi.TabIndex = 1
        Me.buttonChiudi.Text = "Chiudi Info"
        Me.buttonChiudi.UseVisualStyleBackColor = True
        '
        'infoLabel
        '
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Location = New System.Drawing.Point(131, 12)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(192, 39)
        Me.infoLabel.TabIndex = 2
        Me.infoLabel.Text = "Mantieni sotto controllo le tue spese " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mensili con questo semplice gestionale " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'suggerimentiLink
        '
        Me.suggerimentiLink.AutoSize = True
        Me.suggerimentiLink.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.suggerimentiLink.Location = New System.Drawing.Point(160, 105)
        Me.suggerimentiLink.Name = "suggerimentiLink"
        Me.suggerimentiLink.Size = New System.Drawing.Size(68, 13)
        Me.suggerimentiLink.TabIndex = 3
        Me.suggerimentiLink.TabStop = True
        Me.suggerimentiLink.Text = "Suggerimenti"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.gestionale.My.Resources.Resources.coin_euro_icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(113, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.gestionale.My.Resources.Resources.email
        Me.PictureBox2.Location = New System.Drawing.Point(142, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'grazieFamFam
        '
        Me.grazieFamFam.AutoSize = True
        Me.grazieFamFam.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grazieFamFam.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.grazieFamFam.Location = New System.Drawing.Point(140, 71)
        Me.grazieFamFam.Name = "grazieFamFam"
        Me.grazieFamFam.Size = New System.Drawing.Size(75, 24)
        Me.grazieFamFam.TabIndex = 5
        Me.grazieFamFam.Text = "Grazie a:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FAMFAM ICON"
        '
        'famLink
        '
        Me.famLink.AutoSize = True
        Me.famLink.Location = New System.Drawing.Point(214, 82)
        Me.famLink.Name = "famLink"
        Me.famLink.Size = New System.Drawing.Size(25, 13)
        Me.famLink.TabIndex = 6
        Me.famLink.TabStop = True
        Me.famLink.Text = "Sito"
        '
        'infoGestionale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 135)
        Me.ControlBox = False
        Me.Controls.Add(Me.famLink)
        Me.Controls.Add(Me.grazieFamFam)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.suggerimentiLink)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.buttonChiudi)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "infoGestionale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Info Gestional€"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents buttonChiudi As System.Windows.Forms.Button
    Friend WithEvents infoLabel As System.Windows.Forms.Label
    Friend WithEvents suggerimentiLink As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents grazieFamFam As System.Windows.Forms.Label
    Friend WithEvents famLink As System.Windows.Forms.LinkLabel
End Class
