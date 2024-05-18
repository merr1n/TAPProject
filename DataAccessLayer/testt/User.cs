using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DataAccessLayer.testt;

public partial class User
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int TypeId { get; set; }
    public virtual UserType Type { get; set; } = null!;

    [InverseProperty("User")]
    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
