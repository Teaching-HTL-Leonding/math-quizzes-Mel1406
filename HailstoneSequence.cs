//===============part 1===============
/*int n = 0;
Console.Clear();
do
{
    Console.Write("Please enter your starting number: ");
    n = int.Parse(Console.ReadLine()!);
}while (n <= 0);

Console.Write($"The Hailstone sequence for the starting value {n} is: ");
while (n != 1)
{
    if (n % 2 == 0) {n = n / 2;}
    else {n = (n * 3) + 1;}
    Console.Write($"{n}, ");
}

int n = 0;
int length = 0;
Console.Clear();
do
{
    Console.Write("Please enter your starting number: ");
    n = int.Parse(Console.ReadLine()!);
}while (n <= 0);

Console.Write($"The length of the Hailstone sequence for the starting value {n} is: ");
while (n != 1)
{
    if (n % 2 == 0) {n = n / 2;}
    else {n = (n * 3) + 1;}
    length++;
}
Console.Write(length);*/

//===============part 2===============
int n1 = 0;
int n2 = 0;
int length1 = 0;
int length2 = 0;

const string ENTRY = "Please enter your starting number for the {0} sequence: ";
const string LONGER_SEQUENCE = "The {0} sequence is longer than the {1} sequence.";
const string FIRST = "first";
const string SECOND = "second";
Console.Clear();
do
{
    Console.Write(ENTRY, FIRST);
    n1 = int.Parse(Console.ReadLine()!);
} while (n1 <= 0);

do
{
    Console.Write(ENTRY, SECOND);
    n2 = int.Parse(Console.ReadLine()!);
} while (n2 <= 0);

while (n1 != 1)
{
    if (n1 % 2 == 0) { n1 = n1 / 2; }
    else { n1 = (n1 * 3) + 1; }
    length1++;
}

while (n2 != 1)
{
    if (n2 % 2 == 0) { n2 = n2 / 2; }
    else { n2 = (n2 * 3) + 1; }
    length2++;
}

if (length1 > length2) { System.Console.WriteLine(LONGER_SEQUENCE, FIRST, SECOND); }
else if (length2 > length1) { System.Console.WriteLine(LONGER_SEQUENCE, SECOND, FIRST); }
else { System.Console.WriteLine("Both sequences have the same length."); }