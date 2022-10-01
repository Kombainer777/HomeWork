Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

    if(Math.Sqrt(a) == b) 
    {
        Console.WriteLine("Да, первое число является квадратом второго");
    }
    else 
    {
        Console.WriteLine("Нет, первое число не является квадратом второго");
    }