// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки №1 по X:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки №1 по Y:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки №1 по Z:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки №2 по X:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки №2 по Y:");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки №2 по Z:");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Координаты точки №1: ({x1}, {y1}, {z1})");
Console.WriteLine($"Координаты точки №2: ({x2}, {y2}, {z2})");

Console.WriteLine($"Расстояние между точками: {SQRT(SQR(x2-x1) + SQR(y2-y1) + SQR(z2-z1))}");