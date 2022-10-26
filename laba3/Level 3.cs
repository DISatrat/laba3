using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    class Level_3
    {
        static void Main(string[] args)
        {
            N12();
            Console.ReadLine();
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

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 2; j++)
                {
                    if (j % 2 == 0 && j != 0)
                    {
                        if (mas[j] > mas[j + 2])
                        {
                            int z = mas[j];
                            mas[j] = mas[j + 2];
                            mas[j + 2] = z;
                        }
                    }
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }




        }
        public static void N12()
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
            int k = -1;
            try
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] < 0)
                    {
                        c++;
                    }
                }

                int[] mas2 = new int[mas.Length - c];

                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] > 0)
                    {
                        k++;
                        mas2[k] = mas[i];
                    }
                }

                for (int i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas2[i] + " ");
                }
            }
            catch { }

        }
    }
}