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
z = (Math.Pow((x * x - 2 * x), 3) - 4 * ((x * x * x * x) + 1) * (1 - b)) / (5 * a + 3 * b);
r = ((0.5 * a + ((3 / 4) / 4) * b - (7 / 5) / 5) / (3 * c + 1)) + (1 / (a - c));

Console.WriteLine($" x = {x}");
Console.WriteLine($" y = {y}");
Console.WriteLine($" z = {z}");
Console.WriteLine($" r = {r}");