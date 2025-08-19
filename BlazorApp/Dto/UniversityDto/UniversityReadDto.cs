namespace BlazorApp.Dto.UniversityDto
{
    public class UniversityReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameKh { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public string LogoUrl { get; set; }
        public string Email { get; set; }
    }
}
