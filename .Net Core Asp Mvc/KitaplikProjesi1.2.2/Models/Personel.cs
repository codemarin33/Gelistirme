using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitaplikProjesi_v1._1._2.Models
{
    public class Personel
    {
        [Key]
        public int PersonelD { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sehir { get; set; }
        public int BirimID { get; set; }
        public Birim Birim { get; set; }

    }
}
