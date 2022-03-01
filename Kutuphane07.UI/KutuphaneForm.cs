using Kutuphane07.DATA;
using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane07.UI
{
    public partial class KutuphaneForm : MetroForm
    {
        private readonly Kullanici girisYapan;
        KutuphaneYoneticisi kutuphaneYoneticisi;
        public KutuphaneForm(Kullanici girisYapan)
        {
            InitializeComponent();
            this.girisYapan = girisYapan;
        }

        private void TurleriYukle()
        {
            cmbTurler.Items.Add("Hepsi");
            cmbTurler.Items.AddRange(Enum.GetValues(typeof(KitapTurEnum)).Cast<object>().ToArray());
            cmbTurler.SelectedIndex = 0;
        }

        private void KutuphaneForm_Load(object sender, EventArgs e)
        {
            try
            {
                VerileriOku();
                Listele();
            }
            catch (Exception)
            {
                kutuphaneYoneticisi = new KutuphaneYoneticisi();
            }
            TurleriYukle();
        }

        private void VerileriOku()
        {
            string json = File.ReadAllText(KutuphaneYoneticisi.path);
            kutuphaneYoneticisi = JsonConvert.DeserializeObject<KutuphaneYoneticisi>(json);
        }

        private void VerileriKaydet()
        {
            string json = JsonConvert.SerializeObject(kutuphaneYoneticisi);
            File.WriteAllText(KutuphaneYoneticisi.path, json);
        }
        private void Listele()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                .ToList();
            dgvKitaplar.Columns[0].Visible = false;//Id kolonunu gizledik.
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";
            dgvKitaplar.Columns[7].Visible = true;//Oduncalinmatarihini gizledik.
        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    if (girisYapan.KullaniciAdi != "admin")
                    {
                        contextMenuStrip1.Items[1].Visible = false;
                        //adı admin olmayan kullanıcılar kitap imha et butonunu göremeyecek.
                    }
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;//sağ click yaptığım satırı seç
                }
            }
        }
        private void tsmiKitapImhaEt_Click(object sender, EventArgs e)
        {
            Guid imhaEdilecekKitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            string kitapAd = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Ad;
            DialogResult dr = MetroMessageBox.Show(this, $"{kitapAd} silinecek onaylıyor musunuz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                kutuphaneYoneticisi.KitapImhaEt(imhaEdilecekKitapId);
                Listele();
            }
        }
        private void tsmiCikisYap_Click(object sender, EventArgs e)
        {
            VerileriKaydet();
            Close();
        }


        private void tsmiBagisYap_Click(object sender, EventArgs e)
        {
            BagisYapForm bagisYapForm = new BagisYapForm(kutuphaneYoneticisi);
            DialogResult dr = bagisYapForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listele();
            }
        }

        private void tsmiHesabim_Click(object sender, EventArgs e)
        {
            HesabimForm hesabimForm = new HesabimForm(girisYapan,kutuphaneYoneticisi);
            hesabimForm.ShowDialog();
            Listele();
        }

        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {
            if (((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).OduncAlinmaTarihi != null)
            {
                MetroMessageBox.Show(this, "Kitap kullanımda!", "Bilgilendirme");
                return;
            }
            Guid kitapId = ((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Id;
            kutuphaneYoneticisi.KitapOduncAl(girisYapan,kitapId);
            Listele();
        }


        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }
    }
}
