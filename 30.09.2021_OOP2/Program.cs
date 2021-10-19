using System;

namespace _30._09._2021_OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        class Metot
        {
            //class mettotları fieldlarada yahut dısardan gelen paramteler eslıgınde gelen deger uzreınde işleler yapmamızı saglayan yapılardır.

        }

        //this keywordu sınıfın nesnelerini temsil eder.
        //aynı isimdeki field ile metot parametrelerini ayıtrmakiçin kullanılır.
        //bir constructordan baska br yapıcı metodu cagırmaya yarar.
        

        class MyClass
        {
            int x;
            public void P(int x)
            {
               
                // x;//paramtrededir.
                //this.x; //classında fıeldina erıstık.baska turlu erişemeyiz.

               //  x  //aynı paramtre yoksa fieldi getirir.          
            }
        }
        class MyClass2
        {
            int x;
            public void P(int z)
            {
                //class ıle fıeld ısmı aynı degilse;
               // x;  //this keyworduyle ilgili class yapılanasnının o ankı nesnesnie karsılık gelir. this keywordu kullanma zorunda degilsin c# bunu otomatık getitir.
                    //ts
            }



        }



    }
}
