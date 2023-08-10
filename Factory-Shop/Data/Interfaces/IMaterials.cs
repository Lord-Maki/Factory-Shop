using Factory_Shop.Data.Models;

namespace Factory_Shop.Data.Interfaces
{
    public interface IMaterials
    {
        //Creating an interface for the material model
       IEnumerable<Materials> AllMaterials { get; }

        Materials GetMaterials(int MatId); // Getting specific material by Id

        // implamentation in ~/Data/Repository
    }
}
