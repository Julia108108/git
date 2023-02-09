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