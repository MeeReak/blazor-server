using BlazorApp.Dto.CertificateDto;
using mptc.dgc.sample.infrastructure.Models;

namespace BlazorApp.Interface.ICertificate
{
    public interface ICertificateMapper
    {
        CertificateReadDto ToReadDto(Certificate certificate);
    }
}
