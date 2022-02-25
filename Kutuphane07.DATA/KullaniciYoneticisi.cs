using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane07.DATA
{
    public class KullaniciYoneticisi
    {
        public KullaniciYoneticisi()
        {
            Kullanicilar = new List<Kullanici>()
            {
                new Kullanici(){ AdSoyad = "Galip yıldız", KullaniciAdi = "galip", Parola = "123" }
            };
        }
        public List<Kullanici> Kullanicilar { get; set; }
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            return Kullanicilar.Any(x=>x.KullaniciAdi == kullaniciAdi);
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            return Kullanicilar.FirstOrDefault(x=>x.KullaniciAdi == kullaniciAdi && x.Parola == parola);
        }
        public bool KayitOl(string adSoyad, string kullaniciAdi, string parola, string parolaTekrar)
        {
            //TODO gerekli parametreler ile kullanıcı listeye eklenbilirse true eklenemez ise false döndürücez. KullaniciVarMi metodundan faydalanılabilir.
            return true;
        }
    }
}
