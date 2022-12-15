Console.Clear();
Console.Write("Please enter your first value: ");
double value1 = double.Parse(Console.ReadLine()!);
Console.Write("Please enter your second value: ");
double value2 = double.Parse(Console.ReadLine()!);
Console.Write("Please enter your third value: ");
double value3 = double.Parse(Console.ReadLine()!);
double value3Rounded = Math.Round(value3Rounded, 2);

if (value1 + value2 == value3) { System.Console.WriteLine($"{value1} + {value2} = {value3Rounded}"); }
else if (value1 - value2 == value3Rounded) { System.Console.WriteLine($"{value1} - {value2} = {value3Rounded}"); }
else if (value2 - value1 == value3Rounded) { System.Console.WriteLine($"{value2} - {value1} = {value3Rounded}"); }
else if (value1 * value2 == value3Rounded) { System.Console.WriteLine($"{value1} * {value2} = {value3Rounded}"); }
else if (value1 / value2 == value3Rounded) { System.Console.WriteLine($"{value1} / {value2} = {value3Rounded}"); }
else if (value2 / value1 == value3Rounded) { System.Console.WriteLine($"{value2} / {value1} = {value3Rounded}"); }
else if (Math.Pow(value1, value2) == value3Rounded) { System.Console.WriteLine($"{value1} ^ {value2} = {value3Rounded}"); }
else if (Math.Pow(value2, value1) == value3Rounded) { System.Console.WriteLine($"{value2} ^ {value1} = {value3Rounded}"); }
else if (value1 % value2 == value3Rounded) { System.Console.WriteLine($"{value1} % {value2} = {value3Rounded}"); }
else if (value2 % value1 == value3Rounded) { System.Console.WriteLine($"{value2} % {value1} = {value3Rounded}"); }
else { System.Console.WriteLine("No valid match found with those numbers."); }