// See https://aka.ms/new-console-template for more information

bool Prost(int num)
{
    bool pr = true;
    for (int i = 1; i < num+1; i++)
    {
        if ((num != i)&&(i != 1))
        {
            if (num % i == 0)
            {
                pr = false;
                
            }
        }
    }
    Console.Write("Число простое: ");
    return pr; 
}
Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

bool message = Prost(num);  // получаем результат метода в переменную message
Console.Write(message);
