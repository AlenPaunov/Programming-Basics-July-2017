using System;

class Axe
{
    static void Main(string[] args)
    {
        var input = int.Parse(Console.ReadLine());
        var colls = input * 5;
        //handle = (int)input/2
        //top part = input
        //bottom part = (int)input/2
        var star = '*';
        var line = '-';
        var a = 0;
        char lineA = '-';
        //first part
        for (a = 0; a < input; a++)
        {
            Console.WriteLine(new string(line, input * 3) + star + new string(line, a) + star + new string(line, input * 2 - 2 - a));
        }
        //handle part
        for (int b = 0; b < ((int)(input / 2)); b++)
        {
            Console.WriteLine(new string(star, input * 3) + star + new string(line, a-1) + star + new string(line, input * 2 - 2 - a+1));
        }
        //last part
        for (int c = 0; c < ((int)(input / 2)); c++)
        {
            if (c==(int)(input/2)-1)
            {
                lineA = '*';
            }
            
            Console.WriteLine(new string(line, input * 3 - c) + star + new string(lineA, a-1 + (2 * c)) + star + new string(line, input * 2 - 2 - a+1- c));
        }
    }
}

