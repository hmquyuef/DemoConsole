using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole
{
    //viết ở đây
    internal class Program
    {
        //viết ở đây
        static void Main(string[] args)
        {
            //Bai 1: Ctrl + K, Ctrl + C
            //Ctrl + K, Ctrl + U
            //int A = 9;
            //if (A % 2 == 0) Console.WriteLine("{0} la so chan", A);
            //else Console.WriteLine("{0} la so le", A);
            //Bai 2:

            //int B = 10;
            //string kq = "so chan";
            //if (B % 2 != 0) kq = "so le";

            //Console.WriteLine("{0} la {1}", B, kq);

            //int C = 10;
            //Console.WriteLine("{0} la {1}", C, C % 2 == 0 ? "so chan" : "so le");

            //int D = 11;
            //if(D % 2 == 0) Console.WriteLine("{0} la so chan", D);
            //if(D % 2 != 0) Console.WriteLine("{0} la so le", D);

            //string E = null;
            //string F = E ?? "DEMO"; //if loai 1
            //Console.WriteLine(F);
            //if(soCanh == 3) Console.WriteLine("Hinh tam giac");
            //else if(soCanh >= 4) Console.WriteLine("Hinh chu nhat");
            //else if(soCanh == 5) Console.WriteLine("Hinh chu nhat");
            //else if(soCanh == 6) Console.WriteLine("Hinh chu nhat");
            //else if(soCanh == 7) Console.WriteLine("Hinh chu nhat");
            //else if(soCanh == 8) Console.WriteLine("Hinh chu nhat");
            //else if(soCanh == 9) Console.WriteLine("Hinh chu nhat");
            //else if(soCanh == 10) Console.WriteLine("Hinh chu nhat");
            //else Console.WriteLine("ko hop le");

            //int soCanh = 4;
            //switch (soCanh)
            //{
            //    //if(soCanh == 3 || soCanh == 4 || soCanh == 5)
            //    case 3: 
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Hinh chu nhat");
            //        break;
            //    case 6:
            //        Console.WriteLine("Hinh chu nhat");
            //        break;
            //    default:
            //        Console.WriteLine("ko hop le");
            //        break;
            //}

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            //int s = 0;

            //for (int i = 1; i <= 100; i++)//1000 lan
            //{
            //    if (i % 2 != 0) s += i;
            //}
            //Console.WriteLine("Tong la: {0}", s);

            //for (int i = 2; i <= 1000; i += 2) // i = i + 1 // 500 lan
            //{
            //    s += i;
            //}
            //Console.WriteLine(s);

            //for (int i = 1; i <= 100; i++) // i = i + 1 // 500 lan
            //{
            //    for (int j = 1; j <= 100; j++) // i = i + 1 // 500 lan
            //    {
            //        for (int z = 1; z <= 100; z++) // i = i + 1 // 500 lan
            //        {
            //            Console.WriteLine("{0} x {1} x {2} = {3}", i, j, z, i * j * z);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}

            for (int j = 1; j <= 100; j++)
            {
                if (j % 2 != 0)
                {
                    continue;
                    Console.WriteLine(j);
                }
                Console.WriteLine(j);
            }

            //int i = 1;
            //while(i <= 100)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //    i++;
            //}


            Console.ReadKey();
        }
        //viết ở đây
    }
    //viết ở đây
}