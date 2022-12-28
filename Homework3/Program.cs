// 3 уровень - (по желанию) hardcore.

//Перед вами непростая и интересная задача. Попробуйте сделать блок-схему и если получится, то крепите к pull request.

// Выведите таблицу размером n×n, заполненную числами от 1 до n^2 

//   по спирали, выходящей из левого верхнего угла и закрученной по часовой стрелке, как показано в примере:
// Sample Input:

// 5
// Sample Output:

// 1 2 3 4 5
// 16 17 18 19 6
// 15 24 25 20 7
// 14 23 22 21 8
// 13 12 11 10 9


int N = Convert.ToInt32(Console.ReadLine()); // ввод размера квадратного массива
string[,] matrix = new string[N, N]; // Создаю массив в формате строки для красивого вывода на консоль.
int counter = 1; // первое число с которого начнется счет цифр в массиве. 
int length = matrix.GetLength(0); // инициализировал переменную с длиной массива
int x = -1; // инициализировал переменные x и y для управления проходом по спирали 
//-1 чтобы в конце не сбилось направление спирали, выяснил научно тыкальным путем. =) С нулем вылетаю за границы массива.
int y = 0;
for (int j = 0; j < matrix.GetLength(0) / 2; j++) // первый for делает круг и повторяет итерацию до конца массива
{
   // каждый круг массива значения длины уменьшаю таким образом, чтобы не попасть на уже записанные столбцы и строки...  
    for (int i = 0; i < length; i++) // прохожу массив вправо.  
    {
        x++; // проходим по всем элементам строки
        
        if (counter < 10) // условия для вывода "красивого" массива, повторяются в последующих for.
        {
            matrix[y, x] = "00" + Convert.ToString(counter); // записываю число в массив, повторяются в последующих for.

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter); // записываю число в массив, повторяются в последующих for.
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter); // записываю число в массив, повторяются в последующих for.
        }
        counter++; // Следующее число по порядку, повторяются в последующих for.
        
    }
    length--; // уменьшаю длину прохода чтобы записать значения вниз по колонке

    for (int i = 0; i < length; i++) // прохожу массив вниз. 
    {
        y++; // Прохожу по всем не записанным элементам столбца 
        
        if (counter < 10)
        {
            matrix[y, x] = "00" + Convert.ToString(counter);

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter);
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter);
        }    
        counter++;
    }

    for (int i = 0; i < length; i++) // прохожу массив влево. 
    {
        x--; // Прохожу по всем не записанным элементам строки 
       
        if (counter < 10)
        {
            matrix[y, x] = "00" + Convert.ToString(counter);

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter);
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter);
        }
        counter++;                        
    }
    length--;
    for (int i = 0; i < length; i++) // прохожу массив вверх.
    {
        y--; // Прохожу по всем не записанным элементам столбца 
        
        if (counter < 10) 
        {
            matrix[y, x] = "00" + Convert.ToString(counter);

        }
        else if (counter < 100)
        {
            matrix[y, x] = "0" + Convert.ToString(counter);
        }
        else
        {
            matrix[y, x] = Convert.ToString(counter);
        }
        counter++;                        
    }
}

if (matrix.GetLength(0) % 2 == 1) // ставлю последнюю цифру в том случае, если массив оказался не четным (а то получился бы в центре массива 0)
{
    if (counter < 10)
    {

        matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = "00" + Convert.ToString(counter);

    }
    else if (counter < 100)
    {
        matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = "0" + Convert.ToString(counter);
    }
    else
    {
        matrix[matrix.GetLength(1) / 2, matrix.GetLength(0) / 2] = Convert.ToString(counter);

    }
}


for (int i = 0; i < matrix.GetLength(0); i++) // Вывожу на консоль
{
    for (int j = 0; j < matrix.GetLength(0); j++)
        Console.Write($"{matrix[i, j]}  ");
    Console.WriteLine();
}