using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class Heap
    {
        private HeapDugum[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugum[maxSize];
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Kisiler deger)
        {
            if (currentSize == maxSize)
                return false;
            foreach (var item in BasvuruListele())
            {
                if (item.TCKimlik == deger.TCKimlik)
                {
                    return false;
                }
            }
            HeapDugum newHeapDugumu = new HeapDugum(deger);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugum top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (rightChild < currentSize && heapArray[leftChild].elemanPuani < heapArray[rightChild].elemanPuani)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.elemanPuani >= heapArray[largerChild].elemanPuani)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugum bottom = heapArray[index];
            while (index > 0 && (heapArray[parent].elemanPuani < bottom.elemanPuani))
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugum RemoveMax() 
        {
            HeapDugum root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            heapArray[currentSize] = null;
            return root;
        }

        public List<Kisiler> BasvuruListele()
        {
            int i = 0;
            List<Kisiler> liste = new List<Kisiler>();
            while ((heapArray[i]) != null)
            {
                liste.Add(((Kisiler)(heapArray[i]).Deger));
                i++;
            }
            return liste;
        }
        public Kisiler UygunAday()
        {
                return (Kisiler)heapArray[0].Deger;
        }
        public List<Kisiler> YabancıDilBilenleriListele(string dil)
        {
            int i = 0;
            List<Kisiler> liste = new List<Kisiler>();
            while ((heapArray[i]) != null)
            {
                foreach (var item in ((Kisiler)(heapArray[i]).Deger).YabanciDil)
                {
                    if (dil == item)
                    {
                        liste.Add(((Kisiler)(heapArray[i]).Deger));

                    }
                }
                i++;
            }
            return liste;
        }
        public List<Kisiler> ikiYılveüzeriDeneyimListele()
        {
            int i = 0;
            List<Kisiler> liste = new List<Kisiler>();
            while ((heapArray[i]) != null) 
            {
                if (((Kisiler)(heapArray[i]).Deger).Deneyimler.IkiYilUzeriDeneyim())
                {
                    liste.Add(((Kisiler)(heapArray[i]).Deger));
                }
                i++;
            }
            return liste;
        }



    }
}
