namespace Stox
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.ColLWData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWHigh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWLow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWAdjClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DebugPage = new System.Windows.Forms.TabPage();
            this.LSTdebug = new System.Windows.Forms.ListBox();
            this.BTrequest = new System.Windows.Forms.Button();
            this.CBrequest = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.DebugPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.DebugPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CBrequest);
            this.tabPage1.Controls.Add(this.BTrequest);
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColLWData,
            this.ColLWOpen,
            this.ColLWHigh,
            this.ColLWLow,
            this.ColLWClose,
            this.ColLWAdjClose,
            this.ColLWVolume});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(6, 6);
            this.listView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(784, 342);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // ColLWData
            // 
            this.ColLWData.Tag = "";
            this.ColLWData.Text = "Data";
            this.ColLWData.Width = 80;
            // 
            // ColLWOpen
            // 
            this.ColLWOpen.Text = "Open";
            this.ColLWOpen.Width = 80;
            // 
            // ColLWHigh
            // 
            this.ColLWHigh.Text = "High";
            this.ColLWHigh.Width = 80;
            // 
            // ColLWLow
            // 
            this.ColLWLow.Text = "Low";
            this.ColLWLow.Width = 80;
            // 
            // ColLWClose
            // 
            this.ColLWClose.Text = "Close";
            this.ColLWClose.Width = 80;
            // 
            // ColLWAdjClose
            // 
            this.ColLWAdjClose.Text = "Adj Close";
            this.ColLWAdjClose.Width = 80;
            // 
            // ColLWVolume
            // 
            this.ColLWVolume.Text = "Volume";
            this.ColLWVolume.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DebugPage
            // 
            this.DebugPage.Controls.Add(this.LSTdebug);
            this.DebugPage.Location = new System.Drawing.Point(4, 22);
            this.DebugPage.Name = "DebugPage";
            this.DebugPage.Size = new System.Drawing.Size(792, 424);
            this.DebugPage.TabIndex = 2;
            this.DebugPage.Text = "Debug";
            this.DebugPage.UseVisualStyleBackColor = true;
            // 
            // LSTdebug
            // 
            this.LSTdebug.FormattingEnabled = true;
            this.LSTdebug.Location = new System.Drawing.Point(9, 4);
            this.LSTdebug.Name = "LSTdebug";
            this.LSTdebug.Size = new System.Drawing.Size(775, 381);
            this.LSTdebug.TabIndex = 0;
            // 
            // BTrequest
            // 
            this.BTrequest.Location = new System.Drawing.Point(8, 371);
            this.BTrequest.Name = "BTrequest";
            this.BTrequest.Size = new System.Drawing.Size(75, 23);
            this.BTrequest.TabIndex = 1;
            this.BTrequest.Text = "Richiedi dati";
            this.BTrequest.UseVisualStyleBackColor = true;
            this.BTrequest.Click += new System.EventHandler(this.BTrequest_Click);
            // 
            // CBrequest
            // 
            this.CBrequest.FormattingEnabled = true;
            this.CBrequest.Items.AddRange(new object[] {
            "AAPL",
            "SMSN.IL"});
            this.CBrequest.Location = new System.Drawing.Point(103, 373);
            this.CBrequest.Name = "CBrequest";
            this.CBrequest.Size = new System.Drawing.Size(121, 21);
            this.CBrequest.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Portafoglio Stox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.DebugPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage DebugPage;
        private System.Windows.Forms.ListBox LSTdebug;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader ColLWData;
        private System.Windows.Forms.ColumnHeader ColLWOpen;
        private System.Windows.Forms.ColumnHeader ColLWHigh;
        private System.Windows.Forms.ColumnHeader ColLWLow;
        private System.Windows.Forms.ColumnHeader ColLWClose;
        private System.Windows.Forms.ColumnHeader ColLWAdjClose;
        private System.Windows.Forms.ColumnHeader ColLWVolume;
        private System.Windows.Forms.ComboBox CBrequest;
        private System.Windows.Forms.Button BTrequest;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

