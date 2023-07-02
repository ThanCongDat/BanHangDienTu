namespace BanHangDienTu.Models.DTO
{
    public class OrderDTO
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public UserDTO User { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
        public decimal TotalPrice { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
