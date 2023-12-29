using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NguoiTimViec
{
    public class HoSoTimViec
    {
        [Key]
        public int HoSoTimViecId { get; set; }
        public int Ngay { get; set; }
        public int Thang { get; set; }
        public int Nam { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }

        public string MucTieuNgheNghiep { get; set; }
        public int TaiKhoanId { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public int HocVanId { get; set; }
        public virtual HocVan HocVan { get; set; }
        public int ChungChiId { get; set; }
        public virtual ChungChi ChungChi { get; set; }
        public int NgoaiNguId { get; set; }
        public virtual NgoaiNgu NgoaiNgu { get; set; }


    }
}
