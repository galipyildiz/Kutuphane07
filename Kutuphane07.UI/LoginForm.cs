using Kutuphane07.DATA;
using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class LoginForm : MetroForm
    {
        KullaniciYoneticisi kullaniciYoneticisi;
        public LoginForm()
        {
            InitializeComponent();
            //Debug.WriteLine("**********");
            //Debug.WriteLine(KullaniciYoneticisi.path);
            //Debug.WriteLine("**********");
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text) && !string.IsNullOrEmpty(txtParola.Text))
            {
                Kullanici girisYapanKullanici = kullaniciYoneticisi.GirisYap(txtKullaniciAdi.Text, txtParola.Text);
                if (girisYapanKullanici != null)
                {
                    KutuphaneForm kutuphaneForm = new KutuphaneForm(girisYapanKullanici);
                    kutuphaneForm.ShowDialog();
                }
                else
                {
                    MetroMessageBox.Show(this,"Kullanıcı adı yada parola hatalı!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Lütfen kullanıcı adı ve şifrenizi giriniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lnkLblKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(kullaniciYoneticisi);
            registerForm.ShowDialog();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Json kaydetme
            string json = JsonConvert.SerializeObject(kullaniciYoneticisi);
            File.WriteAllText(KullaniciYoneticisi.path, json);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Json okuma
            try
            {
                string json = File.ReadAllText(KullaniciYoneticisi.path);
                kullaniciYoneticisi = JsonConvert.DeserializeObject<KullaniciYoneticisi>(json);
            }
            catch (Exception)
            {
                kullaniciYoneticisi = new KullaniciYoneticisi();
            }
        }
    }
}
