using System.ComponentModel.DataAnnotations;

namespace BanHangDienTu.Models.Entities
{
    public class Cart
    {
        [Key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public decimal TotalPrice
        {
            get { return Products.Sum(p => p.Price); }
        }

        public Cart()
        {
            Products = new HashSet<Product>();
        }

    }
}
