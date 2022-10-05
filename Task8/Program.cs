// Дано число из отрезка [10,99], Показать наибольшую цифру числа
int num = new Random().Next(9,100);
Console.WriteLine("Выпавшее число:" +num);
string b = num.ToString();
if(b[0] > b[1]) Console.WriteLine("Наибольшая цифра из числа: " +b[0]);
else if(b[0] < b[1]) Console.WriteLine("Наибольшая цифра из числа: " +b[1]);
else
{
    Console.WriteLine("Числа равны, наибольшего нет. Максимальное: " +b[0]);
}