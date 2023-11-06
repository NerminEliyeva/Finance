using System.ComponentModel.DataAnnotations;

namespace Finance.Domain.Entity
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string? CurrencyCode { get; set; }
        public string? CurrencyName { get; set; }
    }
}
