﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.testt;

public partial class EventType
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
