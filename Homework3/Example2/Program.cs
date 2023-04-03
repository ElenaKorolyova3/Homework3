// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("X координата первой точки");
int x1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Y координата первой точки");
int y1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("k координата первой точки");
int k1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("X координата второй точки");
int x2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Y координата второй точки");
int y2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("K координата второй точки");
int k2 = int.Parse(Console.ReadLine());

double skalyar = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((k2-k1),2));

System.Console.WriteLine(skalyar);