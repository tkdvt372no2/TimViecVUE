using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NguoiTimViec
{
    public class NgoaiNgu
    {
        [Key]
        public int NgoaiNguId { get; set; }
        public string NgonNgu { get; set; } = string.Empty;
        public string TrinhDo { get; set; } = string.Empty;
        public string ChungChiNgoaiNgu { get; set; } = string.Empty;
        public HoSoTimViec hoSoTimViec { get; set; }
        public int HoSoTimViecId { get; set; }
    }
}
