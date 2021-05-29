using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarvedRock.Api.Data.Entities
{
    public class Product
    {
        public Product()
        {
            PhotoFileName = "file.png";
        }

        public Product(int id, string name, ProductType type, string description, decimal price, string fileName)
        {
            Id = id;
            Name = name;
            Type = type;
            Description = description;
            Price = price;
            IntroducedAt = DateTime.Now;
            PhotoFileName = fileName;
        }

        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public ProductType Type { get; set; }
        public string Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int Stock { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset IntroducedAt { get; set; }

        [StringLength(100)]
        public string PhotoFileName { get; set; }
    }
}