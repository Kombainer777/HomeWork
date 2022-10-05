// Выяснить кратно ли число заданному, если нет - вывести остаток
Console.WriteLine("Введите делимое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите делитель");
int b = int.Parse(Console.ReadLine());
if(a % b == 0)  Console.WriteLine("Первое число кратно второму");
else
{
    int res = (a%b);
    Console.WriteLine("Первое число не кратно второму. Остаток от деления:" +res);
}