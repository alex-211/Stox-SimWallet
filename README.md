# Analisi funzionale per un'applicazione per la gestione del portafoglio titoli di un'investirore individuale
Versione 1 - Massimo Antonellini, 2021

## Scopo dell'applicazione
Gestire un portafoglio di titoli, segnalando all’utente un “allarme” quando siamo vicini al “punto” in cui si vuole comprare o vendere il titolo. I due punti per comprare o vendere sono impostati dall’utente in base a qualche criterio (ne parleremo in classe); l’applicazione non include quindi tecniche intelligenza artificiale o algoritmi di trading.

L'utilità dell'applicazione consiste in: 
1. evitare di passare le giornate a sorvegliare i titoli
2. evitare di usare meccanismi di vendita condizionale (vendo automaticamente se il titolo sale/scende sopra X dollari), perchè spesso ci sono degli sbalzi temporanei di prezzo che causano ordini indesiderati e quindi piccole perdito o mancati guadagni che si potrebbero evitare. In questi casi, l'utente viene semplicemente "allertato" e può valutare cosa è meglio fare.

## Premesse
### Siti con quotazioni e grafici
Ci sono vari siti in giro per il mondo che permettono di acquisire le quotazioni dei titoli e grafici, molti dei qualicon un certo ritardo (15 minuti, specie in Europa), mentre forniscono dati (più o meno) in tempo reale, magari non prendendoli dalla borsa “ufficiale” (es. NASDAQ) ma da una “borsa alternativa” (es. BATS)

Per realizzare l’applicazione senza troppo lavoro servirebbe:
1.un sito da cui scaricare le quotazioni, il più possibile in tempo reale;
2.un sito da cui scaricare i grafici intraday (dell’andamento del giorno) e, possibilmente quelli della settimana, mese, trimestre, anno.

_Yahoo_
<br>
Il sito più popolare è yahoo che permette di scaricare quotazioni in formato CSV (formato di cui parleremo a breve a lezione), ad esempio l’url: https://query1.finance.yahoo.com/v7/finance/download/AAPL?period1=1581498323&period2=1613120723&interval=1d&events=history&includeAdjustedClose=true

fornisce le quotazioni di fine giornata tra due date per il titolo AAPL (Apple). Alcune spiegazioni [qui](https://mapleprimes.com/posts/208409-Downloading-Historical-Stock-Quotes)
Da qualche parte sulla rete ci devono essere informazioni su come ottenere dati in tempo reale e altro. E’ anche possibile scaricare informazioni più dettagliate in formato JSON. [Dettagli qui](https://www.stock-data-solutions.com/kb/how-to-load-historical-prices-from-yahoo-finance-to-csv.htm)

[_Alternative a Yahoo_](https://www.quantshare.com/sa-620-10-new-ways-to-download-historical-stock-quotes-for-free)

_Grafici_
<br>
Yahoo genera anche grafici (delle giornata e storici). Ad esempio, la pagina: 
https://finance.yahoo.com/quote/AAPL/chart
<br>
che tuttavia, oltre al grafico, visualizza molte altre informazioni. Occorre studiare la pagina per capire se si può estrarre solo il grafico

### DataGridView - SUMA SI
I dati dei titoli possono essere presentati con il controllo DataGridView, che permette di visualizzare i dati in forma tabellare. Ho una piccola dispensa sulle matrici che ne parla.Alcuni dati potrebbero essere presentati in modo “più grafico” [da discutere in un secondo tempo].

### Implementazione di una versione per Android
Per varie ragioni, credo che la prima versione del programma dovrebbe essere per Windows, per poi realizzarneuna seconda per Android.
*Nota:* in Visual Studio con C# si possono scrivere programmi eseguibili su entrambi i sistemi, ma gli oggetti dell’interfaccia utente sono differenti. Tempo fa avevo trovato una libreria per Android che utilizzava gli stessi form di Windows, ma non ho approfondito la questione. Ho anche letto che forse Microsoft vuole unificare gli oggetti dei due ambienti, ma anche qui non ho approfondito la faccenda.Possibile soluzione (parziale):  mettere la logica del programma in una serie di function (tra poco impareremo a metterle in una classe), in modo da separare interfaccia utente e logica del programma. Nel passaggio da Windows a Android si butta via l’interfaccia utente e si conserva la logica. Meglio che buttare via tutto...
## Funzioni del programma
Il programma deve gestire 2 insiemi di dati:
1. Il *portafoglio*, costituito da titoli che si possiedono;
2. La *la lista dei titoli 'interessanti' o watch list,* costituito dai titoli che si desidera acquistare

Le funzioni di base del programma sono descritte nelle sezioni seguenti. 
### 1. Funzioni del programma 
Esegue automaticamente il caricamento dei dati (titoli, ticker) da un file e la visualizzazione del portafoglio.
### 2. Visualizzazione dei dati [PROVVISORIO]
La visualizzazione dei due insiemi di titoli viene eseguita tramite due DataGridView, come mostrato. I dati senza sfondo giallo sono inseriti dall’utente, mentre quelli in giallo sono calcolati dal programma.
### Portafoglio
![image](https://user-images.githubusercontent.com/114176944/226206818-fb4a0c28-f9c4-436b-a5d8-c927c6312e71.png)

Dove: 
- Ticker: è il codice del titolo
- Nome: è il suo nome
- Qta: è la quantità posseduta
- Val: è la valuta (USD, EUR, ecc.)
- P.carico: è il prezzo di acquisto del titolo (detto anche pmc)
- P.mercato: è il prezzo di mercato del titolo (prezzo corrente)
- %Oggi: è l'incremento (deceremento se negativo) percentuale rispetto al prezzo del giorno prec.
- Controval.: è il controvalore dei titoli in portafoglio = Qta x P.mercato
- %Plus: è il plusvalenza o minusvalenza = precent. di incr. o decr. di P.mercato rispetto P.carico
- Min e Max: sono due valori in 'vicinanza' dei quali l'utente vuole essere 'allertato'
- All. è la spunta per indicare che l'allerta è attivo (X) on non attivo (nulla)

## Watchlist titoli
L'elenco dei titoi interessanti è simile al portafoglio, ma <ins>non ci sono P.carico, Controval e %Plus.</ins>
![image](https://user-images.githubusercontent.com/114176944/226207308-6035b0b0-3a1e-414d-98d7-67064ae2fc59.png)

### Nota:
Min, Max. e P.mercato potrebbero essere visualizzati come una barra colorata in cui P.mercato è rappresentato (ad es.) come un punto colorato più o meno vicino ad uno degli estremi della barra, che corrispondono ai valori Min e Max.

### 3. Modifica dei titoli [PROVVISORIO]
Servono funzioni (e due form, uno per inserire e uno per modificare?) per:
- aggiungere titoli/ticker (che dovrebbero essere scelti da un elenco periodicamente aggiornato), inserendo anche gli altri dati;
- rimuovere titoli/ticker;
- modificare P.carico, Qta, Min e Max.

### 4. Aggiornamento degli allarmi [PROVISSORIO]
Le quotazioni verranno caricate dalla sorgente dei dati ad intervalli stabiliti dall’utente nelle impostazioni dell’applicazione (es. 1, 5, 10 minuti). Esempio di implementazione: definire una structure contenente le impostazioni e dichiarare una variabile globale.

### 5. Elenco degli allarmi [PROVISSORIO]
Dev’essere visualizzato quando c’è una variazione nello stato degli allarmi.I nuovi allarmi andrebbero evidenziati in qualche modo per distinguerli da quelli precedenti che continuano ad essere attivi (un colore?). Dettagli della visualizzazione da definire.

### 6. Grafici [PROVVISORIO]
Quando si verifica un allarme sarebbe molto utile visualizzare (con un button o un link) il grafico del giorno, in modo da capire cosa e come sta succedendo. Esempi di implementazione: (a) visualizzare l’immagine del grafico scaricata da un sito di finanza (b) scaricare i dati di giornata e generare il grafico sul pc o dispositivo Android.

### 7. Terminazione del programma 
Esegue automaticamente il salvataggio dei dati in un file. Il salvataggio potrebbe anche essere eseguito con un comando o, automaticamente, ad ogni modifica.

## Interfaccia utente
Probabilmente l’interfaccia più facile da usare per l’utente (e più semplice da convertire in un interfaccia Android) è quella “a schede” con un singolo form, in cui è possibile passare da una scheda all’altra. Un esempio di trova [qui](https://www.c-sharpcorner.com/article/working-with-tab-control-in-windows-forms-using-visual-studio-2017)
<br>
Probabilmente le schede dovrebbero essere 3 (Portafoglio, Watch list e Allarmi), mentre l’inserimento e la modifica dei dati dovrebbero essere eseguite tramite form pop-up oppure (per rimanere nello stile Android) tramite schede di inserimento e modifica che vengono visualizzate solo quando servono.

## Sviluppi futuri
Da definire in un secondo tempo, dopo aver “provato” per un po’ l’applicazione.
