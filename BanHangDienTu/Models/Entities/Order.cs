namespace BanHangDienTu.Models.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public ICollection<Product> Products { get; set; }
        public decimal TotalPrice
        {
            get { return Products.Sum(p => p.Price); }
        }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
