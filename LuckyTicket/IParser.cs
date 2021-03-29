using System.Collections.Generic;

namespace LuckyTicket
{
    interface IParser
    {
        IEnumerable<int> Parse(string number);
    }
}
