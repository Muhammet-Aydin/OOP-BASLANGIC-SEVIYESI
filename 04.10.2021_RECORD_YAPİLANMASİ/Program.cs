using System;

namespace _04._10._2021_RECORD_YAPİLANMASİ
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# 9.0 İLE GELDİ HERHANGI BİR NESNENİN PROPERTY DEGERİNE İLK DEGERİN VERİLMESİ VE SONRAKI SURECTE BU DEGERİN DEGİŞTİRİLMEMESİNİN GARANTI ALTINA ALINMASINI SAGLAYAN INIT ONLY PROPERTY ÖZELLİĞİYLE GELMİŞTİR.
            //BU OZELLIKLE NESNENİN YARATLIS ANINDA PROPTERLERİNE DEGER ATANMAKTA OLUP BOYLE IS URALLARI GEREGINCE RUNTIMEDE DEGİŞMEMESİ GARANTISINI VERİR.
            //GET ONLY PROP NESNEYİ NEWLEME ESNASINDA OBJECT INITILAZIER ILE DEGER ATAMASI YAPAMIYORUZ BU EKSIKTEN DOLAYI BİZE INIT ONLY PROPERTYLER YARDIMCI OLACAKTIR.

            MyClass my1 = new MyClass()
            {
                MyProperty = 5
              

            };
            MyClass my2 = new MyClass()
            {
                MyProperty = 5
            };
            Console.WriteLine(my1.Equals(my2));//false doner referansları esıt degildir.

            İlkRecord my3 = new İlkRecord()
            {
                MyProperty = 5
            };
            İlkRecord my4 = new İlkRecord()
            {
                MyProperty = 5
            };
            Console.WriteLine(my3.Equals(my4));//true doner degerleri esıt oldugu için.
        }
        class MyClass
        {
            public int MyProperty { get; init; }
        }
        record İlkRecord
        {
            public int MyProperty { get; set; }
            //referanslardan zıyade degerler  on plandadır.
        }
 
    }
}
