using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string kategori { get; set; }
        public string marka { get; set; }
        public string isim { get; set; }
        public decimal fiyat { get; set; }
        public decimal indirimlifiyat { get; set; }
        public string urunozellik { get; set; }
        public string renk { get; set; }
        public string resim { get; set; }
        public string resim2 { get; set; }
    }
}
