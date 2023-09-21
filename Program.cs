using System;

namespace cs
{
    class Name
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    bool learning = true;

                    Console.Write("Что надо сделать? \n0 - Что бы выйти\n1 - Вывести таблицу умножения\n2 - Учить таблицу умножения\n");
                    int action = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    if (action == 1)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            for (int j = 1; j < 10; j++)
                            {
                                Console.Write($"{j} x {i} = {i * j} |");
                            }
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else if (action == 2)
                    {
                        Console.WriteLine("0 - Что бы выйти");

                        while (learning)
                        {
                            learning = learn();
                        }
                        Console.Clear();
                    }
                    else if (action == 0)
                    {
                        Console.Clear();
                        return;
                    }
                    else if (action < 2) { }
                }
                catch
                {
                    Console.Clear();
                }
            }

            static bool learn()
            {
                Random rm = new Random();
                int a = rm.Next(1, 10);
                int b = rm.Next(1, 10);
                int c = a * b;
                int userInput = 0;

                while (userInput != c)
                {
                    Console.Write($"{a} x {b} = ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == 0)
                    {
                        return false;
                    }
                }
                Console.Clear();
                return true;
            }
        }
    }
}