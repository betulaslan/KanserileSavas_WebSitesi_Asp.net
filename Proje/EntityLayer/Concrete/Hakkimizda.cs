using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Hakkimizda
    {
        [Key]
        public int HakkimizdaID { get; set; }
        public string Aciklama { get; set; }
        public string TelNo { get; set; }
        public string Adres { get; set; }
    }
}
