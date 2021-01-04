using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmettuyluoyun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seviye Seçiniz:\n1-Kolay\n2-Orta\n3-Zor");
            byte seviye = byte.Parse(Console.ReadLine());
            byte haksayisi = 0;
            switch (seviye)
            {
                case 1:
                    Random rnd = new Random();
                    int rastgelesayi = rnd.Next(1, 10);
                    Console.WriteLine("Seviye 1'e Hoşgeldiniz Kolay Etabımız 1 ile 10 Arasında Sayı Giriniz ama 6 Hakkınız Bulunmaktadır ! ");
                    int hak = 6;
                Basadon:
                    Console.Write("Bir Tahminde Bulununuz:");
                    int tahmin = Convert.ToInt32(Console.ReadLine());
                    if (tahmin == rastgelesayi)
                    {
                        Console.Write("Tebrikler... puan:{0}", hak * 10);
                    }
                    else if (tahmin < rastgelesayi)
                    {
                        hak--;
                        if (hak == 0)
                        {
                            Console.Write("Kaybettiniz! Hakkınız Kalmadı. Dogru cevap = :{0}", rastgelesayi);
                        }
                        else
                        {
                            Console.Write("Tahmininizi Büyütünüz!");
                            goto Basadon;
                        }
                    }
                    else if (tahmin > rastgelesayi)
                    {
                        hak--;
                        if (hak == 0)
                        {
                            Console.Write("Kaybettiniz! Hakkınız Kalmadı. Dogru cevap = :{0}", rastgelesayi);
                        }
                        else
                        {
                            Console.Write("Tahiminizi Küçültünüz");
                            goto Basadon;
                        }
                    }
                    break;
                case 2:
                    Random rnd1 = new Random();
                    int rastgelesayi1 = rnd1.Next(1, 25);
                    Console.WriteLine("Seviye 2'ye Hoşgeldiniz Orta Etabımız 1 ile 25 Arasında Sayı Giriniz ama  4 Hakkınız Bulunmaktadır ! ");
                    int hak1 = 4;
                Basadon1:
                    Console.Write("Bir Tahminde Bulununuz:");
                    int tahmin1 = Convert.ToInt32(Console.ReadLine());
                    if (tahmin1 == rastgelesayi1)
                    {
                        Console.Write("Tebrikler... puan:{0}", hak1 * 15);
                    }
                    else if (tahmin1 < rastgelesayi1)
                    {
                        hak1--;
                        if (hak1 == 0)
                        {
                            Console.Write("Kaybettiniz! Hakkınız Kalmadı. Dogru cevap = :{0}", rastgelesayi1);
                        }
                        else
                        {
                            Console.Write("Tahmininizi Büyütünüz!");
                            goto Basadon1;
                        }
                    }
                    else if (tahmin1 > rastgelesayi1)
                    {
                        hak1--;
                        if (hak1 == 0)
                        {
                            Console.Write("Kaybettiniz! Hakkınız Kalmadı. Dogru cevap = :{0}", rastgelesayi1);
                        }
                        else
                        {
                            Console.Write("Tahiminizi Küçültünüz");
                            goto Basadon1;
                        }
                    }
                    break;
                case 3:
                    Random rnd2 = new Random();
                    int rastgelesayi2 = rnd2.Next(1, 25);
                    Console.WriteLine("Seviye 3'e Hoşgeldiniz Zor Etabımız 1 ile 50 Arasında Sayı Giriniz ama  2 Hakkınız Bulunmaktadır ! ");
                    int hak2 = 2;
                Basadon2:
                    Console.Write("Bir Tahminde Bulununuz:");
                    int tahmin2 = Convert.ToInt32(Console.ReadLine());
                    if (tahmin2 == rastgelesayi2)
                    {
                        Console.Write("Tebrikler... puan:{0}", hak2 * 20);
                    }
                    else if (tahmin2 < rastgelesayi2)
                    {
                        hak2--;
                        if (hak2 == 0)
                        {
                            Console.Write("Kaybettiniz! Hakkınız Kalmadı. Dogru cevap = :{0}", rastgelesayi2);
                        }
                        else
                        {
                            Console.Write("Tahmininizi Büyütünüz!");
                            goto Basadon2;
                        }
                    }
                    else if (tahmin2 > rastgelesayi2)
                    {
                        hak2--;
                        if (hak2 == 0)
                        {
                            Console.Write("Kaybettiniz! Hakkınız Kalmadı. Dogru cevap = :{0}", rastgelesayi2);
                        }
                        else
                        {
                            Console.Write("Tahiminizi Küçültünüz");
                            goto Basadon2;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("1-3 arasında bir sayı giriniz:");
                    break;
            }
            Console.ReadKey();
        }
    }
}
