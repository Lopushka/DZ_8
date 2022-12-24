int[,] TwoArray = new int[3, 4];
Random random = new Random();
for (int i = 0; i < TwoArray.GetLength(0); i++)
{
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {

        TwoArray[i, j] = random.Next(-10, 11);
    }
}
Console.WriteLine($"Массив случайных чисел:");
Console.WriteLine();
for (int i = 0; i < TwoArray.GetLength(0); i++)
{
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {

        Console.Write(TwoArray[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int l = 0; l < TwoArray.GetLength(0); l++)
{
    for (int i = 0; i < TwoArray.GetLength(1); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1) - 1; j++)
        {
            if (TwoArray[l, j] < TwoArray[l, j + 1])
            {
                int tmp = TwoArray[l, j];
                TwoArray[l, j] = TwoArray[l, j + 1];
                TwoArray[l, j + 1] = tmp;
            }
        }
    }
}
Console.WriteLine("Вывод упорядоченного двумерного массива по убыванию элементы каждой строки:");
for (int i = 0; i < TwoArray.GetLength(0); i++)
{
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {

        Console.Write(TwoArray[i, j] + "\t");
    }
    Console.WriteLine();
}