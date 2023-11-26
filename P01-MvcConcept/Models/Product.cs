using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P01_MvcConcept.Models
{
    public class Product
    {
        [Display(Name ="รหัส")]
        [Required(ErrorMessage ="กรุณากรอกข้อมูล")]
        public int Id { get; set; }

        [Display(Name = "ชื่อสินค้า")]
        [Required(ErrorMessage = "กรุณากรอกข้อมูล")]
        [StringLength(100,MinimumLength =3)]
        public string Name { get; set; }

        [Display(Name = "ราคา")]
        [Range(5,double.MaxValue,ErrorMessage = "กรอกขั้นต่ำ {1}")]
        public double Price { get; set; }

        [Display(Name = "จำนวน")]
        [Range(1, 100, ErrorMessage = "อย่างน้อย {1} ไม่เกิน {2}")]
        public int Amount { get; set; }
    }
}
