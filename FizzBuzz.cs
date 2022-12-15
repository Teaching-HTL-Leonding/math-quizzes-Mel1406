const string FIZZ = "FIZZ";
const string BUZZ = "BUZZ";
const string ENTRY = "Pleas enter the number for which multiple '{0}' should be issued: ";
Console.Clear();
Console.Write(ENTRY, FIZZ);
int a = int.Parse(Console.ReadLine()!);
Console.Write(ENTRY, BUZZ);
int b = int.Parse(Console.ReadLine()!);

for (int i = 1; i < 100; i++)
{   
    if (i % a == 0) {Console.Write("FIZZ");}
    if (i % b == 0) {Console.Write("BUZZ");}
    if (i % a != 0 && i % b != 0) {Console.Write(i);}
    System.Console.Write(" ");
}