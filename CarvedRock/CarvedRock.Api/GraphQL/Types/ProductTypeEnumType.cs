using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.GraphQL.Types
{
    public class ProductTypeEnumType : EnumerationGraphType<Data.ProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of the product";
        }
    }
}