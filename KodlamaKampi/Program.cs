using System;

namespace KodlamaKampi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazilim gelistirici yetistirme kampi", "Programlamaya baslangic icin temel kurs", "Java","Python","C#"};

            for(int i = 0; i<kurslar.Length; i++) // kurslar.Lenght (lenght eleman sayisi)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            Console.WriteLine();


            foreach (string kurs in kurslar) // kurslari dolas (in kurslar) - foreach dizilere uygulanir - dizileri tek tek dolasir
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine();

            string[] oyunlar = new string[] { "GTA V", "CSGO", "Age of Empires", "Dark Souls III", "Assassin's Creed", "Dead Cells", "Crysis" };

            for (int a = 0; a < oyunlar.Length; a++)
            {
                Console.WriteLine(oyunlar[a]);
            }

            Console.WriteLine("Diger for bitti");
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            string[] takimlar = new string[] { "Galatasaray", "Fenerbahce", "Besiktas", "Trabzonspor" };

            for (int c = 0; c < takimlar.Length; c++)
            {
                Console.WriteLine(takimlar[c]);
            }
            Console.WriteLine();

            string[] kulupler = new string[] { "Gezi Kulubu", "Satranc Kulubu", "Muzik Kulubu", "Saglik Kulubu" };

            foreach (var kulup in kulupler)
            {
                Console.WriteLine(kulup);
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
