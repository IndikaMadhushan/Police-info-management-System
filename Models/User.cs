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
        public string Name { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[]? ProfilePicture { get; set; }


        public User(int userId, string username, string role, string name, string nic,
                string address, string job, string phone, string email, DateTime? dob, byte[] profilePicture)
        {
            UserId = userId;
            Username = username;
            Role = role;
            Name = name;
            NIC = nic;
            Address = address;
            Job = job;
            Phone = phone;
            Email = email;
            DateOfBirth = dob;
            this.ProfilePicture = profilePicture;
        }

    }
}
