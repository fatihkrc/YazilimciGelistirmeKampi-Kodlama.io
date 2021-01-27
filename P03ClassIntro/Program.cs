using System;

namespace P03ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs
            {
                KursAdi = "C# Temelleri",
                Egitmen = "Engin DEMİROĞ",
                IzlenmeOrani = 90
            };

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "A'dan Z'ye Java";
            kurs2.Egitmen = "Şadi Evren ŞEKER";
            kurs2.IzlenmeOrani = 88;

            Kurs kurs3 = new Kurs
            {
                KursAdi = "Python 101",
                Egitmen = "Atıl SAMANCIOĞLU",
                IzlenmeOrani = 94
            };

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            int i = 0;
            foreach (var kurs in kurslar)
            {
                i++;
                Console.WriteLine("----- KURS {0} -----\nKurs Adı : {1}", i, kurs.KursAdi);
                Console.WriteLine("Eğitmen : {0}", kurs.Egitmen);
                Console.WriteLine("İzlenme Oranı : {0}\n", kurs.IzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}