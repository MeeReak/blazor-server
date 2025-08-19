using BlazorApp.Dto.UniversityDto;
using BlazorApp.Interface.IUniversity;
using mptc.dgc.sample.infrastructure.Models;

namespace BlazorApp.Mapping
{
    public class UniversityMapper : IUniversityMapper
    {
        public UniversityReadDto ToReadDto(University university)
        {
            var dto = new UniversityReadDto();
            dto.Id = university.Id;
            dto.Name = university.Name;

            return dto;
        }
    }
}
