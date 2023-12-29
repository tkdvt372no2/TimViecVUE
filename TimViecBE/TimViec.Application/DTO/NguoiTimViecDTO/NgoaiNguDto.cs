using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Application.DTO.NguoiTimViecDTO
{
    public class NgoaiNguDto
    {
        public int NgoaiNguId { get; set; }
        public string NgonNgu { get; set; } = string.Empty;
        public string TrinhDo { get; set; } = string.Empty;
        public string ChungChiNgoaiNgu { get; set; } = string.Empty;
    }
}
