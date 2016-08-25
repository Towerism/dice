namespace PGC.Dice
{
    public class Limit
    {
        public Limit(int lower, int upper)
        {
            Lower = lower;
            Upper = upper;
        }

        public int Lower { get; }
        public int Upper { get; }
    }
}