namespace veresiye_takip_1
{
    partial class FrmGirdi
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
            numericUpDown1 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            btnTamam = new Button();
            btnIptal = new Button();
            lblDurum = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 48);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Miktar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 74);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Tarih:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 100);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Açıklama:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(86, 46);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1410065408, 2, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(86, 71);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(219, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 100);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(219, 82);
            textBox1.TabIndex = 5;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(111, 186);
            btnTamam.Margin = new Padding(3, 2, 3, 2);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(82, 22);
            btnTamam.TabIndex = 6;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // btnIptal
            // 
            btnIptal.Location = new Point(199, 186);
            btnIptal.Margin = new Padding(3, 2, 3, 2);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(82, 22);
            btnIptal.TabIndex = 7;
            btnIptal.Text = "İptal";
            btnIptal.UseVisualStyleBackColor = true;
            btnIptal.Click += btnIptal_Click;
            // 
            // lblDurum
            // 
            lblDurum.Dock = DockStyle.Top;
            lblDurum.Font = new Font("Segoe UI", 20F);
            lblDurum.Location = new Point(0, 0);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(386, 44);
            lblDurum.TabIndex = 8;
            lblDurum.Text = "label4";
            lblDurum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmGirdi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 234);
            Controls.Add(lblDurum);
            Controls.Add(btnIptal);
            Controls.Add(btnTamam);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGirdi";
            Text = "FrmGirdi";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Button btnTamam;
        private Button btnIptal;
        private Label lblDurum;
    }
}