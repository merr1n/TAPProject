using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EventManagerFrontend.Models
{
    public class EventType
    {
        public EventType(string type)
        {
            Type = type;
        }

        [JsonConstructor]
        public EventType(int id, string type)
        {
            Id = id; Type = type;
        }
        public string Type { get; set; }
        public int Id { get; set; }

        [JsonIgnore]
        public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
