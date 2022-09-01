using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifKavrami
{
    class Program
    {
        static void Main(string[] args)
        {

            //Söz Dizimi
            //class SinifAdi
            //{
            //      [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //      [Erişim Belirleyici] [Geri Donus Tipi] MetotAdi[Parametre Listesi]
            //      {
            //      //Metot Komutları
            //      }
            //}

            //Erişim Belirleyiciler
            //-Public
            //-Private
            //-İnternal
            //-Protected

            Calisan calisan1 = new Calisan("Ayşe","Kara",24516587,"İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine( "----------------------------" );
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Ece";
            calisan2.Soyad = "Yılmaz";
            calisan2.No = 78145689;
            calisan2.Departman = "Yazılımcı";
            calisan2.CalisanBilgileri();


            Calisan calisan3 = new Calisan("Ayşe", "Kara");
            calisan3.CalisanBilgileri();
        }
            class Calisan
         {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad,string soyad,int no ,string departman)
            {
                this.Ad = ad;
                this.Soyad = soyad;
                this.No = no;
                this.Departman = departman;
            }
            public Calisan(string ad, string soyad)
            {
                this.Ad = ad;
                this.Soyad = soyad;
            }
            public Calisan() { }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı : {0}",Ad);
                Console.WriteLine("Çalışan Soyadı : {0}", Soyad);
                Console.WriteLine("Çalışan No : {0}", No);
                Console.WriteLine("Çalışan Departmanı : {0}", Departman);
            }
         }

    }
}
