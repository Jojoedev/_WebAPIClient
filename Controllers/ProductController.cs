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
        public IEnumerable<Product> Index()
        {

           return _iProductInterface.GetProducts();
            
        }

        [HttpGet]
        [Route("id")]
        public ActionResult<Product> GetItem(int id)
        {
            var product = _iProductInterface.GetProduct(id);
            if(product == null)
            {
                return NotFound();
            }

            return product;         
        }


    }
}
