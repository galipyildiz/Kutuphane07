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
    public partial class HesabimForm : MetroForm
    {
        private readonly Kullanici kullanici;

        public HesabimForm(Kullanici kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;
            KullaniciBilgiDoldur();
        }

        private void KullaniciBilgiDoldur()
        {
            lblId.Text += $"\r\n{kullanici.Id}";
            lblAdSoyad.Text += $"\r\n{kullanici.AdSoyad}";
            lblKullaniciAdi.Text += $"\r\n{kullanici.KullaniciAdi}";
            lblParola.Text += $"\r\n{kullanici.Parola}";
            dgvKitaplar.DataSource = kullanici.OduncAlinanKitaplar != null ? kullanici.OduncAlinanKitaplar : null;
            dgvKitaplar.Columns[0].Visible = false;
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].Visible = false;
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].Visible = false;
            dgvKitaplar.Columns[5].Visible = false;
            dgvKitaplar.Columns[6].Visible = false;
            dgvKitaplar.Columns[7].HeaderText = "Ödünç Alınma Tarihi";
        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            //TODO seçili kitabın odunc alinma tarihini null yapıcaz ve kullanıcının kitaplarından silicez.
        }
    }
}
