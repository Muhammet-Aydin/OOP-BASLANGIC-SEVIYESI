using System;

namespace _04._10._2021_constructor_overload_with_thiskeyword
{
    class Program
    {
        static void Main(string[] args)
        {
           MyClass my1 = new MyClass();
           MyClass my2 = new MyClass(5);
           MyClass my3 = new MyClass(5,50);

            //eger bir yapıcı mettot tetıklendıgınde diger yapıcı metotlarında tetıklenmesını ıstıyorsanız this keywordu gerekir.
        }

        class MyClass
        {
            public MyClass()
            {
                Console.WriteLine("1.ctor calıstı.");
            }
            public MyClass(int a):this()
            {
                Console.WriteLine($"2.ctor:{a}");
            }
            public MyClass(int a,int b) :this(a) 
            {
                Console.WriteLine($"3.ctor:a:{a} b:{b}");
            }
            //this ile birlikte o yapıcı mettot harıcındekı yapıcı metotlarıda kullnabiliyoruz.


        }
    }
}
