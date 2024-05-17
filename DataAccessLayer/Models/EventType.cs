using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class EventType
    {
        public EventType(string type)
        {
            Type = type;
        }

        public EventType(int id, string type)
        {
            Id = id; Type = type;
        }
        public string Type { get; set; }
        public int Id { get; set; }
    }
}
