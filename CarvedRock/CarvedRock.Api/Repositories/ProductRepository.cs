using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRock.Api.Data;
using CarvedRock.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarvedRock.Api.Repositories
{
    public class ProductRepository
    {
        private readonly CarvedRockDbContext _dbContext;
        private List<Product> products { get; set; }

        public ProductRepository(/*CarvedRockDbContext dbContext*/)
        {
            //_dbContext = dbContext;
            products = new List<Product>
            {
                new Product(1, "Product #1", ProductType.Boots, "Product #1 Description", 100, "shutterstock_66842440.jpg"),
                new Product(2, "Product #2", ProductType.ClimbingGear, "Product #2 Description", 200, "shutterstock_48040747.jpg"),
                new Product(2, "Product #2.2", ProductType.ClimbingGear, "Product #2.2 Description", 220, "shutterstock_6170527.jpg"),
                new Product(3, "Product #3", ProductType.Boots, "Product #3 Description", 300, "shutterstock_222721876.jpg"),
                new Product(5, "Product #4", ProductType.Kayaks, "Product #4 Description", 400, "shutterstock_441989509.jpg"),
            };
        }

        public Task<List<Product>> GetAll()
        {
            //return _dbContext.Products.ToListAsync();
            return Task.FromResult(products);
        }

        public Task<Product> GetOne(int id)
        {
            //return _dbContext.Products.ToListAsync();
            return Task.FromResult(products.FirstOrDefault(s => s.Id == id));
        }
    }
}