using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Earn
{
    public class LocalEarn : IEarn
    {
        private decimal _percent;
        public LocalEarn(decimal percent)
        {
            _percent = percent;
        }
        public decimal Earn(decimal amount)
        {
            return _percent * amount;
        }
    }
}
