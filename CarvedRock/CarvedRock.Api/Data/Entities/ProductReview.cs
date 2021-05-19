using System.ComponentModel.DataAnnotations;

namespace CarvedRock.Api.Data.Entities
{
    public class ProductReview
    {
        public ProductReview()
        { }

        public ProductReview(int id, int productId, Product product, string title, string review)
        {
            Id = id;
            ProductId = productId;
            Product = product;
            Title = title;
            Review = review;
        }

        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        [StringLength(200), Required]
        public string Title { get; set; }

        public string Review { get; set; }
    }
}