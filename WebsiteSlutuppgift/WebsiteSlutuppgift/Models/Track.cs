using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteSlutuppgift.Models
{
    public class Track
    {   
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Room name is required.")]
        [StringLength(30, ErrorMessage = "Room name cannot be more than 30 characters.")]
        public string Name { get; set; }
    }
}
