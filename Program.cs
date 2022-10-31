# metotlar_overloading
using System;

namespace metotlar_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi="999";
            int outSayi;
           bool sonuc = int.TryParse(sayi,out outSayi);

            if(sonuc)
            {
                Console.WriteLine("Başarılı !");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarısız!");
            }
            metotlar instance = new metotlar();
            instance.topla(4,5,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);

            //metot aşırı yükleme - overloading

            int ifade=999;
            instance.ekranayazdir(Convert.ToString(ifade));
            instance.ekranayazdir(ifade);
            instance.ekranayazdir("Zikriye","ürkmez");
            //metot imzasi
            //metotadi + parametre sayisi +parametre

        }

    }

    class metotlar
    {
        public void topla(int a ,int b ,out int toplam)
        {   
            toplam=a+b;
            

        }

        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
         public void ekranayazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }
}
