﻿using money_tracker.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace money_tracker.Model
{
    public class Transaction
    {
        [DataType(DataType.Currency)]
        public int Amount { get; set; }
        public string Description { get; set; }
        public ISendable Sender { get; set; }
        public IReceivable Receiver { get; set; }
    }
}
