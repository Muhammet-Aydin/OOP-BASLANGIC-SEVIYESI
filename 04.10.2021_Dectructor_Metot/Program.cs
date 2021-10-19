using System;

namespace _04._10._2021_Dectructor_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir classtan uretılen nesne ımha edilirken ototmatık olarak  cagrılan metot dıyebılırrız c# desctructor sadece sadece class yapılanmasında kullnılır.
            //ilgili nesne herhangi bir referans tarafından tutulmuyorsa,
            //yada nesne olustu kullanıldı  kısım sona ermıstır.
            //yanı nesne erısılemez hale gelir.

            // ~ tilda işareti ile yapılır.
            //altgr+ü+space


            //garbage Collector; 
            //luzumsuz olan nesnlerı toplar
            //bellek optımızayonu gerevini yurutur.
            //nasıl calısıacgını bilemeyiz,calısmasına karısmamalıyız.

            NesneÜret();

            GC.Collect();//gc ulasmak ıcın kullandıgımız sınıfın adı:

           



        }
        static void NesneÜret()
        {
            MyClass my = new MyClass();
        }
    }
    class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("nesne üretildi.");
        }
        ~MyClass()
        {
            Console.WriteLine("nesne yıkılıyorr...");
        }
    
    
    }





}
