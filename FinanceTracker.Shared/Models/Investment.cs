using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Shared.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public bool IsProtected { get; set; } = true;
        public decimal CurrentBalance { get; set; }
        public string TrackingType { get; set; } = string.Empty;
        public string? TickerSymbol { get; set; }
        public decimal GrowthRatePercentage { get; set; }
        public DateTime LastUpdated { get; set; }

        // references
        public List<InvestmentSnapshot> Snapshots { get; set; } = new();
    }
}
