using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veresiye_takip_1
{

    /*
     kid varchar(64) primary key,
    adi varchar(32) not null,
    soyadi varchar(32) not null,
    telefon varchar(20) not null,
    mail varchar(255)
     */
    public class Kisi
    {
        public List<Girdi> Girdiler {  get; set; }
        public Guid kID {  get; set; }
        public string Ad {  get; set; }
        public  string SoyAd {  get; set; }
        public string Telefon {  get; set; }
        public string Mail { get; set; }
    }
}
