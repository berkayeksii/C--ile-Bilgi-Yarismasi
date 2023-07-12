using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgi_yarışması
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz.");
            Console.Title = "Bilgi Yarışması Programı";
            string ad, soyad;
            Console.WriteLine("İsminizi Giriniz");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soy isim Giriniz");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Başlamaya Hazırsanız Lütfen 'Enter' Tuşuna Tıklayın");
            Console.WriteLine("Cevapları BÜYÜK HARFLERLE Cevaplandırmanız Gerekmektedir.");
            Console.WriteLine("Her Seçtiğiniz Kodlama'dan Sonra 'Enter' Tuşuna Basmayı Unutmayınız.");
            Console.WriteLine("Oyunda Kazandığınız para Gerçek Değildir Eğlence Amaçlı Gösterilmektedir.");
            Console.ReadLine();

            int dogru, yanlıs, para;
            dogru = 0;
            yanlıs = 0;
            para = 0;
            string s1;
            Console.WriteLine("Soru -1 = Türkiye’nin en fazla yağış alan ili hangisidir?  Şıkları Görmek İçin 'ENTER' Tıklayın");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine("A)Ankara\nB)Artvin\nC)Trabzon\nD)Rize\nE)Samsun");
            c1=Console.ReadLine();
            if (c1 == "D")
            {
                dogru = dogru + 1;
                para = para + 100;
                Console.WriteLine("Tebrikler,Yanıtınız Doğru,Cevap Etmek İçin 'ENTER' Tuşuna basınız.");

            }
            else
            {
                yanlıs = yanlıs + 1;
                Console.WriteLine("Üzgünüm,Yanıtınız Yanlış,'ENTER' Tuşuna Basınız.");
                Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            string s2;
            Console.WriteLine("Çanakkale Savaşı sırasında 215 kg’lık mermiyi tek başına kaldıran Türk askeri kimdir?");
            s2 = Convert.ToString(Console.ReadLine());
            string c2;
            Console.WriteLine("A)Seyit Onbaşı\nB)Recep Yüzbaşı\nC)Ali Binbaşı\nD)İsmet Yüzbaşı\nE)Ercan Onbaşı");
            c2 = Console.ReadLine();
            if (c2=="A")
            {
                dogru = dogru + 1;
                para = para + 200;
                Console.WriteLine("Tebrikler,Yanıtınız Doğru,Cevap Etmek İçin 'ENTER' Tuşuna basınız.");
                Console.ReadLine();
       }
            else
            {
                yanlıs = yanlıs + 1;
                Console.WriteLine("Üzgünüm,Yanıtınız Yanlış,'ENTER' Tuşuna Basınız.");
                Console.ReadLine();
            }
            string s3;
            Console.WriteLine("Gezilerini ‘Seyahatname’ adlı eserde toplayan Türk gezgin kimdir?");
            s2 = Convert.ToString(Console.ReadLine());
            string c3;
            Console.WriteLine("A)Aşık Veysel \nB)Evliye Çelebi\nC)Mehmet Akif Ersoy\nD)Katip Çelebi\nE)Kaşgarlı Mahmut");
            c2 = Console.ReadLine();
            if (c2 == "B")
            {
                dogru = dogru + 1;
                para = para + 200;
                Console.WriteLine("Tebrikler,Yanıtınız Doğru,Cevap Etmek İçin 'ENTER' Tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs = yanlıs + 1;
                Console.WriteLine("Üzgünüm,Yanıtınız Yanlış,'ENTER' Tuşuna Basınız.");
                Console.ReadLine();
            }
            string s4;
            Console.WriteLine("Osmanlı Devletinin kurucusu olan Osmanlı ailesi hangi Türk boyuna mensuptur?");
            s2 = Convert.ToString(Console.ReadLine());
            string c4;
            Console.WriteLine("A)Kayı \nB)Bozok\nC)Osmanoğulları\nD)II.Mehmed\nE)Kanuni");
            c2 = Console.ReadLine();
            if (c2 == "A")
            {
                dogru = dogru + 1;
                para = para + 200;
                Console.WriteLine("Tebrikler,Yanıtınız Doğru,Cevap Etmek İçin 'ENTER' Tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs = yanlıs + 1;
                Console.WriteLine("Üzgünüm,Yanıtınız Yanlış,'ENTER' Tuşuna Basınız.");
                Console.ReadLine();
            }
            string s5;
            Console.WriteLine("Pirinç hangi ürünün kabuğunun soyulması ile elde edilir?");
            s2 = Convert.ToString(Console.ReadLine());
            string c5;
            Console.WriteLine("A)Yulaf \nB)Çeltik\nC)Somon\nD)Toprak\nE)Mercimek");
            c2 = Console.ReadLine();
            if (c2 == "B")
            {
                dogru = dogru + 1;
                para = para + 200;
                Console.WriteLine("Tebrikler,Yanıtınız Doğru,Cevap Etmek İçin 'ENTER' Tuşuna basınız.");
                Console.ReadLine();
            }
            else
            {
                yanlıs = yanlıs + 1;
                Console.WriteLine("Üzgünüm,Yanıtınız Yanlış,'ENTER' Tuşuna Basınız.");
                Console.ReadLine();
            }
            Console.WriteLine("Bilgi Yarışmasının Sonuna Geldiniz Sayın :" + ad + " " + soyad);
            Console.WriteLine("Adınız : " + ad);
            Console.WriteLine("Soy isminiz :" + soyad);
            Console.WriteLine("Doğru Sayısı : " + dogru);
            Console.WriteLine("Yanlış Sayısı : " + yanlıs);
            Console.WriteLine("Toplam Kazandığınız Para : " + para);

            Console.Read();
        }
    }
}
