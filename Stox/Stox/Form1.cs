 // Alessandro Agus & Alessandro Porpiglia (3AINF) 2023
// movtep-3wovsy-fYmdos

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CsvHelper;

using System.Net;
using System.IO;
using System.Globalization;

using CsvHelper.Configuration.Attributes; // Questo serve a dare dei nomi custom agli header


namespace Stox
{
    public partial class Form1 : Form
    {
        // AGUS NON TOGLIERE PUBLIC CHE SE NO SI ROMPE IL FORM2!! 
        public const int MAXV = 100;
        public string[] ticker = new string[MAXV];
        public DateTime[] dataAcquisto = new DateTime[MAXV];
        public float[] prezzoAcquisto = new float[MAXV];
        public int nv = 0;

        public const int nColTicker = 7;
        public string[] colTicker = { "Open", "High", "Low", "Close", "Adj Close", "Volume", "Differenza" };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Impedisci all'utente di aggiungere e cancellare righe
            dgvTicker.AllowUserToAddRows = false;
            dgvTicker.AllowUserToDeleteRows = false;
            // Impedisci all'utente di modificare le celle
            dgvTicker.EditMode = DataGridViewEditMode.EditProgrammatically;
            // Ridimensiona automaticamente le celle della griglia in base al loro contenuto
            dgvTicker.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            // Imposta la larghezza dei titoli delle righe a 130 pixel
            dgvTicker.RowHeadersWidth = 130;
            dgvTicker.ColumnCount = nColTicker;
            for(int i = 0; i < nColTicker; i++)
            {
                dgvTicker.Columns[i].HeaderText = colTicker[i];
            }
            for (int i = 0; i < nv;  i++) 
            {
                CBrequest.Items.Add(ticker[i]);
            }
        }

        // creates a class that splits the csv data 
        public class splitter1
        {
            public string Date { get; set; }
            public string Open { get; set; }
            public string High { get; set; }
            public string Low { get; set; }
            public string Close { get; set; }

            [Name("Adj Close")]
            public string Adj_close { get; set; }
            public string Volume { get; set; }
        }

        private void BTrequest_Click(object sender, EventArgs e)
        {
            float differnza;
            int pos = -1;
            for(int i = 0; i < nv; i++)
            {
                if (ticker[i] == CBrequest.Text)
                {
                    pos = i;
                    break;
                }
            }
            if (pos == -1)
            {
                MessageBox.Show("ticker non inserito");
                return;
            }
            // Ottieni data di oggi e convertila in unix timestamp per usarla nella query di Yahoo -- Spiegazione dettagliata su commit di GitHub
            DateTime today = DateTime.Now;
            DateTime yesterday = DateTime.Now.AddDays(-1);
            int period1 = (int)yesterday.Date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            int period2 = (int)today.Date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            
//          listView.Clear(); -- sembra non funzionare, fa il clear delle colonne (non solo dei dati) e quindi non permette ai nuovi dati di essere inseriti
//          ColLWLow.cle -- per le colonne non c'è un metodo .Clear

            // Create a web client to request the CSV data
            var client = new WebClient();
            var DataStream = client.OpenRead("https://query1.finance.yahoo.com/v7/finance/download/" + CBrequest.Text + "?period1=" + period1 + "&period2="+ period2 +"&interval=1d&events=history&includeAdjustedClose=true");
            var DataStream_Acquisto = client.OpenRead("https://query1.finance.yahoo.com/v7/finance/download/" + CBrequest.Text + "?period1=" + period1 + "&period2=" + period2 + "&interval=1d&events=history&includeAdjustedClose=true");


            // Create a reader for CSVhelper
            var reader = new CsvReader(new StreamReader(DataStream), CultureInfo.InvariantCulture);

            using (reader)
            {
                // stores the splitted data in the tik variable
                var tik = reader.GetRecords<splitter1>().ToList();

                foreach (var record in tik)
                {
                    //visualizzazione debug 'listbox'
                    LSTdebug.Items.Add(record.Date + " " + record.Open + " " + record.High + " " + record.Low + " " + record.Close + " " + record.Adj_close + " " + record.Volume);

                    //Creazione tabella 'listview' *migliorabile -- metodo archiviato, in pausa. Proviamo un DataGridView (30-3-23)
                    ListViewItem item = new ListViewItem(record.Open);
                    item.SubItems.Add(record.High);
                    item.SubItems.Add(record.Low);
                    item.SubItems.Add(record.Close);
                    item.SubItems.Add(record.Adj_close);
                    item.SubItems.Add(record.Volume);
                    //item.SubItems.Add(prezzoAcquisto[pos] - Convert.ToSingle(record.Close)); //errore da fixare
                    listView.Items.Add(item);
                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BTclosing_Click(object sender, EventArgs e)
        {
            // save program data on form closing
            // tira svariate eccezzioni e io tiro svariate bestemmie

            string folder_path = "";
            string nv_cool = Convert.ToString(nv);
            FolderBrowserDialog dialog_cartella = new FolderBrowserDialog();
            if (dialog_cartella.ShowDialog() == DialogResult.OK)
            {
                folder_path = dialog_cartella.SelectedPath;
            }

            if (folder_path != "")
            {
                using (var streamWriterticker = new StreamWriter(folder_path + "\\data-ticker.csv"))
                using (var csvWriter = new CsvWriter(streamWriterticker, CultureInfo.InvariantCulture))
                {
                    if (ticker != null)
                    {
                        for (int i = 0; i < nv; i++)
                        {
                            csvWriter.WriteRecords(ticker[i]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Non hai aggiunto nessun ticker ai tuoi salvati");
                    }
                }

                using (var streamWriterdate = new StreamWriter(folder_path + "\\data-dateAcquisto.csv"))
                using (var csvWriter = new CsvWriter(streamWriterdate, CultureInfo.InvariantCulture))
                {
                    if (dataAcquisto != null)
                    {
                        for (int i = 0; i < nv; i++)
                        {
                            csvWriter.WriteRecords(Convert.ToString(dataAcquisto[i]));
                            // mo come cazzo traduco da stringa a data per leggere il dato, non si sà, però sarà un problema x un altro giorno

                        }
                    }
                }

                using (var streamwriterprezzo = new StreamWriter(folder_path + "\\data-prezzoAcquisto.csv"))
                using (var csvWriter = new CsvWriter(streamwriterprezzo, CultureInfo.InvariantCulture))
                {
                    if (prezzoAcquisto != null)
                    {
                        for (int i = 0; i < nv; i++)
                        {
                            csvWriter.WriteRecords(Convert.ToString(prezzoAcquisto[i]));
                        }
                    }
                }

                using (var streamwriternv = new StreamWriter(folder_path + "\\data-prezzoAcquisto.csv"))
                using (var csvWriter = new CsvWriter(streamwriternv, CultureInfo.InvariantCulture))
                {
                    if (nv_cool != null)
                    {
                        int i = 0;
                        csvWriter.WriteRecord(nv_cool[i]);
                        /*Spiegazione di questo abominio sgorbio della natura: perchè cazzo ci sta un indicatore di index su una variabile?
                         Perchè in teoria il metodo WriteRecord sarebbe fatto per i dati singoli, AKA le variabili, però sto stronzo pensa
                        comunque di essere il metodo WriteRecords (plurale) quindi senza indicatore di index mi tira una eccezzine di livelli
                        clamorosi e mi dice con quel suo tono da paraculo demmerda: DiD yOu aCcIdenTaLlY cAALl GetRecord oR WriteRecord which 
                        acts on a single record instead of calling GetRecords or WriteRecords which acts on a list of records?
                        NO STRONZETTO L'HO FATTO APPOSTA A CHIAMARE WriteRecord SEI TU STUPIDO CHE PENSI CHE UNA VARIABILE SIA UN ARRAY*/
                    }
                }

                Application.Exit(); // necessario?
            }
            else
            {
                MessageBox.Show("Operazione annullata, i dati non sono stati salvati");
            }
        }
    }
}
