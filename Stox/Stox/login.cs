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

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
// Chrome fiddler, dato che il bottone sul sito di Nasdaq non ha un link di download diretto, ma usa una richiesta AJAX o JS quindi per scaricare il csv per fare il confronto, uso questa libreria
using System.IO;
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
            for (int i = 0; i < nasdaq_list.Count; i++)
            {
                
                if (txtInputTitolo.Text == nasdaq_list[i].Symbol)
                {
                    break;
                }
                else if (i == nasdaq_list.Count - 1)
                {
                    MessageBox.Show("Il ticker non è stato trovato nel database di NASDAQ");
                    return;
                }
            }
            DateTime dataMin = new DateTime(1970 - 01 - 01);
            if (dtpInputData.Value < dataMin)
            {
                MessageBox.Show("Il titolo non può esser stato comprato prima del 01/01/1970"); 
                return;
            }
            form1.ticker[form1.nv] = Convert.ToString(txtInputTitolo.Text);
            form1.dataAcquisto[form1.nv] = dtpInputData.Value;
            form1.nv++;
        }

        private void btContinua_Click(object sender, EventArgs e)
        {
            this.Hide(); // si fa hide nel caso l'utente voglia aggiungere titoli mentre il programma è in uso
            form1.ShowDialog();
        }

        private async Task login_LoadAsync(object sender, EventArgs e)
        {
            string confronto_downloadPath = "C:\\Stox-Wallet";
            string chrome_path = "C:\\Stox-Wallet";
            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", "C:\\Stox-wallet");
            options.AddArgument("--headless");
            using (IWebDriver driver = new ChromeDriver(chrome_path, options)) 
            {

                driver.Navigate().GoToUrl("https://www.nasdaq.com/market-activity/stocks/screener");
                await Task.Delay(1000);
                IWebElement download_button = driver.FindElement(By.CssSelector(".nasdaq-screener__form-button--download.ns-download-1"));
                download_button.Click();
                driver.Quit();
            }

            using (StreamReader reader = new StreamReader(confronto_downloadPath))
            using (CsvReader csvReader = new CsvReader((IParser)reader)) // necessario cast esplicito per qualche ragione
            {
                
                // dopo aver provato altri metodi, mi arrendo per usare quello di ChatGPT
                while (csvReader.Read()) 
                {
                    nasdaq_splitter nasdaq_reader = csvReader.GetRecord<nasdaq_splitter>();
                    nasdaq_list.Add(nasdaq_reader);
                }
            }
            
        }
        public class nasdaq_splitter
        {
            public string Symbol { get; set; }
        }
    }
}
