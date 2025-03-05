using System.ComponentModel;
using System.Text.Json;

namespace OdevApp
{
    public partial class Form1 : Form
    {
        string[] siniflar = { "10A", "10B", "10C", "10D", "10E" };

        BindingList<Ogrenci> ogrenciler = new();
        Ogrenci secili;

        public Form1()
        {
            InitializeComponent();


            if (File.Exists("bilgiler.txt"))
            {
                var str = File.ReadAllText("bilgiler.txt");
                var liste = JsonSerializer.Deserialize<List<Ogrenci>>(str);
                ogrenciler = new(liste);
            }

            cbSinif.Items.AddRange(siniflar);
            lbOgrenciler.DataSource = ogrenciler;
            lbOgrenciler.DisplayMember = "Bilgi";
        }

        void Ekle()
        {
            Ogrenci ogr = new();
            ogr.Nu = Convert.ToInt32(txtNumara.Text);
            ogr.Ad = txtAd.Text;
            ogr.Soyad = txtSoyad.Text;
            ogr.SinifId = cbSinif.SelectedIndex;
            ogr.Ders = txtDers.Text;
            ogr.OdevKonusu = txtOdev.Text;
            ogr.OdevYaptiMi = rdOdevEvet.Checked;
            ogr.Puan = Convert.ToDouble(nudPuan.Value);

            ogrenciler.Add(ogr);

            Yeni();
        }

        void Yeni()
        {
            secili = null;
            pbKayitBilgi.Image = Properties.Resources.yeni;
            lblKayitBilgi.Text = "Yeni Kayýt";

            txtNumara.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cbSinif.SelectedIndex = -1;
            txtDers.Clear();
            txtOdev.Clear();
            rdOdevEvet.Checked = false;
            rdOdevHayir.Checked = false;
            nudPuan.Value = 0;
        }

        void Guncelle()
        {
            if (secili != null)
            {
                secili.Nu = Convert.ToInt32(txtNumara.Text);
                secili.Ad = txtAd.Text;
                secili.Soyad = txtSoyad.Text;
                secili.SinifId = cbSinif.SelectedIndex;
                secili.Ders = txtDers.Text;
                secili.OdevKonusu = txtOdev.Text;
                secili.OdevYaptiMi = rdOdevEvet.Checked;
                secili.Puan = Convert.ToDouble(nudPuan.Value);

                ogrenciler.ResetBindings();
            }
        }
        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            if (secili == null)
                Ekle();
            else
                Guncelle();
        }

        private void lbOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secili = lbOgrenciler.SelectedItem as Ogrenci;
            /*
            if (lbOgrenciler.SelectedIndex == -1)
                secili = null;
            else 
                secili = ogrenciler[lbOgrenciler.SelectedIndex];
            */

            if (secili != null)
            {
                pbKayitBilgi.Image = Properties.Resources.kayitli;
                lblKayitBilgi.Text = "Eski Kayýt";

                txtNumara.Text = secili.Nu.ToString();
                txtAd.Text = secili.Ad;
                txtSoyad.Text = secili.Soyad;
                cbSinif.SelectedIndex = secili.SinifId;//###
                txtDers.Text = secili.Ders;
                txtOdev.Text = secili.OdevKonusu;
                rdOdevEvet.Checked = secili.OdevYaptiMi;
                rdOdevHayir.Checked = !secili.OdevYaptiMi;
                nudPuan.Value = Convert.ToDecimal(secili.Puan);
            }
            else
            {
                Yeni();
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var str = JsonSerializer.Serialize(ogrenciler);

            File.WriteAllText("bilgiler.txt", str);

            MessageBox.Show("Kaydedildi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yeni();
        }
    }
}
