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
    public partial class BagisYapForm : MetroForm
    {
        private readonly KutuphaneYoneticisi kutuphaneYoneticisi;

        public BagisYapForm(KutuphaneYoneticisi kutuphaneYoneticisi)
        {
            InitializeComponent();
            this.kutuphaneYoneticisi = kutuphaneYoneticisi;
            KitapTurYukle();
        }

        private void KitapTurYukle()
        {
            cmbTur.DataSource = Enum.GetValues(typeof(KitapTurEnum));
        }

        private void btnBagisYap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKitapAd.Text) && !string.IsNullOrEmpty(txtYazarAdi.Text))
            {
                kutuphaneYoneticisi.KitapBagisYap(
                    txtKitapAd.Text,
                    dtpBasimTarihi.Value,
                    (KitapTurEnum)cmbTur.SelectedItem,
                    txtYazarAdi.Text,
                    (int)nudSayfaSayisi.Value,
                    txtAciklama.Text);//açıklama zorunlu değil
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Kitap adı ve yazar adı zorunludur!");
            }
        }
    }
}
