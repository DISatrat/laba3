using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Level_2
    {
        static void Main(string[] args)
        {
            N5();
            Console.ReadLine();


        }
        public static void N1()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            int[] mas = new int[l];
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    int element = Convert.ToInt32(splitString[i]);
                    mas[i] = element;
                    Console.Write(" " + mas[i]);
                }
                catch
                {

                }
            }
            Console.WriteLine(" ");

            int c = 0;
            int m = 1000;
            for (int i = 0; i < mas.Length + 1; i++)
            {
                try
                {
                    if (mas[i] > mas[i + 1] && c < m)
                    {
                        c = mas[i + 1];
                        m = c;
                    }
                }
                catch
                {

                }
            }
            Console.WriteLine(mas[c] * 2);

        }
        public static void N2()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            double[] mas = new double[l];
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            for (int i = 0; i < l; i++)
            {
                try
                {
                    double element = Convert.ToDouble(splitString[i]);
                    mas[i] = element;
                }
                catch { }
            }

            double k = -1000;
            double sum = 0;
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    if (k < mas[i])
                    {
                        k = mas[i];
                    }
                }
                catch { }
            }
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    while (mas[i] < k)
                    {
                        sum += mas[i];
                        break;
                    }
                    if (mas[i] >= k)
                    {
                        break;
                    }
                }
                catch { }
            }
            Console.WriteLine(sum);
        }
        public static void N3()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            int[] mas = new int[l];
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    int element = Convert.ToInt32(splitString[i]);
                    mas[i] = element;
                    Console.Write(" " + mas[i]);
                }
                catch
                {

                }
            }
            Console.WriteLine(" ");

            double k = 1000;

            for (int i = 0; i <= l; i++)
            {
                try
                {
                    if (k > mas[i])
                    {
                        k = mas[i];
                    }
                }
                catch { }
            }
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    while (mas[i] > k)
                    {
                        mas[i] *= 2;
                        Console.WriteLine(mas[i]);
                        break;
                    }
                    if (mas[i] <= k)
                    {
                        Console.WriteLine("нет таких чисел");
                        break;
                    }
                }
                catch { }
            }

        }
        public static void N4()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            double[] mas = new double[l];
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            for (int i = 0; i < l; i++)
            {
                try
                {
                    double element = Convert.ToDouble(splitString[i]);
                    mas[i] = element;
                }
                catch { }
            }

            Console.WriteLine();
            double k = -1000;
            double sum = 0;
            int c = -1;
            int n = 0;

            for (int i = 0; i <= mas.Length; i++)
            {
                try
                {
                    if (k < mas[i])
                    {
                        c++;
                        k = mas[i];
                    }
                }
                catch { }
            }
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                try
                {
                    n++;
                    sum += mas[i];
                }
                catch { }
            }
            sum = sum / n;
            for (int i = 0; i <= mas.Length; i++)
            {
                if (i <= c)
                {
                    Console.Write(mas[i] );
                }
                else if (i > c)
                {
                    mas[i] = sum;
                    Console.Write(mas[i]);
                }
            }
        }
        public static void N5()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            int[] mas = new int[l];
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    int element = Convert.ToInt32(splitString[i]);
                    mas[i] = element;
                    Console.Write(" " + mas[i]);
                }
                catch
                {

                }
            }
            Console.WriteLine(" ");

            int kMax = -1000;
       
            int cMax = 0;
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    if (kMax < mas[i])
                    {
                        kMax = mas[i];
                        cMax = i;
                    }
                }
                catch { }
            }

                int kMin = 1000;
            int cMin = 0;
            int c = 0;
                for (int i = cMax; i <= l; i++)
                {
                    try
                    {
                        if (kMin > mas[i])
                        {
                            kMin = mas[i];
                        }
                    cMin=i;
                    }
                    catch { }
                }
            //Console.WriteLine(kMax + " "+kMin);
            //Console.WriteLine(cMax + " " + cMin);

            for (int i = cMax; i < cMin; i++)
            {
                if (mas[i] < 0)
                {

                    c++;
                }

            }
            Console.WriteLine(c);

            double[] mas2 = new double[c];
            int k = 0;
            for (int i = cMax+1; i < cMin; i++)
            {
                if (mas[i] < 0)
                {
                    mas2[k] = mas[i];
                        k++;
                }
                try { 
                Console.Write(" "+mas2[k-1]);
                
                }
                catch { }
            }


        }
        // 3 5 -3 -4 2 -5
        }
    }


