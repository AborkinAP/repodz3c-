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
void exponent(int number1, int number2)

{
    
    for(int i = 1; i <= number2; i++)
    {
        number1 = number1 * number1;
    }
}


Console.WriteLine("Введите число А ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberB = Convert.ToInt32(Console.ReadLine());

exponent(numberA, numberB);