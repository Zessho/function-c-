// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;

int[] nums1 = new int[3] { 1, 2, 3 };
int[] nums2 = new int[3] { 4, 5, 6 };

string newmass(int[] nums1, int[] nums2)
{
    
    int a = nums1.Length + nums2.Length;
    int[] newnums = new int[a];
    for (int i = 0; i < a; i++)
    {
        if (i < nums1.Length)
        {
            newnums[i] = nums1[i];
        }
        else
        {
            newnums[i] = nums2[i - nums1.Length];
        }
    }
    Console.Write($"Новый массив: ");

    string result = string.Join(" ", newnums);
    return result; //Возвращает System.Int32[]
}
string message = newmass(nums1, nums2);  // получаем результат метода в переменную message
Console.Write(message);