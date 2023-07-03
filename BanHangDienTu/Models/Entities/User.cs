using System.ComponentModel.DataAnnotations;

namespace BanHangDienTu.Models.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên đăng nhập!")]
        [StringLength(50)]
        public string Username { get; set; }
        [EmailAddress(ErrorMessage = "Vui lòng nhập đúng định dạng email !!!")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu!")]
        [StringLength(50)]
        public string Password { get; set; }
        public string Address { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public User()
        {
            Carts = new HashSet<Cart>();
            Orders = new HashSet<Order>();
        }
    }
}
