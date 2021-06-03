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
using System.Data.Sql;

namespace PC_Satis_Otomasyonu
{
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=PC;Integrated Security=true");

        private void button1_Click(object sender, EventArgs e)
        {
           
               if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                
                SqlCommand kayit = new SqlCommand("URUN_EKLEME", baglanti);
                kayit.CommandType = CommandType.StoredProcedure; //commandtype belirliyoruz

                //parametreleri ekliyoruz.
                SqlParameter p1 = kayit.Parameters.Add("@SeriNo", SqlDbType.Int);
                SqlParameter p2 = kayit.Parameters.Add("@UrunID", SqlDbType.Int);
                SqlParameter p3 = kayit.Parameters.Add("@UrunAd", SqlDbType.VarChar, 20);
                SqlParameter p4 = kayit.Parameters.Add("@Marka", SqlDbType.VarChar, 20);
                SqlParameter p5 = kayit.Parameters.Add("@UrunModel", SqlDbType.VarChar,20);
                SqlParameter p6 = kayit.Parameters.Add("@KDV", SqlDbType.Decimal);
                SqlParameter p7 = kayit.Parameters.Add("@BurutFiyat", SqlDbType.Decimal);
                SqlParameter p8 = kayit.Parameters.Add("@RamKapasitesi", SqlDbType.VarChar,5);
                SqlParameter p9 = kayit.Parameters.Add("@IslemciHizi", SqlDbType.VarChar,5);
                SqlParameter p10 = kayit.Parameters.Add("@İslemciTeknolojisi", SqlDbType.VarChar, 15);
                SqlParameter p11 = kayit.Parameters.Add("CekirdekSayisi", SqlDbType.TinyInt);
                SqlParameter p12 = kayit.Parameters.Add("@Cache", SqlDbType.VarChar,5);
                SqlParameter p13 = kayit.Parameters.Add("@HDDKapasite", SqlDbType.VarChar, 6);
                SqlParameter p14 = kayit.Parameters.Add("@EkranKartiTipi", SqlDbType.VarChar, 15);
                SqlParameter p15 = kayit.Parameters.Add("@EkranKartKapasitesi", SqlDbType.VarChar,6);
                SqlParameter p16 = kayit.Parameters.Add("@GarantiSuresi", SqlDbType.TinyInt);
                SqlParameter p17 = kayit.Parameters.Add("@UrunAdet", SqlDbType.Int);
                //değerleri atıyoruz   

                p1.Value = Convert.ToInt32("1");
                p2.Value = Convert.ToInt32(UrunIDText.Text);
                p3.Value = urunAdText.Text;
                p4.Value = urunMarkaText.Text;
                p5.Value = urunModelText.Text;
                p6.Value = Convert.ToDecimal(kdvText.Text);
                p7.Value = Convert.ToDecimal(fiyatText.Text);
                p8.Value = ramKapasiteText.Text;
                p9.Value = IslemciHizText.Text;
                p10.Value = IslemciTeknoText.Text;
                p11.Value = Convert.ToByte(CekirdekText.Text);
                p12.Value = cacheText.Text;
                p13.Value = hddText.Text;
                p14.Value = EkranKartitext.Text;
                p15.Value = EkranKartiKapasitetext.Text;
                p16.Value = Convert.ToByte(garantiText.Text);
                p17.Value = Convert.ToInt32(urunAdetText.Text);
                //veriyi işliyoruz 

                kayit.ExecuteNonQuery();
                MessageBox.Show("Urun Eklenmiştir...");
                //bağlantıyı kapatıyoruz 
                baglanti.Close();
           
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void fiyatText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fiyatText_TabIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void kdvText_TextChanged(object sender, EventArgs e)
        {

        }

        private void EkranKartiKapasitetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void EkranKartitext_TextChanged(object sender, EventArgs e)
        {

        }

        private void hddText_TextChanged(object sender, EventArgs e)
        {

        }

        private void ramKapasiteText_TextChanged(object sender, EventArgs e)
        {

        }

        private void garantiText_TextChanged(object sender, EventArgs e)
        {

        }

        private void CekirdekText_TextChanged(object sender, EventArgs e)
        {

        }

        private void IslemciTeknoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void cacheText_TextChanged(object sender, EventArgs e)
        {

        }

        private void IslemciHizText_TextChanged(object sender, EventArgs e)
        {

        }

        private void urunMarkaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void urunModelText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UrunIDText_TextChanged(object sender, EventArgs e)
        {

        }

        private void urunAdText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
