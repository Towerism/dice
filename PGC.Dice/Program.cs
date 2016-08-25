using System;
using System.Collections.Generic;
using System.Text;
using PGC.Dice.Interfaces;

namespace PGC.Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Limit limit = new Limit(1, 6);
            IRandom random = new RandomRange(limit);
            Die die = new Die(random);
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
            Console.WriteLine(die.Roll());
        }
    }
}
