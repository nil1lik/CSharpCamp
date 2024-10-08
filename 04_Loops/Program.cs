using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100 ; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue++;
            //}

            //Console.WriteLine(totalValue);

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i%2==0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine($"--------------\n{totalValue}");

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine($"{i}. saat sonunda: {bacterium}");
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //int sum = 0;

            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //while (i<=10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //while (i<=10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            int sum = 0;
            Console.Write("Lütfen 3 basamaklı bir sayı giriniz: ");
            int num = int.Parse(Console.ReadLine());

            int ones, tens, hundreds;

            ones = num % 10;
            hundreds = num / 100;
            tens = (num % 100) / 10;
            sum = ones + hundreds + tens;
            Console.WriteLine($"Basamak değerleri toplamı: {sum}");

            #endregion

            Console.Read();
        }
    }
}
