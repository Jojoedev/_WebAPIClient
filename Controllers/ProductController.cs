﻿using _WebAPIClient.Dtos;
using _WebAPIClient.Interface;
using _WebAPIClient.Model;
using Microsoft.AspNetCore.Mvc;

namespace _WebAPIClient.Controllers
{

    [ApiController]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private readonly IProductInterface _iProductInterface;

        public ProductController(IProductInterface iProductInterface)
        {
            _iProductInterface = iProductInterface;
        }

        [HttpGet]
        public IEnumerable<ProductDTO> Index()
        {

            return _iProductInterface.GetProducts().Select(x => new ProductDTO
            {
                Id = x.Id,
                Name = x.Name,
                Category = x.Category,
            });
            
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<ProductDTO> GetItem(int id)
        {
            var product = _iProductInterface.GetProduct(id);
            if(product == null)
            {
                return NotFound();
            }

            return new ProductDTO
            {
                Id =product.Id,
                Name = product.Name,
                Category = product.Category
            };       
        }
        [HttpPost]
        public ActionResult<ProductDTO> CreateNew(ProductDTO productDTO)
        {
            Product product = new Product();
            product.Id = productDTO.Id;
            product.Name = productDTO.Name;
            product.Category = productDTO.Category;

            _iProductInterface.Create(product);
            return CreatedAtAction(nameof(GetItem), new { id = productDTO.Id }, productDTO);
            
        }
        
        
        
    }
}
