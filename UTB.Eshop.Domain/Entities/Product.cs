using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UTB.Eshop.Domain.Entities
{
    [Table(nameof(Product))]
	public class Product : Entity<int>
	{
        [Required]
        [StringLength(100)]
		public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Price { get; set; }
    }
}

