
namespace P01_MvcConcept.IService
{
    public interface IProductService
    {
        void GenerateProduct(int number);
        List<Product> GetProductAll();
        Product SearchProduct(int id);
        void AddProduct(Product product);
        void DeleteProduct(int id);
    }
}
