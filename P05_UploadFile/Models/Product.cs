namespace P05_UploadFile.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string? ImageUrl {  get; set; }
    }
}
