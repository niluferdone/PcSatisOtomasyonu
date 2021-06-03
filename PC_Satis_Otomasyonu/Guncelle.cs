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
    public partial class Guncelle : Form
    {
        public Guncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.; Initial Catalog=PC; Integrated Security=true");
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand ekle = new SqlCommand("SELECT * FROM URUNLER WHERE SeriNo=" + serinoText.Text + "", baglanti);
                ekle.ExecuteNonQuery();
                SqlDataReader dr = ekle.ExecuteReader();
                if (dr.Read())
                {
                    urunAdText.Text = dr["UrunAd"].ToString();
                    UrunIDText.Text = dr["UrunID"].ToString();
                    urunModelText.Text = dr["UrunModel"].ToString();
                    urunMarkaText.Text = dr["Marka"].ToString();
                    IslemciHizText.Text = dr["IslemciHizi"].ToString();
                    cacheText.Text = dr["Cache"].ToString();
                    IslemciTeknoText.Text = dr["İslemciTeknolojisi"].ToString();
                    CekirdekText.Text = dr["CekirdekSayisi"].ToString();
                    garantiText.Text = dr["GarantiSuresi"].ToString();
                    ramKapasiteText.Text = dr["RamKapasitesi"].ToString();
                    hddText.Text = dr["HDDKapasite"].ToString();
                    EkranKartitext.Text = dr["EkranKartiTipi"].ToString();
                    EkranKartiKapasitetext.Text = dr["EkranKartKapasitesi"].ToString();
                    fiyatText.Text = dr["BurutFiyat"].ToString();
                    kdvText.Text = dr["KDV"].ToString();
                }
                baglanti.Dispose();
                baglanti.Close();
                dr.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Güncelleme Hatası...");
            }
        }

        private void guncelleBtn_Click(object sender, EventArgs e)
        {
            
                baglanti = new SqlConnection("Data Source=.; Initial Catalog=PC; Integrated Security=true");

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                SqlCommand guncelle = new SqlCommand("UPDATE URUNLER SET " +
                   "UrunAd=@UrunAd,Marka=@Marka,UrunModel=@UrunModel,IslemciHizi=@IslemciHizi," +
                   "Cache=@Cache,İslemciTeknolojisi=@İslemciTeknolojisi,CekirdekSayisi=@CekirdekSayisi,"+
                   "GarantiSuresi=@GarantiSuresi,RamKapasitesi=@RamKapasitesi,HDDKapasite=@HDDKapasite,"+
                   "EkranKartiTipi=@EkranKartiTipi,EkranKartKapasitesi=@EkranKartKapasitesi,BurutFiyat=@BurutFiyat,KDV=@KDV WHERE SeriNo=" + serinoText.Text, baglanti);
                guncelle.Parameters.AddWithValue("@UrunAd", urunAdText.Text);
                guncelle.Parameters.AddWithValue("@Marka", urunMarkaText.Text);
                guncelle.Parameters.AddWithValue("@UrunModel", urunModelText.Text);
                guncelle.Parameters.AddWithValue("@GarantiSuresi", garantiText.Text);
                guncelle.Parameters.AddWithValue("@IslemciHizi", IslemciHizText.Text);
                guncelle.Parameters.AddWithValue("@Cache", cacheText.Text);
                guncelle.Parameters.AddWithValue("@İslemciTeknolojisi", IslemciTeknoText.Text);
                guncelle.Parameters.AddWithValue("@CekirdekSayisi", CekirdekText.Text);
                guncelle.Parameters.AddWithValue("@RamKapasitesi", ramKapasiteText.Text);
                guncelle.Parameters.AddWithValue("@HDDKapasite", hddText.Text);
                guncelle.Parameters.AddWithValue("@EkranKartiTipi", EkranKartitext.Text);
                guncelle.Parameters.AddWithValue("@EkranKartKapasitesi", EkranKartiKapasitetext.Text);
                guncelle.Parameters.AddWithValue("@BurutFiyat", fiyatText.Text);
                guncelle.Parameters.AddWithValue("@KDV", kdvText.Text);

                guncelle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme işlemi başarıyla yapılmıştır...");

          
        }
    }
}
