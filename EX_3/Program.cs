static double[,] GetArrayConsole(string name)
{
loop1:
    Console.Write("\n{0} Размер по вертикали число больше 0:    ", name);
    int SizeY = Convert.ToInt32(Console.ReadLine());
    Console.Write("\n{0} Размер по горизонтали число больше 0:  ", name);
    int SizeX = Convert.ToInt32(Console.ReadLine());

    if (SizeY > 0 && SizeX > 0)
    {
        double[,] TwoArray = new double[SizeY, SizeX];
        for (int i = 0; i < TwoArray.GetLength(0); i++)
        {
            for (int j = 0; j < TwoArray.GetLength(1); j++)
            {
                Console.Write($"{name} индекс элимента {i},{j} = ");
                TwoArray[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
        return TwoArray;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("\nДопускается  ввод числа больше 0.");
        goto loop1;
    }

}

//вывод массива

static void OutputArrayToConsole(double[,] TwoArray)
{
    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {

            Console.Write(TwoArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

// произведение
static double[,] CompositionToArray(double[,] TwoArray1, double[,] TwoArray2)
{
    double[,] TwoArray3 = new double [TwoArray1.GetLength(0),TwoArray2.GetLength(1)];
    for (int i = 0; i < TwoArray3.GetLength(0); i++)
        {
            for (int j = 0; j < TwoArray3.GetLength(1); j++)
            {
                TwoArray3[i, j] = 0;

                for (var k = 0; k <TwoArray1.GetLength(1); k++)
                {
                    TwoArray3[i, j] += TwoArray1[i, k] * TwoArray2[k, j];
                }
            }
        }

        return TwoArray3;

}


Console.WriteLine($"Произведение двух матриц");
var matrix1 = GetArrayConsole("Matrix1");
Console.WriteLine();
var matrix2 = GetArrayConsole("Matrix2");
Console.WriteLine();
Console.WriteLine("Matrix1");
OutputArrayToConsole(matrix1);
Console.WriteLine();
Console.WriteLine("Matrix2");
OutputArrayToConsole(matrix2);
Console.WriteLine();
var comp =CompositionToArray(matrix1,matrix2);
Console.WriteLine("Результирующая матрица");
OutputArrayToConsole(comp);

