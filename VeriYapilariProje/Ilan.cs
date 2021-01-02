using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class Ilan
    {
        public int IlanNo { get; set; }
        public string IsTanimi { get; set; }
        public string Pozisyon { get; set; }
        public string ElemanOzellik { get; set; }
        public Sirket sirket { get; set; }
        public Heap Basvuru { get; set; }
        public Ilan()
        {
            Basvuru = new Heap(20);
        }

    }
}
