using System;
using System.Collections.Generic;
using UTB.Eshop.Domain.Entities;

namespace UTB.Eshop.Application.Services.Abstraction
{
	public interface IProductApplicationService
	{
		Product GetProduct(int ID);
		IList<Product> GetAllProducts();
	}
}

