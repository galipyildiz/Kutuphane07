using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KutuphaneYoneticisi
    {
        public static readonly string path = Environment.CurrentDirectory.Replace("Kutuphane07.UI\\bin\\Debug", "") + "kutuphaneveri.json";
        public KutuphaneYoneticisi()
        {
            Kitaplar = new List<Kitap>() 
            {
                new Kitap() 
                {
                    Aciklama = "Test",
                    Ad = "Test",
                    BasimTarihi = DateTime.Now,
                    KitapTur = KitapTurEnum.Tarih,
                    SayfaSayisi = 100,
                    YazarAd = "Test"
                },
                new Kitap()
                {
                    Aciklama = "Test",
                    Ad = "Test",
                    BasimTarihi = DateTime.Now,
                    KitapTur = KitapTurEnum.Tarih,
                    SayfaSayisi = 100,
                    YazarAd = "Test"
                }
            };
        }
        public List<Kitap> Kitaplar { get; set; }
        public void KitapBagisYap(string ad, DateTime basimTarihi, KitapTurEnum kitapTur, string yazarAd, int sayfaSayisi, string aciklama)
        {
            Kitaplar.Add(new Kitap()
            {
                 Ad = ad,
                 Aciklama = aciklama,
                 BasimTarihi = basimTarihi,
                 KitapTur = kitapTur,
                 SayfaSayisi = sayfaSayisi,
                 YazarAd = yazarAd
            });
        }
        public void KitapImhaEt(Guid kitapId)
        {
            //TODO listeden kitabı bularak silicez.
        }
        public void KitapOduncAl(Kullanici kullanici, Guid kitapId)
        {
            //TODO kitabın oduncalinmatarihini set ederiz ve kullanıcının odunc alınan kitaplarına ekleriz.
        }
        public void KitapTeslimEt()
        {
            //TODO
        }
    }
}
