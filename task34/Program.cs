/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
void PrintArray(int[] pa)
{
    for (int i = 0; i < pa.Length; i++)
    {
        Console.Write($"{pa[i]} ");
    }
}
void EvenNumber(int[] en)
{
    int count = 0;
    for (int i = 0; i < en.Length; i++)
    {
        double temp = en[i];
        if (temp % 2 == 0) count++;
    }
    if (count >= 1)
    {
        Console.Write($"Четных чисел {count} ");
    }
    else
    {
        Console.Write($"Четных чисел нет");
    }
}

int[] array = GetArray(4, 100, 1000);
PrintArray(array);
Console.WriteLine();
EvenNumber(array);
