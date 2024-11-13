using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veresiye_takip_1
{
    internal class BL
    {
        public static List<Kisi> Kisiler = new List<Kisi>();

        public static void KisiEkle(string ad, string soyad, string tel , string mail)
        {
            Kisi k = new Kisi()
            {
                kID = Guid.NewGuid(),
                Ad = ad,
                SoyAd = soyad,
                Telefon = tel,
                Mail = mail
            };

            int sonuc = DL.KisiEkle(k.kID.ToString(), ad, soyad, tel, mail);
            if (sonuc != -1) 
                Kisiler.Add(k);
        }

        public static void KisiSil(string ID)
        {
            int sonuc = DL.KisiSil(ID);
            if (sonuc != -1)
            {
                Kisi k = Kisiler.Find(o => o.kID.ToString() == ID);
                Kisiler.Remove(k);
            }
        }

        public static void KisiDuzenle(string kid,string adi, string soyad, string tel, string mail)
        {
            Kisi k = Kisiler.Find(o => o.kID.ToString() == kid);
            int sonuc = DL.KisiDuzenle(kid, adi, soyad, tel, mail);
            if(sonuc != -1)
            {
                k.Ad = adi;
                k.SoyAd = soyad;
                k.Telefon = tel;
                k.Mail = mail;
            }
        }

        public static void GirdiEkle(string kid,float miktar, DateTime tarih,string aciklama)
        {
            Kisi k = Kisiler.Find(o=>o.kID.ToString() == kid);
            Girdi g = new Girdi()
            {
                gID = Guid.NewGuid(),
                Miktar = miktar,
                Tarih = tarih,
                Aciklama = aciklama
            };
            int sonuc = DL.GirdiEkle(kid, g.gID.ToString(), miktar, tarih, aciklama);
            if(sonuc != -1)            
                k.Girdiler.Add(g);            
        }

        public static void GirdiDuzenle(string kid, string gid,float miktar,DateTime tarih,string aciklama)
        {
            Kisi k = Kisiler.Find(o => o.kID.ToString() == kid);
            int sonuc= DL.GirdiDuzenle(gid, miktar, tarih,aciklama);
            if (sonuc != -1)
            {
                Girdi g = k.Girdiler.Find(o => o.gID.ToString() == gid);
                g.Miktar = miktar;
                g.Tarih = tarih;
                g.Aciklama = aciklama;
            }
        }

        public static void GirdiSil(string kid,string gid)
        {
            Kisi k = Kisiler.Find(o => o.kID.ToString() == kid);
            int sonuc = DL.GirdiSil(gid);
            if (sonuc != -1)
            {
                Girdi g = k.Girdiler.Find(o=> o.gID.ToString() == gid);
                k.Girdiler.Remove(g);
            }
        }

        public static void KisileriListele()
        {
            Kisiler = DL.KisileriListele();
            foreach(var k in Kisiler)
            {
                k.Girdiler = DL.GirdileriListele(k.kID.ToString());
            }
        }

        internal static float KisiToplamBorcu(string kid)
        {
            Kisi k = Kisiler.Find(o => o.kID.ToString() == kid);
            return k.Girdiler.Sum(o => o.Miktar);
           // return 0;
        }

        internal static List<Kisi> KisileriFiltrele(string filtre)
        {
            filtre=filtre.ToLower();

            if (string.IsNullOrEmpty(filtre))
                return Kisiler;

            List<Kisi> veriler = new List<Kisi>();
            foreach (var k in Kisiler)
            {
                if(k.Ad.ToLower().StartsWith(filtre) || k.SoyAd.ToLower().StartsWith(filtre) || k.Telefon.StartsWith(filtre) || k.Mail.ToLower().StartsWith(filtre))
                    veriler.Add(k);
            }

            return veriler;

        }
    }
}
