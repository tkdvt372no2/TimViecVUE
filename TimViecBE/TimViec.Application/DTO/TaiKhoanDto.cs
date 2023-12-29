using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Application.DTO
{
    public class TaiKhoanDto
    {
        public int TaiKhoanId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string HinhAnh { get; set; }
        public string SoDienThoai { get; set; }
    }
}
