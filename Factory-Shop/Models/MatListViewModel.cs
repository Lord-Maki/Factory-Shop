using Factory_Shop.Data.Models;

namespace Factory_Shop.Models
{
    public class MatListViewModel
    {
        public IEnumerable<Materials>? AllMaT { get; set; }
        public string? MatCategory { get; set; }

    }
}
