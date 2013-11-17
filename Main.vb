Imports ADOX
Public Class Principale
    'Il testo vuoto da utilizzare nelle diverse operazioni del programma
    Dim testoVuoto As String = String.Empty
    Dim iconCancel As Image = My.Resources.cancel
    Dim iconPositivo As Image = My.Resources.add
    Dim iconBlank As Image = My.Resources.blank
    Private Sub Principale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CreaDatabseMensileToolStripMenuItem.Enabled = False
        'Disabilito la possibilità di dimensionare a tutto schermo
        Me.MaximizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        'Label del giorno attuale
        Dim suffisso As String = "Data odierna: "
        dataOggi.Text = suffisso + CStr(Today)
        'Imposto i label dei totali di calcolo vuoti con il solo simbolo € di colore nero all'avvio dell'applicazione
        For Each totali As Label In {totaleEntrate, totaleUscite, disponibilità}
            totali.Text = "€"
            totali.ForeColor = Color.Black
        Next
        'Imposto immagine close al tasto calcola disponibilità
        clacolaDisponibilità.Text = testoVuoto
        CType(clacolaDisponibilità, Button).Image = My.Resources.cancel
        'Disattivo il tasto diponibilità all'avvio del programma
        clacolaDisponibilità.Enabled = False
        With txtInserisciMese
            .Text = "Inserisci Mese"
            .Size = New System.Drawing.Size(200, 10)
        End With
        With ToolStripTextBox1
            .Text = "Salva mese in corso"
        End With
        SalvaDatiAttualiNelDBToolStripMenuItem.Enabled = False
        iconSalvaMessaggio.Image = iconBlank
        lblMessaggioSalva.Text = String.Empty
    End Sub
    Private Sub clacolaDisponibilità_Click(sender As Object, e As EventArgs) Handles clacolaDisponibilità.Click
        Dim affi As Decimal = Decimal.Parse(affitto.Text)
        Dim condo As Decimal = Decimal.Parse(condominio.Text)
        Dim garag As Decimal = Decimal.Parse(garage.Text)
        Dim cc As Decimal = Decimal.Parse(cartaCredito.Text)
        Dim santa As Decimal = Decimal.Parse(finanziamento.Text)
        Dim tv As Decimal = Decimal.Parse(tvOnDemand.Text)
        Dim totaleu As Decimal
        Dim stip As Decimal = Decimal.Parse(stipendio.Text)
        Dim risp As Decimal = Decimal.Parse(risparmi.Text)
        Dim otherEntry As Decimal = Decimal.Parse(altreEntrate.Text)
        Dim totale As Decimal
        Dim disponibile As Decimal
        ' Operazioni di tutte le variabili di calcolo
        totaleu = affi + condo + garag + cc + santa + tv
        totale = stip + risp + otherEntry
        disponibile = totale - totaleu
        'Imposto il calcolo nel label della disponibilità
        disponibilità.Text = (disponibile.ToString("C"))
        'Imposto il colore del label in base al numero se esso positivo o negativo
        If disponibile >= 0 Then
            disponibilità.ForeColor = Color.Green
            immagineDisponibilità.Image = iconPositivo
        ElseIf disponibile < 0 Then
            disponibilità.ForeColor = Color.Red
            immagineDisponibilità.Image = iconCancel
            MsgBox("Attenzione il tuo Saldo è NEGATIVO", MsgBoxStyle.Critical, "SALDO NEGATIVO")
        End If
        SalvaDatiAttualiNelDBToolStripMenuItem.Enabled = True
        With lblMessaggioSalva
            .Text = "Ora è possibile Salvare i dati"
            .Font = New Font("Arial", 8, FontStyle.Underline)
            .ForeColor = Color.Green
        End With
        iconSalvaMessaggio.Image = My.Resources.database_save
    End Sub
    Private Sub calcolaEntrate_Click(sender As Object, e As EventArgs) Handles calcolaEntrate.Click
        Dim stip As Decimal = Decimal.Parse(stipendio.Text)
        Dim risp As Decimal = Decimal.Parse(risparmi.Text)
        Dim otherEntry As Decimal = Decimal.Parse(altreEntrate.Text)
        Dim totale As Decimal
        'Somma delle entrate
        totale = stip + risp + otherEntry
        'Imposta il totale alla valuta del sistema
        totaleEntrate.Text = (totale.ToString("C"))
        'Imposta il colore della somma totale delle entrate in base alla disponibiià di credito
        If totale >= 0 Then
            totaleEntrate.ForeColor = Color.Green
        ElseIf totale < 0 Then
            totaleEntrate.ForeColor = Color.Red
        End If
        'Dopo il calcolo e l'esecuzione del colore da attribuire impongo che il bottone calcola sia disabilitato 
        calcolaEntrate.Enabled = False
        'Dopo il calcolo elimino il testo del bottone per far apparire l'immagine 
        calcolaEntrate.Text = testoVuoto
        CType(calcolaEntrate(), Button).Image = iconCancel
    End Sub
    Private Sub calcolaUscite_Click(sender As Object, e As EventArgs) Handles calcolaUscite.Click
        'Dichiarazione varibili uscite
        Dim affi As Decimal = Decimal.Parse(affitto.Text)
        Dim condo As Decimal = Decimal.Parse(condominio.Text)
        Dim garag As Decimal = Decimal.Parse(garage.Text)
        Dim cc As Decimal = Decimal.Parse(cartaCredito.Text)
        Dim santa As Decimal = Decimal.Parse(finanziamento.Text)
        Dim tv As Decimal = Decimal.Parse(tvOnDemand.Text)
        Dim totaleu As Decimal
        'Somma delle uscite
        totaleu = affi + condo + garag + cc + santa + tv
        'Imposta il totale alla valuta del sistema
        totaleUscite.Text = (totaleu.ToString("C"))
        'Imposta il colore della somma totale delle uscite in base alla disponibiià di credito
        If totaleu >= 0 Then
            totaleUscite.ForeColor = Color.Green 'Saldo in positivo
        ElseIf totaleu < 0 Then
            totaleUscite.ForeColor = Color.Red 'Saldo in negativo
        End If
        'Dopo il calcolo e l'esecuzione del colore da attribuire impongo che il bottone calcola sia disabilitato 
        calcolaUscite.Enabled = False
        'Dopo il calcolo elimino il testo del bottone per far apparire l'immagine 
        calcolaUscite.Text = testoVuoto
        CType(calcolaUscite, Button).Image = iconCancel
        'Attivo il tasto calcola disponibilità
        clacolaDisponibilità.Enabled = True
        'Imposto il testo del tasto disponibilità
        clacolaDisponibilità.Text = "Calcola"
        'Rimuvo immagine dal tasto disponibilità
        CType(clacolaDisponibilità, Button).Image = iconBlank
    End Sub
    Private Sub cancellaEntrate_Click(sender As Object, e As EventArgs) Handles cancellaEntrate.Click
        For Each valoreZero As TextBox In {stipendio, risparmi, altreEntrate}
            valoreZero.Text = "0,00"
        Next
        'Quando reimposto le caselle di testo il bottone di calcolo si riabilita
        calcolaEntrate.Enabled = True
        'Rinomino il bottone e carico un'immagine trasparente
        calcolaEntrate.Text = "Calcola"
        CType(calcolaEntrate, Button).Image = iconBlank
        'Quando reimposto le caselle di testo reimposto anche il label della somma allo stato iniziale
        With totaleEntrate
            .Text = "€"
            .ForeColor = Color.Black
        End With
        clacolaDisponibilità.Enabled = False
        clacolaDisponibilità.Text = testoVuoto
        CType(clacolaDisponibilità, Button).Image = iconCancel
        With disponibilità
            .Text = "€"
            .ForeColor = Color.Black
        End With
    End Sub
    Private Sub cancellaUscite_Click(sender As Object, e As EventArgs) Handles cancellaUscite.Click
        For Each valoreZero As TextBox In {affitto, condominio, garage, cartaCredito,
                                           finanziamento, tvOnDemand}
            valoreZero.Text = "0,00"
        Next
        'Quando reimposto le caselle di testo il bottone di calcolo si riabilita
        calcolaUscite.Enabled = True
        'Rinomino il bottone e carico un'immagine trasparente
        calcolaUscite.Text = "Calcola"
        CType(calcolaUscite, Button).Image = iconBlank
        'Quando reimposto le caselle di testo reimposto anche il label della somma allo stato iniziale
        With totaleUscite
            .Text = "€"
            .ForeColor = Color.Black
        End With
        clacolaDisponibilità.Enabled = False
        clacolaDisponibilità.Text = testoVuoto
        CType(clacolaDisponibilità, Button).Image = iconCancel
        With disponibilità
            .Text = "€"
            .ForeColor = Color.Black
        End With
        lblMessaggioSalva.Text = testoVuoto
        For Each icone As System.Windows.Forms.PictureBox In {immagineDisponibilità, iconSalvaMessaggio}
            icone.Image = iconBlank
        Next
    End Sub
    Private Sub InformazioniDiGestionalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformazioniDiGestionalToolStripMenuItem.Click
        'Visualizza il form di informazioni dell'applicazione
        infoGestionale.Show()
    End Sub
    Private Sub ChiudiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChiudiToolStripMenuItem.Click
        'Comando che chiudi l'applicazione dal menù
        Dim chiudi As MsgBoxResult
        chiudi = MsgBox("Sei sicuro di voler uscire da Gestional€??", MsgBoxStyle.OkCancel, "Chiusura programma")
        If chiudi = vbOK Then
            Close()
        End If
    End Sub
    Private Sub cancellaTutto_Click(sender As Object, e As EventArgs) Handles cancellaTutto.Click
        'Quando premiamo cancella tutto i  valori della text box ritornano a zero
        For Each valoreZero As TextBox In {affitto, condominio, garage, cartaCredito,
                                           finanziamento, tvOnDemand, stipendio, risparmi, altreEntrate}
            valoreZero.Text = "0,00"
        Next
        'Quando reimposto le caselle di testo il bottone di calcolo si riabilita
        calcolaUscite.Enabled = True
        'Rinomino il bottone e carico un'immagine trasparente
        calcolaUscite.Text = "Calcola"
        CType(calcolaUscite, Button).Image = iconBlank
        With totaleUscite
            .Text = "€"
            .ForeColor = Color.Black
        End With
        'Quando reimposto le caselle di testo il bottone di calcolo si riabilita
        calcolaEntrate.Enabled = True
        'Rinomino il bottone e carico un'immagine trasparente
        calcolaEntrate.Text = "Calcola"
        CType(calcolaEntrate, Button).Image = iconBlank
        'Quando reimposto le caselle di testo reimposto anche il label della somma allo stato iniziale
        With totaleEntrate
            .Text = "€"
            .ForeColor = Color.Black
        End With
        Dim stringaVuota As String = String.Empty
        clacolaDisponibilità.Enabled = False
        clacolaDisponibilità.Text = stringaVuota
        CType(clacolaDisponibilità, Button).Image = iconCancel
        With disponibilità
            .Text = "€"
            .ForeColor = Color.Black
        End With
        immagineDisponibilità.Image = iconBlank
        SalvaDatiAttualiNelDBToolStripMenuItem.Enabled = False
        lblMessaggioSalva.Text = String.Empty
        iconSalvaMessaggio.Image = iconBlank
    End Sub
    Private Sub CreaDatabseMensileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreaDatabseMensileToolStripMenuItem.Click
        Dim connessione As ADOX.Catalog = New ADOX.Catalog
        connessione.Create("")
    End Sub
    Private Sub txtInserisciMese_Click(sender As Object, e As EventArgs)
        Dim vuoto As String = String.Empty
        txtInserisciMese.Focus()
    End Sub
    Private Sub SalvaDatiAttualiNelDBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvaDatiAttualiNelDBToolStripMenuItem.Click
        'Variabili per il salvataggio dei dati
        Dim connessione As System.Data.OleDb.OleDbConnection
        Dim cmd As System.Data.OleDb.OleDbCommand
        Dim sqlCmd As String
        connessione = New Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alessio\Documents\Visual Studio 2012\gestionale\gestionale\gestionale.accdb;Persist Security Info=True")
        'Apro la connessione
        connessione.Open()
        'Comando SQL per l'inserimento dei dati
        sqlCmd = "INSERT INTO gestionale VALUES ( '2' , '" & ToolStripTextBox1.Text & "' , '" & stipendio.Text & "' , '" & risparmi.Text & "' , '" & altreEntrate.Text & "' , '" & affitto.Text & "' , '" & condominio.Text & "' , '" & garage.Text & "' , '" & cartaCredito.Text & "' , '" & finanziamento.Text & "' , '" & tvOnDemand.Text & "');"
        cmd = New Data.OleDb.OleDbCommand(sqlCmd, connessione)
        cmd.ExecuteNonQuery()
        'Chiudo la connessione dopo il salvataggio dei dati
        connessione.Close()
    End Sub
End Class
