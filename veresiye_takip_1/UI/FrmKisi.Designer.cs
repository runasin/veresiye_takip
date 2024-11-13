namespace veresiye_takip_1
{
    partial class FrmKisi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbAdi = new TextBox();
            tbSoyadi = new TextBox();
            tbMail = new TextBox();
            mtTel = new MaskedTextBox();
            btnTamam = new Button();
            btnIptal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 20);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 54);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 88);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 125);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Mail:";
            // 
            // tbAdi
            // 
            tbAdi.Location = new Point(83, 17);
            tbAdi.Name = "tbAdi";
            tbAdi.Size = new Size(231, 27);
            tbAdi.TabIndex = 1;
            // 
            // tbSoyadi
            // 
            tbSoyadi.Location = new Point(83, 51);
            tbSoyadi.Name = "tbSoyadi";
            tbSoyadi.Size = new Size(231, 27);
            tbSoyadi.TabIndex = 2;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(83, 123);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(231, 27);
            tbMail.TabIndex = 4;
            // 
            // mtTel
            // 
            mtTel.Location = new Point(83, 87);
            mtTel.Mask = "(999) 000-0000";
            mtTel.Name = "mtTel";
            mtTel.Size = new Size(231, 27);
            mtTel.TabIndex = 3;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(106, 170);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(94, 29);
            btnTamam.TabIndex = 5;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(206, 170);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(94, 29);
            btnIptal.TabIndex = 6;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += Iptal_event;
            // 
            // FrmKisi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 231);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Controls.Add(mtTel);
            Controls.Add(tbMail);
            Controls.Add(tbSoyadi);
            Controls.Add(tbAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmKisi";
            Text = "FrmKisi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbAdi;
        private TextBox tbSoyadi;
        private TextBox tbMail;
        private MaskedTextBox mtTel;
        private Button btnTamam;
        private Button btnIptal;
    }
}