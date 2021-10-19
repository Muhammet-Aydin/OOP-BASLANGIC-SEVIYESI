using System;

namespace _30._09._2021_oop5
{
    class Program
    {
        static void Main(string[] args)
        {
            //2tıp kopyalama davranısı cardır 
            //deep copy
            //shallow copy

            //var olan bır nesnenin referansının kopyalanmasıdır.
            // eldeki deger cagaltılmaz 
            //referansı cagaltılır.

            MyClass m1 = new MyClass();
            MyClass m2 = m1;
            MyClass m3 = m2;
            MyClass m4 = new MyClass();

            //isaret ettıklerı nesneler kopyalanmıstır.bu işlemem shollow kopy denir.            

            MyClass n1 = null;
            MyClass n2 = new MyClass();
            n1 = n2;
            MyClass n3 = n2;
            m1 = m3;
            //hepsi n2 baktıgı yere bakar.

            //bir nesneyi birden fazla referansla isaretleyebiliriz.bu duruma shoollow copy denir.
            //deep copy yapmak istiyorsak clone ıle yapılır.
            MyClass k1 = new MyClass();
            MyClass k2 = k1;//shallow kopy yapar.
            MyClass k3 = k1.deepcopy();//deeep copy yapar.
            k1.yıl = 50;
            k3.yıl = 60;
            Console.WriteLine(k1.yıl) ;
        }

    }
    class MyClass
    {
     public int yıl;
        public MyClass deepcopy()
        {
            return (MyClass)this.MemberwiseClone();//deep copy yaptık.
        } 
    }
}
