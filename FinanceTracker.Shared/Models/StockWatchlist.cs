using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceTracker.Shared.Models
{
    public class StockWatchlist
    {
        public int Id { get; set; }
        public string TickerSymbol { get; set; }
        public string DisplayName { get; set; }
    }
}
