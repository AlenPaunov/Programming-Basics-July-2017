using System;

class Firm
{
    static void Main(string[] args)
    {
        var hoursNeeded = int.Parse(Console.ReadLine());
        var days = int.Parse(Console.ReadLine());
        var workers = int.Parse(Console.ReadLine());

        var hours = Math.Truncate(days * 0.9 * 8 + workers * 2.0 * days);
        if (hours >= hoursNeeded)
        {
            Console.WriteLine($"Yes!{hours - hoursNeeded} hours left.");
        }
        else
        {
            Console.WriteLine($"Not enough time!{hoursNeeded - hours} hours needed.");
        }

    }
}

