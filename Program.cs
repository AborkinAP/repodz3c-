Console.Clear();
// Задача № 19 Определение является ли пятизначное число полиндромом
// void culcPolindrom(int number)
// {
//     if(number / 10000 == number % 10 && number / 1000  % 10 == number % 100 /10)
//     {
//         Console.WriteLine($"{number} является полиндоромом");
//     }
//     else
//     {
//         Console.WriteLine($"{number} не является полиндромом");
//     }
// }

// Console.WriteLine("Введите пятизначное число ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 100000 && num > 9999)
//     {
//     culcPolindrom(num);
//     }
// else
// {
// Console.WriteLine($"{num} не является пятизначным числом");
// }

//Задача № 21 вычисление отрезка по 3 координатам
// void length(int Ax, int Ay, int Az, int Bx, int By, int Bz)
// {
//     double l = Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2) + Math.Pow(Bz-Az, 2));
//     Console.WriteLine($"Длина отрезка равна {l:f2}");
// }
// Console.WriteLine("Введите координаты первой точки ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// int Ay = Convert.ToInt32(Console.ReadLine());
// int Az = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки ");
// int Bx = Convert.ToInt32(Console.ReadLine());
// int By = Convert.ToInt32(Console.ReadLine());
// int Bz = Convert.ToInt32(Console.ReadLine());
// length(Ax, Ay, Az, Bx, By, Bz);

//Задача № 23 Таблица кубов чисел от 1 до n
// void kubNumbers(int number)
// {
//     int n = 1;
//     while (n <= number)
//     {
//         double kubNum = Math.Pow(n, 3);
//         Console.Write($"{kubNum}, ");
//         n++;
//     }
// }

// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// kubNumbers(num);

// Задача 25: Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в степень В.
// void exponent(int number1, int number2)
// {
//     int exp = 1;
//     for(int i = 0; i < number2; i++)
//     {
//         exp = exp * number1;
//     }
//     Console.WriteLine($"Число А в степени B равно {exp}");
// }


// Console.WriteLine("Введите число А ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// exponent(numberA, numberB);

// //Задача №27: Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

// void sumNumbers(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum = sum + number % 10;
//         number = number / 10;
//     } 
//     Console.WriteLine($"Сумма цифр равна {sum}");
// }
// Console.WriteLine("Введите число ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// sumNumbers(numberA);

//Задача 34 
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] array = CreateRandomArray(4, 100, 1000);
// ShowArray(array);

// void chetNumber(int[] array)
// {
//     int n = 0;
//     for (int i = 0; i < array.Length; i++)
//     {

//         if (array[i] % 2 == 0) n++;
//     }
//     Console.WriteLine($"{n} - четных числа");
// }
// chetNumber(array);

//Задача 36
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] array = CreateRandomArray(4, -100, 100);
// ShowArray(array);

// void sumNechetPos(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i = i + 2)
//     {
//         sum = sum + array[i];
//     }
//     Console.WriteLine($"{sum} - сумма сумма элементов на нечетных позициях");
// }
// sumNechetPos(array);

//Задача 38
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] array = CreateRandomArray(4, 0, 100);
// ShowArray(array);

// void diffMaxMin(int[] array)
// {
//     int max = array[0];
//     int min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     Console.WriteLine($"{max} - максимальное, {min} - минимальное");
//     Console.WriteLine($"{max - min} - разница между максимальным и минимальным элементом массива");
// }

// diffMaxMin(array);

//Задача 41
// int[] CreateArray()
// {
//     Console.WriteLine("Введите количество элементов массива");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {   
//         Console.WriteLine($"Введите {i+1} элемент массива");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

//  void countNumMoreZiro(int[] array)
//  {
//     int countNum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > 0) countNum++;
//     }
//     Console.WriteLine($"{countNum}  - количество введенных положительных элементов массива");
//  }

// int[] array = CreateArray();
// ShowArray(array);
// countNumMoreZiro(array);

// //Задача 43
// void crossline()
// {
//     Console.WriteLine("Введите b1");
//     double b1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите k1");
//     double k1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите b2");
//     double b2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите k2");
//     double k2 = Convert.ToInt32(Console.ReadLine());
//     if (k1 != k2)
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine($"{(x, y)}  - точка пересечения линий заданых функциями y = k1 * x + b1 и y = k2 * x + b2");
//     }
//     else
//     {
//         Console.WriteLine($"Линии параллельны");
//     }
// }
// crossline();

//Задача 47
// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());

// double[,] CreateDoubleArray(int a, int b, int minValue, int maxValue)
// {
//     double[,] array = new double[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
//         }
//     }
//     return array;
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }
// double[,] arr = CreateDoubleArray(rows, colums, -10, 10);
// PrintArray(arr);

// //Задача 50
// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значание диапазона генерируемых чисел для массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значание диапазона генерируемых чисел для массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] CreateArray(int a, int b, int minValue, int maxValue)
// {
//     int[,] array = new int[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElements(int[,] array, int number)
// {
//     int n = 0; //счетчик позиций в массиве, которые не совпадают с проверяемым числом
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             if (number == array[i, j])
//             {
//                 Console.Write($"{(i, j)}, ");
//             }
//             else
//             {
//                 n++;
//             }
//         }
//     }
//     if (n == array.GetLength(0) * array.GetLength(1))
//     {
//         Console.Write($"числа {number} нет в массиве");
//     }
//     else
//     {
//         Console.Write($"позиции числа {number} в массиве");
//     }
// }
// int[,] arr = CreateArray(rows, colums, min, max);
// PrintArray(arr);
// Console.WriteLine("Введите искомое число  в массиве: ");
// int num = Convert.ToInt32(Console.ReadLine());
// FindElements(arr, num);

// //Задача 52
// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значание диапазона генерируемых чисел для массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значание диапазона генерируемых чисел для массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] CreateArray(int a, int b, int minValue, int maxValue)
// {
//     int[,] array = new int[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void AvarageArifmColums(int[,] array)
// {
//     double n = 0;
//     int count = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             n = n + array[i, j];
//             count++;
//         }
//         Console.Write($"{(n / count):f1} ");
//         n = 0;
//         count = 0;
//     }
//     Console.Write(" - среднее арифметическое каждого столбца ");
// }
// int[,] arr = CreateArray(rows, colums, min, max);
// PrintArray(arr);
// AvarageArifmColums(arr);

//Задача 50
// Console.WriteLine("Введите количество строк массива: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значание диапазона генерируемых чисел для массива: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значание диапазона генерируемых чисел для массива: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] CreateArray(int a, int b, int minValue, int maxValue)
// {
//     int[,] array = new int[a, b];
//     for (int i = 0; i < a; i++)
//     {
//         for (int j = 0; j < b; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)

// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FindElements(int[,] array, int number)
// {
//     int n = 0; //счетчик позиций в массиве, которые не совпадают с проверяемым числом
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             if (number == array[i, j])
//             {
//                 Console.Write($"{(i, j)}, ");
//             }
//             else
//             {
//                 n++;
//             }
//         }
//     }
//     if (n == array.GetLength(0) * array.GetLength(1))
//     {
//         Console.Write($"числа {number} нет в массиве");
//     }
//     else
//     {
//         Console.Write($"позиции числа {number} в массиве");
//     }
// }
// 

//Задача 54
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значание диапазона генерируемых чисел для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значание диапазона генерируемых чисел для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int a, int b, int minValue, int maxValue)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortNumberForMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = array[i, j];
            int m = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    m = k;
                }
                // Console.Write($"{array[i, j]}");
            }
            int temp = 0;
            if (m != j)
            {
                temp = array[i, j];
                array[i, j] = array[i, m];
                array[i, m] = temp;
            }
        }
    }
    Console.WriteLine($"{string.Join(" ", array)}");
}

int[,] arr = CreateArray(rows, colums, min, max);
PrintArray(arr);
SortNumberForMax(arr);
PrintArray(arr);

//Задача 56
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значание диапазона генерируемых чисел для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значание диапазона генерируемых чисел для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int a, int b, int minValue, int maxValue)
{
    int[,] array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindMaxSumNumRow(int[,] array)
{
    int[] arr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumNum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumNum += array[i, j];
        }
        arr[i] = sumNum;
    }

    int minSum = arr[0];
    int numStr = 1;
    for (int k = 1; k < arr.Length; k++)
    {
        if (arr[k] < minSum)
        {
            minSum = arr[k];
            numStr = k + 1;
        }
    }
    Console.WriteLine($"{string.Join(" ", arr)}");
    Console.Write($"{numStr} - строка содержит минимальную сумму чисел");
}

int[,] arr = CreateArray(rows, colums, min, max);
PrintArray(arr);
FindMaxSumNumRow(arr);

//Задача 58
int[,] arr1 = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] arr2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };

void PrintArray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] MultTwoMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}

int[,] arr3 = MultTwoMatrix(arr1, arr2);
PrintArray(arr3);

//Задача 60
Console.WriteLine("Введите количество строк куба: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов куба: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение глубины куба: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значание диапазона генерируемых чисел для куба: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значание диапазона генерируемых чисел для куба: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] CreateArray(int a, int b, int c, int minValue, int maxValue)
{
    int[,,] array = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int k = 0; k < c; k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ");
            }
            Console.WriteLine();
        }
    }
}

void AddPosNum(int[,,] array)
{
    string[,,] arr = new string[array.GetLength(0), array.GetLength(1), array.GetLength(2)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] arr = CreateArray(rows, colums, depth, min, max);
PrintArray(arr);
AddPosNum(arr);