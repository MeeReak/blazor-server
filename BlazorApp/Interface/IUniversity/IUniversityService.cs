using BlazorApp.Dto.UniversityDto;
using BlazorApp.Helper.Pagination;

namespace BlazorApp.Interface.IUniversity
{
    public interface IUniversityService
    {
        Task<ResponsePagingDto<UniversityReadDto>> GetUniversityPagedAsync(PaginationQueryParams param);
    }
}
