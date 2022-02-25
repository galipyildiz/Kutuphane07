using Kutuphane07.DATA;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    MessageBox.Show("Kullanıcı adı yada parola hatalı!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz");
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
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            kullaniciYoneticisi = new KullaniciYoneticisi();
            //Json okuma
        }
    }
}
