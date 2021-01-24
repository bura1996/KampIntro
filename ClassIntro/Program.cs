using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "salih";
            int yas = 36;
            kurs kurs1 = new kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            kurs kurs2 = new kurs();
            kurs2.KursAdi = "java#";
            kurs2.Egitmen = "salih";
            kurs2.IzlenmeOrani = 100;

            kurs kurs3 = new kurs();
            kurs3.KursAdi = "C";
            kurs3.Egitmen = "mustafa";
            kurs3.IzlenmeOrani = 50;


            // Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);
            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen);
            }
        }
    }
    class kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
