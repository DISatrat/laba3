//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba3
//{
//    class Level_1
//    {
//        static void Main(string[] args)
//        {
//            N54();
//            Console.ReadLine();
//        }
//        public static void N1()
//        {

//            double[] list = new double[6] { 1, 4, 8, 3, 6, 6 };
//            double sum = 0;
            
//            for (int i = 0; i < list.Length; i++)
//            {
//                sum += list[i];

//            }
//            for (int i = 0; i < 6; i++)
//            {
//                list[i] = list[i] / sum;
//                Console.Write(list[i] + " ");
//            }
//        }
//        public static void N2()
//        {
//            double[] list = new double[8] { -89, 10, -3, 1, -4, -10, 9, 5 };
//            double sum = 0;
            
//            int k = 0;
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i] > 0)
//                {
//                    k++;
//                    sum += list[i];
//                }
//            }
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i] > 0)
//                {
//                    list[i] = sum / k;
//                    Console.Write($"{list[i]} ");
//                }
//                else
//                {
//                    Console.Write($"{list[i]} ");
//                }
//            }
//        }
//        public static void N3()
//        {
//            int[] list1 = new int[4] { 5, 2, 7, 2 };
//            int[] list2 = new int[4] { 3, 6, 14, 56 };
//            int[] list3 = new int[4];
//            Console.Write("сумма ");
//            for (int i = 0; i < 4; i++)
//            {
//                list3[i] = list1[i] + list2[i];
//                Console.Write(" " + list3[i]);
//            }
//            Console.Write(" разность ");
//            for (int i = 0; i < 4; i++)
//            {
//                list3[i] = list1[i] - list2[i];
//                Console.Write(" " + list3[i]);
//            }

//        }
//        public static void N4()
//        {

//            double[] list = new double[5] { 6, 8, 5, 32, 43 };
//            double sum = 0;
//            int k = 0;
//            for (int i = 0; i < list.Length; i++)
//            {
//                k++;
//                sum += list[i];
//            }
//            for (int i = 0; i < list.Length; i++)
//            {
//                list[i] = list[i] - sum / k;
//                Console.Write(list[i]);
//            }
//        }
//        public static void N5()
//        {
//            int[] list1 = new int[4] { 5, 2, 7, 2 };
//            int[] list2 = new int[4] { 3, 6, 14, 56 };
//            int sc = 0;
//            for (int i = 0; i < 4; i++)
//            {
//                sc += list1[i] * list2[i];
//            }
//            Console.WriteLine(sc);
//        }
//        public static void N6()
//        {
//            int[] list1 = new int[5] { 5, 2, 7, 2, 8 };
//            double sum = 0;
//            for (int i = 0; i < 5; i++)
//            {
//                sum += list1[i] * list1[i];
//            }
//            sum = Math.Sqrt(sum);
//            Console.WriteLine(sum);
//        }
//        public static void N7()
//        {
//            double[] list = new double[7] { 43, 6, 5, 65443, 654, -354, 676 };
//            double sum = 0;
//            int k = 0;
//            for (int i = 0; i < list.Length; i++)
//            {
//                k++;
//                sum += list[i];
//            }
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i] > sum / k)
//                {
//                    list[i] = 0;
//                }
//                Console.Write(list[i]);
//            }
//        }
//        public static void N8()
//        {
//            double[] list1 = new double[6] { -5, -2, 7, -2, 8, 4 };
//            int c = 0;
//            for (int i = 0; i < 6; i++)
//            {
//                if (list1[i] <= 0)
//                {
//                    c += 1;
//                }
//            }
//            Console.WriteLine(c);
//        }
//        public static void N9()
//        {
//            double[] list = new double[8] { 65, 34, 76, 2, 7, 1, 6, 3 };
//            double sum = 0;
//            int k = 0;
//            int c = 0;
//            for (int i = 0; i < list.Length; i++)
//            {
//                k++;
//                sum += list[i];
//            }
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i] > sum / k)
//                {
//                    c++;
//                }
//            }
//            Console.WriteLine(c);
//        }
//        public static void N10()
//        {
//            double[] list1 = new double[6] { -5, -2, 7, -2, 8, 4 };
//            int p = 2;
//            int q = 10;
//            int c = 0;
//            for (int i = 0; i < 6; i++)
//            {
//                if (list1[i] > p && list1[i] < q)
//                {
//                    c++;
//                }
//            }
//            Console.WriteLine(c);

//        }
//        public static void N11()
//        {
//            double[] list1 = new double[10] { -8, -343, -245, -3, 0, 1, 27, 34, 4, 5 };
//            int c = 0;
//            int k = -1;
//            for (int i = 0; i < list1.Length; i++)
//            {
//                if (list1[i] > 0)
//                {
//                    c++;
//                }
//            }
//            double[] list2 = new double[c];
//            for (int i = 0; i < list1.Length; i++)
//            {
//                if (list1[i] > 0)
//                {
//                    k++;
//                    list2[k] = list1[i];
//                    Console.Write(list2[k]);
//                }
//            }

//        }
//        public static void N12()
//        {
//            double[] list1 = new double[8] { -8, -343, -245, -3, 0, 1, 27, 34 };
//            int c = 0;
            
//            for (int i = 0; i < list1.Length; i++)
//            {
//                if (list1[i] < 0)
//                {
//                    c = i;
//                }

//            }

//            Console.WriteLine(list1[c] + " " + c);
//        }
//        public static void N13()
//        {
//            double[] list = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//            double[] chet = new double[5];
//            double[] neChet = new double[5];
//            int k = -1;
//            int t = -1;
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i] % 2 == 0 && list[i] != 0)
//                {
//                    k++;
//                    chet[k] = list[i];
//                    Console.Write(chet[k]);
//                }
//            }
//            Console.WriteLine();
//            for (int i = 0; i < list.Length; i++)
//            {
//                if (list[i] % 2 != 0)
//                {
//                    t++;
//                    neChet[t] = list[i];
//                    Console.Write(neChet[t]);
//                }
//            }
//        }
//        public static void N14()
//        {
//            double[] list1 = new double[11] { 8, 34, 45, -3, 0, 1, 27, 34, 7, 1, 6 };
//            double sum = 0;
//            for (int i = 0; i < list1.Length; i++)
//            {
//                while (list1[i] > 0)
//                {
//                    sum += list1[i] * list1[i];
//                    break;
//                }
//                if (list1[i] < 0)
//                {
//                    break;
//                }
//            }
//            Console.WriteLine(sum);
//        }
//        public static void N15()
//        {
//            double[] x = new double[10] { 2, 5, 7, 1, 6, 56, 8, 6, 6, 1 };
//            double[] y = new double[10];
//            for (int i = 0; i < x.Length; i++)
//            {
//                y[i] = 0.5 * Math.Log(x[i], Math.E);
//                Console.Write($"{x[i]}  {y[i]}");
//                Console.WriteLine();
//            }
//        }
//        public static void N54()
//        {

//        Console.WriteLine("Введите размер массива");
//            int l = int.Parse(Console.ReadLine());
//        double[] mas = new double[l];
//        Console.WriteLine("Введите элементы массива через пробел");
//            string line = Console.ReadLine();
//        string[] splitString = line.Split(' ');
//            for (int i = 0; i <= l; i++)
//            {
//                try
//                {

//                    double element = Convert.ToDouble(splitString[i]);
//                    mas[i] = element;
//                    Console.WriteLine(mas[i]);
//                }
//                catch
//                {

//                }
//            }


//        }
//}
//}