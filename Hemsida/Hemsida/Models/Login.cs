using System;
using System.ComponentModel.DataAnnotations;

namespace Hemsida.Models
{
    public class Login
    {
        public int Id { get; set; }
    
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}