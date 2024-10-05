using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            Console.Write("Lütfen şifreyi giriniz:");
            string password = Console.ReadLine();

            if (password == "abcd")
            {
                Console.WriteLine("Şifre doğru!");
            }
            else
            {
                Console.WriteLine("Şifre yanlış!");
            }

            string capital, country;

            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();

            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();

            if (capital == "ankara" & country == "türkiye")
            {
                Console.WriteLine("Veriler Doğrulandı!");
            }
            else
            {
                Console.WriteLine("Hatalı Bilgi!");
            }

            int number;
            Console.Write("Sayı Giriniz: ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Sayı doğru!");
            }
            else
            {
                Console.WriteLine("Sayı hatalı!");
            }

            int exam1, exam2, exam3, average;
            string result = "Hata!";

            Console.Write("Sınav 1: ");
            exam1 = int.Parse(Console.ReadLine());

            Console.Write("Sınav 2: ");
            exam2 = int.Parse(Console.ReadLine());

            Console.Write("Sınav 3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine($"Sınavların ortalaması: {average}");

            if (average > 0 & average <= 50)
            {
                result = "Sonuç vasat";
            }
            if (average > 50 & average <= 69)
            {
                result = "Sonuç orta";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç iyi";
            }
            if (average > 84)
            {
                result = "Sonuç çok iyi!";
            }

            Console.WriteLine(result);

            string city;
            Console.Write("Lütfen şehir girişi yapınız: ");
            city = Console.ReadLine().ToLower();

            if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            {
                Console.WriteLine("Şehir mevcut!");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil!");
            }

            Console.Write("Lütfen kullanıcı adını giriniz: ");
            string userName = Console.ReadLine();

            if (userName != "admin")
            {
                Console.WriteLine("Bu kullanıcı adı kabul edilemez!");
            }
            else
            {
                Console.WriteLine("Hoş geldiniz!");
            }

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine($"Birinci sayının ({number1}) ikinci sayıya ({number2}) bölümünden kalan: {result}");

            //Console.Write("Lütfen bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}
            #endregion

            #region Char Değişkenler İle Karar Yapıları

            Console.WriteLine("Lütfen takım sembolünü giriniz.");
            char team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }
            #endregion

            #region Örnek Proje Uygulaması
            Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine($"\n1-Ana Yemekler\n2-Çorbalar\n3-Pizzalar\n4-İçecekler\n5-Tatlılar\n");
            Console.WriteLine("--------------------------------------");

            Console.Write("\nDetayını görmek istediğiniz menüyü seçin: ");
            string menuItem = Console.ReadLine();

            if (menuItem == "1")
            {
                Console.WriteLine("\n--------------------------------------\n");
                Console.WriteLine("****** Ana Yemekler ******" +
                    "\n\n1-Köri Soslu Tavuk" +
                    "\n2-Kızartma Tabağı" +
                    "\n3-Fasulye Pilav" +
                    "\n4-Fırında Somon" +
                    "\n5-Patlıcan Musakka");
                Console.WriteLine("\n--------------------------------------\n");
            }
            if (menuItem == "2")
            {
                Console.WriteLine("\n--------------------------------------\n");
                Console.WriteLine("****** Çorbalar ******" +
                    "\n\n1-Mercimek Çorbası" +
                    "\n2-Ezogelin Çorbası");
                Console.WriteLine("\n--------------------------------------\n");
            }
            if (menuItem == "3")
            {
                Console.WriteLine("\n--------------------------------------\n");
                Console.WriteLine("****** Pizzalar ******" +
                    "\n\n1-Akdeniz Pizza" +
                    "\n2-Margarita" +
                    "\n3-Tavuklu Pizza");
                Console.WriteLine("\n--------------------------------------\n");
            }
            if (menuItem == "4")
            {
                Console.WriteLine("\n--------------------------------------\n");
                Console.WriteLine("****** İçecekler ******" +
                    "\n\n1-Kola" +
                    "\n2-Ayran" +
                    "\n3-Su");
                Console.WriteLine("\n--------------------------------------\n");
            }
            if (menuItem == "5")
            {
                Console.WriteLine("\n--------------------------------------\n");
                Console.WriteLine("****** Tatlılar ******" +
                    "\n\n1-Baklava" +
                    "\n2-Triliçe" +
                    "\n3-Sütlaç");
                Console.WriteLine("\n--------------------------------------\n");
            }
            #endregion

            #region Switch-Case

            Console.Write("\n\nLütfen ay girişi yapınız: \n");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağustos"); break;
                case 9: Console.Write("Eylül"); break;
                case 10: Console.Write("Ekim"); break;
                case 11: Console.Write("Kasım"); break;
                case 12: Console.Write("Aralık"); break;
                default: Console.Write("Hatalı Giriş!"); break;
            }

            #endregion

            #region Switch-Case Hesap Makinesi

            int number1, number2, result2;
            char symbol;

            Console.Write("1. sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result2 = number1 + number2;
                    Console.WriteLine($"Sonuç: {result}");
                    break;
                case '-':
                    result2 = number1 - number2;
                    Console.WriteLine($"Sonuç: {result}");
                    break;
                case 'x':
                    result2 = number1 * number2;
                    Console.WriteLine($"Sonuç: {result}");
                    break;
                case '/':
                    result2 = number1 / number2;
                    Console.WriteLine($"Sonuç: {result}");
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
