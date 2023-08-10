using Factory_Shop.Data.Interfaces;
using Factory_Shop.Data.Models;

namespace Factory_Shop.Data.Mocks
{
    public class MockCategory : IMatCategory
    {
        //Temporay storage of category data
        public IEnumerable<Category> AllCategory
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Сипучі матеріали", Desc = "Сипучі матеріали. Без них неможливе створення" +
                    " багатьох інших, більш складних матеріалів, які повсякденно Використовуються в будівництві; не можливо " +
                    "створити фундамент або оформити садові доріжки..."},
                    new Category {CategoryName ="Бетонні матеріали", Desc = "Суміш, що складається з в'яжучої речовини, " +
                    "великого й дрібного запоповнювачів і води до затверднення має назву бетонної суміші . Бетонна суміш" +
                    " являє собою пластично-в’язку масу, яка порівняно легко займає будь-яку форму, а потім самовільно " +
                    "переходить у каменеподібний стан."}
                };
            }
        }
    }
}
