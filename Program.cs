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
