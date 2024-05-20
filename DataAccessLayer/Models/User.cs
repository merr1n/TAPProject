using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
        [Key]
        public Guid Id { get; set; }
        public virtual UserType Type { get; set; } = null!;
        [InverseProperty(nameof(Event.Organizer))]
        [JsonIgnore]
        public virtual ICollection<Event> Events { get; set; } = new List<Event>();
        [InverseProperty(nameof(Ticket.User))]
        public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
