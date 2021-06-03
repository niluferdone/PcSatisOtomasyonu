using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;

namespace PC_Satis_Otomasyonu
{
    class PDF
    {
        public PDF(
            string serino,string urunid,string urunadi,string marka,string fiyat,string islemcihizi,string ramkapasitesi,
            string hdd,string ekrankarti
            )
        {
            /*-------------------------------------*/

            iTextSharp.text.Document raporum = new iTextSharp.text.Document();

            // PDF oluşturması ve konumun belirlenmesi

            PdfWriter.GetInstance(raporum, new FileStream("C:Raporum.pdf", FileMode.Create));

            //PDF yi yazan özelliğine eklenecek

            raporum.AddAuthor("URUNLER"); // PDF Oluşturma Tarihi Ekle

            raporum.AddCreationDate(); // PDF Oluşturma Tarihi

            // PDF oluşturan kişi özelliğine yazılacak

            raporum.AddCreator("Selim Silgu");

            if (raporum.IsOpen() == false)
            {

                raporum.Open();

            }

            raporum.Add(new Paragraph("Ürün Fiyatı : " + fiyat.ToString() + " TL"));
            raporum.Add(new Paragraph("Seri Numarası : " + serino.ToString()));
            raporum.Add(new Paragraph("Ürün ID : " + serino.ToString()));
            raporum.Add(new Paragraph("Ürün Adı : " + urunadi.ToString()));
            raporum.Add(new Paragraph("Ürün Markası : " + marka.ToString()));
            raporum.Add(new Paragraph("Islemci Hızı : " + islemcihizi.ToString()));
            raporum.Add(new Paragraph("RAM Bellek : " + ramkapasitesi.ToString()));
            raporum.Add(new Paragraph("HDD Kapasitesi : " + hdd.ToString()));
            raporum.Add(new Paragraph("Ekran Karti Kapasitesi : " + ekrankarti.ToString()));
           
            MessageBox.Show("PDF Dosyanız Oluşmuştur.");

            raporum.Close();

            /*-------------------------------------*/
        }
    }
}
