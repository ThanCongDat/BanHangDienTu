namespace BanHangDienTu.Models.ViewModels
{
    public class OrderViewModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public UserViewModel User { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
