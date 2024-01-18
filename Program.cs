using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p1();
            //p2();
            //p3();
            //p4();
            //p5();
            //p6();
            //p7();
            //p8();
            //p9();
            //p10();
            //p11();
            //p12();
            //p13();
            //p14();
            //p15();
            //p16();
            p17();

        }
        static void p1() 
        {
            int n = int.Parse(Console.ReadLine());
            int par = 0;
            for (int i = 0; i < n; i++) 
            {
                int nr = int.Parse(Console.ReadLine());
                if(nr % 2 == 0)
                    par++;
            }
            Console.WriteLine(par);
        }

        static void p2()
        {
            int n = int.Parse(Console.ReadLine());
            int neg = 0;
            int zero = 0;
            int poz = 0;
            for (int i = 0; i < n; i++)
            {
                double nr = double.Parse(Console.ReadLine());
                if (nr < 0)
                    neg++;
                else if (nr == 0)
                    zero++;
                else
                    poz++;
            }
            Console.WriteLine($"numere negative:{neg}");
            Console.WriteLine($"numere egale cu zero:{zero}");
            Console.WriteLine($"numere pozitive:{poz}");
        }

        static void p3()
        {
            int n = int.Parse(Console.ReadLine());
            long sum = 0;
            long prod = 1;
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine($"suma: {sum}");
            Console.WriteLine($"produs: {prod}");
        }

        static void p4()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int poz = -1;

            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr == a)
                    poz = i;
            }
            Console.WriteLine(poz);
        }

        static void p5()
        {
            int n = int.Parse(Console.ReadLine());
            int egal = 0;
            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr == i)
                    egal++;
            }
            Console.WriteLine(egal);
        }

        static void p6()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int cresc = 1;
            int i = 1;
            while ( i < n && cresc == 1)
            {
                int b = int.Parse(Console.ReadLine());
                if (b < a)
                    cresc = 0;
                a = b;
                i++;
            }
            if (cresc == 1)
                Console.WriteLine("numerele sunt in ordine crescatoare");
            else
                Console.WriteLine("numerele nu sunt in ordine crescatoare");
        }

        static void p7()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 9999999;
            int max = -1;

            for (int i = 0; i < n; i++)
            {
                int nr = int.Parse(Console.ReadLine());
                if (nr < min)
                    min = nr;
                if (nr > max)
                    max = nr;
            }
            Console.WriteLine($"mica = {min}");
            Console.WriteLine($"mare = {max}");
        }

        static void p8()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int c;
            int ok = 0;

            while (n != 0)
            {
                c = a + b;
                b = a;
                a = c;
                if (ok == 0)
                {
                    b = 1;
                    ok = 1;
                }
                n--;
            }
            Console.WriteLine(a);
        }

        static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int cresc = 0;
            int decresc = 0;
            int i = 1;
            while (i < n)
            {
                int b = int.Parse(Console.ReadLine());
                if (b < a)
                    decresc++;
                else
                    cresc++;
                a = b;
                i++;
            }
            if ((n <= 2) || (decresc == 0 && cresc > 0) || (decresc > 0 && cresc == 0))
                    Console.WriteLine("este monotona");
            else
                    Console.WriteLine("nu este monotona");
        }

        static void p10()
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int max1 = 1;
            int max2 = 1;
            int i = 1;
            while (i < n)
            {
                int b = int.Parse(Console.ReadLine());
                if (b == a)
                    max1++;
                else
                {
                    max2 = max1;
                    max1 = 1;
                }
                a = b;
                i++;
            }
            Console.WriteLine(max2);
        }

        static void p11()
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double nr = int.Parse(Console.ReadLine());
                sum += 1 / nr;
            }
            Console.WriteLine(sum);
        }

        static void p12()
        {
            string n = Console.ReadLine();
            string[] separator = n.Split('0');
            int nr = 0;
            foreach (string secventa in separator)
            {
                if (!string.IsNullOrEmpty(secventa))
                    nr++;
            }
            Console.WriteLine(nr);
        }

        static void p17() 
        {
            int n = int.Parse(Console.ReadLine());
            int parStg = 0;
            int parDr = 0;
            int max = 0;
            int ok = 0;
            int i = 1;
            while (i <= n)
            {
                int nr = int.Parse(Console.ReadLine());
                int incuibare = 0;
                if (nr == 0)
                    parStg++;
                else
                    parDr++;
                i++;

                if (parStg > parDr)
                    incuibare = parStg - parDr;
                if (max < incuibare)
                    max = incuibare;

                if (parDr > parStg)
                {
                    ok = -1;
                }

            }
            if (ok == -1)
                Console.WriteLine("nu este corect");               //0 0 1 1 1 0
            else
                Console.WriteLine($"este corect si maximul de incubare este {max}");           //0 1 0 0 1 0 1 1 
        }
    }
}
