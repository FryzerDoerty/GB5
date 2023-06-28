// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
void main()
{
    double[] array = FillArray(5, 1, 100);
    PrintArray(array);
    double max = array[0];
    double min = array[0];
    double raz = Res(array, out max, out min);
    System.Console.WriteLine(max + "-" + min + " = " + raz);
}



double Res(double[] array, out double max, out double min)
{
    max = array[0];
    min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        { min = array[i]; }
        else if (array[i] > max)
        {
            max = array[i];
        }
    }
    double raz = Math.Round((max - min), 3);
    return raz;
}

double[] FillArray(int size = 5, int left = 1, int right = 100)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(left, right) + rand.NextDouble(), 3);
    }
    return array;
}
void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}
main();
