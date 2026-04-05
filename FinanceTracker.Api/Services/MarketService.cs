using FinanceTracker.Shared.Models;
using System.Text.Json;


namespace FinanceTracker.Api.Services
{
    public class MarketService
    {
        private readonly IConfiguration _config;
        private readonly string apiKey;
        private string queryURL;
        private readonly HttpClient _client = new HttpClient();

        public MarketService(IConfiguration config)
        {
            _config = config;
            apiKey = config["FinnHub:ApiKey"];
            queryURL = $"https://finnhub.io/api/v1/quote?symbol=SPY&token={apiKey}";
            Console.WriteLine($"Test to see API Key {_config}");
        }

        public async Task<StockQuote> CreateStockQuote(string symbol)
        {

            try
            {
                
                HttpResponseMessage response = await _client.GetAsync(queryURL); // retunrs json
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
