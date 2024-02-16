using System;
using System.Collections.Generic;

namespace graphQLTest.DatabaseAsset;

public partial class AssetPrice
{
    public long Id { get; set; }

    public string? Symbol { get; set; }

    public decimal? Price { get; set; }

    public virtual ICollection<Asset> Asset { get; set; } = new List<Asset>();
}
