using BlazorApp.Dto.CertificateDto;
using BlazorApp.Helper.Pagination;
using BlazorApp.Interface.ICertificate;
using Microsoft.EntityFrameworkCore;
using mptc.dgc.sample.infrastructure.Models;
using Newtonsoft.Json;

namespace BlazorApp.Service
{
    public class CertificateService(SampleContext dbContext, ICertificateMapper mapper, IHttpContextAccessor contextAccessor) : ICertificateService
    {
        public async Task<CertificateReadDto> GetCertificateByGuid(string id)
        {
            var cert = await dbContext.Certificates
                .FirstOrDefaultAsync(x => x.CertificateOaGuid.ToString() == id);
            var mapped = mapper.ToReadDto(cert!);
            return mapped;
        }

        public async Task UpdateCertificateAsync(CertificateReadDto dto)
        {
            var cert = await dbContext.Certificates
                .FirstOrDefaultAsync(x => x.CertificateOaGuid.ToString() == dto.CertificateOaGuid.ToString());

            if (cert == null)
                throw new Exception("Certificate not found");

            cert.StudentId = dto.StudentId;
            cert.NationalId = dto.NationalId;
            cert.NameEn = dto.NameEn;
            cert.NameKh = dto.NameKh;
            cert.Degree = dto.Degree;
            cert.DegreeKm = dto.DegreeKm;
            cert.RawDataJson = JsonConvert.SerializeObject(dto.DataJson);

            await dbContext.SaveChangesAsync();
        }


        public async Task<ResponsePagingDto<CertificateReadDto>> GetCertificatePagedAsync(PaginationQueryParams param)
        {
            return await dbContext.Certificates.AsNoTracking().OrderBy(u => u.CreatedDate).ToPagedResultAsync(param.Skip, param.Top, mapper.ToReadDto, contextAccessor.HttpContext!);
        }
    }
}
