using System.Collections.Generic;
using System.Threading.Tasks;
using CarvedRock.Api.Data;
using CarvedRock.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarvedRock.Api.Repositories
{
    public class ProductRepository
    {
        private readonly CarvedRockDbContext _dbContext;

        public ProductRepository(/*CarvedRockDbContext dbContext*/)
        {
            //_dbContext = dbContext;
        }

        public Task<List<Product>> GetAll()
        {
            //return _dbContext.Products.ToListAsync();
            return Task.FromResult(
                new List<Product>
                {
                    new Product(1, "Product #1", ProductType.Boots, "Product #1 Description", 100),
                    new Product(2, "Product #2", ProductType.ClimbingGear, "Product #2 Description", 200),
                    new Product(3, "Product #3", ProductType.Boots, "Product #3 Description", 300),
                    new Product(5, "Product #4", ProductType.Kayaks, "Product #4 Description", 400),
                });
        }
    }
}