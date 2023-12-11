using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P03_CodeFirst.Models
{
    public class Product
    {
        [DisplayName("รหัส")]
        public int Id { get; set; }
        [DisplayName("ชื่อ")]

        [Required(ErrorMessage ="กรุณาป้อนข้อมูล")]
        public string Name { get; set; }

        [DisplayName("ราคา")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        [Range(1,9999,ErrorMessage ="ป้อนค่าระหว่าง {1} ถึง {2}")]
        public double Price { get; set; }

        [DisplayName("จำนวน")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        [Range(0, 9999, ErrorMessage = "ป้อนค่าระหว่าง {1} ถึง {2}")]
        public int Amount { get; set; }
    }
}
