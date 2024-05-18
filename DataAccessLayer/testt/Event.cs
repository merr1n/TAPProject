using System;
using System.Collections.Generic;

namespace DataAccessLayer.testt;

public partial class Event
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int TypeId { get; set; }

    public Guid OrganizerId { get; set; }

    public DateTime Date { get; set; }

    public decimal Price { get; set; }

    public virtual User Organizer { get; set; } = null!;

    public virtual EventType Type { get; set; } = null!;
}
