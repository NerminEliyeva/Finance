using System.ComponentModel.DataAnnotations;

namespace Finance.Domain.Entity
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int TypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Amount { get; set; }
        public int CurrencyId { get; set; }
        public int UserId { get; set; }
        public string? Description { get; set; }
    }
}
