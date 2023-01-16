// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)
// {
// int[,] newArray = new int[rows,columns];
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = new Random().Next(minValue, maxValue+1);
// }
// }
// return newArray;
// }


// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n,min,max);
// Show2DArray(myArray);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// int[,] Create2DRandomArray ( int rows, int columns)
// {
// int[,] newArray = new int[rows,columns];
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = new Random().Next(0,100);
// }
// }
// return newArray;
// }


// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// void FindByPosition(int[,] array, int pos)
// {
//     if(pos > 99 || pos < 10)
//     {
//       Console.Write($"Позиция некорректна");  
//       break;
//     }
    
//     int row = pos / 10 - 1;
//     int column = pos % 10 - 1;

//   if(array.GetLength(0) > row && array.GetLength(1) > column )
//   {
//     int Val = array[row,column];
//     Console.Write($"Значение элемента = { Val } ");
//   }
//   else
//   {
//     Console.Write($"такого числа в массиве нет");
//   }  
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию элемента ");
// int pos = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);
// FindByPosition(myArray,pos );

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] Create2DRandomArray ( int rows, int columns)
// {
// int[,] newArray = new int[rows,columns];
// for(int i = 0; i < rows; i++)
// {
// for(int j = 0; j < columns; j++)
// {
// newArray[i,j] = new Random().Next(0,20);
// }
// }
// return newArray;
// }


// void Show2DArray(int[,] array)
// {
// for(int i = 0; i < array.GetLength(0); i++)
// {
// for(int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i,j]+" ");
// }
// Console.WriteLine();
// }
// }

// void MeanColumns(int[,] array)
// {
// for(int i = 0; i < array.GetLength(1); i++)
// {
//     int Sum = 0;
// for(int j = 0; j < array.GetLength(0); j++)
// {
//  Sum += array[j,i];
// }
// Console.Write($"Среднене значение столбца { i + 1 } = { (double) Sum / array.GetLength(0) } ");
// Console.WriteLine();
// }
// }

// Console.Write("Введите количество строк ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(m,n);
// Show2DArray(myArray);
// MeanColumns(myArray);