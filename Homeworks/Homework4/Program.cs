// // 1.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Exponent(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++)
//   {
//     result = result * numberA;
//   }
//     return result;
// }

//   Console.Write("Введите число A: ");
//   int numberA = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Введите число B: ");
//   int numberB = Convert.ToInt32(Console.ReadLine());

//   int exponent = Exponent(numberA, numberB);
//   Console.WriteLine(exponent);

// 2.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Sum (int N)
// {
//     int Len = Convert.ToString(N).Length;
//     int A = 0;
//     int result = 0;
//     for (int i = 0; i < Len; i++)
//     {
//       A = N - N % 10;
//       result = result + (N - A);
//       N = N / 10;
//     }
//     return result;
// }


// Console.Write("Введите число:");
// int N = Convert.ToInt32(Console.ReadLine());
// int sum = Sum(N);
// Console.WriteLine(sum);

// 3.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
// int[] myArray = new int[size];
// for(int i=0;i<size;i++)
// {
// myArray[i] = new Random().Next(minValue,maxValue+1);
// }
// return myArray;
// }

// void ShowArray (int[] array)
// {
// Console.WriteLine("Полученный массив ->:");
// for(int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i]+" ");
// }
// Console.WriteLine();
// }
// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// // int[] newArray = CreateRandomArray(lenght,min,max);
// // ShowArray(newArray);

// ShowArray(CreateRandomArray(lenght,min,max));



