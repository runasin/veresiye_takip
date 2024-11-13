using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veresiye_takip_1
{
    /*
     gid varchar(64) primary key,
    kid varchar(64) not null,
    
	miktar float not null default 0,
    tarih datetime,
    aciklama varchar(255)
     */
    public class Girdi
    {
        public Guid gID {  get; set; }
        public Guid kID { get; set; }
        public float Miktar {  get; set; }
        public DateTime Tarih {  get; set; }
        public string Aciklama { get; set; }
    }
}
