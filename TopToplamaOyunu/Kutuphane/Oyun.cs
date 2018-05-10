using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TopToplamaOyunu.Kutuphane.Nesneler;
using TopToplamaOyunu.Kutuphane.Grafikler;
using System.Diagnostics;
using TopToplamaOyunu.Kutuphane.Seviyeler;


namespace TopToplamaOyunu.Kutuphane
{
    public class Oyun
    {
        public Random R = new Random();
        public Panel PnlArena { set; get; }        
        
        public int Skor 
        {
            set 
            { 
                this._skor = value;
                this.LblSkor.Text = value.ToString(); 
            }
            get
            {
                return this._skor;
            }
        }
        public int Seviye
        {
            set
            {
                this._seviye = value;
                this.LblSeviye.Text = value.ToString();
            }
            get
            {
                return this._seviye;
            }
        }
        public int Can
        {
            set
            {
                this._can = value;
                this.LblCan.Text = value.ToString();
            }
            get
            {
                return this._can;
            }
        }
        public Label LblSkor { set; get; }
        public Label LblSeviye { set; get; }
        public Label LblCan { set; get; }
        public IOyunNesnesi Sepet { set; get; }

        private int TOPTA_ALINAN_SKOR = 10;
        private int SEVIYE_ATLAMA_SKORU = 50;
        private int _skor = 0;
        private int _seviye = 0;
        private int _can = 0;
        private GelismisPictureBox PctTop { set; get; }
        private GelismisPictureBox PctSepet { set; get; }
        private Timer Timer { set; get; }
        private List<IOyunNesnesi> Nesneler { set; get; }                
        private int TOP_SAYISI { set; get; }
        private SeviyeYoneticisi SeviyeYoneticisi = new SeviyeYoneticisi();
        private bool Oynaniyor { set; get; }

        public Oyun(Panel pnlArena,Timer timer, GelismisPictureBox pctTop, GelismisPictureBox pctSepet)
        {
            this.PnlArena = pnlArena;
            this.Timer = timer;
            this.PctTop = pctTop;
            this.PctSepet = pctSepet;            
            this.SepetiOlustur();
            this.Nesneler = new List<IOyunNesnesi>();            
            this.Timer.Tick += new EventHandler(Timer_Tick);            
        }
        public void LabelleriAyarla(Label lblSkor, Label lblSeviye, Label lblCan)
        {
            this.LblSkor = lblSkor;
            this.LblSeviye = lblSeviye;
            this.LblCan = lblCan;
        }
        public void OdunEngeliEkle(GelismisPictureBox pctOdunEngeli)
        {
            IOyunNesnesi odunEngel = new OdunEngel(this,pctOdunEngeli);            
            this.Nesneler.Add(odunEngel);
        }
        public void YeniOyun()
        {
            Seviye = 1;
            Can = 5;
            SeviyeBilgisiOlustur(this.Seviye);            
            ToplariOlustur();
            this.Baslangic();
            this.Oynaniyor = true;
            this.Timer.Start();
        }
        public void DuraklatDevamEttir()
        {
            if (this.Oynaniyor)
            {
                this.Timer.Enabled = !this.Timer.Enabled;
            }
        }
        internal bool BaskaNesneyeUsttenCarptiMi(IOyunNesnesi gelenNesne)
        {
            foreach (IOyunNesnesi nesne in this.Nesneler)
            {
                if (gelenNesne.Y < nesne.Y)
                {
                    if (gelenNesne.SagKenar >= nesne.X &&
                        gelenNesne.X <= nesne.SagKenar &&
                        gelenNesne.AltKenar >= nesne.Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        internal bool BaskaNesneyeAlttanCarptiMi(IOyunNesnesi gelenNesne)
        {
            foreach (IOyunNesnesi nesne in this.Nesneler)
            {
                if (gelenNesne.AltKenar > nesne.AltKenar)
                {
                    if (gelenNesne.SagKenar >= nesne.X &&
                        gelenNesne.X <= nesne.SagKenar &&
                        gelenNesne.Y <= nesne.AltKenar)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        internal bool BaskaNesneyeSoldanCarptiMi(IOyunNesnesi gelenNesne)
        {
            foreach (IOyunNesnesi nesne in this.Nesneler)
            {
                if (gelenNesne.X < nesne.X)
                {
                    if (gelenNesne.Y >= nesne.Y &&
                        gelenNesne.Y <= nesne.AltKenar &&
                        gelenNesne.SagKenar >= nesne.X)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        internal bool BaskaNesneyeSagdanCarptiMi(IOyunNesnesi gelenNesne)
        {
            foreach (IOyunNesnesi nesne in this.Nesneler)
            {
                if (gelenNesne.SagKenar > nesne.SagKenar)
                {
                    if (gelenNesne.Y >= nesne.Y &&
                        gelenNesne.Y <= nesne.AltKenar &&
                        gelenNesne.X <= nesne.SagKenar)
                    {
                        return true;
                    }
                }

            }
            return false;
        }       
        internal bool SolaCarptiMi(IOyunNesnesi gelenNesne)
        {
            return gelenNesne.X <= 0;
        }
        internal bool SagaCarptiMi(IOyunNesnesi gelenNesne)
        {
            return gelenNesne.SagKenar >= this.PnlArena.Width;
        }
        internal bool UsteCarptiMi(IOyunNesnesi gelenNesne)
        {
            return gelenNesne.Y <= 0;
        }
        internal bool AlttanCiktiMi(IOyunNesnesi gelenNesne)
        {
            return gelenNesne.AltKenar > this.PnlArena.Height;
        }
        internal void TopAltaCarpti(IOyunNesnesi top)
        {
            this.Can--;
            if (this.Can == 0)
            {
                this.OyunKaybedildi();
                return;
            }
            top.Y = top.Yukseklik * -1;
            top.RastgeleXBelirle();
            top.Baslangic();
        }
        internal bool SepeteGirdiMi(IOyunNesnesi top)
        {
            if (top.Y >= this.Sepet.Y)
            {
                if (top.X >= this.Sepet.X && top.SagKenar <= this.Sepet.SagKenar)
                {
                    return true;
                }
            }
            return false;
        }
        internal void TopSepeteGirdi(IOyunNesnesi top)
        {
            top.Y = top.Yukseklik * -1;
            top.RastgeleXBelirle();
            top.Baslangic();
            this.Skor+=this.TOPTA_ALINAN_SKOR;
            if ((this.Skor % this.SEVIYE_ATLAMA_SKORU) == 0)
            {
                this.SeviyeArttir();
            }
        }
        private void TumunuTemizle()
        {
            this.Timer.Stop();            
            List<int> topIndexleri = new List<int>();
            foreach(IOyunNesnesi nesne in this.Nesneler)
            {
                nesne.GrafikKaldir();                
            }                     
            this.Nesneler = new List<IOyunNesnesi>();
        }
        private IOyunNesnesi TopOlustur()
        {
            IOyunNesnesi top = new Top(this,this.PctTop);
            top.Baslangic();
            return top;
        }
        private void Baslangic()
        {
            foreach (IOyunNesnesi nesne in this.Nesneler)
            {
                nesne.Baslangic();
            }
        }
        private void Guncelle()
        {
            int aktifSeviye = this.Seviye;
            foreach (IOyunNesnesi nesne in this.Nesneler)
            {
                nesne.Guncelle();
                if (aktifSeviye < this.Seviye)
                {
                    return;
                }
            }            
        }
        private void Timer_Tick(object sender,EventArgs e)
        {
            this.Guncelle();
        }
        private void SeviyeBilgisiOlustur(int seviye)
        {
            TumunuTemizle();
            ISeviyeBilgisi seviyeBilgisi = SeviyeYoneticisi.SeviyeBilgisiAl(seviye);
            
            foreach (Control control in seviyeBilgisi.PnlArena.Controls)
            {
                GelismisPictureBox pctAktif = (GelismisPictureBox)control;
                GelismisPictureBox pctOdun = new GelismisPictureBox();
                PictureBoxBilgisiKopyala(pctOdun, pctAktif);                
                OdunEngel odunEngel = new OdunEngel(this,pctOdun);
                this.Nesneler.Add(odunEngel);
                odunEngel.ArenayaYerles();
            }
            this.Timer.Interval = seviyeBilgisi.TopHizi;
            this.TOP_SAYISI = seviyeBilgisi.TopSayisi;
        }
        private void SepetiOlustur()
        {
            this.Sepet = new Sepet(this, this.PctSepet);            
        }
        private void OyunKaybedildi()
        {
            this.Oynaniyor = false;
            this.Timer.Stop();
            MessageBox.Show("Uzgunum kaybettiniz !!!");
        }
        private void SeviyeArttir()
        {

            if((this.Seviye + 1) > SeviyeYoneticisi.TOPLAM_SEVIYE_SAYISI)
            {
                this.OyunKazanildi();
            }
            else
            {
                this.Seviye++;            
                SeviyeBilgisiOlustur(this.Seviye);
                ToplariOlustur();
                this.Timer.Start();
            }
        }
        private void OyunKazanildi()
        {
            this.Oynaniyor = false;
            this.Timer.Stop();
            MessageBox.Show("*** TEBRIKLER Oyun kazanildi !!!");
        }
        private void ToplariOlustur()
        {
            for (int i = 0; i < TOP_SAYISI; i++)
            {
                IOyunNesnesi top = TopOlustur();
                this.Nesneler.Add(top);
            }
        }
        private void PictureBoxBilgisiKopyala(GelismisPictureBox pctHedef, GelismisPictureBox pctKopyalanacak)
        {
            pctHedef.Width = pctKopyalanacak.Width;
            pctHedef.Height = pctKopyalanacak.Height;
            pctHedef.Image = pctKopyalanacak.Image;
            pctHedef.Left = pctKopyalanacak.Left;
            pctHedef.Top = pctKopyalanacak.Top;
            pctHedef.SizeMode = pctKopyalanacak.SizeMode;
        }
    }
}
