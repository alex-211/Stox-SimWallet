// Alessandro Agus & Alessandro Porpiglia (3AINF) 2023
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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // creates a class that splits the csv data 
        public class splitter
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
            // Ottieni data di oggi e convertila in unix timestamp per usarla nella query di Yahoo -- Spiegazione dettagliata su commit di GitHub
            DateTime today = DateTime.Now;
            DateTime yesterday = DateTime.Now.AddDays(-1);
            int period1 = (int)today.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            int period2 = (int)yesterday.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            
//          listView.Clear(); -- sembra non funzionare, fa il clear delle colonne (non solo dei dati) e quindi non permette ai nuovi dati di essere inseriti
//          ColLWLow.cle -- per le colonne non c'è un metodo .Clear

            // Create a web client to request the CSV data
            var client = new WebClient();
            var DataStream = client.OpenRead("https://query1.finance.yahoo.com/v7/finance/download/"+CBrequest.Text+"?period1=" + period1 + "&period2="+ period2 +"&interval=1d&events=history&includeAdjustedClose=true");

            // Create a reader for CSVhelper
            var reader = new CsvReader(new StreamReader(DataStream), CultureInfo.InvariantCulture);

            using (reader)
            {
                // stores the splitted data in the appl variable
                var appl = reader.GetRecords<splitter>().ToList();

                foreach (var record in appl)
                {
                    //visualizzazione debug 'listbox'
                    LSTdebug.Items.Add(record.Date + " " + record.Open + " " + record.High + " " + record.Low + " " + record.Close + " " + record.Adj_close + " " + record.Volume);

                    //Creazione tabella 'listview' *migliorabile -- metodo archiviato, in pausa. Proviamo un DataGridView (30-3-23)
                    ListViewItem item = new ListViewItem(record.Date);
                    item.SubItems.Add(record.Open);
                    item.SubItems.Add(record.High);
                    item.SubItems.Add(record.Low);
                    item.SubItems.Add(record.Close);
                    item.SubItems.Add(record.Adj_close);
                    item.SubItems.Add(record.Volume);
                    listView.Items.Add(item);
                }

            }
        }
    }
}
