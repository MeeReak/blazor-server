using BlazorApp.Dto.CertificateDto;
using BlazorApp.Helper.Pagination;

namespace BlazorApp.Interface.ICertificate
{
    public interface ICertificateService
    {
        Task<ResponsePagingDto<CertificateReadDto>> GetCertificatePagedAsync(PaginationQueryParams param);
        Task<CertificateReadDto> GetCertificateByGuid(string id);
        Task UpdateCertificateAsync(CertificateReadDto dto);
    }
}
