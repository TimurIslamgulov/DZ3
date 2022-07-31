        Console.WriteLine("Введите целое число!");
        int number = Convert.ToInt32(Console.ReadLine());

        int[,] numarr = new int[number, number];
       
        int st_x=-1,st_y=-1,x,y; 
        int temp = 0; // переменная меняющегося числа забиваемого в массив
        int tnumber; // переменная меняющейся размерности в зависимости от номера спирали
        tnumber=number;
        // Определим количество спиралей и наличие точки.
        int nsp = tnumber/2; //количество спиралей
        bool point = false;  //наличие точки
        if (tnumber%2 != 0) point = true;
         Console.WriteLine(value: $"Выводим до: {number * number} количество спиралей {nsp} точка = {point}");
         // Заполняем спирали
         for(int sp=1;sp<=nsp;sp++)
         {
            st_x++; st_y++; //стартовое положение в массиве при начале ввода данных спирали
            x=st_x; y=st_y;
         
            tnumber=number-(sp-1);
            
            // Первая грань
            for (;x<tnumber;x++)
            {
                temp++;
                numarr[y,x]=temp;
            }
                x--; y++;
            //Вторая грань
            for (;y<tnumber;++y)
                {
                    temp++;
                    numarr[y,x]=temp;
                }
                    //Третья грань
                    y--; x--;
                    for (;x>=st_x;x--)
                    {
                         temp++;
                         numarr[y,x]=temp;
                     }
                        //Четвертая грань
                        x++;y--;
                        for (;y>st_y;--y)
                        {
                            temp++;
                            numarr[y,x]=temp;
                        }
         }
         //Устанавливаем точку
         if (point) numarr[++st_y,++st_x]=temp+1;
        // модуль вывода массива
        for (int i=0;i<number;i++)
        {
            for (int j=0;j<number;j++)
            {
                if (j<number-1) Console.Write(numarr[i,j]+ " ");
                    else Console.WriteLine(numarr[i,j]);
            }
        }
    