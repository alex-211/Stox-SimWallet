using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System.Globalization;

namespace Stox
{
    public partial class login : Form
    {
        Form1 form1 = new Form1();
        public login()
        {
            InitializeComponent();
            dtpInputData.MaxDate = DateTime.Now;
            dtpInputData.MinDate = new DateTime(1970, 1, 1);

            for (int i = 0; i < form1.nv; i++)
            {
                LSTcomprati.Items.Add(form1.ticker[i]);
            }
        }
        List<nasdaq_splitter> nasdaq_list = new List<nasdaq_splitter>();

        private void btAggiungi_Click(object sender, EventArgs e)
        {   
            if (float.TryParse(TXTprezzoAcquisto.Text, out form1.prezzoAcquisto[form1.nv])==false)
            {
                MessageBox.Show("Sono ammessi solo numeri nel dato 'Prezzo acquisto'");
                return;
            }
            else if (txtInputTitolo.Text == "" || txtInputTitolo.TextLength > 5)
            {
                MessageBox.Show("Il titolo ticker non può essere vuoto ed il ticker può avere massimo 5 caratteri");
                return; 
            }

            var client = new WebClient();
            try
            {
                DateTime today = DateTime.Now;
                DateTime yesterday = DateTime.Now.AddDays(-1);
                int period1 = (int)yesterday.Date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                int period2 = (int)today.Date.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                string response = client.DownloadString("https://query1.finance.yahoo.com/v7/finance/download/" + txtInputTitolo.Text + "?period1=" + period1 + "&period2=" + period2 + "&interval=1d&events=history&includeAdjustedClose=true");
            }
            catch
            {
                MessageBox.Show("Suca");
                return; // Il sito non esiste
            }


            DateTime dataMin = new DateTime(1970 - 01 - 01);
            if (dtpInputData.Value < dataMin)
            {
                MessageBox.Show("Il titolo non può esser stato comprato prima del 01/01/1970"); 
                return;
            }
            form1.ticker[form1.nv] = txtInputTitolo.Text;
            form1.dataAcquisto[form1.nv] = dtpInputData.Value;
            form1.nv++;
        }

        private void btContinua_Click(object sender, EventArgs e)
        {
            this.Hide(); // si fa hide nel caso l'utente voglia aggiungere titoli mentre il programma è in uso
            form1.ShowDialog();
        }

        public class nasdaq_splitter
        {
            public string Symbol { get; set; }
        }
    }
}
