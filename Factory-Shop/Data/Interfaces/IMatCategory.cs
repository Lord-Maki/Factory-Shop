using Factory_Shop.Data.Models;

namespace Factory_Shop.Data.Interfaces
{
    public interface IMatCategory
    {
        //Creating an interface for the category model
        IEnumerable<Category> AllCategory { get; }  

        // implamentation in ~/Data/Repository
    }
}
