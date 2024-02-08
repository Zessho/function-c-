// See https://aka.ms/new-console-template for more information


string length(string str)
{
    return($"Длинна Строки: {str.Length}"); 
}
Console.Write("Введите строку: ");
string str = Console.ReadLine();

//length(str);
string message = length(str);  // получаем результат метода в переменную message
Console.Write(message);