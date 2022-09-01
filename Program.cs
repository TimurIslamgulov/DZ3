// Выведите таблицу размером n x n заполненую числами от 1 до n^2 по спирали
// выходящей из левого верхнего угла и закручиной по часовой стрелки. 

int n = 5;
double pow = Math.Pow (n,2);
int count = Convert.ToInt32(pow);

int[] arr = new int [count];

void StepNumber(int n, int[] arr)
{
    int count = 0;
    int i = 0;
    double pow = Math.Pow (n,2);
    count = Convert.ToInt32(pow);
    while (i < count)
    {
        arr[i] = i + 1;
        // Console.Write(i + " ");
        i++;  
    }
}

// void PressArr(int[] arr)
// {
//     int index = 0;
//     while(index < arr.Length)
//     {

//         Console.Write(arr[index]+ " ");
//         index++;
//     }
// }


StepNumber(n, arr);
// PressArr(arr);


//Вывод  от 1 до 5
Console.SetCursorPosition(0, 5);
Console.Write(arr[0] + " ");
Console.SetCursorPosition(5, 5);
Console.Write(arr[1] + " ");
Console.SetCursorPosition(10, 5);
Console.Write(arr[2] + " ");
Console.SetCursorPosition(15, 5);
Console.Write(arr[3] + " ");
Console.SetCursorPosition(20, 5);
Console.Write(arr[4] + " ");

//Вывод  от 5 до 9
Console.SetCursorPosition(20, 7);
Console.Write(arr[5] + " ");
Console.SetCursorPosition(20, 9);
Console.Write(arr[6] + " ");
Console.SetCursorPosition(20, 11);
Console.Write(arr[7] + " ");
Console.SetCursorPosition(20, 13);
Console.Write(arr[8] + " ");

//Вывод  от 9 до 13
Console.SetCursorPosition(15, 13);
Console.Write(arr[9] + " ");
Console.SetCursorPosition(10, 13);
Console.Write(arr[10] + " ");
Console.SetCursorPosition(5, 13);
Console.Write(arr[11] + " ");
Console.SetCursorPosition(0, 13);
Console.Write(arr[12] + " ");

//Вывод  от 13 до 16
Console.SetCursorPosition(0, 11);
Console.Write(arr[13] + " ");
Console.SetCursorPosition(0, 9);
Console.Write(arr[14] + " ");
Console.SetCursorPosition(0, 7);
Console.Write(arr[15] + " ");

//Вывод  от 16 до 19
Console.SetCursorPosition(5, 7);
Console.Write(arr[16] + " ");
Console.SetCursorPosition(10, 7);
Console.Write(arr[17] + " ");
Console.SetCursorPosition(15, 7);
Console.Write(arr[18] + " ");

//Вывод  от 19 до 21
Console.SetCursorPosition(15, 9);
Console.Write(arr[19] + " ");
Console.SetCursorPosition(15, 11);
Console.Write(arr[20] + " ");

//Вывод  от 21 до 23
Console.SetCursorPosition(10, 11);
Console.Write(arr[21] + " ");
Console.SetCursorPosition(5, 11);
Console.Write(arr[22] + " ");

//Вывод  от 23 до 24
Console.SetCursorPosition(5, 9);
Console.Write(arr[23] + " ");

//Вывод  от 24 до 25
Console.SetCursorPosition(10, 9);
Console.Write(arr[24] + " ");



Console.SetCursorPosition(0, 20);




