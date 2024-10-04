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
            #region yazdırma komutları                  

            //Console.Write("MERHABA DÜNYA");
            //Console.Write("HAMZA");
            //Console.Read();

            //Console.WriteLine("****** YEMEK KATEGORİLERİ ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("****** YEMEK KATEGORİLERİ ******");

            //Console.Read();

            #endregion yazdırma komutları

            #region StrinDegiskenler

            //string
            //Degisken_türü_degisken_adı:

            //string name;
            //name = "Hamza";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "hamza";
            //customerSurname = "gunduz";
            //customerPhone = "555555555";
            //customerEmail = "deneme@gmail.com";
            //district = "baglar";
            //city = "diyarbakır";



            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("EmailAdresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);


            //customerName = "Ayşegül";
            //Console.WriteLine(customerName);
            //customerSurname = "Kaya";
            //customerPhone = "54577454555454";
            //customerEmail = "grggr@gmail.com";
            //district = "yenişehir";
            //city = "Batman";


            //Console.WriteLine();
            //Console.WriteLine("-----------------------");
            //Console.WriteLine("Müşteri:" + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("EmailAdresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);

            //Console.WriteLine("-----------------------");





            #endregion StrinDegiskenler


            #region intdegiskenler

            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokPrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int PizzaPrice = 250;
            int lemonedePrice = 30;

            Console.WriteLine("**** RESTAURANT MENÜ FİYATLARI **** ");
            Console.WriteLine();
            Console.WriteLine("------Hamburger Fiyatı: " + hamburgerPrice + "TL");
            Console.WriteLine("------Hamburger Fiyatı: " + lemonedePrice + "TL");
            Console.WriteLine("------Hamburger Fiyatı: " + waterPrice + "TL");
            Console.WriteLine("------Hamburger Fiyatı: " + PizzaPrice + "TL");
            Console.WriteLine("------Hamburger Fiyatı: " + cokPrice + "TL");
            Console.WriteLine("------Hamburger Fiyatı: " + friesPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** RESTAURANT MENÜ FİYATLARI **** ");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int PizzaCount;
            int lemonedeCount;
            int friesCount;

            int totalhamburgerPrice = 0;
            int totallemonedePrice = 0;
            int totalPizzaPrice = 0;
            int totalcokPrice = 0;
            int totalwaterPrice = 0;
            int totalfriesPrice = 0;
            

            


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            PizzaCount = 3;
            lemonedeCount = 3;
            friesCount = 3;

            totalhamburgerPrice = hamburgerCount * hamburgerPrice;
            totalcokPrice += cokeCount * cokPrice;
            totalwaterPrice += waterCount * waterPrice;
            totallemonedePrice += lemonedeCount * lemonedePrice;
            totalfriesPrice += friesCount * friesPrice;
            totalPizzaPrice += PizzaCount * PizzaPrice;




            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı:" + totalhamburgerPrice + " TL ");
            Console.WriteLine("Pizza Tutarı:" + totalPizzaPrice + " TL ");
            Console.WriteLine("fries Tutarı:" + totalfriesPrice + " TL ");
            Console.WriteLine("limonata Tutarı:" + totallemonedePrice + " TL ");
            Console.WriteLine("Su Tutarı:" + totalwaterPrice + " TL ");
            Console.WriteLine("Kola Tutarı:" + totalcokPrice + " TL ");

            Console.WriteLine();

            int totalPrice = totalfriesPrice + totalcokPrice + totalwaterPrice + totallemonedePrice + totalhamburgerPrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL ");



            #endregion

            Console.Read();



        }
    }
}





