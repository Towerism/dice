using PGC.Dice.Interfaces;

namespace PGC.Dice
{
    public class Die
    {
        private readonly IRandom _random;

        public Die(IRandom random)
        {
            _random = random;
        }

        public int Roll()
        {
            return _random.GetNumber();
        }
    }
}