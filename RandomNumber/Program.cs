Random rnd  = new Random();

int myRandomNum;

int randomSum = 0;


for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11);
    Console.WriteLine($"My random number is {myRandomNum}");
    randomSum += myRandomNum;

}

Console.WriteLine($"random sum total:{randomSum}");