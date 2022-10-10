using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int x, y;
        string z;
        Console.WriteLine("Give me 2 numbers and a ... char");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());
        z = Console.ReadLine();
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(x.ToString() + y.ToString() + z);
        // According to docs Read() kinda... blocks return. And gives back ASCII. For example...
        // let's say I give A I should get 65 and then... Return again? So like 13. And then something...
        // It's confusing. 

        //x = Console.Read();   
        // y = Console.Read();
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(x.ToString() + y.ToString() + z);
        // Better way to read would be ReadLine with something - like Parse/TryParse like at the begining.

        //Casting and changing variables.
        Console.WriteLine("Changing something into something:");
        Console.WriteLine("int to string: {0}", x.ToString());
        Console.WriteLine("string to int (z+x): {0}", int.Parse(z) + x);
        Console.WriteLine("messing around with floats, give me one:");
        string a = Console.ReadLine();
        // probably depends on system settings. Had to use ',' instead of '.'
        float b = float.Parse(a);
        Console.WriteLine("Your float is: {0}", b);
        // lets cast that float to double
        double c = (double)b;
        Console.WriteLine(c);
        // now from double to int and get rid of the dot part
        int d = (int)c;
        Console.WriteLine(d);
        // Flow Control
        Console.WriteLine("Flow control. We'll need start, stop, continue and break ints\n(I'm not doing any exceptions here/fornow");
        int strt, stp, cnt, brk;
        Console.WriteLine("Give me start:");
        strt = int.Parse(Console.ReadLine());
        Console.WriteLine("Give me stop:");
        stp = int.Parse(Console.ReadLine());
        Console.WriteLine("Give me continue:");
        cnt = int.Parse(Console.ReadLine());
        Console.WriteLine("Give me break:");
        brk = int.Parse(Console.ReadLine());

        for (; strt < stp; strt++)
        {
            if (strt < cnt)
            {
                continue;
            }
            if (strt > brk)
            {
                break;
            }
            Console.WriteLine(strt);
        }
        // Case/Switch
        Console.WriteLine("Switch/case. Pick a number from 1 to 3, eventually use anything else to stop");
        bool thing = true;
        int number;
        do
        {
            if (int.TryParse(Console.ReadLine(), out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    default:
                        Console.WriteLine("Well... You chose death");
                        Console.WriteLine(number);
                        thing = false;
                        break;
                }
            }
            else 
            {
                Console.WriteLine("You ... are an idiot. You were supposed to pick numbers you dumbo");
                break;
            }

        } while (thing);
    }
}