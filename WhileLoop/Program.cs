
Random rnd = new Random();
int cpuRandom;
    bool LoopActive = true; //bool - true/fals
while (LoopActive)
{
    cpuRandom = rnd.Next(1, 4);
    //Console.WriteLine($"cpu has generated {cpuRandom}.");
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userName = Int32.Parse(Console.ReadLine());

    if (userName == cpuRandom)
    {
        Console.WriteLine("Congratulation, you won!");
        break;
    }
    else
    {
       Console.WriteLine("Oops. Try again.");
    }
}

Console.WriteLine("Have a nice day!");