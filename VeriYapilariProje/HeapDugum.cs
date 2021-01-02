using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class HeapDugum
    {
        public double elemanPuani { get; set; }
        public object Deger { get; set; }
        public HeapDugum(object deger)
        {
            this.Deger = deger;
            Random rastgele = new Random();
            double sayi = rastgele.Next(0,10);
            elemanPuani = sayi;
        }
    }
}
