<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principale))
        Me.dataOggi = New System.Windows.Forms.Label()
        Me.gruppoEntrate = New System.Windows.Forms.GroupBox()
        Me.cancellaEntrate = New System.Windows.Forms.Button()
        Me.totaleEntrate = New System.Windows.Forms.Label()
        Me.calcolaEntrate = New System.Windows.Forms.Button()
        Me.altreentrateLabel = New System.Windows.Forms.Label()
        Me.altreEntrate = New System.Windows.Forms.TextBox()
        Me.risparmiLabel = New System.Windows.Forms.Label()
        Me.risparmi = New System.Windows.Forms.TextBox()
        Me.labelStipendio = New System.Windows.Forms.Label()
        Me.stipendio = New System.Windows.Forms.TextBox()
        Me.gruppoUscite = New System.Windows.Forms.GroupBox()
        Me.totaleUscite = New System.Windows.Forms.Label()
        Me.cancellaUscite = New System.Windows.Forms.Button()
        Me.calcolaUscite = New System.Windows.Forms.Button()
        Me.conselLabel = New System.Windows.Forms.Label()
        Me.tvOnDemand = New System.Windows.Forms.TextBox()
        Me.santanderLabel = New System.Windows.Forms.Label()
        Me.finanziamento = New System.Windows.Forms.TextBox()
        Me.caratCreditoLabel = New System.Windows.Forms.Label()
        Me.cartaCredito = New System.Windows.Forms.TextBox()
        Me.garageLabel = New System.Windows.Forms.Label()
        Me.garage = New System.Windows.Forms.TextBox()
        Me.condomionioLabel = New System.Windows.Forms.Label()
        Me.condominio = New System.Windows.Forms.TextBox()
        Me.affittoLabel = New System.Windows.Forms.Label()
        Me.affitto = New System.Windows.Forms.TextBox()
        Me.disponibilità = New System.Windows.Forms.Label()
        Me.menuGestionale = New System.Windows.Forms.MenuStrip()
        Me.gruppoDisponibilità = New System.Windows.Forms.GroupBox()
        Me.lblMessaggioSalva = New System.Windows.Forms.Label()
        Me.cancellaTutto = New System.Windows.Forms.Button()
        Me.clacolaDisponibilità = New System.Windows.Forms.Button()
        Me.iconSalvaMessaggio = New System.Windows.Forms.PictureBox()
        Me.immagineDisponibilità = New System.Windows.Forms.PictureBox()
        Me.conselIcon = New System.Windows.Forms.PictureBox()
        Me.santanderIcon = New System.Windows.Forms.PictureBox()
        Me.cartaCreditoIcon = New System.Windows.Forms.PictureBox()
        Me.garageIcon = New System.Windows.Forms.PictureBox()
        Me.condominioIcon = New System.Windows.Forms.PictureBox()
        Me.affittoIcon = New System.Windows.Forms.PictureBox()
        Me.altreEntrateIcon = New System.Windows.Forms.PictureBox()
        Me.risparmiIcon = New System.Windows.Forms.PictureBox()
        Me.stipendioIcon = New System.Windows.Forms.PictureBox()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EsportaPdfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsportaExelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChiudiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtInserisciMese = New System.Windows.Forms.ToolStripTextBox()
        Me.CreaDatabseMensileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.SalvaDatiAttualiNelDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoApplicazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniDiGestionalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizzaMesePrecedentiSalvatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gruppoEntrate.SuspendLayout()
        Me.gruppoUscite.SuspendLayout()
        Me.menuGestionale.SuspendLayout()
        Me.gruppoDisponibilità.SuspendLayout()
        CType(Me.iconSalvaMessaggio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.immagineDisponibilità, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conselIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.santanderIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cartaCreditoIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.garageIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.condominioIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.affittoIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.altreEntrateIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.risparmiIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stipendioIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataOggi
        '
        Me.dataOggi.AutoSize = True
        Me.dataOggi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataOggi.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.dataOggi.Location = New System.Drawing.Point(12, 59)
        Me.dataOggi.Name = "dataOggi"
        Me.dataOggi.Size = New System.Drawing.Size(65, 15)
        Me.dataOggi.TabIndex = 0
        Me.dataOggi.Text = "dataOggi"
        '
        'gruppoEntrate
        '
        Me.gruppoEntrate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gruppoEntrate.Controls.Add(Me.altreEntrateIcon)
        Me.gruppoEntrate.Controls.Add(Me.risparmiIcon)
        Me.gruppoEntrate.Controls.Add(Me.stipendioIcon)
        Me.gruppoEntrate.Controls.Add(Me.cancellaEntrate)
        Me.gruppoEntrate.Controls.Add(Me.totaleEntrate)
        Me.gruppoEntrate.Controls.Add(Me.calcolaEntrate)
        Me.gruppoEntrate.Controls.Add(Me.altreentrateLabel)
        Me.gruppoEntrate.Controls.Add(Me.altreEntrate)
        Me.gruppoEntrate.Controls.Add(Me.risparmiLabel)
        Me.gruppoEntrate.Controls.Add(Me.risparmi)
        Me.gruppoEntrate.Controls.Add(Me.labelStipendio)
        Me.gruppoEntrate.Controls.Add(Me.stipendio)
        Me.gruppoEntrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gruppoEntrate.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gruppoEntrate.Location = New System.Drawing.Point(11, 78)
        Me.gruppoEntrate.Name = "gruppoEntrate"
        Me.gruppoEntrate.Size = New System.Drawing.Size(226, 256)
        Me.gruppoEntrate.TabIndex = 1
        Me.gruppoEntrate.TabStop = False
        Me.gruppoEntrate.Text = "Entrate"
        '
        'cancellaEntrate
        '
        Me.cancellaEntrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancellaEntrate.Location = New System.Drawing.Point(116, 214)
        Me.cancellaEntrate.Name = "cancellaEntrate"
        Me.cancellaEntrate.Size = New System.Drawing.Size(75, 35)
        Me.cancellaEntrate.TabIndex = 9
        Me.cancellaEntrate.Text = "Cancella"
        Me.cancellaEntrate.UseVisualStyleBackColor = True
        '
        'totaleEntrate
        '
        Me.totaleEntrate.AutoSize = True
        Me.totaleEntrate.Location = New System.Drawing.Point(24, 150)
        Me.totaleEntrate.Name = "totaleEntrate"
        Me.totaleEntrate.Size = New System.Drawing.Size(72, 24)
        Me.totaleEntrate.TabIndex = 7
        Me.totaleEntrate.Text = "Calcola"
        '
        'calcolaEntrate
        '
        Me.calcolaEntrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcolaEntrate.Location = New System.Drawing.Point(24, 214)
        Me.calcolaEntrate.Name = "calcolaEntrate"
        Me.calcolaEntrate.Size = New System.Drawing.Size(75, 35)
        Me.calcolaEntrate.TabIndex = 6
        Me.calcolaEntrate.Text = "Calcola"
        Me.calcolaEntrate.UseVisualStyleBackColor = True
        '
        'altreentrateLabel
        '
        Me.altreentrateLabel.AutoSize = True
        Me.altreentrateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altreentrateLabel.ForeColor = System.Drawing.Color.Green
        Me.altreentrateLabel.Location = New System.Drawing.Point(124, 93)
        Me.altreentrateLabel.Name = "altreentrateLabel"
        Me.altreentrateLabel.Size = New System.Drawing.Size(88, 18)
        Me.altreentrateLabel.TabIndex = 5
        Me.altreentrateLabel.Text = "Altre Entrate"
        '
        'altreEntrate
        '
        Me.altreEntrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altreEntrate.Location = New System.Drawing.Point(27, 90)
        Me.altreEntrate.Name = "altreEntrate"
        Me.altreEntrate.Size = New System.Drawing.Size(88, 24)
        Me.altreEntrate.TabIndex = 4
        Me.altreEntrate.Text = "0,00"
        '
        'risparmiLabel
        '
        Me.risparmiLabel.AutoSize = True
        Me.risparmiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.risparmiLabel.ForeColor = System.Drawing.Color.Green
        Me.risparmiLabel.Location = New System.Drawing.Point(124, 63)
        Me.risparmiLabel.Name = "risparmiLabel"
        Me.risparmiLabel.Size = New System.Drawing.Size(67, 18)
        Me.risparmiLabel.TabIndex = 3
        Me.risparmiLabel.Text = "Risparmi"
        '
        'risparmi
        '
        Me.risparmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.risparmi.Location = New System.Drawing.Point(28, 60)
        Me.risparmi.Name = "risparmi"
        Me.risparmi.Size = New System.Drawing.Size(88, 24)
        Me.risparmi.TabIndex = 2
        Me.risparmi.Text = "0,00"
        '
        'labelStipendio
        '
        Me.labelStipendio.AutoSize = True
        Me.labelStipendio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelStipendio.ForeColor = System.Drawing.Color.Green
        Me.labelStipendio.Location = New System.Drawing.Point(124, 33)
        Me.labelStipendio.Name = "labelStipendio"
        Me.labelStipendio.Size = New System.Drawing.Size(69, 18)
        Me.labelStipendio.TabIndex = 1
        Me.labelStipendio.Text = "Stipendio"
        '
        'stipendio
        '
        Me.stipendio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stipendio.Location = New System.Drawing.Point(28, 30)
        Me.stipendio.Name = "stipendio"
        Me.stipendio.Size = New System.Drawing.Size(88, 24)
        Me.stipendio.TabIndex = 0
        Me.stipendio.Text = "0,00"
        '
        'gruppoUscite
        '
        Me.gruppoUscite.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gruppoUscite.Controls.Add(Me.totaleUscite)
        Me.gruppoUscite.Controls.Add(Me.cancellaUscite)
        Me.gruppoUscite.Controls.Add(Me.calcolaUscite)
        Me.gruppoUscite.Controls.Add(Me.conselLabel)
        Me.gruppoUscite.Controls.Add(Me.conselIcon)
        Me.gruppoUscite.Controls.Add(Me.tvOnDemand)
        Me.gruppoUscite.Controls.Add(Me.santanderLabel)
        Me.gruppoUscite.Controls.Add(Me.santanderIcon)
        Me.gruppoUscite.Controls.Add(Me.finanziamento)
        Me.gruppoUscite.Controls.Add(Me.caratCreditoLabel)
        Me.gruppoUscite.Controls.Add(Me.cartaCreditoIcon)
        Me.gruppoUscite.Controls.Add(Me.cartaCredito)
        Me.gruppoUscite.Controls.Add(Me.garageLabel)
        Me.gruppoUscite.Controls.Add(Me.garageIcon)
        Me.gruppoUscite.Controls.Add(Me.garage)
        Me.gruppoUscite.Controls.Add(Me.condomionioLabel)
        Me.gruppoUscite.Controls.Add(Me.condominioIcon)
        Me.gruppoUscite.Controls.Add(Me.condominio)
        Me.gruppoUscite.Controls.Add(Me.affittoLabel)
        Me.gruppoUscite.Controls.Add(Me.affittoIcon)
        Me.gruppoUscite.Controls.Add(Me.affitto)
        Me.gruppoUscite.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gruppoUscite.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gruppoUscite.Location = New System.Drawing.Point(241, 78)
        Me.gruppoUscite.Name = "gruppoUscite"
        Me.gruppoUscite.Size = New System.Drawing.Size(307, 256)
        Me.gruppoUscite.TabIndex = 2
        Me.gruppoUscite.TabStop = False
        Me.gruppoUscite.Text = "Uscite"
        '
        'totaleUscite
        '
        Me.totaleUscite.AutoSize = True
        Me.totaleUscite.Location = New System.Drawing.Point(199, 218)
        Me.totaleUscite.Name = "totaleUscite"
        Me.totaleUscite.Size = New System.Drawing.Size(72, 24)
        Me.totaleUscite.TabIndex = 20
        Me.totaleUscite.Text = "Calcola"
        '
        'cancellaUscite
        '
        Me.cancellaUscite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancellaUscite.Location = New System.Drawing.Point(104, 214)
        Me.cancellaUscite.Name = "cancellaUscite"
        Me.cancellaUscite.Size = New System.Drawing.Size(75, 35)
        Me.cancellaUscite.TabIndex = 19
        Me.cancellaUscite.Text = "Cancella"
        Me.cancellaUscite.UseVisualStyleBackColor = True
        '
        'calcolaUscite
        '
        Me.calcolaUscite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcolaUscite.Location = New System.Drawing.Point(12, 214)
        Me.calcolaUscite.Name = "calcolaUscite"
        Me.calcolaUscite.Size = New System.Drawing.Size(75, 35)
        Me.calcolaUscite.TabIndex = 18
        Me.calcolaUscite.Text = "Calcola"
        Me.calcolaUscite.UseVisualStyleBackColor = True
        '
        'conselLabel
        '
        Me.conselLabel.AutoSize = True
        Me.conselLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conselLabel.ForeColor = System.Drawing.Color.Crimson
        Me.conselLabel.Location = New System.Drawing.Point(145, 183)
        Me.conselLabel.Name = "conselLabel"
        Me.conselLabel.Size = New System.Drawing.Size(110, 18)
        Me.conselLabel.TabIndex = 17
        Me.conselLabel.Text = "TV On Demand"
        '
        'tvOnDemand
        '
        Me.tvOnDemand.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvOnDemand.Location = New System.Drawing.Point(39, 180)
        Me.tvOnDemand.Name = "tvOnDemand"
        Me.tvOnDemand.Size = New System.Drawing.Size(100, 24)
        Me.tvOnDemand.TabIndex = 15
        Me.tvOnDemand.Text = "0,00"
        '
        'santanderLabel
        '
        Me.santanderLabel.AutoSize = True
        Me.santanderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.santanderLabel.ForeColor = System.Drawing.Color.Crimson
        Me.santanderLabel.Location = New System.Drawing.Point(145, 153)
        Me.santanderLabel.Name = "santanderLabel"
        Me.santanderLabel.Size = New System.Drawing.Size(117, 18)
        Me.santanderLabel.TabIndex = 14
        Me.santanderLabel.Text = "Finanziamento 1"
        '
        'finanziamento
        '
        Me.finanziamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finanziamento.Location = New System.Drawing.Point(39, 150)
        Me.finanziamento.Name = "finanziamento"
        Me.finanziamento.Size = New System.Drawing.Size(100, 24)
        Me.finanziamento.TabIndex = 12
        Me.finanziamento.Text = "0,00"
        '
        'caratCreditoLabel
        '
        Me.caratCreditoLabel.AutoSize = True
        Me.caratCreditoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caratCreditoLabel.ForeColor = System.Drawing.Color.Crimson
        Me.caratCreditoLabel.Location = New System.Drawing.Point(145, 123)
        Me.caratCreditoLabel.Name = "caratCreditoLabel"
        Me.caratCreditoLabel.Size = New System.Drawing.Size(111, 18)
        Me.caratCreditoLabel.TabIndex = 11
        Me.caratCreditoLabel.Text = "Carta di Credito"
        '
        'cartaCredito
        '
        Me.cartaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartaCredito.Location = New System.Drawing.Point(39, 120)
        Me.cartaCredito.Name = "cartaCredito"
        Me.cartaCredito.Size = New System.Drawing.Size(100, 24)
        Me.cartaCredito.TabIndex = 9
        Me.cartaCredito.Text = "0,00"
        '
        'garageLabel
        '
        Me.garageLabel.AutoSize = True
        Me.garageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.garageLabel.ForeColor = System.Drawing.Color.Crimson
        Me.garageLabel.Location = New System.Drawing.Point(145, 93)
        Me.garageLabel.Name = "garageLabel"
        Me.garageLabel.Size = New System.Drawing.Size(57, 18)
        Me.garageLabel.TabIndex = 8
        Me.garageLabel.Text = "Garage"
        '
        'garage
        '
        Me.garage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.garage.Location = New System.Drawing.Point(39, 90)
        Me.garage.Name = "garage"
        Me.garage.Size = New System.Drawing.Size(100, 24)
        Me.garage.TabIndex = 6
        Me.garage.Text = "0,00"
        '
        'condomionioLabel
        '
        Me.condomionioLabel.AutoSize = True
        Me.condomionioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.condomionioLabel.ForeColor = System.Drawing.Color.Crimson
        Me.condomionioLabel.Location = New System.Drawing.Point(145, 63)
        Me.condomionioLabel.Name = "condomionioLabel"
        Me.condomionioLabel.Size = New System.Drawing.Size(121, 18)
        Me.condomionioLabel.TabIndex = 5
        Me.condomionioLabel.Text = "Spese abitazione"
        '
        'condominio
        '
        Me.condominio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.condominio.Location = New System.Drawing.Point(39, 60)
        Me.condominio.Name = "condominio"
        Me.condominio.Size = New System.Drawing.Size(100, 24)
        Me.condominio.TabIndex = 3
        Me.condominio.Text = "0,00"
        '
        'affittoLabel
        '
        Me.affittoLabel.AutoSize = True
        Me.affittoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.affittoLabel.ForeColor = System.Drawing.Color.Crimson
        Me.affittoLabel.Location = New System.Drawing.Point(145, 33)
        Me.affittoLabel.Name = "affittoLabel"
        Me.affittoLabel.Size = New System.Drawing.Size(100, 18)
        Me.affittoLabel.TabIndex = 2
        Me.affittoLabel.Text = "Affitto - Mutuo"
        '
        'affitto
        '
        Me.affitto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.affitto.Location = New System.Drawing.Point(39, 30)
        Me.affitto.Name = "affitto"
        Me.affitto.Size = New System.Drawing.Size(100, 24)
        Me.affitto.TabIndex = 0
        Me.affitto.Text = "0,00"
        '
        'disponibilità
        '
        Me.disponibilità.AutoSize = True
        Me.disponibilità.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disponibilità.Location = New System.Drawing.Point(38, 40)
        Me.disponibilità.Name = "disponibilità"
        Me.disponibilità.Size = New System.Drawing.Size(72, 24)
        Me.disponibilità.TabIndex = 3
        Me.disponibilità.Text = "Calcola"
        '
        'menuGestionale
        '
        Me.menuGestionale.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.menuGestionale.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StoricoToolStripMenuItem, Me.ToolStripMenuItem1, Me.InfoApplicazioneToolStripMenuItem})
        Me.menuGestionale.Location = New System.Drawing.Point(0, 0)
        Me.menuGestionale.Name = "menuGestionale"
        Me.menuGestionale.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.menuGestionale.Size = New System.Drawing.Size(783, 24)
        Me.menuGestionale.TabIndex = 4
        Me.menuGestionale.Text = "menuGestionale"
        '
        'gruppoDisponibilità
        '
        Me.gruppoDisponibilità.Controls.Add(Me.iconSalvaMessaggio)
        Me.gruppoDisponibilità.Controls.Add(Me.lblMessaggioSalva)
        Me.gruppoDisponibilità.Controls.Add(Me.immagineDisponibilità)
        Me.gruppoDisponibilità.Controls.Add(Me.cancellaTutto)
        Me.gruppoDisponibilità.Controls.Add(Me.clacolaDisponibilità)
        Me.gruppoDisponibilità.Controls.Add(Me.disponibilità)
        Me.gruppoDisponibilità.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gruppoDisponibilità.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.gruppoDisponibilità.Location = New System.Drawing.Point(554, 78)
        Me.gruppoDisponibilità.Name = "gruppoDisponibilità"
        Me.gruppoDisponibilità.Size = New System.Drawing.Size(200, 152)
        Me.gruppoDisponibilità.TabIndex = 5
        Me.gruppoDisponibilità.TabStop = False
        Me.gruppoDisponibilità.Text = "Disponibilità"
        '
        'lblMessaggioSalva
        '
        Me.lblMessaggioSalva.AutoSize = True
        Me.lblMessaggioSalva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessaggioSalva.Location = New System.Drawing.Point(40, 127)
        Me.lblMessaggioSalva.Name = "lblMessaggioSalva"
        Me.lblMessaggioSalva.Size = New System.Drawing.Size(39, 13)
        Me.lblMessaggioSalva.TabIndex = 7
        Me.lblMessaggioSalva.Text = "Label1"
        '
        'cancellaTutto
        '
        Me.cancellaTutto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancellaTutto.Location = New System.Drawing.Point(111, 84)
        Me.cancellaTutto.Name = "cancellaTutto"
        Me.cancellaTutto.Size = New System.Drawing.Size(75, 36)
        Me.cancellaTutto.TabIndex = 5
        Me.cancellaTutto.Text = "Cancella tutto"
        Me.cancellaTutto.UseVisualStyleBackColor = True
        '
        'clacolaDisponibilità
        '
        Me.clacolaDisponibilità.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clacolaDisponibilità.Location = New System.Drawing.Point(19, 84)
        Me.clacolaDisponibilità.Name = "clacolaDisponibilità"
        Me.clacolaDisponibilità.Size = New System.Drawing.Size(75, 36)
        Me.clacolaDisponibilità.TabIndex = 4
        Me.clacolaDisponibilità.Text = "Calcola"
        Me.clacolaDisponibilità.UseVisualStyleBackColor = True
        '
        'iconSalvaMessaggio
        '
        Me.iconSalvaMessaggio.Location = New System.Drawing.Point(18, 125)
        Me.iconSalvaMessaggio.Name = "iconSalvaMessaggio"
        Me.iconSalvaMessaggio.Size = New System.Drawing.Size(16, 16)
        Me.iconSalvaMessaggio.TabIndex = 8
        Me.iconSalvaMessaggio.TabStop = False
        '
        'immagineDisponibilità
        '
        Me.immagineDisponibilità.Image = Global.gestionale.My.Resources.Resources.blank
        Me.immagineDisponibilità.Location = New System.Drawing.Point(18, 44)
        Me.immagineDisponibilità.Name = "immagineDisponibilità"
        Me.immagineDisponibilità.Size = New System.Drawing.Size(16, 16)
        Me.immagineDisponibilità.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.immagineDisponibilità.TabIndex = 6
        Me.immagineDisponibilità.TabStop = False
        '
        'conselIcon
        '
        Me.conselIcon.Image = Global.gestionale.My.Resources.Resources.monitor
        Me.conselIcon.Location = New System.Drawing.Point(15, 185)
        Me.conselIcon.Name = "conselIcon"
        Me.conselIcon.Size = New System.Drawing.Size(16, 16)
        Me.conselIcon.TabIndex = 16
        Me.conselIcon.TabStop = False
        '
        'santanderIcon
        '
        Me.santanderIcon.Image = Global.gestionale.My.Resources.Resources.money_delete
        Me.santanderIcon.Location = New System.Drawing.Point(15, 154)
        Me.santanderIcon.Name = "santanderIcon"
        Me.santanderIcon.Size = New System.Drawing.Size(16, 16)
        Me.santanderIcon.TabIndex = 13
        Me.santanderIcon.TabStop = False
        '
        'cartaCreditoIcon
        '
        Me.cartaCreditoIcon.Image = Global.gestionale.My.Resources.Resources.creditcards
        Me.cartaCreditoIcon.Location = New System.Drawing.Point(12, 125)
        Me.cartaCreditoIcon.Name = "cartaCreditoIcon"
        Me.cartaCreditoIcon.Size = New System.Drawing.Size(16, 16)
        Me.cartaCreditoIcon.TabIndex = 10
        Me.cartaCreditoIcon.TabStop = False
        '
        'garageIcon
        '
        Me.garageIcon.Image = Global.gestionale.My.Resources.Resources.car
        Me.garageIcon.Location = New System.Drawing.Point(12, 95)
        Me.garageIcon.Name = "garageIcon"
        Me.garageIcon.Size = New System.Drawing.Size(16, 16)
        Me.garageIcon.TabIndex = 7
        Me.garageIcon.TabStop = False
        '
        'condominioIcon
        '
        Me.condominioIcon.Image = Global.gestionale.My.Resources.Resources.house_go
        Me.condominioIcon.Location = New System.Drawing.Point(12, 65)
        Me.condominioIcon.Name = "condominioIcon"
        Me.condominioIcon.Size = New System.Drawing.Size(16, 16)
        Me.condominioIcon.TabIndex = 4
        Me.condominioIcon.TabStop = False
        '
        'affittoIcon
        '
        Me.affittoIcon.Image = Global.gestionale.My.Resources.Resources.house
        Me.affittoIcon.Location = New System.Drawing.Point(12, 34)
        Me.affittoIcon.Name = "affittoIcon"
        Me.affittoIcon.Size = New System.Drawing.Size(16, 16)
        Me.affittoIcon.TabIndex = 1
        Me.affittoIcon.TabStop = False
        '
        'altreEntrateIcon
        '
        Me.altreEntrateIcon.Image = Global.gestionale.My.Resources.Resources.add
        Me.altreEntrateIcon.Location = New System.Drawing.Point(6, 95)
        Me.altreEntrateIcon.Name = "altreEntrateIcon"
        Me.altreEntrateIcon.Size = New System.Drawing.Size(16, 16)
        Me.altreEntrateIcon.TabIndex = 12
        Me.altreEntrateIcon.TabStop = False
        '
        'risparmiIcon
        '
        Me.risparmiIcon.Image = Global.gestionale.My.Resources.Resources.coins_add
        Me.risparmiIcon.Location = New System.Drawing.Point(6, 65)
        Me.risparmiIcon.Name = "risparmiIcon"
        Me.risparmiIcon.Size = New System.Drawing.Size(16, 16)
        Me.risparmiIcon.TabIndex = 11
        Me.risparmiIcon.TabStop = False
        '
        'stipendioIcon
        '
        Me.stipendioIcon.Image = Global.gestionale.My.Resources.Resources.money
        Me.stipendioIcon.Location = New System.Drawing.Point(6, 34)
        Me.stipendioIcon.Name = "stipendioIcon"
        Me.stipendioIcon.Size = New System.Drawing.Size(16, 16)
        Me.stipendioIcon.TabIndex = 10
        Me.stipendioIcon.TabStop = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApriToolStripMenuItem, Me.SalvaToolStripMenuItem, Me.ToolStripSeparator1, Me.EsportaPdfToolStripMenuItem, Me.EsportaExelToolStripMenuItem, Me.ToolStripSeparator2, Me.ChiudiToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.add
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ApriToolStripMenuItem
        '
        Me.ApriToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.folder_add
        Me.ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        Me.ApriToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ApriToolStripMenuItem.Text = "Apri"
        '
        'SalvaToolStripMenuItem
        '
        Me.SalvaToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.disk
        Me.SalvaToolStripMenuItem.Name = "SalvaToolStripMenuItem"
        Me.SalvaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SalvaToolStripMenuItem.Text = "Salva"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'EsportaPdfToolStripMenuItem
        '
        Me.EsportaPdfToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.page_white_acrobat
        Me.EsportaPdfToolStripMenuItem.Name = "EsportaPdfToolStripMenuItem"
        Me.EsportaPdfToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EsportaPdfToolStripMenuItem.Text = "Esporta Pdf"
        '
        'EsportaExelToolStripMenuItem
        '
        Me.EsportaExelToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.page_excel
        Me.EsportaExelToolStripMenuItem.Name = "EsportaExelToolStripMenuItem"
        Me.EsportaExelToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.EsportaExelToolStripMenuItem.Text = "Esporta Exel"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(133, 6)
        '
        'ChiudiToolStripMenuItem
        '
        Me.ChiudiToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.door_in
        Me.ChiudiToolStripMenuItem.Name = "ChiudiToolStripMenuItem"
        Me.ChiudiToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ChiudiToolStripMenuItem.Text = "Chiudi"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtInserisciMese, Me.CreaDatabseMensileToolStripMenuItem, Me.ToolStripSeparator3, Me.ToolStripTextBox1, Me.SalvaDatiAttualiNelDBToolStripMenuItem})
        Me.ToolStripMenuItem1.Image = Global.gestionale.My.Resources.Resources.database
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(101, 20)
        Me.ToolStripMenuItem1.Text = "Azioni su DB"
        '
        'txtInserisciMese
        '
        Me.txtInserisciMese.Name = "txtInserisciMese"
        Me.txtInserisciMese.Size = New System.Drawing.Size(100, 23)
        '
        'CreaDatabseMensileToolStripMenuItem
        '
        Me.CreaDatabseMensileToolStripMenuItem.Enabled = False
        Me.CreaDatabseMensileToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.database_add
        Me.CreaDatabseMensileToolStripMenuItem.Name = "CreaDatabseMensileToolStripMenuItem"
        Me.CreaDatabseMensileToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.CreaDatabseMensileToolStripMenuItem.Text = "Crea Database Mensile"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(257, 6)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(200, 23)
        '
        'SalvaDatiAttualiNelDBToolStripMenuItem
        '
        Me.SalvaDatiAttualiNelDBToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.database_edit
        Me.SalvaDatiAttualiNelDBToolStripMenuItem.Name = "SalvaDatiAttualiNelDBToolStripMenuItem"
        Me.SalvaDatiAttualiNelDBToolStripMenuItem.Size = New System.Drawing.Size(260, 22)
        Me.SalvaDatiAttualiNelDBToolStripMenuItem.Text = "Salva dati attuali nel DB"
        '
        'StoricoToolStripMenuItem
        '
        Me.StoricoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizzaMesePrecedentiSalvatiToolStripMenuItem})
        Me.StoricoToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.application
        Me.StoricoToolStripMenuItem.Name = "StoricoToolStripMenuItem"
        Me.StoricoToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.StoricoToolStripMenuItem.Text = "Storico "
        '
        'InfoApplicazioneToolStripMenuItem
        '
        Me.InfoApplicazioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformazioniDiGestionalToolStripMenuItem})
        Me.InfoApplicazioneToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.information
        Me.InfoApplicazioneToolStripMenuItem.Name = "InfoApplicazioneToolStripMenuItem"
        Me.InfoApplicazioneToolStripMenuItem.Size = New System.Drawing.Size(127, 20)
        Me.InfoApplicazioneToolStripMenuItem.Text = "Info Applicazione"
        '
        'InformazioniDiGestionalToolStripMenuItem
        '
        Me.InformazioniDiGestionalToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.information
        Me.InformazioniDiGestionalToolStripMenuItem.Name = "InformazioniDiGestionalToolStripMenuItem"
        Me.InformazioniDiGestionalToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.InformazioniDiGestionalToolStripMenuItem.Text = "Informazioni di Gestional€"
        '
        'VisualizzaMesePrecedentiSalvatiToolStripMenuItem
        '
        Me.VisualizzaMesePrecedentiSalvatiToolStripMenuItem.Image = Global.gestionale.My.Resources.Resources.application_form
        Me.VisualizzaMesePrecedentiSalvatiToolStripMenuItem.Name = "VisualizzaMesePrecedentiSalvatiToolStripMenuItem"
        Me.VisualizzaMesePrecedentiSalvatiToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.VisualizzaMesePrecedentiSalvatiToolStripMenuItem.Text = "Visualizza Mese precedenti Salvati"
        '
        'Principale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 357)
        Me.Controls.Add(Me.gruppoDisponibilità)
        Me.Controls.Add(Me.gruppoUscite)
        Me.Controls.Add(Me.gruppoEntrate)
        Me.Controls.Add(Me.dataOggi)
        Me.Controls.Add(Me.menuGestionale)
        Me.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuGestionale
        Me.Name = "Principale"
        Me.Text = "Gestionale domestico"
        Me.gruppoEntrate.ResumeLayout(False)
        Me.gruppoEntrate.PerformLayout()
        Me.gruppoUscite.ResumeLayout(False)
        Me.gruppoUscite.PerformLayout()
        Me.menuGestionale.ResumeLayout(False)
        Me.menuGestionale.PerformLayout()
        Me.gruppoDisponibilità.ResumeLayout(False)
        Me.gruppoDisponibilità.PerformLayout()
        CType(Me.iconSalvaMessaggio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.immagineDisponibilità, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conselIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.santanderIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cartaCreditoIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.garageIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.condominioIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.affittoIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.altreEntrateIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.risparmiIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stipendioIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataOggi As System.Windows.Forms.Label
    Friend WithEvents gruppoEntrate As System.Windows.Forms.GroupBox
    Friend WithEvents stipendio As System.Windows.Forms.TextBox
    Friend WithEvents labelStipendio As System.Windows.Forms.Label
    Friend WithEvents risparmiLabel As System.Windows.Forms.Label
    Friend WithEvents risparmi As System.Windows.Forms.TextBox
    Friend WithEvents altreEntrate As System.Windows.Forms.TextBox
    Friend WithEvents altreentrateLabel As System.Windows.Forms.Label
    Friend WithEvents calcolaEntrate As System.Windows.Forms.Button
    Friend WithEvents totaleEntrate As System.Windows.Forms.Label
    Friend WithEvents cancellaEntrate As System.Windows.Forms.Button
    Friend WithEvents gruppoUscite As System.Windows.Forms.GroupBox
    Friend WithEvents affittoIcon As System.Windows.Forms.PictureBox
    Friend WithEvents affitto As System.Windows.Forms.TextBox
    Friend WithEvents stipendioIcon As System.Windows.Forms.PictureBox
    Friend WithEvents condominioIcon As System.Windows.Forms.PictureBox
    Friend WithEvents condominio As System.Windows.Forms.TextBox
    Friend WithEvents affittoLabel As System.Windows.Forms.Label
    Friend WithEvents condomionioLabel As System.Windows.Forms.Label
    Friend WithEvents risparmiIcon As System.Windows.Forms.PictureBox
    Friend WithEvents altreEntrateIcon As System.Windows.Forms.PictureBox
    Friend WithEvents garageIcon As System.Windows.Forms.PictureBox
    Friend WithEvents garage As System.Windows.Forms.TextBox
    Friend WithEvents garageLabel As System.Windows.Forms.Label
    Friend WithEvents cartaCreditoIcon As System.Windows.Forms.PictureBox
    Friend WithEvents cartaCredito As System.Windows.Forms.TextBox
    Friend WithEvents caratCreditoLabel As System.Windows.Forms.Label
    Friend WithEvents santanderIcon As System.Windows.Forms.PictureBox
    Friend WithEvents finanziamento As System.Windows.Forms.TextBox
    Friend WithEvents santanderLabel As System.Windows.Forms.Label
    Friend WithEvents conselIcon As System.Windows.Forms.PictureBox
    Friend WithEvents tvOnDemand As System.Windows.Forms.TextBox
    Friend WithEvents conselLabel As System.Windows.Forms.Label
    Friend WithEvents cancellaUscite As System.Windows.Forms.Button
    Friend WithEvents calcolaUscite As System.Windows.Forms.Button
    Friend WithEvents totaleUscite As System.Windows.Forms.Label
    Friend WithEvents disponibilità As System.Windows.Forms.Label
    Friend WithEvents menuGestionale As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoApplicazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniDiGestionalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsportaPdfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsportaExelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChiudiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents gruppoDisponibilità As System.Windows.Forms.GroupBox
    Friend WithEvents clacolaDisponibilità As System.Windows.Forms.Button
    Friend WithEvents cancellaTutto As System.Windows.Forms.Button
    Friend WithEvents immagineDisponibilità As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreaDatabseMensileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtInserisciMese As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SalvaDatiAttualiNelDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblMessaggioSalva As System.Windows.Forms.Label
    Friend WithEvents iconSalvaMessaggio As System.Windows.Forms.PictureBox
    Friend WithEvents StoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizzaMesePrecedentiSalvatiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
