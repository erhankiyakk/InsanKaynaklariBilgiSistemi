using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class HashEntry
    {
        private int anahtar;

        private object deger;

        private HashEntry next;

        public object Deger
        {
            get { return deger; }
            set { deger = value; }
        }
        public int Anahtar
        {
            get { return anahtar; }
            set { anahtar = value; }
        }


        public HashEntry Next
        {
            get { return next; }
            set { next = value; }
        }


        public HashEntry(int anahtar, object deger)
        {
            this.anahtar = anahtar;
            this.deger = deger;
            this.next = null;
        }
    }
}
