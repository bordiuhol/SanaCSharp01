﻿// See https://aka.ms/new-console-template for more information

double a, b, c, d, x, y, z, r;
Console.WriteLine("a:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("b:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("c:");
c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("d:");
d = Convert.ToDouble(Console.ReadLine());
x = (a + 2 * b - c + d) / (c * d) + (a + b) / (c - d) - a * a / (b * b);
Console.WriteLine($"x = {x}");
y = 5 * (a + b) * (c - d) / (1 / 2 * c) + d * d * ((a * a - b * b) / (b - a));
Console.WriteLine($"y = {y}");
z = (Double.Pow((x * x - 2 * x), 3) - 4 * (Double.Pow(x, 4) + 1)) * (1 - b) / (5 * a + 3 * b);
Console.WriteLine($"z = {z}");
r = (1 / 2 * a + 3 / 4 * b - 7 / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine($"r = {r}");