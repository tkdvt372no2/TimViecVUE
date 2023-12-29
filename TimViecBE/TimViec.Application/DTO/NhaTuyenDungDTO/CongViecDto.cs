using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Application.DTO.NhaTuyenDungDTO
{
    public class CongViecDto
    {
        public int CongViecId { get; set; }
        public string TenCongViec { get; set; }
        public string NganhNghe { get; set; }
        public string CapBac { get; set; }
        public float KinhNghiem { get; set; }
        public int MucLuong { get; set; }
        public string HocVan { get; set; }
        public string LoaiCongViec { get; set; }
        public string DiaDiem { get; set; }
        public int CongTyId { get; set; }
        public int TaiKhoanId { get; set; }
        public DateTime? HanNop { get; set; } = DateTime.Now.AddDays(3);
        public DateTime? NgayCapNhat { get; set; } = DateTime.Now;
    }
}
