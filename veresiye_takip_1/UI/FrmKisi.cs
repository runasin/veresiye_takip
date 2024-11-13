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
    public partial class FrmKisi : Form
    {
        public FrmKisi()
        {
            InitializeComponent();
        }

        public string Ad { get { return tbAdi.Text; } 
                set { tbAdi.Text = value; } }
        public string SoyAd { get { return tbSoyadi.Text; }
            set { tbSoyadi.Text = value; } }
        public string Telefon { get { return mtTel.Text; }
            set { mtTel.Text = value; } }
        public string Mail { get { return tbMail.Text; }
            set { tbMail.Text = value; } }


        private void btnTamam_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Iptal_event(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }


}
