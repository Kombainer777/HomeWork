// Найти третью цифру числа или сообщить что ее нет
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if(a < 100) Console.WriteLine("Третьей цифры в заданном числе нет.");
else
{
    string b = a.ToString();
    Console.WriteLine("Третьей цифрой в заданном числе является:" +b[2]);
}
