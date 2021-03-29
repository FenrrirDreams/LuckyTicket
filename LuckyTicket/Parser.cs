using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LuckyTicket
{
    class Parser : IParser
    {
        private const int minAcceptableLength = 1;
        private const int maxAcceptableLength = 1000;

        private readonly int _minLength;
        private readonly int _maxLength;
        private readonly string _pattern;

        public Parser(int minLength, int maxLength)
        {
            if (minLength < minAcceptableLength || minLength > maxLength || maxLength > maxAcceptableLength)
            {
                throw new Exception($"minLength mast be less or equal maxLength; min acceptable length - {minAcceptableLength}, max acceptable length - {maxAcceptableLength}");
            }
            _minLength = minLength;
            _maxLength = maxLength;
            _pattern = $"[0-9]{{{minLength},{maxLength}}}";
        }

        public IEnumerable<int> Parse(string number)
        {
            if (!Regex.IsMatch(number, _pattern))
            {
                throw new Exception($"The range from {_minLength} digit number to {_maxLength} digit number is expected.");
            }

            foreach (var digit in number.ToCharArray())
            {
                yield return int.Parse(digit.ToString());
            }
        }
    }
}
