namespace P05_UploadFile.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task Add(Product product, IFormFile file);
        Task Update(Product product, IFormFile file);
        Task<Product> Find(int id);
        Task Delete(Product product);
    }
}
