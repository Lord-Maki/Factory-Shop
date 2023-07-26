using Factory_Shop.Data.Models;

namespace Factory_Shop.Models
{
    public class MatListViewModel
    {
        public MatListViewModel()
        {
        }
        // модель для матеріалів
        public IEnumerable<Materials>? AllMaT { get; set; }
        public string? MatCategory { get; set; }

        //моодель пагінації
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }

        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set; }

       

        public MatListViewModel(int totalItems, int page, int pageSize = 4)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
            int currentPage = page;

            int startPage = currentPage - 3;
            int endPage = currentPage + 3;

            if (startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }

            if (endPage > totalPages)
            {
                endPage = totalPages;
                if (endPage > 3)
                {
                    startPage = endPage - 3;
                }
            }

            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
        }
    }

}
