using System;

namespace _04._10._2021_Constructor_Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my1 = new MyClass();
            
            my1.Topla();

            //parantez acılıp kapandıgında constructor mettotu tetıklemiş olunur.
            //ram heap alanında myclass nesnesi olustururken yapmamız gereken seyler yazılır.
            //class newlendıgınde ılk basta teıklendıgınde çalısır.

            //contructor metotdun ozellıklerı:
            //ozel bır sınıf elemeanıdır.
            //bildiimimiz metot ımzalarıdan farklıdır.
            //yapıcı metotların metot adı sınıf adıyla aynıdır.


            //new Class1();//bulamadıgı için yapamadı.

            //Class1 cl2 = new Class1();



        }
      public  class MyClass
        {
            public MyClass()//public olmalıdır.
            {
                //ctor tab tab
                //kendi yapar.
                Console.WriteLine("ilk ben calısırım.");
            }

            private MyClass(int a) //baska bir classta newlerken erısemeyız.
            {
                //bu ezilmiş olur.
            }
            public MyClass(string a)
            {
                //asırı yukleme yaptık.
            }

            public int MyProperty { get; set; }


            public void Topla()
            {   
                Console.WriteLine( "topladım.");
            }


        }
    }
}
