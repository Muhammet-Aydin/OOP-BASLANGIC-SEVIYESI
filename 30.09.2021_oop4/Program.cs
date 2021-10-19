using System;

namespace _30._09._2021_oop4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass()
            {
                MyProperty = 50, 
                MyProperty2 = 60, 
                MyProperty3 = 90
            };
            //ıntance alma işlemi //object ınıtılazıer ozelliğyle boyle yapılabilir.newleme işlemi esnasında  proplara baslangıc degeri atanarak nesne olusturukur.prop init ozelliyle bu sekılde olusturulablir.diger turlu nesne once olusturulur ardından gidlip degerler atılır asagıda olduugu gibi.yanı biz burada bu yontemle bu propartyın baslangıc degerlini set etmıs oluyoruz.
            //my.MyProperty =2;
            //my.MyProperty2 =4;
            //my.MyProperty3 =6;




        }
        class MyClass
        {
            public int MyProperty { get; set; }
            public int MyProperty2 { get; set; }
            public int MyProperty3 { get; set; }
        }
    }
}
