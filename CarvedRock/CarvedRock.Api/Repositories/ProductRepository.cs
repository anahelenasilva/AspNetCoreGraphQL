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
                    new Product(1, "Produto 1", ProductType.Boots, "Descrição Produto 1", 100),
                    new Product(2, "Produto 2", ProductType.Boots, "Descrição Produto 2", 200),
                    new Product(3, "Produto 3", ProductType.Boots, "Descrição Produto 3", 300),
                    new Product(5, "Produto 4", ProductType.Boots, "Descrição Produto 4", 400),
                });
        }
    }
}