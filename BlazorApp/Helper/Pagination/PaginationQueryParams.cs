namespace BlazorApp.Helper.Pagination
{
    public class PaginationQueryParams
    {
        public int Skip { get; set; } = 0;
        public int Top { get; set; } = 10;
        public string? Search { get; set; } = string.Empty;
        public bool? Filter { get; set; }
        public Guid? UniversityId { get; set; } = new Guid();

        public string? OrderBy { get; set; } = "CreateDate";
    }
}
