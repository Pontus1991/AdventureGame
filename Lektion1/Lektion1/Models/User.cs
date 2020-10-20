using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lektion1.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int Age { get; set; }

        public User()
        {
            
        }
        public User(string userName, int age)
        {
            UserName = userName;
            Age = age;
        }
    }
}
