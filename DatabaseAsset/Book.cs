using System;
using System.Collections.Generic;

namespace graphQLTest.DatabaseAsset;

public partial class Book
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? TimeCreated { get; set; }

    public DateTime? TimeUpdated { get; set; }
}
