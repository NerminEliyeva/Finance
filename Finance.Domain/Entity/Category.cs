using System.ComponentModel.DataAnnotations;

namespace Finance.Domain.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? CategoryColor { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryIcon { get; set; }
        public int Type { get; set; }
        public int UserId { get; set; }

    }
}
