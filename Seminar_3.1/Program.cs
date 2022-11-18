Console.WriteLine("Введите номер четверти: ");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:{
        Console.WriteLine("Это 1я четверть");
        break;
    }
    case 2:{
        Console.WriteLine("Это 2я четверть");
        break;
    }
     case 3:{
        Console.WriteLine("Это 3я четверть");
        break;
    }
     case 4:{
        Console.WriteLine("Это 4я четверть");
        break;
    }
     default:{
        Console.WriteLine("Такой четверти не существует");
        break;
    }

}


