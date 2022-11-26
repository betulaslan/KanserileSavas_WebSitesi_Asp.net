using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AnaSayfa
    {
        [Key]
        public int AnaSayfaID { get; set; }
        public string Baslik { get; set; }
        public string Resim { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public string CoverImage { get; set; }
        public string Detay1 { get; set; }
        public string Detay2 { get; set; }
        public string Resim2 { get; set; }

    }
}
