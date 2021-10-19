using System;

namespace _05._10._2021_İnheritance5
{
    class Program
    {
        static void Main(string[] args)
        {
            D d = new D();
            d.x();
          
        }
    }
    class A
    {
        public void x()
        {


        }

    }
    class B:A
    {

    }
    class C:B
    {

    }
    class D:C
    {
        public new void x()
        {
        
        //a clasının içindeki metotla d clasının içicdeki metot aynı ısımde fakat birbrinden mıras alıkları ıcın farklılıgınıbelirtmek için new yazarsak farklılaasırlar. hangi metot kullanmak ıstıyorsak new yazarsırz compile gizleme ozelliğini  devreye sokarak base clasın altındakı ismi gizler.
        //eskiden bu ıslem new keywordu ile compile sevıyesınde belirtilirdi.fakat gunumuzde ısım gızleme ıslemı complie tarafından gercekleştırılır.
        //ve derlerken hata almayız ama uyarı alırız.

            //record 
            //recordlar sadece ve sadece recordlardan kalıtım alırlar.
            //classlardan kaltıım alamazlar veremezlerde.
            //birden fazla recordtan kalıtım asla alamaz.
            //this. base keyworları geçeerlirdir.
            
        }

    }



}
