using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Shared.Models
{
    public class StockWatchlist
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public string? TickerSymbol { get; set; }
        public string DisplayName { get; set; } = string.Empty;
    }
}
