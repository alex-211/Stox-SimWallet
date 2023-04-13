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
            this.SuspendLayout();
            // 
            // dtpInputData
            // 
            this.dtpInputData.Location = new System.Drawing.Point(13, 41);
            this.dtpInputData.Name = "dtpInputData";
            this.dtpInputData.Size = new System.Drawing.Size(200, 20);
            this.dtpInputData.TabIndex = 1;
            // 
            // btAggiungi
            // 
            this.btAggiungi.Location = new System.Drawing.Point(13, 68);
            this.btAggiungi.Name = "btAggiungi";
            this.btAggiungi.Size = new System.Drawing.Size(75, 23);
            this.btAggiungi.TabIndex = 2;
            this.btAggiungi.Text = "Aggiungi";
            this.btAggiungi.UseVisualStyleBackColor = true;
            this.btAggiungi.Click += new System.EventHandler(this.btAggiungi_Click);
            // 
            // btContinua
            // 
            this.btContinua.Location = new System.Drawing.Point(13, 151);
            this.btContinua.Name = "btContinua";
            this.btContinua.Size = new System.Drawing.Size(75, 23);
            this.btContinua.TabIndex = 3;
            this.btContinua.Text = "continua";
            this.btContinua.UseVisualStyleBackColor = true;
            this.btContinua.Click += new System.EventHandler(this.btContinua_Click);
            // 
            // txtInputTitolo
            // 
            this.txtInputTitolo.Location = new System.Drawing.Point(13, 13);
            this.txtInputTitolo.Name = "txtInputTitolo";
            this.txtInputTitolo.Size = new System.Drawing.Size(100, 20);
            this.txtInputTitolo.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInputTitolo);
            this.Controls.Add(this.btContinua);
            this.Controls.Add(this.btAggiungi);
            this.Controls.Add(this.dtpInputData);
            this.Name = "login";
            this.Text = "Ciao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpInputData;
        private System.Windows.Forms.Button btAggiungi;
        private System.Windows.Forms.Button btContinua;
        private System.Windows.Forms.TextBox txtInputTitolo;
    }
}