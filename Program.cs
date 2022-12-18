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

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

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

double GetRandomNumberInRange(Random random,double minNumber, double maxNumber)

    return random.NextDouble() * (maxNumber - minNumber) + minNumber;


int maxNum = numbers[0];
int minNum = numbers[0];

for (int i = 0; i < array.Length; i++)
{
    if (numbers[i] > maxNum)
    {
        maxNum = numbers[i];
    }
    if (numbers[i] < minNum)
    {
        minNum = numbers[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxNum - minNum}");






















/// 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.




// 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Сумма квадратов двух сторон больше квадрата третьей


// 2.Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

// 3.Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

