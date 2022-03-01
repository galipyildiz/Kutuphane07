using Kutuphane07.DATA;
using MetroFramework;
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
            //TODO json oku
            kutuphaneYoneticisi = new KutuphaneYoneticisi();
            Listele();
            TurleriYukle();
        }

        private void Listele()
        {
            dgvKitaplar.DataSource = null;
            dgvKitaplar.DataSource = kutuphaneYoneticisi.Kitaplar
                .Where(x => x.OduncAlinmaTarihi == null)
                .ToList();
            dgvKitaplar.Columns[0].Visible = false;//Id kolonunu gizledik.
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Basım Tarihi";
            dgvKitaplar.Columns[3].HeaderText = "Kitap Türü";
            dgvKitaplar.Columns[4].HeaderText = "Yazar Ad";
            dgvKitaplar.Columns[5].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[6].HeaderText = "Açıklama";
            dgvKitaplar.Columns[7].Visible = false;//Oduncalinmatarihini gizledik.
        }

        private void dgvKitaplar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int position = dgvKitaplar.HitTest(e.X, e.Y).RowIndex;
                if (position >= 0)
                {
                    contextMenuStrip1.Show(dgvKitaplar, new Point(e.X, e.Y));
                    dgvKitaplar.Rows[position].Selected = true;//sağ click yaptığım satırı seç
                }
            }
        }

        private void tsmiCikisYap_Click(object sender, EventArgs e)
        {
            //TODO kutuphaneyoneticisini kaydet
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
            HesabimForm hesabimForm = new HesabimForm(girisYapan);
            hesabimForm.ShowDialog();
        }

        private void tsmiKitapOduncAl_Click(object sender, EventArgs e)
        {
            //TODO kitap odunc alma islemleri
        }

        private void tsmiKitapImhaEt_Click(object sender, EventArgs e)
        {
            //TODO kitap imha etme işlemleri
            MessageBox.Show(((Kitap)dgvKitaplar.SelectedRows[0].DataBoundItem).Ad);
        }

        private void KutuphaneForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO json kaydet
        }
    }
}
