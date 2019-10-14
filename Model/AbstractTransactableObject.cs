using money_tracker.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money_tracker.Model
{
    public abstract class AbstractTransactableObject : ISendable, IReceivable
    {
        public List<Transaction> Transactions { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public int BalanceQuantity { get; set; }

        public void CreditAmount(int amount)
        {
            BalanceQuantity += amount;
        }

        public void DebitAmount(int amount)
        {
            BalanceQuantity -= amount;
        }
    }
}
