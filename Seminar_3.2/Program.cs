Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine()!);
            string number1 = number.ToString();
            if (number1.Length != 6)
            {
                Console.WriteLine("Неверное значение!");
            }
            else
            {
                if (number1[0] + number1[1] + number1[2] == number1[3] + number1[4] + number1[5])
                {
                    Console.WriteLine("Счасливое число");
                }
                else
                {
                    Console.WriteLine("Несчасливое число");

                }
            }

