using BlazorApp.Dto.UniversityDto;
using BlazorApp.Helper.Pagination;
using BlazorApp.Interface.IUniversity;
using Microsoft.EntityFrameworkCore;
using mptc.dgc.sample.infrastructure.Models;
using Newtonsoft.Json;

namespace BlazorApp.Service
{
    public class UniversityService(SampleContext dbContext, IUniversityMapper mapper, IHttpContextAccessor contextAccessor) : IUniversityService
    {
        public async Task<ResponsePagingDto<UniversityReadDto>> GetUniversityPagedAsync(PaginationQueryParams param)
        {
            var query = dbContext.Universities.AsNoTracking();

            return await query.ToPagedResultAsync(param.Skip, param.Top, mapper.ToReadDto, contextAccessor.HttpContext!);
        }
    }
}
