int[,] TwoArray = new int[3, 4];
Random random = new Random();
int Sum= 0;
int index =0;
for (int i = 0; i < TwoArray.GetLength(0); i++)
{
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {

        TwoArray[i, j] = random.Next(-100,101);
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

for (int i = 0; i < TwoArray.GetLength(0); i++)
{   int SumTmp=0;
    for (int j = 0; j < TwoArray.GetLength(1); j++)
    {
        SumTmp +=TwoArray[i,j];
        if (SumTmp>Sum)
        {
            Sum=SumTmp;
            index=i;
        }
        
    }
    
}
Console.WriteLine($"Сумма элиментов:{Sum}\nНомер строки с наименьшей суммой элементов:  {index+1}");
