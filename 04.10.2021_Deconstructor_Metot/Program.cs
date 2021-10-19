using System;

namespace _04._10._2021_Deconstructor_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Person prs = new Person
            {
                Ad = "muhammet",
                Soyad = "aydın",
                Yas = 52
            };

            var (x, y, z) = prs;
            Console.WriteLine((x, y, z));
        }
    }

    class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public void Deconstruct(out string ad, out string soyad, out int yas)
        {
            ad = Ad;
            soyad = Soyad;
            yas = Yas;

        }

    }

}