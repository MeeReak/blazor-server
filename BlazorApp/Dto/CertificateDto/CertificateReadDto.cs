namespace BlazorApp.Dto.CertificateDto
{
    public class CertificateReadDto
    {
        public int Id { get; set; }

        public Guid UniversityId { get; set; }

        public string StudentId { get; set; } = string.Empty;

        public string Number { get; set; } = string.Empty;

        public string NameKh { get; set; } = string.Empty;

        public string NameEn { get; set; } = string.Empty;

        public string Degree { get; set; } = string.Empty;

        public string DegreeKm { get; set; } = string.Empty;

        public string Year { get; set; } = string.Empty;

        public string NationalId { get; set; } = string.Empty;

        public string Passport { get; set; } = string.Empty;

        public Guid CertificateOaGuid { get; set; }

        public string DataJson { get; set; } = string.Empty;

        public string WrapContent { get; set; } = string.Empty;

        public bool IsCertificateProduced { get; set; }

        public string CertificateVerifyUrl { get; set; } = string.Empty;

        public string CertificatePdfUrl { get; set; } = string.Empty;

        public string CertificateOadecryptKey { get; set; } = string.Empty;

        public bool IsSignedWithBlockchain { get; set; }

        public string TargetHash { get; set; } = string.Empty;

        public string MerkleRoot { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; }
    }
}
