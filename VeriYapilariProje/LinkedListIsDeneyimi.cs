using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class LinkedListIsDeneyimi:ListADT
    {
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

       
        public override Node GetElement(string isAdi)
        {
            Node retNode = null;
            Node tempNode = Head;
            while (tempNode != null)
            {
                if (((IsDeneyimi)tempNode.Data).IsYeri == isAdi)
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
                temp.Add((IsDeneyimi)node.Data);
                node = node.Next;
            }
            return temp;
        }
        public bool IkiYilUzeriDeneyim()
        {
            Boolean ikiYılUzeri = false;
            Node temp = Head;
            int toplamIsDeneyimi = 0;
            while (temp != null)
            {
                toplamIsDeneyimi += ((IsDeneyimi)temp.Data).Yil;
                temp = temp.Next;
            }
            
            if (toplamIsDeneyimi >= 2)
            {
                ikiYılUzeri = true;
            }
            return ikiYılUzeri;
        }
    }
}
