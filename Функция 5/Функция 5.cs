// See https://aka.ms/new-console-template for more information

void factorial(int num)
{
    int f = 0;
    for (int i = 1; i <= num; i++)
    {
        f = f + i;
    }
    Console.Write($"Факториал числа {num} = {f} ");
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

factorial(num);