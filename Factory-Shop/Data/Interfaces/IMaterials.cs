using Factory_Shop.Data.Models;

namespace Factory_Shop.Data.Interfaces
{
    public interface IMaterials
    {
        IEnumerable<Materials> AllMaterials { get; }

        Materials GetMaterials(int CarId);

    }
}
