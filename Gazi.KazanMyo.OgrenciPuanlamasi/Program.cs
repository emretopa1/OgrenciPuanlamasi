using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.KazanMyo.OgrenciPuanlamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç ogrenci girmek istiyorsunuz?");
            byte mevcut = byte.Parse(Console.ReadLine());

            string[,] ogrenciler = new string[mevcut + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyadi";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Puan";
            ogrenciler[0, 5] = "Harf";

            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                int vize, final, ort;

                Console.WriteLine("Adinizi Girin:");
                ogrenciler[i, 0] = Console.ReadLine();

                Console.WriteLine("Soyadini Girin:");
                ogrenciler[i, 1] = Console.ReadLine();

                Console.Write("Vize:");
                ogrenciler[i, 2] = Console.ReadLine();
                vize = Convert.ToInt32(Console.ReadLine());

                Console.Write("Final:");
                ogrenciler[i, 3] = Console.ReadLine();
                final = Convert.ToInt32(Console.ReadLine());

                ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
                Console.WriteLine("{0}", ort);
                ogrenciler[i, 4] = Console.ReadLine();

                if (ort >= 90 && ort <= 100)
                {
                    Console.WriteLine("AA");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 85 && ort <= 89)
                {
                    Console.WriteLine("BA");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 80 && ort <= 84)
                {
                    Console.WriteLine("BB");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 70 && ort <= 79)
                {
                    Console.WriteLine("CB");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 60 && ort <= 69)
                {
                    Console.WriteLine("CC");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 55 && ort <= 59)
                {
                    Console.WriteLine("DC");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 50 && ort <= 54)
                {
                    Console.WriteLine("DD");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 40 && ort <= 49)
                {
                    Console.WriteLine("FD");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else if (ort >= 0 && ort <= 39)
                {
                    Console.WriteLine("FF");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Hesaplanamadi");
                    ogrenciler[i, 5] = Console.ReadLine();
                }
            }
            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }
                Console.WriteLine();

            }
        }    
    }
}
