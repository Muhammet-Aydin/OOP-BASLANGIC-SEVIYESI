using System;

namespace _04._10._2021_Statıc_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
          
                new MyClass();

                new MyClass();
            
        }
    }
    class MyClass
    {
        public MyClass()
        {

            //her nesne uretılırken  ilk tetıklenecek metotdur.
            Console.WriteLine("my class const tetıklendi.");
        }
       static MyClass()
        {
            //bir sınıftan ilk nesne uretılıren tetıklenecek metotdur.
            //ilk nesne uretıldıkten sonra bir daha tetıklenmez.
            ///statik constructorlarda tetiklene bilmesş için illa nesne uertımını maınde dırekolarak cagırmaya gerek yokrur..
            /////ilgil sınıf ıcerısınde herhang bir metot teıklmesı statıc const tetıklemesıne yardımcı oalcatkır.
            Console.WriteLine("bu class içinde statıc sonct tetıklendı.");
        }

       
    }
}
