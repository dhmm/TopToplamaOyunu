using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TopToplamaOyunu.Kutuphane.Seviyeler.SeviyeGrafikleri;


namespace TopToplamaOyunu.Kutuphane.Seviyeler
{
    public class SeviyeYoneticisi
    {
        public const int TOPLAM_SEVIYE_SAYISI = 10;

        public ISeviyeBilgisi SeviyeBilgisiAl(int seviye)
        {
            ISeviyeBilgisi seviyeBilgisi = null;
            switch (seviye)
            {
                case 1:
                    seviyeBilgisi = new Seviye1();                    
                    break;
                case 2:
                    seviyeBilgisi = new Seviye2();
                    break;
                case 3:
                    seviyeBilgisi = new Seviye3();
                    break;
                case 4:
                    seviyeBilgisi = new Seviye4();
                    break;
                case 5:
                    seviyeBilgisi = new Seviye5();
                    break;
                case 6:
                    seviyeBilgisi = new Seviye6();
                    break;
                case 7:
                    seviyeBilgisi = new Seviye7();
                    break;
                case 8:
                    seviyeBilgisi = new Seviye8();
                    break;
                case 9:
                    seviyeBilgisi = new Seviye9();
                    break;
                case 10:
                    seviyeBilgisi = new Seviye10();
                    break;
            }
            return seviyeBilgisi;
        }
    }
}
