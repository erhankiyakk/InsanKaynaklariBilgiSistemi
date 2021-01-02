using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class İkiliAramaAgaci
    {
        private İkiliAramaAgacDugumu kok;
        public List<Kisiler> dugumlerListesi;
        private Kisiler tekdugum;
        private string dugumler;
        public İkiliAramaAgaci()
        {
        }
        public İkiliAramaAgaci(İkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void PreOrder()
        {
            dugumlerListesi = new List<Kisiler>();
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }
        public void InOrder()
        {
            dugumlerListesi = new List<Kisiler>();
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(İkiliAramaAgacDugumu dugum)
        {
            
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        private void Ziyaret(İkiliAramaAgacDugumu dugum)
        {
            tekdugum = ((Kisiler)dugum.veri);

            dugumler += ((Kisiler)dugum.veri).Ad + ((Kisiler)dugum.veri).Soyad + " ";
            dugumlerListesi.Add(tekdugum);
        }
        public void PostOrder()
        {
            dugumlerListesi = new List<Kisiler>();
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void Ekle(Kisiler deger)
        {
            //Yeni eklenecek düğümün parent'ı
            İkiliAramaAgacDugumu tempParent = new İkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            İkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (deger.TCKimlik == ((Kisiler)tempSearch.veri).TCKimlik)
                    return;
                else if (deger.TCKimlik < ((Kisiler)tempSearch.veri).TCKimlik)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            İkiliAramaAgacDugumu eklenecek = new İkiliAramaAgacDugumu(deger);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (deger.TCKimlik < ((Kisiler)tempParent.veri).TCKimlik)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }
        public İkiliAramaAgacDugumu Ara(double anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private İkiliAramaAgacDugumu AraInt(İkiliAramaAgacDugumu dugum,
                                            double anahtar)
        {
            if (dugum == null)
                return null;
            else if (((Kisiler)dugum.veri).TCKimlik == anahtar)
                return dugum;
            else if (((Kisiler)dugum.veri).TCKimlik > anahtar)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }

        
        public void Guncelle(Kisiler kisi)
        {
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).TCKimlik=kisi.TCKimlik;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).Ad = kisi.Ad;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).Adres = kisi.Adres;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).Telefon = kisi.Telefon;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).E_posta = kisi.E_posta;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).Referans = kisi.Referans;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).DogumTarihi = kisi.DogumTarihi;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).DogumYeri = kisi.DogumYeri;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).IlgiAlanlari = kisi.IlgiAlanlari;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).YabanciDil=kisi.YabanciDil;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).Uyruk = kisi.Uyruk;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).EgitimBilgisi = kisi.EgitimBilgisi;
            ((Kisiler)AraInt(kok, kisi.TCKimlik).veri).Deneyimler = kisi.Deneyimler;
        }
        

        private İkiliAramaAgacDugumu Successor(İkiliAramaAgacDugumu silDugum)
        {
            İkiliAramaAgacDugumu successorParent = silDugum;
            İkiliAramaAgacDugumu successor = silDugum.sag;
            İkiliAramaAgacDugumu current = silDugum.sag;
            while (!(current.sol == null))
            {
                successorParent = current;
                successor = current.sol;
                current = current.sol;
            }
            if (!(successor == silDugum.sag))
            {
                successorParent.sol = successor.sag;
            }
            else
            {
                successorParent.sag = successor.sag;
            }
            return successor;
        }

        public bool Sil(double deger)
        {
            İkiliAramaAgacDugumu current = kok;
            İkiliAramaAgacDugumu parent = kok;
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (((Kisiler)current.veri).TCKimlik != deger)
            {
                parent = current;
                if (deger < ((Kisiler)current.veri).TCKimlik)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                {
                    kok = null;
                }
                else if (issol == true)
                {
                    parent.sol = null;
                }
                else
                {
                    parent.sag = null;
                }
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                {
                    kok = current.sol;
                }
                else if (issol)
                {
                    parent.sol = current.sol;
                }
                else
                {
                    parent.sag = current.sag;
                }
            }
            else if (current.sol == null)
            {
                if (current == kok)
                {
                    kok = current.sag;
                }
                else if (issol)
                {
                    parent.sol = current.sol;
                }
                else
                {
                    parent.sag = current.sag;
                }
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                İkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                {
                    successor.sol = kok.sol;
                    successor.sag = kok.sag;
                    kok = successor;
                }
                else if (issol)
                {
                    successor.sol = current.sol;
                    successor.sag = current.sag;
                    parent.sol = successor;
                }
                else
                {
                    successor.sol = current.sol;
                    successor.sag = current.sag;
                    parent.sag = successor;
                }
            }
            return true;
        }
        private int DerinlikBulma(İkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return 0;
            else
            {
                int solDerinlik = solDerinlik = DerinlikBulma(dugum.sol);
                int sagDerinlik = sagDerinlik = DerinlikBulma(dugum.sag);
                if (solDerinlik > sagDerinlik)
                    return solDerinlik + 1;
                else
                    return sagDerinlik + 1;
            }
        }
        public int DerinlikBul()
        {
            return DerinlikBulma(kok);
        }
        public int ElemanSayisi()
        {
            return ElamanSayisiBulma(kok);
        }
        private int ElamanSayisiBulma(İkiliAramaAgacDugumu dugum)
        {
            int elemanSayisi = 0;
            if (dugum != null)
            {
                elemanSayisi = 1;
                elemanSayisi += ElamanSayisiBulma(dugum.sol);
                elemanSayisi += ElamanSayisiBulma(dugum.sag);
            }
            return elemanSayisi;
        }
        
    }
}
