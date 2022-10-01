// Показать все четные числа в интервале от 1 до N

Console.WriteLine("Эта программа выведет все четные числа в диапазоне от 1 до N. Введите значение N - конец диапазона");
int N = int.Parse(Console.ReadLine());
int first = 1;
int size = N - 1;
int [] arr = new int[size];
int i = 0;
while(first <= size)
{
    arr[i] = first;
    first++;
    i++;
    }   
i=0;
while(i<size)
{
    if(arr[i] % 2== 0)
    {
        Console.WriteLine(arr[i]);
    }
    i++;
}