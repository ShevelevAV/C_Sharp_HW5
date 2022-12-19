/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] GetArray(int size, int min, int max)
{
    int[] temp = new int[size];
    for (int i = 0; i < size; i++)
    {
        temp[i] = new Random().Next(min, max);
    }
    return temp;
}
void PrintArray(int[] arr)
{
    for (int i =0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
   
}
void SumNotEver(int[] sne)
{
    int sum = 0;
    for(int i = 1; i < sne.Length; i +=2)
    {
        sum += sne[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum}");
}
int[] array = GetArray(4, 1, 100);
PrintArray(array);
Console.WriteLine();
SumNotEver(array);