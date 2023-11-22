using DeltaCore.Models;

namespace DeltaCore.Service
{
    public class ProductsService
    {
        public List<Product> GetProducts()
        {
            return new List<Product>
        {
            new Product { ProductId = 1001, ProductName = "Tools", ProductDescription = "Gears Gear tools production specification" },
            new Product { ProductId = 2001, ProductName = "Panels", ProductDescription = "Switch Gear Panels" },
            new Product { ProductId = 2008, ProductName = "DocTonar", ProductDescription = "Document Solar Objects" },
            new Product { ProductId = 2011, ProductName = "SwitchGear", ProductDescription = "Low-tension Panel" },
            new Product { ProductId = 2013, ProductName = "Gadgets", ProductDescription = "Makes Life More comfortable And Enjoyable" }
        };
        }
    }
}