namespace BoardGameHub.Core.Models.Pagination
{
    public class PaginatedList
    {
        public int TotalItems { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public string Sorting { get; set; }

        public PaginatedList()
        {

        }
        public PaginatedList(int totalItems, int page, int pageSize = 8)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / pageSize);
            int currentPage = page;

            int startPage = 1;
            int endPage = totalPages;

            TotalItems = totalItems;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
        }
    }
}
