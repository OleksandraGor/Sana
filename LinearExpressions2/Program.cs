

Console.WriteLine("Значення a =");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Значення b =");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Значення x =");
double x = double.Parse(Console.ReadLine());

Console.WriteLine("Значення m =");
double m = double.Parse(Console.ReadLine());

Console.WriteLine("Значення n =");
double n = double.Parse(Console.ReadLine());

double z2, y, z1;
z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);
z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + Math.Pow(10, -2) * (x - b);


Console.WriteLine($" z1 = {z1}");
Console.WriteLine($" z2 = {z2}");
Console.WriteLine($" y = {y}");
