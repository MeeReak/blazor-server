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
            cert.RawDataJson = dto.DataJson;

            await dbContext.SaveChangesAsync();
        }

        public async Task<ResponsePagingDto<CertificateReadDto>> GetCertificatePagedAsync(PaginationQueryParams param)
        {
            var query = dbContext.Certificates.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(param.Search))
            {
                query = query.Where(x => x.NameEn.Contains(param.Search));
            }

            if (param.Filter is not null)
            {
                query = query.Where(x => x.IsSignedWithBlockchain == param.Filter);
            }

            if (param.UniversityId is not null)
            {
                query = query.Where(x => x.UniversityId == param.UniversityId);
            }

            query = query.OrderBy(u => u.CreatedDate);

            return await query.ToPagedResultAsync(param.Skip, param.Top, mapper.ToReadDto, contextAccessor.HttpContext!);
        }

    }
}
