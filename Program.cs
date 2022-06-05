using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Media;


namespace ralos
{
    class Program


    {
        static void Main(string[] args)
        {//kullanıcının girişi
            string user, sifre;
            login:
            Console.Write("Kullanıcı adını giriniz: ");
            user = Console.ReadLine();
            Console.Write("Kullanıcı şifresini giriniz: ");
            sifre = Console.ReadLine();
            if (user == "user" && sifre == "asdf")
            {
                Console.WriteLine("Giriş yapılıyor, lütfen bekleyiniz...");
                Console.Clear();
                afterlogin();
            }
            else
            {
                Console.WriteLine("Kullanıcı girişi başarılı değildir. ");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("");
                Console.Clear();
                goto login;
            }
            Console.ReadKey();
        }
        static void afterlogin()
        {

            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("RalOS'a hoşgeldin, lütfen bir komut seç");
            komt:
            Console.Write("KOM: ");
            string komut = Console.ReadLine();

            if (komut == "help")
            {
                Console.WriteLine("UYARI: BÜTÜN KOMUTLAR KÜÇÜK HARFLERLE YAZILMALIDIR");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("about: Hakkında kısmı.");
                Console.WriteLine("exit: Uygulamadan çıkar.");
                Console.WriteLine("help: Yardım sayfasını açar.");
                Console.WriteLine("clear: Tüm penceredeki yazıları siler.");
                goto komt;
            } // yardım komutu
            if (komut == "about")
            {
                Console.WriteLine();
                Console.WriteLine("██████╗░░█████╗░██╗░░░░░░█████╗░░██████╗");
                Console.WriteLine("██╔══██╗██╔══██╗██║░░░░░██╔══██╗██╔════╝");
                Console.WriteLine("██████╔╝███████║██║░░░░░██║░░██║╚█████╗░");
                Console.WriteLine("██╔══██╗██╔══██║██║░░░░░██║░░██║░╚═══██╗");
                Console.WriteLine("██║░░██║██║░░██║███████╗╚█████╔╝██████╔╝");
                Console.WriteLine();
                Console.WriteLine("RALOS NEDİR");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("RalOs, 0.2 sürümünde olup Windows içinde çalışan ve MS-DOS tarzı sunan deneysel bir uygulamadır.");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Bu uygulamanın amacı sadece C# dilini öğrenmektir. Açık kaynaklıdır.");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Kaynak Kodları:[sonra yüklenecektir]");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Herhangi bir iletişim adresimiz yok maalesef.");
                goto komt;
            } // hakkında kısmı
            if (komut == "exit") // çıkış
            if (komut == "clear")
            {
                Console.Clear();
                goto komt;


            } //ekran temizleme
            if (komut == "nothing")
            {
                Console.WriteLine("hiçbirşey olmadı...");
                goto komt;


            } // komut şablonu (üşengecim)

        }
    }
}

