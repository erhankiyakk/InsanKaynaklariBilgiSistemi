using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public abstract class ListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(object value);
        public abstract Node GetElement(string value);

        public abstract List<object> DisplayElements();
    }
}
