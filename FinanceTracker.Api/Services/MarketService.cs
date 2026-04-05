using FinanceTracker.Shared.Models;
using System.Text.Json;


namespace FinanceTracker.Api.Services
{
    public class MarketService
    {
        private readonly IConfiguration _config;
        private readonly string apiKey;
        private readonly HttpClient _client = new HttpClient();

        public MarketService(IConfiguration config)
        {
            _config = config;
            apiKey = config["FinnHub:ApiKey"];
            Console.WriteLine($"Test to see API Key {_config}");
        }

        public async Task<List<StockQuote>> CreateBaseStockQuote()
        {
            // S&P 500, Nasdaq Composite, Dow Jones, Apple, MicroSoft, Tesla, Interest Rates, US 10 year Treasury
            string[] BaseStocks = ["SPY", "QQQ", "DIA", "AAPL", "MSFT", "TSLA", "TNX"];
            List<StockQuote> baseStocks = new();

            try
            {
                for (int i = 0; i < BaseStocks.Length; i++)
                {
                    string queryURL = $"https://finnhub.io/api/v1/quote?symbol={baseStocks[i]}&token={apiKey}";
                    HttpResponseMessage response = await _client.GetAsync(queryURL); // returns json
                    string json = await response.Content.ReadAsStringAsync();
                    StockQuote stockQuote = JsonSerializer.Deserialize<StockQuote>(json);
                    stockQuote.Symbol = BaseStocks[i];
                    baseStocks.Add(stockQuote);
                }
                return baseStocks;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<StockQuote> CreateSingleStockQuote(string symbol) {
            try
            {
                
                string queryURL = $"https://finnhub.io/api/v1/quote?symbol={symbol}&token={apiKey}";
                HttpResponseMessage response = await _client.GetAsync(queryURL); // returns json
                string json = await response.Content.ReadAsStringAsync();
                StockQuote stockQuote = JsonSerializer.Deserialize<StockQuote>(json);
                stockQuote.Symbol = symbol;
                return stockQuote;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
        
    }
}
