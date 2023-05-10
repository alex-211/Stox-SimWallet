namespace Stox
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpInputData = new System.Windows.Forms.DateTimePicker();
            this.btAggiungi = new System.Windows.Forms.Button();
            this.btContinua = new System.Windows.Forms.Button();
            this.txtInputTitolo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXTprezzoAcquisto = new System.Windows.Forms.TextBox();
            this.LSTcomprati = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtpInputData
            // 
            this.dtpInputData.Location = new System.Drawing.Point(424, 71);
            this.dtpInputData.Name = "dtpInputData";
            this.dtpInputData.Size = new System.Drawing.Size(200, 20);
            this.dtpInputData.TabIndex = 1;
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(334, 166);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(293, 23);
            this.btAggiungi.TabIndex = 2;
            this.btAggiungi.Text = "Aggiungi";
            this.btAggiungi.UseVisualStyleBackColor = true;
            this.btAggiungi.Click += new System.EventHandler(this.btAggiungi_Click);
            // 
            // btContinua
            // 
            this.btContinua.Location = new System.Drawing.Point(16, 166);
            this.btContinua.Name = "btContinua";
            this.btContinua.Size = new System.Drawing.Size(133, 23);
            this.btContinua.TabIndex = 3;
            this.btContinua.Text = "Continua ai dati titoli";
            this.btContinua.UseVisualStyleBackColor = true;
            this.btContinua.Click += new System.EventHandler(this.btContinua_Click);
            // 
            // txtInputTitolo
            // 
            this.txtInputTitolo.Location = new System.Drawing.Point(424, 43);
            this.txtInputTitolo.Name = "txtInputTitolo";
            this.txtInputTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtInputTitolo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bentornato!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "I titoli già aggiunti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aggiungi un nuovo titolo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ticker: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data di acquisto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Prezzo d\'acquisto";
            // 
            // TXTprezzoAcquisto
            // 
            this.TXTprezzoAcquisto.Location = new System.Drawing.Point(424, 97);
            this.TXTprezzoAcquisto.Name = "TXTprezzoAcquisto";
            this.TXTprezzoAcquisto.Size = new System.Drawing.Size(200, 20);
            this.TXTprezzoAcquisto.TabIndex = 12;
            // 
            // LSTcomprati
            // 
            this.LSTcomprati.FormattingEnabled = true;
            this.LSTcomprati.Location = new System.Drawing.Point(16, 65);
            this.LSTcomprati.Name = "LSTcomprati";
            this.LSTcomprati.Size = new System.Drawing.Size(229, 95);
            this.LSTcomprati.TabIndex = 13;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LSTcomprati);
            this.Controls.Add(this.TXTprezzoAcquisto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputTitolo);
            this.Controls.Add(this.btContinua);
            this.Controls.Add(this.btAggiungi);
            this.Controls.Add(this.dtpInputData);
            this.Name = "login";
            this.Text = "Ciao!";
            //this.Load += new System.EventHandler(this.login_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpInputData;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.Button btContinua;
        private System.Windows.Forms.TextBox txtInputTitolo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXTprezzoAcquisto;
        private System.Windows.Forms.ListBox LSTcomprati;
    }
}