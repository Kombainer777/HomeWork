// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());
string b = a.ToString();
Console.Write("Полученное число:" +b[0]); Console.WriteLine(b[2]);