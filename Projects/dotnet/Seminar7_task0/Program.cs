int[,] arr = new int[3, 4];
Random rnd = new Random();

System.Console.WriteLine(arr.Length);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = rnd.Next(100);
    }
}

for (int i = 0; i < arr.GetLength(0); i++)
{ 
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    System.Console.WriteLine();
}
// Console.WriteLine(String.Join(" ", arr.Cast<int>())); // это метод распечатывает массив в строчку

// а еще можно использовать этот метод foreach:
// foreach (var item in arr)
//{
    //System.Cosnole.Write(item + " ");
//}

