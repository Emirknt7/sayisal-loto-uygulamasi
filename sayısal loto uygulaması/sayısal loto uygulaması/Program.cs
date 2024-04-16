using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace sayısal_loto_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {                                    // 1 den 10 kadar loto uygulaması
            while (true)
            {
                Console.WriteLine("sayısal loto uygulamasına hoşgeldiniz ");
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("\nçekilen toplar 1 den 10 kadardır");
                System.Threading.Thread.Sleep(3000);// 3sayineye geç okuma kodu 
                int puan = 0;
                int[] dizi = new int[6];
                Random sanslıkelimeler = new Random();
                int[] tutlansayi = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    dizi[i ] = sanslıkelimeler.Next(1, 10);
                }
                Console.WriteLine("\nşanslı toplar çekildi sırada senin tahminlerin var"); 
                System.Threading.Thread.Sleep(3000);
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine("{0}. tahmini girin", (i + 1));
                    tutlansayi[i] = Convert.ToInt32(Console.ReadLine());
                    if (tutlansayi[i] == dizi[i])
                    {
                        Console.WriteLine("tebrikler {0}. tahminiz /DOĞRU\\\n ", (i + 1) );
                        puan++;
                        System.Threading.Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("malesef  {0}. tahminiz /YANLIŞ\\ ", (i + 1) );
                        Console.WriteLine("{0}. şanslı sayı {1}\n ", (i + 1), dizi[i]);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("************************kazandığınız puan =  $$  {0} $$  ****************************** ", puan);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("şanslı sayılar bunlardı");
                for (int i = 0; i < 6; i++)
                {
                    Console.Write( dizi[i]);
                }
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("\n\n bizi tercih ettiğiniz için teşekür ederiz \n"+" tekrar deneyiniz\n\n\n\n ");
                Console.ReadKey();
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
