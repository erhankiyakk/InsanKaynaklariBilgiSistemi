using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class Kisiler
    {
        public double TCKimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string E_posta { get; set; }
        public Uyruk Uyruk { get; set; }
        public string Adres { get; set; }
        public string DogumYeri { get; set; }
        public List<string> YabanciDil { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string IlgiAlanlari { get; set; }
        public string Referans { get; set; }
        public double ElemanPuani { get; set; }
        public LinkedListIsDeneyimi Deneyimler;
        public LinkedListEgitim EgitimBilgisi;
        public Kisiler()
        {
            this.Deneyimler = new LinkedListIsDeneyimi();
            this.EgitimBilgisi = new LinkedListEgitim();
            this.YabanciDil = new List<string>();
        }
    }
}
