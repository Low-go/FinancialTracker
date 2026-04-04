using FinanceTracker.Shared.Models;
using System.Text.Json;


namespace FinanceTracker.Api.Services
{
    public class MarketService
    {
        private readonly IConfiguration _config;
        private readonly string apiKey;
        private string QUERY_URL;

        // might need this, webhook secrete d78nmfpr01qp0fl5tgl0
        public MarketService()
        {
            apiKey = _config["FinnHub:ApiKey"];
            QUERY_URL = $"https://finnhub.io/api/v1/quote?symbol=SPY&token={apiKey}";
            Console.WriteLine($"Test to see API Key {_config}");
        }

        public async Task<StockQuote> CreateStockQuote(string url, string Symbol)
        {

            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url); // retunrs json
                string json = await response.Content.ReadAsStringAsync();
                StockQuote stockQuote = JsonSerializer.Deserialize<StockQuote>(json);
                return stockQuote;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
    }
}
