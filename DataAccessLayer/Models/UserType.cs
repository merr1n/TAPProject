using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class UserType
    {
        public UserType(string type)
        {
           Type = type;
        }

        public UserType(int id, string type)
        {
            Id = id; Type = type;
        }

        public string Type { get; set; }
        public int Id { get; set; }

        [JsonIgnore]
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
