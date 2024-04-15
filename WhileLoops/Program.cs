// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
Random rnd = new Random();
Console.WriteLine("Hello, World!");
int cpuRandom;
bool loopActive = true;
while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine("Make a guess. Enter a number 1-3");
    int userNumber = Int32.Parse(Console.ReadLine());
    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;
    }
    else
    {
        Console.WriteLine("Womp womp. Try again.");
    }
}
Console.WriteLine("Have a nice day!");