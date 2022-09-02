using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayse";
            ogrenci.Soyisim = "Yilmaz";
            ogrenci.OgrenciNo=293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim
        {
            get { return soyisim; }
            set { soyisim = value; }
        }
        public int OgrenciNo
        {
            get { return ogrenciNo; }
            set { ogrenciNo = value; }
        }
        public int Sinif
        {
            get { return sinif; }
            set {
                if (value<1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    sinif = 1;
                }
                sinif = value; }
        }

       public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
            {
                this.isim = isim;
                this.soyisim = soyisim;
                this.ogrenciNo = ogrenciNo;
                this.sinif = sinif;
            }

        public Ogrenci() { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******Öğrenci Bilgileri*********");
            Console.WriteLine("Öğrenci Adı  :{0}",this.isim);
            Console.WriteLine("Öğrenci Soyadı  :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No  :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı  :{0}", this.sinif);
        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }
        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }
    }
}
