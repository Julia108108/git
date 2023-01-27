// Массив. возвращение значений

int[] InputArray()
{
    System.Console.WriteLine("n --> ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] a = new int[n];

    for (int i = 0; i < n; i++)
    { 
        System.Console.WriteLine("--> ");
        a[i] = Convert.ToInt32(Console.ReadLine());  
    }

    return a;
}

int[] a = IntputArray();
for (int i = 0; i < a.Length; i++)
{
    System.Console.WriteLine(a[i]);
}