using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quızApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // quiz uygulaması 

            Console.WriteLine("** SORULARI EKLE **");
            Console.Write("Soru adeti : ");
            int soruSayisi = Convert.ToInt32(Console.ReadLine());

            string[,] sorular = new string[soruSayisi, 6];

            for (int i = 0; i < soruSayisi; i++)
            {
                Console.Write("{0}. Soru girin : ", i + 1);
                sorular[i, 0] = Console.ReadLine();

                for (int j = 1; j < 6; j++)
                {

                    if (j == 5)
                    {
                        Console.Write(" doğru Cevap giriniz  : ");
                    }
                    else
                    {
                        Console.Write("Cevap {0} : ", j);
                    }
                    sorular[i, j] = Console.ReadLine();
                }
            }
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("*** SORULAR ***");
            Console.WriteLine();
            int dogruSayisi = 0, yalnisSayisi = 0;
            for (int i = 0; i < soruSayisi; i++)
            {
                Console.WriteLine("{0}. Soru : {1} ", i + 1, sorular[i, 0]);
                for (int j = 1; j < 5; j++)
                {
                    Console.WriteLine("cevap {0} :{1}", j, sorular[i, j]);

                }
                Console.Write("Cevabınız : ");
                string cevap = Console.ReadLine();

                if (cevap == sorular[i, 5])
                {
                    dogruSayisi++;
                }
                else
                {
                    yalnisSayisi++;
                }
            }
            Console.WriteLine("doğru sayısı : " + dogruSayisi);
            Console.WriteLine("yalnış sayısı : " + yalnisSayisi);

            Console.ReadLine();

        }

    }
}



