namespace TimViec.API.Model
{
    public class TaiKhoanModel
    {
        public int TaiKhoanId { get; set; }
        public string UserName { get; set; }
        public string? Password { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string SoDienThoai { get; set; }
        public IFormFile? HinhAnh { get; set; }
    }
}
