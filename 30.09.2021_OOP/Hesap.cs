using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._09._2021_OOP
{
    public class Hesap
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        private int bakiye;//dısardan erisme kapattık sadece prop uzerınden erısıılır.gelen istek getle karsılanır get uzerınden returnle dondurulur.set yapılacaksa value ıle deger atılır.prop fıeld bas harfı buyuk yazılır.

        public int Bakiye
        {
            get
            {
                if (bakiye>0)
                {
                 return bakiye+5;

                }
                else
                {
                    return 0;
                }
            ;  }
            set
            {
                if (value < 100)
                {
                    bakiye = value;
                }
                else
                {
                    bakiye = value * 2;
                }
            } 
        }















    }
}
