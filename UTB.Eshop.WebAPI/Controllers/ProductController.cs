using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UTB.Eshop.Application.Services.Abstraction;
using UTB.Eshop.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UTB.Eshop.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductApplicationService _productService;

        public ProductController(ILogger<ProductController> logger, IProductApplicationService productService)
        {
            _logger = logger;
            _productService = productService;
        }


        // GET: Product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProducts();
        }


        // GET Product/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetProduct(id);
        }


        //dalsi varianty, ktere nepouzijeme .. ale vyzkouset si je muzete
        /*
        // POST Product
        [HttpPost]
        public void Post([FromBody]Product value)
        {
        }

        // PUT Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product value)
        {
        }

        // DELETE Product/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}

