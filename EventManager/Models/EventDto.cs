namespace EventManager.Models
{
        public class EventDto
        {
            public string Title { get; set; }
            public string Location { get; set; }
            public string Description { get; set; }
            public string Status { get; set; }
            public Guid OrganizerId { get; set; }
            public int TypeId { get; set; }
            public DateTime Date { get; set; }
            public decimal Price { get; set; }
        }
}
