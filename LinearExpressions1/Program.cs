Console.WriteLine("Значення a =");
double a = double.Parse(Console.ReadLine());


Console.WriteLine("Значення b =");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Значення c =");
double c = double.Parse(Console.ReadLine());


Console.WriteLine("Значення d =");
double d = double.Parse(Console.ReadLine());
double x, y, z, r;

x = ((a + 2 * b - c + d) / (c * d)) + ((a + b) / (c - d)) - ((a * a) / (b * b));
y = (5 * (a + b) / (c - d) / (0.5 * c)) + (b * b * ((a * a - b * b) / (b - a)));
