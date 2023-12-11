using System.ComponentModel;

namespace P03_CodeFirst.Models
{
    public class Product
    {
        [DisplayName("รหัส")]
        public int Id { get; set; }
        [DisplayName("ชื่อ")]
        public string Name { get; set; }
        [DisplayName("ราคา")]
        public double Price { get; set; }
        [DisplayName("จำนวน")]
        public int Amount { get; set; }
    }
}
