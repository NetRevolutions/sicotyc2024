using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("DRIVER", Schema = "SCT")]
    public class Driver : TrackingBase
    {
        [Key]
        public Guid DriverId { get; set; }
        public string? Ruc { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Img { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime? DocumentExpiration { get; set; }  
                
        public bool EnableIMO { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public DateTime? AntecedentesPolicialesExpiration { get; set; }
        public DateTime? AntecedentesPenalesExpiration { get; set; }

        // Relation 1:1


        // Relation 1:*
        public List<DriverLicense>? DriverLicenses { get; set; }

        // Relation *:*

    }
}
