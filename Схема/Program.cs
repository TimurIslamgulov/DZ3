Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
int m = 0, k = n - 1, i = 0, j = 0, temp = 1;
array[i, j] = temp;
while (temp < n * n)
{
    while (j < k)
    {
        temp++;
        j++;
        array[i, j] = temp;
    }
    while (i < k)
    {
        temp++;
        i++;
        array[i, j] = temp;
    }
    while (j > m)
    {
        temp++;
        j--;
        array[i, j] = temp;
    }
    m++;
    k--;
    while (i > m)
    {
        temp++;
        i--;
        array[i, j] = temp;
    }
}
for (i = 0; i < n; i++)
{
    for (j = 0; j < n; j++)
    {
        Console.Write("{0}\t", array[i, j]);
    }
    Console.WriteLine();
}

