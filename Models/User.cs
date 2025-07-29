using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public User(int userId, string username, string role)
        {
            UserId = userId;
            Username = username;
            Role = role;
        }

    }
}
