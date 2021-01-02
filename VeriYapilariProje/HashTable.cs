using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class HashTable
    {
        int TABLE_SIZE = 100;
        HashEntry[] hashTablosu;

        public HashTable()
        {
            hashTablosu = new HashEntry[TABLE_SIZE];
            for (int i = 0; i < TABLE_SIZE; i++)
                hashTablosu[i] = null;
        }

        public void IlanEkleme(int anahtar, object deger)
        {
            int indis = (anahtar % TABLE_SIZE);
            if (hashTablosu[indis] == null)
                hashTablosu[indis] = new HashEntry(anahtar, deger);
            else
            {
                HashEntry hashDugumu = hashTablosu[indis];
                while (hashDugumu.Next != null && hashDugumu.Anahtar != anahtar)
                    hashDugumu = hashDugumu.Next;
                if (hashDugumu.Anahtar == anahtar)
                    hashDugumu.Deger = deger;
                else
                    hashDugumu.Next = new HashEntry(anahtar, deger);
            }
        }
        public Ilan GetIlan(int key)
        {
            int hash = (key % TABLE_SIZE);
            if (hashTablosu[hash] == null)
                return null;
            else
            {
                HashEntry entry = hashTablosu[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return (Ilan)entry.Deger;
            }
        }
        public List<Ilan> ButunIlanlar()
        {
            List<Ilan> ilanlar = new List<Ilan>();
            for (int i = 0; i < 10; i++)
            {
                HashEntry entry = hashTablosu[i];
                while (entry != null)
                {
                    ilanlar.Add((Ilan)entry.Deger);
                    entry = entry.Next;
                }
            }
            return ilanlar;
        }
        public bool IlanSilme(int anahtar)
        {
            int hash = (anahtar % TABLE_SIZE);
            if (hashTablosu[hash] == null)
                return false;
            else
            {
                HashEntry entry = hashTablosu[hash];
                HashEntry parent = hashTablosu[hash];
                while (entry != null && entry.Anahtar != anahtar)
                {
                    parent = entry;
                    entry = entry.Next;
                }
                if (entry == null)
                    return false;
                else if (entry == hashTablosu[hash])
                {
                    hashTablosu[hash] = entry.Next;
                    return true;
                }
                else
                {
                    parent.Next = entry.Next;
                    return true;
                }

            }
        }
        public List<Ilan> isYeriAdınaGöreListe(string isYeriAdi)
        {
            List<Ilan> ılans = new List<Ilan>();
            for (int i = 0; i < 100; i++)
            {
                HashEntry entry = hashTablosu[i];
                while (entry != null)
                {
                    if (((Ilan)entry.Deger).sirket.Ad == isYeriAdi)
                    {
                        ılans.Add((Ilan)entry.Deger);
                    }
                    entry = entry.Next;
                }
            }
            return ılans;
        }
        public List<Ilan> pozisyonaListe(string pozisyon)
        {
            List<Ilan> ılans = new List<Ilan>();
            for (int i = 0; i < 10; i++)
            {
                HashEntry entry = hashTablosu[i];
                while (entry != null)
                {
                    if (((Ilan)entry.Deger).Pozisyon == pozisyon)
                    {
                        ılans.Add((Ilan)entry.Deger);
                    }
                    entry = entry.Next;
                }
            }
            return ılans;
        }
    }
}
