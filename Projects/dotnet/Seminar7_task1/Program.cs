// Задача 48. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле:
// Amn = m + n. Выведите полученный массив на экран
// m = 3, n = 4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int InputIntNumber(string numberName)
{
    System.Console.Write($"Input {numberName} :");
   int intNumber = Convert.ToInt32(Console.ReadLine());
    return intNumber;}

void FillArray2D(int [,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j]=i+j;
    }
}
}

void PrintIntArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int  m =InputIntNumber("число m");
int  n =InputIntNumber("число n");
int [,] array2D= new int [m,n];
FillArray2D(array2D);
PrintIntArray2D(array2D);

//Еще одно решение:

//Console.WriteLine("Введите количестов строк: ");
//int m = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите количестов столбцов: ");
//int n = Convert.ToInt32(Console.ReadLine());

//int [,] array = new int [m, n] //создали размерность массива

//for (int i = 0; i < array.GetLength(0); i++) //i -строка, j - столбец
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array [i, j] = i + j;
//        Console.Write(array [i, j]);
//    }
//    System.Console.WriteLine();
//}

