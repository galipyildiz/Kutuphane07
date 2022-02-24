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
            Kullanicilar = new List<Kullanici>();
        }
        public List<Kullanici> Kullanicilar { get; set; }
        public bool KullaniciVarMi(string kullaniciAdi)
        {
            //TODO kullaniciAdi varsa true yoksa false dönmeli.
            return true;
        }
        public Kullanici GirisYap(string kullaniciAdi, string parola)
        {
            //TODO kullanıcı listesindeki kullanıcılardan kullaniciAdi ve parolası eşeleşen kullanıcıyı bularak onu return edicez.
            return new Kullanici();
        }
        public bool KayitOl(string adSoyad, string kullaniciAdi, string parola, string parolaTekrar)
        {
            //TODO gerekli parametreler ile kullanıcı listeye eklenbilirse true eklenemez ise false döndürücez. KullaniciVarMi metodundan faydalanılabilir.
            return true;
        }
    }
}
