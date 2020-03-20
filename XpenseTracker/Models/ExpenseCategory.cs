using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XpenseTracker.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool UserDefined { get; set; }
    }
}
