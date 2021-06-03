using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PC_Satis_Otomasyonu
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=PC;Integrated Security=true");
        public String serinumarasi;
        private void Admin_Load(object sender, EventArgs e)
        {
            /* TÜM VERİLERİ GÖSTERME*/

            try
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand tumVeriler = new SqlCommand("SELECT * FROM URUNLER", baglanti);
                SqlDataAdapter adapter = new SqlDataAdapter(tumVeriler);
                DataTable veriTablosu = new DataTable();
                adapter.Fill(veriTablosu);
                SqlDataReader dr;
                dr = tumVeriler.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["SeriNo"].ToString());
                    item.SubItems.Add(dr["UrunID"].ToString());
                    item.SubItems.Add(dr["UrunAd"].ToString());
                    item.SubItems.Add(dr["Marka"].ToString());
                    item.SubItems.Add(dr["Fiyat"].ToString());
                    item.SubItems.Add(dr["IslemciHizi"].ToString());
                    item.SubItems.Add(dr["RAMKapasitesi"].ToString());
                    item.SubItems.Add(dr["HDDKapasite"].ToString());
                    item.SubItems.Add(dr["EkranKartKapasitesi"].ToString());
                    TumVerilerListe.Items.Add(item);
                }
                dr.Close();
            }
            catch  (SqlException)
            {
                MessageBox.Show("Veri Tabanına bağlanırken bir hata oluştu...","Bağlantı hatası");
            }
            /*------------------------*/
            /*-------------STOK BİLGİSİ--------------*/
            /* TÜM VERİLERİ GÖSTERME*/

            try
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand stok = new SqlCommand("SELECT * FROM STOK", baglanti);
                SqlDataAdapter adapter2 = new SqlDataAdapter(stok);
                DataTable veriTablosu = new DataTable();
                adapter2.Fill(veriTablosu);
                SqlDataReader dr;
                dr = stok.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["UrunID"].ToString());
                    item.SubItems.Add(dr["UrunAd"].ToString());
                    item.SubItems.Add(dr["UrunAdet"].ToString());                  
                    stokListe.Items.Add(item);
                }
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Veri Tabanına bağlanırken bir hata oluştu...", "Bağlantı hatası");
            }
            /*------------MUSTERİLER------------*/
            try
            {

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand musteri = new SqlCommand("SELECT * FROM MUSTERI WHERE MusteriID<>1", baglanti);
                SqlDataAdapter adapter3 = new SqlDataAdapter(musteri);
                DataTable veriTablosu = new DataTable();
                adapter3.Fill(veriTablosu);
                SqlDataReader dr;
                dr = musteri.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["MusteriID"].ToString());
                    item.SubItems.Add(dr["MusteriAd"].ToString());
                    item.SubItems.Add(dr["MusteriSoyad"].ToString());
                    item.SubItems.Add(dr["Adres"].ToString());
                    item.SubItems.Add(dr["Telno"].ToString());
                    item.SubItems.Add(dr["Sehir"].ToString());
                    item.SubItems.Add(dr["Yetki"].ToString());
                    musteriListe.Items.Add(item);
                }
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Veri Tabanına bağlanırken bir hata oluştu...", "Bağlantı hatası");
            }
            /*--------------------------*/
            
            /* SİLİNMİŞ ÜRÜNLER */

            SqlCommand silinmis = new SqlCommand("SELECT * FROM SILINMIS_URUNLER", baglanti);
            SqlDataAdapter adap = new SqlDataAdapter(silinmis);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            SqlDataReader sdr;
            sdr = silinmis.ExecuteReader();
            while (sdr.Read())
            {
                ListViewItem item = new ListViewItem(sdr["SeriNo"].ToString());
                item.SubItems.Add(sdr["UrunID"].ToString());
                item.SubItems.Add(sdr["UrunAd"].ToString());
                item.SubItems.Add(sdr["Marka"].ToString());
                item.SubItems.Add(sdr["UrunModel"].ToString());
                item.SubItems.Add(sdr["KDV"].ToString());
                item.SubItems.Add(sdr["BurutFiyat"].ToString());
                item.SubItems.Add(sdr["Fiyat"].ToString());
                item.SubItems.Add(sdr["RAMKapasitesi"].ToString());
                item.SubItems.Add(sdr["İslemciHizi"].ToString());
                item.SubItems.Add(sdr["İslemciTeknolojisi"].ToString());
                item.SubItems.Add(sdr["CekirdekSayisi"].ToString());
                item.SubItems.Add(sdr["Cache"].ToString());
                item.SubItems.Add(sdr["HDDKapasite"].ToString());
                item.SubItems.Add(sdr["EkranKartiTipi"].ToString());
                item.SubItems.Add(sdr["EkranKartKapasitesi"].ToString());
                silinmisUrunListe.Items.Add(item);
            }
            sdr.Close();
            /*-----------------------------------------*/
        }

        private void listView5_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            /* URUN BİLGİLERİNİ ÇEKME*/
            SqlDataReader oku;
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                if (TumVerilerListe.SelectedItems.Count > 0)
                {
                    ListViewItem item = TumVerilerListe.SelectedItems[0];
                    seriNumarasi.Text = item.SubItems[0].Text;
                }
                SqlParameter urunSeri = new SqlParameter("@urunSeri", seriNumarasi.Text);
                String giris = "SELECT * FROM URUNLER WHERE SeriNo = @urunSeri";
                SqlCommand komut = new SqlCommand(giris, baglanti);
                komut.Parameters.Add(urunSeri);
                SqlDataAdapter adapter = new SqlDataAdapter(komut);
                DataTable veriTablosu = new DataTable();
                adapter.Fill(veriTablosu);
                if (veriTablosu.Rows.Count > 0)
                {
                    komut.ExecuteNonQuery();
                    oku = komut.ExecuteReader();
                    if (oku.Read())
                    {
                        seriNumarasi.Text = oku["SeriNo"].ToString();
                        urunAdLabel.Text = oku["UrunAd"].ToString();
                        urunIDLabel.Text = oku["UrunID"].ToString();
                        urunMarkaLabel.Text = oku["Marka"].ToString();
                        urunModelLabel.Text = oku["UrunModel"].ToString();
                        islemciHız.Text = oku["IslemciHizi"].ToString();
                        cache.Text = oku["Cache"].ToString();
                        islemciTeknoloji.Text = oku["İslemciTeknolojisi"].ToString();
                        cekirdekSayisi.Text = oku["CekirdekSayisi"].ToString();
                        ramKapasite.Text = oku["RamKapasitesi"].ToString();
                        hddKapasiteLabel.Text = oku["HDDKapasite"].ToString();
                        ekranKartTip.Text = oku["EkranKartiTipi"].ToString();
                        ekranKapasiteLabel.Text = oku["EkranKartKapasitesi"].ToString();
                        urunFiyat.Text = oku["Fiyat"].ToString();
                        garantiSure.Text = oku["GarantiSuresi"].ToString();
                    }
                    baglanti.Close();
                }                

            }
            catch (SqlException)
            {
                MessageBox.Show("Veri Seçilirken Hata Oluştu ! ");
            }
            /*----------------------------*/
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
          
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=PC; Integrated Security=true");
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand sil = new SqlCommand("DELETE FROM URUNLER WHERE SeriNo =  " + seriNumarasi.Text, baglanti);
                sil.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Başarıyla Yapılmıştır.");
                baglanti.Close();
                for (int i = 0; i < TumVerilerListe.Items.Count; i++)
                {
                    if (TumVerilerListe.Items[i].SubItems[0].Text == seriNumarasi.Text)
                    {
                        TumVerilerListe.Items[i].Remove();
                    }
                }
           

        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle ekleFormu = new UrunEkle();
            ekleFormu.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelle update = new Guncelle();
            update.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PDF rapor =new PDF(
            seriNumarasi.Text,urunIDLabel.Text,urunAdLabel.Text,urunMarkaLabel.Text,urunFiyat.Text,islemciHız.Text,ramKapasite.Text,
            hddKapasiteLabel.Text,ekranKapasiteLabel.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TumVerilerListe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
