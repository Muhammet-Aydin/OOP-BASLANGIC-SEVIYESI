using System;

namespace _05._10._2021_Genel_Ornekler
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir nesnesını oop de bankayı sanallastırma yap

        }
    }

    class Çalısanlar
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public int Yas { get; set; }

        public bool MedeniHal { get; set; }



    }
    class Güvenlik : Çalısanlar
    {
        public string VardiyaSekli{ get; set; }

    }
    class MüsteriTemsilcisi : Çalısanlar
    {
        public int ÇalıştıgıMasa { get; set; }
        public int ÇalısanKisiSayısı { get; set; }

    }
    class Müdürler : Çalısanlar
    {

        public string SorumluOlduguDeparman { get; set; }
    }


    class MüsteriTipleri
    {

        public bool MüsteriTipi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Adres { get; set; }
        public int Hesap { get; set; }

        public int FindexNotu { get; set; }




    }
    class KurumsalMüşteri : MüsteriTipleri
    {
        public int OzelFaizOrani { get; set; }

        public string FirmaAdı { get; set; }
        public double SirketPiyasaDegeri { get; set; }



    }
    class NormalMüsteri : MüsteriTipleri

    {
        public int NormalFaizOrani { get; set; }
        public int AylıkGelir { get; set; }




    }




}
