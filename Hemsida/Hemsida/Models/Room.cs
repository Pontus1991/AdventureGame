using System;
using System.ComponentModel.DataAnnotations;

namespace Hemsida.Models
{
    public class Room
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Room name is required.")]
        [StringLength(30, ErrorMessage = "Room name cannot be more than 30 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Floor is required.")]
        [Range(1, 99, ErrorMessage = "Floor must be between 0 and 100")]
        public int Floor { get; set; }

        [Required(ErrorMessage = "Size is required.")]
        [Range(1, 99, ErrorMessage = "Floor must be between 0 and 100")]
        public int Size { get; set; }
    }
}
