using CarvedRock.Api.Data;
using CarvedRock.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.Api.Repositories
{
    public class ProductReviewRepository
    {
        private readonly CarvedRockDbContext _dbContext;
        private List<ProductReview> reviews { get; set; }

        public ProductReviewRepository(/*CarvedRockDbContext dbContext*/)
        {
            //_dbContext = dbContext;

            var product1 = new Product(1, "Product #1", ProductType.Boots, "Product #1 Description", 100, "shutterstock_66842440.jpg");
            var product2 = new Product(2, "Product #2", ProductType.ClimbingGear, "Product #2 Description", 200, "shutterstock_48040747.jpg");

            reviews = new List<ProductReview>
            {
                new ProductReview(1, product1.Id, product1, "Testing review P1", "This is the review of the product 1"),
                new ProductReview(2, product1.Id, product1, "Testing review P1 2", "This is another and different review of the product 1"),

                new ProductReview(3, product2.Id, product2, "Testing review P2", "This is the review of the product 2"),
                new ProductReview(4, product2.Id, product2, "Testing review P2 2", "This is another and different review of the product 2")
            };
        }

        public async Task<List<ProductReview>> GetForProduct(int productId)
        {
            //return await _dbContext.ProductReviews.Where(pr => pr.ProductId == productId).ToListAsync();
            return await Task.FromResult(reviews.Where(pr => pr.ProductId == productId).ToList());
        }

        public async Task<ILookup<int, ProductReview>> GetForProducts(IEnumerable<int> productIds)
        {
            //var reviews = await _dbContext.ProductReviews.Where(pr => productIds.Contains(pr.ProductId)).ToListAsync();
            //return reviews.ToLookup(r => r.ProductId);

            var reviewsList = reviews.Where(pr => productIds.Contains(pr.ProductId)).ToList();
            return await Task.FromResult(reviewsList.ToLookup(r => r.ProductId));
        }

        public async Task<ProductReview> AddReview(ProductReview review)
        {
            //_dbContext.ProductReviews.Add(review);
            //await _dbContext.SaveChangesAsync();

            reviews.Add(review);
            return review;
        }
    }
}