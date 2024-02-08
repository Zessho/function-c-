// See https://aka.ms/new-console-template for more information

int[] nums = new int[5];
for (int i = 0; i< nums.Length; i++)
{
    Console.Write($"Введите {i+1} Элемент массива:");
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
int search(int[] nums)
{
    int big = nums[0];
    for (int i = 0; i < nums.Length; i++)
    {
        if (big < nums[i])
        {
            big = nums[i];
        } 
    }
    Console.Write("Cамое большое число в массиве: ");
    return big;
}
int message = search(nums);  // получаем результат метода в переменную message
Console.Write(message);
