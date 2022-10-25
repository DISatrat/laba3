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
            N20();
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
                    Console.Write(mas[i]);
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
                    cMin = i;
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
            for (int i = cMax + 1; i < cMin; i++)
            {
                if (mas[i] < 0)
                {
                    mas2[k] = mas[i];
                    k++;
                }
                try {
                    Console.Write(" " + mas2[k - 1]);

                }
                catch { }
            }


        }
        // 3 5 -3 -4 2 -5
        public static void N6()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            double[] mas = new double[l];
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

            Console.WriteLine("Введите число р");
            int p = int.Parse(Console.ReadLine());
            double sum = 0;
            double sreA;
            double close = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += Math.Abs(mas[i]);
            }
            sreA = sum / mas.Length;
            int k = 0;
            for (int i = 0; i <= mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length - 1; j++)
                {

                    if (Math.Abs(sreA - mas[i]) < Math.Abs(sreA - mas[j]))
                    {
                        close = mas[i];
                        k = i;
                    }
                    else
                    {
                        close = mas[j];
                        k = j;
                    }
                }
            }
            Console.WriteLine(sreA);
            Console.WriteLine(k);
            double[] mas2 = new double[mas.Length + 1];
            int n = mas2.Length;
            for (int i = 0; i <= mas2.Length; i++)
            {
                if (i == k + 1)
                {
                    try
                    {

                        mas2[i] = p;
                    }
                    catch { }
                }
                else if (i > k + 1)
                {
                    for (int j = k + 1; j < mas.Length; j++)
                    {
                        try
                        {
                            mas2[j + 1] = mas[j];
                        }
                        catch { }


                    }
                }
                else
                {
                    try
                    {

                        mas2[i] = mas[i];
                    }
                    catch { }
                }
                try
                {
                    Console.Write(" " + mas2[i]);
                }
                catch { }
            }

        }
        public static void N7()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            int[] mas = new int[splitString.Length];
            for (int i = 0; i < splitString.Length; i++)
                mas[i] = int.Parse(splitString[i]);

            int k = -1000;
            int c = -1;

            try
            {
                for (int i = 0; i <= mas.Length; i++)
                {
                    if (k < mas[i])
                    {
                        k = mas[i];
                        c++;
                    }
                }
            }
            catch { }

            mas[c + 1] *= 2;

            try
            {
                for (int i = 0; i <= mas.Length; i++)
                {
                    Console.Write($"{mas[i]} ");
                }
            }
            catch { }

        }
        public static void N8()
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
                    cMin = i;
                }
                catch { }
            }
            Console.WriteLine(cMin + " " + cMax);

            int a = kMax;
            mas[cMax] = mas[cMin];

            mas[cMin] = kMax;
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(" " + mas[i]);
            }
        }
        public static void N9()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            int[] mas = new int[splitString.Length];
            for (int i = 0; i < splitString.Length; i++)
                mas[i] = int.Parse(splitString[i]);

            int max = -1000;
            int min = 1000;
            int cMax = -1;
            int cMin = -1;
            double sum = 0;
            int c = 0;
            double srArif = 0;

            try
            {
                for (int i = 0; i <= mas.Length; i++)
                {
                    if (max < mas[i])
                    {
                        max = mas[i];
                        cMax = i;
                    }
                }

            }
            catch { }

            try
            {
                for (int i = 0; i <= mas.Length; i++)
                {
                    if (min > mas[i])
                    {
                        min = mas[i];
                        cMin = i;
                    }
                }

            }
            catch { }

            try
            {
                if (cMax > cMin)
                {
                    for (int j = cMin + 1; j <= cMax - 1; j++)
                    {
                        sum += mas[j];
                        c++;
                    }
                }
                else if (cMax < cMin)
                {
                    for (int j = cMax + 1; j <= cMin - 1; j++)
                    {
                        sum += mas[j];
                        c++;
                    }
                }
            }
            catch { }

            try
            {
                srArif = sum / c;
            }
            catch { }

            Console.WriteLine(srArif);

        }
        public static void N10()
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

            double kMix = 1000;

            int cMix = 0;
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    if (kMix > mas[i])
                    {
                        kMix = mas[i];
                        cMix = i;
                    }
                }
                catch { }
            }
            Console.WriteLine(cMix);
            double[] mas2 = new double[mas.Length - 1];
            for (int i = 0; i < mas.Length; i++)
            {
                if (i == cMix)
                {
                    try
                    {

                    mas2[i] = mas[i + 1];
                    }
                    catch { }
                }
                else if (i > cMix)
                {
                    for (int j = i+1; j < mas.Length; j++)
                    {
                        try
                        {
                        mas2[j-1] = mas[j];

                        }
                        catch { }

                    }
                }
                else
                {
                    try
                    {

                        mas2[i] = mas[i];
                    }
                    catch { }
                }
                try 
                {
                    
                    Console.Write(" "+mas2[i]);
                }
                catch { }
            }

        }
        public static void N11()
    {
        Console.WriteLine("Введите элементы массива через пробел");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');
        int[] mas = new int[splitString.Length];
        for (int i = 0; i < splitString.Length; i++)
            mas[i] = int.Parse(splitString[i]);
        Console.WriteLine("Введите P");
        int p = int.Parse(Console.ReadLine());

        int index = 0;

        try
        {
            for (int i = 0; i <= mas.Length; i++)
            {
                if (mas[i] > 0)
                {
                    index = i;
                }
            }
        }
        catch { }

        int[] mas2 = new int[mas.Length + 1];

        try
        {
            for (int i = 0; i <= mas.Length; i++)
            {
                if (i == index + 1)
                {
                    mas2[i] = p;
                }
                else if (i <= index)
                {
                    mas2[i] = mas[i];
                }
                else if (i >= index + 1)
                {
                    mas2[i] = mas[i - 1];
                }
            }
        }
        catch { }

        try
        {
            for (int i = 0; i <= mas2.Length; i++)
            {
                Console.Write(mas2[i] + " ");
            }
        }
        catch { }
    }
        public static void N12()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            double[] mas = new double[l];
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

            double kMin = 1000;

            int cMin = 0;
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    if (mas[i] < 0)
                    {
                        kMin = mas[i];
                        cMin = i;
                        break;
                    }
                }
                catch { }
            }
           
            double kMax = -1000;

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
            
            double sum = 0;
            for (int i = cMax+1; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            double[] mas2 = new double[mas.Length];
            for (int i = 0; i < mas2.Length; i++)
            {
                if (i == cMin)
                {
                    mas2[i] = sum;
                }
                else
                {
                    mas2[i] = mas[i];
                }
                try
                {

                    Console.Write(" "+mas2[i]);
                }
                catch { }
            }
        }
        public static void N13()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            int[] mas = new int[splitString.Length];
            for (int i = 0; i < splitString.Length; i++)
                mas[i] = int.Parse(splitString[i]);

            int max = -1000;
            int index = 0;

            try
            {
                for (int i = 0; i <= mas.Length; i++)
                {
                    if (i % 2 == 0 && i != 0 && mas[i] > max)
                    {
                        max = mas[i];
                        index = i;
                    }

                }
            }
            catch { }

            mas[index] = index;

            try
            {
                for (int i = 0; i <= mas.Length; i++)
                {
                    Console.Write(mas[i] + " ");
                }
            }
            catch { }
        }
        public static void N14()
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

            int kMin = 1000;

            int cMin = 0;
            for (int i = 0; i <= l; i++)
            {
                try
                {
                    if (mas[i] < 0)
                    {
                        kMin = mas[i];
                        cMin = i;
                        break;
                    }
                }
                catch { }
            }

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
            int a = cMin;
            int b = cMax;
            Console.WriteLine(a + " " + b);
            mas[cMax] = mas[cMin];
            mas[cMin] = kMax;
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(" "+mas[i]);
            }

        }
        public static void N15()
        {
            Console.WriteLine("Введите элементы массива A через пробел");
            string lineA = Console.ReadLine();
            string[] splitStringA = lineA.Split(' ');
            int[] masA = new int[splitStringA.Length];
            for (int i = 0; i < splitStringA.Length; i++)
                masA[i] = int.Parse(splitStringA[i]);

            Console.WriteLine("Введите элементы массива B через пробел");
            string lineB = Console.ReadLine();
            string[] splitStringB = lineB.Split(' ');
            int[] masB = new int[splitStringB.Length];
            for (int i = 0; i < splitStringB.Length; i++)
                masB[i] = int.Parse(splitStringB[i]);

            int k = 0;
            int l = 0;
            int c = 0;
            int index = 0;

            int[] mas = new int[masA.Length + masB.Length];

            try
            {
                if (masB.Length <= masA.Length)
                {
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (c < masB.Length)
                        {
                            if (i % 2 == 0)
                            {
                                mas[i] = masA[k];
                                k++;
                                index = k;
                            }
                            else if (i % 2 != 0)
                            {
                                mas[i] = masB[l];
                                l++;
                                c++;
                            }
                        }
                        else
                        {
                            mas[i] = masA[index];
                            index++;
                        }
                    }
                    for (int i = 0; i < mas.Length; i++)
                    {
                        Console.Write(mas[i] + " ");
                    }
                }

                else if (masB.Length > masA.Length)
                {
                    Console.WriteLine("Ошибка: массив B больше массива A");
                }
            }
            catch { }
        }
        public static void N16()
        {
            Console.WriteLine("Введите размер массива");
            int l = int.Parse(Console.ReadLine());
            double[] mas = new double[l];
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
            double sum = 0;
            double sre = 0;
            try
            {

                for (int i = 0; i < mas.Length; i++)
                {
              sum += mas[i];

                }
                sre = sum / mas.Length;
           
            }
            catch { }
            int c = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < sre)
                {
                    c++;
                }
            }
            int k = -1;
            Console.WriteLine(sre);
            double[] mas2 = new double[c];
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < sre)
                {
                    try
                    {
                        k++;
                    mas2[k] = mas[i];
                    }
                    catch { }
                }
                try
                {

              
                }
                catch { }
            }
            for (int i = 0; i < mas2.Length; i++)
            {
                Console.Write(" " + mas2[i]);
            }
        }
        public static void N17()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            int[] mas = new int[splitString.Length];
            for (int i = 0; i < splitString.Length; i++)
                mas[i] = int.Parse(splitString[i]);

            int max = -1000;
            int min = 1000;
            int iMax = 0;
            int iMin = 0;
            double sum = 0;
            int k = 0;
            int h = 0;
            double c = 0;
            double srArif = 0;
            try
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > max)
                    {
                        max = mas[i];
                        iMax = i;
                    }
                    if (mas[i] < min)
                    {
                        min = mas[i];
                        iMin = i;
                    }
                }

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > 0)
                    {
                        k++;
                    }
                    if (mas[i] < 0)
                    {
                        h++;
                    }
                }

                if (iMax < iMin)
                {
                    if (k > 0)
                    {
                        for (int i = 0; i < mas.Length; i++)
                        {
                            if (mas[i] > 0)
                            {
                                sum += mas[i];
                                c++;
                            }
                        }
                        Console.WriteLine(sum + " " + c);
                        srArif = sum / c;
                        Console.WriteLine("Среднее арифметическое " + srArif);
                    }
                    else
                    {
                        Console.WriteLine("Массив не содержит положительных элементов");
                    }
                }
                else if (iMax > iMin)
                {
                    if (h > 0)
                    {
                        for (int i = 0; i < mas.Length; i++)
                        {
                            if (mas[i] < 0)
                            {
                                sum += mas[i];
                                c++;
                            }
                        }
                        srArif = sum / c;
                        Console.WriteLine("Среднее арифметическое " + srArif);
                    }
                    else
                    {
                        Console.WriteLine("Массив не содержит отрицательных элементов");
                    }
                }
            }
            catch { }
        }
        public static void N18()
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

            int chetMax = -1000;
            int k = 0;
            int nechetMax = -1000;
            for (int i = 0; i < mas.Length; i+=2)
            {
                if (mas[i] > chetMax)
                {
                    k = mas[i];
                    chetMax = k;
                }
            }
            Console.WriteLine(chetMax);

            int c = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 != 0)
                {
                    c = mas[i];
                    nechetMax = c;
                }
            }
            Console.WriteLine(nechetMax);

            if (chetMax > nechetMax)
            {
                for (int i = 0; i < mas.Length/2; i++)
                {
                    mas[i] = 0;
                }
            }
            else
            {
                for (int i = mas.Length/2; i < mas.Length; i++)
                {
                    mas[i] = 0;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {

            Console.Write(" "+mas[i]);
            }
        }
        public static void N19()
        {
            Console.WriteLine("Введите элементы массива через пробел");
            string line = Console.ReadLine();
            string[] splitString = line.Split(' ');
            int[] mas = new int[splitString.Length];
            for (int i = 0; i < splitString.Length; i++)
                mas[i] = int.Parse(splitString[i]);

            int max = -1000;
            int iMax = 0;
            int sum = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > max)
                {
                    max = mas[i];
                    iMax = i;
                }
            }

            if (max > sum)
            {
                mas[iMax] = 0;
            }
            else
            {
                mas[iMax] *= 2;
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
        }
        public static void N20()
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

            int k = 0;
            int Min = 1000;
            int c = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < Min)
                {
                    k = mas[i];
                    Min = k;
                    c = i;
                }
            }
            
            int otric = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 0)
                {
                    otric = i;
                    break;
                }
            }
            
            int sum = 0;
               if (otric < c)
               {
                   for (int j = 0; j < mas.Length; j+=2)
                   {
                    sum += mas[j];
                   }
               }
            else
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += mas[i];
                    }
                }
            }
           
                Console.WriteLine("сумм= "+sum);
            
        }
    }
}


