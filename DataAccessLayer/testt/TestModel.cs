using System;
using System.Collections.Generic;

namespace DataAccessLayer.testt;

public partial class TestModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
}
