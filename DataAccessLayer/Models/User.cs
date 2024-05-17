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
        public User(string name, string email, string password, int typeId)
        {
            Name=name; Email=email; Password=password; TypeId=typeId;
        }

        public User(Guid id, string name, string email, string password, int typeId)
        {
            Id = id; Name=name; Email=email; Password=password; TypeId=typeId;
        }

        public string Name {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int TypeId { get; set; }
        public Guid Id { get; set; }
    }
}
