using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money_tracker.Common
{
    public interface ISendable
    {
        void DebitAmount(int amount);
    }
}
