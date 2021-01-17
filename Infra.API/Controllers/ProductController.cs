using Infra.MongoDB.Documents;
using Infra.MongoDB.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _productRepository;

        public ProductController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            var products = _productRepository.AsQueryable().ToList();           

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(string id)
        {
            var product = await _productRepository.FindByIdAsync(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Post(Product value)
        {
            await _productRepository.InsertOneAsync(value);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Product>> Put(string id, [FromBody] Product value)
        {
            await _productRepository.ReplaceOneAsync(value);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(string id)
        {
            await _productRepository.DeleteByIdAsync(id);
            return Ok();
        }
    }
}
