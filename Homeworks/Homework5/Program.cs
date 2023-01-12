// 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] CreateRandomArray (int size,int minValue, int maxValue)
// {
// int[] myArray = new int[size];

// if( minValue<100 || minValue>999 )
// {
//     minValue = 100;
// }

// if(maxValue > 999 || minValue<100)
// {
//     maxValue = 999;
// }

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

// void EvenNumbers (int[] array )
// {
// int CountEven = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(array[i] % 2 == 0 )
//     {
//      CountEven ++;
//     }
// }
// Console.Write($"Количество четных чисел ->:{CountEven}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное трёхзначное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное трёхзначное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое значение отрезка:");

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);

// EvenNumbers(newArray);

// 2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// void SummUneven (int[] array )
// {
// int CountUneven = 0;

// for(int i = 0; i < array.Length; i++)
// {
//     if(i % 2 == 1 )
//     {
//      CountUneven += array[i];
//     }
// }
// Console.Write($"Сумма чисел нечетных позиций ->:{CountUneven}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);
// ShowArray(newArray);

// SummUneven (newArray);


// 3.Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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

// void MaxDifference (int[] array )
// {
// int MaxDif = array.Max() - array.Min();
// Console.Write($"Сумма чисел нечетных позиций ->:{MaxDif}");
// }

// Console.WriteLine("Введите размер массива:");
// int lenght = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимально возможное значение элемента массива:");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимально возможное значение элемента массива:");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] newArray = CreateRandomArray(lenght,min,max);

// ShowArray(newArray);

// MaxDifference(newArray);
