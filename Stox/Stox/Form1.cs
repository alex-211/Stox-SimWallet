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

using CsvHelper.Configuration.Attributes; // Questo serve a dare dei nomi custom agli header (es. vedi righa 59) 


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
            // Create a web client to request the CSV data
            var client = new WebClient();
            var DataStream = client.OpenRead("https://query1.finance.yahoo.com/v7/finance/download/AAPL?period1=1581498323&period2=1613120723&interval=1d&events=history&includeAdjustedClose=true");

            // Create a reader for CSVhelper
            var reader = new CsvReader(new StreamReader(DataStream), CultureInfo.InvariantCulture);

            using (reader)
            {
                // stores the splitted data in the appl variable
                var appl = reader.GetRecords<splitter>().ToList();

                foreach (var record in appl)
                {
                    LSTdebug.Items.Add(record.Date + " " + record.Open + " " + record.High + " " + record.Low + " " + record.Close + " " + record.Adj_close + " " + record.Volume);
                }
            }
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
    }
}
