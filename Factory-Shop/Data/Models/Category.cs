namespace Factory_Shop.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Desc { get; set; }
        public List<Materials> Materials { get; set; }


    }
}
