// (1) Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// (2) Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: 
// a[m,n]= m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// (3) Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты. 
// Нечетный индекс - тот, который при index % 2 == 1.

// (4) Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
 
Console.Write("Выберите задачу: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n == 1) Task46();
else if(n == 2) Task48();
else if(n == 3) Task49();
else if(n == 4) Task51();

void Task46()  // (1)
{
    Console.WriteLine("Введите m и n: ");
    int m = Convert.ToInt32(Console.ReadLine());  // задали размерность двумерного массива m х n
    int n = Convert.ToInt32(Console.ReadLine());  
    int[,] array2d = new int[m,n];  // []- одномерный; [,]-двумерный; [,,]-трехмерный массивы
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            array2d[i,j] = new Random().Next(-10,10);  //интервал задали произвольно
            Console.Write($"{array2d[i,j]} ");
        }
        Console.WriteLine();
    }
}

void Task48()  // (2)
{
    Console.WriteLine("Введите m и n: ");
    int m = Convert.ToInt32(Console.ReadLine());  
    int n = Convert.ToInt32(Console.ReadLine());  
    int[,] array2d = new int[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            array2d[i,j] = i+j;
            Console.Write($"{array2d[i,j]} ");
        }
    Console.WriteLine();
    }
}

void Task49()  // (3)
{
    Console.WriteLine("Введите m и n: ");
    int m = Convert.ToInt32(Console.ReadLine());  
    int n = Convert.ToInt32(Console.ReadLine());  
    int[,] array2d = new int[m,n]; 
    Console.WriteLine("Введите элементы массива в одну строку через запятую:"); // будем заполнять массив вручную
    for(int i=0; i<m; i++)     // для n=4 будем вводить четыре числа через запятую
    {
        string text = Console.ReadLine(); // считываем введеную строку чисел как строку символов string
        string[] array = text.Split(","); // Split используется для разбиения строки с разделителями на подстроки, 
        for(int j=0; j<n; j++)            // т.е. превращаем введенную стоку в одномерный массив 
        {
            array2d[i,j] = Convert.ToInt32(array[j]); //конвертируем каждый элемент одномерного массива array в число,
            if(i % 2 == 1 && j % 2 == 1)              //так построчно заполняем двумерный массив array2d (m=3 -> три строки)
                array2d[i,j] = array2d[i,j] * array2d[i,j];   
        }
    }
    Console.WriteLine();
void OutPut(int[,] array2d) //метод для вывода двумерного массива array2d
{
    for(int i=0; i<array2d.GetLength(0); i++)
    {
        for(int j=0; j<array2d.GetLength(1); j++)
            Console.Write(array2d[i,j]+",");
    Console.WriteLine();        
   } 
}
OutPut(array2d);
}

void Task51()  // (4)
{
    Console.WriteLine("Введите m и n: ");
    int m = Convert.ToInt32(Console.ReadLine());  
    int n = Convert.ToInt32(Console.ReadLine());  
    int[,] array2d = new int[m,n];  
    int sum = 0;   //инициировали переменную sum, чтобы посчитать сумму элементов массива по диагонали
    Console.WriteLine("Введите элементы массива в одну строку через запятую:");
    for(int i=0; i<m; i++)
    {
        string[] text = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
        for(int j=0; j<n; j++)
        {
            array2d[i,j] = Convert.ToInt32(text[j]);
            if(i == j)   // индексы на главной диагонали двумерного массива совпадают [0,0], [1,1],..
            sum += array2d[i,j];
        }
    }
    Console.WriteLine(sum);
}
