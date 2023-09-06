using _WebAPIClient.Model;

namespace _WebAPIClient.InmemoryDB
{
    public static class Database
    {
        public static List<Product> products = new List<Product>()
        {
          new Product(){ Id = 1, Name="Peak", Category="Beverages", Quantity= 23},
          new Product(){ Id = 2, Name="Tissue", Category="Toiletry", Quantity= 65},
          new Product(){ Id = 3, Name="Jameson", Category="Wine", Quantity= 34},
          new Product(){ Id = 4, Name="Fan", Category="Home Appliance", Quantity= 44}
        };
    };
}
