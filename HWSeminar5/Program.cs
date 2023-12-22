
// ------------------
//Задача 1: Напишите программу, которая на вход принимает позиции элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание,
//что такого элемента нет.

Console.WriteLine("Введите число 1");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число 2");
int num2 = Convert.ToInt32(Console.ReadLine()); 

int[,] array = new int[3,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        System.Console.WriteLine();
    }
}
CreateArray();
if(num1 < 3 && num2 < 4)
{
    System.Console.WriteLine(array[num1,num2]);
}
else
{
    System.Console.WriteLine("Такого элемента нет");
}


// --------------------------
// Задача 3: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = new int[3,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        System.Console.WriteLine();
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

void FindeElementsArray()
{
    int minSum = 2147483647;  //Здесь указал максимально возможное число для int, как можно сделать проще?
    int isk = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        int sumElement=0;
    
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
            sumElement+= array[i,j];
        }
        if(minSum > sumElement)
        {
            minSum = sumElement;
            isk = i;
        }
    }
Console.WriteLine("Индекс строки с наименьшей суммой = " + isk);
}




CreateArray();
PrintArray();
FindeElementsArray();




//---------- Задача 2, не смог решить :(

int[,] array = new int[3,4];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        System.Console.WriteLine();
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}

// void SwapArray()
// {
//     int I = 0;
//     int iMax = array.GetLength(0);
    
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
        
//             array[i,j] = array[]
        
//         }

// }


CreateArray();
PrintArray();
//SwapArray();
PrintArray();