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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DebugPage = new System.Windows.Forms.TabPage();
            this.LSTdebug = new System.Windows.Forms.ListBox();
            this.listView = new System.Windows.Forms.ListView();
            this.ColLWData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWOpen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWAdjClose = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWHigh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWLow = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLWVolume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.DebugPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.DebugPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DebugPage
            // 
            this.DebugPage.Controls.Add(this.LSTdebug);
            this.DebugPage.Location = new System.Drawing.Point(4, 25);
            this.DebugPage.Margin = new System.Windows.Forms.Padding(4);
            this.DebugPage.Name = "DebugPage";
            this.DebugPage.Size = new System.Drawing.Size(1059, 525);
            this.DebugPage.TabIndex = 2;
            this.DebugPage.Text = "Debug";
            this.DebugPage.UseVisualStyleBackColor = true;
            // 
            // LSTdebug
            // 
            this.LSTdebug.FormattingEnabled = true;
            this.LSTdebug.ItemHeight = 16;
            this.LSTdebug.Location = new System.Drawing.Point(12, 5);
            this.LSTdebug.Margin = new System.Windows.Forms.Padding(4);
            this.LSTdebug.Name = "LSTdebug";
            this.LSTdebug.Size = new System.Drawing.Size(1032, 468);
            this.LSTdebug.TabIndex = 0;
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
            this.listView.Location = new System.Drawing.Point(8, 7);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1044, 510);
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
            // ColLWVolume
            // 
            this.ColLWVolume.Text = "Volume";
            this.ColLWVolume.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Portafoglio Stox";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.DebugPage.ResumeLayout(false);
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
    }
}

