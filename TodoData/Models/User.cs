using System;

namespace TodoData
{
    public class User : Entity
    {
        public User()
        {
            
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}