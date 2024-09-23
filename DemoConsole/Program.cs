using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DemoConsole
{
    class Program
    {
        //edit code here.....
        //viết ở đây
        public static void NhanVien(string hoten, int lcb, float hsl = 2f)
        {
            Console.WriteLine("Ho ten la {0}", hoten);
            Console.WriteLine("LCB la {0}", lcb);
            Console.WriteLine("HSL la {0}", hsl);
            Console.WriteLine("Thuc lanh la {0}", lcb * hsl);
        }
        //public static int TongMang(int a1, int a2, int a3, int a4, .... int a10)
        //{
        //    return a1 + a2 + a3 + ... + a10;
        //}

        public static int TongMang(params int[] a)
        {
            int s = 0;
            for(int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            bool KiemTraSoChan()
            {
                if (s % 2 == 0) return true;
                else return false;
            }
            return s;
        }
        static void Main(string[] args)
        {
            Array.Resize(ref a,7);
            List<int> b = new List<int>();
            ArrayList c = new ArrayList();
            int[] a = new int[5];
            a[6] = 10;
            Console.Write("{0}\t", a[6]);
            //int[] numbers = { 5, 7, 1, 9, 5, 2, 4, 3, 6, 2, 10 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //int mã = numbers.Max();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write("{0}\t", numbers[i]);
            //}

            //int tong = 0;
            //for (int i = 0; i < numbers.Length; i++) tong += numbers[i];

            //int sum = 0;
            //foreach (var number in numbers)
            //{
            //    if (number % 3 == 0) Console.WriteLine(number);
            //    break;
            //}


            //int max = numbers[0];
            //for (int i = 1; i < numbers.Length; i++) if (max < numbers[i]) max = numbers[i];
            //Console.WriteLine("So lon nhat trong mang la {0}", max);

            //int MAX = numbers.Max();
            //int MIN = numbers.Min();
            //double av = numbers.Average();
            //Console.WriteLine("So lon nhat trong mang la {0}", MAX);

            //while (true)
            //{
            //    Console.Write("Nhap so luong phan tu: ");
            //    int n = int.Parse(Console.ReadLine());

            //    int[] mangSoNguyen = new int[n]; // chay tu 0 -> n-1
            //                                     //nhap gia tri cho mang
            //    for (int i = 0; i < mangSoNguyen.Length; i++)
            //    {
            //        Console.Write("Gia tri phan tu {0} = ", i);
            //        mangSoNguyen[i] = int.Parse(Console.ReadLine());
            //    }

            //    //xu ly mang


            //    Console.WriteLine();
            //    Console.WriteLine("Gia tri mang vua nhap:");
            //    //xuat gia tri cho mang
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("{0}\t", mangSoNguyen[i]);
            //    }

            //    Console.WriteLine("Nhan y de thoat!");
            //    string stop = Console.ReadLine();
            //    if (stop == "y" && stop == "Y") break;
            //    //Console.Clear();
            //}

            Console.ReadKey();
        }
        //viết ở đây
    }
    //viết ở đây
}