using System;

namespace _05._10._2021_İnheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            

        }
    }
    class MyClass
    {
        public MyClass(int a)
        {
            
        }
        public MyClass()//2tane ctor olursa kalıtım alırken hangısını kullanmak ısertsek ınu kullanarak deger gonderırırz.
        {

        }



    }
    class MyClass2:MyClass
    {

        public MyClass2() : base(5)
        {

        }
       
        //egerki base stor //parametre alan cor ıse child classlarda o constro-uctorın degerını dongermek zorundayız.

    }
}
