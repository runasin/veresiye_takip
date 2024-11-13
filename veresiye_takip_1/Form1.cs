namespace veresiye_takip_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BL veri = new BL();
        }

        public void KisileriListele()
        {
            BL.KisileriListele();
            listKisiler.Items.Clear();
            foreach (Kisi k in BL.Kisiler)
            {
                ListViewItem veri = new ListViewItem(
                    new string[] { k.kID.ToString(), k.Ad, k.SoyAd, k.Telefon, k.Mail });
                listKisiler.Items.Add(veri);
            }
        }

        void KisiGirdileriniListele(string kid)
        {
            Kisi k = BL.Kisiler.Find(o => o.kID.ToString() == kid);
            listVeriler.Items.Clear();
            foreach (Girdi g in k.Girdiler)
            {
                ListViewItem veri = new ListViewItem(
                    new string[]
                    {
                        k.kID.ToString(),
                        g.gID.ToString(),
                        g.Miktar.ToString("C2"),
                        g.Tarih.ToLongDateString(),
                        g.Aciklama
                    });
                listVeriler.Items.Add(veri);
            }

        }


        private void btnKisiEkle_Click(object sender, EventArgs e)
        {
            FrmKisi k = new FrmKisi()
            {
                Text = "Kişi Ekle",
                StartPosition = FormStartPosition.CenterParent
            };
            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.KisiEkle(k.Ad, k.SoyAd, k.Telefon, k.Mail);
                KisileriListele();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriListele();
        }

        private void listKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listKisiler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listKisiler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;
            KisiGirdileriniListele(kid);

            float borc_miktari = BL.KisiToplamBorcu(kid);
            lblBorc.Text = $"Toplam Borç: {borc_miktari:C2}";
        }

        private void btnBorcEkle_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listKisiler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;
            FrmGirdi g = new FrmGirdi()
            {
                Text = "Girdi",
                Borc = true,
                StartPosition = FormStartPosition.CenterParent
            };
            if (g.ShowDialog() == DialogResult.OK)
            {
                BL.GirdiEkle(kid, g.Miktar, g.Tarih, g.Aciklama);
                KisiGirdileriniListele(kid);
            }
            listKisiler_SelectedIndexChanged(null, null);
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listKisiler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;
            FrmGirdi g = new FrmGirdi()
            {
                Text = "Girdi",
                Borc = false,
                StartPosition = FormStartPosition.CenterParent
            };
            if (g.ShowDialog() == DialogResult.OK)
            {
                BL.GirdiEkle(kid, -g.Miktar, g.Tarih, g.Aciklama);
                KisiGirdileriniListele(kid);
            }
            listKisiler_SelectedIndexChanged(null, null);
        }

        private void btnKisiDuzenle_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listKisiler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;

            FrmKisi k = new FrmKisi()
            {
                Text = "Kişi Güncelle",
                StartPosition = FormStartPosition.CenterParent
            };
            k.Ad = veri.SubItems[1].Text;
            k.SoyAd = veri.SubItems[2].Text;
            k.Telefon = veri.SubItems[3].Text;
            k.Mail = veri.SubItems[4].Text;

            if (k.ShowDialog() == DialogResult.OK)
            {
                BL.KisiDuzenle(kid, k.Ad, k.SoyAd, k.Telefon, k.Mail);
                KisileriListele();
            }
        }

        private void btnKisiSil_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listKisiler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;
            string m = veri.SubItems[1].Text + " " + veri.SubItems[2].Text;

            DialogResult sonuc = MessageBox.Show($"Seçili {m.ToUpper()} müşterisi silinsin mi?\n{BL.KisiToplamBorcu(kid)}₺ Borcu bulunuyor", "Silmeyi Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                BL.KisiSil(kid);
                KisileriListele();
            }
        }

        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            if (listKisiler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listVeriler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;
            string gid = veri.SubItems[1].Text;

            string m = veri.SubItems[2].Text + " " + veri.SubItems[3].Text;

            DialogResult sonuc = MessageBox.Show($"Seçili {m.ToUpper()} girdisi silinsin mi?", "Silmeyi Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc == DialogResult.Yes)
            {
                BL.GirdiSil(kid, gid);
                KisileriListele();
            }
        }

        private void btnVeriDuzenle_Click(object sender, EventArgs e)
        {
            if (listVeriler.SelectedItems.Count == 0)
                return;
            ListViewItem veri = listVeriler.SelectedItems[0];
            string kid = veri.SubItems[0].Text;
            string gid = veri.SubItems[1].Text;

            string para = "";
            para += veri.SubItems[2].Text.Trim(['₺', ' ']);
            float mik = float.Parse(para);

            FrmGirdi g = new FrmGirdi()
            {
                Text = "Girdi Düzenle",
                StartPosition = FormStartPosition.CenterParent,
                Borc = mik > 0
            };

            g.Miktar = mik;
            g.Tarih = DateTime.Parse(veri.SubItems[3].Text);
            g.Aciklama = veri.SubItems[4].Text;

            if (g.ShowDialog() == DialogResult.OK)
            {
                BL.GirdiDuzenle(kid, gid, g.Miktar, g.Tarih, g.Aciklama);

                listKisiler_SelectedIndexChanged(null, null);
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            List<Kisi> filtreliVeri = BL.KisileriFiltrele(txtAra.Text);

            listKisiler.Items.Clear();
            listVeriler.Items.Clear();
            lblBorc.Text = null;
            foreach(Kisi fi in filtreliVeri)
            {
                ListViewItem veri = new ListViewItem(
                    new string[]
                    {
                        fi.kID.ToString(),
                        fi.Ad,
                        fi.SoyAd,
                        fi.Telefon,
                        fi.Mail
                    });
                listKisiler.Items.Add(veri);
            }

        }
    }
}
