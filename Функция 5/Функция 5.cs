// See https://aka.ms/new-console-template for more information

int factorial(int num)
{
    int f = 0;
    for (int i = 1; i <= num; i++)
    {
        f = f + i;
    }
    Console.Write($"Факториал числа {num} = ");
    return f;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int message = factorial(num);  // получаем результат метода в переменную message
Console.Write(message);