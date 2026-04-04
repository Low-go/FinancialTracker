using System.Text.Json.Serialization;

namespace FinanceTracker.Shared.Models
{
    public class StockQuote
    {

        public string Symbol { get; set; }
        [JsonPropertyName("c")]
        public decimal Price { get; set; }
        [JsonPropertyName("d")]
        public decimal Change { get; set; }
        [JsonPropertyName("dp")]
        public decimal ChangePercent { get; set; }

    }
}
