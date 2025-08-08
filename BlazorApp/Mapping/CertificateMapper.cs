using BlazorApp.Dto.CertificateDto;
using BlazorApp.Interface.ICertificate;
using mptc.dgc.sample.infrastructure.Models;
using Newtonsoft.Json;

namespace BlazorApp.Mapping
{
    public class CertificateMapper : ICertificateMapper
    {
        public CertificateReadDto ToReadDto(Certificate certificate)
        {
            var dto = new CertificateReadDto();
            dto.UniversityId = certificate.UniversityId;
            dto.StudentId = certificate.StudentId;
            dto.Number = certificate.Number;
            dto.NameKh = certificate.NameKh;
            dto.NameEn = certificate.NameEn;
            dto.Degree = certificate.Degree;
            dto.DegreeKm = certificate.DegreeKm;
            dto.Year = certificate.Year;
            dto.NationalId = certificate.NationalId;
            dto.Passport = certificate.Passport;
            dto.CertificateOaGuid = certificate.CertificateOaGuid;
            dto.WrapContent = certificate.WrapContent;
            dto.IsCertificateProduced = certificate.IsCertificateProduced;
            dto.CertificateVerifyUrl = certificate.CertificateVerifyUrl; 
            dto.CertificatePdfUrl = certificate.CertificatePdfUrl;
            dto.CertificateOadecryptKey = certificate.CertificateOadecryptKey;
            dto.IsSignedWithBlockchain = certificate.IsSignedWithBlockchain;
            dto.TargetHash = certificate.TargetHash;
            dto.MerkleRoot = certificate.MerkleRoot;
            dto.CreatedDate = certificate.CreatedDate;
            dto.DataJson = JsonConvert.DeserializeObject(certificate.RawDataJson).ToString();

            return dto;
        }
    }
}
