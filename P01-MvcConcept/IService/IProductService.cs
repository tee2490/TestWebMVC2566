
namespace P01_MvcConcept.IService
{
    public interface IProductService
    {
        void GenerateProduct(int number);
        List<Product> GetProductAll();
    }
}
