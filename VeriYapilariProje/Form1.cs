using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapilariProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //proje son hali
        HashTable hashtable = new HashTable();

        İkiliAramaAgaci aramaAgaci = new İkiliAramaAgaci();
        Kisiler kisiler = new Kisiler();
        İkiliAramaAgacDugumu dugum = new İkiliAramaAgacDugumu();
        List<Heap> heaps = new List<Heap>();

        LinkedListEgitim listeEgitim = new LinkedListEgitim();
        EgitimDurumBilgileri egitim = new EgitimDurumBilgileri();

        LinkedListIsDeneyimi listeIsDeneyimi = new LinkedListIsDeneyimi();
        IsDeneyimi isDeneyimi = new IsDeneyimi();

        Sirket sirket = new Sirket();
        List<Sirket> listeSirket = new List<Sirket>();
        private void EkranTemizle()
        {
            txtAd.Text = txtSoyad.Text = txtAdres.Text = txtTelefon.Text = txtEposta.Text = txtIlgiAlanlari.Text = txtDogumYeri.Text = txtReferans.Text = txtSoyad.Text = "";
            cbIngilizce.Checked = cbDige.Checked = cbAlmanca.Checked = false;
        }

      
        private void SilEkranTemizle()
        {
            txtSilinecekKisiTc.Text = "";

        }
        private void isBilgisiEkranTemizle()
        {
            txtIsTC.Text = txtIsDeneyimiIsyeriAdi.Text = txtIsDeneyimiIsyeriAdres.Text = txtIsDeneyimiPozisyon.Text = txtIsDeneyimiYil.Text = "";

        }
        private void EgitimBİlgiEKranTemizle()
        {
            txtOkulAdi.Text = txtBolum.Text = txtBaslangicTarih.Text = txtBitisTarih.Text = txtNotOrtalamasi.Text = "";

        }
        private void SirketTemizle()
        {
            txtSirketTelefon.Text = txtSirketAdres.Text = txtSirketEposta.Text = txtSirketFaks.Text;
        }
        private void BasvuruEkranTEmizle()
        {
            txtBasvurTc.Text = txtBasvurAd.Text = txtBasvurSoyad.Text = "";
        }
        private void SirketEkranTemizle()
        {
            txtSirketAd.Text = txtSirketAdres.Text = txtSirketEposta.Text = txtSirketTelefon.Text = txtSirketFaks.Text = "";
        }
        private void ListeleIdEkranTemizle()
        {
            txtListeleId.Text = "";
        }
        private void IlanSilEkranTemizle()
        {
            txtSilinecekIlanNo.Text = "";
        }
        private void IsYeriAdEkranTemizle()
        {
            txtIsYeriAdIlanListeleme.Text = "";
        }

        private void btnYeniIsEkle_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniOkulEkle_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btnIseAlinanAdayiBul_Click(object sender, EventArgs e)
        {

        }

        private void btnBasvuruYap_Click(object sender, EventArgs e)
        {

        }

        private void btnBasvur_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnIsBasvuranKaydet_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                MessageBox.Show("Lütfen bilgilerini giriniz");
            }
            else if (aramaAgaci.Ara(Convert.ToDouble(txtTc.Text)) != null)
            {
                MessageBox.Show("Sistemde kayıtlı böyle biri var");
            }
            else
            {
                kisiler = new Kisiler();
                kisiler.TCKimlik = Convert.ToDouble(txtTc.Text);
                kisiler.Ad = txtAd.Text;
                kisiler.Soyad = txtSoyad.Text;
                kisiler.Adres = txtAdres.Text;
                kisiler.Telefon = txtTelefon.Text;
                kisiler.E_posta = txtEposta.Text;
                kisiler.Referans = txtReferans.Text;
                kisiler.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value.ToString());
                kisiler.DogumYeri = txtDogumYeri.Text;
                kisiler.IlgiAlanlari = txtIlgiAlanlari.Text;
                if (cbAlmanca.Checked == true)
                {
                    kisiler.YabanciDil.Add("Almanca");
                }
                else if (cbIngilizce.Checked == true)
                {
                    kisiler.YabanciDil.Add("İngilizce");
                }
                else if (cbDige.Checked == true)
                {
                    kisiler.YabanciDil.Add("Diger");
                }
                kisiler.Uyruk = (cmbUyruk.SelectedItem.ToString() == "Yabancı") ? Uyruk.Diğer : Uyruk.TC;
                kisiler.EgitimBilgisi = listeEgitim;
                kisiler.Deneyimler = listeIsDeneyimi;
                aramaAgaci.Ekle(kisiler);
                MessageBox.Show(txtTc.Text + " Kişi eklendi.");
                EkranTemizle();
            }
        }

        private void btnIsBasvuranSil_Click(object sender, EventArgs e)
        {
            if (txtSilinecekKisiTc.Text == "")
                MessageBox.Show("Lütfen silmek istediğiniz kisinin Tc Kimlik numasını giriniz.");
            else
            {
                bool sil = aramaAgaci.Sil(Convert.ToDouble(txtSilinecekKisiTc.Text));
                if (sil)
                {
                    MessageBox.Show(txtSilinecekKisiTc.Text + " TC kimlik numaralı kişi silindi.");
                    SilEkranTemizle();
                }
                else
                    MessageBox.Show(txtSilinecekKisiTc.Text + " TC kimlik numaralı Kişi bulunamadı.");
            }
        }

        private void btnIsBasvuranGuncelle_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek istediğiniz kişinin TC kimlik numarasını girin");
            }
            else if (aramaAgaci.Ara(Convert.ToDouble(txtTc.Text)) == null)
            {
                MessageBox.Show("Girdiğiniz TC kimlik numarasıyla bir kişi bulunamadı.");
            }
            else
            {
                kisiler = new Kisiler();
                kisiler.TCKimlik = Convert.ToDouble(txtTc.Text);
                kisiler.Ad = txtAd.Text;
                kisiler.Soyad = txtSoyad.Text;
                kisiler.Adres = txtAdres.Text;
                kisiler.Telefon = txtTelefon.Text;
                kisiler.E_posta = txtEposta.Text;
                kisiler.Referans = txtReferans.Text;
                kisiler.DogumTarihi = Convert.ToDateTime(dtpDogumTarihi.Value.ToString());
                kisiler.DogumYeri = txtDogumYeri.Text;
                kisiler.IlgiAlanlari = txtIlgiAlanlari.Text;
                if (cbAlmanca.Checked == true)
                {
                    kisiler.YabanciDil.Add("Almanca");
                }
                else if (cbIngilizce.Checked == true)
                {
                    kisiler.YabanciDil.Add("İngilizce");
                }
                else if (cbDige.Checked == true)
                {
                    kisiler.YabanciDil.Add("Diger");
                }
                aramaAgaci.Guncelle(kisiler);
                MessageBox.Show(txtTc.Text + " Kişi Güncellendi.");
                EkranTemizle();
            }

        }

        private void btnIsBilgisiEkle_Click(object sender, EventArgs e)
        {
            if (((Kisiler)aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)).veri).Deneyimler.GetElement(txtIsDeneyimiIsyeriAdi.Text) != null)
            {
                MessageBox.Show("Lütfen sisteminizde kayıtlı olmayan bir iş yeri bilgisi giriniz");
            }
            if (txtIsTC.Text == "")
            {
                MessageBox.Show("Lütfen eğitimini eklemek istediğiniz kişinin sistemde kayıtlı tc kimlik nosu giriniz");
            }
            else if(aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)) == null)
            {
                MessageBox.Show("Lütfen eğitimini eklemek istediğiniz kişinin sistemde kayıtlı tc kimlik nosu giriniz");

            }
            else if (txtIsDeneyimiIsyeriAdi.Text == "" || txtIsDeneyimiPozisyon.Text == "" || txtIsDeneyimiYil.Text == "")
            {
                MessageBox.Show("Eğitim bilgilerini girin.");
            }
            else
            {
                isDeneyimi.IsYeri = txtIsDeneyimiIsyeriAdi.Text;
                isDeneyimi.IsYeriAdres = txtIsDeneyimiIsyeriAdres.Text;
                isDeneyimi.Pozisyon = txtIsDeneyimiPozisyon.Text;
                isDeneyimi.Yil = Convert.ToInt32(txtIsDeneyimiYil.Text);
                ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)).veri).Deneyimler.InsertFirst(isDeneyimi);
                isBilgisiEkranTemizle();
                isDeneyimi = new IsDeneyimi();
            }

            DataTable table = new DataTable();
            dgwIsYerleri.DataSource = table;
        }

        private void btnIsBilgisiGuncelle_Click(object sender, EventArgs e)
        {
            if (((Kisiler)aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)).veri).Deneyimler.GetElement(txtIsDeneyimiIsyeriAdi.Text) == null)
            {
                MessageBox.Show("Lütfen sisteminizde kayıtlı olan bir iş yeri bilgisi giriniz");
            }
            else if (txtIsTC.Text == "" || txtIsDeneyimiIsyeriAdi.Text == "" || txtIsDeneyimiIsyeriAdres.Text == "" || txtIsDeneyimiPozisyon.Text == "" || txtIsDeneyimiYil.Text == "")
            {
                MessageBox.Show("Lütfen Güncellemek istediğiniz kişinin TC kimlik numarasını girin");
            }
            else if (aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)) == null)
            {
                MessageBox.Show("Girdiğiniz TC kimlik numarasıyla bir kişi bulunamadı.");
            }
            else
            {
                dugum = aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text));
                Kisiler kisi = (Kisiler)dugum.veri;
                kisi.Deneyimler = ((Kisiler)dugum.veri).Deneyimler;
                Node nodeDeneyim = ((Kisiler)dugum.veri).Deneyimler.GetElement(txtIsDeneyimiIsyeriAdi.Text);
                if (nodeDeneyim == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz is yerinin adını düzgün giriniz");
                }
                else
                {
                    IsDeneyimi isDeneyimi = (IsDeneyimi)nodeDeneyim.Data;
                    isDeneyimi.IsYeri = txtIsDeneyimiIsyeriAdi.Text;
                    isDeneyimi.IsYeriAdres = txtIsDeneyimiIsyeriAdres.Text;
                    isDeneyimi.Pozisyon = txtIsDeneyimiPozisyon.Text;
                    isDeneyimi.Yil = Convert.ToInt32(txtIsDeneyimiYil.Text);
                    MessageBox.Show("İş Deneyim Bilgisi GÜncellendi...");
                    isBilgisiEkranTemizle();
                    DataTable table = new DataTable();
                    dgwIsYerleri.DataSource = table;

                }
            }
        }

        private void btnIsBilGoster_Click(object sender, EventArgs e)
        {
            if (txtIsTC.Text == "")
            {
                MessageBox.Show("Lütfen listelemek istediğiniz kişinin tc kimlik numarasını girin");
            }
            else if (aramaAgaci.Ara(Convert.ToInt32(txtIsTC.Text)) == null)
            {
                MessageBox.Show("Lütfen sistemde kayıtlı tc giriniz");
            }
            else
            {
                dugum = aramaAgaci.Ara(Convert.ToInt32(txtIsTC.Text));
                Node nodeDeneyim = new Node();
                Kisiler k = new Kisiler();
                k.Deneyimler = ((Kisiler)dugum.veri).Deneyimler;
                nodeDeneyim = ((Kisiler)dugum.veri).Deneyimler.Head;
                DataTable tablo = new DataTable();
                tablo.Columns.Add("IsYeri", typeof(string));
                tablo.Columns.Add("IsYeriAdres", typeof(string));
                tablo.Columns.Add("Pozisyon", typeof(string));
                tablo.Columns.Add("Yıl", typeof(string));
                tablo.Rows.Clear();
                while (nodeDeneyim != null)
                {
                    IsDeneyimi isDeneyimi = (IsDeneyimi)nodeDeneyim.Data;
                    tablo.Rows.Add(isDeneyimi.IsYeri, isDeneyimi.IsYeriAdres, isDeneyimi.Pozisyon,isDeneyimi.Yil);
                    nodeDeneyim = nodeDeneyim.Next;
                }
                dgwIsYerleri.DataSource = tablo;
            }
            isBilgisiEkranTemizle();
        }

        private void btnEgitimBİlgisiEkle_Click(object sender, EventArgs e)
        {
            if (((Kisiler)aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)).veri).EgitimBilgisi.GetElement(txtOkulAdi.Text) != null)
            {
                MessageBox.Show("Lütfen sisteminizde kayıtlı olmayan bir eğitim yeri bilgisi giriniz");
            }
            else if (txtEgitimTC.Text == "" )
            {
                MessageBox.Show("Lütfen eğitimini eklemek istediğiniz kişinin sistemde kayıtlı tc kimlik nosu giriniz");
            }
            else if(aramaAgaci.Ara(Convert.ToDouble(txtEgitimTC.Text)) == null)
            {
                MessageBox.Show("Lütfen eğitimini eklemek istediğiniz kişinin sistemde kayıtlı tc kimlik nosu giriniz");

            }
            else if (txtOkulAdi.Text == "" || txtNotOrtalamasi.Text == "" || txtBolum.Text == "" || txtBaslangicTarih.Text == "" || txtBitisTarih.Text == "")
                MessageBox.Show("Eğitim bilgilerini girin.");
            else
            {
                egitim.OkulAdi = txtOkulAdi.Text;
                egitim.Bolum = txtBolum.Text;
                egitim.BaslangicYili = Convert.ToInt32(txtBaslangicTarih.Text);
                egitim.BitisYili = Convert.ToInt32(txtBitisTarih.Text);
                egitim.NotOrtalama = Convert.ToDouble(txtNotOrtalamasi.Text);
                ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(txtEgitimTC.Text)).veri).EgitimBilgisi.InsertFirst(egitim);
                MessageBox.Show("Eğitim bilgileri eklendi.");
                EgitimBİlgiEKranTemizle();
                egitim = new EgitimDurumBilgileri();

            }
        }

        private void btnEgitimBilgisiGoster_Click(object sender, EventArgs e)
        {
            if (txtEgitimTC.Text == "")
            {
                MessageBox.Show("Lütfen listelemek istediğiniz kişinin tc kimlik numarasını girin");
            }
            else if (aramaAgaci.Ara(Convert.ToInt32(txtEgitimTC.Text)) == null)
            {
                MessageBox.Show("Lütfen sistemde kayıtlı tc giriniz");
            }
            else
            {
                dugum = aramaAgaci.Ara(Convert.ToInt32(txtEgitimTC.Text));
                Node nodeEgitim = new Node();
                Kisiler k = new Kisiler();
                k.EgitimBilgisi = ((Kisiler)dugum.veri).EgitimBilgisi;
                nodeEgitim = ((Kisiler)dugum.veri).EgitimBilgisi.Head;
                DataTable tablo = new DataTable();
                tablo.Columns.Add("Okul Adı", typeof(string));
                tablo.Columns.Add("Bolum", typeof(string));
                tablo.Columns.Add("Baslangıç Yılı", typeof(string));
                tablo.Columns.Add("Bitis Yılı", typeof(string));
                tablo.Columns.Add("Not Ortalaması", typeof(int));
                tablo.Rows.Clear();
                while (nodeEgitim != null)
                {
                    EgitimDurumBilgileri egitim = (EgitimDurumBilgileri)nodeEgitim.Data;
                    tablo.Rows.Add(egitim.OkulAdi, egitim.Bolum, egitim.BaslangicYili, egitim.BitisYili, egitim.NotOrtalama);
                    nodeEgitim = nodeEgitim.Next;
                }
                dgwEgitimBilgileri.DataSource = tablo;
                EgitimBİlgiEKranTemizle();
            }
        }

        private void btnKisiAra_Click(object sender, EventArgs e)
        {
            if (txtKisiAra.Text == "")
                MessageBox.Show("Arama yapmak için önce aranacak kişinin TCsini giriniz.");
            else if(aramaAgaci.Ara(Convert.ToInt32(txtKisiAra.Text)) == null)
            {
                MessageBox.Show("Lütfen sisteme kayıtlı TC giriniz");
            }
            else
            {
                //Ara methodu ile kişi ağacı üzerinde kişi adına göre arama işlemi gerçekleştirildi
                dugum = aramaAgaci.Ara(Convert.ToInt32(txtKisiAra.Text));
                //kişi ikili arama ağacında bulunamazsa null değer döner
                if (dugum == null)
                {
                    MessageBox.Show("Aradığınız kişi bulunamadı.");
                    txtKisiAra.Text = "";
                }
                else
                {
                    txtTc.Text = ((Kisiler)dugum.veri).TCKimlik.ToString();
                    txtIsTC.Text= ((Kisiler)dugum.veri).TCKimlik.ToString();
                    txtEgitimTC.Text= ((Kisiler)dugum.veri).TCKimlik.ToString();
                    txtAd.Text = ((Kisiler)dugum.veri).Ad;
                    txtSoyad.Text = ((Kisiler)dugum.veri).Soyad;
                    txtAdres.Text = ((Kisiler)dugum.veri).Adres;
                    txtTelefon.Text = ((Kisiler)dugum.veri).Telefon;
                    txtEposta.Text = ((Kisiler)dugum.veri).E_posta;
                    txtReferans.Text = ((Kisiler)dugum.veri).Referans;
                    txtDogumYeri.Text = ((Kisiler)dugum.veri).DogumYeri;
                    txtIlgiAlanlari.Text = ((Kisiler)dugum.veri).IlgiAlanlari;
                    dtpDogumTarihi.Value = (Convert.ToDateTime((((Kisiler)dugum.veri).DogumTarihi)));
                    foreach (var item in ((Kisiler)dugum.veri).YabanciDil)
                    {
                        if (item == "Almanca")
                        {
                            cbAlmanca.Checked = true;
                        }
                        else if (item == "İngilizce")
                        {
                            cbIngilizce.Checked = true;
                        }
                        else
                        {
                            cbDige.Checked = true;
                        }
                    }
                    Node nodeDeneyim = ((Kisiler)dugum.veri).Deneyimler.Head;
                    DataTable tablo = new DataTable();
                    tablo.Columns.Add("IsYeri", typeof(string));
                    tablo.Columns.Add("IsYeriAdres", typeof(string));
                    tablo.Columns.Add("Pozisyon", typeof(string));
                    tablo.Columns.Add("Yıl", typeof(int));
                    tablo.Rows.Clear();
                    while (nodeDeneyim != null)
                    {
                        IsDeneyimi isDeneyimi = (IsDeneyimi)nodeDeneyim.Data;
                        tablo.Rows.Add(isDeneyimi.IsYeri, isDeneyimi.IsYeriAdres, isDeneyimi.Pozisyon,isDeneyimi.Yil);
                        nodeDeneyim = nodeDeneyim.Next;
                    }
                    dgwIsYerleri.DataSource = tablo;

                    Node nodeEgitim = ((Kisiler)dugum.veri).EgitimBilgisi.Head;
                    DataTable tablom = new DataTable();
                    tablom.Columns.Add("Okul Adı", typeof(string));
                    tablom.Columns.Add("Bolum", typeof(string));
                    tablom.Columns.Add("Baslangıç Yılı", typeof(string));
                    tablom.Columns.Add("Bitis Yılı", typeof(string));
                    tablom.Columns.Add("Not Ortalaması", typeof(int));
                    tablom.Rows.Clear();
                    while (nodeEgitim != null)
                    {
                        EgitimDurumBilgileri egitim = (EgitimDurumBilgileri)nodeEgitim.Data;
                        tablom.Rows.Add(egitim.OkulAdi, egitim.Bolum, egitim.BaslangicYili, egitim.BitisYili, egitim.NotOrtalama);
                        nodeEgitim = nodeEgitim.Next;
                    }
                    dgwEgitimBilgileri.DataSource = tablom;
                    
                }
            }
        }

        private void btnEgitimBilgisiGuncelle_Click(object sender, EventArgs e)
        {
            if (((Kisiler)aramaAgaci.Ara(Convert.ToDouble(txtIsTC.Text)).veri).EgitimBilgisi.GetElement(txtOkulAdi.Text) == null)
            {
                MessageBox.Show("Lütfen sisteminizde kayıtlı olan bir eğitim yeri bilgisi giriniz");
            }
            else if (txtEgitimTC.Text == "" || txtOkulAdi.Text == "" || txtNotOrtalamasi.Text == "" || txtBaslangicTarih.Text == "" || txtBitisTarih.Text == "")
            {
                MessageBox.Show("Lütfen listelemek istediğiniz kişinin bilgilerini girin");
            }
            else if (aramaAgaci.Ara(Convert.ToInt32(txtEgitimTC.Text)) == null)
            {
                MessageBox.Show("Lütfen sistemde kayıtlı tc giriniz");
            }
            else
            {
                dugum = aramaAgaci.Ara(Convert.ToInt32(txtEgitimTC.Text));
                DataTable tablo = new DataTable();
                Node nodeEgitim = ((Kisiler)dugum.veri).EgitimBilgisi.GetElement(txtOkulAdi.Text);
                if (nodeEgitim == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz is yerinin adını düzgün giriniz");
                }
                else
                {
                    EgitimDurumBilgileri egitimDurumBilgileri = (EgitimDurumBilgileri)nodeEgitim.Data;
                    egitimDurumBilgileri.Bolum = txtBolum.Text;
                    egitimDurumBilgileri.BaslangicYili = Convert.ToInt32(txtBaslangicTarih.Text);
                    egitimDurumBilgileri.BitisYili = Convert.ToInt32(txtBitisTarih.Text);
                    egitimDurumBilgileri.NotOrtalama = Convert.ToInt32(txtNotOrtalamasi.Text);
                    MessageBox.Show("Eğitim Bilginiz Güncellendi...");
                }
                
            }
            EgitimBİlgiEKranTemizle();
            DataTable table = new DataTable();
            dgwEgitimBilgileri.DataSource = table;

        }

        private void btnBasvuruYap_Click_1(object sender, EventArgs e)
        {
            if (dgvIlanlar.Rows.Count<1)
            {
                MessageBox.Show("Lütfen iş ilanınlarını listeleyin.");
            }
            else if(txtBasvurTc.Text == "" || txtBasvurAd.Text == "" || txtBasvurSoyad.Text == "" || aramaAgaci.Ara(Convert.ToInt32(txtBasvurTc.Text)) == null)
            {
                MessageBox.Show("Lütfen sistemde kayıtlı kişi bilgilerini giriniz");
            }

            else
            {
                Ilan ilan = hashtable.GetIlan(Convert.ToInt32(dgvIlanlar.CurrentRow.Cells[0].Value));
                dugum = aramaAgaci.Ara(Convert.ToInt32(txtBasvurTc.Text));
                Kisiler kisi = (Kisiler)dugum.veri;
                if (ilan.Basvuru.Insert(kisi))
                {
                    MessageBox.Show("Başvurnuz tamamlandı.");
                    BasvuruEkranTEmizle();
                }
                else
                {
                    MessageBox.Show("Lütfen başvurmadığınız bir işe başvurun");
                }
            }
        }
        

        private void btnIsYeriAdinaGoreIlanListele_Click(object sender, EventArgs e)
        {
            if (txtIsYeriAdIlanListeleme.Text == "")
            {
                MessageBox.Show("lütfen sistemde kayıtlı bir iş yeri adı giriniz");
            }
            else
            {
                List<Ilan> ılans = new List<Ilan>();
                ılans = hashtable.isYeriAdınaGöreListe(txtIsYeriAdIlanListeleme.Text);
                if (ılans == null)
                {
                    MessageBox.Show("lütfen sistemde kayıtlı bir iş yeri adı giriniz");
                }
                else
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ilan no", typeof(int));
                    table.Columns.Add("Sirket", typeof(string));
                    table.Columns.Add("Pozisyon", typeof(string));
                    table.Columns.Add("eleman özellikleri", typeof(string));
                    table.Columns.Add("İş Tanımı", typeof(string));
                    table.Rows.Clear();
                    foreach (var i in ılans)
                    {
                        table.Rows.Add(i.IlanNo,i.sirket.Ad,i.Pozisyon,i.ElemanOzellik,i.IsTanimi);

                    }

                    dgvIlanlar.DataSource=table;
                    IsYeriAdEkranTemizle();
                }
            }
        }
       
            
        private void btnSirketEkle_Click(object sender, EventArgs e)
        {
            if (listeSirket.Find(x => x.Ad == txtSirketAd.Text) != null)
            {
                MessageBox.Show("lütfen sistemde kayıtlı olmayan bir şirket ismi giriniz");
            }
            else if (txtSirketAd.Text == "")
                MessageBox.Show("Lütfen Şirket Bilgilerini Giriniz");
            else
            {
                sirket = new Sirket();
                sirket.Ad = txtSirketAd.Text;
                sirket.Adresi = txtSirketAdres.Text;
                sirket.Eposta = txtSirketEposta.Text;
                sirket.Telefon = txtSirketTelefon.Text;
                sirket.Faks = txtSirketFaks.Text;
                listeSirket.Add(sirket);
                MessageBox.Show("Şirket sisteme başarıyla kaydedildi.");
                SirketEkranTemizle();
            }
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            aramaAgaci.PreOrder();
            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));

            tablo.Rows.Clear();
            foreach (var i in aramaAgaci.dugumlerListesi)
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }

            dgvKisiler.DataSource = tablo;
        }

        private void btnInorder_Click(object sender, EventArgs e)
        {
            aramaAgaci.InOrder();


            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));

            tablo.Rows.Clear();
            foreach (var i in aramaAgaci.dugumlerListesi)
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }

            dgvKisiler.DataSource = tablo;
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            aramaAgaci.PostOrder();


            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));

            tablo.Rows.Clear();
            foreach (var i in aramaAgaci.dugumlerListesi)
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }

            dgvKisiler.DataSource = tablo;
        }

        private void btnDerinlik_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ağaç Derinliği : " + aramaAgaci.DerinlikBul().ToString());

        }

        private void btnElemanSayisi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eleman Sayısı : " + aramaAgaci.ElemanSayisi().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kisiler kisiler1;
            kisiler1 = new Kisiler();
            kisiler1.TCKimlik = 1012;
            kisiler1.Ad ="Halil";
            kisiler1.Soyad = "Yeşil";
            kisiler1.Adres = "Ankara";
            kisiler1.Telefon = "542";
            kisiler1.E_posta = "halilyesilceng@gmail.com";
            kisiler1.Referans = "Erhan";
            kisiler1.DogumTarihi =DateTime.Parse("22/11/1998");
            kisiler1.DogumYeri ="Yozgat";
            kisiler1.IlgiAlanlari = "Gitar Çalmak";
            kisiler1.YabanciDil.Add("İngilizce");
            kisiler1.YabanciDil.Add("Almanca");
            kisiler1.YabanciDil.Add("Diğer");
            kisiler1.Uyruk =Uyruk.TC;
            
            aramaAgaci.Ekle(kisiler1);
            IsDeneyimi isDeneyimi1 = new IsDeneyimi();
            isDeneyimi1.IsYeri = "BAKIRÇAY";
            isDeneyimi1.IsYeriAdres = "İZMİR";
            isDeneyimi1.Pozisyon = "REKTÖR";
            isDeneyimi1.Yil = 15;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1012)).veri).Deneyimler.InsertFirst(isDeneyimi1);

            EgitimDurumBilgileri egitim1 = new EgitimDurumBilgileri();
            egitim1.OkulAdi = "BAKIRÇAY ÜNİVERSİTESİ";
            egitim1.Bolum ="BİLGİSAYAR MÜHENDİSLİĞİ";
            egitim1.BaslangicYili = 2018;
            egitim1.BitisYili = 2022;
            egitim1.NotOrtalama = 4;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1012)).veri).EgitimBilgisi.InsertFirst(egitim1);
            IsDeneyimi isDeneyimi2 = new IsDeneyimi();

            isDeneyimi2.IsYeri = "SİLİKON VADİSİ";
            isDeneyimi2.IsYeriAdres = "KALİFORNİYA";
            isDeneyimi2.Pozisyon = "CEO";
            isDeneyimi2.Yil = 10;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1012)).veri).Deneyimler.InsertFirst(isDeneyimi2);

            EgitimDurumBilgileri egitim2 = new EgitimDurumBilgileri();
            egitim2.OkulAdi = "ANKARA LİSESİ";
            egitim2.Bolum = "SAYISAL";
            egitim2.BaslangicYili = 2012;
            egitim2.BitisYili = 2017;
            egitim2.NotOrtalama = 100;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1012)).veri).EgitimBilgisi.InsertFirst(egitim2);

            Kisiler kisiler2;
            kisiler2 = new Kisiler();
            kisiler2.TCKimlik = 1389;
            kisiler2.Ad = "Erhan";
            kisiler2.Soyad = "Kıyak";
            kisiler2.Adres = "Denizli";
            kisiler2.Telefon = "532";
            kisiler2.E_posta = "erhankiyak@gmail.com";
            kisiler2.Referans = "Halil";
            kisiler2.DogumTarihi =DateTime.Parse(" 15/03/1998");
            kisiler2.DogumYeri = "Denizli";
            kisiler2.IlgiAlanlari = "Veri Yapıları Çalışmak";
            kisiler2.YabanciDil.Add("");
            kisiler2.Uyruk = Uyruk.Diğer;
            
            aramaAgaci.Ekle(kisiler2);
            IsDeneyimi isDeneyimi3 = new IsDeneyimi();

            isDeneyimi3.IsYeri = "KATİP ÇELEBİ";
            isDeneyimi3.IsYeriAdres = "İZMİR";
            isDeneyimi3.Pozisyon = "DEKAN";
            isDeneyimi3.Yil = 9;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1389)).veri).Deneyimler.InsertFirst(isDeneyimi3);

            EgitimDurumBilgileri egitim3 = new EgitimDurumBilgileri();
            egitim3.OkulAdi = "BAKIRÇAY ÜNİVERSİTESİ";
            egitim3.Bolum = "BİLGİSAYAR MÜHENDİSLİĞİ";
            egitim3.BaslangicYili = 2018;
            egitim3.BitisYili = 2022;
            egitim3.NotOrtalama =3.99;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1389)).veri).EgitimBilgisi.InsertFirst(egitim3);

            IsDeneyimi isDeneyimi4 = new IsDeneyimi();

            isDeneyimi4.IsYeri = "GOOGLE";
            isDeneyimi4.IsYeriAdres = "KALİFORNİYA";
            isDeneyimi4.Pozisyon = "CEP";
            isDeneyimi4.Yil = 10;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1389)).veri).Deneyimler.InsertFirst(isDeneyimi4);

            EgitimDurumBilgileri egitim4 = new EgitimDurumBilgileri();

            egitim4.OkulAdi = "DENİZLİ LİSESİ";
            egitim4.Bolum = "SAYISAL";
            egitim4.BaslangicYili = 2013;
            egitim4.BitisYili = 2017;
            egitim4.NotOrtalama = 99;
            ((Kisiler)aramaAgaci.Ara(Convert.ToDouble(1389)).veri).EgitimBilgisi.InsertFirst(egitim4);


            Kisiler kisiler3;
            kisiler3 = new Kisiler();
            kisiler3.TCKimlik = 1385;
            kisiler3.Ad = "Abdulsamet";
            kisiler3.Soyad = "Alper";
            kisiler3.Adres = "İzmir";
            kisiler3.Telefon = "555";
            kisiler3.E_posta = "abdus01@gmail.com";
            kisiler3.Referans = "Erhan";
            kisiler3.DogumTarihi = DateTime.Parse("18/05/1999");
            kisiler3.DogumYeri = "Erzurum";
            kisiler3.IlgiAlanlari = "Playstation";
            kisiler3.YabanciDil.Add("Almanca");
            kisiler3.Uyruk = Uyruk.TC;
           
            aramaAgaci.Ekle(kisiler3);

            Kisiler kisiler4;
            kisiler4 = new Kisiler();
            kisiler4.TCKimlik = 1390;
            kisiler4.Ad = "Enes";
            kisiler4.Soyad = "Kurt";
            kisiler4.Adres = "İzmir";
            kisiler4.Telefon = "123";
            kisiler4.E_posta = "eneskurt@gmail.com";
            kisiler4.Referans = "Abdulsamet";
            kisiler4.DogumTarihi = DateTime.Parse("12/01/1939");
            kisiler4.DogumYeri = "Erzurum";
            kisiler4.IlgiAlanlari = "Gemi";
            kisiler4.YabanciDil.Add("İngilizce");
            kisiler4.YabanciDil.Add("Diğer");
            kisiler4.Uyruk = Uyruk.Diğer;
            
            aramaAgaci.Ekle(kisiler4);

            Kisiler kisiler5;
            kisiler5 = new Kisiler();
            kisiler5.TCKimlik = 391;
            kisiler5.Ad = "Omer";
            kisiler5.Soyad = "Şengün";
            kisiler5.Adres = "Kocaeli";
            kisiler5.Telefon = "3123";
            kisiler5.E_posta = "omercan@gmail.com";
            kisiler5.Referans = "Enes";
            kisiler5.DogumTarihi = DateTime.Parse("22/11/1993");
            kisiler5.DogumYeri = "İzmir";
            kisiler5.IlgiAlanlari = "Futbol";
            kisiler5.YabanciDil.Add("İngilizce");
            kisiler5.Uyruk = Uyruk.TC;
            
            aramaAgaci.Ekle(kisiler5);

            Sirket sirket1 = new Sirket();          
            sirket1.Ad = "Nurol";
            sirket1.Adresi = "Ankara";
            sirket1.Eposta = "nurol@gmail.com";
            sirket1.Telefon = "0312";
            sirket1.Faks = "814";
            listeSirket.Add(sirket1);

            Ilan ilan1 = new Ilan();
            ilan1.IlanNo = 1;
            ilan1.IsTanimi = "Yazılım";
            ilan1.Pozisyon = "Çalışan";
            ilan1.ElemanOzellik = "Veri yapısı profesyonel kullanmak";
            ilan1.sirket = sirket1;
            hashtable.IlanEkleme(ilan1.IlanNo, ilan1);
            ilan1.Basvuru.Insert(kisiler3);
            ilan1.Basvuru.Insert(kisiler4);
            ilan1.Basvuru.Insert(kisiler5);

            Ilan ilan2 = new Ilan();
            ilan2.IlanNo = 2;
            ilan2.IsTanimi = "Yazılım";
            ilan2.Pozisyon = "Çalışan";
            ilan2.ElemanOzellik = "Veri Biliminde uzman";
            ilan2.sirket = sirket1;
            hashtable.IlanEkleme(ilan2.IlanNo, ilan2);

            Sirket sirket2 = new Sirket();
            sirket2.Ad = "Fasdat";
            sirket2.Adresi = "Ankara";
            sirket2.Eposta = "fasdat@gmail.com";
            sirket2.Telefon = "2312";
            sirket2.Faks = "45123";
            listeSirket.Add(sirket2);

            Ilan ilan3 = new Ilan();
            ilan3.IlanNo = 3;
            ilan3.IsTanimi = "Yazılım";
            ilan3.Pozisyon = "Müdür";
            ilan3.ElemanOzellik = "Proje yönetmek";
            ilan3.sirket = sirket2;
            hashtable.IlanEkleme(ilan3.IlanNo, ilan3);

            Sirket sirket3 = new Sirket();
            sirket3.Ad = "Hugp boss";
            sirket3.Adresi = "izmir";
            sirket3.Eposta = "hugo@gmail.com";
            sirket3.Telefon = "3231";
            sirket3.Faks = "543534";
            listeSirket.Add(sirket3);

            Ilan ilan4 = new Ilan();
            ilan4.IlanNo = 4;
            ilan4.IsTanimi = "Yazılım";
            ilan4.Pozisyon = "Çalışan";
            ilan4.ElemanOzellik = "Test uzmanı";
            ilan4.sirket = sirket3;
            hashtable.IlanEkleme(ilan4.IlanNo, ilan4);


        }

        private void btnSirketSil_Click(object sender, EventArgs e)
        {
            List<Sirket> sirkets = listeSirket;
            foreach (var item in sirkets)
            {
                if (item.Ad == txtSirketAd.Text)
                {
                    listeSirket.Remove(item);
                    MessageBox.Show("Silme işlemi gerçekleşti");
                    SirketEkranTemizle();
                    break;
                }
            }
            MessageBox.Show("Böyle bir kayıt bulunamadı");
        }
        
        private void btnSirketGuncelle_Click(object sender, EventArgs e)
        {
            foreach (var item in listeSirket)
            {
                if (item.Ad == txtSirketAd.Text)
                {
                    item.Telefon = txtSirketTelefon.Text;
                    item.Adresi = txtSirketAdres.Text;
                    item.Eposta = txtSirketEposta.Text;
                    item.Faks = txtSirketFaks.Text;
                    MessageBox.Show("Güncelleme işlemi gerçekleşti");
                    SirketEkranTemizle();
                }
            }
            MessageBox.Show("Böyle bir kayıt bulunamadı");

        }

        private void btnSirketAra_Click(object sender, EventArgs e)
        {
            Sirket sirket;
            if (txtSirketAra.Text == "")
            {
                MessageBox.Show("Sirket ismini giriniz");
                return;
            }
            sirket=listeSirket.Find(x => x.Ad == txtSirketAra.Text);
            if(sirket == null)
            {
                MessageBox.Show("Aradığınız şirket sistemde kayıtlı değil!");
                SirketEkranTemizle();
            }
            else
            {
                txtSirketAd.Text = sirket.Ad;
                txtSirketAdres.Text = sirket.Adresi;
                txtSirketEposta.Text = sirket.Eposta;
                txtSirketTelefon.Text = sirket.Telefon;
                txtSirketFaks.Text = sirket.Faks;
            }
        }
        private void IlanEkranTemizle()
        {
            txtIlanElemanOzellik.Text = txtIlanIsTanimi.Text = txtIlanİsVerenPozisyon.Text= txtIlanNo.Text="";
        }
        private void btniIanEkle_Click(object sender, EventArgs e)
        {
            if (txtIlanIsTanimi.Text == "" || txtIlanIsyeriAdi.Text == "" || txtIlanIsTanimi.Text == "" || txtIlanElemanOzellik.Text == "")
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
                return;
            }
            sirket = listeSirket.Find(x => x.Ad == txtIlanIsyeriAdi.Text);
            Ilan ilan= hashtable.GetIlan(Convert.ToInt32(txtIlanNo.Text));
            if (sirket == null)
            {
                MessageBox.Show("Lütfen sisteme kayıtlı bir şirket ismi giriniz.");
            }
            else if (ilan != null)
            {
                MessageBox.Show("kayıtlı olmayan bir ilan numarası giriniz");
            }
            else 
            {
                ilan = new Ilan();
                ilan.IlanNo = Convert.ToInt32(txtIlanNo.Text);
                ilan.IsTanimi = txtIlanIsTanimi.Text;
                ilan.Pozisyon = txtIlanİsVerenPozisyon.Text;
                ilan.ElemanOzellik = txtIlanElemanOzellik.Text;
                ilan.sirket = sirket;
                hashtable.IlanEkleme(ilan.IlanNo, ilan);
                MessageBox.Show("İlanızı eklediniz");
                IlanEkranTemizle();
            }
            
           
        }

        private void btnIlanSil_Click(object sender, EventArgs e)
        {
            if (txtSilinecekIlanNo.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz ilan nosunu giriniz");
                return;
            }
            bool silinme = hashtable.IlanSilme(Convert.ToInt32(txtSilinecekIlanNo.Text));
            if (silinme == false)
            {
                MessageBox.Show("Böyle bir değer bulunamadı");
            }
            else
            {
                MessageBox.Show("Silindi");
                IlanSilEkranTemizle();
            }
        }
       
        private void btnIlanAra_Click(object sender, EventArgs e)
        {
            if (txtAraIlanNo.Text == "")
            {
                MessageBox.Show("Lütfen sistemde kayıtlı ilan numarası giriniz");
            }
            else
            {
                Ilan ilan = new Ilan();
                ilan = hashtable.GetIlan(Convert.ToInt32(txtAraIlanNo.Text));

                if (ilan == null)
                {
                    MessageBox.Show("Kayit bulunamadi");
                }
                else
                {
                    txtIlanNo.Text = ilan.IlanNo.ToString();
                    txtIlanIsyeriAdi.Text = ilan.sirket.Ad;
                    txtIlanIsTanimi.Text = ilan.IsTanimi;
                    txtIlanİsVerenPozisyon.Text = ilan.Pozisyon;
                    txtIlanElemanOzellik.Text = ilan.ElemanOzellik;
                }
            }
        }

        private void btnIlanGuncelle_Click(object sender, EventArgs e)
        {
            if (txtIlanNo.Text == "" || txtIlanIsyeriAdi.Text == "")
            {
                MessageBox.Show("Lütfen sistemde kayıtlı ilan bilgisi giriniz");
                return;
            }
            sirket = listeSirket.Find(x => x.Ad == txtIlanIsyeriAdi.Text);
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtIlanNo.Text));
            if (ilan == null || sirket==null)
            {
                MessageBox.Show("Kayit bulunamadi");
            }
            else if (ilan == null)
            {
                MessageBox.Show("Kayit bulunamadi");
            }
            else if (ilan.sirket == sirket)
            {
                ilan.sirket.Ad = txtIlanIsyeriAdi.Text;
                ilan.IsTanimi = txtIlanIsTanimi.Text;
                ilan.Pozisyon = txtIlanİsVerenPozisyon.Text;
                ilan.ElemanOzellik = txtIlanElemanOzellik.Text;
                MessageBox.Show("İlanınız Güncellendi...");
                IlanEkranTemizle();
            }
            else
            {
                MessageBox.Show("Bu iş yerine ait böyle bir ilan yok");
            }
        }

        private void btnPozisyonaGoreIlanListele_Click(object sender, EventArgs e)
        {
            if (txtPozisyonIlanListele.Text == "")
            {
                MessageBox.Show("lütfen sistemde kayıtlı bir pozisyon adı giriniz");
            }
            else
            {
                List<Ilan> ılans = new List<Ilan>();
                ılans = hashtable.pozisyonaListe(txtPozisyonIlanListele.Text);
                if (ılans == null)
                {
                    MessageBox.Show("lütfen sistemde kayıtlı bir pozisyon adı giriniz");
                }
                else
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ilan no", typeof(int));
                    table.Columns.Add("Sirket", typeof(string));
                    table.Columns.Add("Pozisyon", typeof(string));
                    table.Columns.Add("eleman özellikleri", typeof(string));
                    table.Columns.Add("İş Tanımı", typeof(string));

                    table.Rows.Clear();
                    foreach (var i in ılans)
                    {
                        table.Rows.Add(i.IlanNo, i.sirket.Ad, i.Pozisyon, i.ElemanOzellik, i.IsTanimi);

                    }

                    dgvIlanlar.DataSource = table;
                    txtPozisyonIlanListele.Text = "";

                }
            }
        }

        private void btnIseUygunAdayBul_Click(object sender, EventArgs e)
        {
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId));
            txtIseEnUygunAday.Text= ilan.Basvuru.UygunAday().TCKimlik +"nolu kişi en uygun kişi.";
            ListeleIdEkranTemizle();
        }

        private void btnIseAl_Click(object sender, EventArgs e)
        {
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId));
            ilan.Basvuru.RemoveMax();
            MessageBox.Show("En uygun aday işe alındı.");
            ListeleIdEkranTemizle();
        }

        private void btnBaşvuranTumİlanlarıGöster_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));

            tablo.Rows.Clear();
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId.Text));
            foreach (var i in ilan.Basvuru.BasvuruListele())
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }
            dgvIlanBasvuranKisiler.DataSource = tablo;
            ListeleIdEkranTemizle();
        }

        private void btnIlanListeleIkiYılDeneyim_Click(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));

            tablo.Rows.Clear();
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId));
            foreach (var i in ilan.Basvuru.BasvuruListele())
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }
            dgvIlanBasvuranKisiler.DataSource = tablo;
            ListeleIdEkranTemizle();
        }

       

        private void dgwIsYerleri_MouseClick(object sender, MouseEventArgs e)
        {
          
            txtIsDeneyimiIsyeriAdi.Text = dgwIsYerleri.SelectedRows[0].Cells[0].Value.ToString();
            txtIsDeneyimiIsyeriAdres.Text = dgwIsYerleri.SelectedRows[0].Cells[1].Value.ToString();
            txtIsDeneyimiPozisyon.Text = dgwIsYerleri.SelectedRows[0].Cells[2].Value.ToString();
            txtIsDeneyimiYil.Text = dgwIsYerleri.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void dgwEgitimBilgileri_MouseClick(object sender, MouseEventArgs e)
        {
            txtOkulAdi.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[0].Value.ToString();
            txtBolum.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[1].Value.ToString();
            txtBaslangicTarih.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[2].Value.ToString();
            txtBitisTarih.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[3].Value.ToString();
            txtNotOrtalamasi.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void gpIsBasvuranillgiler_Enter(object sender, EventArgs e)
        {

        }

        private void gpIsYeriIlanAra_Enter(object sender, EventArgs e)
        {

        }

        private void dgwIsYerleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBaşvuranTumİlanlarıGöster_Click_1(object sender, EventArgs e)
        {
            if (txtListeleId.Text == "")
            {
                MessageBox.Show("lütfen listelemek istediğiniz ilanın ıdsini giriniz");
                return;
            }
            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));

            tablo.Rows.Clear();
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId.Text));
            if (ilan == null)
            {
                MessageBox.Show("Bu id ye ait kayıtlı ilan yok");
                return;
            }
            foreach (var i in ilan.Basvuru.BasvuruListele())
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }
            dgvIlanBasvuranKisiler.DataSource = tablo;
            ListeleIdEkranTemizle();
        }

        private void btnIlanListeleIkiYılDeneyim_Click_1(object sender, EventArgs e)
        {
            if (txtListeleId.Text == "")
            {
                MessageBox.Show("lütfen listelemek istediğiniz ilanın ıdsini giriniz");
                return;
            }
            DataTable tablo = new DataTable();
            tablo.Columns.Add("TCKimlik", typeof(string));
            tablo.Columns.Add("Ad", typeof(string));
            tablo.Columns.Add("Soyad", typeof(string));
            tablo.Columns.Add("Adres", typeof(string));
            tablo.Columns.Add("Telefon", typeof(string));
            tablo.Columns.Add("E_posta", typeof(string));
            tablo.Columns.Add("Referans", typeof(string));
            tablo.Columns.Add("DogumTarihi", typeof(string));
            tablo.Columns.Add("DogumYeri", typeof(string));
            tablo.Columns.Add("IlgiAlanlari", typeof(string));
            tablo.Columns.Add("Uyruk", typeof(string));
            tablo.Rows.Clear();
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId.Text));
            if (ilan == null)
            {
                MessageBox.Show("Bu id ye ait kayıtlı ilan yok");
                return;
            }
            foreach (var i in ilan.Basvuru.ikiYılveüzeriDeneyimListele())
            {
                tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

            }
            dgvIlanBasvuranKisiler.DataSource = tablo;
            ListeleIdEkranTemizle();
        }

        private void btnIlanListeleDileGore_Click_1(object sender, EventArgs e)
        {
            if (txtListeleId.Text == "")
            {
                MessageBox.Show("lütfen listelemek istediğiniz ilanın ıdsini giriniz");
            }
            else
            {

                DataTable tablo = new DataTable();
                tablo.Columns.Add("TCKimlik", typeof(string));
                tablo.Columns.Add("Ad", typeof(string));
                tablo.Columns.Add("Soyad", typeof(string));
                tablo.Columns.Add("Adres", typeof(string));
                tablo.Columns.Add("Telefon", typeof(string));
                tablo.Columns.Add("E_posta", typeof(string));
                tablo.Columns.Add("Referans", typeof(string));
                tablo.Columns.Add("DogumTarihi", typeof(string));
                tablo.Columns.Add("DogumYeri", typeof(string));
                tablo.Columns.Add("IlgiAlanlari", typeof(string));
                tablo.Columns.Add("Uyruk", typeof(string));
                tablo.Rows.Clear();
                Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId.Text));
                if (ilan == null)
                {
                    MessageBox.Show("Bu id ye ait kayıtlı ilan yok");
                    return;
                }
                foreach (var i in ilan.Basvuru.YabancıDilBilenleriListele(txtIstenenDil.Text))
                {
                    tablo.Rows.Add(i.TCKimlik, i.Ad, i.Soyad, i.Adres, i.Telefon, i.E_posta, i.Referans, i.DogumTarihi, i.DogumYeri, i.IlgiAlanlari, i.Uyruk);

                }
                dgvIlanBasvuranKisiler.DataSource = tablo;
                ListeleIdEkranTemizle();
            }
        }
        
        private void btnIseUygunAdayBul_Click_1(object sender, EventArgs e)
        {
            if (txtListeleId.Text == "")
            {
                MessageBox.Show("lütfen listelemek istediğiniz ilanın ıdsini giriniz");
                return;
            }
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(txtListeleId.Text));
            if (ilan == null)
            {
                MessageBox.Show("Bu id ye ait kayıtlı ilan yok");
                return;
            }
            txtIseEnUygunAday.Text = ilan.Basvuru.UygunAday().TCKimlik + "nolu kişi en uygun kişi.";
            ListeleIdEkranTemizle();
        }

        private void btnIseAl_Click_1(object sender, EventArgs e)
        {
            if (txtListeleId.Text == "")
            {
                MessageBox.Show("lütfen listelemek istediğiniz ilanın ıdsini giriniz");
                return;
            }
            Ilan ilan = hashtable.GetIlan(Convert.ToInt32(Convert.ToInt32(txtListeleId.Text)));
            if (ilan == null)
            {
                MessageBox.Show("Bu id ye ait kayıtlı ilan yok");
                return;
            }
            ilan.Basvuru.RemoveMax();
            MessageBox.Show("En uygun aday işe alındı.");
            hashtable.IlanSilme(Convert.ToInt32(txtListeleId.Text));
            ListeleIdEkranTemizle();
        }

        private void dgwIsYerleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIsDeneyimiIsyeriAdi.Text = dgwIsYerleri.SelectedRows[0].Cells[0].Value.ToString();
            txtIsDeneyimiIsyeriAdres.Text = dgwIsYerleri.SelectedRows[0].Cells[1].Value.ToString();
            txtIsDeneyimiPozisyon.Text = dgwIsYerleri.SelectedRows[0].Cells[2].Value.ToString();
            txtIsDeneyimiYil.Text = dgwIsYerleri.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void dgwEgitimBilgileri_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtOkulAdi.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[0].Value.ToString();
            txtBolum.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[1].Value.ToString();
            txtBaslangicTarih.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[2].Value.ToString();
            txtBitisTarih.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[3].Value.ToString();
            txtNotOrtalamasi.Text = dgwEgitimBilgileri.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
