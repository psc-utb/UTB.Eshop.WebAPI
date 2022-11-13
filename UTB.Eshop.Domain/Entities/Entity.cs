using System;
using System.ComponentModel.DataAnnotations;

namespace UTB.Eshop.Domain.Entities
{
	public abstract class Entity<TKey>
	{
		[Key]
		public TKey ID { get; set; }
	}
}

