using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Application.DTO.NguoiTimViecDTO
{
    public class HocVanDto
    {
        public int HocVanId { get; set; }
        public string TenTruong { get; set; } = string.Empty;
        public string BangCap { get; set; } = string.Empty;
        public string MoTa { get; set; } = string.Empty;
    }
}
