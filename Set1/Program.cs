using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Set1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti numarul problemei: ");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        P1();
                        break;
                    }
                case "2":
                    {
                        P2();
                        break;
                    }
                case "3":
                    {
                        P3();
                        break;
                    }
                case "4":
                    {
                        P4();
                        break;
                    }
                case "5":
                    {
                        P5();
                        break;
                    }
                case "6":
                    {
                        P6();
                        break;
                    }
                case "7":
                    {
                        P7();
                        break;
                    }
                case "8":
                    {
                        P8();
                        break;
                    }
                case "9":
                    {
                        P9();
                        break;
                    }
                case "10":
                    {
                        P10();
                        break;
                    }
                case "11":
                    {
                        P11();
                        break;
                    }
                case "12":
                    {
                        P12();
                        break;
                    }
                case "13":
                    {
                        P13();
                        break;
                    }
                case "14":
                    {
                        P14();
                        break;
                    }
                case "15":
                    {
                        P15();
                        break;
                    }
                case "16":
                    {
                        P16();
                        break;
                    }
                case "17":
                    {
                        P17();
                        break;
                    }
                case "18":
                    {
                        P18();
                        break;
                    }
                case "19":
                    {
                        P19();
                        break;
                    }
                case "20":
                    {
                        P20();
                        break;
                    }
                case "21":
                    {
                        P21();
                        break;
                    }
            }
        }

        private static void P1()
        {
            Console.WriteLine("\nProblema 1");
            Console.WriteLine("Introduceti numerele a si b, cu spatiu intre ele.\n( ax + b = 0 )");
            double a, b, x;
            string[] t = Console.ReadLine().Split(' ');
            a = double.Parse(t[0]);
            b = double.Parse(t[1]);
            x = -b / a;
            Console.WriteLine($"x = {x}");
            Console.ReadLine();
        }

        private static void P2()
        {
            Console.WriteLine("\nProblema 2");
            Console.WriteLine("Introduceti numerele a, b si c, cu spatiu intre ele.\n( ax^2 + bx + c = 0 )");
            double a, b, c, x1 = 0, x2 = 0, d;
            string[] t = Console.ReadLine().Split(' ');
            a = double.Parse(t[0]);
            b = double.Parse(t[1]);
            c = double.Parse(t[2]);
            d = (b * b) - 4 * (a * c);
            if (d > 0)
            {
                x1 = ((-b + Math.Sqrt(d)) / 2 * a);
                x2 = ((-b - Math.Sqrt(d)) / 2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (d == 0)
            {
                x1 = -b / 2 * a;
                x2 = x1;
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (d < 0)
            {
                Console.WriteLine("Ecuatia nu are solutii reale.");
            }
            Console.ReadKey();
        }

        private static void P3()
        {
            Console.WriteLine("\nProblema 3");
            Console.WriteLine("Introduceti numerele n si k, cu spatiu intre ele.\n( pentru a verifica daca n se divide cu k )");
            int n, k;
            string[] t = Console.ReadLine().Split(' ');
            n = int.Parse(t[0]);
            k = int.Parse(t[1]);
            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else
            {
                Console.WriteLine($"{n} nu se divide cu {k}");
            }
            Console.ReadKey();
        }

        private static void P4()
        {
            Console.WriteLine("\nProblema 4");
            Console.WriteLine("Introduceti anul:");
            int y;
            y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
            {
                if (y % 400 == 0)
                {
                    Console.WriteLine($"{y} e an bisect");
                }
                else if (y % 100 == 0)
                {
                    Console.WriteLine($"{y} nu e an bisect");
                }
                else
                {
                    Console.WriteLine($"{y} e an bisect");
                }
            }
            else
            {
                Console.WriteLine($"{y} nu e an bisect");
            }
            Console.ReadKey();
        }

        private static void P5()
        {
            Console.WriteLine("\nProblema 5");
            Console.WriteLine("Introduceti numerele n si k, cu spatiu intre ele.\n( pentru a extrage a k-a cifra din n )");
            int n, k, i = 0;
            string[] t = Console.ReadLine().Split(' ');
            n = int.Parse(t[0]);
            k = int.Parse(t[1]);
            while (n > 0)
            {
                n = n / 10;
                i++;
                if (i == (k - 1))
                {
                    Console.WriteLine(n % 10);
                }
            }
            Console.ReadKey();
        }

        private static void P6()
        {
            Console.WriteLine("\nProblema 6");
            Console.WriteLine("Introduceti numerele a, b si c, cu spatiu intre ele.\n( pentru a verifica daca aceste pot fi laturile unui triunghi )");
            int a, b, c;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Pot forma un triunghi!");
            }
            else
            {
                Console.WriteLine("Nu pot forma un triunghi!");
            }
            Console.ReadKey();
        }

        private static void P7()
        {
            Console.WriteLine("\nProblema 7");
            Console.WriteLine("Introduceti numerele a si b, cu spatiu intre ele.");
            int a, b, fa = 0;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            Console.WriteLine($"Before swap\na = {a} b = {b}");
            fa = a;
            a = b;
            b = fa;
            Console.WriteLine($"\nAfter swap\na = {a} b = {b}");
            Console.ReadLine();
        }

        private static void P8()
        {
            Console.WriteLine("\nProblema 8");
            Console.WriteLine("Introduceti numerele a si b, cu spatiu intre ele.");
            int a, b;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            Console.WriteLine($"Before swap\na = {a} b = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swap\na = {a} b = {b}");
            Console.ReadKey();
        }

        private static void P9()
        {
            Console.WriteLine("\nProblema 9");
            Console.WriteLine("Introduceti numarul n.\n( pentru a afla toti divizorii acestuia )");
            int n = int.Parse(Console.ReadLine());
            int fn = n;
            Console.WriteLine(n);
            for (int i = n; i > 1; i--)
            {
                n = n - 1;
                if (fn % n == 0)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadKey();
        }

        private static void P10()
        {
            Console.WriteLine("\nProblema 10");
            Console.WriteLine("Introduceti numarul n.\n( pentru a verifica daca acesta este prim )");
            int n = int.Parse(Console.ReadLine());
            int fn = n;
            int p = 0;
            for (int i = n; i > 1; i--)
            {
                n = n - 1;
                if (fn % n == 0)
                {
                    p++;
                }
            }
            if (p > 2)
            {
                Console.WriteLine($"{fn} nu este prim");
            }
            else
            {
                Console.WriteLine($"{fn} este prim");
            }
            Console.ReadKey();
        }

        private static void P11()
        {
            Console.WriteLine("\nProblema 11");
            Console.WriteLine("Introduceti numarul n.");
            int n = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            while (n > 0)
            {
                reminder = n % 10;
                reverse = (reverse * 10) + reminder;
                n = n / 10;
            }
            Console.WriteLine(reverse);
            Console.ReadKey();
        }

        private static void P12()
        {
            Console.WriteLine("\nProblema 12");
            Console.WriteLine("Introduceti numerele n, a si b, cu spatiu intre ele.\n( pentru a afla cate numere integi divizibile cu n se afla in intervalul [a, b] )");
            //a,b = numerele din interval
            //m = totalul de numere divizibile cu n din intervalul [a, b]
            int a, b, n, ib, m = 0;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            n = int.Parse(Console.ReadLine());
            //ib = initial b (valoarea initiala a lui b)
            ib = b;

            if (b % n == 0)
            {
                m++;
                Console.WriteLine(b);
            }
            for (int i = b; i > a; i--)
            {
                b = b - 1;

                if (b % n == 0)
                {
                    m++;
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine($"Sunt {m} numere divizibile cu {n} in intervalul [{a}, {ib}].");
            Console.ReadKey();
        }

        private static void P13()
        {
            Console.WriteLine("\nProblema 13");
            Console.WriteLine("Introduceti numerele y1 si y2, cu spatiu intre ele.\n( pentru a afla cati ani bisecti sunt intre y1 si y2");
            int y1, y2, iy2, m = 0;
            string[] t = Console.ReadLine().Split(' ');
            y1 = int.Parse(t[0]);
            y2 = int.Parse(t[1]);
            iy2 = y2;
            if (y2 % 4 == 0)
            {
                if (y2 % 100 != 0)
                {
                    m++;
                    Console.WriteLine(y2);
                }
                else if (y2 % 400 == 0)
                {
                    m++;
                    Console.WriteLine(y2);
                }
            }
            for (int i = y2; i > y1; i--)
            {
                y2 = y2 - 1;
                if (y2 % 4 == 0)
                {
                    if (y2 % 100 != 0)
                    {
                        m++;
                        Console.WriteLine(y2);
                    }
                    else if (y2 % 400 == 0)
                    {
                        m++;
                        Console.WriteLine(y2);
                    }
                }
            }
            Console.WriteLine($"Sunt {m} ani bisecti intre anii {y1} si {iy2}.");
            Console.ReadLine();
        }

        private static void P14()
        {
            Console.WriteLine("\nProblema 14");
            Console.WriteLine("Introduceti numarul n.\n( pentru a afla daca acesta este palindrom )");
            int n = int.Parse(Console.ReadLine());
            int reminder, reverse = 0;
            int fn = n;
            while (n > 0)
            {
                reminder = n % 10;
                reverse = (reverse * 10) + reminder;
                n = n / 10;
            }
            if (reverse == fn)
            {
                Console.WriteLine($"{fn} este un numar palindrom.");
            }
            else
            {
                Console.WriteLine($"{fn} nu este un numar palindrom.");
            }
            Console.ReadKey();
        }

        private static void P15()
        {
            Console.WriteLine("\nProblema 15");
            Console.WriteLine("Introduceti numerele a, b si c, cu spatiu intre ele.\n( pentru a le ordona crescator )");
            int a, b, c;
            string[] g = Console.ReadLine().Split(' ');
            a = int.Parse(g[0]);
            b = int.Parse(g[1]);
            c = int.Parse(g[2]);
            int[] t = { a, b, c };
            Array.Sort(t);
            foreach (int i in t)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }

        private static void P16()
        {
            Console.WriteLine("\nProblema 16");
            Console.WriteLine("Introduceti numerele a, b, c, d si e, cu spatiu intre ele.\n( pentru a le ordona crescator )");
            int a, b, c, d, e, k;
            string[] t = Console.ReadLine().Split(' ');
            a = int.Parse(t[0]);
            b = int.Parse(t[1]);
            c = int.Parse(t[2]);
            d = int.Parse(t[3]);
            e = int.Parse(t[4]);
            if (a > b) { k = a; a = b; b = k; }
            if (a > c) { k = a; a = c; c = k; }
            if (a > d) { k = a; a = d; d = k; }
            if (a > e) { k = a; a = e; e = k; }

            if (b > c) { k = b; b = c; c = k; }
            if (b > d) { k = b; b = d; d = k; }
            if (b > e) { k = b; b = e; e = k; }

            if (c > d) { k = c; c = d; d = k; }
            if (c > e) { k = c; c = e; e = k; }

            if (d > e) { k = d; d = e; e = k; }
            Console.WriteLine($"{a} {b} {c} {d} {e}");
            Console.ReadKey();
        }

        private static void P17()
        {
            Console.WriteLine("\nProblema 17");
            Console.WriteLine("Introduceti numerele a si b, cu spatiu intre ele.");
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int m = int.Parse(t[1]);
            int cn, cm;
            cn = n;
            cm = m;
            while (m != 0)
            {
                int r = n % m;
                n = m;
                m = r;
            }
            Console.WriteLine($"Cel mai mare divizor comun este {n}");
            n = cn;
            m = cm;
            while (m != n)
            {
                if (n < m)
                    n = n + cn;
                if (m > n)
                    m = m + cm;
            }
            Console.WriteLine($"Cel mai mic multiplu comun este {n}");
        }

        private static void P18()
        {
            Console.WriteLine("\nProblema 18");
            Console.WriteLine("Introduceti numarul n.");
            int n = int.Parse(Console.ReadLine());
            int d = 2;
            int p;
            while (n > 1)
            {

                p = 0;
                while (n % d == 0)
                {
                    ++p;
                    n /= d;
                }
                if (p != 0)
                    Console.Write($"{d}^{p} x ");
                ++d;
                if (n > 1 && d * d > n)
                {
                    d = n;
                }
            }
        }

        private static void P19()
        {
            Console.WriteLine("\nProblema 19");

        }
        private static void P20()
        {
            Console.WriteLine("\nProblema 20");
        }

        private static void P21()
        {
            Console.WriteLine("\nProblema 21");
            for (int j = 0; j < 999; j++)
            {
                Random rnd = new Random();
                int x = rnd.Next(1, 1024);
                Console.WriteLine("Ghiceste un numar intre 1 si 1024.");
                for (int i = 0; i < 1024; i++)
                {
                    int r = int.Parse(Console.ReadLine());
                    if (r == x)
                    {
                        Console.WriteLine("\n!! Ai ghicit !!");
                        Console.WriteLine($"Incercari: {i}\n------------------\n");
                        Console.WriteLine("Doresti sa joci din nou?");
                        string rsp = Console.ReadLine();
                        if (rsp == "DA" || rsp == "da" || rsp == "Da" || rsp == "dA")
                        {
                            Console.Write("\n");
                            break;
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }
                    }
                    else if (r > x) { Console.WriteLine("<< Mai putin >>"); }
                    else if (r < x) { Console.WriteLine("<< Mai mult >>"); }
                }
                Console.ReadKey();
            }


        }
    }
}

