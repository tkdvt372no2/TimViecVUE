using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NguoiTimViec
{
    public class ViecLam
    {
        [Key]
        public int ViecLamId { get; set; }
        public int ViecLamNop { get; set; } 
        public TaiKhoan TaiKhoan { get; set; }
        public int TaiKhoanId { get; set; }

    }
}
