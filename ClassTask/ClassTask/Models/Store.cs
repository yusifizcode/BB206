namespace ClassTask.Models
{
    public class Store
    {
        Product[] Products = new Product[0];

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public void RemoveProductByNo(int no)
        {
            Product[] newProducts = new Product[0];

            foreach (var pr in Products)
            {
                if (pr.No != no)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pr;
                }
            }

            Products = newProducts;
        }

        public Product GetProduct(int? no)
        {
            if (no != null)
            {
                foreach (var pr in Products)
                {
                    if (pr.No == no)
                    {
                        return pr;
                    }
                }
            }

            return null;
        }

        public Product[] FilterProductsByType(Enums.Type type)
        {
            Product[] newProducts = new Product[0];

            foreach (var pr in Products)
            {
                if (pr.Type == type)
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pr;
                }
            }

            return newProducts;
        }

        public Product[] FilterProductByName(string name)
        {
            Product[] newProducts = new Product[0];

            foreach (var pr in Products)
            {
                if (pr.Name.ToLower().Contains(name.ToLower()))
                {
                    Array.Resize(ref newProducts, newProducts.Length + 1);
                    newProducts[newProducts.Length - 1] = pr;
                }
            }

            return newProducts;
        }
    }
}
