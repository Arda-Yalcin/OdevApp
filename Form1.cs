using System.ComponentModel;

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
        }

        private void btnEkleGuncelle_Click(object sender, EventArgs e)
        {
            Ekle();
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



        }
    }
}
