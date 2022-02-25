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

        public KutuphaneForm(Kullanici girisYapan) 
        {
            InitializeComponent();
            this.girisYapan = girisYapan;
        }

        private void KutuphaneForm_Load(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, girisYapan.KullaniciAdi,"Giriş Yapan",MessageBoxButtons.OK,MessageBoxIcon.Question);
        }

        private void KutuphaneForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(this,new Point(e.X, e.Y));
            }
        }
    }
}
