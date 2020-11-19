using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteSlutuppgift.Models
{
    public class Table
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Table name is required.")]
        [StringLength(30, ErrorMessage = "Table name cannot be more than 30 characters.")]
        public string Name { get; set; }
    }
}
