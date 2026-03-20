
namespace FinanceTracker.Shared.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public int Month {  get; set; }
        public int Year { get; set; }
        public DateTime CreatedAt { get; set; }

        //references 
        public List<Transaction> TransactionList { get; set; } = new();
    }
}
