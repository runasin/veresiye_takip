namespace veresiye_takip_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblBorc = new ToolStripStatusLabel();
            splitContainer1 = new SplitContainer();
            listKisiler = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            toolStrip1 = new ToolStrip();
            btnKisiEkle = new ToolStripButton();
            btnKisiDuzenle = new ToolStripButton();
            btnKisiSil = new ToolStripButton();
            txtAra = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            listVeriler = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            toolStrip2 = new ToolStrip();
            btnVeriEkle = new ToolStripSplitButton();
            btnBorcEkle = new ToolStripMenuItem();
            btnOdemeYap = new ToolStripMenuItem();
            btnVeriDuzenle = new ToolStripButton();
            btnVeriSil = new ToolStripButton();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblBorc });
            statusStrip1.Location = new Point(0, 480);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(867, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(775, 17);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblBorc
            // 
            lblBorc.Name = "lblBorc";
            lblBorc.Size = new Size(79, 17);
            lblBorc.Text = "Toplam Borç: ";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listKisiler);
            splitContainer1.Panel1.Controls.Add(toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listVeriler);
            splitContainer1.Panel2.Controls.Add(toolStrip2);
            splitContainer1.Size = new Size(867, 480);
            splitContainer1.SplitterDistance = 425;
            splitContainer1.TabIndex = 1;
            // 
            // listKisiler
            // 
            listKisiler.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listKisiler.Dock = DockStyle.Fill;
            listKisiler.FullRowSelect = true;
            listKisiler.GridLines = true;
            listKisiler.Location = new Point(0, 25);
            listKisiler.Margin = new Padding(3, 2, 3, 2);
            listKisiler.Name = "listKisiler";
            listKisiler.Size = new Size(425, 455);
            listKisiler.TabIndex = 1;
            listKisiler.UseCompatibleStateImageBehavior = false;
            listKisiler.View = View.Details;
            listKisiler.SelectedIndexChanged += listKisiler_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adı";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyadı";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mail";
            columnHeader5.Width = 150;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnKisiEkle, btnKisiDuzenle, btnKisiSil, txtAra, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(425, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnKisiEkle
            // 
            btnKisiEkle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnKisiEkle.ImageTransparentColor = Color.Magenta;
            btnKisiEkle.Name = "btnKisiEkle";
            btnKisiEkle.Size = new Size(53, 22);
            btnKisiEkle.Text = "Kişi Ekle";
            btnKisiEkle.Click += btnKisiEkle_Click;
            // 
            // btnKisiDuzenle
            // 
            btnKisiDuzenle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnKisiDuzenle.ImageTransparentColor = Color.Magenta;
            btnKisiDuzenle.Name = "btnKisiDuzenle";
            btnKisiDuzenle.Size = new Size(74, 22);
            btnKisiDuzenle.Text = "Kişi Düzenle";
            btnKisiDuzenle.Click += btnKisiDuzenle_Click;
            // 
            // btnKisiSil
            // 
            btnKisiSil.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnKisiSil.ImageTransparentColor = Color.Magenta;
            btnKisiSil.Name = "btnKisiSil";
            btnKisiSil.Size = new Size(44, 22);
            btnKisiSil.Text = "Kişi Sil";
            btnKisiSil.Click += btnKisiSil_Click;
            // 
            // txtAra
            // 
            txtAra.AccessibleDescription = "";
            txtAra.Alignment = ToolStripItemAlignment.Right;
            txtAra.BackColor = SystemColors.Info;
            txtAra.BorderStyle = BorderStyle.FixedSingle;
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(100, 25);
            txtAra.Tag = "";
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(28, 22);
            toolStripLabel1.Text = "Ara:";
            // 
            // listVeriler
            // 
            listVeriler.BorderStyle = BorderStyle.FixedSingle;
            listVeriler.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10 });
            listVeriler.Dock = DockStyle.Fill;
            listVeriler.FullRowSelect = true;
            listVeriler.GridLines = true;
            listVeriler.Location = new Point(0, 25);
            listVeriler.Margin = new Padding(3, 2, 3, 2);
            listVeriler.Name = "listVeriler";
            listVeriler.Size = new Size(438, 455);
            listVeriler.TabIndex = 1;
            listVeriler.UseCompatibleStateImageBehavior = false;
            listVeriler.View = View.Details;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "kID";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "gID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Miktar";
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Tarih";
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Açıklama";
            columnHeader10.Width = 150;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnVeriEkle, btnVeriDuzenle, btnVeriSil });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(438, 25);
            toolStrip2.TabIndex = 0;
            toolStrip2.Text = "toolStrip2";
            // 
            // btnVeriEkle
            // 
            btnVeriEkle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVeriEkle.DropDownItems.AddRange(new ToolStripItem[] { btnBorcEkle, btnOdemeYap });
            btnVeriEkle.ImageTransparentColor = Color.Magenta;
            btnVeriEkle.Name = "btnVeriEkle";
            btnVeriEkle.Size = new Size(66, 22);
            btnVeriEkle.Text = "Veri Ekle";
            // 
            // btnBorcEkle
            // 
            btnBorcEkle.Name = "btnBorcEkle";
            btnBorcEkle.Size = new Size(135, 22);
            btnBorcEkle.Text = "Borç Ekle";
            btnBorcEkle.Click += btnBorcEkle_Click;
            // 
            // btnOdemeYap
            // 
            btnOdemeYap.Name = "btnOdemeYap";
            btnOdemeYap.Size = new Size(135, 22);
            btnOdemeYap.Text = "Ödeme Yap";
            btnOdemeYap.Click += btnOdemeYap_Click;
            // 
            // btnVeriDuzenle
            // 
            btnVeriDuzenle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVeriDuzenle.ImageTransparentColor = Color.Magenta;
            btnVeriDuzenle.Name = "btnVeriDuzenle";
            btnVeriDuzenle.Size = new Size(75, 22);
            btnVeriDuzenle.Text = "Veri Düzenle";
            btnVeriDuzenle.Click += btnVeriDuzenle_Click;
            // 
            // btnVeriSil
            // 
            btnVeriSil.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnVeriSil.ImageTransparentColor = Color.Magenta;
            btnVeriSil.Name = "btnVeriSil";
            btnVeriSil.Size = new Size(45, 22);
            btnVeriSil.Text = "Veri Sil";
            btnVeriSil.Click += btnVeriSil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 502);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnKisiEkle;
        private ToolStripButton btnKisiDuzenle;
        private ToolStripButton btnKisiSil;
        private ToolStrip toolStrip2;
        private ToolStripButton btnVeriDuzenle;
        private ToolStripButton btnVeriSil;
        private ListView listKisiler;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ListView listVeriler;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ToolStripSplitButton btnVeriEkle;
        private ToolStripMenuItem btnBorcEkle;
        private ToolStripMenuItem btnOdemeYap;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblBorc;
        private ToolStripTextBox txtAra;
        private ToolStripLabel toolStripLabel1;
    }
}
