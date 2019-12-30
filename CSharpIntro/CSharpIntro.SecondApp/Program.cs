using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.SecondApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SecondApp");

            //KARAR YAPILARI
            //IF - ELSE IF - ELSE
            /*
             if(koşul)
             {
                koşul doğruysa yapılacaklar
             }
             else
             {
                koşul yanlışsa yapılacaklar
             }
             */

            int sayi = 15;
            //if (sayi==10)
            //{
            //    Console.WriteLine("Sayı=10 doğru bir koşul");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı=10 doğru bir koşul değil");
            //}

            //if (sayi<10)
            //{
            //    Console.WriteLine("Sayı 10 dan küçük");
            //}
            //else if (sayi == 10)
            //{
            //    Console.WriteLine("Sayı 10 a eşit");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 10 dan büyüktür");
            //}


            //if (sayi < 10)
            //{
            //    Console.WriteLine("Sayı 10 dan küçük");
            //}
            //else if (sayi >= 10)
            //{
            //    Console.WriteLine("Sayı 10 a eşit yada 10 dan büyük");
            //}

            //Klavyeden girilen iki yazılı notunun ortalamasını bulup 5 lik sistemde notunu ekrana yazan c# console kodlarını yazın.

            double yazili1, yazili2, ortalama;

            Console.WriteLine("Lütfen 1.Yazılı sonucunu giriniz.");
            yazili1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen 2.Yazılı sonucunu giriniz.");
            yazili2 = Convert.ToDouble(Console.ReadLine());

            ortalama = (yazili1 + yazili2) / 2;

            // 0-24 F
            // 25-49 D
            // 50-64 C
            // 65-79 B
            // 80-100 A

            if (ortalama>=0 && ortalama <25)
            {
                Console.WriteLine("F");
            }
            else if(ortalama >= 25 && ortalama < 50)
            {
                Console.WriteLine("D");
            }
            else if(ortalama >= 50 && ortalama < 65)
            {
                Console.WriteLine("C");
            }
            else if(ortalama >= 65 && ortalama < 80)
            {
                Console.WriteLine("B");
            }
            else if(ortalama >= 80 && ortalama < 101)
            {
                Console.WriteLine("A");
            }
            //else
            //{
            //    Console.WriteLine("Hatalı giriş yaptınız. sınav sonuçlarını 0-100 arası değerler olarak giriniz.");
            //}


            Console.ReadKey();
        }
    }
}
