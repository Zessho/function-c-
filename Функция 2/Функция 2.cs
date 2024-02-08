// See https://aka.ms/new-console-template for more information

Double Square(Double rad)
{
    Double S = rad*rad*Math.PI;
    Console.Write($"Площадь окружности = ");
    return S;
}
Console.Write("Введите радиус окружности:");
Double rad = Convert.ToDouble(Console.ReadLine());

Double message = Square(rad);  // получаем результат метода в переменную message
Console.Write(message);