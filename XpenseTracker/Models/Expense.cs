using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XpenseTracker.Models
{
    public class Expense
    {
        public UInt64 Id { get; set; }
        public DateTime Date { get; set; }
        public ExpenseCategory Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
