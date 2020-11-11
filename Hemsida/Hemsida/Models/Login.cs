using System;
using System.ComponentModel.DataAnnotations;

namespace Hemsida.Models
{
    public class Login
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Booker firstname is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Booker lastname is required.")]
        public string PassWord { get; set; }
    }
}