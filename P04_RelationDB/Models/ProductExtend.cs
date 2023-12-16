using Microsoft.EntityFrameworkCore;

namespace P04_RelationDB.Models
{
    [Owned] //ให้ตารางอื่นเป็นเจ้าของ
    public class ProductExtend
    {
        public string Color { get; set; }
        public double Weight { get; set; }
    }
}
