using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class LinkedListEgitim:ListADT
    {
        public Node dugum;
        public override void InsertFirst(object value)
        {
            Node tempHead = new Node() { Data = value };

            if (Head == null) 
            {
                Head = tempHead;
            }
            else
            {
               
                tempHead.Next = Head;
                Head = tempHead;
            }
            Size++;
        }


        
        public override Node GetElement(string OkulAdi)
        {
            Node retNode = null;
            Node tempNode = Head;
            while (tempNode != null)
            {
                if (((EgitimDurumBilgileri)tempNode.Data).OkulAdi== OkulAdi)
                {
                    retNode = tempNode;
                    break;
                }
                tempNode = tempNode.Next;
            }
            return retNode;
        }

        public override List<object> DisplayElements()
        {
            List<object> temp = new List<object>();
            Node node = Head;
            while (node != null) 
            {
                temp.Add((EgitimDurumBilgileri)node.Data);
                node = node.Next;
            }
            return temp;
        }
    }
}
