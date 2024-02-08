// See https://aka.ms/new-console-template for more information

int Sum(int num1, int num2)
{
    int result = num1 + num2;
    Console.Write($"{num1} + {num2} = ");
    return result;
}
Console.Write("Введите число 1:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2:");
int num2 = Convert.ToInt32(Console.ReadLine());
//Sum(num1, num2);
int message = Sum(num1,num2);  // получаем результат метода в переменную message
Console.Write(message);