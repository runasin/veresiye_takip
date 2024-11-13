using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veresiye_takip_1
{
    public partial class FrmGirdi : Form
    {
        public float Miktar
        {
            get { return (float)numericUpDown1.Value; }
            set { numericUpDown1.Value = (decimal)value; }
        }
        public DateTime Tarih
        {
            get { return dateTimePicker1.Value; }
            set { dateTimePicker1.Value = value; }
        }
        public string Aciklama
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public FrmGirdi()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;  
        }

        bool borclu = true;
        public bool Borc
        {
            get { return borclu; }
            set
            {
                borclu = value;
                if (borclu == true)
                {
                    lblDurum.Text = "Borç Giriliyor";
                    lblDurum.BackColor = Color.Tomato;
                }
                else
                {
                    lblDurum.Text = "Ödeme Giriliyor";
                    lblDurum.BackColor = Color.YellowGreen;
                }
            }
        }




    }
}
