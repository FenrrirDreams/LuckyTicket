using System.Linq;

namespace LuckyTicket
{
    class Checker
    {
        private readonly IParser _parser;

        public Checker(IParser parser)
        {
            _parser = parser;
        }

        public bool IsNumberLucky(string number)
        {
            var digits = _parser.Parse(number);
            var halfCount = digits.Count() / 2;

            var firstSum = digits.Take(halfCount).Sum();
            var secondSum = digits.Skip(halfCount).Sum();

            return firstSum == secondSum;
        }
    }
}
