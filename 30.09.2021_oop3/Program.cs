using System;

namespace _30._09._2021_oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack bölgesinde tanımlanan ve heap bölgeside nesnleri işaretleyen referans eden noktalardır.
            //  stack bölgesinde int,bool deger tıpınde degişkenler tanımlanır degerleri ile ...
            // interface ,abstractclass,class referans tiplerdir.
            //bunlar ramın stack bölgesinde referansı tutulur.
            //ramın heap alanında ise bu barındırdıgı alanların valueları barındırılır.,
            //kalıtım aldıgı herhangı bir sınıftan aynı turde ıse referansını tutar
            //biri nesne olusturun derse aklınıza ılk gekecek olan sey class olmalı.

            MyClass myc = new MyClass();
            myc.MyProperty = 50;
            myc.MyProperty2 = "ali";

            MyClass myc2 = new MyClass();

            myc2 = null;
            //null olan nesnesi olamyan yapı.
            // Console.WriteLine(myc2.MyProperty);//null referance exceptıon hatası verir.
            //  Console.WriteLine(myc2.MyProperty2);

            MyClass my1 = new MyClass();

            my1.fonc(new MyClass());

            new MyClass().MyProperty = 50;
            //luzumsuz yer tutar bır sure sonra garbage colletor ref buunmyanaları temızler.
    
        }
        class MyClass
        {
            public int MyProperty { get; set; }
            public string MyProperty2 { get; set; }

            public void fonc(MyClass my1)
            {

                Console.WriteLine(my1.MyProperty);
            }
        }





    }
}
