using _WebAPIClient.Model;

namespace _WebAPIClient.Interface
{
    public interface IProductInterface
    {
        IEnumerable<Product> GetProducts();

        Product GetProduct(int id);

        void Create(Product product);
    }
}
