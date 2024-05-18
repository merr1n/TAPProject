using DataAccessLayer.Repository;
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
    public class Event
    {
        public Event(string title, string location, Guid organizerId, DateTime date, string description, int typeId, decimal price, string status)
        {
            Title = title;
            Location = location;
            OrganizerId = organizerId;
            Date = date;
            Description = description;
            TypeId = typeId;
            Price = price;
            Status = status;
        }

        public Event(Guid id, string title, string location, Guid organizerId, DateTime date, string description, int typeId, decimal price, string status)
        {
            Id = id;
            Title = title;
            Location = location;
            OrganizerId = organizerId;
            Date = date;
            Description = description;
            TypeId = typeId;
            Price = price;
            Status = status;
        }

        public string Title { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public DateTime Date { get; set; }
        public Guid OrganizerId { get; set; }
        public decimal Price { get; set; }
        [Key]
        public Guid Id { get; set; }
        public virtual EventType Type { get; set; } = null!;
        [InverseProperty(nameof(User.Events))]
        [JsonIgnore]
        public virtual User Organizer { get; set; } = null!;
    }
}
