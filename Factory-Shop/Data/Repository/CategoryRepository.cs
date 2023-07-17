using Factory_Shop.Data.Interfaces;
using Factory_Shop.Data.Models;

namespace Factory_Shop.Data.Repository
{
    public class CategoryRepository : IMatCategory
    {
        private readonly AddDBContend addDBContend;
        public CategoryRepository(AddDBContend addDBContend)
        {
            this.addDBContend = addDBContend;
        }
        public IEnumerable<Category> AllCategory => addDBContend.Category;
    }
}
