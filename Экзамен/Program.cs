using System;
using System.IO;
namespace Экзамен
{
    class Program
    {
        public void reshenie()
        {
            StreamWriter sw = new StreamWriter(@"X:\NGK\ПМ.02 Экзамен\Log.txt");

            //Ввод размерности массива
            Console.WriteLine("Введите количество строк:");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество стобцов:");
            int M = Convert.ToInt32(Console.ReadLine());
            sw.WriteLine("Размерность таблицы {0} на {1}", N, M);
            Console.Clear();

            //Ввод чисел в массив
            int[,] Mas = new int[N, M];
            Console.WriteLine("ВВОДИМЫЕ ЧИСЛА ОГРАНИЧЕНЫ 3 СИМВОЛАМИ\n");
            sw.WriteLine("\nИсходные числа:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\nВведите числа из строки {0}:", i + 1);
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine("Введите {0} число: ", j + 1);
                    Mas[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();

            //Решение
            int count = 0, chislo; int x1, x2, x3;
            int[] rMas = new int[N * M];
            sw.WriteLine("Начата проверка.");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    x1 = Mas[i, j] / 100;
                    x2 = Mas[i, j] % 100 / 10;
                    x3 = Mas[i, j] % 10;
                    chislo = (int)Math.Pow(x1, 3) + (int)Math.Pow(x2, 3) + (int)Math.Pow(x3, 3);
                    if (chislo == Mas[i, j])
                    {
                        rMas[count] = Mas[i, j];
                        count = count + 1;
                    }
                }
            }
            sw.WriteLine("Проверка закончена.");

            //Вывод
            Console.WriteLine("Исходные числа\n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("{0:d3}   ", Mas[i, j]);
                    sw.Write("{0:d3}   ", Mas[i, j]);
                }
                Console.WriteLine();
                sw.WriteLine();
            }
            Console.WriteLine("\nЧисла Армстронга:");
            sw.WriteLine("\nЧисла Армстронга:");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0:d3}   ", rMas[i]);
                sw.Write("{0:d3}   ", rMas[i]);
            }
            Console.WriteLine("\nКоличество чисел армстронга равно {0}", count);
            sw.WriteLine("\nКоличество чисел армстронга равно {0}", count);
            sw.Close();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.reshenie();
            Console.ReadKey();
        }
    }
}