using System;

namespace _05._10._2021_İnheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            
          new D();
            
            //HEPSİ BİRBİRİNDEN NEWLENDIGI İÇİN EN UST CLASS SONRA ALTA DOGRU NEWLENIR.



        }
    }
    class A
    {
        public A()
        {
            Console.WriteLine($"{nameof( A )}nesne olusturulmuştur.");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine($"{nameof( B )}nesne olusturulmuştur.");
        }
    }

    class C:B
    {
        public C()
        {
            Console.WriteLine($"{nameof( C )}nesne olusturulmuştur.");
        }
    }

    class D:C
    {
        public D()
        {
            Console.WriteLine($"{nameof( D )}nesne olusturulmuştur.");
        }
    }
}
