using System;

namespace _05._10._2021_İnheritance6_Virtual_Override
{
    class Program
    {
        static void Main(string[] args)
        {

            Pc p = new Pc();
            Obje obj = new Pc();
            obj.BilgeVer();

        }
        //bir nesne uzerınde var olan tum memberların tamamı derleme zamanında bellidir.
        //Yani derleme esnasında hanig nesneler uzerınde hangi metotdu cagırdırıgınız bellidir.
        //sanal yapılar ile derleme zamanında kesın olarak bilinen metodun run tımede belirlenebilmektedir.yani nesne ile ilgili hangı
        //metotdu kullancagınız run tımede belirtilir.
        //bu işlemleri gerçeklestırebilmek için virtual yapıları kullanırız.
        //bizler bır sınıfta sanal yaı olusturmak istersek (metot,propert,fıeld)imzasını virtual keyworduyle ısaretlemek gerekiyor.
        //
    }
    class MyClass
    {
        public void fnk()
        {

        }
        public virtual int MyProperty { get; set; }

        //bir classta vırtual ile işsartlenerek sanal hale getirilebilir.
        //bu class mıras alan torunlarında ezilmek isteniyorsa override keyworduyle ezebilirsiniz.

    }
    class MyClass1
    {
        public virtual void fnk()
        {

        }
        virtual public int MyProperty { get; set; }
    }







    class Obje
    {
        virtual public void BilgeVer()
        {
            Console.WriteLine("Ben bir objeyim.");
        }
    }
    class Pc : Obje
    {
        public override void BilgeVer()
        {
            Console.WriteLine("ben bir bilgisayarım.");
        }
    }
    class Masa : Obje
    {
        public override void BilgeVer()
        {
            Console.WriteLine("ben bir masayım.");
        }
    }
    class Fare : Obje
    {
        public override void BilgeVer()
        {
            Console.WriteLine("ben bir fareyim.");
        }
    }
    class Bardak : Obje
    {
        public override void BilgeVer()
        {
            Console.WriteLine("ben bir bardagım.");
        }
    }
    //ikiden cok hıyarık durumda kalıtım durmlarında override durumu
    //bir classta vertual oalrak işsaretlenmıs herhangı bşr member illakı direkt olarak o classtan tureyen birinci dereceden classlarda overrıde edilmek mecburıyetınde degildir.
    //eger ihtiyac duurumunda bir alt seviyedeki torunlandan herhangı biri ezilecbilir.
    //fakat böyle bir durumda krıtık bir durum soz konsudur bu sorunda soyutlanan memberın en son override edildiği objectten sonra 
    //gerçeli oldugudur ve objectten sonra hıyarearsık olarak turetılen sınıflar varsa onlarda override işlemi gerceklestırılebilir.
}
