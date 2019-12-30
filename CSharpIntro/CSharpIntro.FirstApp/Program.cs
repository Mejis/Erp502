using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntro.FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FirstApp");
            Console.WriteLine("FirstApp");
            Console.WriteLine("FirstApp");
            Console.WriteLine("FirstApp");

            //VERİ TİPLERİ

            //Console.WriteLine("Size of byte :" + sizeof(byte) + " Byte. Max :" + byte.MaxValue + " Min :" + byte.MinValue);
            //Console.WriteLine("Size of int :" + sizeof(int) + " Byte. Max :" + int.MaxValue + " Min :" + int.MinValue);
            //Console.WriteLine("Size of short :" + sizeof(short) + " Byte. Max :" + short.MaxValue + " Min :" + short.MinValue);
            //Console.WriteLine("Size of ushort :" + sizeof(ushort) + " Byte. Max :" + ushort.MaxValue + " Min :" + ushort.MinValue);
            //Console.WriteLine("Size of long :" + sizeof(long) + " Byte. Max :" + long.MaxValue + " Min :" + long.MinValue);
            //Console.WriteLine("Size of ulong :" + sizeof(ulong) + " Byte. Max :" + ulong.MaxValue + " Min :" + ulong.MinValue);
            //Console.WriteLine("Size of decimal :" + sizeof(decimal) + " Byte. Max :" + decimal.MaxValue + " Min :" + decimal.MinValue);

            ////Sayısal Veri Tipleri
            ////byte,sbyte,short,ushort,int,uint,long,ulong,float,double,decimal
            ////Sözel veri tipleri
            ////char,string
            ////Özel Tip
            ////bool(Boolean)=>True/False

            ////object:Bu veri tipine her türden veri atanabilir.

            //byte _int1 = 100;
            //byte _int2 = 100;

            //byte _int2 =_int1++;

            //int _TopInt =_int1 + _int2;
            //int _TopInt1 = (_int1 + _int2);
            ////Console.WriteLine(_TopInt);
            //Console.WriteLine(_TopInt1);

            //Console.WriteLine(_int1);
            //Console.WriteLine(_int2);

            //DİZELER(ARRAYS)

            //Yazım Şekli
            //veriTipi[] diziAdi=new veriTipi[veriBoyutu(Tutulacak eleman sayısı)];

            //int[] sayilar = new int[10] { 1,2,3,4,5,6,7,8,9,10};
            //int[] sayilar1 = new int[10];
            //sayilar1[0] = 11;
            //sayilar1[1] = 12;
            //sayilar1[2] = 13;
            //sayilar1[3] = 14;
            //sayilar1[4] = 15;
            //sayilar1[5] = 16;
            //sayilar1[6] = 17;
            //sayilar1[7] = 18;
            //sayilar1[8] = 19;
            //sayilar1[9] = 20;

            //int[] sayilar2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            //Console.WriteLine(sayilar[5]);
            //Console.WriteLine(sayilar1[5]);

            //string[] mevsimler = new string[4] { "İlkbahar","Yaz","Sonbahar","Kış"};
            //string[] mevsimler1 = { "İlkbahar","Yaz","Sonbahar","Kış"};

            //string bos = "";
            //bos = null;

            //int a;
            //a = -1;
            //Console.WriteLine(a);


            //string[] gunler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };

            //Clear Metodu

            //Array.Clear(gunler, 2, 2);

            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    Console.WriteLine(gunler[i]);
            //}

            //foreach (string item in gunler)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(gunler[0]);
            //Console.WriteLine(gunler[1]);
            //Console.WriteLine(gunler[2]);
            //Console.WriteLine(gunler[3]);
            //Console.WriteLine(gunler[4]);
            //Console.WriteLine(gunler[5]);
            //Console.WriteLine(gunler[6]);

            //Console.WriteLine("Eleman sayısı : {0}    {1}",gunler.Length,gunler[5]);
            //Console.WriteLine($"Eleman sayısı : {gunler.Length} -**- {gunler[3]}");

            //int[] numbers = { 4, 12, 56, 2, 67, 35 };
            //Console.WriteLine($"Eleman sayısı : {numbers.Length}");
            //Console.WriteLine($"Dizinin ortalaması : {numbers.Average()}");
            //Console.WriteLine($"Dizinin ilk elemanı : {numbers.First()}");
            //Console.WriteLine($"Dizinin son elemanı : {numbers.Last()}");
            //Console.WriteLine($"Dizinin en büyük elemanı : {numbers.Max()}");
            //Console.WriteLine($"Dizinin en küçük elemanı : {numbers.Min()}");
            //Console.WriteLine($"Dizinin elemanları toplamı : {numbers.Sum()}");


            //Console.WriteLine($"12 sayısı dizinin kaçıncı elemanı : {Array.IndexOf(numbers,12)}");
            //Console.WriteLine($"67 sayısı dizinin kaçıncı elemanı : {Array.IndexOf(numbers, 67)}");

            int sayi1 = 4;
            int sayi2 = 6;

            //int sonuc1 = sayi1++ + sayi2;//10
            //int sonuc1 = ++sayi1 + sayi2;//11
            //int sonuc1 = ++sayi1 + sayi2++;//11
            //int sonuc1 = ++sayi1 + sayi2++ + sayi1;//16
            //int sonuc1 = ++sayi1 + sayi2++ + ++sayi1 + ++sayi1 + ++sayi2;//32
            //                //5       //6        6         7         8
            //string sonuc1 = "45" + 5 + 9;//4559
            //string sonuc1 = "45" + (5 + 9);//4514
            //string sonuc1 = 5 + 9 + "45";//1445
            //string sonuc1 = 5 + 9 + "23" + 5 + 4 + "3";//1423543
            //string sonuc1 = 5 + 9 + "" + "5" + 4 + "3";//14543 
            string sonuc1 = 5 + (9 + "23") + "5" + 4 + "3";//5923543


            Console.WriteLine(sonuc1);

            Console.ReadKey();

            //C# Conversions
            //1=>Implicit Conversion 2=>Explicit Conversion
            //Debugging
            //Watch Penceresi
            //QuickWatch Penceresi
            //Autos Penceresi
            //Immediate Penceresi
            //Hata Türleri
            //==> CompileTimeException
            //==> RunTime Exception

        }
    }
}
