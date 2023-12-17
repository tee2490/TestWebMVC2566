using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P05_UploadFile.Models
{
    public class Product
    {
        [DisplayName("รหัส")]
        public int Id { get; set; }

        [DisplayName("ชื่อ"), Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Name { get; set; }

        [DisplayName("ราคา")]
        [Range(1,999,ErrorMessage ="ป้อนค่าระหว่าง {1} ถึง {2}")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public double Price { get; set; }

        [DisplayName("จำนวน")]
        [Range(1, 100, ErrorMessage = "ป้อนค่าระหว่าง {1} ถึง {2}")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public int Amount { get; set; }

        [DisplayName("ภาพ")]
        public string? ImageUrl {  get; set; }
    }
}
