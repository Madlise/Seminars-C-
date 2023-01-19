// // 1.Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void AllNumbers (int N)
// {
//     if(N == 1)
//     {
//         Console.Write(1 + " ");
//     } 
//     if(N != 1)
//     {
//         AllNumbers(N - 1);
//         Console.Write(N + " ");
//     }
// }


// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// AllNumbers(N);

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void AllNumbers(int m, int n)
// {
//     if (n != m)
//     {
//         if (m > n)
//         {
//             AllNumbers(m - 1, n);
//             Console.WriteLine(m + " ");
//         }
//         else
//         {
//             AllNumbers(n - 1, m);
//             Console.WriteLine(n + " ");
//         }
//     }
//     else
//     {
//         Console.WriteLine(m + " ");
//     }
// }

// int CalculateSumm(int m, int n)
// {
//     int Sum = 0;
//     if(m == n)
//     {
//         Sum = m;
//     }
//     else
//     {
//         if(m > n)
//         {
//           Sum = m + CalculateSumm(m-1,n);
//         }
//         else
//         {
//          Sum = n + CalculateSumm(m, n-1);   
//         }
//     }
//     return Sum;
// }

// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// AllNumbers(M, N);

// int result = CalculateSumm(M, N);
// Console.WriteLine(result);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ack(int n,int m)
// {
// while(n != 0)
// {
//     if(m == 0)
//     {
//         m = 1;
//     }
//     else
//     {
//         m = Ack(n,m-1);
//     }
//     n --;
// }
// m ++;
// return m;
// }

// Console.WriteLine("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());

// int result = Ack(N, M);
// Console.WriteLine(result);
