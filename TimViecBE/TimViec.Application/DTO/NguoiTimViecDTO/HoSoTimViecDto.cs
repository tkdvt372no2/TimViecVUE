using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Application.DTO.NguoiTimViecDTO
{
    public class HoSoTimViecDto
    {
        public int HoSoTimViecId { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MucTieuNgheNghiep { get; set; }
    }
}
