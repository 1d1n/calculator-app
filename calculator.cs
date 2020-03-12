using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        class calculator
        {
            static void Main(string[] args)
            {
                int a;
                int b;
                int menu;
                Console.WriteLine("Pilih menu kalkulator:\n\n");
                Console.WriteLine("1. penjumlahan");
                Console.WriteLine("2. pengurangan");
                Console.WriteLine("3. perkalian");
                Console.WriteLine("4. pembagian\n");
                Console.WriteLine("input nomor menu [1..4] : ");
                menu = int.Parse(Console.ReadLine());
                if (menu < 1)
                {
                    Console.WriteLine("Maaf Pilihan nggak ada\n");
                }
                else if (menu > 4)
                {
                    Console.WriteLine("Maaf Pilihan nggak ada\n");
                }
                else
                {
                    switch (menu)
                    {
                        case 1:
                            Console.WriteLine("Masukan angka pertama : ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukan angka kedua : ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Hasil penjumlahan {0} + {1} = {2}", a, b, penjumlahan(a, b));
                            break;
                        case 2:
                            Console.WriteLine("Masukan angka pertama : ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukan angka kedua : ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Hasil pengurangan {0} + {1} = {2}", a, b, pengurangan(a, b));
                            break;
                        case 3:
                            Console.WriteLine("Masukan angka pertama : ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukan angka kedua : ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Hasil perkalian {0} + {1} = {2}", a, b, perkalian(a, b));
                            break;
                        case 4:
                            Console.WriteLine("Masukan angka pertama : ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Masukan angka kedua : ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Hasil pembagian {0} + {1} = {2}", a, b, pembagian(a, b));
                            break;
                    }
                }


                Console.WriteLine("\ntekan sembarang key untuk keluar..");
                Console.ReadKey();

            }
            static int penjumlahan(int a, int b)
            {
                return a + b;
            }
            static int pengurangan(int a, int b)
            {
                return a - b;
            }
            static int perkalian(int a, int b)
            {
                return a * b;
            }
            static int pembagian(int a, int b)
            {
                return a / b;
            }
        }
    }
    }
