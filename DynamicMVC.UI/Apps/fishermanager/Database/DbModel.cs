
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AGIRLIK_BIRIMLERI
    {
      
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AKTIF_DURUM_KOD
    {
        public AKTIF_DURUM_KOD()
        {
            this.AG = new HashSet<AG>();
            this.CIFTLIK = new HashSet<CIFTLIK>();
            this.DEMIRBAS = new HashSet<DEMIRBAS>();
            this.KAFES = new HashSet<KAFES>();
            this.KULLANICI = new HashSet<KULLANICI>();
            this.MENULER = new HashSet<MENULER>();
            this.PLATFORM = new HashSet<PLATFORM>();
        }

        public int AKTIF_DURUM_KOD1 { get; set; }
        public string AKTIF_DURUM_AD { get; set; }

        public virtual ICollection<AG> AG { get; set; }
        public virtual ICollection<CIFTLIK> CIFTLIK { get; set; }
        public virtual ICollection<DEMIRBAS> DEMIRBAS { get; set; }
        public virtual ICollection<KAFES> KAFES { get; set; }
        public virtual ICollection<KULLANICI> KULLANICI { get; set; }
        public virtual ICollection<MENULER> MENULER { get; set; }
        public virtual ICollection<PLATFORM> PLATFORM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ANAC_BALIK
    {
        public ANAC_BALIK()
        {
            this.YAVRU_BALIK = new HashSet<YAVRU_BALIK>();
        }

        public int ANAC_BALIK_KOD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public bool AKTIF { get; set; }
        public string ANAC_BALIK_ADI { get; set; }
        public string ANAC_BALIK_ACIKLAMA { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
        public virtual ICollection<YAVRU_BALIK> YAVRU_BALIK { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            this.AspNetUsers = new HashSet<AspNetUsers>();
        }

        public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUsers> AspNetUsers { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AspNetUserClaims
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AspNetUserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AspNetUsers
    {
        public AspNetUsers()
        {
            this.AspNetUserClaims = new HashSet<AspNetUserClaims>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogins>();
            this.AspNetRoles = new HashSet<AspNetRoles>();
        }

        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AuditTrail
    {
        public int Id { get; set; }
        public System.DateTime DateTime { get; set; }
        public string Script { get; set; }
        public string User { get; set; }
        public string Action { get; set; }
        public string Table { get; set; }
        public string Field { get; set; }
        public string KeyValue { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class AYARLAR
    {
        public string AYAR_KOD { get; set; }
        public string AYAR_DEGERI { get; set; }
        public string VERI_TURU { get; set; }
        public string TABLO_ADI { get; set; }
        public string TEXT_ALANI { get; set; }
        public string VALUE_ALANI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BALIK
    {
        public BALIK()
        {
            this.HUCRE = new HashSet<HUCRE>();
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
            this.ISLEM_YEMLEME = new HashSet<ISLEM_YEMLEME>();
        }

        public int BALIK_KOD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public int BALIK_ADET { get; set; }
        public decimal BALIK_ORTALAMA_AGIRLIK { get; set; }
        public string ORTALAMA_AGIRLIK_BIRIM_KOD { get; set; }
        public System.DateTime KAYIT_TARIHI { get; set; }
        public System.DateTime SATIN_ALMA_TARIHI { get; set; }
        public Nullable<int> AG_KOD { get; set; }
        public Nullable<int> KUS_AGI_KOD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public Nullable<int> PLATFORM_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public int YAVRU_BALIK_KOD { get; set; }

        public virtual AG AG { get; set; }
        public virtual AGIRLIK_BIRIMLERI AGIRLIK_BIRIMLERI { get; set; }
        public virtual BALIK_TUR BALIK_TUR { get; set; }
        public virtual CIFTLIK CIFTLIK { get; set; }
        public virtual KAFES KAFES { get; set; }
        public virtual KUS_AGI KUS_AGI { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
        public virtual YAVRU_BALIK YAVRU_BALIK { get; set; }
        public virtual ICollection<HUCRE> HUCRE { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual ICollection<ISLEM_YEMLEME> ISLEM_YEMLEME { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BALIK_BOY_AGIRLIK_ADET
    {
        public int KOD { get; set; }
        public int BOY { get; set; }
        public decimal AGIRLIK_G { get; set; }
        public int ADET { get; set; }
        public int BALIK_TUR_KOD { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BALIK_KULUCKA_SURELERI
    {
        public int BALIK_KULUCKA_KOD { get; set; }
        public int SURE_BAS_GUN { get; set; }
        public int SURE_BIT_GUN { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }
        public int BALIK_TUR_KOD { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BALIK_SINIFLARI
    {
        public int SINIF_KOD { get; set; }
        public int BOY_BAS_CM { get; set; }
        public int BOY_BIT_CM { get; set; }
        public string SINIF_AD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BALIK_TUR
    {
        public BALIK_TUR()
        {
            this.ANAC_BALIK = new HashSet<ANAC_BALIK>();
            this.BALIK = new HashSet<BALIK>();
            this.BALIK_BOY_AGIRLIK_ADET = new HashSet<BALIK_BOY_AGIRLIK_ADET>();
            this.BALIK_KULUCKA_SURELERI = new HashSet<BALIK_KULUCKA_SURELERI>();
            this.SICAKLIK_YEMLEME_ORANI = new HashSet<SICAKLIK_YEMLEME_ORANI>();
            this.YAVRU_BALIK = new HashSet<YAVRU_BALIK>();
            this.YEM_GELISIM_SURELERI = new HashSet<YEM_GELISIM_SURELERI>();
            this.YEM_KURAL_BOYUT = new HashSet<YEM_KURAL_BOYUT>();
            this.YEM_KURAL_ZAMAN = new HashSet<YEM_KURAL_ZAMAN>();
        }

        public int BALIK_TUR_KOD { get; set; }
        public string BALIK_TUR_ADI { get; set; }
        public string BALIK_TUR_ACIKLAMA { get; set; }

        public virtual ICollection<ANAC_BALIK> ANAC_BALIK { get; set; }
        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual ICollection<BALIK_BOY_AGIRLIK_ADET> BALIK_BOY_AGIRLIK_ADET { get; set; }
        public virtual ICollection<BALIK_KULUCKA_SURELERI> BALIK_KULUCKA_SURELERI { get; set; }
        public virtual ICollection<SICAKLIK_YEMLEME_ORANI> SICAKLIK_YEMLEME_ORANI { get; set; }
        public virtual ICollection<YAVRU_BALIK> YAVRU_BALIK { get; set; }
        public virtual ICollection<YEM_GELISIM_SURELERI> YEM_GELISIM_SURELERI { get; set; }
        public virtual ICollection<YEM_KURAL_BOYUT> YEM_KURAL_BOYUT { get; set; }
        public virtual ICollection<YEM_KURAL_ZAMAN> YEM_KURAL_ZAMAN { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BILDIRIM_TURLERI
    {
        public BILDIRIM_TURLERI()
        {
            this.KULLANICI_BILDIRIMLERI = new HashSet<KULLANICI_BILDIRIMLERI>();
            this.OLAY_TURLERI = new HashSet<OLAY_TURLERI>();
        }

        public string BILDIRIM_TUR_KODU { get; set; }
        public string BILDIRIM_TUR_ADI { get; set; }
        public string BILDIRIM_ACIKLAMA { get; set; }

        public virtual ICollection<KULLANICI_BILDIRIMLERI> KULLANICI_BILDIRIMLERI { get; set; }
        public virtual ICollection<OLAY_TURLERI> OLAY_TURLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class BIRIM_TURLERI
    {
        public BIRIM_TURLERI()
        {
            this.STOK = new HashSet<STOK>();
            this.STOK_TURLERI = new HashSet<STOK_TURLERI>();
        }

        public string BIRIM_TURU_KODU { get; set; }
        public string BIRIM_ADI { get; set; }

        public virtual ICollection<STOK> STOK { get; set; }
        public virtual ICollection<STOK_TURLERI> STOK_TURLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class C_FIELD_TYPE
    {
        public string FIELD_TYPE_KOD { get; set; }
        public string FIELD_NAME { get; set; }
        public string FIELD_DESCRIPTION { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class C_ISLEM_STANDART_LOG
    {
        public int Id { get; set; }
        public string TABLO_AD { get; set; }
        public string ISLEM { get; set; }
        public int KULLANICI_KOD { get; set; }
        public System.DateTime TARIH { get; set; }
        public string ACIKLAMA { get; set; }
        public string ESKI_DEGER { get; set; }
        public string YENI_DEGER { get; set; }
        public string EK_BILGI { get; set; }
        public string VERI_NO { get; set; }

        public virtual C_TABLOLAR C_TABLOLAR { get; set; }
        public virtual KULLANICI KULLANICI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class C_ISLEM_TANIM_LOG
    {
        public int Id { get; set; }
        public int ISLEM_TANIM_ID { get; set; }
        public string SQL_KODU { get; set; }
        public int KULLANICI_KOD { get; set; }
        public string PARAMETERS_JSON { get; set; }
        public bool IS_SUCCESS { get; set; }
        public string ERROR_MESSAGE { get; set; }
        public string ERROR_STACKTRACE { get; set; }
        public System.DateTime TARIH { get; set; }

        public virtual ISLEM_TANIM ISLEM_TANIM { get; set; }
        public virtual KULLANICI KULLANICI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class C_TABLOLAR
    {
        public C_TABLOLAR()
        {
            this.C_ISLEM_STANDART_LOG = new HashSet<C_ISLEM_STANDART_LOG>();
            this.KUTUPHANE_BAGLANTI = new HashSet<KUTUPHANE_BAGLANTI>();
        }

        public string AD { get; set; }
        public string SINIF_AD { get; set; }
        public string AYARLAR { get; set; }
        public string GRUP { get; set; }

        public virtual ICollection<C_ISLEM_STANDART_LOG> C_ISLEM_STANDART_LOG { get; set; }
        public virtual ICollection<KUTUPHANE_BAGLANTI> KUTUPHANE_BAGLANTI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class CEVIRI_DILLERI
    {
        public CEVIRI_DILLERI()
        {
            this.CEVIRILER = new HashSet<CEVIRILER>();
        }

        public string DIL_KODU { get; set; }
        public string DIL_ADI { get; set; }
        public int AKTIF { get; set; }

        public virtual ICollection<CEVIRILER> CEVIRILER { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class CEVIRILER
    {
        public string KELIME_KODU { get; set; }
        public string DEGER { get; set; }
        public string DIL_KODU { get; set; }

        public virtual CEVIRI_DILLERI CEVIRI_DILLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class CIFTLIK
    {
        public CIFTLIK()
        {
            this.AG = new HashSet<AG>();
            this.BALIK = new HashSet<BALIK>();
            this.HUCRE = new HashSet<HUCRE>();
            this.KAFES = new HashSet<KAFES>();
            this.KUS_AGI = new HashSet<KUS_AGI>();
            this.PLATFORM = new HashSet<PLATFORM>();
        }

        public int CIFTLIK_KOD { get; set; }
        public string CIFTLIK_AD { get; set; }
        public string CIFTLIK_ADRES { get; set; }
        public string CIFTLIK_TEL { get; set; }
        public string CIFTLIK_EMAIL { get; set; }
        public string CIFTLIK_VERGINO { get; set; }
        public int KULLANICI_KAYIT_EDEN { get; set; }
        public Nullable<int> KULLANICI_GUNCELLEYEN { get; set; }
        public System.DateTime KAYIT_TARIHI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }

        public virtual ICollection<AG> AG { get; set; }
        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD { get; set; }
        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual ICollection<HUCRE> HUCRE { get; set; }
        public virtual ICollection<KAFES> KAFES { get; set; }
        public virtual ICollection<KUS_AGI> KUS_AGI { get; set; }
        public virtual ICollection<PLATFORM> PLATFORM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class DEMIRBAS
    {
        public int DEMIRBAS_KOD { get; set; }
        public string DEMIRBAS_AD { get; set; }
        public string DEMIRBAS_ACIKLAMA { get; set; }
        public int DEMIRBAS_TUR_KOD { get; set; }
        public Nullable<int> FIRMA_KOD { get; set; }
        public string PARA_BIRIMI { get; set; }
        public Nullable<decimal> PARA_DEGERI { get; set; }
        public Nullable<System.DateTime> SATIN_ALMA_TARIHI { get; set; }
        public Nullable<System.DateTime> KULLANIMA_BASLAMA_TARIHI { get; set; }
        public string DURUM { get; set; }
        public Nullable<int> KONUM_KOD { get; set; }
        public Nullable<int> AKTIF_DURUM_KOD { get; set; }
        public string ACIKLAMA_2 { get; set; }

        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD1 { get; set; }
        public virtual DEMIRBAS_DURUMLARI DEMIRBAS_DURUMLARI { get; set; }
        public virtual DEMIRBAS_TUR DEMIRBAS_TUR { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class DEMIRBAS_DURUMLARI
    {
        public DEMIRBAS_DURUMLARI()
        {
            this.DEMIRBAS = new HashSet<DEMIRBAS>();
        }

        public string DURUM_KOD { get; set; }
        public string DURUM_AD { get; set; }

        public virtual ICollection<DEMIRBAS> DEMIRBAS { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class DEMIRBAS_TUR
    {
        public DEMIRBAS_TUR()
        {
            this.DEMIRBAS = new HashSet<DEMIRBAS>();
        }

        public int DEMIRBAS_TUR_KOD { get; set; }
        public string DEMIRBAS_TUR_AD { get; set; }
        public string DEMIRBAS_ACIKLAMA { get; set; }

        public virtual ICollection<DEMIRBAS> DEMIRBAS { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class DOSYA_KATEGORILER
    {
        public DOSYA_KATEGORILER()
        {
            this.DOSYALAR = new HashSet<DOSYALAR>();
        }

        public int Id { get; set; }
        public string KATEGORI_AD { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }

        public virtual ICollection<DOSYALAR> DOSYALAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class DOSYA_TURLER
    {
        public DOSYA_TURLER()
        {
            this.DOSYALAR = new HashSet<DOSYALAR>();
        }

        public string DOSYA_TUR_KOD { get; set; }
        public string DOSYA_TUR_AD { get; set; }
        public string DOSYA_UZANTI { get; set; }
        public string DOSYA_MIME_TYPE { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }

        public virtual ICollection<DOSYALAR> DOSYALAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class DOSYALAR
    {
        public int ID { get; set; }
        public string DOSYA_AD { get; set; }
        public string DOSYA_GUID { get; set; }
        public Nullable<int> DOSYA_KATEGORI_ID { get; set; }
        public bool AKTIF { get; set; }
        public string DOSYA_TUR_KOD { get; set; }
        public string TABLO_AD { get; set; }
        public string KOLON_AD { get; set; }
        public string KAYIT_ID { get; set; }
        public Nullable<int> KULLANICI_ID { get; set; }
        public System.DateTime TARIH { get; set; }

        public virtual DOSYA_KATEGORILER DOSYA_KATEGORILER { get; set; }
        public virtual DOSYA_TURLER DOSYA_TURLER { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class FIRMA
    {
        public FIRMA()
        {
            this.STOK = new HashSet<STOK>();
        }

        public int FIRMA_KOD { get; set; }
        public int FIRMA_TUR_KOD { get; set; }
        public string FIRMA_AD { get; set; }
        public string FIRMA_ADRES { get; set; }
        public string FIRMA_TELEFON { get; set; }
        public string FIRMA_CEP_TELEFON { get; set; }
        public string FIRMA_ILETISIM_KISISI { get; set; }
        public string FIRMA_VERGI_NO { get; set; }
        public string FIRMA_VERGI_DAIRESI { get; set; }
        public bool BAKIM_FIRMASI { get; set; }
        public bool YEM_FIRMASI { get; set; }
        public bool VETERINERLIK_FIRMASI { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string YETKILI_AD_SOYAD { get; set; }
        public string YETKILI_CEP_TELEFON { get; set; }
        public string YETKILI_E_POSTA { get; set; }
        public string YETKILI_UNVANI { get; set; }

        public virtual FIRMA_TUR FIRMA_TUR { get; set; }
        public virtual ICollection<STOK> STOK { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class FIRMA_TUR
    {
        public FIRMA_TUR()
        {
            this.FIRMA = new HashSet<FIRMA>();
        }

        public int FIRMA_TUR_KOD { get; set; }
        public string FIRMA_TUR_AD { get; set; }
        public string FIRMA_TUR_ACIKLAMA { get; set; }

        public virtual ICollection<FIRMA> FIRMA { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class FORMLAR
    {
        public string FORM_KOD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class GOREV
    {
        public GOREV()
        {
            this.KULLANICI = new HashSet<KULLANICI>();
        }

        public int GOREV_KOD { get; set; }
        public string GOREV_AD { get; set; }
        public string GOREV_ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }
        public string GOREV_GRUP_ADI { get; set; }

        public virtual ICollection<KULLANICI> KULLANICI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class HACIM_BIRIMLERI
    {
        public string BIRIM_KOD { get; set; }
        public decimal HACIM_DEGER { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class HASTALIKLAR
    {
        public int HASTALIK_KOD { get; set; }
        public string HASTALIK_AD { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }
        public bool KARANTINA_GEREKIR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class HUCRE
    {
        public HUCRE()
        {
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
        }

        public int HUCRE_KOD { get; set; }
        public int SATIR_INDEX { get; set; }
        public int SUTUN_INDEX { get; set; }
        public Nullable<int> BALIK_KOD { get; set; }
        public Nullable<int> AG_KOD { get; set; }
        public Nullable<int> KUS_AGI_KOD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public int PLATFORM_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }

        public virtual AG AG { get; set; }
        public virtual BALIK BALIK { get; set; }
        public virtual CIFTLIK CIFTLIK { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual KAFES KAFES { get; set; }
        public virtual KUS_AGI KUS_AGI { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class HUCRE_DEGISIMLERI
    {
        public int ID { get; set; }
        public int HUCRE_KOD { get; set; }
        public int SATIR_INDEX { get; set; }
        public int SUTUN_INDEX { get; set; }
        public Nullable<int> BALIK_KOD { get; set; }
        public Nullable<int> AG_KOD { get; set; }
        public Nullable<int> KUS_AGI_KOD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public int PLATFORM_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> KULLANICI_KOD { get; set; }
        public string ISLEM_TIPI { get; set; }

        public virtual AG AG { get; set; }
        public virtual BALIK BALIK { get; set; }
        public virtual HUCRE HUCRE { get; set; }
        public virtual KAFES KAFES { get; set; }
        public virtual KULLANICI KULLANICI { get; set; }
        public virtual KUS_AGI KUS_AGI { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM
    {
        public int ISLEM_ID { get; set; }
        public string ISLEM_KOD { get; set; }
        public string UZUNLUK_BIRIMI { get; set; }
        public Nullable<decimal> UZUNLUK_DEGERI { get; set; }
        public string AGIRLIK_BIRIMI { get; set; }
        public Nullable<decimal> AGIRLIK_DEGERI { get; set; }
        public string PARA_BIRIMI { get; set; }
        public Nullable<decimal> PARA_DEGERI { get; set; }
        public string HACIM_BIRIMI { get; set; }
        public Nullable<decimal> HACIM_DEGERI { get; set; }
        public Nullable<int> FIRMA_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public Nullable<int> PLATFORM_KOD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public Nullable<int> KUS_AGI_KOD { get; set; }
        public Nullable<int> AG_KOD { get; set; }
        public Nullable<int> BALIK_KOD { get; set; }
        public Nullable<int> YEM_KOD { get; set; }
        public Nullable<int> ONCEKI_ISLEM_ID { get; set; }
        public Nullable<int> STOK_KOD { get; set; }
        public Nullable<int> HUCRE_KOD { get; set; }

        public virtual STOK STOK { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_ADIMLARI
    {
        public string ISLEM_ADIM_KODU { get; set; }
        public string ISLEM_ADIM_ADI { get; set; }
        public string ISLEM_ADIM_ACIKLAMA { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_BALIK_HASAT
    {
        public int ISLEM_KOD { get; set; }
        public int BALIK_KOD { get; set; }
        public int ADET { get; set; }
        public string ORTALAMA_AGIRLIK_BIRIMI { get; set; }
        public decimal ORTALAMA_AGIRLIK { get; set; }
        public string TOPLAM_AGIRLIK_BIRIMI { get; set; }
        public decimal TOPLAM_AGIRLIK { get; set; }
        public System.DateTime TARIH { get; set; }
        public int AG_KOD { get; set; }
        public int KAFES_KOD { get; set; }
        public int PLATFORM_KOD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_KODLARI
    {
        public ISLEM_KODLARI()
        {
            this.ISLEM_PARAMETRELERI = new HashSet<ISLEM_PARAMETRELERI>();
        }

        public string ISLEM_KOD { get; set; }
        public string ISLEM_KOD_ACIKLAMA { get; set; }
        public string ISLEM_HEDEF_NESNE { get; set; }
        public string ISLEM_KAYNAK_NESNE { get; set; }

        public virtual ICollection<ISLEM_PARAMETRELERI> ISLEM_PARAMETRELERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_KULLANICI_ROLLERI
    {
        public int ISLEM_KULLANICI_ROL_ID { get; set; }
        public int KULLANICI_ID { get; set; }
        public int ISLEM_ROL_ID { get; set; }
        public bool IPTAL { get; set; }

        public virtual ISLEM_ROL ISLEM_ROL { get; set; }
        public virtual KULLANICI KULLANICI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_OLU_BALIK
    {
        public int ISLEM_KOD { get; set; }
        public int BALIK_KOD { get; set; }
        public int ADET { get; set; }
        public string ORTALAMA_AGIRLIK_BIRIMI { get; set; }
        public decimal ORTALAMA_AGIRLIK { get; set; }
        public string TOPLAM_AGIRLIK_BIRIMI { get; set; }
        public decimal TOPLAM_AGIRLIK { get; set; }
        public System.DateTime TARIH { get; set; }
        public int AG_KOD { get; set; }
        public int KAFES_KOD { get; set; }
        public int PLATFORM_KOD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_PARAMETRELERI
    {
        public int PARAMETRE_KOD { get; set; }
        public string ISLEM_KOD { get; set; }
        public string TABLO_ADI { get; set; }
        public string KOLON_ADI { get; set; }
        public Nullable<int> ZORUNLU { get; set; }
        public string VERI_TURU { get; set; }
        public string COKLU_SECIM_SQL_KEY { get; set; }

        public virtual ISLEM_KODLARI ISLEM_KODLARI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_ROL
    {
        public ISLEM_ROL()
        {
            this.ISLEM_KULLANICI_ROLLERI = new HashSet<ISLEM_KULLANICI_ROLLERI>();
            this.ISLEM_YETKI_ROL = new HashSet<ISLEM_YETKI_ROL>();
        }

        public int ISLEM_ROL_ID { get; set; }
        public string AD { get; set; }
        public bool IPTAL { get; set; }

        public virtual ICollection<ISLEM_KULLANICI_ROLLERI> ISLEM_KULLANICI_ROLLERI { get; set; }
        public virtual ICollection<ISLEM_YETKI_ROL> ISLEM_YETKI_ROL { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_TANIM
    {
        public ISLEM_TANIM()
        {
            this.C_ISLEM_TANIM_LOG = new HashSet<C_ISLEM_TANIM_LOG>();
            this.ISLEM_YETKI_ROL = new HashSet<ISLEM_YETKI_ROL>();
            this.ISLEM_TANIM_VERSIYON = new HashSet<ISLEM_TANIM_VERSIYON>();
        }

        public int Id { get; set; }
        public string TABLO_ADI { get; set; }
        public string SAYFA { get; set; }
        public string ISLEM_ADI { get; set; }
        public string ISLEM_KODU { get; set; }
        public string SQL_KODU { get; set; }
        public string ACIKLAMA { get; set; }
        public string CSS { get; set; }
        public string ICON_CSS { get; set; }
        public bool AKTIF { get; set; }
        public string GOSTERIM_KONUMLARI { get; set; }
        public string SQL_KODU_TEST { get; set; }
        public string FORM_PARAMETERS { get; set; }

        public virtual ICollection<C_ISLEM_TANIM_LOG> C_ISLEM_TANIM_LOG { get; set; }
        public virtual ICollection<ISLEM_YETKI_ROL> ISLEM_YETKI_ROL { get; set; }
        public virtual ICollection<ISLEM_TANIM_VERSIYON> ISLEM_TANIM_VERSIYON { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_TANIM_VERSIYON
    {
        public int Id { get; set; }
        public int ISLEM_TANIM_ID { get; set; }
        public int VERSION_NO { get; set; }
        public int KULLANICI_KOD { get; set; }
        public string SQL_KODU { get; set; }
        public string ACIKLAMA { get; set; }
        public string CSS { get; set; }
        public string ICON_CSS { get; set; }
        public string GOSTERIM_KONUMLARI { get; set; }
        public string FORM_PARAMETERS { get; set; }

        public virtual ISLEM_TANIM ISLEM_TANIM { get; set; }
        public virtual KULLANICI KULLANICI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_YEMLEME
    {
        public int ISLEM_KOD { get; set; }
        public int BALIK_KOD { get; set; }
        public int YEM_TUR_KOD { get; set; }
        public string AGIRLIK_BIRIMI { get; set; }
        public decimal AGIRLIK_DEGERI { get; set; }
        public System.DateTime TARIH { get; set; }
        public int AG_KOD { get; set; }
        public int KAFES_KOD { get; set; }
        public int PLATFORM_KOD { get; set; }

        public virtual AG AG { get; set; }
        public virtual AGIRLIK_BIRIMLERI AGIRLIK_BIRIMLERI { get; set; }
        public virtual BALIK BALIK { get; set; }
        public virtual KAFES KAFES { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
        public virtual YEM_TURLERI YEM_TURLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEM_YETKI_ROL
    {
        public int ISLEM_YETKI_ROL_ID { get; set; }
        public int ISLEM_TANIM_ID { get; set; }
        public int ISLEM_ROL_ID { get; set; }

        public virtual ISLEM_ROL ISLEM_ROL { get; set; }
        public virtual ISLEM_TANIM ISLEM_TANIM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class ISLEMLER
    {
        public string ISLEM_KODU { get; set; }
        public string ISLEM_ADI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KAFES
    {
        public KAFES()
        {
            this.AG = new HashSet<AG>();
            this.BALIK = new HashSet<BALIK>();
            this.HUCRE = new HashSet<HUCRE>();
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
            this.ISLEM_YEMLEME = new HashSet<ISLEM_YEMLEME>();
            this.KUS_AGI = new HashSet<KUS_AGI>();
        }

        public int KAFES_KOD { get; set; }
        public string KAFES_AD { get; set; }
        public int KAFES_SEKIL_KOD { get; set; }
        public Nullable<int> PLATFORM_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }
        public int KULLANICI_KAYIT_EDEN { get; set; }
        public string KULLANICI_GUNCELLEYEN { get; set; }
        public Nullable<System.DateTime> KAYIT_TARIHI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }
        public Nullable<decimal> MALIYET { get; set; }
        public string MALIYET_BIRIM_KODU { get; set; }

        public virtual ICollection<AG> AG { get; set; }
        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD { get; set; }
        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual CIFTLIK CIFTLIK { get; set; }
        public virtual ICollection<HUCRE> HUCRE { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual ICollection<ISLEM_YEMLEME> ISLEM_YEMLEME { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
        public virtual SEKIL SEKIL { get; set; }
        public virtual ICollection<KUS_AGI> KUS_AGI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KIMYASAL_KURALLARI
    {
        public int KOD { get; set; }
        public Nullable<int> KIMYASAL_KOD { get; set; }
        public Nullable<int> KIMYASAL_TUR_KOD { get; set; }
        public Nullable<int> BALIK_TUR_KOD { get; set; }
        public int KULLANMA_IZNI_MG_LT_BAS { get; set; }
        public int KULLANMA_IZNI_MG_LT_BIT { get; set; }
        public int KULLANMA_SURE_DK { get; set; }
        public int ARINMA_SURE_GUN { get; set; }

        public virtual KIMYASAL_TURLERI KIMYASAL_TURLERI { get; set; }
        public virtual KIMYASALLAR KIMYASALLAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KIMYASAL_TURLERI
    {
        public KIMYASAL_TURLERI()
        {
            this.KIMYASAL_KURALLARI = new HashSet<KIMYASAL_KURALLARI>();
            this.KIMYASALLAR = new HashSet<KIMYASALLAR>();
        }

        public int KIMYASAL_TUR_KOD { get; set; }
        public string AD { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }
        public string KISA_AD { get; set; }

        public virtual ICollection<KIMYASAL_KURALLARI> KIMYASAL_KURALLARI { get; set; }
        public virtual ICollection<KIMYASALLAR> KIMYASALLAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KIMYASALLAR
    {
        public KIMYASALLAR()
        {
            this.KIMYASAL_KURALLARI = new HashSet<KIMYASAL_KURALLARI>();
        }

        public int KIMYASAL_KOD { get; set; }
        public string AD { get; set; }
        public string ACIKLAMA { get; set; }
        public int KIMYASAL_TUR_KOD { get; set; }
        public string KISA_AD { get; set; }
        public bool AKTIF { get; set; }
        public bool ARINMA_GEREKLI { get; set; }

        public virtual ICollection<KIMYASAL_KURALLARI> KIMYASAL_KURALLARI { get; set; }
        public virtual KIMYASAL_TURLERI KIMYASAL_TURLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KONUM
    {
        public int KONUM_KOD { get; set; }
        public string KONUM_AD { get; set; }
        public string KONUM_ACIKLAMA { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KULLANICI
    {
        public KULLANICI()
        {
            this.C_ISLEM_STANDART_LOG = new HashSet<C_ISLEM_STANDART_LOG>();
            this.C_ISLEM_TANIM_LOG = new HashSet<C_ISLEM_TANIM_LOG>();
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
            this.ISLEM_KULLANICI_ROLLERI = new HashSet<ISLEM_KULLANICI_ROLLERI>();
            this.ISLEM_TANIM_VERSIYON = new HashSet<ISLEM_TANIM_VERSIYON>();
            this.KULLANICI_BILDIRIMLERI = new HashSet<KULLANICI_BILDIRIMLERI>();
        }

        public int KULLANICI_KOD { get; set; }
        public string KULLANICI_AD { get; set; }
        public string KULLANICI_SOYAD { get; set; }
        public string KULLANICI_EPOSTA { get; set; }
        public string KULLANICI_GIRIS_KOD { get; set; }
        public string KULLANICI_SIFRE { get; set; }
        public Nullable<int> KULLANICI_YETKI { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }
        public bool KULLANICI_ERISIM { get; set; }
        public string KULLANICI_RESIM_DOSYA_ID { get; set; }
        public string KULLANICI_LOGS { get; set; }
        public Nullable<int> GOREV_KOD { get; set; }
        public Nullable<int> CURRENT_PLATFORM_KOD { get; set; }
        public string LAST_SIDE_MENU { get; set; }

        public virtual ICollection<C_ISLEM_STANDART_LOG> C_ISLEM_STANDART_LOG { get; set; }
        public virtual ICollection<C_ISLEM_TANIM_LOG> C_ISLEM_TANIM_LOG { get; set; }
        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD { get; set; }
        public virtual GOREV GOREV { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual ICollection<ISLEM_KULLANICI_ROLLERI> ISLEM_KULLANICI_ROLLERI { get; set; }
        public virtual ICollection<ISLEM_TANIM_VERSIYON> ISLEM_TANIM_VERSIYON { get; set; }
        public virtual ICollection<KULLANICI_BILDIRIMLERI> KULLANICI_BILDIRIMLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KULLANICI_BILDIRIMLERI
    {
        public int KULLANICI_KODU { get; set; }
        public string BILDIRIM_TUR_KODU { get; set; }
        public bool AKTIF { get; set; }

        public virtual BILDIRIM_TURLERI BILDIRIM_TURLERI { get; set; }
        public virtual KULLANICI KULLANICI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KUS_AGI
    {
        public KUS_AGI()
        {
            this.BALIK = new HashSet<BALIK>();
            this.HUCRE = new HashSet<HUCRE>();
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
        }

        public int KUS_AGI_KOD { get; set; }
        public string KUS_AGI_AD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public Nullable<int> PLATFORM_KOD { get; set; }
        public Nullable<int> CIFTLIK_KOD { get; set; }

        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual CIFTLIK CIFTLIK { get; set; }
        public virtual ICollection<HUCRE> HUCRE { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual KAFES KAFES { get; set; }
        public virtual PLATFORM PLATFORM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KUTUPHANE
    {
        public KUTUPHANE()
        {
            this.KUTUPHANE_BAGLANTI = new HashSet<KUTUPHANE_BAGLANTI>();
            this.KUTUPHANE_DOSYA = new HashSet<KUTUPHANE_DOSYA>();
        }

        public string KUTUPHANE_KOD { get; set; }
        public string KUTUPHANE_AD { get; set; }
        public string KUTUPHANE_TUR { get; set; }
        public bool AKTIF { get; set; }
        public string ACIKLAMA { get; set; }

        public virtual ICollection<KUTUPHANE_BAGLANTI> KUTUPHANE_BAGLANTI { get; set; }
        public virtual ICollection<KUTUPHANE_DOSYA> KUTUPHANE_DOSYA { get; set; }
        public virtual KUTUPHANE_TURLER KUTUPHANE_TURLER { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KUTUPHANE_BAGLANTI
    {
        public int Id { get; set; }
        public string TABLO_AD { get; set; }
        public string KAYIT_ID { get; set; }
        public string KUTUPHANE_KOD { get; set; }

        public virtual C_TABLOLAR C_TABLOLAR { get; set; }
        public virtual KUTUPHANE KUTUPHANE { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KUTUPHANE_DOSYA
    {
        public int Id { get; set; }
        public string KUTUPHANE_ID { get; set; }
        public string DOSYA_TUR_KOD { get; set; }
        public string DOSYA_AD { get; set; }
        public int SIRA { get; set; }
        public bool AKTIF { get; set; }

        public virtual KUTUPHANE KUTUPHANE { get; set; }
        public virtual KUTUPHANE_DOSYA_TUR KUTUPHANE_DOSYA_TUR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KUTUPHANE_DOSYA_TUR
    {
        public KUTUPHANE_DOSYA_TUR()
        {
            this.KUTUPHANE_DOSYA = new HashSet<KUTUPHANE_DOSYA>();
        }

        public string DOSYA_TUR_KOD { get; set; }
        public string AD { get; set; }
        public bool AKTIF { get; set; }

        public virtual ICollection<KUTUPHANE_DOSYA> KUTUPHANE_DOSYA { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class KUTUPHANE_TURLER
    {
        public KUTUPHANE_TURLER()
        {
            this.KUTUPHANE = new HashSet<KUTUPHANE>();
        }

        public string KUTUPHANE_TUR_KOD { get; set; }
        public string AD { get; set; }
        public string ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }

        public virtual ICollection<KUTUPHANE> KUTUPHANE { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class MENULER
    {
        public MENULER()
        {
            this.MENULER1 = new HashSet<MENULER>();
        }

        public string MENU_KOD { get; set; }
        public string MENU_AD { get; set; }
        public int AKTIF { get; set; }
        public int YETKI { get; set; }
        public string UST_MENU { get; set; }
        public int SIRA { get; set; }
        public string MENU_ICON_CLASS { get; set; }
        public string CUSTOM_URL { get; set; }

        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD { get; set; }
        public virtual ICollection<MENULER> MENULER1 { get; set; }
        public virtual MENULER MENULER2 { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class MESAJLAR
    {
        public int ID { get; set; }
        public string GONDEREN { get; set; }
        public string GONDERILEN { get; set; }
        public System.DateTime GONDERILME_TARIHI { get; set; }
        public bool OKUNDU { get; set; }
        public int OLAY_KODU { get; set; }
        public string MESAJ_ICERIGI { get; set; }
        public Nullable<System.DateTime> OKUNMA_TARIHI { get; set; }

        public virtual OLAYLAR OLAYLAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class MEVSIMLER
    {
        public MEVSIMLER()
        {
            this.YEM_KURAL_ZAMAN = new HashSet<YEM_KURAL_ZAMAN>();
        }

        public string MEVSIM_KOD { get; set; }
        public string MEVSIM_AD { get; set; }

        public virtual ICollection<YEM_KURAL_ZAMAN> YEM_KURAL_ZAMAN { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class OLAY_TURLERI
    {
        public OLAY_TURLERI()
        {
            this.OLAYLAR = new HashSet<OLAYLAR>();
        }

        public string OLAY_TUR_KODU { get; set; }
        public string BASLIK { get; set; }
        public string ACIKLAMA { get; set; }
        public string BASLIK_TEMA { get; set; }
        public string E_POSTA_TEMA { get; set; }
        public string MESAJ_TEMA { get; set; }
        public string SMS_TEMA { get; set; }
        public bool E_POSTA_AKTIF { get; set; }
        public bool MESAJ_AKTIF { get; set; }
        public bool SMS_AKTIF { get; set; }
        public string BILDIRIM_TUR_KODU { get; set; }

        public virtual BILDIRIM_TURLERI BILDIRIM_TURLERI { get; set; }
        public virtual ICollection<OLAYLAR> OLAYLAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class OLAYLAR
    {
        public OLAYLAR()
        {
            this.MESAJLAR = new HashSet<MESAJLAR>();
        }

        public int OLAY_KODU { get; set; }
        public string OLAY_TUR_KODU { get; set; }
        public System.DateTime OLAY_TARIHI { get; set; }
        public string OLAY_BASLIK { get; set; }
        public string OLAY_ACIKLAMA { get; set; }
        public bool BASARILI { get; set; }

        public virtual ICollection<MESAJLAR> MESAJLAR { get; set; }
        public virtual OLAY_TURLERI OLAY_TURLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class PARA_BIRIM_LOG
    {
        public int Id { get; set; }
        public string VERI_TIPI { get; set; }
        public string VERI_DEGERI { get; set; }
        public string PARA_BIRIMI { get; set; }
        public Nullable<decimal> KUR_ORANI { get; set; }
        public string TUTAR { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }

        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class PARA_BIRIMI_LOG
    {
        public int Id { get; set; }
        public string VERI_TIPI { get; set; }
        public string VERI_DEGERI { get; set; }
        public string PARA_BIRIMI { get; set; }
        public Nullable<decimal> KUR_ORANI { get; set; }
        public string TUTAR { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class PARA_BIRIMLERI
    {
        public PARA_BIRIMLERI()
        {
            this.AG = new HashSet<AG>();
            this.DEMIRBAS = new HashSet<DEMIRBAS>();
            this.KAFES = new HashSet<KAFES>();
            this.PARA_BIRIM_LOG = new HashSet<PARA_BIRIM_LOG>();
            this.PLATFORM = new HashSet<PLATFORM>();
            this.STOK = new HashSet<STOK>();
            this.YAVRU_BALIK = new HashSet<YAVRU_BALIK>();
            this.YEM = new HashSet<YEM>();
        }

        public string BIRIM_KOD { get; set; }
        public decimal PARA_DEGER { get; set; }

        public virtual ICollection<AG> AG { get; set; }
        public virtual ICollection<DEMIRBAS> DEMIRBAS { get; set; }
        public virtual ICollection<KAFES> KAFES { get; set; }
        public virtual ICollection<PARA_BIRIM_LOG> PARA_BIRIM_LOG { get; set; }
        public virtual ICollection<PLATFORM> PLATFORM { get; set; }
        public virtual ICollection<STOK> STOK { get; set; }
        public virtual ICollection<YAVRU_BALIK> YAVRU_BALIK { get; set; }
        public virtual ICollection<YEM> YEM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class Pictures
    {
        public int Id { get; set; }
        public string FileName { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class PLATFORM
    {
        public PLATFORM()
        {
            this.AG = new HashSet<AG>();
            this.BALIK = new HashSet<BALIK>();
            this.HUCRE = new HashSet<HUCRE>();
            this.HUCRE_DEGISIMLERI = new HashSet<HUCRE_DEGISIMLERI>();
            this.ISLEM_YEMLEME = new HashSet<ISLEM_YEMLEME>();
            this.KAFES = new HashSet<KAFES>();
            this.KUS_AGI = new HashSet<KUS_AGI>();
        }

        public int PLATFORM_KOD { get; set; }
        public string PLATFORM_AD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }
        public int SATIR { get; set; }
        public int SUTUN { get; set; }
        public int KULLANICI_KAYIT_EDEN { get; set; }
        public string KULLANICI_GUNCELLEYEN { get; set; }
        public Nullable<System.DateTime> KAYIT_TARIHI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }
        public Nullable<decimal> MALIYET_TUTAR { get; set; }
        public string MALIYET_PARA_BIRIMI { get; set; }
        public Nullable<System.DateTime> GIDER_YANSIMA_TARIHI { get; set; }

        public virtual ICollection<AG> AG { get; set; }
        public virtual AKTIF_DURUM_KOD AKTIF_DURUM_KOD { get; set; }
        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual CIFTLIK CIFTLIK { get; set; }
        public virtual ICollection<HUCRE> HUCRE { get; set; }
        public virtual ICollection<HUCRE_DEGISIMLERI> HUCRE_DEGISIMLERI { get; set; }
        public virtual ICollection<ISLEM_YEMLEME> ISLEM_YEMLEME { get; set; }
        public virtual ICollection<KAFES> KAFES { get; set; }
        public virtual ICollection<KUS_AGI> KUS_AGI { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class PLATFORM_HUCRELERI
    {
        public string HUCRE_KOD { get; set; }
        public int PLAFORM_ID { get; set; }
        public int X_NO { get; set; }
        public int Y_NO { get; set; }
        public int AG_KODU { get; set; }
        public int KUS_AGI_KODU { get; set; }
        public int BALIK_KODU { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class RAPOR_SABLONLAR
    {
        public RAPOR_SABLONLAR()
        {
            this.RAPORLAR = new HashSet<RAPORLAR>();
        }

        public string SABLON_KOD { get; set; }
        public string SABLON_AD { get; set; }
        public string ACIKLAMA { get; set; }
        public string SABLON { get; set; }
        public Nullable<bool> AKTIF { get; set; }

        public virtual ICollection<RAPORLAR> RAPORLAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class RAPORLAR
    {
        public int Id { get; set; }
        public string RAPOR_KOD { get; set; }
        public string RAPOR_SABLON { get; set; }
        public string ITEM_SABLON { get; set; }
        public bool AKTIF { get; set; }
        public string SQL_KOD { get; set; }
        public string FORM_PARAMETERS { get; set; }
        public string HEAD_RAW { get; set; }
        public string BODY_BEFORE_RAW { get; set; }
        public string SABLON_KOD { get; set; }

        public virtual RAPOR_SABLONLAR RAPOR_SABLONLAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class SEKIL
    {
        public SEKIL()
        {
            this.AG = new HashSet<AG>();
            this.AG1 = new HashSet<AG>();
            this.KAFES = new HashSet<KAFES>();
        }

        public int SEKIL_KOD { get; set; }
        public string SEKIL_AD { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }
        public string SEKIL_RESIM { get; set; }

        public virtual ICollection<AG> AG { get; set; }
        public virtual ICollection<AG> AG1 { get; set; }
        public virtual ICollection<KAFES> KAFES { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class SICAKLIK_YEMLEME_ORANI
    {
        public int SICAKLIK_YEMLEME_ORANI_KODU { get; set; }
        public Nullable<int> BALIK_TUR_KOD { get; set; }
        public int SICAKLIK_BAS { get; set; }
        public int SICAKLIK_BIT { get; set; }
        public decimal YEM_YUZDESI { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class SQL_KODLARI
    {
        public string SQL_KEY { get; set; }
        public string SQL_TIPI { get; set; }
        public string SQL_QUERY { get; set; }
        public string PARAMETERS { get; set; }
        public string ROLLBACK_QUERY { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class STOK
    {
        public STOK()
        {
            this.ISLEM = new HashSet<ISLEM>();
        }

        public int STOK_KOD { get; set; }
        public System.DateTime KAYIT_TARIHI { get; set; }
        public System.DateTime STOK_TARIHI { get; set; }
        public string BIRIM_TURU { get; set; }
        public decimal MIKTAR { get; set; }
        public string STOK_TURU { get; set; }
        public int AKTIF { get; set; }
        public string ACIKLAMA { get; set; }
        public decimal TUTAR { get; set; }
        public string TUTAR_BIRIM_KOD { get; set; }
        public string UZUNLUK_BIRIM_KODU { get; set; }
        public string AGIRLIK_BIRIM_KODU { get; set; }
        public Nullable<int> FIRMA_KODU { get; set; }

        public virtual AGIRLIK_BIRIMLERI AGIRLIK_BIRIMLERI { get; set; }
        public virtual BIRIM_TURLERI BIRIM_TURLERI { get; set; }
        public virtual FIRMA FIRMA { get; set; }
        public virtual ICollection<ISLEM> ISLEM { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
        public virtual STOK_TURLERI STOK_TURLERI { get; set; }
        public virtual UZUNLUK_BIRIMLERI UZUNLUK_BIRIMLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class STOK_TURLERI
    {
        public STOK_TURLERI()
        {
            this.STOK = new HashSet<STOK>();
        }

        public string STOK_TURU_KODU { get; set; }
        public string STOK_TURU_ACIKLAMA { get; set; }
        public string BIRIM_KODU { get; set; }
        public bool TEKIL_STOK { get; set; }

        public virtual BIRIM_TURLERI BIRIM_TURLERI { get; set; }
        public virtual ICollection<STOK> STOK { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class UserLevelPermissions
    {
        public int UserLevelID { get; set; }
        public string TableName { get; set; }
        public int Permission { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class UserLevels
    {
        public int UserLevelID { get; set; }
        public string UserLevelName { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class UZUNLUK_BIRIMLERI
    {
        public UZUNLUK_BIRIMLERI()
        {
            this.STOK = new HashSet<STOK>();
            this.YEM_TURLERI = new HashSet<YEM_TURLERI>();
            this.YEM = new HashSet<YEM>();
        }

        public string BIRIM_KOD { get; set; }
        public decimal UZUNLUK_DEGER { get; set; }

        public virtual ICollection<STOK> STOK { get; set; }
        public virtual ICollection<YEM_TURLERI> YEM_TURLERI { get; set; }
        public virtual ICollection<YEM> YEM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_AKTIF_AGLAR
    {
        public string AG_AD { get; set; }
        public decimal AG_DERINLIK { get; set; }
        public decimal AG_YARICAP { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public string CIFTLIK_AD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_AKTIF_FIRMALAR
    {
        public string FIRMA_AD { get; set; }
        public string FIRMA_TUR_AD { get; set; }
        public int FIRMA_KOD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_BAKIM_FIRMALARI
    {
        public string FIRMA_AD { get; set; }
        public string FIRMA_TUR_AD { get; set; }
        public int FIRMA_KOD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_BALIK
    {
        public int BALIK_KOD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public string BALIK_TUR_ADI { get; set; }
        public string BALIK_TUR_ACIKLAMA { get; set; }
        public string BALIK_KOD_AD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_BALIK_SEC
    {
        public int BALIK_KOD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public string BALIK_TUR_ADI { get; set; }
        public string BALIK_TUR_ACIKLAMA { get; set; }
        public string BALIK_KOD_AD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_COLUMN_LIST
    {
        public string Database_Name { get; set; }
        public string Schema_Name { get; set; }
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public string Column_Data_Type { get; set; }
        public string Column_System_Type { get; set; }
        public short Column_Maximum_Length { get; set; }
        public byte Column_Precision { get; set; }
        public byte Column_Scale { get; set; }
        public string Column_Is_Nullable { get; set; }
        public string Column_Has_Identity { get; set; }
        public string Column_Is_Computed { get; set; }
        public string Computed_Column_Definition { get; set; }
        public int Column_Id { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_COLUMN_LIST_ALL
    {
        public string Database_Name { get; set; }
        public string Schema_Name { get; set; }
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public string Column_Data_Type { get; set; }
        public string Column_System_Type { get; set; }
        public short Column_Maximum_Length { get; set; }
        public byte Column_Precision { get; set; }
        public byte Column_Scale { get; set; }
        public string Column_Is_Nullable { get; set; }
        public string Column_Has_Identity { get; set; }
        public string Column_Is_Computed { get; set; }
        public string Computed_Column_Definition { get; set; }
        public int Column_Id { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_FN_LIST
    {
        public string schema_name { get; set; }
        public string function_name { get; set; }
        public string type { get; set; }
        public string parameters { get; set; }
        public string definition { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_HUCRE_OZET
    {
        public int HUCRE_KOD { get; set; }
        public int SATIR_INDEX { get; set; }
        public int SUTUN_INDEX { get; set; }
        public string HUCRE_MATRIX { get; set; }
        public Nullable<int> BALIK_KOD { get; set; }
        public Nullable<int> AG_KOD { get; set; }
        public Nullable<int> KUS_AGI_KOD { get; set; }
        public Nullable<int> KAFES_KOD { get; set; }
        public int PLATFORM_KOD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public string PLATFORM_AD { get; set; }
        public string KAFES_AD { get; set; }
        public string CIFTLIK_AD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public string BALIK_TUR_ADI { get; set; }
        public string BALIK_TUR_ACIKLAMA { get; set; }
        public string KUS_AGI_AD { get; set; }
        public string AG_AD { get; set; }
        public decimal AG_YARICAP { get; set; }
        public decimal AG_DERINLIK { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_ISLEM_BALIK_YEMLEME
    {
        public string ISLEM_KOD { get; set; }
        public string AGIRLIK_BIRIMI { get; set; }
        public Nullable<decimal> AGIRLIK_DEGERI { get; set; }
        public Nullable<int> BALIK_KOD { get; set; }
        public Nullable<int> YEM_KOD { get; set; }
        public string AG_AD { get; set; }
        public string KAFES_AD { get; set; }
        public string YEM_AD { get; set; }
        public string YEM_TUR_AD { get; set; }
        public int YEM_TUR_KOD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public string BALIK_TUR_ADI { get; set; }
        public string ISLEM_KOD_ACIKLAMA { get; set; }
        public int ISLEM_ID { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_ISLEM_TANIM_LOG
    {
        public int Id { get; set; }
        public int ISLEM_TANIM_ID { get; set; }
        public string SQL_KODU { get; set; }
        public int KULLANICI_KOD { get; set; }
        public string PARAMETERS_JSON { get; set; }
        public bool IS_SUCCESS { get; set; }
        public string ERROR_MESSAGE { get; set; }
        public string ERROR_STACKTRACE { get; set; }
        public System.DateTime TARIH { get; set; }
        public string KULLANICI_AD { get; set; }
        public string KULLANICI_SOYAD { get; set; }
        public string GOREV_AD { get; set; }
        public Nullable<int> GOREV_KOD { get; set; }
        public int AKTIF { get; set; }
        public string ISLEM_ADI { get; set; }
        public string ISLEM_KODU { get; set; }
        public string SAYFA { get; set; }
        public string TABLO_ADI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_PLATFORM_OZET
    {
        public int PLATFORM_KOD { get; set; }
        public string PLATFORM_AD { get; set; }
        public string PLATFORM_AD_CIFTLIK_AD { get; set; }
        public string CIFTLIK_AD_PLATFORM_AD { get; set; }
        public int CIFTLIK_KOD { get; set; }
        public int AKTIF { get; set; }
        public int KAYIT_DURUM { get; set; }
        public int SATIR { get; set; }
        public int SUTUN { get; set; }
        public int KULLANICI_KAYIT_EDEN { get; set; }
        public string KULLANICI_GUNCELLEYEN { get; set; }
        public Nullable<System.DateTime> KAYIT_TARIHI { get; set; }
        public Nullable<System.DateTime> GUNCELLEME_TARIHI { get; set; }
        public string CIFTLIK_AD { get; set; }
        public Nullable<int> CIFTLIK_AKTIF { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_SP_LIST
    {
        public string schema_name { get; set; }
        public string procedure_name { get; set; }
        public string type { get; set; }
        public string parameters { get; set; }
        public string definition { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_SYS_TABLOLAR
    {
        public int TABLE_ID { get; set; }
        public string TABLE_NAME { get; set; }
        public Nullable<int> STATUS { get; set; }
        public Nullable<int> CATEGORY { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_TABLE_LIST_ALL
    {
        public string Database_Name { get; set; }
        public string Schema_Name { get; set; }
        public string Table_Name { get; set; }
        public string Column_Name { get; set; }
        public string Column_Data_Type { get; set; }
        public string Column_System_Type { get; set; }
        public short Column_Maximum_Length { get; set; }
        public byte Column_Precision { get; set; }
        public byte Column_Scale { get; set; }
        public string Column_Is_Nullable { get; set; }
        public string Column_Has_Identity { get; set; }
        public string Column_Is_Computed { get; set; }
        public string Computed_Column_Definition { get; set; }
        public int Column_Id { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_TRIGER_LIST
    {
        public string schema_name { get; set; }
        public string triger_name { get; set; }
        public string type { get; set; }
        public string parameters { get; set; }
        public string definition { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_VIEW_LIST
    {
        public string schema_name { get; set; }
        public string view_name { get; set; }
        public string type { get; set; }
        public string parameters { get; set; }
        public string definition { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_YEM
    {
        public int YEM_KOD { get; set; }
        public string YEM_ACIKLAMA { get; set; }
        public string YEM_AD_TUR { get; set; }
        public string YEM_TUR_AD { get; set; }
        public int YEM_TUR_KOD { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_YEM_KULLANILAN_MIKTAR
    {
        public int YEM_TUR_KOD { get; set; }
        public string YEM_TUR_AD { get; set; }
        public Nullable<decimal> KULLANILAN_MIKTAR { get; set; }
        public string YEM_AD_VE_MIKTAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_YEM_SATIN_ALINAN_MIKTAR
    {
        public int YEM_TUR_KOD { get; set; }
        public string YEM_TUR_AD { get; set; }
        public Nullable<decimal> SATIN_ALINAN_MIKTAR { get; set; }
        public string YEM_AD_VE_MIKTAR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class V_YEM_STOK
    {
        public string YEM_TUR_AD { get; set; }
        public string STOK_MIKTARI { get; set; }
        public string YEM_TUR_VE_STOK { get; set; }
        public int YEM_TUR_KOD { get; set; }
        public Nullable<decimal> STOK { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YAVRU_BALIK
    {
        public YAVRU_BALIK()
        {
            this.BALIK = new HashSet<BALIK>();
            this.YAVRU_BALIK1 = new HashSet<YAVRU_BALIK>();
        }

        public int YAVRU_BALIK_KOD { get; set; }
        public string YAVRU_BALIK_ADI { get; set; }
        public string YAVRU_BALIK_ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }
        public Nullable<System.DateTime> LARVA_DOGUM_TARIHI { get; set; }
        public System.DateTime KAYIT_TARIHI { get; set; }
        public Nullable<int> KULLANICI_KAYIT_EDEN { get; set; }
        public Nullable<int> ANAC_BALIK_KOD { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public Nullable<System.DateTime> YUMURTA_TARIHI { get; set; }
        public int YAVRU_BALIK_ADET { get; set; }
        public decimal BOY_CM { get; set; }
        public bool BOYLANDI { get; set; }
        public Nullable<System.DateTime> BOYLAMA_TARIHI { get; set; }
        public Nullable<int> BOYLANAN_BALIK_KOD { get; set; }
        public Nullable<decimal> MALIYET_TUTAR { get; set; }
        public string MALIYET_BIRIM_KOD { get; set; }

        public virtual ANAC_BALIK ANAC_BALIK { get; set; }
        public virtual ICollection<BALIK> BALIK { get; set; }
        public virtual BALIK_TUR BALIK_TUR { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
        public virtual ICollection<YAVRU_BALIK> YAVRU_BALIK1 { get; set; }
        public virtual YAVRU_BALIK YAVRU_BALIK2 { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YEM
    {
        public int YEM_KOD { get; set; }
        public string YEM_ACIKLAMA { get; set; }
        public decimal YEM_STOK { get; set; }
        public string STOK_BIRIM_KOD { get; set; }
        public int YEM_TUR_KOD { get; set; }
        public decimal TUTAR { get; set; }
        public string TUTAR_PARA_BIRIM { get; set; }
        public decimal YEM_BOYUT { get; set; }
        public string YEM_BOYUT_BIRIM { get; set; }
        public string NOTLAR { get; set; }
        public System.DateTime KAYIT_TARIH { get; set; }
        public System.DateTime SATIN_ALMA_TARIH { get; set; }

        public virtual AGIRLIK_BIRIMLERI AGIRLIK_BIRIMLERI { get; set; }
        public virtual PARA_BIRIMLERI PARA_BIRIMLERI { get; set; }
        public virtual UZUNLUK_BIRIMLERI UZUNLUK_BIRIMLERI { get; set; }
        public virtual YEM_TURLERI YEM_TURLERI { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YEM_GELISIM_SURELERI
    {
        public int YEM_GELISIM_SURE_KOD { get; set; }
        public string AD { get; set; }
        public string ACIKLAMA { get; set; }
        public Nullable<int> BALIK_KOD { get; set; }
        public int BOY_BASLANGIC_CM { get; set; }
        public int BOY_BITIS_CM { get; set; }
        public decimal ORT_AGIRLIK_GR { get; set; }
        public int SURE_BAS_GUN { get; set; }
        public int SURE_BIT_GUN { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YEM_KURAL_BOYUT
    {
        public int KURAL_KOD { get; set; }
        public string KURAL_ADI { get; set; }
        public string KURAL_ACIKLAMA { get; set; }
        public string MESAJ_KOD { get; set; }
        public bool AKTIF { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public decimal BOYUT_BASLANGIC { get; set; }
        public string BOYUT_BASLANGIC_BIRIM { get; set; }
        public decimal BOYUT_BITIS { get; set; }
        public string BOYUT_BITIS_BIRIM { get; set; }
        public int BALIK_BOY_BASLANGIC_CM { get; set; }
        public int BALIK_BOY_BITIS_CM { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YEM_KURAL_ZAMAN
    {
        public int KURAL_KOD { get; set; }
        public string KURAL_ADI { get; set; }
        public string KURAL_ACIKLAMA { get; set; }
        public string MESAJ_KOD { get; set; }
        public bool AKTIF { get; set; }
        public int BALIK_TUR_KOD { get; set; }
        public int BASLAMA_ZAMANI_SAAT { get; set; }
        public int BASLAMA_ZAMANI_DAKIKA { get; set; }
        public string MEVSIM { get; set; }
        public int BITIS_ZAMANI_SAAT { get; set; }
        public int BITIS_ZAMANI_DAKIKA { get; set; }

        public virtual BALIK_TUR BALIK_TUR { get; set; }
        public virtual MEVSIMLER MEVSIMLER { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YEM_TURLERI
    {
        public YEM_TURLERI()
        {
            this.ISLEM_YEMLEME = new HashSet<ISLEM_YEMLEME>();
            this.YEM = new HashSet<YEM>();
        }

        public int YEM_TUR_KOD { get; set; }
        public string YEM_TUR_AD { get; set; }
        public Nullable<decimal> YEM_TUR_BOYUT { get; set; }
        public string YEM_TUR_BOYUT_BIRIM { get; set; }

        public virtual ICollection<ISLEM_YEMLEME> ISLEM_YEMLEME { get; set; }
        public virtual UZUNLUK_BIRIMLERI UZUNLUK_BIRIMLERI { get; set; }
        public virtual ICollection<YEM> YEM { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;
    using System.Collections.Generic;

    public partial class YEMLEME_YONTEMLERI
    {
        public string YEMLEME_YONTEM_KOD { get; set; }
        public string YONTEM_AD { get; set; }
        public string YONTEM_ACIKLAMA { get; set; }
        public bool AKTIF { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;

    public partial class sp_helpdiagramdefinition_Result
    {
        public Nullable<int> version { get; set; }
        public byte[] definition { get; set; }
    }
}
namespace DynamicMVC.UI.DB
{
    using System;

    public partial class sp_helpdiagrams_Result
    {
        public string Database { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Owner { get; set; }
        public int OwnerID { get; set; }
    }
}
