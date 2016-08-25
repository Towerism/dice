using System;
using PGC.Dice.Interfaces;

namespace PGC.Dice
{
    public class RandomRange : IRandom
    {
        private readonly Random _random;
        private readonly Limit _limit;

        public RandomRange(Limit limit)
        {
            _limit = limit;
            _random = new Random();
        }

        public int GetNumber()
        {
            int lower = _limit.Lower;
            int upper = _limit.Upper + 1;
            return _random.Next(lower, upper);
        }
    }
}