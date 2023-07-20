/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size)
{
   int[] array = new int [size];
   for(int i = 0; i < size; i++)
   array[i] = new Random().Next(100, 1000);
   return array;
}

void ShowArray(int[] array)
{
   for(int i=0; i < array.Length; i++)
   Console.Write(array[i] + " ");
   Console.WriteLine();
}

int EvenNumber(int[] array)
{
   int count = 0;
   for(int i=0; i < array.Length; i++)
   {
       if(array[i] % 2 == 0) 
       count += 1;
    }
    return count;
}
Console.Write("Enter the length of the array  ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(lenght);
int evenNumber = EvenNumber(myArray);
ShowArray(myArray);
Console.WriteLine("Number of even numbers in array "+ evenNumber);

*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
   for(int i=0; i < array.Length; i++)
   Console.Write(array[i] + " ");
   Console.WriteLine();
}

int Sum(int[] array)
{
   int sum = 0;
   for(int i=0; i < array.Length; i+=2)
       {
           sum += array[i];
       }
   return sum;
}

Console.Write("Enter the length of the array  ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(lenght, min, max);
int sum = Sum(myArray);
ShowArray(myArray);
Console.WriteLine("The sum of the odd values is "+ sum);

*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i=0; i < size; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
   for(int i=0; i < array.Length; i++)
   Console.Write(array[i] + " ");
   Console.WriteLine();
}

int Raz(int[] array)
{
int min = array[0];
int max = array[0];
for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
                max = array[i];
            if (min > array[i])
                min = array[i];
        }
        return max - min;
}

Console.Write("Enter the length of the array  ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the minimum value ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the maximum value ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
ShowArray(myArray);

int result = Raz(myArray);
Console.Write($"Difference between the maximum and minimum elements of the array: {result}");
