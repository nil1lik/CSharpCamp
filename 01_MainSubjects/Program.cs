using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Yazdırma Komutları

            Console.WriteLine("Merhaba Dünya!");
            Console.Write("Selam");

            Console.WriteLine("\n\n-----------------------------------------");

            Console.WriteLine
               (
                "\n\n***** Yemek Kategorileri *****\n" +
                "\n1-Çorbalar" +
                "\n2-Ana Yemekler" +
                "\n3-Soğuk Başlangıçlar" +
                "\n4-Salatalar" +
                "\n5-Tatlılar" +
                "\n6-İçecekler" +
                "\n\n***** Yemek Kategorileri *****"
               );

            #endregion

            Console.WriteLine("\n\n-----------------------------------------");

            #region Değişkenler

            //string name;
            //name = "Nil";
            //Console.WriteLine($"\n{name}");

            string customerName, customerSurname, customerPhone, customerEmail, customerDistrict, customerCity;

            customerName = "Nil";
            customerSurname = "1lik";
            customerPhone = "+90 532 532 00 00";
            customerEmail = "1lik@gmail.com";
            customerDistrict = "Bakırköy";
            customerCity = "İstanbul";

            Console.WriteLine($"\n\n" +
                $"***** Rezervasyon Kartı *****" +
                $"\n\n" +
                $"Ad Soyad: {customerName} {customerSurname}\n" +
                $"Telefon: {customerPhone}\n" +
                $"E-mail: {customerEmail}\n" +
                $"Adres: {customerCity} / {customerDistrict}\n" +
                $"\n***** Rezervasyon Kartı *****");


            customerName = "Asel";
            customerSurname = "1lik";
            customerPhone = "+90 555 555 00 00";
            customerEmail = "asel@gmail.com";
            customerDistrict = "Güngören";
            customerCity = "İstanbul";

            Console.WriteLine($"\n\n" +
                $"***** Rezervasyon Kartı *****" +
                $"\n\n" +
                $"Ad Soyad: {customerName} {customerSurname}\n" +
                $"Telefon: {customerPhone}\n" +
                $"E-mail: {customerEmail}\n" +
                $"Adres: {customerCity} / {customerDistrict}\n" +
                $"\n***** Rezervasyon Kartı *****");

            #endregion

            Console.WriteLine("\n\n-----------------------------------------");

            #region Integer Değişkenler

            //int number;
            //number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice, cokePrice, waterPrice, friesPrice, pizzaPrice, lemonadePrice;
            hamburgerPrice = 300;
            cokePrice = 35;
            waterPrice = 10;
            friesPrice = 50;
            pizzaPrice = 250;
            lemonadePrice = 30;

            Console.WriteLine($"\n\n" +
                $"***** Restoran Menü Fiyatı *****\n\n" +
                $"Hamburger: {hamburgerPrice}\u20BA\n" +
                $"Pizza: {pizzaPrice}\u20BA\n" +
                $"Kızartma: {friesPrice}\u20BA\n" +
                $"Kola: {cokePrice}\u20BA\n" +
                $"Limonata: {lemonadePrice}\u20BA\n" +
                $"Su: {waterPrice}\u20BA\n" +
                $"\n\n***** Restoran Menü Fiyatı *****");

            Console.WriteLine("\n\n-----------------------------------------");

            int hamburgerCount, cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount;

            int totalPrice = 0;
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalCokePrice = cokeCount * cokePrice;
            int totalWaterPrice = waterCount * waterPrice;
            int totalLemonadePrice = lemonadeCount * lemonadePrice;
            int totalFriesPrice = friesCount * friesPrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine($"\n\n" +
                $"***** Detaylı Fiş *****\n\n" +
                $"Hamburger Tutarı: {totalHamburgerPrice}\u20BA\n" +
                $"Pizza Tutarı: {totalPizzaPrice}\u20BA\n" +
                $"Kızartma Tutarı: {totalFriesPrice}\u20BA\n" +
                $"Kola Tutarı: {totalCokePrice}\u20BA\n" +
                $"Limonata Tutarı: {totalLemonadePrice}\u20BA\n" +
                $"Su Tutarı: {totalWaterPrice}\u20BA\n" +
                $"\n***** Detaylı Fiş *****");

            int totalPrice2 = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalLemonadePrice + totalFriesPrice + totalPizzaPrice;

            Console.WriteLine($"\n\nToplam Tutar: {totalPrice2:F2}\u20BA");

            #endregion

            Console.WriteLine("\n\n-----------------------------------------");

            Console.Read();
        }
    }
}
