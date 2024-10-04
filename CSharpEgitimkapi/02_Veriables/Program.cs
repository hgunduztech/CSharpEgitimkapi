using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler           

            ////double number;

            ////number = 4.85;
            ////Console.WriteLine(number);


            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyat: " + applePrice + " TL - Gram: " + appleGram + " kg - Toplam Fiyat: " + appleTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyat: " + orangePrice + " TL - Gram: " + orangeGram + " kg - Toplam Fiyat: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyat: " + strawberryPrice + " TL - Gram: " + strawGram + " kg - Toplam Fiyat: " + strawTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyat: " + potatoPrice + " TL - Gram: " + potatoGram + " kg - Toplam Fiyat: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyat: " + tomatoPrice + " TL - Gram: " + tomatoGram + " kg - Toplam Fiyat: " + tomatoTotalPrice + " TL");










            #endregion Double Degiskenler


            #region Char Degiskenler
            //// ABCDEFGH
            ////DEF
            ////TOPLANTI SAAT 20 : 00

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion Char Degiskenler

            #region Klavyeden Veri Girişleri String Degiskenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //// Yolcu bilgilerini al
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //// Bilgileri yazdır
            //Console.WriteLine(passengerName + " " + passengerSurname + " " +
            //    passengerDistrict + " / " + passengerCity + " " + passengerAge + " " + passengerIdentityNumber);






            #endregion Klavyeden Veri Girişleri String Degiskenler


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler


            // ABC12D BURADA K, KODU BİR SAYISAL DEĞER OLARAK GÖRMEZ

            //int shosPrice, computerPrice, chairPrice, tvPrice;

            //shosPrice = 100;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shosCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shosCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //// Toplam fiyatı hesaplama (her ürünün fiyatı ile sayısını çarpıyoruz)
            //int totalPrice = (shosCount * shosPrice) + (computerCount * computerPrice) + (chairCount * chairPrice) + (tvCount * tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);







            #endregion Klavyeden Tam Sayı Girişleri ve Dönüşümler

            #region Klavyeden ondalıklı sayı işlemler

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Ortalamamız: " + result);






            #endregion Klavyeden ondalıklı sayı işlemler


            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen Cinsiyet Seçiniz: ");
            gender = char.Parse(Console.ReadLine());


            Console.WriteLine("Seçtiğiniz Ciniyet:" + gender);



            






            #endregion Klavyeden Karakter Girişleri



            Console.Read();


        }
    }
}
