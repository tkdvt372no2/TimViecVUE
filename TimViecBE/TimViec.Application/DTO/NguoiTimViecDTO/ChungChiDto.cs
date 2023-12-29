using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Application.DTO.NguoiTimViecDTO
{
    public class ChungChiDto
    {
        public int ChungChiId { get; set; }
        public string TenChungChi { get; set; } = string.Empty;
        public string CapBoi { get; set; } = string.Empty;
    }
}
