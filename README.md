﻿### Yapılacaklar 
- [X] Data katmanına ilgili classların oluşturulması
	- Kitap
        - Id Guid (contructor'da otomaik değer atansın.)
        - Ad string
        - BasimTarihi DateTimee
        - KitapTurEnum KitapTuru
        - YazarAd string
        - SayfaSayisi int
        - Aciklama string
    - KitapTurEnum
        - Egitim,Psikoloji,Korku,Biyografi,....
    - Kullanıcı
        - Id Guid (contructor'da otomaik değer atansın.)
        - AdSoyad string
        - KullaniciAdi string
        - Parola string
        - List< Kitap > OduncAlinanKitaplar
    - KullanıcıYontecisi
        - Kullanıcı listesi olmalı ve tüm işlemler bu liste üzerinden yapılmalı.
        - KayıtOl methodu
        - GirisYap methodu
        - KullaniciVarMi methodu
    - KutuphaneYoneticisi
        - Kitap listesi olmalı ve tüm işlemler bu liste üzerinden yapılmalı.
        - KitapBagisYap methodu
        - KitapImhaEt methodu
        - KitapOduncAl methodu parametre kullanıcı ve kitap
- [ ] Register ve Login sayfalarının tasarlanması
    - Görsel tasarımın yapılması.
    - Register sayfasında parola eşleşme kontrolü
    - Aynı kullanıcı adına sahip kişi var mı kontrolü
    - Register ve login işlemleri methodlar kullanılarak
    - Login başarılıysa KutuphaneForm acilsin. 
    - LoginForm açılır ve kapanırken Kullanıcıyoneticisini serialize ve deserialize ediniz.
- [ ] KutuphaneForm
    - KutuphaneForm açılır ve kapanırken kutuphaneyoneticisi serialize ve deserialize edilir.
    - 
- [ ] Sınıfların tasarlanması
- [ ] Sınıfların tasarlanması
 
#### Örnek tasarım
- BagisYap Form

![](./assets/bagisForm.png)

- Kutuphane Form

![](./assets/kutuphaneForm.png)

- Hesabim Form

![](./assets/hesabimForm.png)