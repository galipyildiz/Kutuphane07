
namespace Kutuphane07.UI
{
    partial class BagisYapForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtKitapAd = new MetroFramework.Controls.MetroTextBox();
            this.dtpBasimTarihi = new MetroFramework.Controls.MetroDateTime();
            this.cmbTur = new MetroFramework.Controls.MetroComboBox();
            this.txtYazarAdi = new MetroFramework.Controls.MetroTextBox();
            this.nudSayfaSayisi = new System.Windows.Forms.NumericUpDown();
            this.txtAciklama = new MetroFramework.Controls.MetroTextBox();
            this.btnBagisYap = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kutuphane07.UI.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(70, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 289);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Kitap Adı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 324);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Basım Tarihi:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 359);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Tür:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 388);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Yazar Adı:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(23, 414);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 1;
            this.metroLabel5.Text = "Sayfa Sayısı:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(23, 443);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Açıklama:";
            // 
            // txtKitapAd
            // 
            // 
            // 
            // 
            this.txtKitapAd.CustomButton.Image = null;
            this.txtKitapAd.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtKitapAd.CustomButton.Name = "";
            this.txtKitapAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtKitapAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtKitapAd.CustomButton.TabIndex = 1;
            this.txtKitapAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtKitapAd.CustomButton.UseSelectable = true;
            this.txtKitapAd.CustomButton.Visible = false;
            this.txtKitapAd.Lines = new string[0];
            this.txtKitapAd.Location = new System.Drawing.Point(127, 285);
            this.txtKitapAd.MaxLength = 32767;
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.PasswordChar = '\0';
            this.txtKitapAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtKitapAd.SelectedText = "";
            this.txtKitapAd.SelectionLength = 0;
            this.txtKitapAd.SelectionStart = 0;
            this.txtKitapAd.ShortcutsEnabled = true;
            this.txtKitapAd.Size = new System.Drawing.Size(232, 23);
            this.txtKitapAd.TabIndex = 2;
            this.txtKitapAd.UseSelectable = true;
            this.txtKitapAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtKitapAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpBasimTarihi
            // 
            this.dtpBasimTarihi.Location = new System.Drawing.Point(126, 314);
            this.dtpBasimTarihi.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpBasimTarihi.Name = "dtpBasimTarihi";
            this.dtpBasimTarihi.Size = new System.Drawing.Size(233, 29);
            this.dtpBasimTarihi.TabIndex = 3;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.ItemHeight = 23;
            this.cmbTur.Location = new System.Drawing.Point(126, 349);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(233, 29);
            this.cmbTur.TabIndex = 4;
            this.cmbTur.UseSelectable = true;
            // 
            // txtYazarAdi
            // 
            // 
            // 
            // 
            this.txtYazarAdi.CustomButton.Image = null;
            this.txtYazarAdi.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtYazarAdi.CustomButton.Name = "";
            this.txtYazarAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtYazarAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYazarAdi.CustomButton.TabIndex = 1;
            this.txtYazarAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYazarAdi.CustomButton.UseSelectable = true;
            this.txtYazarAdi.CustomButton.Visible = false;
            this.txtYazarAdi.Lines = new string[0];
            this.txtYazarAdi.Location = new System.Drawing.Point(126, 384);
            this.txtYazarAdi.MaxLength = 32767;
            this.txtYazarAdi.Name = "txtYazarAdi";
            this.txtYazarAdi.PasswordChar = '\0';
            this.txtYazarAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYazarAdi.SelectedText = "";
            this.txtYazarAdi.SelectionLength = 0;
            this.txtYazarAdi.SelectionStart = 0;
            this.txtYazarAdi.ShortcutsEnabled = true;
            this.txtYazarAdi.Size = new System.Drawing.Size(232, 23);
            this.txtYazarAdi.TabIndex = 2;
            this.txtYazarAdi.UseSelectable = true;
            this.txtYazarAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYazarAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nudSayfaSayisi
            // 
            this.nudSayfaSayisi.Location = new System.Drawing.Point(126, 413);
            this.nudSayfaSayisi.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSayfaSayisi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSayfaSayisi.Name = "nudSayfaSayisi";
            this.nudSayfaSayisi.Size = new System.Drawing.Size(233, 20);
            this.nudSayfaSayisi.TabIndex = 5;
            this.nudSayfaSayisi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtAciklama
            // 
            // 
            // 
            // 
            this.txtAciklama.CustomButton.Image = null;
            this.txtAciklama.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.txtAciklama.CustomButton.Name = "";
            this.txtAciklama.CustomButton.Size = new System.Drawing.Size(87, 87);
            this.txtAciklama.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAciklama.CustomButton.TabIndex = 1;
            this.txtAciklama.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAciklama.CustomButton.UseSelectable = true;
            this.txtAciklama.CustomButton.Visible = false;
            this.txtAciklama.Lines = new string[0];
            this.txtAciklama.Location = new System.Drawing.Point(127, 439);
            this.txtAciklama.MaxLength = 32767;
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.PasswordChar = '\0';
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAciklama.SelectedText = "";
            this.txtAciklama.SelectionLength = 0;
            this.txtAciklama.SelectionStart = 0;
            this.txtAciklama.ShortcutsEnabled = true;
            this.txtAciklama.Size = new System.Drawing.Size(232, 92);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.UseSelectable = true;
            this.txtAciklama.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAciklama.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBagisYap
            // 
            this.btnBagisYap.Location = new System.Drawing.Point(260, 537);
            this.btnBagisYap.Name = "btnBagisYap";
            this.btnBagisYap.Size = new System.Drawing.Size(98, 23);
            this.btnBagisYap.TabIndex = 6;
            this.btnBagisYap.Text = "Bağış Yap";
            this.btnBagisYap.UseSelectable = true;
            this.btnBagisYap.Click += new System.EventHandler(this.btnBagisYap_Click);
            // 
            // BagisYapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 590);
            this.Controls.Add(this.btnBagisYap);
            this.Controls.Add(this.nudSayfaSayisi);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.dtpBasimTarihi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtYazarAdi);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 590);
            this.MinimumSize = new System.Drawing.Size(409, 590);
            this.Name = "BagisYapForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayfaSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtKitapAd;
        private MetroFramework.Controls.MetroDateTime dtpBasimTarihi;
        private MetroFramework.Controls.MetroComboBox cmbTur;
        private MetroFramework.Controls.MetroTextBox txtYazarAdi;
        private System.Windows.Forms.NumericUpDown nudSayfaSayisi;
        private MetroFramework.Controls.MetroTextBox txtAciklama;
        private MetroFramework.Controls.MetroButton btnBagisYap;
    }
}