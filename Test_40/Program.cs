//  Задача 40. На вход программы подаются три целых положительных числа. 
//Определить , является ли это сторонами треугольника. Если да, то вывести его площадь.

Console.Write("Введите строну а: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите строну b: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите строну c: ");
double c = double.Parse(Console.ReadLine());

if ((a + b > c) && (b + c > a) && (a + c > b))
{
    double p = (a + b + c) / 2;
    Console.WriteLine("Это треугольник");
    Console.WriteLine("Площадь треугольника: " + Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
}
else
{
    Console.WriteLine("Это не треугольник");
}
if (a + b <= c || a + c <= b || b + c <= a)
{
    Console.WriteLine("Треугольник не существует.\n");
}

Console.ReadKey();