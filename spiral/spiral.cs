// спустя две недели мучений... :)

int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];
int x = 1;

for (int shift = 0; shift <= n - 2; shift++)
{
    for (int i = 0 + shift; i < n - shift; i++)
    {
        array[0 + shift, i] = x;
        x++;
    }
    x--;       
    for (int i = 0 + shift; i < n - shift; i++)
    {
        array[i, n - 1 - shift] = x;
        x++; 
    }  
    x--;
    for (int i = n - 1 - shift; i >= 0 + shift; i--)
    {
        array[n - 1 - shift, i] = x;
        x++;
    }
    x--;
    for (int i = n - 1 - shift; i > 0 + shift; i--)
    {
        array[i, 0 + shift] = x;
        x++;
    }      
}

for (int rows = 0; rows < n; rows++)
{
    for (int columns = 0; columns < n; columns++)
    {
        System.Console.Write($"{array[rows, columns]} ");
    }
    System.Console.WriteLine();
}