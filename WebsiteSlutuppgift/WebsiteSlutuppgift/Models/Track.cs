using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteSlutuppgift.Models
{
    public class Track
    {   
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Track name is required.")]
        [StringLength(7, ErrorMessage = "Track name cannot be more than 7 characters.")]
        public string Name { get; set; }
    }
}
