﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace sicotyc.entities.Models
{
    [Keyless]
    public class OptionByRole
    {        
        public Guid OptionId { get; set; }
        public string? Title { get; set; }
        public string? Icon { get; set; }
        public string? Url { get; set; }
        public int OptionOrder { get; set; }
        public int OptionLevel { get; set; }
        public Guid? OptionParentId { get; set; }
        public bool IsEnabled { get; set; }
    }
}
