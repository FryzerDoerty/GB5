// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void Main()
{
    int[] array = FillArray(5, 100, 999);
    PrintArray(array);
    int sum = 0;
    Res(array, out sum);
    System.Console.WriteLine(sum);
}
int[] FillArray(int size = 5, int left = 100, int right = 999)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(left, right);
    }
    return array;
}
void Res(int[] array, out int sum)
{
    sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        { sum = sum + 1; }
    }
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
Main();
