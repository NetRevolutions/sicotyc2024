using sicotyc.entities.Models;

namespace sicotyc.entities.DataTransferObjects
{
    public class DriverDto
    {
        public Guid DriverId { get; set; }
        public string? Ruc { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Img { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime? DocumentExpiration { get; set; }
        public ICollection<DriverLicense>? DriverLicenses { get; set; }
        public bool EnableIMO { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public DateTime? AntecedentesPolicialesExpiration { get; set; } = DateTime.MinValue;
        public DateTime? AntecedentesPenalesExpiration { get; set; } = DateTime.MinValue;
    }
}
