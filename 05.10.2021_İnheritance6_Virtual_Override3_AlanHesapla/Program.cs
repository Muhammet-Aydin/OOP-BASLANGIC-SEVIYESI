using System;

namespace _05._10._2021_İnheritance6_Virtual_Override3_AlanHesapla
{
    class Program
    {
        static void Main(string[] args)
        {
            Üçgen üçg = new Üçgen(5,4);
            Kare kr = new Kare(5,5);
            Dikdörtgen drt = new Dikdörtgen(4,8);

            Console.WriteLine("üçgen alan:"+ üçg.AlanHesapla());
            Console.WriteLine("kare alan:" + kr.AlanHesapla());
            Console.WriteLine("dikdörtgen alan:" + drt.AlanHesapla());
        }
    }
    //sanal yapılar oopde en cok polimorfizm cokbiçimlilik dediğimiz yapıda kullanılır.
    //eger bir nesneyi sanal olarak bildirmişseniz derleyici nesnelerin tur bilgisinden daydalanarakm dermeleme zamanında hangı nesnenn ılgılı memberını cagırıcagını bilir.


    //şekil adındakı base clasımızın içine fıeldlarımızı ve constructor metotumuzu yazdık chıld classlardan gelen degerler buraya tasınacak burdan fıeldlara aktarılır.
    //alan hesapla her sekil için farklı yapılacagından alan hesapla mettodnu virtual oalrak işsaretldik.

    class Şekil
    {
        public int _boy;
        public int _en;
        public Şekil(int boy, int en)//constructor metot parametreleri aldık fıeldlara attık.
        {
            _boy = boy;
            _en = en;
        }

        virtual public int AlanHesapla()
        {
            return 0;

        }
    }
    class Üçgen : Şekil
    {
        public Üçgen(int boy,int en):base(boy,en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en / 2;
        }
    }
    class Kare : Şekil
    {
        public Kare(int boy,int en):base(boy,en)
        {
            
        }
        public override int AlanHesapla()
        {
            return _boy * _en;
        }
    }
    class Dikdörtgen : Şekil
    {
        public Dikdörtgen(int boy, int en) : base(boy,en)
        {

        }
        public override int AlanHesapla()
        {
            return _boy * _en * 2;
        }
    }
}
