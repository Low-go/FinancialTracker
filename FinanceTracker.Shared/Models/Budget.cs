using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Shared.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public int Month {  get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
