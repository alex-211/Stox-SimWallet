﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btAggiungi_Click(object sender, EventArgs e)
        {
            // per ora si NON si controlla la validità del dato ticker, MA verrà agginto
            
            if (float.TryParse(TXTprezzoAcquisto.Text, out form1.prezzoAcquisto[form1.nv])==false)
            {
                MessageBox.Show("Sono ammessi solo numeri nel dato 'Prezzo acquisto'");
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
    }
}
