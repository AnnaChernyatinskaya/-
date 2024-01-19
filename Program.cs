using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shifr_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, rez = "";
            Console.WriteLine("Введите текст: ");
            text = Console.ReadLine();
            while (text.Length > 25 || text == " ")
            {
                Console.WriteLine("Что-то пошло не так!");
                Console.WriteLine("Введите текст: ");
                text = Console.ReadLine();
            }
            Console.WriteLine("Выберите действие: \n1 - зашифровать\n2 - расшифровать");
            string d = Console.ReadLine();
            int n = Int32.Parse(d);

            Console.WriteLine("Исходная таблица перестановки: ");
            char[,] a = new char[5, 5];
            for (int i = 0; i < text.Length; i++)
            {
                a[i / 5, i % 5] = text[i];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
            char temp;

            switch (n)
            {
                case 1:
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == 0)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i + 1, j];
                                a[i + 1, j] = temp;
                            }
                            else if (i == 3)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i - 3, j];
                                a[i - 3, j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Перестановка СТРОК таблицы");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("{0} ", a[i, j]);
                        }
                        Console.WriteLine();
                    }
                    
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == 1)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i, j + 1];
                                a[i, j + 1] = temp;
                            }
                            else if (j == 3)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i, j + 1];
                                a[i, j + 1] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Перестановка столбцов таблицы");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("{0} ", a[i, j]);
                            rez += a[i, j];
                        }
                        Console.WriteLine();
                    }
                
                    Console.WriteLine("Результат: " + rez);
                    break;
                case 2:
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (j == 1)
                            {
                                temp = a[i,j];
                                a[i,j] = a[i,j+1];
                                a[i,j+1] = temp;
                            }
                            else if (j == 3)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i, j + 1];
                                a[i, j + 1] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Перестановка столбцов таблицы");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("{0} ", a[i, j]);
                        }
                        Console.WriteLine();
                    }
                    
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (i == 0)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i+3, j];
                                a[i+3, j] = temp;
                            }
                            else if (i == 1)
                            {
                                temp = a[i, j];
                                a[i, j] = a[i-1, j];
                                a[i-1, j] = temp;
                            }
                        }
                    }
                    Console.WriteLine("Перестановка строк таблицы");
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            Console.Write("{0} ", a[i, j]);
                            rez += a[i,j];
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("Результат: " + rez);
                    break;
            }
            Console.ReadKey();
        }
    }
}
