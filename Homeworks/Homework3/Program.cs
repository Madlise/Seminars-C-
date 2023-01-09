// 1.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  Console.WriteLine("Введите пятизначное число ");
//  int A = Convert.ToInt32(Console.ReadLine());
//  string L =  Convert.ToString(A);
// char[] ar = L.ToCharArray();
// Array.Reverse(ar);
// string s = new String(ar);
// int f = Convert.ToInt32(s);
// if( f == A )
// {
//   Console.WriteLine("ДА");  
// }
// else
// {
//     Console.WriteLine("НЕТ");  
// }

// 2.Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void distanse ( double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     if(x1!= 0 && x2!=0 && y1!= 0 && y2!= 0)
//     {
//         double k1 = x2 - x1;
//         double k2 = y2 - y1;
//         double k3 = z2 - z1;
//         double d = Math.Round(Math.Sqrt((k1*k1) + (k2*k2) + (k3*k3)),2);
//         Console.WriteLine(d);
//     }
//     else
//     {
//         Console.WriteLine("ошибка");
//     }
// }

// Console.WriteLine("Введите координаты х для первой точки:");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты y для первой точки:");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты z для первой точки:");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты х для второй точки:");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты y для второй точки:");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координаты z для второй точки:");
// double z2 = Convert.ToDouble(Console.ReadLine());
// distanse(x1,y1,z1,x2,y2,z2);

// 3.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void FindeQuart ( double N)
// {
//     for(double A = 1; A < N+1;  A++ )
//     { 
//         Console.WriteLine($" {A} * {A} = {A * A * A}");
//     }
// }

// Console.WriteLine("Введите число:");
// double N = Convert.ToDouble(Console.ReadLine());
// FindeQuart(N);