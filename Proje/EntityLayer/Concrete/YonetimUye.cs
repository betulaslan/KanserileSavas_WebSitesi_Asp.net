using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class YonetimUye
    {
        [Key]
        public int YonetimUyeID { get; set; }
        public string AdSoyad { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
       

    }
}
