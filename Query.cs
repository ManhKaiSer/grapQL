using graphQLTest.DatabaseAsset;
using HotChocolate.Data.Sorting;
using HotChocolate.Resolvers;

namespace graphQLTest
{
    public class Query
    {
        public string Hello(string name = "World")
        => $"Hello, {name}!";

        [UsePaging]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Asset> GetAssets(AssetDbContext context, IResolverContext resolverContext)
            => resolverContext.ArgumentKind("order") is ValueKind.Null ?
            context.Asset.OrderBy(t => t.Price) : context.Asset;
    }

    public class AssetSortingInputType : SortInputType<Asset>
    {
        protected override void Configure(ISortInputTypeDescriptor<Asset> descriptor)
        {
            descriptor.BindFieldsExplicitly();
            descriptor.Field(t => t.Price);
        }
    }
}
