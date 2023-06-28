//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
void main()
{
    int[] array = FillArray(5, -999, 999);
    PrintArray(array);
    int sum = 0;
    Res(array, out sum);
    System.Console.WriteLine(sum);
}
int[] FillArray(int size = 5, int left = -999, int right = 999)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(left, right);
    }
    return array;
}
void Res(int[] arr, out int sum)
{
    sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        { sum = sum + arr[i]; }
    }

}
void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
main();
