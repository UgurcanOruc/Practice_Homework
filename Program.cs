using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Uygulama_Ödevi_Operatörler_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bu program sizden girdiler isteyerek ilerleyen ve 5 sorudan oluşan bir ödev programıdır.\n\n");
            Console.ReadLine();
            
            //Soru 1
            //-----------------------------------------------------
            
            Console.WriteLine("Soru 1\n-----------------------------\n\nBu soruda sizden iki sayı isteyeceğiz ve toplamının farklarına bölümünden kalanını size göstereceğiz.\n");

            Console.WriteLine("İlk sayıyı giriniz.");
            double q1Sayı1 = double.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz.");
            double q1Sayı2 = double.Parse(Console.ReadLine());

            double q1Toplam = q1Sayı1 + q1Sayı2;
            double q1Fark = q1Sayı1 - q1Sayı2;

            Console.WriteLine("Girdiğiniz sayılarının toplamının farklarına bölümünden kalan = " + (q1Toplam % q1Fark).ToString());
            Console.ReadLine();
            
            Console.WriteLine("Bir tuşa basıp diğer soruya geçebilirsiniz.\n-----------------------------");
            Console.ReadLine();

            //Burada bitiyor.
            //-----------------------------------------------------


            //Soru 2
            //-----------------------------------------------------

            Console.WriteLine("Soru 2\n-----------------------------\n\nBu soruda sizlerden bir sayı isteyeceğiz ve o sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesini göstereceğiz.\n ");

            Console.WriteLine("Sayıyı giriniz.");
            int q2Sayı1 = int.Parse(Console.ReadLine());

            // Bu soruyu 3 farklı yoldan yapmak aklıma geldi, hepsini buraya yazacağım.

            int q2Islem1 = ( ( q2Sayı1 - 10 + 20) % 2 ) ^ 2;
            
            Console.WriteLine("Verdiğiniz sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi = " + q2Islem1.ToString());
            Console.ReadLine();

            /* 
              
            YA DA

            double q2Islem2 = Math.Pow((q2Sayı1 - 10 + 20) % 2, 2);
            Console.WriteLine("Verdiğiniz sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi " + q2Islem2.ToString());
            
            YA DA

            Console.WriteLine("Verdiğiniz sayının 10 eksiğinin 20 fazlasının 2'ye bölümünden kalanın karesi " + (((q2Sayı1 - 10 + 20) % 2) ^ 2).ToString());
            Console.ReadLine();

            */

            Console.WriteLine("Bir tuşa basıp diğer soruya geçebilirsiniz.\n-----------------------------");
            Console.ReadLine();

            //Burada bitiyor.
            //-----------------------------------------------------

            //Soru 3
            //-----------------------------------------------------

            Console.WriteLine("Soru 3\n-----------------------------\n\nBu soruda sizden iki sayı isteyeceğiz ve karelerinin toplamı ile karelerinin farkının toplamını göstereceğiz.\n");

            Console.WriteLine("İlk sayıyı giriniz.");
            int q3Sayı1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz.");
            int q3Sayı2 = int.Parse(Console.ReadLine());

            int q3KareToplamı = q3Sayı1 ^ 2 + q3Sayı2 ^ 2;
            int q3KareFarkı = q3Sayı1 ^ 2 - q3Sayı2 ^ 2;
            int q3Islem = q3KareToplamı + q3KareFarkı;

            Console.WriteLine("Girilen iki sayının karelerinin toplamı ile karelerinin farkının toplamı = " + q3Islem.ToString());
            Console.ReadLine();

            Console.WriteLine("Bir tuşa basıp diğer soruya geçebilirsiniz.\n-----------------------------");
            Console.ReadLine();

            //Burada bitiyor.
            //-----------------------------------------------------

            //Soru 4
            //-----------------------------------------------------

            Console.WriteLine("Soru 4\n-----------------------------\n\nBu soruda sizden vize ve final notlarınızı isteyeceğiz ve ortalamalarını alıp size notunuzu göstereceğiz.\n");

            Console.WriteLine("Lütfen vize notunuzu giriniz.");
            double q4VizeNotu = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen final notunuzu giriniz.");
            double q4FinalNotu = double.Parse(Console.ReadLine());

            double ortalamaHesaplama = q4VizeNotu * 0.30 + q4FinalNotu * 0.70;

            Console.WriteLine("Vize notunuzun %30'undan ve final notunuzun %70'inden gelen not ortalamanız = " + ortalamaHesaplama.ToString());
            Console.ReadLine();

            /* YA DA

            Console.WriteLine("Vize notunuzun %30'undan ve final notunuzun %70'inden gelen not ortalamanız " + (q4VizeNotu * 0.30 + q4FinalNotu * 0.70).ToString());
            Console.ReadLine();

            */

            Console.WriteLine("Bir tuşa basıp diğer soruya geçebilirsiniz.\n-----------------------------");
            Console.ReadLine();

            //Burada bitiyor.
            //-----------------------------------------------------

            //Soru 5
            //-----------------------------------------------------

            Console.WriteLine("Soru 5\n-----------------------------\n\nBu soruda sizden isim ve soyisminizi isteyeceğiz ve adınıza ait mail adresinizi oluşturacağız, lütfen iki ya da daha fazla isminiz varsa dahi bir tanesini giriniz.\n");

            Console.WriteLine("Lütfen adınızı giriniz.");
            string q5kullanıcıIsmi = Console.ReadLine();

            Console.WriteLine("Lütfen soyadınızı giriniz.");
            string q5kullanıcıSoyismi = Console.ReadLine();

            Console.WriteLine("Mail adresiniz : " + q5kullanıcıIsmi + "." + q5kullanıcıSoyismi + "@hotmail.com");
            Console.ReadLine();

            Console.WriteLine("Soru 5 burada bitti.\n-----------------------------");
            Console.ReadLine();

            //Burada bitiyor.
            //-----------------------------------------------------
           
            Console.WriteLine("Ödev burada bitmiştir.");
            Console.ReadLine();

        }
    }
}
