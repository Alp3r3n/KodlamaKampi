using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            int puan;

            Console.WriteLine("Puaninizi giriniz");

            puan = Convert.ToInt32(Console.ReadLine());

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay";
            kurs3.IzlenmeOrani = 80;

            //////////////////////////////////////////////////////////////////////////////////

            Okul metu = new Okul();
            metu.OkulAdi = "Orta dogu teknik universitesi";
            metu.OkulBolumu = "Bilgisayar Muhendisligi";
            metu.OkulPuani = 500;

            Okul bilkent = new Okul();
            bilkent.OkulAdi = "Bilkent Universitesi";
            bilkent.OkulBolumu = "Bilgisayar Muhendisligi";
            bilkent.OkulPuani = 490;

            Okul ostim = new Okul();
            ostim.OkulAdi = "Ostim Teknik Universitesi";
            ostim.OkulBolumu = "Bilgisayar Muhendisligi";
            ostim.OkulPuani = 400;

            if (puan == bilkent.OkulPuani)
            {
                Console.WriteLine();
                Console.WriteLine("Bilkent'i kazandiniz");
            }
            Console.WriteLine();

            Okul[] okullar = new Okul[] { metu, bilkent, ostim };

            foreach (var Okul in okullar)
            {
                Console.WriteLine(Okul.OkulAdi + " : " + Okul.OkulPuani);
            }
            Console.WriteLine();

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };  // liste 

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
            Console.WriteLine();

            ////////////////////////////////////////////////////////////////////////////////

            Insan alperen = new Insan();
            alperen.BireyAdi = "Alperen";
            alperen.BireyCinsiyet = "Erkek";
            alperen.TcNo = 198324121344;

            Insan emir = new Insan();
            emir.BireyAdi = "emir";
            emir.BireyCinsiyet = "erkek";
            emir.TcNo = 12321323453425;

            Insan mert = new Insan();
            mert.BireyAdi = "mert";
            mert.BireyCinsiyet = "erkek";
            mert.TcNo = 123128942379;

            Insan[] insanlar = new Insan[] { alperen, emir, mert };

            foreach (var Insan in insanlar)
            {
                Console.WriteLine(Insan.BireyAdi + " : " + Insan.BireyCinsiyet + " : " + Insan.TcNo);
            }
            Console.WriteLine();

            Oyun AgeOfEmpires = new Oyun();
            AgeOfEmpires.OyunTuru = "Strateji";
            AgeOfEmpires.OyunYeri = "Bilgisayar";
            AgeOfEmpires.OyunYili = 2021;

            Oyun CsGo = new Oyun();
            CsGo.OyunTuru = "Aksiyon";
            CsGo.OyunYeri = "Konsol ve Bilgisayar";
            CsGo.OyunYili = 2013;

            Oyun Witcher = new Oyun();
            Witcher.OyunTuru = "Aksiyon rpg";
            Witcher.OyunYeri = "Konsol, switch ve bilgisayar";
            Witcher.OyunYili = 2014;

            Oyun[] oyunlar = new Oyun[] { AgeOfEmpires, CsGo, Witcher };

            foreach (var Oyun in oyunlar)
            {
                Console.WriteLine(Oyun.OyunTuru + " : " + Oyun.OyunYeri + " : " + Oyun.OyunYili);
            }
            Console.WriteLine();

            Konum Ankara = new Konum();
            Ankara.KonumYeri = "Ic Anadolu";
            Ankara.KonumSaati = 19.00;
            Ankara.KonumHava = "Aksam";

            Konum Giresun = new Konum();
            Giresun.KonumYeri = "Karadeniz";
            Giresun.KonumSaati = 20.00;
            Giresun.KonumHava = "Aksam";

            Konum Bursa = new Konum();
            Bursa.KonumYeri = "Marmara";
            Bursa.KonumSaati = 18.00;
            Bursa.KonumHava = "Acik";

            Konum[] konumlar = new Konum[] { Ankara, Giresun, Bursa };

            foreach (var Konum in konumlar)
            {
                Console.WriteLine(Konum.KonumYeri + " : " + Konum.KonumSaati + " : " + Konum.KonumHava);
            }
            Console.WriteLine();

            Marka Xsirketi = new Marka();
            Xsirketi.MarkaSahibi = "Alperen";
            Xsirketi.MarkaDegeri = 1000;
            Xsirketi.MarkaYili = 2017;

            Marka Ysirketi = new Marka();
            Ysirketi.MarkaSahibi = "Mehmet";
            Ysirketi.MarkaDegeri = 998;
            Ysirketi.MarkaYili = 2016;

            Marka Zsirketi = new Marka();
            Zsirketi.MarkaSahibi = "Ali";
            Zsirketi.MarkaDegeri = 995;
            Zsirketi.MarkaYili = 2014;

            Marka[] markalar = new Marka[] { Xsirketi, Ysirketi, Zsirketi };

            foreach (var Marka in markalar)
            {
                Console.WriteLine(Marka.MarkaSahibi + " : " + Marka.MarkaDegeri + " : " + Marka.MarkaYili);
            }
            Console.WriteLine();

            Ders Matematik = new Ders();
            Matematik.DersAdi = "Matematik";
            Matematik.DersHocasi = "Mehmet";
            Matematik.DersSaati = 10;

            Ders Fizik = new Ders();
            Fizik.DersAdi = "Fizik";
            Fizik.DersHocasi = "Esra";
            Fizik.DersSaati = 10;

            Ders Programlama = new Ders();
            Programlama.DersAdi = "Programlama";
            Programlama.DersHocasi = "Serdar";
            Programlama.DersSaati = 10;

            Ders[] dersler = new Ders[] { Matematik, Fizik, Programlama };

            foreach (var Ders in dersler)
            {
                Console.WriteLine(Ders.DersAdi + " : " + Ders.DersHocasi + " : " + Ders.DersSaati);
            }
            Console.WriteLine();

            Bilgisayar EkranKarti = new Bilgisayar();
            EkranKarti.Ad = "RTX 3060 ti";
            EkranKarti.Fiyat  = 21000;

            Bilgisayar Islemci = new Bilgisayar();
            Islemci.Ad = "AMD Ryzen 7 3700X";
            Islemci.Fiyat = 4000;

            Bilgisayar RAM = new Bilgisayar();
            RAM.Ad = "Hyperx 3600 MHz 16GB Ram";
            RAM.Fiyat = 1600;

            Bilgisayar[] parcalar = new Bilgisayar[] { EkranKarti, Islemci, RAM };

            foreach (var Bilgisayar in parcalar)
            {
                Console.WriteLine(Bilgisayar.Ad + " : " + Bilgisayar.Fiyat);
            }
            Console.WriteLine();

            string[] menu = new string[] { "Corba ", "Iskender ", "Salata ", "Pide "};

            for(int k = 0; k<menu.Length; k++ )
            {
                Console.WriteLine(menu[k]);
            }
            Console.WriteLine();

            string[] ulkeler = new string[] { "Turkiye ", "Ingiltere ", "Litvanya ", "Isvec" };

            foreach (var ulke in ulkeler)
            {
                Console.WriteLine(ulke);
            }
            Console.WriteLine();
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }

        class Okul
        {
            public string OkulAdi { get; set; }
            public string OkulBolumu { get; set; }
            public double OkulPuani { get; set; }
        }

        class Insan
        {
            public string BireyAdi { get; set; }
            public string BireyCinsiyet { get; set; }
            public long TcNo { get; set; }
        }

        class Oyun
        {
            public string OyunTuru { get; set; }
            public string OyunYeri { get; set; }
            public int OyunYili { get; set; }
        }

        class Konum
        {
            public string KonumYeri { get; set; }
            public double KonumSaati { get; set; }
            public string KonumHava { get; set; }
        }

        class Marka
        {
            public string MarkaSahibi { get; set; }
            public int MarkaDegeri { get; set; }
            public int MarkaYili { get; set; }
        }

        class Ders
        {
            public string DersAdi { get; set; }
            public int DersSaati { get; set; }
            public string DersHocasi { get; set; }
        }

        class Bilgisayar
        {
            public string Ad { get; set; }
            public int Fiyat { get; set; }
        }
    }
}
