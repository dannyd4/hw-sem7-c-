

int[,] CreateNew2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;

}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[,] CreateNew2dArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = Math.Round( (new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 1);//научиться выводить знаки после запятой в нужном количестве

    return newArray;

} 

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

double[] averageColumsNumber(int[,] array)
{
   // int[,] myArray = new int[array.GetLength(0), array.GetLength(1)];

    double[] sum = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[j] += array[i, j];
            if(i == array.GetLength(0)-1) 
                sum[j] = Math.Round(sum[j]/(i+1) , 1);
        }
    }
    return sum;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");

    }
}

// test 47 sem7 c# Задайте 2D массив размером m х n c случ вещественными числами.

/*
Console.Write("Введите количество строк массива m = ");
int rowsNumber = Convert.ToInt16(Console.ReadLine());

Console.Write("Введите количество столбцов массива n = ");
int columnsNumber = Convert.ToInt16(Console.ReadLine());

double[,] myarray2d = CreateNew2dArrayDouble(rowsNumber, columnsNumber, -10, 10);

Show2dArrayDouble(myarray2d);
*/


// test 50 sem7 c# 

/*
Console.WriteLine("Был создан массив: ");

int[,] myarray = CreateNew2dArray(4, 4, 0, 10);
Show2dArray(myarray);

Console.WriteLine("Введите стороку элемента row = ");
int rowsNumber = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите столбец элемента columns = ");
int columnsNumber = Convert.ToInt16(Console.ReadLine());

int maxNumberRow = myarray.GetLength(0);
int maxNumberColumns = myarray.GetLength(1);

if (rowsNumber > maxNumberRow
     || rowsNumber < 0
     || columnsNumber > maxNumberColumns
     || columnsNumber < 0) 
     {
         Console.WriteLine("Ты промазал брат! Нет элемента с такими индексами!");
     }
     
else Console.WriteLine(myarray[rowsNumber,columnsNumber]);
*/

//test 52 sem7 c#


Console.WriteLine("Был создан массив: ");

int[,] myarray = CreateNew2dArray(4, 4, 0, 10);
Show2dArray(myarray);

Console.WriteLine("Среднее арифметическое каждого столбца: ");
ShowArray(averageColumsNumber(myarray));
