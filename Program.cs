// 1. Calculating the area and circumference of a circle
Console.Write("Enter the radius :");
decimal radius = Convert.ToDecimal(Console.ReadLine());
decimal L, S;
L = 2 * (decimal)Math.PI * radius;
S = L/2 * radius;
Console.WriteLine($"S={S}\nL={L}");