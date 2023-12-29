using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NhaTuyenDung
{
    public class CongTy
    {
        [Key]
        public int CongTyId { get; set; }
        public string TenCongTy { get; set; }
        public string SoNhanVien { get; set; }
        public string QuocGia { get; set; }
        public string DiaChi { get; set; }
        public string HinhAnh { get; set; }
        public string SoLuoc { get; set; }
        public ICollection<CongViec> congViecs { get; set; }
    }
}
