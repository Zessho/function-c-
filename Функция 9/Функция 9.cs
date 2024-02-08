// See https://aka.ms/new-console-template for more information

String Reverse(string str)
{
    char [] nstr = str.ToCharArray();
    Array.Reverse(nstr);
    return new string(nstr);
}
Console.Write("Введите строку: ");
string str = Console.ReadLine();
//Reverse(str);
string message = Reverse(str);  // получаем результат метода в переменную message
Console.Write(message);