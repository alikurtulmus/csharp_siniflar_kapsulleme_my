using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_siniflar_kapsulleme_my
{
    internal class araba
    {
        //değişkenlerin erişim türü public olursa diğer formlardan da erişim sağlanabilir. ancak private yaptığımızda diğer formlardan erişim sağlanamaz.
        public string renk;
        public int hiz;
        public double motor;
        public char durum;
        public int fiyat;

        private int yil;
        private string marka;

        //private tanımladığımız değişkenler diğer formlarda kullanılamayacağı için aşağıdaki işlemleri yaptık

        public int YIL
        {
            get { return yil; } //get komutuna geriye döndüreceğimiz değeri yazarız.
            set { yil = Math.Abs(value); } //math kütüphanesindeki abs komutunu kullanarak girilen negatif değerlerin mutlak değerini alarak "yil" değişkenine atadık
            //diğer formlarda ikinci oluşturduğumuz YIL değişkenini kullanırız

        }

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); } //marka kısmına yazdığımız harfleri büyük harfe çevirir
        }



    }
}
