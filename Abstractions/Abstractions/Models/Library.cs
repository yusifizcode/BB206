namespace Abstractions.Models
{
    public class Library
    {
        Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product[] GetProductsByPrice(int minPrice, int maxPrice)
        {
            Product[] newProducts = new Product[0];

            foreach (Product product in Products)
            {
                if (product.Price >= minPrice && product.Price <= maxPrice)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = product;
                }
            }

            return newProducts;
        }

        public Product[] GetProductsByName(string name)
        {
            Product[] newProducts = new Product[0];

            foreach (Product product in Products)
            {
                if (product.Name.ToLower() == name.ToLower())
                {
                    PushProduct(newProducts, product);
                }
            }

            return newProducts;
        }

        public void PushProduct(Product[] products, Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
    }
}
