using System.ComponentModel.DataAnnotations.Schema;

namespace P04_RelationDB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public int CategoryId { get; set; } //คีย์นอกที่เชื่อมต่อไปยังไฟล์ Category
        //[ForeignKey("TestId")]
        public Category Category { get; set; }
    }
}
