// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

string userPIN;
    Console.WriteLine("Enter your PIN");

while (true)
{
    userPIN = Console.ReadLine();
    if (userPIN == "1234")
    { Console.WriteLine("Welcome!");
        break;
    }
    else
    {
        Console.WriteLine("Wrong PIN. Try again.");
    }
}