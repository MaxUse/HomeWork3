// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// System.Console.WriteLine("Введите число M:");
// int M = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число N:");
// int N = Convert.ToInt32(Console.ReadLine());

// string iskomoe = "";
// showResult(M,N);
// void showResult(int num1, int num2)
// {
//     if(num1<num2 && num1 != num2+1)
//     {
//         iskomoe += num1;
//         showResult(num1+1,num2);
//     }
//     else if(num1>num2 && num1+1 != num2)
//     {
//         iskomoe += num2;
//         showResult(num1, num2+1);
//     }
//     else
//     {
//         return;
//     }
// }
// Console.WriteLine(iskomoe);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// int AckermanFunction(int m, int n)
// {

//     if(m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n==0)
//     {
//         return AckermanFunction(m-1,1);
//     }
//     else if (m>0 && n>0)
//     {
//         return AckermanFunction(m-1, AckermanFunction(m, n-1));
//     }
//     else
//     {
//         System.Console.WriteLine("Числа должны быть неотрицательными");
//         return 0;
//     }
// }

// void AckermanPrint()
// {
//     int m = 1;
//     int n = 1;
//     int result = AckermanFunction(m,n);
//     System.Console.WriteLine("Значение функции Аккермана равно " + result);
// }

// AckermanPrint();


// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
