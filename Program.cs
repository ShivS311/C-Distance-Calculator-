// Avg Calc
#nullable disable

// Welcome
Console.Clear();
Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR!");

//Input
Console.Write("Enter Your x1 Number: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y1 Number: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter x2 Number: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter y2 Number: ");
double y2 = Convert.ToDouble(Console.ReadLine());

// Process
double value1 = (x2 - x1);
double value2 = (y2 - y1);

double powerX = Math.Pow(value1, 2);
double powerY = Math.Pow(value2, 2);

double average = Math.Sqrt(powerX + powerY);

// OutPut
Console.WriteLine($"Distance between the two points is: {average}");


