using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Entities.NguoiTimViec;
using TimViec.Domain.Entities.NhaTuyenDung;

namespace TimViec.Domain.Entities
{
    public class TaiKhoan
    {
        public int TaiKhoanId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string HinhAnh { get; set; }
        public string SoDienThoai { get; set; }
        public HoSoTimViec HoSoTimViec { get; set; }
        public virtual ICollection<ViecLam> ViecLams { get; set; }
        public virtual ICollection<CongViec> CongViecs { get; set;}
    }
}
