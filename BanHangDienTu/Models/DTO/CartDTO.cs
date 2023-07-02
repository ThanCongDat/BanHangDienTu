namespace BanHangDienTu.Models.DTO
{
    public class CartDTO
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public UserDTO User { get; set; }
        public ICollection<ProductDTO> Products { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
