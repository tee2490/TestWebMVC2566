
namespace P04_RelationDB.Models
{
    public class ComponentProduct
    {
        public int ComponentId { get; set; }
        public Component Component { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
