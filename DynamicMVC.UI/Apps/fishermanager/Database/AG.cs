using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMVC.UI.DB
{
    public class AG
    {
        public AG()
        {
            this.BALIK = new HashSet<BALIK>();
            this.HUCRE = new HashSet<HUCRE>();
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
            this.ISLEM_YEMLEME = new HashSet<ISLEM_YEMLEME>();
        }

        public int AG_KOD { get; set; }
        public string AG_AD { get; set; }
        public decimal AG_DERINLIK { get; set; }
        public decimal AG_YARICAP { get; set; }
        public decimal AG_MALIYET { get; set; }
        public string AG_MALIYET_PARA_BIRIMI { get; set; }
        public int AG_SEKIL_KOD { get; set; }
        public int AG_GOZU_SEKIL_KOD { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }
        public Nullable<int> PLATFORM_KOD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public Nullable<System.DateTime> SON_BAKIM_TARIHI { get; set; }
        public int KULLANICI_KAYIT_EDEN { get; set; }
        public string KULLANICI_GUNCELLEYEN { get; set; }
        public Nullable<System.DateTime> KAYIT_TARIHI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }

        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD { get; set; }
        public virtual CIFTLIK CIFTLIK { get; set; }
        public virtual KAFES KAFES { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
        public virtual SEKIL SEKIL { get; set; }
        public virtual SEKIL SEKIL1 { get; set; }
        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual ICollection<HUCRE> HUCRE { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual ICollection<ISLEM_YEMLEME> ISLEM_YEMLEME { get; set; }
    }
}