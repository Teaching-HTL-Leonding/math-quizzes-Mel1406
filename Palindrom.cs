//===============part 1===============
/*const string PALINDROME = "Your number is{0} a palindrome.";

Console.Clear();

Console.Write("Please enter the number you want to check: ");
int number = int.Parse(Console.ReadLine()!);

int newNumber = 0;

if (number < 10) {System.Console.WriteLine(PALINDROME, "");}
else {
    for (int rest = number; rest != 0; rest /= 10)
    {
        newNumber = newNumber * 10 + rest % 10;
    }
    if (newNumber == number) {System.Console.WriteLine(PALINDROME, "");}
    else { System.Console.WriteLine(PALINDROME, " not");}
}*/

//===============part 2===============
int maxPalindrome = 0;

for (int i = 100; i < 1000; i++)
{
    for (int j = 100; j < 1000; j++)
    {
        int result = i * j;
        int reversedResult = 0;
        for (int rest = result; rest != 0; rest /= 10)
        {
            reversedResult = reversedResult * 10 + rest % 10;
        }
        if (result == reversedResult) { maxPalindrome = Math.Max(maxPalindrome, reversedResult); }
    }
}
System.Console.WriteLine($"The largest palindrome made of a 3-digit number is: {maxPalindrome}");