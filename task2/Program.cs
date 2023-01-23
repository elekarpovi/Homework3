//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

System.Console.WriteLine("Введите координаты точки A: x, y, z.");
System.Console.Write("x = ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("z = ");
double z1 = Convert.ToDouble(Console.ReadLine());


System.Console.WriteLine("Введите координаты точки B: x, y, z.");
System.Console.Write("x = ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("z = ");
double z2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Round((Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2))),2);

System.Console.WriteLine($"Расстояние между точками = {distance} ");