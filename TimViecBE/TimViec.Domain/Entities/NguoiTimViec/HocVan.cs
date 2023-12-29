using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NguoiTimViec
{
    public class HocVan
    {
        [Key]
        public int HocVanId { get; set; }
        public string TenTruong { get; set; } = string.Empty;
        public string BangCap { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
        public HoSoTimViec hoSoTimViec { get; set; }
        public int HoSoTimViecId { get; set; }
    }
}
