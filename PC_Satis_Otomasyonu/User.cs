using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PC_Satis_Otomasyonu
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=PC;Integrated Security=true");
        private void sepetList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {
            /* Alınan Ürünler */

            try
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand alinanUrun = new SqlCommand("SELECT * FROM SATIS WHERE MusteriID="+this.Text, baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(alinanUrun);
                DataTable veriTablosu = new DataTable();
                adapter.Fill(veriTablosu);
                SqlDataReader dr;
                dr = alinanUrun.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["SeriNo"].ToString());                    
                    item.SubItems.Add(dr["UrunID"].ToString());
                    item.SubItems.Add(dr["MusteriID"].ToString());
                    item.SubItems.Add(dr["UrunAd"].ToString());
                    item.SubItems.Add(dr["GarantiSuresi"].ToString());
                    item.SubItems.Add(dr["SimdikiTarih"].ToString());                    
                    item.SubItems.Add(dr["SatisTarihi"].ToString());
                    item.SubItems.Add(dr["KalanGarantiSuresi"].ToString());
                    urunlerim.Items.Add(item);
                }
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Veri Tabanına bağlanırken bir hata oluştu...", "Bağlantı hatası");
            }
            /*------------------------*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fiyatSiralaCombo.Text == "Artan")
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                aramaListesi.Items.Clear();
                SqlCommand artan = new SqlCommand("SELECT * FROM URUNLER ORDER BY Fiyat ASC", baglanti);
                SqlDataAdapter artanAdapter = new SqlDataAdapter(artan);
                DataTable veriArtan = new DataTable();
                artanAdapter.Fill(veriArtan);
                SqlDataReader artanReader;
                artanReader = artan.ExecuteReader();
                while (artanReader.Read())
                {
                    ListViewItem item = new ListViewItem(artanReader["SeriNo"].ToString());
                    item.SubItems.Add(artanReader["UrunID"].ToString());
                    item.SubItems.Add(artanReader["UrunAd"].ToString());
                    item.SubItems.Add(artanReader["Marka"].ToString());
                    item.SubItems.Add(artanReader["Fiyat"].ToString());
                    item.SubItems.Add(artanReader["IslemciHizi"].ToString());
                    item.SubItems.Add(artanReader["RamKapasitesi"].ToString());
                    item.SubItems.Add(artanReader["HDDKapasite"].ToString());
                    item.SubItems.Add(artanReader["EkranKartKapasitesi"].ToString());
                    aramaListesi.Items.Add(item);
                }
                artanReader.Close();
            }
            else if (fiyatSiralaCombo.Text == "Azalan")
            {
                aramaListesi.Items.Clear();
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand azalan = new SqlCommand("SELECT * FROM URUNLER ORDER BY Fiyat DESC", baglanti);
                SqlDataAdapter azalanAdapter = new SqlDataAdapter(azalan);
                DataTable veriAzalan = new DataTable();
                azalanAdapter.Fill(veriAzalan);
                SqlDataReader azalanReader;
                azalanReader = azalan.ExecuteReader();
                while (azalanReader.Read())
                {
                    ListViewItem item = new ListViewItem(azalanReader["SeriNo"].ToString());
                    item.SubItems.Add(azalanReader["UrunID"].ToString());
                    item.SubItems.Add(azalanReader["UrunAd"].ToString());
                    item.SubItems.Add(azalanReader["Marka"].ToString());
                    item.SubItems.Add(azalanReader["Fiyat"].ToString());
                    item.SubItems.Add(azalanReader["IslemciHizi"].ToString());
                    item.SubItems.Add(azalanReader["RamKapasitesi"].ToString());
                    item.SubItems.Add(azalanReader["HDDKapasite"].ToString());
                    item.SubItems.Add(azalanReader["EkranKartKapasitesi"].ToString());
                    aramaListesi.Items.Add(item);
                }
                azalanReader.Close();
            }



            /***********************************************************************/

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* ------------------------------------------------------------ */
            aramaListesi.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlParameter markaAdi = new SqlParameter("@Marka", markaSiralaCombo.Text);
            SqlCommand markaKomut = new SqlCommand("SELECT * FROM URUNLER WHERE Marka=@Marka", baglanti);
            markaKomut.Parameters.Add(markaAdi);
            SqlDataAdapter markaAdapter = new SqlDataAdapter(markaKomut);
            DataTable markaVeri = new DataTable();
            markaAdapter.Fill(markaVeri);
            SqlDataReader markaReader;
            markaReader = markaKomut.ExecuteReader();
            while (markaReader.Read())
            {
                ListViewItem item = new ListViewItem(markaReader["SeriNo"].ToString());
                item.SubItems.Add(markaReader["UrunID"].ToString());
                item.SubItems.Add(markaReader["UrunAd"].ToString());
                item.SubItems.Add(markaReader["Marka"].ToString());
                item.SubItems.Add(markaReader["Fiyat"].ToString());
                item.SubItems.Add(markaReader["IslemciHizi"].ToString());
                item.SubItems.Add(markaReader["RamKapasitesi"].ToString());
                item.SubItems.Add(markaReader["HDDKapasite"].ToString());
                item.SubItems.Add(markaReader["EkranKartKapasitesi"].ToString());
                aramaListesi.Items.Add(item);
            }
            markaReader.Close();
            /*---------------------------------------------------------------*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* -------------------------------------------------------------------- */
            aramaListesi.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlParameter markaAdi = new SqlParameter("@İslemciTeknoloji", islemciSiralaCombo.Text);
            SqlCommand markaKomut = new SqlCommand("SELECT * FROM URUNLER WHERE İslemciTeknolojisi=@İslemciTeknoloji", baglanti);
            markaKomut.Parameters.Add(markaAdi);
            SqlDataAdapter markaAdapter = new SqlDataAdapter(markaKomut);
            DataTable markaVeri = new DataTable();
            markaAdapter.Fill(markaVeri);
            SqlDataReader markaReader;
            markaReader = markaKomut.ExecuteReader();

            while (markaReader.Read())
            {
                ListViewItem item = new ListViewItem(markaReader["SeriNo"].ToString());
                item.SubItems.Add(markaReader["UrunID"].ToString());
                item.SubItems.Add(markaReader["UrunAd"].ToString());
                item.SubItems.Add(markaReader["Marka"].ToString());
                item.SubItems.Add(markaReader["Fiyat"].ToString());
                item.SubItems.Add(markaReader["IslemciHizi"].ToString());
                item.SubItems.Add(markaReader["RamKapasitesi"].ToString());
                item.SubItems.Add(markaReader["HDDKapasite"].ToString());
                item.SubItems.Add(markaReader["EkranKartKapasitesi"].ToString());
                aramaListesi.Items.Add(item);
            }
            markaReader.Close();
            /*----------------------------------------------------------------------*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* -------------------------------------------------------------------- */
            aramaListesi.Items.Clear();
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlParameter markaAdi = new SqlParameter("@CPUHizi", islemciHiziCombo.Text);
            SqlCommand markaKomut = new SqlCommand("SELECT * FROM URUNLER WHERE IslemciHizi=@CPUHizi", baglanti);
            markaKomut.Parameters.Add(markaAdi);
            SqlDataAdapter markaAdapter = new SqlDataAdapter(markaKomut);
            DataTable markaVeri = new DataTable();
            markaAdapter.Fill(markaVeri);
            SqlDataReader markaReader;
            aramaListesi.Columns.Add("CPU Hızı");
            markaReader = markaKomut.ExecuteReader();
            while (markaReader.Read())
            {
                ListViewItem item = new ListViewItem(markaReader["SeriNo"].ToString());
                item.SubItems.Add(markaReader["UrunID"].ToString());
                item.SubItems.Add(markaReader["UrunAd"].ToString());
                item.SubItems.Add(markaReader["Marka"].ToString());
                item.SubItems.Add(markaReader["Fiyat"].ToString());
                item.SubItems.Add(markaReader["IslemciHizi"].ToString());
                item.SubItems.Add(markaReader["RamKapasitesi"].ToString());
                item.SubItems.Add(markaReader["HDDKapasite"].ToString());
                item.SubItems.Add(markaReader["EkranKartKapasitesi"].ToString());
                aramaListesi.Items.Add(item);
            }
            markaReader.Close();
            /*----------------------------------------------------------------------*/
        }

        private void satınAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*SATIN ALMA İŞLEMİ */
            ListViewItem item = urunlerim.SelectedItems[0];
               if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand satis = new SqlCommand("INSERT INTO SATIS (UrunID,UrunAd,GarantiSuresi,SimdikiTarih,KalanGarantiSuresi,SatisTarihi,MusteriID)" +
                "VALUES (@UrunID,@UrunAd,@GarantiSuresi,@SimdikiTarih,@KalanGarantiSuresi,@SatisTarihi,@MusteriID)", baglanti);

            satis.Parameters.AddWithValue("@UrunID", item.SubItems[1].Text);
            satis.Parameters.AddWithValue("@UrunAd", item.SubItems[2].Text);
            satis.Parameters.AddWithValue("@GarantiSuresi", item.SubItems[4].Text);
            satis.Parameters.AddWithValue("@SimdikiTarih", item.SubItems[5].Text);
            satis.Parameters.AddWithValue("@KalanGarantiSuresi", item.SubItems[7].Text);
            satis.Parameters.AddWithValue("@SatisTarihi", item.SubItems[6].Text);
            satis.Parameters.AddWithValue("@MusteriID", this.Text);
            satis.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Ürün Satın Alındı...");
        }
    }
}
