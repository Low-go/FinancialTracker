using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Shared.Models
{
    public class InvestmentSnapshot
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime SnapShotDate { get; set; }
    }
}
