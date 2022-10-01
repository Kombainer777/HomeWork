// Октябрь 2022
int[] mon =  {3, 10, 17, 24, 31};
int[] tue =  {4, 11, 18, 25 };
int[] wed =  {5, 12, 19, 26};
int[] thu =  {6, 13, 20, 27};
int[] fri =  {7, 14, 21, 28};
int[] sat =  {1, 8, 15, 22, 29};
int[] sun =  {2, 9, 16, 23, 30};
Console.WriteLine("Введите число месяца октября (31 день)");
int a = int.Parse(Console.ReadLine());
    if(mon.Contains(a))
    {
     Console.WriteLine("Понедельник");   
    }
     if(tue.Contains(a))
    {
     Console.WriteLine("Вторник");   
    }
     if(wed.Contains(a))
    {
     Console.WriteLine("Среда");   
    }
     if(thu.Contains(a))
    {
     Console.WriteLine("Четверг");   
    }
     if(fri.Contains(a))
    {
     Console.WriteLine("Пятница");   
    }
     if(sat.Contains(a))
    {
     Console.WriteLine("Суббота");   
    }
     if(sun.Contains(a))
    {
     Console.WriteLine("Воскресенье");   
    }