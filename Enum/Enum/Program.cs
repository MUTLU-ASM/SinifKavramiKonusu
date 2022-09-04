using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);
            int sıcaklık = 32;
            if (sıcaklık<=(int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya Çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if (sıcaklık>=(int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            else if (sıcaklık>=(int)HavaDurumu.Normal && sıcaklık<(int)HavaDurumu.CokSıcak)
                Console.WriteLine("Hadi dışarı çıkalım!");
        }
    }
    enum Gunler
    {
            Pazartesi,
            Salı,
            Çarşamba,
            Perşembe,
            Cuma,
            Cumartesi,
            Pazar
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sıcak=25,
        CokSıcak=30
    }
}
