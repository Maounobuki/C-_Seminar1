Console.WriteLine("Введите число N: ");
            int N = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Таблица квадратов до числа N: ");
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
