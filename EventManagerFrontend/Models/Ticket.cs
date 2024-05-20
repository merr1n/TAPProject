using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EventManagerFrontend.Models
{
    public class Ticket
    {
        public Ticket() { }
        public Ticket(Guid userId, Guid eventId)
        {
            UserId = userId;
            EventId = eventId;
        }

        public int Id { get; set; }
        public Guid UserId { get; set; }
        public Guid EventId { get; set; }
        [JsonIgnore]

        public virtual Event Event { get; set; } = null!;

        [JsonIgnore]
        public virtual User User { get; set; } = null!;
    }
}
