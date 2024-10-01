using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "\u20BA" + 
            //    "\n---- Portakal Birim Fiyatı: " + orangePrice + "\u20BA" +
            //    "\n---- Çilek Birim Fiyatı: " + strawberryPrice + "\u20BA" +
            //    "\n---- Patates Birim Fiyatı: " + potatoPrice + "\u20BA" +
            //    "\n---- Domates Birim Fiyatı: " + tomatoPrice + "\u20BA");

            //double appleGram = 1.245;
            //double orangeGram = 2.650;
            //double strawberryGram = 0.750;
            //double potatoGram = 4.859;
            //double tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;


            //Console.WriteLine("\n\n------------------------------------------------------------------------------------\n" +
            //                  $"Alınan Ürün: Elma ~ Birim Fiyatı: {applePrice:F2}\u20BA ~ Gramaj: {appleGram} ~ Toplam Tutar: {appleTotalPrice:F2}\u20BA \n" +
            //                  $"Alınan Ürün: Portakal ~ Birim Fiyatı: {orangePrice:F2}\u20BA ~ Gramaj: {orangeGram} ~ Toplam Tutar: {orangeTotalPrice:F2}\u20BA \n" +
            //                  $"Alınan Ürün: Çilek ~ Birim Fiyatı: {strawberryPrice:F2}\u20BA ~ Gramaj: {strawberryGram} ~ Toplam Tutar: {strawberryTotalPrice:F2}\u20BA \n" +
            //                  $"Alınan Ürün: Patates ~ Birim Fiyatı: {potatoPrice:F2}\u20BA ~ Gramaj: {potatoGram} ~ Toplam Tutar: {potatoTotalPrice:F2}\u20BA \n" +
            //                  $"Alınan Ürün: Domates ~ Birim Fiyatı: {tomatoPrice:F2}\u20BA ~ Gramaj: {tomatoGram} ~ Toplam Tutar: {tomatoTotalPrice:F2}\u20BA \n" +
            //                  "------------------------------------------------------------------------------------");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine($"Toplam Tutar: {shoppingTotalPrice:F2}\u20BA\n" +
            //    $"------------------------------------------------------------------------------------");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri - String

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****\n");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine($"\n\n-----------------------------------------------------\n" +
            //    $"YOLCU BİLGİLERİ\n" +
            //    $"Adı Soyadı: {passengerName} {passengerSurname}\n" +
            //    $"TC Kimlik No: {passengerIdentityNumber}\n" +
            //    $"Yaşı: {passengerAge}\n" +
            //    $"İkamet: {passengerCity} / {passengerDistrict}\n" +
            //    $"-----------------------------------------------------\n");

            #endregion

            #region Klavyeden Veri Girişleri - Tam Sayılar ve Dönüşüm

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz:");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz:");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz:");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine($"\nToplam Tutar: {totalPrice:F2}\u20BA");

            #endregion

            #region Klavyeden Veri Girişleri - Ondalıklı Sayılar ve Dönüşüm

            //double exam1, exam2, exam3, result;

            //Console.Write("\nLütfen 1. Sınav notunuzu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("\nLütfen 2. Sınav notunuzu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("\nLütfen 3. Sınav notunuzu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine($"\n\nOrtalama: {result:F2}");
            #endregion

            #region Klavyeden Veri Girişleri - Char ve Dönüşüm

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine($"Seçtiğiniz cinsiyet: {gender}");
            #endregion

            Console.Read();
        }
    }
}
