using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Domain.Entities.NhaTuyenDung;

namespace TimViec.Domain.Entities.NhaTuyenDung
{
    public class CongViec
    {
        [Key]
        public int CongViecId { get; set; }
        public string TenCongViec { get; set; }
        public string NganhNghe { get; set; }
        public string CapBac { get; set; }
        public float KinhNghiem { get; set; }
        public int MucLuong { get; set; }
        public string HocVan { get; set; }
        public string LoaiCongViec { get; set; }
        public string DiaDiem { get; set; }
        public CongTy CongTy { get; set; }
        public int CongTyId { get; set; }
        public DateTime? HanNop { get; set; } = DateTime.Now.AddDays(3);
        public DateTime? NgayCapNhat { get; set; } = DateTime.Now; 
        public ICollection<CongViecDaNop> CongViecDaNops { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public int TaiKhoanId { get; set; }
    }
}
