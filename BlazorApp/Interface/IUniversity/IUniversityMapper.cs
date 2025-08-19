using BlazorApp.Dto.UniversityDto;
using mptc.dgc.sample.infrastructure.Models;

namespace BlazorApp.Interface.IUniversity
{
    public interface IUniversityMapper
    {
        UniversityReadDto ToReadDto(University university);
    }
}
