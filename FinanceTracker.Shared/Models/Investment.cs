using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Shared.Models
{
    public class Investment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; }
        public decimal CurrentBalance { get; set; }
        public string TrackingType { get; set; }
        public string TickerSymbol { get; set; }
        public decimal GrowthRatePercentage { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
