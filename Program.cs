//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input Value of {i + 1} element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Input Array size: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(length);
ShowArray(myArray);
*/





//-====================================================Array=================================================================-
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/

// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных элементов массива.

/*
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
           sum += array[i]; // sum = sum + array[i]

    return sum;
}            

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int result = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements is " + result);

*/

// 2. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
    

int[] ShowNegativeArray(int[] array)
{   
    for(int i = 0; i < array.Length; i++)
        
        array[i] = array[i] * -1; // array[i] *= -1

    return array;
}
Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int[] newMyArray = ShowNegativeArray(myArray);
ShowArray(newMyArray);

*/


// 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

bool Zamena(int[] array, int a)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == a)
            return true;
    }        
    return false;
      
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число которое нужной найтиж: ");
int a = Convert.ToInt32(Console.ReadLine ());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

bool result = Zamena(myArray,a);
Console.WriteLine(result);

*/

// 4. Задайте массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
    

int FindCound(int[] array,int num1, int num2) 
{
    int count = 0;
    if(num1 > num2)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]>=num1 && array[i]<=num2) count++;
    }
    return count;
}
Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

Console.Write("Input a number1: ");
int num1 = Convert.ToInt32(Console.ReadLine ());
Console.Write("Input a number2: ");
int num2 = Convert.ToInt32(Console.ReadLine ());

int result = FindCound(myArray, num1, num2);
Console.WriteLine(result);

*/

//---------------------------------------------------DZ5--------------------------------------------------------------------------

 // 1. Задайте массив заполненный случайными положительными трёхзначными числами. 
 //    Напишите программу, которая покажет количество чётных чисел в массиве.

/*

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(100, 1000);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int NumberOfEvenNumbers(int[] array)
{

    int count = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0)
            count++;
    return count;
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = NumberOfEvenNumbers(myArray);
Console.Write(result);

*/


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(1, 10);

    return array; 
}

void ShowArray(int[] array) 
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();    
}

int GetSum (int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i += 2)
        sum += array[i]; // sum = sum + array[i]
    return sum;

}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int result = GetSum(myArray);
Console.Write(result);

*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/*

double[] CreateDoubleArray(int size, int min, int max)
{
    double[] array = new double[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().Next(min, max) + new Random().NextDouble(), 2);
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write("[" + array[i] + "] ");
    }
    Console.WriteLine();
}

double MaxValue(double[] array)
{
    double maxValue = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxValue) maxValue = array[i];
    }
    return maxValue;
}

double Difference(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];
   
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < minValue) minValue = array[i];
        if(array[i] > maxValue) maxValue = array[i];
    }

    Console.WriteLine($"Maximum value is [{maxValue}]");
    Console.WriteLine($"Minimum value is [{minValue}]");

    double difference = maxValue - minValue;
    return difference;
}

Console.Write("Input Number of Elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible Value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible Value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateDoubleArray(size, min, max);
ShowArray(myArray);

double maxValue = MaxValue(myArray);

double diff = Difference(myArray);
Console.WriteLine($"The Difference between minValue and maxValue is [{diff}]");
*/


//------------------------------------------------Lekciya---------------------------------------------------------------------

// 1.Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();    
}


void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);

*/

// 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

/*

bool Triangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number c: ");
int num3 = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(num1, num2, num3);
Console.WriteLine(result);

*/


// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/*

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();    
}

int[] Fibonachi(int a, int b, int n)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i-2];
    }
    return array;
}

Console.Write("Введите количество чисел к выводу: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonachi(num1,num2, count);
ShowArray(result);

*/

//4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];
    
    for(int i = 0; i < size; i++)
        array [i] = new Random().Next(minValue, maxValue + 1);

    return array; 
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
        Console.WriteLine();    
}

int[] ArrayCopy(int[] array)
{
    int[] arrayCopy = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       arrayCopy[i] = array[i]; 
    }
    return arrayCopy;
}
    
Console.Write("Input a number of elements: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
int[] newMyArray = ArrayCopy(myArray);
ShowArray(newMyArray);

*/
//----------------------------------------------------------DZ6--------------------------------------------------------------------------

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*

void EvenCount(int M)
{
    int count = 0;
    Console.WriteLine("Ведите числа: ");
    for(int num = 0; num < M; num++)
    {
        int current = Convert.ToInt32(Console.ReadLine());
        if(current > 0)
           count++;
    }
    Console.WriteLine($"Общее количество чисел больше нуля: {count}");
}
Console.Write("Введите количество элементов: ");
int M = Convert.ToInt32(Console.ReadLine());
EvenCount(M);

*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*

void intersections (double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2); 
    double y = k2 * (b2 - b1) / (k1 - k2) + b2;
    if(k1 / k2 == b1 / b2)
        Console.WriteLine("the lines coincide.");
    else 
        if(k1 == k2)
            Console.WriteLine("No points of intersection of lines.");
        else
            Console.WriteLine($"Point of intersection of lines with coordinates: ({Math.Round(x, 2)}, {Math.Round(y, 2)})");
    
}
Console.Write("Input the element equation K1; ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the element equation K2; ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the element equation B1; ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the element equation B2; ");
double b2 = Convert.ToInt32(Console.ReadLine());
intersections(k1, k2, b1, b2);

*/



//-------------------------------------------2dArray----------------------------------------------------------------




//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

*/

// 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j.
// Выведите полученный массив на экран.

/*

int[,] Create2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = i + j;

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(rows,columns);
Show2dArray(myArray);

*/


//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void QuadSwitch(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
        for(int j = 0; j < array.GetLength(1); j += 2)
            array[i,j] *= array[i,j];   
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
QuadSwitch(myArray);
Show2dArray(myArray);

*/

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

/*

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int Diaganal(int[,] array)
{
    int sum = 0;                                                           // int sum = 0; 
    for(int i = 0; i < array.GetLength(0); i++)                            // for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {                                                                      //   sum += array[i,i]
        for(int j = 0; j < array.GetLength(1); j++)                        // return sum;
        {
            if(i == j)
                sum += array[i,j];
        }
    }
    return sum;
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
int sum = Diaganal(myArray);
Console.WriteLine($"sum is {sum}");

*/



// ------------------------------------------------DZ7--------------------------------------------------------------------------

/*

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = Math.Round(new Random().Next(minValue, maxValue) + new Random().NextDouble(), 2);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);

*/ 

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/*

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(min, max + 1);
    return array;
}

void Show2dArray(int[,] myArray)
{
    Console.Write("Input row Element: ");
    int rowElement = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column Element: ");
    int columnElement = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
            Console.Write(myArray[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();

    if (rowElement < myArray.GetLength(0) && columnElement < myArray.GetLength(1))
        Console.WriteLine($"The element at row {rowElement} and column {columnElement} is {myArray[rowElement, columnElement]}");
    else Console.WriteLine("No elemens!");
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(myArray);

*/

 //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/*

int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < columns; j++)
                array[i, j] = new Random().Next(1, 10);
    return array;
}

void ShowArray(int[,] myArray)
{
    for(int i = 0; i < myArray.GetLength(0); i++)
    {
        for(int j = 0; j < myArray.GetLength(1); j++)
            Console.Write(myArray[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageArray(int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            sum += array[i,j];
        average[j] = Math.Round(sum / array.GetLength(0), 2);
    }
    return average;
}

void ShowAverage(double[] average)
{
    for(int i = 0; i < average.Length; i++)
   
       Console.Write(average[i] + " ");
   
    Console.WriteLine(); 
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns);
ShowArray(myArray);
ShowAverage(AverageArray(myArray));

*/


//-------------------------------------------2dArray Next----------------------------------------------------------------

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array) 

{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void ReverseArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
        for(int i = 0; i < array.GetLength(0) - 1; i++)
            for(int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i,j];
                array[i,j] = array [j,i];
                array [j,i] = temp;
            }
    else
        Console.WriteLine("Reverse is imposible");   
} 

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ReverseArray(myArray);
Show2dArray(myArray);

*/

//Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SwitchRows(int[,] array, int row1, int row2)
{
    if(row1 != row2 && row1 < array.GetLength(0) && row2 < array.GetLength(0))
    {
        int temp = 0;
        for(int j = 0;j < array.GetLength(1); j++)
        {
            temp = array[row1,j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;

        }
    }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.Write("Введите номер первой строки: ");
int numrow1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер второй строки: ");
int numrow2 = Convert.ToInt32(Console.ReadLine());
SwitchRows(myArray, numrow1, numrow2);
Show2dArray(myArray);


//Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.