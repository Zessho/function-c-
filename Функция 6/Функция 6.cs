// See https://aka.ms/new-console-template for more information

void palindrome(string str)
{
    int i = 0;
    int j = str.Length-1;
    bool pal = true;
    for(i= 0; i < str.Length; i++)
    {
        if (str[i] == ' ')
        {
            str.Remove(i);
        }
    }
    while ((i < str.Length-1) && (j > 0))
    {
        i++;
        j--;
        if (str[i] != str[j]) {
            pal = false;
            break;
        }  
    }
    if (pal == true)
    {
        Console.Write("Строка является палиндромом ");  
    }
    else
    {
        Console.Write("Строка не является палиндромом ");
    }
    //    Console.Write($"{str[0]}");
    //    Console.Write($"{str[str.Length-1]}");
}
Console.Write("Введите строку: ");
string str = Console.ReadLine();
//palindrome(str);
palindrome(str);


