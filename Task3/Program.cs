// Найти максимальное из трёх чисел. Числа предложим ввести пользователю
Console.WriteLine("Ведите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите третье число");
int c = int.Parse(Console.ReadLine());
int max = a;

    if(max < b)
    {
        max = b;
    }
    else
    {
        if(max < c)
        {
          max = c;  
        }
    }
Console.Write("Максимальное число из трёх введенных:  ");
Console.WriteLine(max);