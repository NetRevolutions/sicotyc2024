﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Table("USER_DETAIL", Schema = "SCT")]
    public class UserDetail : TrackingBase
    {
        [Key]
        public Guid UserDetailId { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? DocumentType { get; set; }
        public string? DocumentNumber { get; set; }

        [ForeignKey(nameof(User))] // Navigational Properties
        public string? Id { get; set; }
        public User? User { get; set; }
    }
}
