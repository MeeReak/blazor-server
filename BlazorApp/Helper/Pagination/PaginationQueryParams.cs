﻿namespace BlazorApp.Helper.Pagination
{
    public class PaginationQueryParams
    {
        public int Skip { get; set; } = 0;
        public int Top { get; set; } = 10;
        public string? OrderBy { get; set; } = "CreateDate";
    }
}
