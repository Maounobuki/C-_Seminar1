Console.WriteLine("Введите числa кординаты А: ");
            double x1 = double.Parse(Console.ReadLine()!);
            double y1 = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Введите числa кординаты B: ");
            double x2 = double.Parse(Console.ReadLine()!);
            double y2 = double.Parse(Console.ReadLine()!);

            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"Расстояние между координатами А и B = {AB:f3}" );

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

/*// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int[] mas = {3, 6, 2, 1};
int[] mas = {7, -5, 1, -1};

double masR = Math.Sqrt(Math.Pow(mas[0]-mas[2], 2) + Math.Pow(mas[1]-mas[3], 2));
Console.WriteLine($"{masR:f2}");*/