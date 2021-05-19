using CarvedRock.Api.Data.Entities;
using CarvedRock.Api.Repositories;
using GraphQL.Types;
using System.Reflection.Metadata;

namespace CarvedRock.Api.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(ProductReviewRepository reviewRepository)
        {
            Field(t => t.Id);
            Field(t => t.Name).Description("The name of the product");
            Field(t => t.Description);
            Field(t => t.IntroducedAt).Description("When the product was first introduced in the database");
            Field(t => t.PhotoFileName).Description("The url with the product photo");
            Field(t => t.Price);
            Field(t => t.Rating).Description("The (max 5) star customer rating");
            Field(t => t.Stock);
            Field<ProductTypeEnumType>("Type", "The type of the product");
            Field<ListGraphType<ProductReviewType>>(
                "reviews",
                resolve: context => reviewRepository.GetForProduct(context.Source.Id)
            );
        }
    }
}