using System.Collections.Generic;
using XamarinWorkshop.Models;

namespace XamarinWorkshop
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product()
                {
                    Id = 1,
                    Description =
                        "See the difference over eight million pixels can make in the new XPS 15, available with 4K Ultra HD touch display and powerful processors.",
                    Price = "$1,500",
                    Name = "DELL XPS 15",
                    ImgUrl = "http://ecx.images-amazon.com/images/I/81UcGYcuBNL._SL1500_.jpg"

                },
                new Product()
                {
                    Id = 2,
                    Description =
                        "The smallest 13-inch laptop on the planet has the worldâ€™s first virtually borderless InfinityEdge display with optional touch.",
                    Price = "$1,300",
                    ImgUrl = "http://core0.staticworld.net/images/article/2015/01/xps-15-9-100539027-orig.png",
                    Name = "DELL XPS 13",

                }
            };

            return products;
        }
    }
}
