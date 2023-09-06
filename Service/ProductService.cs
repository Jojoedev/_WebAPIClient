using _WebAPIClient.InmemoryDB;
using _WebAPIClient.Interface;
using _WebAPIClient.Model;

namespace _WebAPIClient.Service
{
    
    public class ProductService : IProductInterface
    {
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            return Database.products.Where(x => x.Id == id).FirstOrDefault();
            
        }

        public IEnumerable<Product> GetProducts()
        {
            return Database.products;
        }
    }


}
