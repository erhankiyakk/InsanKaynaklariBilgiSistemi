namespace VeriYapilariProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tpKisileriListele = new System.Windows.Forms.TabPage();
            this.gpKisileriGetir = new System.Windows.Forms.GroupBox();
            this.dgvKisiler = new System.Windows.Forms.DataGridView();
            this.btnDerinlik = new System.Windows.Forms.Button();
            this.btnElemanSayisi = new System.Windows.Forms.Button();
            this.btnPostOrder = new System.Windows.Forms.Button();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.btnInorder = new System.Windows.Forms.Button();
            this.tpIsBasvuranIlanIslemleri = new System.Windows.Forms.TabPage();
            this.gpIlanListelemeSecenekleri = new System.Windows.Forms.GroupBox();
            this.dgvIlanBasvuranKisiler = new System.Windows.Forms.DataGridView();
            this.txtListeleId = new System.Windows.Forms.TextBox();
            this.btnIseUygunAdayBul = new System.Windows.Forms.Button();
            this.lblListele = new System.Windows.Forms.Label();
            this.btnBaşvuranTumİlanlarıGöster = new System.Windows.Forms.Button();
            this.btnIlanListeleDileGore = new System.Windows.Forms.Button();
            this.btnIlanListeleIkiYılDeneyim = new System.Windows.Forms.Button();
            this.txtIstenenDil = new System.Windows.Forms.TextBox();
            this.txtIseEnUygunAday = new System.Windows.Forms.TextBox();
            this.lblIstenenDil = new System.Windows.Forms.Label();
            this.btnIseAl = new System.Windows.Forms.Button();
            this.lblEnUygunAday = new System.Windows.Forms.Label();
            this.gpIlanSil = new System.Windows.Forms.GroupBox();
            this.btnIlanSil = new System.Windows.Forms.Button();
            this.txtSilinecekIlanNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpIlanAra = new System.Windows.Forms.GroupBox();
            this.btnIlanAra = new System.Windows.Forms.Button();
            this.txtAraIlanNo = new System.Windows.Forms.TextBox();
            this.lblIlanAraIsYeri = new System.Windows.Forms.Label();
            this.gbIlanVer = new System.Windows.Forms.GroupBox();
            this.lblIlanNo = new System.Windows.Forms.Label();
            this.txtIlanNo = new System.Windows.Forms.TextBox();
            this.btnIlanGuncelle = new System.Windows.Forms.Button();
            this.lblIlanPozisyon = new System.Windows.Forms.Label();
            this.txtIlanElemanOzellik = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.lblIlanIsYeriAd = new System.Windows.Forms.Label();
            this.txtIlanIsyeriAdi = new System.Windows.Forms.TextBox();
            this.txtIlanİsVerenPozisyon = new System.Windows.Forms.TextBox();
            this.lblIsTanimi = new System.Windows.Forms.Label();
            this.btniIanEkle = new System.Windows.Forms.Button();
            this.txtIlanIsTanimi = new System.Windows.Forms.TextBox();
            this.tpSirketBul = new System.Windows.Forms.TabPage();
            this.gpIsyeriBul = new System.Windows.Forms.GroupBox();
            this.btnSirketAra = new System.Windows.Forms.Button();
            this.txtSirketAra = new System.Windows.Forms.TextBox();
            this.lblSirketAdGunc = new System.Windows.Forms.Label();
            this.gbSirketIslemleri = new System.Windows.Forms.GroupBox();
            this.btnSirketSil = new System.Windows.Forms.Button();
            this.btnSirketGuncelle = new System.Windows.Forms.Button();
            this.btnSirketEkle = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.txtSirketAd = new System.Windows.Forms.TextBox();
            this.txtSirketEposta = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtSirketAdres = new System.Windows.Forms.TextBox();
            this.txtSirketFaks = new System.Windows.Forms.TextBox();
            this.txtSirketTelefon = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tpIsIlan = new System.Windows.Forms.TabPage();
            this.gpBasvur = new System.Windows.Forms.GroupBox();
            this.btnBasvuruYap = new System.Windows.Forms.Button();
            this.txtBasvurAd = new System.Windows.Forms.TextBox();
            this.lblBasvurAd = new System.Windows.Forms.Label();
            this.txtBasvurTc = new System.Windows.Forms.TextBox();
            this.lblBasvurTc = new System.Windows.Forms.Label();
            this.lblBasvurSoyad = new System.Windows.Forms.Label();
            this.txtBasvurSoyad = new System.Windows.Forms.TextBox();
            this.gpIsYeriIlanAra = new System.Windows.Forms.GroupBox();
            this.btnIsYeriAdinaGoreIlanListele = new System.Windows.Forms.Button();
            this.lblIsyeriAdiİlanListeleme = new System.Windows.Forms.Label();
            this.dgvIlanlar = new System.Windows.Forms.DataGridView();
            this.btnPozisyonaGoreIlanListele = new System.Windows.Forms.Button();
            this.txtIsYeriAdIlanListeleme = new System.Windows.Forms.TextBox();
            this.lblPozisyonIlanlar = new System.Windows.Forms.Label();
            this.txtPozisyonIlanListele = new System.Windows.Forms.TextBox();
            this.tpIsBasvuramIslemler = new System.Windows.Forms.TabPage();
            this.gpIsBasvuranillgiler = new System.Windows.Forms.GroupBox();
            this.gpKisiSil = new System.Windows.Forms.GroupBox();
            this.btnIsBasvuranSil = new System.Windows.Forms.Button();
            this.txtSilinecekKisiTc = new System.Windows.Forms.TextBox();
            this.lblSilinecekKisiTc = new System.Windows.Forms.Label();
            this.gpKisiAra = new System.Windows.Forms.GroupBox();
            this.btnKisiAra = new System.Windows.Forms.Button();
            this.txtKisiAra = new System.Windows.Forms.TextBox();
            this.lblKisiAraTC = new System.Windows.Forms.Label();
            this.btnIsBasvuranKaydet = new System.Windows.Forms.Button();
            this.grpIsDeneyimleri = new System.Windows.Forms.GroupBox();
            this.dgwIsYerleri = new System.Windows.Forms.DataGridView();
            this.txtIsTC = new System.Windows.Forms.TextBox();
            this.lblIsTC = new System.Windows.Forms.Label();
            this.txtIsDeneyimiYil = new System.Windows.Forms.TextBox();
            this.lbYıl = new System.Windows.Forms.Label();
            this.btnIsBilgisiEkle = new System.Windows.Forms.Button();
            this.btnIsBilGoster = new System.Windows.Forms.Button();
            this.btnIsBilgisiGuncelle = new System.Windows.Forms.Button();
            this.txtIsDeneyimiPozisyon = new System.Windows.Forms.TextBox();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.txtIsDeneyimiIsyeriAdi = new System.Windows.Forms.TextBox();
            this.txtIsDeneyimiIsyeriAdres = new System.Windows.Forms.TextBox();
            this.lblIsYeriAd = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.btnIsBasvuranGuncelle = new System.Windows.Forms.Button();
            this.gpEgitimBilgileri = new System.Windows.Forms.GroupBox();
            this.dgwEgitimBilgileri = new System.Windows.Forms.DataGridView();
            this.txtEgitimTC = new System.Windows.Forms.TextBox();
            this.lblEgitimTC = new System.Windows.Forms.Label();
            this.btnEgitimBİlgisiEkle = new System.Windows.Forms.Button();
            this.btnEgitimBilgisiGoster = new System.Windows.Forms.Button();
            this.btnEgitimBilgisiGuncelle = new System.Windows.Forms.Button();
            this.txtNotOrtalamasi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBitisTarih = new System.Windows.Forms.TextBox();
            this.txtOkulAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBaslangicTarih = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.grpKayitOl = new System.Windows.Forms.GroupBox();
            this.cbDige = new System.Windows.Forms.CheckBox();
            this.cbAlmanca = new System.Windows.Forms.CheckBox();
            this.cbIngilizce = new System.Windows.Forms.CheckBox();
            this.txtReferans = new System.Windows.Forms.TextBox();
            this.lblReferans = new System.Windows.Forms.Label();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblTc = new System.Windows.Forms.Label();
            this.txtGunReferans = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label21 = new System.Windows.Forms.Label();
            this.lblDogumTarih = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.lblYabanciDil = new System.Windows.Forms.Label();
            this.txtIlgiAlanlari = new System.Windows.Forms.TextBox();
            this.lblIlgiAlani = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblCalisanAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.tpIslemler = new System.Windows.Forms.TabControl();
            this.tpKisileriListele.SuspendLayout();
            this.gpKisileriGetir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).BeginInit();
            this.tpIsBasvuranIlanIslemleri.SuspendLayout();
            this.gpIlanListelemeSecenekleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanBasvuranKisiler)).BeginInit();
            this.gpIlanSil.SuspendLayout();
            this.gpIlanAra.SuspendLayout();
            this.gbIlanVer.SuspendLayout();
            this.tpSirketBul.SuspendLayout();
            this.gpIsyeriBul.SuspendLayout();
            this.gbSirketIslemleri.SuspendLayout();
            this.tpIsIlan.SuspendLayout();
            this.gpBasvur.SuspendLayout();
            this.gpIsYeriIlanAra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).BeginInit();
            this.tpIsBasvuramIslemler.SuspendLayout();
            this.gpIsBasvuranillgiler.SuspendLayout();
            this.gpKisiSil.SuspendLayout();
            this.gpKisiAra.SuspendLayout();
            this.grpIsDeneyimleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIsYerleri)).BeginInit();
            this.gpEgitimBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEgitimBilgileri)).BeginInit();
            this.grpKayitOl.SuspendLayout();
            this.tpIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpKisileriListele
            // 
            this.tpKisileriListele.BackColor = System.Drawing.Color.Gray;
            this.tpKisileriListele.Controls.Add(this.gpKisileriGetir);
            this.tpKisileriListele.Location = new System.Drawing.Point(4, 25);
            this.tpKisileriListele.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpKisileriListele.Name = "tpKisileriListele";
            this.tpKisileriListele.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpKisileriListele.Size = new System.Drawing.Size(1523, 679);
            this.tpKisileriListele.TabIndex = 4;
            this.tpKisileriListele.Text = "İş Arayan Kişiler";
            // 
            // gpKisileriGetir
            // 
            this.gpKisileriGetir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gpKisileriGetir.Controls.Add(this.dgvKisiler);
            this.gpKisileriGetir.Controls.Add(this.btnDerinlik);
            this.gpKisileriGetir.Controls.Add(this.btnElemanSayisi);
            this.gpKisileriGetir.Controls.Add(this.btnPostOrder);
            this.gpKisileriGetir.Controls.Add(this.btnPreorder);
            this.gpKisileriGetir.Controls.Add(this.btnInorder);
            this.gpKisileriGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpKisileriGetir.Location = new System.Drawing.Point(32, 54);
            this.gpKisileriGetir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpKisileriGetir.Name = "gpKisileriGetir";
            this.gpKisileriGetir.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpKisileriGetir.Size = new System.Drawing.Size(819, 580);
            this.gpKisileriGetir.TabIndex = 0;
            this.gpKisileriGetir.TabStop = false;
            this.gpKisileriGetir.Text = "Tum Kişiler Listesi";
            // 
            // dgvKisiler
            // 
            this.dgvKisiler.AllowUserToAddRows = false;
            this.dgvKisiler.AllowUserToDeleteRows = false;
            this.dgvKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKisiler.Location = new System.Drawing.Point(23, 252);
            this.dgvKisiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKisiler.Name = "dgvKisiler";
            this.dgvKisiler.ReadOnly = true;
            this.dgvKisiler.RowTemplate.Height = 24;
            this.dgvKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKisiler.Size = new System.Drawing.Size(752, 302);
            this.dgvKisiler.TabIndex = 1;
            // 
            // btnDerinlik
            // 
            this.btnDerinlik.BackColor = System.Drawing.Color.LightBlue;
            this.btnDerinlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDerinlik.Location = new System.Drawing.Point(105, 127);
            this.btnDerinlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDerinlik.Name = "btnDerinlik";
            this.btnDerinlik.Size = new System.Drawing.Size(259, 48);
            this.btnDerinlik.TabIndex = 4;
            this.btnDerinlik.Text = "Ağaç Derinliği";
            this.btnDerinlik.UseVisualStyleBackColor = false;
            this.btnDerinlik.Click += new System.EventHandler(this.btnDerinlik_Click);
            // 
            // btnElemanSayisi
            // 
            this.btnElemanSayisi.BackColor = System.Drawing.Color.LightBlue;
            this.btnElemanSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnElemanSayisi.Location = new System.Drawing.Point(401, 127);
            this.btnElemanSayisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElemanSayisi.Name = "btnElemanSayisi";
            this.btnElemanSayisi.Size = new System.Drawing.Size(259, 48);
            this.btnElemanSayisi.TabIndex = 5;
            this.btnElemanSayisi.Text = "Eleman Sayısı";
            this.btnElemanSayisi.UseVisualStyleBackColor = false;
            this.btnElemanSayisi.Click += new System.EventHandler(this.btnElemanSayisi_Click);
            // 
            // btnPostOrder
            // 
            this.btnPostOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPostOrder.Location = new System.Drawing.Point(516, 54);
            this.btnPostOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPostOrder.Name = "btnPostOrder";
            this.btnPostOrder.Size = new System.Drawing.Size(259, 48);
            this.btnPostOrder.TabIndex = 3;
            this.btnPostOrder.Text = "PostOrder Listele";
            this.btnPostOrder.UseVisualStyleBackColor = false;
            this.btnPostOrder.Click += new System.EventHandler(this.btnPostOrder_Click);
            // 
            // btnPreorder
            // 
            this.btnPreorder.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPreorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPreorder.Location = new System.Drawing.Point(23, 54);
            this.btnPreorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(213, 48);
            this.btnPreorder.TabIndex = 1;
            this.btnPreorder.Text = "PreOrder Listele";
            this.btnPreorder.UseVisualStyleBackColor = false;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // btnInorder
            // 
            this.btnInorder.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInorder.Location = new System.Drawing.Point(243, 54);
            this.btnInorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInorder.Name = "btnInorder";
            this.btnInorder.Size = new System.Drawing.Size(259, 48);
            this.btnInorder.TabIndex = 2;
            this.btnInorder.Text = "InOrder Listele";
            this.btnInorder.UseVisualStyleBackColor = false;
            this.btnInorder.Click += new System.EventHandler(this.btnInorder_Click);
            // 
            // tpIsBasvuranIlanIslemleri
            // 
            this.tpIsBasvuranIlanIslemleri.BackColor = System.Drawing.Color.Gray;
            this.tpIsBasvuranIlanIslemleri.Controls.Add(this.gpIlanListelemeSecenekleri);
            this.tpIsBasvuranIlanIslemleri.Controls.Add(this.gpIlanSil);
            this.tpIsBasvuranIlanIslemleri.Controls.Add(this.gpIlanAra);
            this.tpIsBasvuranIlanIslemleri.Controls.Add(this.gbIlanVer);
            this.tpIsBasvuranIlanIslemleri.Location = new System.Drawing.Point(4, 25);
            this.tpIsBasvuranIlanIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIsBasvuranIlanIslemleri.Name = "tpIsBasvuranIlanIslemleri";
            this.tpIsBasvuranIlanIslemleri.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIsBasvuranIlanIslemleri.Size = new System.Drawing.Size(1523, 679);
            this.tpIsBasvuranIlanIslemleri.TabIndex = 3;
            this.tpIsBasvuranIlanIslemleri.Text = "İş Veren İlan İşlemleri";
            // 
            // gpIlanListelemeSecenekleri
            // 
            this.gpIlanListelemeSecenekleri.BackColor = System.Drawing.Color.Salmon;
            this.gpIlanListelemeSecenekleri.Controls.Add(this.dgvIlanBasvuranKisiler);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.txtListeleId);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.btnIseUygunAdayBul);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.lblListele);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.btnBaşvuranTumİlanlarıGöster);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.btnIlanListeleDileGore);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.btnIlanListeleIkiYılDeneyim);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.txtIstenenDil);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.txtIseEnUygunAday);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.lblIstenenDil);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.btnIseAl);
            this.gpIlanListelemeSecenekleri.Controls.Add(this.lblEnUygunAday);
            this.gpIlanListelemeSecenekleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpIlanListelemeSecenekleri.Location = new System.Drawing.Point(897, 22);
            this.gpIlanListelemeSecenekleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpIlanListelemeSecenekleri.Name = "gpIlanListelemeSecenekleri";
            this.gpIlanListelemeSecenekleri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpIlanListelemeSecenekleri.Size = new System.Drawing.Size(648, 650);
            this.gpIlanListelemeSecenekleri.TabIndex = 64;
            this.gpIlanListelemeSecenekleri.TabStop = false;
            this.gpIlanListelemeSecenekleri.Text = "İlan Listeleme Seçenekleri";
            // 
            // dgvIlanBasvuranKisiler
            // 
            this.dgvIlanBasvuranKisiler.AllowUserToAddRows = false;
            this.dgvIlanBasvuranKisiler.AllowUserToDeleteRows = false;
            this.dgvIlanBasvuranKisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlanBasvuranKisiler.Location = new System.Drawing.Point(52, 384);
            this.dgvIlanBasvuranKisiler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIlanBasvuranKisiler.Name = "dgvIlanBasvuranKisiler";
            this.dgvIlanBasvuranKisiler.ReadOnly = true;
            this.dgvIlanBasvuranKisiler.RowTemplate.Height = 24;
            this.dgvIlanBasvuranKisiler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIlanBasvuranKisiler.Size = new System.Drawing.Size(548, 230);
            this.dgvIlanBasvuranKisiler.TabIndex = 55;
            // 
            // txtListeleId
            // 
            this.txtListeleId.Location = new System.Drawing.Point(60, 33);
            this.txtListeleId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtListeleId.Multiline = true;
            this.txtListeleId.Name = "txtListeleId";
            this.txtListeleId.Size = new System.Drawing.Size(131, 25);
            this.txtListeleId.TabIndex = 71;
            // 
            // btnIseUygunAdayBul
            // 
            this.btnIseUygunAdayBul.BackColor = System.Drawing.Color.Turquoise;
            this.btnIseUygunAdayBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIseUygunAdayBul.Location = new System.Drawing.Point(84, 228);
            this.btnIseUygunAdayBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIseUygunAdayBul.Name = "btnIseUygunAdayBul";
            this.btnIseUygunAdayBul.Size = new System.Drawing.Size(192, 86);
            this.btnIseUygunAdayBul.TabIndex = 70;
            this.btnIseUygunAdayBul.Text = "İşe Uygun Adayı Bul";
            this.btnIseUygunAdayBul.UseVisualStyleBackColor = false;
            this.btnIseUygunAdayBul.Click += new System.EventHandler(this.btnIseUygunAdayBul_Click_1);
            // 
            // lblListele
            // 
            this.lblListele.AutoSize = true;
            this.lblListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListele.Location = new System.Drawing.Point(4, 33);
            this.lblListele.Name = "lblListele";
            this.lblListele.Size = new System.Drawing.Size(54, 17);
            this.lblListele.TabIndex = 60;
            this.lblListele.Text = "ilan ID";
            // 
            // btnBaşvuranTumİlanlarıGöster
            // 
            this.btnBaşvuranTumİlanlarıGöster.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBaşvuranTumİlanlarıGöster.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaşvuranTumİlanlarıGöster.Location = new System.Drawing.Point(52, 78);
            this.btnBaşvuranTumİlanlarıGöster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBaşvuranTumİlanlarıGöster.Name = "btnBaşvuranTumİlanlarıGöster";
            this.btnBaşvuranTumİlanlarıGöster.Size = new System.Drawing.Size(147, 76);
            this.btnBaşvuranTumİlanlarıGöster.TabIndex = 62;
            this.btnBaşvuranTumİlanlarıGöster.Text = "Tüm İşe Başvuran Adayları Listele ";
            this.btnBaşvuranTumİlanlarıGöster.UseVisualStyleBackColor = false;
            this.btnBaşvuranTumİlanlarıGöster.Click += new System.EventHandler(this.btnBaşvuranTumİlanlarıGöster_Click_1);
            // 
            // btnIlanListeleDileGore
            // 
            this.btnIlanListeleDileGore.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIlanListeleDileGore.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanListeleDileGore.Location = new System.Drawing.Point(251, 76);
            this.btnIlanListeleDileGore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlanListeleDileGore.Name = "btnIlanListeleDileGore";
            this.btnIlanListeleDileGore.Size = new System.Drawing.Size(149, 74);
            this.btnIlanListeleDileGore.TabIndex = 69;
            this.btnIlanListeleDileGore.Text = "Dİle Göre İlan Listele";
            this.btnIlanListeleDileGore.UseVisualStyleBackColor = false;
            this.btnIlanListeleDileGore.Click += new System.EventHandler(this.btnIlanListeleDileGore_Click_1);
            // 
            // btnIlanListeleIkiYılDeneyim
            // 
            this.btnIlanListeleIkiYılDeneyim.Location = new System.Drawing.Point(435, 78);
            this.btnIlanListeleIkiYılDeneyim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlanListeleIkiYılDeneyim.Name = "btnIlanListeleIkiYılDeneyim";
            this.btnIlanListeleIkiYılDeneyim.Size = new System.Drawing.Size(165, 74);
            this.btnIlanListeleIkiYılDeneyim.TabIndex = 68;
            this.btnIlanListeleIkiYılDeneyim.Text = "2 Yıl Deneyimi Olanlari Listele";
            this.btnIlanListeleIkiYılDeneyim.UseVisualStyleBackColor = true;
            this.btnIlanListeleIkiYılDeneyim.Click += new System.EventHandler(this.btnIlanListeleIkiYılDeneyim_Click_1);
            // 
            // txtIstenenDil
            // 
            this.txtIstenenDil.Location = new System.Drawing.Point(313, 23);
            this.txtIstenenDil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIstenenDil.Multiline = true;
            this.txtIstenenDil.Name = "txtIstenenDil";
            this.txtIstenenDil.Size = new System.Drawing.Size(131, 25);
            this.txtIstenenDil.TabIndex = 67;
            // 
            // txtIseEnUygunAday
            // 
            this.txtIseEnUygunAday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIseEnUygunAday.Location = new System.Drawing.Point(297, 188);
            this.txtIseEnUygunAday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIseEnUygunAday.Multiline = true;
            this.txtIseEnUygunAday.Name = "txtIseEnUygunAday";
            this.txtIseEnUygunAday.Size = new System.Drawing.Size(208, 20);
            this.txtIseEnUygunAday.TabIndex = 64;
            // 
            // lblIstenenDil
            // 
            this.lblIstenenDil.AutoSize = true;
            this.lblIstenenDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIstenenDil.Location = new System.Drawing.Point(224, 31);
            this.lblIstenenDil.Name = "lblIstenenDil";
            this.lblIstenenDil.Size = new System.Drawing.Size(85, 17);
            this.lblIstenenDil.TabIndex = 66;
            this.lblIstenenDil.Text = "İstenen Dil";
            // 
            // btnIseAl
            // 
            this.btnIseAl.BackColor = System.Drawing.Color.Lime;
            this.btnIseAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIseAl.Location = new System.Drawing.Point(313, 228);
            this.btnIseAl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIseAl.Name = "btnIseAl";
            this.btnIseAl.Size = new System.Drawing.Size(192, 86);
            this.btnIseAl.TabIndex = 65;
            this.btnIseAl.Text = "İşe Al";
            this.btnIseAl.UseVisualStyleBackColor = false;
            this.btnIseAl.Click += new System.EventHandler(this.btnIseAl_Click_1);
            // 
            // lblEnUygunAday
            // 
            this.lblEnUygunAday.AutoSize = true;
            this.lblEnUygunAday.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnUygunAday.Location = new System.Drawing.Point(148, 188);
            this.lblEnUygunAday.Name = "lblEnUygunAday";
            this.lblEnUygunAday.Size = new System.Drawing.Size(145, 17);
            this.lblEnUygunAday.TabIndex = 63;
            this.lblEnUygunAday.Text = "İşe En Uygun Aday";
            // 
            // gpIlanSil
            // 
            this.gpIlanSil.BackColor = System.Drawing.Color.Salmon;
            this.gpIlanSil.Controls.Add(this.btnIlanSil);
            this.gpIlanSil.Controls.Add(this.txtSilinecekIlanNo);
            this.gpIlanSil.Controls.Add(this.label1);
            this.gpIlanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpIlanSil.Location = new System.Drawing.Point(488, 292);
            this.gpIlanSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpIlanSil.Name = "gpIlanSil";
            this.gpIlanSil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpIlanSil.Size = new System.Drawing.Size(401, 164);
            this.gpIlanSil.TabIndex = 63;
            this.gpIlanSil.TabStop = false;
            this.gpIlanSil.Text = "İlan Sil";
            // 
            // btnIlanSil
            // 
            this.btnIlanSil.BackColor = System.Drawing.Color.Red;
            this.btnIlanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanSil.Location = new System.Drawing.Point(127, 89);
            this.btnIlanSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlanSil.Name = "btnIlanSil";
            this.btnIlanSil.Size = new System.Drawing.Size(243, 57);
            this.btnIlanSil.TabIndex = 20;
            this.btnIlanSil.Text = "İlan Sil";
            this.btnIlanSil.UseVisualStyleBackColor = false;
            this.btnIlanSil.Click += new System.EventHandler(this.btnIlanSil_Click);
            // 
            // txtSilinecekIlanNo
            // 
            this.txtSilinecekIlanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilinecekIlanNo.Location = new System.Drawing.Point(127, 34);
            this.txtSilinecekIlanNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSilinecekIlanNo.Name = "txtSilinecekIlanNo";
            this.txtSilinecekIlanNo.Size = new System.Drawing.Size(243, 23);
            this.txtSilinecekIlanNo.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 58;
            this.label1.Text = "İlan Numarası";
            // 
            // gpIlanAra
            // 
            this.gpIlanAra.BackColor = System.Drawing.Color.Salmon;
            this.gpIlanAra.Controls.Add(this.btnIlanAra);
            this.gpIlanAra.Controls.Add(this.txtAraIlanNo);
            this.gpIlanAra.Controls.Add(this.lblIlanAraIsYeri);
            this.gpIlanAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpIlanAra.Location = new System.Drawing.Point(493, 22);
            this.gpIlanAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpIlanAra.Name = "gpIlanAra";
            this.gpIlanAra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpIlanAra.Size = new System.Drawing.Size(396, 183);
            this.gpIlanAra.TabIndex = 33;
            this.gpIlanAra.TabStop = false;
            this.gpIlanAra.Text = "İlanı Bul";
            // 
            // btnIlanAra
            // 
            this.btnIlanAra.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnIlanAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanAra.Location = new System.Drawing.Point(21, 75);
            this.btnIlanAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlanAra.Name = "btnIlanAra";
            this.btnIlanAra.Size = new System.Drawing.Size(349, 94);
            this.btnIlanAra.TabIndex = 32;
            this.btnIlanAra.Text = "İlan Ara";
            this.btnIlanAra.UseVisualStyleBackColor = false;
            this.btnIlanAra.Click += new System.EventHandler(this.btnIlanAra_Click);
            // 
            // txtAraIlanNo
            // 
            this.txtAraIlanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAraIlanNo.Location = new System.Drawing.Point(111, 31);
            this.txtAraIlanNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAraIlanNo.Name = "txtAraIlanNo";
            this.txtAraIlanNo.Size = new System.Drawing.Size(259, 23);
            this.txtAraIlanNo.TabIndex = 30;
            // 
            // lblIlanAraIsYeri
            // 
            this.lblIlanAraIsYeri.AutoSize = true;
            this.lblIlanAraIsYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanAraIsYeri.Location = new System.Drawing.Point(7, 36);
            this.lblIlanAraIsYeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIlanAraIsYeri.Name = "lblIlanAraIsYeri";
            this.lblIlanAraIsYeri.Size = new System.Drawing.Size(107, 17);
            this.lblIlanAraIsYeri.TabIndex = 31;
            this.lblIlanAraIsYeri.Text = "ilan Numarası";
            // 
            // gbIlanVer
            // 
            this.gbIlanVer.BackColor = System.Drawing.Color.Salmon;
            this.gbIlanVer.Controls.Add(this.lblIlanNo);
            this.gbIlanVer.Controls.Add(this.txtIlanNo);
            this.gbIlanVer.Controls.Add(this.btnIlanGuncelle);
            this.gbIlanVer.Controls.Add(this.lblIlanPozisyon);
            this.gbIlanVer.Controls.Add(this.txtIlanElemanOzellik);
            this.gbIlanVer.Controls.Add(this.label35);
            this.gbIlanVer.Controls.Add(this.lblIlanIsYeriAd);
            this.gbIlanVer.Controls.Add(this.txtIlanIsyeriAdi);
            this.gbIlanVer.Controls.Add(this.txtIlanİsVerenPozisyon);
            this.gbIlanVer.Controls.Add(this.lblIsTanimi);
            this.gbIlanVer.Controls.Add(this.btniIanEkle);
            this.gbIlanVer.Controls.Add(this.txtIlanIsTanimi);
            this.gbIlanVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbIlanVer.Location = new System.Drawing.Point(21, 22);
            this.gbIlanVer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIlanVer.Name = "gbIlanVer";
            this.gbIlanVer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbIlanVer.Size = new System.Drawing.Size(441, 433);
            this.gbIlanVer.TabIndex = 15;
            this.gbIlanVer.TabStop = false;
            this.gbIlanVer.Text = "İlan Ver";
            // 
            // lblIlanNo
            // 
            this.lblIlanNo.AutoSize = true;
            this.lblIlanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanNo.Location = new System.Drawing.Point(29, 46);
            this.lblIlanNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIlanNo.Name = "lblIlanNo";
            this.lblIlanNo.Size = new System.Drawing.Size(107, 17);
            this.lblIlanNo.TabIndex = 22;
            this.lblIlanNo.Text = "İlan Numarası";
            // 
            // txtIlanNo
            // 
            this.txtIlanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlanNo.Location = new System.Drawing.Point(157, 41);
            this.txtIlanNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlanNo.Name = "txtIlanNo";
            this.txtIlanNo.Size = new System.Drawing.Size(243, 23);
            this.txtIlanNo.TabIndex = 21;
            // 
            // btnIlanGuncelle
            // 
            this.btnIlanGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIlanGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIlanGuncelle.Location = new System.Drawing.Point(224, 308);
            this.btnIlanGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIlanGuncelle.Name = "btnIlanGuncelle";
            this.btnIlanGuncelle.Size = new System.Drawing.Size(176, 95);
            this.btnIlanGuncelle.TabIndex = 19;
            this.btnIlanGuncelle.Text = "İlan Güncelle";
            this.btnIlanGuncelle.UseVisualStyleBackColor = false;
            this.btnIlanGuncelle.Click += new System.EventHandler(this.btnIlanGuncelle_Click);
            // 
            // lblIlanPozisyon
            // 
            this.lblIlanPozisyon.AutoSize = true;
            this.lblIlanPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanPozisyon.Location = new System.Drawing.Point(29, 196);
            this.lblIlanPozisyon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIlanPozisyon.Name = "lblIlanPozisyon";
            this.lblIlanPozisyon.Size = new System.Drawing.Size(73, 17);
            this.lblIlanPozisyon.TabIndex = 18;
            this.lblIlanPozisyon.Text = "Pozisyon";
            // 
            // txtIlanElemanOzellik
            // 
            this.txtIlanElemanOzellik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlanElemanOzellik.Location = new System.Drawing.Point(157, 249);
            this.txtIlanElemanOzellik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlanElemanOzellik.Multiline = true;
            this.txtIlanElemanOzellik.Name = "txtIlanElemanOzellik";
            this.txtIlanElemanOzellik.Size = new System.Drawing.Size(243, 29);
            this.txtIlanElemanOzellik.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label35.Location = new System.Drawing.Point(29, 249);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(138, 17);
            this.label35.TabIndex = 14;
            this.label35.Text = "Eleman Özellikleri";
            // 
            // lblIlanIsYeriAd
            // 
            this.lblIlanIsYeriAd.AutoSize = true;
            this.lblIlanIsYeriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlanIsYeriAd.Location = new System.Drawing.Point(29, 92);
            this.lblIlanIsYeriAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIlanIsYeriAd.Name = "lblIlanIsYeriAd";
            this.lblIlanIsYeriAd.Size = new System.Drawing.Size(75, 17);
            this.lblIlanIsYeriAd.TabIndex = 16;
            this.lblIlanIsYeriAd.Text = "İşyeri Adı";
            // 
            // txtIlanIsyeriAdi
            // 
            this.txtIlanIsyeriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlanIsyeriAdi.Location = new System.Drawing.Point(157, 89);
            this.txtIlanIsyeriAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlanIsyeriAdi.Name = "txtIlanIsyeriAdi";
            this.txtIlanIsyeriAdi.Size = new System.Drawing.Size(243, 23);
            this.txtIlanIsyeriAdi.TabIndex = 15;
            // 
            // txtIlanİsVerenPozisyon
            // 
            this.txtIlanİsVerenPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlanİsVerenPozisyon.Location = new System.Drawing.Point(157, 188);
            this.txtIlanİsVerenPozisyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlanİsVerenPozisyon.Multiline = true;
            this.txtIlanİsVerenPozisyon.Name = "txtIlanİsVerenPozisyon";
            this.txtIlanİsVerenPozisyon.Size = new System.Drawing.Size(243, 25);
            this.txtIlanİsVerenPozisyon.TabIndex = 17;
            // 
            // lblIsTanimi
            // 
            this.lblIsTanimi.AutoSize = true;
            this.lblIsTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsTanimi.Location = new System.Drawing.Point(29, 135);
            this.lblIsTanimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsTanimi.Name = "lblIsTanimi";
            this.lblIsTanimi.Size = new System.Drawing.Size(73, 17);
            this.lblIsTanimi.TabIndex = 13;
            this.lblIsTanimi.Text = "İş Tanımı";
            // 
            // btniIanEkle
            // 
            this.btniIanEkle.BackColor = System.Drawing.Color.Lime;
            this.btniIanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniIanEkle.Location = new System.Drawing.Point(33, 308);
            this.btniIanEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btniIanEkle.Name = "btniIanEkle";
            this.btniIanEkle.Size = new System.Drawing.Size(157, 95);
            this.btniIanEkle.TabIndex = 12;
            this.btniIanEkle.Text = "İlan Ver";
            this.btniIanEkle.UseVisualStyleBackColor = false;
            this.btniIanEkle.Click += new System.EventHandler(this.btniIanEkle_Click);
            // 
            // txtIlanIsTanimi
            // 
            this.txtIlanIsTanimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIlanIsTanimi.Location = new System.Drawing.Point(157, 133);
            this.txtIlanIsTanimi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlanIsTanimi.Multiline = true;
            this.txtIlanIsTanimi.Name = "txtIlanIsTanimi";
            this.txtIlanIsTanimi.Size = new System.Drawing.Size(243, 20);
            this.txtIlanIsTanimi.TabIndex = 0;
            // 
            // tpSirketBul
            // 
            this.tpSirketBul.BackColor = System.Drawing.Color.Gray;
            this.tpSirketBul.Controls.Add(this.gpIsyeriBul);
            this.tpSirketBul.Controls.Add(this.gbSirketIslemleri);
            this.tpSirketBul.Location = new System.Drawing.Point(4, 25);
            this.tpSirketBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSirketBul.Name = "tpSirketBul";
            this.tpSirketBul.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpSirketBul.Size = new System.Drawing.Size(1523, 679);
            this.tpSirketBul.TabIndex = 2;
            this.tpSirketBul.Text = "Şirket İşlemleri";
            // 
            // gpIsyeriBul
            // 
            this.gpIsyeriBul.BackColor = System.Drawing.Color.Tan;
            this.gpIsyeriBul.Controls.Add(this.btnSirketAra);
            this.gpIsyeriBul.Controls.Add(this.txtSirketAra);
            this.gpIsyeriBul.Controls.Add(this.lblSirketAdGunc);
            this.gpIsyeriBul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpIsyeriBul.Location = new System.Drawing.Point(499, 26);
            this.gpIsyeriBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpIsyeriBul.Name = "gpIsyeriBul";
            this.gpIsyeriBul.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpIsyeriBul.Size = new System.Drawing.Size(471, 210);
            this.gpIsyeriBul.TabIndex = 28;
            this.gpIsyeriBul.TabStop = false;
            this.gpIsyeriBul.Text = "İş Yeri Bul";
            // 
            // btnSirketAra
            // 
            this.btnSirketAra.BackColor = System.Drawing.Color.Cyan;
            this.btnSirketAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketAra.Location = new System.Drawing.Point(17, 78);
            this.btnSirketAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSirketAra.Name = "btnSirketAra";
            this.btnSirketAra.Size = new System.Drawing.Size(431, 78);
            this.btnSirketAra.TabIndex = 27;
            this.btnSirketAra.Text = "Ara";
            this.btnSirketAra.UseVisualStyleBackColor = false;
            this.btnSirketAra.Click += new System.EventHandler(this.btnSirketAra_Click);
            // 
            // txtSirketAra
            // 
            this.txtSirketAra.Location = new System.Drawing.Point(269, 34);
            this.txtSirketAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketAra.Name = "txtSirketAra";
            this.txtSirketAra.Size = new System.Drawing.Size(177, 23);
            this.txtSirketAra.TabIndex = 26;
            // 
            // lblSirketAdGunc
            // 
            this.lblSirketAdGunc.AutoSize = true;
            this.lblSirketAdGunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSirketAdGunc.Location = new System.Drawing.Point(13, 38);
            this.lblSirketAdGunc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSirketAdGunc.Name = "lblSirketAdGunc";
            this.lblSirketAdGunc.Size = new System.Drawing.Size(237, 17);
            this.lblSirketAdGunc.TabIndex = 25;
            this.lblSirketAdGunc.Text = "Güncellenecek şirket adını girin";
            // 
            // gbSirketIslemleri
            // 
            this.gbSirketIslemleri.BackColor = System.Drawing.Color.Tan;
            this.gbSirketIslemleri.Controls.Add(this.btnSirketSil);
            this.gbSirketIslemleri.Controls.Add(this.btnSirketGuncelle);
            this.gbSirketIslemleri.Controls.Add(this.btnSirketEkle);
            this.gbSirketIslemleri.Controls.Add(this.label29);
            this.gbSirketIslemleri.Controls.Add(this.label33);
            this.gbSirketIslemleri.Controls.Add(this.txtSirketAd);
            this.gbSirketIslemleri.Controls.Add(this.txtSirketEposta);
            this.gbSirketIslemleri.Controls.Add(this.label30);
            this.gbSirketIslemleri.Controls.Add(this.label32);
            this.gbSirketIslemleri.Controls.Add(this.txtSirketAdres);
            this.gbSirketIslemleri.Controls.Add(this.txtSirketFaks);
            this.gbSirketIslemleri.Controls.Add(this.txtSirketTelefon);
            this.gbSirketIslemleri.Controls.Add(this.label31);
            this.gbSirketIslemleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSirketIslemleri.Location = new System.Drawing.Point(21, 20);
            this.gbSirketIslemleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSirketIslemleri.Name = "gbSirketIslemleri";
            this.gbSirketIslemleri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSirketIslemleri.Size = new System.Drawing.Size(429, 652);
            this.gbSirketIslemleri.TabIndex = 11;
            this.gbSirketIslemleri.TabStop = false;
            this.gbSirketIslemleri.Text = "Şirket İşlemleri";
            // 
            // btnSirketSil
            // 
            this.btnSirketSil.BackColor = System.Drawing.Color.Red;
            this.btnSirketSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketSil.Location = new System.Drawing.Point(163, 370);
            this.btnSirketSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSirketSil.Name = "btnSirketSil";
            this.btnSirketSil.Size = new System.Drawing.Size(115, 113);
            this.btnSirketSil.TabIndex = 29;
            this.btnSirketSil.Text = "Şirket Sil";
            this.btnSirketSil.UseVisualStyleBackColor = false;
            this.btnSirketSil.Click += new System.EventHandler(this.btnSirketSil_Click);
            // 
            // btnSirketGuncelle
            // 
            this.btnSirketGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSirketGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketGuncelle.Location = new System.Drawing.Point(296, 370);
            this.btnSirketGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSirketGuncelle.Name = "btnSirketGuncelle";
            this.btnSirketGuncelle.Size = new System.Drawing.Size(115, 113);
            this.btnSirketGuncelle.TabIndex = 28;
            this.btnSirketGuncelle.Text = "Şirket Güncelle";
            this.btnSirketGuncelle.UseVisualStyleBackColor = false;
            this.btnSirketGuncelle.Click += new System.EventHandler(this.btnSirketGuncelle_Click);
            // 
            // btnSirketEkle
            // 
            this.btnSirketEkle.BackColor = System.Drawing.Color.Lime;
            this.btnSirketEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirketEkle.Location = new System.Drawing.Point(24, 370);
            this.btnSirketEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSirketEkle.Name = "btnSirketEkle";
            this.btnSirketEkle.Size = new System.Drawing.Size(115, 113);
            this.btnSirketEkle.TabIndex = 10;
            this.btnSirketEkle.Text = "Şirket Kaydet";
            this.btnSirketEkle.UseVisualStyleBackColor = false;
            this.btnSirketEkle.Click += new System.EventHandler(this.btnSirketEkle_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.Location = new System.Drawing.Point(21, 31);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(75, 17);
            this.label29.TabIndex = 1;
            this.label29.Text = "İşyeri Adı";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label33.Location = new System.Drawing.Point(21, 197);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(58, 17);
            this.label33.TabIndex = 9;
            this.label33.Text = "Eposta";
            // 
            // txtSirketAd
            // 
            this.txtSirketAd.Location = new System.Drawing.Point(116, 27);
            this.txtSirketAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketAd.Name = "txtSirketAd";
            this.txtSirketAd.Size = new System.Drawing.Size(295, 23);
            this.txtSirketAd.TabIndex = 0;
            // 
            // txtSirketEposta
            // 
            this.txtSirketEposta.Location = new System.Drawing.Point(116, 194);
            this.txtSirketEposta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketEposta.Name = "txtSirketEposta";
            this.txtSirketEposta.Size = new System.Drawing.Size(295, 23);
            this.txtSirketEposta.TabIndex = 8;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label30.Location = new System.Drawing.Point(21, 270);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(50, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "Adres";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label32.Location = new System.Drawing.Point(21, 142);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(42, 17);
            this.label32.TabIndex = 7;
            this.label32.Text = "Faks";
            // 
            // txtSirketAdres
            // 
            this.txtSirketAdres.Location = new System.Drawing.Point(116, 262);
            this.txtSirketAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketAdres.Multiline = true;
            this.txtSirketAdres.Name = "txtSirketAdres";
            this.txtSirketAdres.Size = new System.Drawing.Size(295, 84);
            this.txtSirketAdres.TabIndex = 3;
            // 
            // txtSirketFaks
            // 
            this.txtSirketFaks.Location = new System.Drawing.Point(116, 137);
            this.txtSirketFaks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketFaks.Name = "txtSirketFaks";
            this.txtSirketFaks.Size = new System.Drawing.Size(295, 23);
            this.txtSirketFaks.TabIndex = 6;
            // 
            // txtSirketTelefon
            // 
            this.txtSirketTelefon.Location = new System.Drawing.Point(116, 84);
            this.txtSirketTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSirketTelefon.Name = "txtSirketTelefon";
            this.txtSirketTelefon.Size = new System.Drawing.Size(295, 23);
            this.txtSirketTelefon.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.Location = new System.Drawing.Point(21, 89);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(63, 17);
            this.label31.TabIndex = 5;
            this.label31.Text = "Telefon";
            // 
            // tpIsIlan
            // 
            this.tpIsIlan.BackColor = System.Drawing.Color.Gray;
            this.tpIsIlan.Controls.Add(this.gpBasvur);
            this.tpIsIlan.Controls.Add(this.gpIsYeriIlanAra);
            this.tpIsIlan.Location = new System.Drawing.Point(4, 25);
            this.tpIsIlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIsIlan.Name = "tpIsIlan";
            this.tpIsIlan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIsIlan.Size = new System.Drawing.Size(1523, 679);
            this.tpIsIlan.TabIndex = 1;
            this.tpIsIlan.Text = "İş İlanları";
            this.tpIsIlan.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // gpBasvur
            // 
            this.gpBasvur.BackColor = System.Drawing.Color.DarkKhaki;
            this.gpBasvur.Controls.Add(this.btnBasvuruYap);
            this.gpBasvur.Controls.Add(this.txtBasvurAd);
            this.gpBasvur.Controls.Add(this.lblBasvurAd);
            this.gpBasvur.Controls.Add(this.txtBasvurTc);
            this.gpBasvur.Controls.Add(this.lblBasvurTc);
            this.gpBasvur.Controls.Add(this.lblBasvurSoyad);
            this.gpBasvur.Controls.Add(this.txtBasvurSoyad);
            this.gpBasvur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpBasvur.Location = new System.Drawing.Point(8, 240);
            this.gpBasvur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBasvur.Name = "gpBasvur";
            this.gpBasvur.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpBasvur.Size = new System.Drawing.Size(719, 191);
            this.gpBasvur.TabIndex = 45;
            this.gpBasvur.TabStop = false;
            this.gpBasvur.Text = "Başvuru Yap";
            // 
            // btnBasvuruYap
            // 
            this.btnBasvuruYap.BackColor = System.Drawing.Color.Lime;
            this.btnBasvuruYap.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnBasvuruYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasvuruYap.Location = new System.Drawing.Point(363, 54);
            this.btnBasvuruYap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBasvuruYap.Name = "btnBasvuruYap";
            this.btnBasvuruYap.Size = new System.Drawing.Size(329, 114);
            this.btnBasvuruYap.TabIndex = 14;
            this.btnBasvuruYap.Text = "Başvuru Yap";
            this.btnBasvuruYap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBasvuruYap.UseVisualStyleBackColor = false;
            this.btnBasvuruYap.UseWaitCursor = true;
            this.btnBasvuruYap.Click += new System.EventHandler(this.btnBasvuruYap_Click_1);
            // 
            // txtBasvurAd
            // 
            this.txtBasvurAd.Location = new System.Drawing.Point(116, 103);
            this.txtBasvurAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBasvurAd.Name = "txtBasvurAd";
            this.txtBasvurAd.Size = new System.Drawing.Size(209, 23);
            this.txtBasvurAd.TabIndex = 16;
            // 
            // lblBasvurAd
            // 
            this.lblBasvurAd.AutoSize = true;
            this.lblBasvurAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasvurAd.Location = new System.Drawing.Point(27, 103);
            this.lblBasvurAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasvurAd.Name = "lblBasvurAd";
            this.lblBasvurAd.Size = new System.Drawing.Size(27, 17);
            this.lblBasvurAd.TabIndex = 17;
            this.lblBasvurAd.Text = "Ad";
            // 
            // txtBasvurTc
            // 
            this.txtBasvurTc.Location = new System.Drawing.Point(116, 66);
            this.txtBasvurTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBasvurTc.Name = "txtBasvurTc";
            this.txtBasvurTc.Size = new System.Drawing.Size(209, 23);
            this.txtBasvurTc.TabIndex = 18;
            // 
            // lblBasvurTc
            // 
            this.lblBasvurTc.AutoSize = true;
            this.lblBasvurTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasvurTc.Location = new System.Drawing.Point(27, 66);
            this.lblBasvurTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasvurTc.Name = "lblBasvurTc";
            this.lblBasvurTc.Size = new System.Drawing.Size(26, 17);
            this.lblBasvurTc.TabIndex = 19;
            this.lblBasvurTc.Text = "Tc";
            // 
            // lblBasvurSoyad
            // 
            this.lblBasvurSoyad.AutoSize = true;
            this.lblBasvurSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBasvurSoyad.Location = new System.Drawing.Point(27, 139);
            this.lblBasvurSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasvurSoyad.Name = "lblBasvurSoyad";
            this.lblBasvurSoyad.Size = new System.Drawing.Size(53, 17);
            this.lblBasvurSoyad.TabIndex = 21;
            this.lblBasvurSoyad.Text = "Soyad";
            // 
            // txtBasvurSoyad
            // 
            this.txtBasvurSoyad.Location = new System.Drawing.Point(116, 139);
            this.txtBasvurSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBasvurSoyad.Name = "txtBasvurSoyad";
            this.txtBasvurSoyad.Size = new System.Drawing.Size(209, 23);
            this.txtBasvurSoyad.TabIndex = 20;
            // 
            // gpIsYeriIlanAra
            // 
            this.gpIsYeriIlanAra.BackColor = System.Drawing.Color.DarkKhaki;
            this.gpIsYeriIlanAra.Controls.Add(this.btnIsYeriAdinaGoreIlanListele);
            this.gpIsYeriIlanAra.Controls.Add(this.lblIsyeriAdiİlanListeleme);
            this.gpIsYeriIlanAra.Controls.Add(this.dgvIlanlar);
            this.gpIsYeriIlanAra.Controls.Add(this.btnPozisyonaGoreIlanListele);
            this.gpIsYeriIlanAra.Controls.Add(this.txtIsYeriAdIlanListeleme);
            this.gpIsYeriIlanAra.Controls.Add(this.lblPozisyonIlanlar);
            this.gpIsYeriIlanAra.Controls.Add(this.txtPozisyonIlanListele);
            this.gpIsYeriIlanAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpIsYeriIlanAra.Location = new System.Drawing.Point(732, 31);
            this.gpIsYeriIlanAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpIsYeriIlanAra.Name = "gpIsYeriIlanAra";
            this.gpIsYeriIlanAra.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpIsYeriIlanAra.Size = new System.Drawing.Size(685, 617);
            this.gpIsYeriIlanAra.TabIndex = 44;
            this.gpIsYeriIlanAra.TabStop = false;
            this.gpIsYeriIlanAra.Text = "İlan Listele";
            this.gpIsYeriIlanAra.Enter += new System.EventHandler(this.gpIsYeriIlanAra_Enter);
            // 
            // btnIsYeriAdinaGoreIlanListele
            // 
            this.btnIsYeriAdinaGoreIlanListele.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIsYeriAdinaGoreIlanListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsYeriAdinaGoreIlanListele.Location = new System.Drawing.Point(403, 22);
            this.btnIsYeriAdinaGoreIlanListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsYeriAdinaGoreIlanListele.Name = "btnIsYeriAdinaGoreIlanListele";
            this.btnIsYeriAdinaGoreIlanListele.Size = new System.Drawing.Size(267, 98);
            this.btnIsYeriAdinaGoreIlanListele.TabIndex = 25;
            this.btnIsYeriAdinaGoreIlanListele.Text = "İş Yeri Adına Göre Ilanları Listele";
            this.btnIsYeriAdinaGoreIlanListele.UseVisualStyleBackColor = false;
            this.btnIsYeriAdinaGoreIlanListele.Click += new System.EventHandler(this.btnIsYeriAdinaGoreIlanListele_Click);
            // 
            // lblIsyeriAdiİlanListeleme
            // 
            this.lblIsyeriAdiİlanListeleme.AutoSize = true;
            this.lblIsyeriAdiİlanListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsyeriAdiİlanListeleme.Location = new System.Drawing.Point(13, 70);
            this.lblIsyeriAdiİlanListeleme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsyeriAdiİlanListeleme.Name = "lblIsyeriAdiİlanListeleme";
            this.lblIsyeriAdiİlanListeleme.Size = new System.Drawing.Size(78, 17);
            this.lblIsyeriAdiİlanListeleme.TabIndex = 43;
            this.lblIsyeriAdiİlanListeleme.Text = "İş Yeri Ad";
            // 
            // dgvIlanlar
            // 
            this.dgvIlanlar.AllowUserToAddRows = false;
            this.dgvIlanlar.AllowUserToDeleteRows = false;
            this.dgvIlanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIlanlar.Location = new System.Drawing.Point(17, 313);
            this.dgvIlanlar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvIlanlar.Name = "dgvIlanlar";
            this.dgvIlanlar.ReadOnly = true;
            this.dgvIlanlar.RowTemplate.Height = 24;
            this.dgvIlanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIlanlar.Size = new System.Drawing.Size(652, 286);
            this.dgvIlanlar.TabIndex = 15;
            // 
            // btnPozisyonaGoreIlanListele
            // 
            this.btnPozisyonaGoreIlanListele.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPozisyonaGoreIlanListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPozisyonaGoreIlanListele.Location = new System.Drawing.Point(403, 162);
            this.btnPozisyonaGoreIlanListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPozisyonaGoreIlanListele.Name = "btnPozisyonaGoreIlanListele";
            this.btnPozisyonaGoreIlanListele.Size = new System.Drawing.Size(267, 94);
            this.btnPozisyonaGoreIlanListele.TabIndex = 41;
            this.btnPozisyonaGoreIlanListele.Text = "Pozisyona Göre Ilanları Listele";
            this.btnPozisyonaGoreIlanListele.UseVisualStyleBackColor = false;
            this.btnPozisyonaGoreIlanListele.Click += new System.EventHandler(this.btnPozisyonaGoreIlanListele_Click);
            // 
            // txtIsYeriAdIlanListeleme
            // 
            this.txtIsYeriAdIlanListeleme.Location = new System.Drawing.Point(191, 66);
            this.txtIsYeriAdIlanListeleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsYeriAdIlanListeleme.Name = "txtIsYeriAdIlanListeleme";
            this.txtIsYeriAdIlanListeleme.Size = new System.Drawing.Size(175, 23);
            this.txtIsYeriAdIlanListeleme.TabIndex = 42;
            // 
            // lblPozisyonIlanlar
            // 
            this.lblPozisyonIlanlar.AutoSize = true;
            this.lblPozisyonIlanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyonIlanlar.Location = new System.Drawing.Point(13, 180);
            this.lblPozisyonIlanlar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPozisyonIlanlar.Name = "lblPozisyonIlanlar";
            this.lblPozisyonIlanlar.Size = new System.Drawing.Size(173, 17);
            this.lblPozisyonIlanlar.TabIndex = 40;
            this.lblPozisyonIlanlar.Text = "İlana Göre Pozisyonlar";
            // 
            // txtPozisyonIlanListele
            // 
            this.txtPozisyonIlanListele.Location = new System.Drawing.Point(191, 172);
            this.txtPozisyonIlanListele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPozisyonIlanListele.Multiline = true;
            this.txtPozisyonIlanListele.Name = "txtPozisyonIlanListele";
            this.txtPozisyonIlanListele.Size = new System.Drawing.Size(175, 25);
            this.txtPozisyonIlanListele.TabIndex = 39;
            // 
            // tpIsBasvuramIslemler
            // 
            this.tpIsBasvuramIslemler.BackColor = System.Drawing.Color.Gray;
            this.tpIsBasvuramIslemler.Controls.Add(this.gpIsBasvuranillgiler);
            this.tpIsBasvuramIslemler.Location = new System.Drawing.Point(4, 25);
            this.tpIsBasvuramIslemler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIsBasvuramIslemler.Name = "tpIsBasvuramIslemler";
            this.tpIsBasvuramIslemler.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIsBasvuramIslemler.Size = new System.Drawing.Size(1523, 679);
            this.tpIsBasvuramIslemler.TabIndex = 0;
            this.tpIsBasvuramIslemler.Text = "İş Başvuran İşlemleri";
            // 
            // gpIsBasvuranillgiler
            // 
            this.gpIsBasvuranillgiler.BackColor = System.Drawing.Color.Gray;
            this.gpIsBasvuranillgiler.Controls.Add(this.gpKisiSil);
            this.gpIsBasvuranillgiler.Controls.Add(this.gpKisiAra);
            this.gpIsBasvuranillgiler.Controls.Add(this.btnIsBasvuranKaydet);
            this.gpIsBasvuranillgiler.Controls.Add(this.grpIsDeneyimleri);
            this.gpIsBasvuranillgiler.Controls.Add(this.btnIsBasvuranGuncelle);
            this.gpIsBasvuranillgiler.Controls.Add(this.gpEgitimBilgileri);
            this.gpIsBasvuranillgiler.Controls.Add(this.grpKayitOl);
            this.gpIsBasvuranillgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpIsBasvuranillgiler.Location = new System.Drawing.Point(7, 7);
            this.gpIsBasvuranillgiler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpIsBasvuranillgiler.Name = "gpIsBasvuranillgiler";
            this.gpIsBasvuranillgiler.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpIsBasvuranillgiler.Size = new System.Drawing.Size(1369, 631);
            this.gpIsBasvuranillgiler.TabIndex = 3;
            this.gpIsBasvuranillgiler.TabStop = false;
            this.gpIsBasvuranillgiler.Text = "İş Başvuran İşlemler";
            this.gpIsBasvuranillgiler.Enter += new System.EventHandler(this.gpIsBasvuranillgiler_Enter);
            // 
            // gpKisiSil
            // 
            this.gpKisiSil.BackColor = System.Drawing.Color.SteelBlue;
            this.gpKisiSil.Controls.Add(this.btnIsBasvuranSil);
            this.gpKisiSil.Controls.Add(this.txtSilinecekKisiTc);
            this.gpKisiSil.Controls.Add(this.lblSilinecekKisiTc);
            this.gpKisiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpKisiSil.Location = new System.Drawing.Point(919, 215);
            this.gpKisiSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpKisiSil.Name = "gpKisiSil";
            this.gpKisiSil.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpKisiSil.Size = new System.Drawing.Size(409, 156);
            this.gpKisiSil.TabIndex = 42;
            this.gpKisiSil.TabStop = false;
            this.gpKisiSil.Text = "Kişi Sil";
            // 
            // btnIsBasvuranSil
            // 
            this.btnIsBasvuranSil.BackColor = System.Drawing.Color.Red;
            this.btnIsBasvuranSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBasvuranSil.Location = new System.Drawing.Point(44, 60);
            this.btnIsBasvuranSil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsBasvuranSil.Name = "btnIsBasvuranSil";
            this.btnIsBasvuranSil.Size = new System.Drawing.Size(340, 89);
            this.btnIsBasvuranSil.TabIndex = 26;
            this.btnIsBasvuranSil.Text = "Sil";
            this.btnIsBasvuranSil.UseVisualStyleBackColor = false;
            this.btnIsBasvuranSil.Click += new System.EventHandler(this.btnIsBasvuranSil_Click);
            // 
            // txtSilinecekKisiTc
            // 
            this.txtSilinecekKisiTc.Location = new System.Drawing.Point(140, 20);
            this.txtSilinecekKisiTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSilinecekKisiTc.Name = "txtSilinecekKisiTc";
            this.txtSilinecekKisiTc.Size = new System.Drawing.Size(244, 23);
            this.txtSilinecekKisiTc.TabIndex = 37;
            // 
            // lblSilinecekKisiTc
            // 
            this.lblSilinecekKisiTc.AutoSize = true;
            this.lblSilinecekKisiTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilinecekKisiTc.Location = new System.Drawing.Point(5, 26);
            this.lblSilinecekKisiTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSilinecekKisiTc.Name = "lblSilinecekKisiTc";
            this.lblSilinecekKisiTc.Size = new System.Drawing.Size(127, 17);
            this.lblSilinecekKisiTc.TabIndex = 38;
            this.lblSilinecekKisiTc.Text = "Silinecek Kişi Tc";
            // 
            // gpKisiAra
            // 
            this.gpKisiAra.BackColor = System.Drawing.Color.SteelBlue;
            this.gpKisiAra.Controls.Add(this.btnKisiAra);
            this.gpKisiAra.Controls.Add(this.txtKisiAra);
            this.gpKisiAra.Controls.Add(this.lblKisiAraTC);
            this.gpKisiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpKisiAra.Location = new System.Drawing.Point(919, 37);
            this.gpKisiAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpKisiAra.Name = "gpKisiAra";
            this.gpKisiAra.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpKisiAra.Size = new System.Drawing.Size(409, 171);
            this.gpKisiAra.TabIndex = 41;
            this.gpKisiAra.TabStop = false;
            this.gpKisiAra.Text = "Kişi Ara";
            // 
            // btnKisiAra
            // 
            this.btnKisiAra.BackColor = System.Drawing.Color.Cyan;
            this.btnKisiAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKisiAra.Location = new System.Drawing.Point(15, 62);
            this.btnKisiAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKisiAra.Name = "btnKisiAra";
            this.btnKisiAra.Size = new System.Drawing.Size(327, 94);
            this.btnKisiAra.TabIndex = 29;
            this.btnKisiAra.Text = "Ara";
            this.btnKisiAra.UseVisualStyleBackColor = false;
            this.btnKisiAra.Click += new System.EventHandler(this.btnKisiAra_Click);
            // 
            // txtKisiAra
            // 
            this.txtKisiAra.Location = new System.Drawing.Point(73, 18);
            this.txtKisiAra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKisiAra.Name = "txtKisiAra";
            this.txtKisiAra.Size = new System.Drawing.Size(259, 23);
            this.txtKisiAra.TabIndex = 27;
            // 
            // lblKisiAraTC
            // 
            this.lblKisiAraTC.AutoSize = true;
            this.lblKisiAraTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKisiAraTC.Location = new System.Drawing.Point(11, 18);
            this.lblKisiAraTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKisiAraTC.Name = "lblKisiAraTC";
            this.lblKisiAraTC.Size = new System.Drawing.Size(57, 17);
            this.lblKisiAraTC.TabIndex = 28;
            this.lblKisiAraTC.Text = "Kişi Tc";
            // 
            // btnIsBasvuranKaydet
            // 
            this.btnIsBasvuranKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnIsBasvuranKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBasvuranKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIsBasvuranKaydet.Location = new System.Drawing.Point(12, 489);
            this.btnIsBasvuranKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsBasvuranKaydet.Name = "btnIsBasvuranKaydet";
            this.btnIsBasvuranKaydet.Size = new System.Drawing.Size(161, 89);
            this.btnIsBasvuranKaydet.TabIndex = 1;
            this.btnIsBasvuranKaydet.Text = "Kaydet";
            this.btnIsBasvuranKaydet.UseVisualStyleBackColor = false;
            this.btnIsBasvuranKaydet.Click += new System.EventHandler(this.btnIsBasvuranKaydet_Click);
            // 
            // grpIsDeneyimleri
            // 
            this.grpIsDeneyimleri.BackColor = System.Drawing.Color.SteelBlue;
            this.grpIsDeneyimleri.Controls.Add(this.dgwIsYerleri);
            this.grpIsDeneyimleri.Controls.Add(this.txtIsTC);
            this.grpIsDeneyimleri.Controls.Add(this.lblIsTC);
            this.grpIsDeneyimleri.Controls.Add(this.txtIsDeneyimiYil);
            this.grpIsDeneyimleri.Controls.Add(this.lbYıl);
            this.grpIsDeneyimleri.Controls.Add(this.btnIsBilgisiEkle);
            this.grpIsDeneyimleri.Controls.Add(this.btnIsBilGoster);
            this.grpIsDeneyimleri.Controls.Add(this.btnIsBilgisiGuncelle);
            this.grpIsDeneyimleri.Controls.Add(this.txtIsDeneyimiPozisyon);
            this.grpIsDeneyimleri.Controls.Add(this.lblPozisyon);
            this.grpIsDeneyimleri.Controls.Add(this.txtIsDeneyimiIsyeriAdi);
            this.grpIsDeneyimleri.Controls.Add(this.txtIsDeneyimiIsyeriAdres);
            this.grpIsDeneyimleri.Controls.Add(this.lblIsYeriAd);
            this.grpIsDeneyimleri.Controls.Add(this.lblAdres);
            this.grpIsDeneyimleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpIsDeneyimleri.Location = new System.Drawing.Point(413, 23);
            this.grpIsDeneyimleri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIsDeneyimleri.Name = "grpIsDeneyimleri";
            this.grpIsDeneyimleri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpIsDeneyimleri.Size = new System.Drawing.Size(493, 287);
            this.grpIsDeneyimleri.TabIndex = 3;
            this.grpIsDeneyimleri.TabStop = false;
            this.grpIsDeneyimleri.Text = "İş Deneyimleri";
            // 
            // dgwIsYerleri
            // 
            this.dgwIsYerleri.AllowUserToAddRows = false;
            this.dgwIsYerleri.AllowUserToDeleteRows = false;
            this.dgwIsYerleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIsYerleri.Location = new System.Drawing.Point(21, 103);
            this.dgwIsYerleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwIsYerleri.Name = "dgwIsYerleri";
            this.dgwIsYerleri.ReadOnly = true;
            this.dgwIsYerleri.RowTemplate.Height = 24;
            this.dgwIsYerleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwIsYerleri.Size = new System.Drawing.Size(447, 111);
            this.dgwIsYerleri.TabIndex = 46;
            this.dgwIsYerleri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIsYerleri_CellClick);
            this.dgwIsYerleri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwIsYerleri_CellContentClick);
            // 
            // txtIsTC
            // 
            this.txtIsTC.Location = new System.Drawing.Point(164, 14);
            this.txtIsTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsTC.Multiline = true;
            this.txtIsTC.Name = "txtIsTC";
            this.txtIsTC.Size = new System.Drawing.Size(228, 22);
            this.txtIsTC.TabIndex = 1;
            // 
            // lblIsTC
            // 
            this.lblIsTC.AutoSize = true;
            this.lblIsTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsTC.Location = new System.Drawing.Point(125, 18);
            this.lblIsTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsTC.Name = "lblIsTC";
            this.lblIsTC.Size = new System.Drawing.Size(32, 18);
            this.lblIsTC.TabIndex = 44;
            this.lblIsTC.Text = "Tc ";
            // 
            // txtIsDeneyimiYil
            // 
            this.txtIsDeneyimiYil.Location = new System.Drawing.Point(308, 78);
            this.txtIsDeneyimiYil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsDeneyimiYil.Name = "txtIsDeneyimiYil";
            this.txtIsDeneyimiYil.Size = new System.Drawing.Size(151, 23);
            this.txtIsDeneyimiYil.TabIndex = 5;
            // 
            // lbYıl
            // 
            this.lbYıl.AutoSize = true;
            this.lbYıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbYıl.Location = new System.Drawing.Point(241, 80);
            this.lbYıl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbYıl.Name = "lbYıl";
            this.lbYıl.Size = new System.Drawing.Size(26, 17);
            this.lbYıl.TabIndex = 38;
            this.lbYıl.Text = "Yıl";
            // 
            // btnIsBilgisiEkle
            // 
            this.btnIsBilgisiEkle.BackColor = System.Drawing.Color.Green;
            this.btnIsBilgisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBilgisiEkle.Location = new System.Drawing.Point(24, 220);
            this.btnIsBilgisiEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsBilgisiEkle.Name = "btnIsBilgisiEkle";
            this.btnIsBilgisiEkle.Size = new System.Drawing.Size(137, 58);
            this.btnIsBilgisiEkle.TabIndex = 7;
            this.btnIsBilgisiEkle.Text = "İş Bilgisi Ekle";
            this.btnIsBilgisiEkle.UseVisualStyleBackColor = false;
            this.btnIsBilgisiEkle.Click += new System.EventHandler(this.btnIsBilgisiEkle_Click);
            // 
            // btnIsBilGoster
            // 
            this.btnIsBilGoster.BackColor = System.Drawing.Color.SandyBrown;
            this.btnIsBilGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBilGoster.Location = new System.Drawing.Point(328, 223);
            this.btnIsBilGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsBilGoster.Name = "btnIsBilGoster";
            this.btnIsBilGoster.Size = new System.Drawing.Size(140, 58);
            this.btnIsBilGoster.TabIndex = 6;
            this.btnIsBilGoster.Text = "Is Yeri Listele";
            this.btnIsBilGoster.UseVisualStyleBackColor = false;
            this.btnIsBilGoster.Click += new System.EventHandler(this.btnIsBilGoster_Click);
            // 
            // btnIsBilgisiGuncelle
            // 
            this.btnIsBilgisiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnIsBilgisiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBilgisiGuncelle.Location = new System.Drawing.Point(164, 220);
            this.btnIsBilgisiGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsBilgisiGuncelle.Name = "btnIsBilgisiGuncelle";
            this.btnIsBilgisiGuncelle.Size = new System.Drawing.Size(153, 60);
            this.btnIsBilgisiGuncelle.TabIndex = 8;
            this.btnIsBilgisiGuncelle.Text = "İş Yeri Bİlgisi Güncelle";
            this.btnIsBilgisiGuncelle.UseVisualStyleBackColor = false;
            this.btnIsBilgisiGuncelle.Click += new System.EventHandler(this.btnIsBilgisiGuncelle_Click);
            // 
            // txtIsDeneyimiPozisyon
            // 
            this.txtIsDeneyimiPozisyon.Location = new System.Drawing.Point(100, 74);
            this.txtIsDeneyimiPozisyon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsDeneyimiPozisyon.Name = "txtIsDeneyimiPozisyon";
            this.txtIsDeneyimiPozisyon.Size = new System.Drawing.Size(133, 23);
            this.txtIsDeneyimiPozisyon.TabIndex = 4;
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.Location = new System.Drawing.Point(20, 78);
            this.lblPozisyon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(73, 17);
            this.lblPozisyon.TabIndex = 30;
            this.lblPozisyon.Text = "Pozisyon";
            // 
            // txtIsDeneyimiIsyeriAdi
            // 
            this.txtIsDeneyimiIsyeriAdi.Location = new System.Drawing.Point(100, 44);
            this.txtIsDeneyimiIsyeriAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsDeneyimiIsyeriAdi.Name = "txtIsDeneyimiIsyeriAdi";
            this.txtIsDeneyimiIsyeriAdi.Size = new System.Drawing.Size(133, 23);
            this.txtIsDeneyimiIsyeriAdi.TabIndex = 2;
            // 
            // txtIsDeneyimiIsyeriAdres
            // 
            this.txtIsDeneyimiIsyeriAdres.Location = new System.Drawing.Point(308, 44);
            this.txtIsDeneyimiIsyeriAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIsDeneyimiIsyeriAdres.Name = "txtIsDeneyimiIsyeriAdres";
            this.txtIsDeneyimiIsyeriAdres.Size = new System.Drawing.Size(151, 23);
            this.txtIsDeneyimiIsyeriAdres.TabIndex = 3;
            // 
            // lblIsYeriAd
            // 
            this.lblIsYeriAd.AutoSize = true;
            this.lblIsYeriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsYeriAd.Location = new System.Drawing.Point(20, 47);
            this.lblIsYeriAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsYeriAd.Name = "lblIsYeriAd";
            this.lblIsYeriAd.Size = new System.Drawing.Size(82, 17);
            this.lblIsYeriAd.TabIndex = 26;
            this.lblIsYeriAd.Text = "İş Yeri Adı";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(239, 50);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(50, 17);
            this.lblAdres.TabIndex = 28;
            this.lblAdres.Text = "Adres";
            // 
            // btnIsBasvuranGuncelle
            // 
            this.btnIsBasvuranGuncelle.BackColor = System.Drawing.Color.Gold;
            this.btnIsBasvuranGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBasvuranGuncelle.Location = new System.Drawing.Point(213, 487);
            this.btnIsBasvuranGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIsBasvuranGuncelle.Name = "btnIsBasvuranGuncelle";
            this.btnIsBasvuranGuncelle.Size = new System.Drawing.Size(165, 90);
            this.btnIsBasvuranGuncelle.TabIndex = 2;
            this.btnIsBasvuranGuncelle.Text = "Güncelle";
            this.btnIsBasvuranGuncelle.UseVisualStyleBackColor = false;
            this.btnIsBasvuranGuncelle.Click += new System.EventHandler(this.btnIsBasvuranGuncelle_Click);
            // 
            // gpEgitimBilgileri
            // 
            this.gpEgitimBilgileri.BackColor = System.Drawing.Color.SteelBlue;
            this.gpEgitimBilgileri.Controls.Add(this.dgwEgitimBilgileri);
            this.gpEgitimBilgileri.Controls.Add(this.txtEgitimTC);
            this.gpEgitimBilgileri.Controls.Add(this.lblEgitimTC);
            this.gpEgitimBilgileri.Controls.Add(this.btnEgitimBİlgisiEkle);
            this.gpEgitimBilgileri.Controls.Add(this.btnEgitimBilgisiGoster);
            this.gpEgitimBilgileri.Controls.Add(this.btnEgitimBilgisiGuncelle);
            this.gpEgitimBilgileri.Controls.Add(this.txtNotOrtalamasi);
            this.gpEgitimBilgileri.Controls.Add(this.label12);
            this.gpEgitimBilgileri.Controls.Add(this.txtBitisTarih);
            this.gpEgitimBilgileri.Controls.Add(this.txtOkulAdi);
            this.gpEgitimBilgileri.Controls.Add(this.label13);
            this.gpEgitimBilgileri.Controls.Add(this.txtBaslangicTarih);
            this.gpEgitimBilgileri.Controls.Add(this.txtBolum);
            this.gpEgitimBilgileri.Controls.Add(this.label14);
            this.gpEgitimBilgileri.Controls.Add(this.label15);
            this.gpEgitimBilgileri.Controls.Add(this.label16);
            this.gpEgitimBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gpEgitimBilgileri.Location = new System.Drawing.Point(435, 366);
            this.gpEgitimBilgileri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpEgitimBilgileri.Name = "gpEgitimBilgileri";
            this.gpEgitimBilgileri.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpEgitimBilgileri.Size = new System.Drawing.Size(927, 282);
            this.gpEgitimBilgileri.TabIndex = 4;
            this.gpEgitimBilgileri.TabStop = false;
            this.gpEgitimBilgileri.Text = "Eğitim Bilgileri";
            // 
            // dgwEgitimBilgileri
            // 
            this.dgwEgitimBilgileri.AllowUserToAddRows = false;
            this.dgwEgitimBilgileri.AllowUserToDeleteRows = false;
            this.dgwEgitimBilgileri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwEgitimBilgileri.Location = new System.Drawing.Point(484, 28);
            this.dgwEgitimBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwEgitimBilgileri.Name = "dgwEgitimBilgileri";
            this.dgwEgitimBilgileri.ReadOnly = true;
            this.dgwEgitimBilgileri.RowTemplate.Height = 24;
            this.dgwEgitimBilgileri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwEgitimBilgileri.Size = new System.Drawing.Size(423, 150);
            this.dgwEgitimBilgileri.TabIndex = 41;
            this.dgwEgitimBilgileri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwEgitimBilgileri_CellClick);
            // 
            // txtEgitimTC
            // 
            this.txtEgitimTC.Location = new System.Drawing.Point(143, 18);
            this.txtEgitimTC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEgitimTC.Name = "txtEgitimTC";
            this.txtEgitimTC.Size = new System.Drawing.Size(293, 23);
            this.txtEgitimTC.TabIndex = 40;
            // 
            // lblEgitimTC
            // 
            this.lblEgitimTC.AutoSize = true;
            this.lblEgitimTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEgitimTC.Location = new System.Drawing.Point(19, 18);
            this.lblEgitimTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEgitimTC.Name = "lblEgitimTC";
            this.lblEgitimTC.Size = new System.Drawing.Size(28, 17);
            this.lblEgitimTC.TabIndex = 39;
            this.lblEgitimTC.Text = "TC";
            // 
            // btnEgitimBİlgisiEkle
            // 
            this.btnEgitimBİlgisiEkle.BackColor = System.Drawing.Color.Green;
            this.btnEgitimBİlgisiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitimBİlgisiEkle.Location = new System.Drawing.Point(200, 199);
            this.btnEgitimBİlgisiEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEgitimBİlgisiEkle.Name = "btnEgitimBİlgisiEkle";
            this.btnEgitimBİlgisiEkle.Size = new System.Drawing.Size(236, 58);
            this.btnEgitimBİlgisiEkle.TabIndex = 38;
            this.btnEgitimBİlgisiEkle.Text = "Eğitim Bİlgisi Ekle";
            this.btnEgitimBİlgisiEkle.UseVisualStyleBackColor = false;
            this.btnEgitimBİlgisiEkle.Click += new System.EventHandler(this.btnEgitimBİlgisiEkle_Click);
            // 
            // btnEgitimBilgisiGoster
            // 
            this.btnEgitimBilgisiGoster.BackColor = System.Drawing.Color.SandyBrown;
            this.btnEgitimBilgisiGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitimBilgisiGoster.Location = new System.Drawing.Point(692, 199);
            this.btnEgitimBilgisiGoster.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEgitimBilgisiGoster.Name = "btnEgitimBilgisiGoster";
            this.btnEgitimBilgisiGoster.Size = new System.Drawing.Size(176, 58);
            this.btnEgitimBilgisiGoster.TabIndex = 34;
            this.btnEgitimBilgisiGoster.Text = "Egitim Bilgilerini Listele";
            this.btnEgitimBilgisiGoster.UseVisualStyleBackColor = false;
            this.btnEgitimBilgisiGoster.Click += new System.EventHandler(this.btnEgitimBilgisiGoster_Click);
            // 
            // btnEgitimBilgisiGuncelle
            // 
            this.btnEgitimBilgisiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEgitimBilgisiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgitimBilgisiGuncelle.Location = new System.Drawing.Point(468, 199);
            this.btnEgitimBilgisiGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEgitimBilgisiGuncelle.Name = "btnEgitimBilgisiGuncelle";
            this.btnEgitimBilgisiGuncelle.Size = new System.Drawing.Size(173, 58);
            this.btnEgitimBilgisiGuncelle.TabIndex = 32;
            this.btnEgitimBilgisiGuncelle.Text = "Eğitim Bilgisi Güncelle";
            this.btnEgitimBilgisiGuncelle.UseVisualStyleBackColor = false;
            this.btnEgitimBilgisiGuncelle.Click += new System.EventHandler(this.btnEgitimBilgisiGuncelle_Click);
            // 
            // txtNotOrtalamasi
            // 
            this.txtNotOrtalamasi.Location = new System.Drawing.Point(143, 162);
            this.txtNotOrtalamasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotOrtalamasi.Name = "txtNotOrtalamasi";
            this.txtNotOrtalamasi.Size = new System.Drawing.Size(293, 23);
            this.txtNotOrtalamasi.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(19, 162);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Not Ortalaması";
            // 
            // txtBitisTarih
            // 
            this.txtBitisTarih.Location = new System.Drawing.Point(143, 130);
            this.txtBitisTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBitisTarih.Name = "txtBitisTarih";
            this.txtBitisTarih.Size = new System.Drawing.Size(293, 23);
            this.txtBitisTarih.TabIndex = 29;
            // 
            // txtOkulAdi
            // 
            this.txtOkulAdi.Location = new System.Drawing.Point(143, 46);
            this.txtOkulAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOkulAdi.Name = "txtOkulAdi";
            this.txtOkulAdi.Size = new System.Drawing.Size(293, 23);
            this.txtOkulAdi.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(19, 130);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Bitiş Tarih";
            // 
            // txtBaslangicTarih
            // 
            this.txtBaslangicTarih.Location = new System.Drawing.Point(143, 105);
            this.txtBaslangicTarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBaslangicTarih.Name = "txtBaslangicTarih";
            this.txtBaslangicTarih.Size = new System.Drawing.Size(293, 23);
            this.txtBaslangicTarih.TabIndex = 27;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(143, 75);
            this.txtBolum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(293, 23);
            this.txtBolum.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(19, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "Okul Adı";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(19, 76);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bölüm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(19, 105);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "Başlangıç Tarih";
            // 
            // grpKayitOl
            // 
            this.grpKayitOl.BackColor = System.Drawing.Color.SteelBlue;
            this.grpKayitOl.Controls.Add(this.cbDige);
            this.grpKayitOl.Controls.Add(this.cbAlmanca);
            this.grpKayitOl.Controls.Add(this.cbIngilizce);
            this.grpKayitOl.Controls.Add(this.txtReferans);
            this.grpKayitOl.Controls.Add(this.lblReferans);
            this.grpKayitOl.Controls.Add(this.cmbUyruk);
            this.grpKayitOl.Controls.Add(this.lblSoyad);
            this.grpKayitOl.Controls.Add(this.txtSoyad);
            this.grpKayitOl.Controls.Add(this.txtTc);
            this.grpKayitOl.Controls.Add(this.lblTc);
            this.grpKayitOl.Controls.Add(this.txtGunReferans);
            this.grpKayitOl.Controls.Add(this.dtpDogumTarihi);
            this.grpKayitOl.Controls.Add(this.label21);
            this.grpKayitOl.Controls.Add(this.lblDogumTarih);
            this.grpKayitOl.Controls.Add(this.txtDogumYeri);
            this.grpKayitOl.Controls.Add(this.lblDogumYeri);
            this.grpKayitOl.Controls.Add(this.lblUyruk);
            this.grpKayitOl.Controls.Add(this.lblYabanciDil);
            this.grpKayitOl.Controls.Add(this.txtIlgiAlanlari);
            this.grpKayitOl.Controls.Add(this.lblIlgiAlani);
            this.grpKayitOl.Controls.Add(this.lblAd);
            this.grpKayitOl.Controls.Add(this.txtAd);
            this.grpKayitOl.Controls.Add(this.lblCalisanAdres);
            this.grpKayitOl.Controls.Add(this.txtAdres);
            this.grpKayitOl.Controls.Add(this.lblTel);
            this.grpKayitOl.Controls.Add(this.txtTelefon);
            this.grpKayitOl.Controls.Add(this.lblEposta);
            this.grpKayitOl.Controls.Add(this.txtEposta);
            this.grpKayitOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpKayitOl.Location = new System.Drawing.Point(12, 23);
            this.grpKayitOl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpKayitOl.Name = "grpKayitOl";
            this.grpKayitOl.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpKayitOl.Size = new System.Drawing.Size(379, 439);
            this.grpKayitOl.TabIndex = 0;
            this.grpKayitOl.TabStop = false;
            this.grpKayitOl.Text = "Kayıt Ol Ve Güncelle";
            this.grpKayitOl.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // cbDige
            // 
            this.cbDige.AutoSize = true;
            this.cbDige.Location = new System.Drawing.Point(296, 208);
            this.cbDige.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDige.Name = "cbDige";
            this.cbDige.Size = new System.Drawing.Size(69, 21);
            this.cbDige.TabIndex = 8;
            this.cbDige.Text = "Diğer";
            this.cbDige.UseVisualStyleBackColor = true;
            // 
            // cbAlmanca
            // 
            this.cbAlmanca.AutoSize = true;
            this.cbAlmanca.Location = new System.Drawing.Point(205, 208);
            this.cbAlmanca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAlmanca.Name = "cbAlmanca";
            this.cbAlmanca.Size = new System.Drawing.Size(91, 21);
            this.cbAlmanca.TabIndex = 7;
            this.cbAlmanca.Text = "Almanca";
            this.cbAlmanca.UseVisualStyleBackColor = true;
            // 
            // cbIngilizce
            // 
            this.cbIngilizce.AutoSize = true;
            this.cbIngilizce.Location = new System.Drawing.Point(132, 207);
            this.cbIngilizce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbIngilizce.Name = "cbIngilizce";
            this.cbIngilizce.Size = new System.Drawing.Size(89, 21);
            this.cbIngilizce.TabIndex = 6;
            this.cbIngilizce.Text = "İngilizce";
            this.cbIngilizce.UseVisualStyleBackColor = true;
            // 
            // txtReferans
            // 
            this.txtReferans.Location = new System.Drawing.Point(132, 334);
            this.txtReferans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReferans.Multiline = true;
            this.txtReferans.Name = "txtReferans";
            this.txtReferans.Size = new System.Drawing.Size(228, 22);
            this.txtReferans.TabIndex = 12;
            // 
            // lblReferans
            // 
            this.lblReferans.AutoSize = true;
            this.lblReferans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReferans.Location = new System.Drawing.Point(21, 338);
            this.lblReferans.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferans.Name = "lblReferans";
            this.lblReferans.Size = new System.Drawing.Size(76, 18);
            this.lblReferans.TabIndex = 48;
            this.lblReferans.Text = "Referans";
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Items.AddRange(new object[] {
            "T.C",
            "Diğer"});
            this.cmbUyruk.Location = new System.Drawing.Point(132, 234);
            this.cmbUyruk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(228, 25);
            this.cmbUyruk.TabIndex = 9;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(21, 89);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(55, 18);
            this.lblSoyad.TabIndex = 44;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(132, 85);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(228, 23);
            this.txtSoyad.TabIndex = 2;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(132, 26);
            this.txtTc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTc.Multiline = true;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(228, 22);
            this.txtTc.TabIndex = 0;
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTc.Location = new System.Drawing.Point(21, 30);
            this.lblTc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(32, 18);
            this.lblTc.TabIndex = 42;
            this.lblTc.Text = "Tc ";
            // 
            // txtGunReferans
            // 
            this.txtGunReferans.Location = new System.Drawing.Point(140, 610);
            this.txtGunReferans.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGunReferans.Name = "txtGunReferans";
            this.txtGunReferans.Size = new System.Drawing.Size(228, 23);
            this.txtGunReferans.TabIndex = 40;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(132, 304);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(228, 23);
            this.dtpDogumTarihi.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(29, 610);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 17);
            this.label21.TabIndex = 39;
            this.label21.Text = "Referans";
            // 
            // lblDogumTarih
            // 
            this.lblDogumTarih.AutoSize = true;
            this.lblDogumTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarih.Location = new System.Drawing.Point(15, 304);
            this.lblDogumTarih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogumTarih.Name = "lblDogumTarih";
            this.lblDogumTarih.Size = new System.Drawing.Size(109, 18);
            this.lblDogumTarih.TabIndex = 37;
            this.lblDogumTarih.Text = "Doğum Tarihi";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(132, 265);
            this.txtDogumYeri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(228, 23);
            this.txtDogumYeri.TabIndex = 10;
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumYeri.Location = new System.Drawing.Point(19, 270);
            this.lblDogumYeri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(96, 18);
            this.lblDogumYeri.TabIndex = 35;
            this.lblDogumYeri.Text = "Doğum Yeri";
            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyruk.Location = new System.Drawing.Point(21, 239);
            this.lblUyruk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(52, 18);
            this.lblUyruk.TabIndex = 34;
            this.lblUyruk.Text = "Uyruk";
            // 
            // lblYabanciDil
            // 
            this.lblYabanciDil.AutoSize = true;
            this.lblYabanciDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYabanciDil.Location = new System.Drawing.Point(21, 207);
            this.lblYabanciDil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYabanciDil.Name = "lblYabanciDil";
            this.lblYabanciDil.Size = new System.Drawing.Size(92, 18);
            this.lblYabanciDil.TabIndex = 16;
            this.lblYabanciDil.Text = "Yabancı Dil";
            // 
            // txtIlgiAlanlari
            // 
            this.txtIlgiAlanlari.Location = new System.Drawing.Point(132, 367);
            this.txtIlgiAlanlari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIlgiAlanlari.Multiline = true;
            this.txtIlgiAlanlari.Name = "txtIlgiAlanlari";
            this.txtIlgiAlanlari.Size = new System.Drawing.Size(228, 50);
            this.txtIlgiAlanlari.TabIndex = 13;
            // 
            // lblIlgiAlani
            // 
            this.lblIlgiAlani.AutoSize = true;
            this.lblIlgiAlani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIlgiAlani.Location = new System.Drawing.Point(19, 370);
            this.lblIlgiAlani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIlgiAlani.Name = "lblIlgiAlani";
            this.lblIlgiAlani.Size = new System.Drawing.Size(89, 18);
            this.lblIlgiAlani.TabIndex = 18;
            this.lblIlgiAlani.Text = "İlgi Alanları";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(21, 59);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(32, 18);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(132, 55);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(228, 23);
            this.txtAd.TabIndex = 1;
            // 
            // lblCalisanAdres
            // 
            this.lblCalisanAdres.AutoSize = true;
            this.lblCalisanAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalisanAdres.Location = new System.Drawing.Point(21, 178);
            this.lblCalisanAdres.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalisanAdres.Name = "lblCalisanAdres";
            this.lblCalisanAdres.Size = new System.Drawing.Size(51, 18);
            this.lblCalisanAdres.TabIndex = 2;
            this.lblCalisanAdres.Text = "Adres";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(132, 174);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(228, 23);
            this.txtAdres.TabIndex = 5;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(21, 118);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(64, 18);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Telefon";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(132, 114);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(228, 23);
            this.txtTelefon.TabIndex = 3;
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEposta.Location = new System.Drawing.Point(21, 148);
            this.lblEposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(61, 18);
            this.lblEposta.TabIndex = 6;
            this.lblEposta.Text = "Eposta";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(132, 144);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(228, 23);
            this.txtEposta.TabIndex = 4;
            // 
            // tpIslemler
            // 
            this.tpIslemler.Controls.Add(this.tpIsBasvuramIslemler);
            this.tpIslemler.Controls.Add(this.tpIsIlan);
            this.tpIslemler.Controls.Add(this.tpSirketBul);
            this.tpIslemler.Controls.Add(this.tpIsBasvuranIlanIslemleri);
            this.tpIslemler.Controls.Add(this.tpKisileriListele);
            this.tpIslemler.Location = new System.Drawing.Point(12, 12);
            this.tpIslemler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIslemler.Name = "tpIslemler";
            this.tpIslemler.SelectedIndex = 0;
            this.tpIslemler.Size = new System.Drawing.Size(1531, 708);
            this.tpIslemler.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1425, 746);
            this.Controls.Add(this.tpIslemler);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpKisileriListele.ResumeLayout(false);
            this.gpKisileriGetir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKisiler)).EndInit();
            this.tpIsBasvuranIlanIslemleri.ResumeLayout(false);
            this.gpIlanListelemeSecenekleri.ResumeLayout(false);
            this.gpIlanListelemeSecenekleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanBasvuranKisiler)).EndInit();
            this.gpIlanSil.ResumeLayout(false);
            this.gpIlanSil.PerformLayout();
            this.gpIlanAra.ResumeLayout(false);
            this.gpIlanAra.PerformLayout();
            this.gbIlanVer.ResumeLayout(false);
            this.gbIlanVer.PerformLayout();
            this.tpSirketBul.ResumeLayout(false);
            this.gpIsyeriBul.ResumeLayout(false);
            this.gpIsyeriBul.PerformLayout();
            this.gbSirketIslemleri.ResumeLayout(false);
            this.gbSirketIslemleri.PerformLayout();
            this.tpIsIlan.ResumeLayout(false);
            this.gpBasvur.ResumeLayout(false);
            this.gpBasvur.PerformLayout();
            this.gpIsYeriIlanAra.ResumeLayout(false);
            this.gpIsYeriIlanAra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIlanlar)).EndInit();
            this.tpIsBasvuramIslemler.ResumeLayout(false);
            this.gpIsBasvuranillgiler.ResumeLayout(false);
            this.gpKisiSil.ResumeLayout(false);
            this.gpKisiSil.PerformLayout();
            this.gpKisiAra.ResumeLayout(false);
            this.gpKisiAra.PerformLayout();
            this.grpIsDeneyimleri.ResumeLayout(false);
            this.grpIsDeneyimleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIsYerleri)).EndInit();
            this.gpEgitimBilgileri.ResumeLayout(false);
            this.gpEgitimBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwEgitimBilgileri)).EndInit();
            this.grpKayitOl.ResumeLayout(false);
            this.grpKayitOl.PerformLayout();
            this.tpIslemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpKisileriListele;
        private System.Windows.Forms.DataGridView dgvKisiler;
        private System.Windows.Forms.GroupBox gpKisileriGetir;
        private System.Windows.Forms.Button btnDerinlik;
        private System.Windows.Forms.Button btnElemanSayisi;
        private System.Windows.Forms.Button btnPostOrder;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.Button btnInorder;
        private System.Windows.Forms.TabPage tpIsBasvuranIlanIslemleri;
        private System.Windows.Forms.GroupBox gpIlanAra;
        private System.Windows.Forms.Button btnIlanAra;
        private System.Windows.Forms.TextBox txtAraIlanNo;
        private System.Windows.Forms.Label lblIlanAraIsYeri;
        private System.Windows.Forms.GroupBox gbIlanVer;
        private System.Windows.Forms.Button btnIlanSil;
        private System.Windows.Forms.Button btnIlanGuncelle;
        private System.Windows.Forms.Label lblIlanPozisyon;
        private System.Windows.Forms.TextBox txtIlanElemanOzellik;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label lblIlanIsYeriAd;
        private System.Windows.Forms.TextBox txtIlanIsyeriAdi;
        private System.Windows.Forms.TextBox txtIlanİsVerenPozisyon;
        private System.Windows.Forms.Label lblIsTanimi;
        private System.Windows.Forms.Button btniIanEkle;
        private System.Windows.Forms.TextBox txtIlanIsTanimi;
        private System.Windows.Forms.TabPage tpSirketBul;
        private System.Windows.Forms.GroupBox gpIsyeriBul;
        private System.Windows.Forms.Button btnSirketAra;
        private System.Windows.Forms.TextBox txtSirketAra;
        private System.Windows.Forms.Label lblSirketAdGunc;
        private System.Windows.Forms.GroupBox gbSirketIslemleri;
        private System.Windows.Forms.Button btnSirketSil;
        private System.Windows.Forms.Button btnSirketGuncelle;
        private System.Windows.Forms.Button btnSirketEkle;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtSirketAd;
        private System.Windows.Forms.TextBox txtSirketEposta;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtSirketAdres;
        private System.Windows.Forms.TextBox txtSirketFaks;
        private System.Windows.Forms.TextBox txtSirketTelefon;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TabPage tpIsIlan;
        private System.Windows.Forms.GroupBox gpBasvur;
        private System.Windows.Forms.Button btnBasvuruYap;
        private System.Windows.Forms.TextBox txtBasvurAd;
        private System.Windows.Forms.Label lblBasvurAd;
        private System.Windows.Forms.TextBox txtBasvurTc;
        private System.Windows.Forms.Label lblBasvurTc;
        private System.Windows.Forms.Label lblBasvurSoyad;
        private System.Windows.Forms.TextBox txtBasvurSoyad;
        private System.Windows.Forms.GroupBox gpIsYeriIlanAra;
        private System.Windows.Forms.Button btnIsYeriAdinaGoreIlanListele;
        private System.Windows.Forms.Label lblIsyeriAdiİlanListeleme;
        private System.Windows.Forms.Button btnPozisyonaGoreIlanListele;
        private System.Windows.Forms.TextBox txtIsYeriAdIlanListeleme;
        private System.Windows.Forms.Label lblPozisyonIlanlar;
        private System.Windows.Forms.TextBox txtPozisyonIlanListele;
        private System.Windows.Forms.DataGridView dgvIlanlar;
        private System.Windows.Forms.TabPage tpIsBasvuramIslemler;
        private System.Windows.Forms.GroupBox gpIsBasvuranillgiler;
        private System.Windows.Forms.Button btnIsBasvuranKaydet;
        private System.Windows.Forms.Button btnKisiAra;
        private System.Windows.Forms.Label lblKisiAraTC;
        private System.Windows.Forms.TextBox txtKisiAra;
        private System.Windows.Forms.Button btnIsBasvuranSil;
        private System.Windows.Forms.GroupBox grpIsDeneyimleri;
        private System.Windows.Forms.TextBox txtIsDeneyimiYil;
        private System.Windows.Forms.Label lbYıl;
        private System.Windows.Forms.Button btnIsBilgisiEkle;
        private System.Windows.Forms.Button btnIsBilGoster;
        private System.Windows.Forms.Button btnIsBilgisiGuncelle;
        private System.Windows.Forms.TextBox txtIsDeneyimiPozisyon;
        private System.Windows.Forms.Label lblPozisyon;
        private System.Windows.Forms.TextBox txtIsDeneyimiIsyeriAdi;
        private System.Windows.Forms.TextBox txtIsDeneyimiIsyeriAdres;
        private System.Windows.Forms.Label lblIsYeriAd;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Button btnIsBasvuranGuncelle;
        private System.Windows.Forms.GroupBox gpEgitimBilgileri;
        private System.Windows.Forms.Button btnEgitimBilgisiGoster;
        private System.Windows.Forms.Button btnEgitimBilgisiGuncelle;
        private System.Windows.Forms.TextBox txtNotOrtalamasi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBitisTarih;
        private System.Windows.Forms.TextBox txtOkulAdi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBaslangicTarih;
        private System.Windows.Forms.TextBox txtBolum;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpKayitOl;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox txtGunReferans;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblDogumTarih;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.Label lblYabanciDil;
        private System.Windows.Forms.TextBox txtIlgiAlanlari;
        private System.Windows.Forms.Label lblIlgiAlani;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblCalisanAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.TabControl tpIslemler;
        private System.Windows.Forms.TextBox txtReferans;
        private System.Windows.Forms.Label lblReferans;
        private System.Windows.Forms.Button btnEgitimBİlgisiEkle;
        private System.Windows.Forms.Label lblSilinecekKisiTc;
        private System.Windows.Forms.TextBox txtSilinecekKisiTc;
        private System.Windows.Forms.TextBox txtIsTC;
        private System.Windows.Forms.Label lblIsTC;
        private System.Windows.Forms.TextBox txtEgitimTC;
        private System.Windows.Forms.Label lblEgitimTC;
        private System.Windows.Forms.DataGridView dgwIsYerleri;
        private System.Windows.Forms.DataGridView dgwEgitimBilgileri;
        private System.Windows.Forms.CheckBox cbDige;
        private System.Windows.Forms.CheckBox cbAlmanca;
        private System.Windows.Forms.CheckBox cbIngilizce;
        private System.Windows.Forms.DataGridView dgvIlanBasvuranKisiler;
        private System.Windows.Forms.Label lblIlanNo;
        private System.Windows.Forms.TextBox txtIlanNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSilinecekIlanNo;
        private System.Windows.Forms.GroupBox gpIlanListelemeSecenekleri;
        private System.Windows.Forms.TextBox txtListeleId;
        private System.Windows.Forms.Button btnIseUygunAdayBul;
        private System.Windows.Forms.Label lblListele;
        private System.Windows.Forms.Button btnBaşvuranTumİlanlarıGöster;
        private System.Windows.Forms.Button btnIlanListeleDileGore;
        private System.Windows.Forms.Button btnIlanListeleIkiYılDeneyim;
        private System.Windows.Forms.TextBox txtIstenenDil;
        private System.Windows.Forms.TextBox txtIseEnUygunAday;
        private System.Windows.Forms.Label lblIstenenDil;
        private System.Windows.Forms.Button btnIseAl;
        private System.Windows.Forms.Label lblEnUygunAday;
        private System.Windows.Forms.GroupBox gpIlanSil;
        private System.Windows.Forms.GroupBox gpKisiSil;
        private System.Windows.Forms.GroupBox gpKisiAra;
    }
}

