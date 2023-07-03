namespace BanHangDienTu.Models.ViewModels
{
    public class CartViewModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public UserViewModel User { get; set; }
        public IList<ProductViewModel> Products { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
