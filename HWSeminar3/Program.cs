
// Console.WriteLine("Введите число от 1 до 100");
// int num = Convert.ToInt32(Console.ReadLine());


//  1.  Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество
//      элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
int sum = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101);
    Console.Write(array[i] + " ");

    if(array[i]>20 && array[i]<90)
    {
        sum = sum + 1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество заданных элементов в массиве = " + sum);


//   2.    Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество
//         чётных чисел в массиве.

int[] array = new int[10];
int sum = 0;

for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101);
    Console.Write(array[i] + " ");

    if(array[i]%2 == 0)
    {
        sum = sum + 1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве = " + sum);


//    3.     Задайте массив из вещественных чисел с ненулевой дробной частью. 
//           Найдите разницу между максимальным и минимальным элементов массива.

double[] array = new double[10];
double min = 13;
double max = 0;


for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().NextDouble();
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for(int j = 0; j<array.Length; j++)
{
    if(array[j]>max)
    {
        array[j] = max;
    }
    else if(array[j]<=min)
    {
        array[j] = min;
    }
}
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + (max-min));