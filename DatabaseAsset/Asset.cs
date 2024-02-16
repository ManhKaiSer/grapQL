using System;
using System.Collections.Generic;

namespace graphQLTest.DatabaseAsset;

public partial class Asset
{
    public long Id { get; set; }

    public string? Description { get; set; }

    public string? Color { get; set; }

    public string? ImageKey { get; set; }

    public string? Name { get; set; }

    public long? Price { get; set; }

    public string? Symbol { get; set; }

    public string? Slug { get; set; }

    public virtual AssetPrice? PriceNavigation { get; set; }
}
