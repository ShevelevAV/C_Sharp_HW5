/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

int[] GetArray(int size, int min, int max)
{
    int[] temp = new int[size];
    for (int i = 0; i < size; i++)
    {
        temp[i] = new Random().Next(min, max);
    }
    return temp;
}
void PrintArray(int[] pa)
{
    for (int i = 0; i < pa.Length; i++)
    {
        Console.Write($"{pa[i]} ");
    }
}
void DiffMinMax(int[] arr)
{
    int i = 0;
    int max = arr[i];
    int min = arr[i];
    while (i < arr.Length)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
        i++;
    }
    Console.Write($"{max} - {min} = {max - min} ");

}

int[] array = GetArray(5, 1, 100);
PrintArray(array);
Console.WriteLine();
DiffMinMax(array);