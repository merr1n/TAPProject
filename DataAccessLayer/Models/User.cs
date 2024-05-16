using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class User
    {

        public User() { }
        public User(string name, string email, string password, string type)
        {
            Name=name; Email=email; Password=password; Type=type;
        }

        public User(Guid id, string name, string email, string password, string type)
        {
            Id = id; Name=name; Email=email; Password=password; Type=type;
        }

        public string Name {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public Guid Id { get; set; }
    }
}
