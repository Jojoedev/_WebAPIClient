using _WebAPIClient.Data;
using _WebAPIClient.InmemoryDB;
using _WebAPIClient.Interface;
using _WebAPIClient.Model;

namespace _WebAPIClient.Service
{
    
     public class ProductService : IProductInterface
    {
        private readonly ApplicationDbContext _Context;
        public ProductService(ApplicationDbContext context)
        {
            _Context = context;  
        }

        public void Create(Product product)
        {
           _Context.Products.Add(product);
            _Context.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _Context.Products.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Delete(int id)
        {
            var product = _Context.Products.Where(n => n.Id == id).FirstOrDefault();
            _Context.Products.Remove(product);
            _Context.SaveChanges(true); 
        }

        public IEnumerable<Product> GetProducts()
        {
            return _Context.Products;
        }

        public void Update(int id)
        {
            var product = _Context.Products.Where(x => x.Id == id).FirstOrDefault();
            _Context.SaveChanges();
        }


    }


}
