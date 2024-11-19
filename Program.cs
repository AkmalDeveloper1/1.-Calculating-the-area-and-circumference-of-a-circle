// 1. Calculating the area and circumference of a circle
Console.Write("Enter the radius :");
decimal radius = Convert.ToDecimal(Console.ReadLine());
decimal L, S;
L = 2 * (decimal)Math.PI * radius;
S = L / 2 * radius;
Console.WriteLine($"S={S}\nL={L}");

// 2. Currency converter
Console.Write("Sizda mavjud Qiymat :");
decimal qiymat = Convert.ToDecimal(Console.ReadLine());
Console.Write("Valyuta(UZS) kursi :");
decimal kurs = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine($"Natija :{qiymat * kurs} so'm");

// 3. Age calculation
Console.Write("Enter your year of birth :");
int yearOfBirth = Convert.ToInt32(Console.ReadLine());
int currentYear = DateTime.Now.Year;
int resulInDays = (currentYear - yearOfBirth) * 365;
Console.WriteLine(resulInDays);
// Valid for the current year