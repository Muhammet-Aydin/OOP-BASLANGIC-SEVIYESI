using System;

namespace _05._10._2021_İnheritance6_Virtual_Override2
{
    class Program
    {
        static void Main(string[] args)
        {


            Maymun myn = new Maymun();
            myn.Konus();
            İnek ink = new İnek();
            ink.Konus();


        }
    }
    class Memeli
    {
        virtual public void Konus()
        {
            Console.WriteLine("konusuyor...");
               
        }
    }
    class İnek:Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("inek konusuyor.");
        }
    }
    class Maymun:Memeli
    {
        public override void Konus()
        {
            Console.WriteLine("maymun konsuyor...");
        }
    }
}
