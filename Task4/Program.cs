// Проверить, является ли число четным. Пользователь будет сам вводить число

Console.WriteLine("Ведите любое число");
int a = int.Parse(Console.ReadLine());

    if(a%2==0)
    {
        Console.WriteLine("Число четное");
    }
    else
    {
        Console.WriteLine("Число нечетное");
    }