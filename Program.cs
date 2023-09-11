using System;

namespace cs
{
    class Name
    {
        static void Main(string[] args)
        {
            Random rm = new Random();
            Console.Write("Что надо вывести? \n1 - таблица умножение\n2 - учить таблицу умножения\n");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (action == 1)
            {
                for (int i = 1; i < 9; i++)
                {
                    for (int j = 1; j < 9; j++)
                    {
                        Console.Write($"{j} x {i} = {i * j} |");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            else if (action == 2)
            {
                Console.WriteLine("0 - Что бы выйти");
                while (true)
                {
                    int a = rm.Next(1, 10);
                    int b = rm.Next(1, 10);
                    int c = a * b;
                    int us = 0;

                    while (us != c)
                    {
                        Console.Write($"{a} x {b} = ");
                        us = Convert.ToInt32(Console.ReadLine());
                        if (us == 0)
                        {
                            return;
                        }
                    }
                    Console.Clear();
                }
            }
        }
    }
}