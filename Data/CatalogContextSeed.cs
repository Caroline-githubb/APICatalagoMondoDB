using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(productCollection => true).Any();

            if(!existProduct)
                productCollection.InsertManyAsync(GetMyProducts());
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    ID = "122345678886",
                    Name = "IPhone X",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore,"+
                    "magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "+
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint "+
                    "occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-1.png",
                    Price = 950.00M,
                    Category = "SmartPhone"
                },

                new Product()

                {
                    ID = "122345678887",
                    Name = "Samsung X",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore,"+
                    "magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. "+
                    "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint "+
                    "occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    Image = "product-1.png",
                    Price = 850.00M,
                    Category = "SmartPhone"
                }


                
            };
        }

        


    }
}