namespace Finance.Application.Dto
{
    public class CreateCategoryDto
    {
        public string? CategoryColor { get; set; }
        public string? CategoryName { get; set; }
        public int CategoryIcon { get; set; }
        public int Type { get; set; }
        public int UserId { get; set; }

    }
}
