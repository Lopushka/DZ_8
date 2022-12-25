static void OutputArrayToConsole(int[,] TwoArray)
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

static void GetExclusiveNumbers(int[] myArray)
{
    Random random = new Random();
    bool repeat;
    for (int i = 0; i < myArray.Length;)
    {
        repeat = false;
        int numder = random.Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            if (myArray[j] == numder)
            {
                repeat = true;
                break;
            }
        }
        if (!repeat)
        {
            myArray[i] = numder;
            i++;
        }
    }
}

Console.WriteLine("Задайте размер массива.");
loop1:
Console.WriteLine("ИИии Помните! Максимальное колличество неповторяющихся  двузначных чисел 91.");

Console.Write("\nРазмер по вертикали число больше 0: ");
int namderY = Convert.ToInt32(Console.ReadLine());
Console.Write("\nРазмер по горизонтали число больше 0: ");
int namderX = Convert.ToInt32(Console.ReadLine());
Random random = new Random();


if (namderY > 0 && namderX > 0 && namderX * namderY <= 91)
{
    int[,] TwoArray = new int[namderY, namderX];
    int[] myArray = new int[namderY * namderX];
    GetExclusiveNumbers(myArray);
    int cnt = 0;

    for (int i = 0; i < TwoArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoArray.GetLength(1); j++)
        {
            TwoArray[i, j] = myArray[cnt];
            cnt++;
        }

    }



    OutputArrayToConsole(TwoArray);
}

else
{
    Console.WriteLine();
    Console.WriteLine("\nДопускается  ввод числа больше 0.");
    goto loop1;
}