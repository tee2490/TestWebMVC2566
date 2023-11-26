using P01_MvcConcept.Settings;

namespace P01_MvcConcept.IService
{
    public class ProductService : IProductService
    {
        public List<Product> ProductList { get; set; }

        public ProductService()
        {
            ProductList = new List<Product>();
            GenerateProduct(20);
        }

        public void GenerateProduct(int number = 10)
        {
            Random rand = new Random();
            var numberOfName = NameOfProduct.ProductName.Count;

            for (int i = 1; i < number; i++)
            {
                ProductList.Add(new Product
                {
                    Id = i,
                    Name = NameOfProduct.ProductName[rand.Next(numberOfName)],
                    Price = rand.Next(200) + 10,
                    Amount = rand.Next(100) + 1
                });
            }

        }

        public List<Product> GetProductAll()
        {
            return ProductList;
        }

        public Product SearchProduct(int id)
        {
            return ProductList.Find(x => x.Id == id);
        }

        public void AddProduct(Product product)
        {
            ProductList.Add(product);
        }

        public void DeleteProduct(int id)
        {
            var result = SearchProduct(id);

            if (result != null) { ProductList.Remove(result); }
        }

        public void UpdateProduct(Product product)
        {
            var oldProduct = ProductList.Find(p => p.Id == product.Id);
            var index = ProductList.IndexOf(oldProduct);
            if (index != -1)
            {
                ProductList.RemoveAt(index);
                ProductList.Insert(index, product);
            }
        }
    }
}
