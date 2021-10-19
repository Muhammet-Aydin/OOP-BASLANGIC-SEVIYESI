using System;

namespace OOP_Baslangic
{
    class Program
    {
        static void Main(string[] args)
        {
            //günlük hayattaki her turluvarlık nesne olarak ifade edilir.
            //ornegin veri tabankarı içerisinde karmasık bir sekılde duran verileri  incelediginizi duusunun istatistiksel ve atıksal bir cıkarım yapak zor olacaktr.buda verinn butunlugu onemlıdır.
            //sınıf nedir. bir yerden baska br uere gitmemizi saglanyan bir nesne oarak ifade edilir.
            //araba nesnesının kendi çerisinde kendine aıt ozellıklerı mevcuttur.
            //araba nesnesnin ozellikerini sayabiliriz. bu nesneyı olusturan ozellikleri be görevleri yazılım dunyasına tasıyabilmemiz için bize yardımcı olutlar classlar gerçek hayat nesnelerimizzi yaızlımı objerlıne donusturmeyı saglayan yapılardır.
            //eger classın altında ozellik tanımladıgınzda bunun adı fıeld olur.
            MyClassUst myu = new MyClassUst();

            Person t = PersonDondur();

            Console.WriteLine(t.age + t.name);

            myu.yaz();


            int a = MyClassUst.MyClassAlt.topla(5, 9);
            Console.WriteLine(a.ToString());
        }

        public static Person PersonDondur()
        {
            Person person = new Person();
            person.name = "muhammet";
            person.age = "20";
            return person;
        }
    }

    public class Person
    {
        public string name;
        public string age;
    }
    class MyClass
    {
        string Renk;
        string Motorgücü;
        string Kasatipi;
        string Model;
        int Yil;

    }


    //class yapsıında oyukarıda görğldüğü gibi class ıcınde nsneye ait özellikleri belirtiliyor.bunkara fıeld denir.

    class MyClassUst
    {
        public void yaz()
        {

            Console.WriteLine("merhaba");
        }
        public class MyClassAlt

        {
            public static int topla(int sayı1, int sayı2)
            {
                int toplam = sayı1 + sayı2;
                return toplam;

            }

        }
    }

}
