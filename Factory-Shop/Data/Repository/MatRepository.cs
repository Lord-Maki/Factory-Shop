using Factory_Shop.Data.Interfaces;
using Factory_Shop.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Factory_Shop.Data.Repository
{
    public class MatRepository : IMaterials
    {
        private readonly AddDBContend dbContend;

        public MatRepository (AddDBContend dbContend)
        {
            this.dbContend = dbContend;
        }
        public IEnumerable<Materials> AllMaterials => dbContend.Materials.Include(c => c.Category);

        public Materials GetMaterials(int MaterialId) => dbContend.Materials.FirstOrDefault(p => p.Id == MaterialId);
        
    }
}
