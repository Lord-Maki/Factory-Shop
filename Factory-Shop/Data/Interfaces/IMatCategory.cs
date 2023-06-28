using Factory_Shop.Data.Models;

namespace Factory_Shop.Data.Interfaces
{
    public interface IMatCategory
    {
        IEnumerable<Category> AllCategory { get; }  

    }
}
