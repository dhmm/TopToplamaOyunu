using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TopToplamaOyunu.Kutuphane.Seviyeler
{
    public interface ISeviyeBilgisi
    {
        Panel PnlArena { get; }
        int TopSayisi { get; }
        int TopHizi { get; }
    }
}
