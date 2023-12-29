using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NguoiTimViec
{
    public class ChungChi
    {
        [Key]
        public int ChungChiId { get; set; }
        public string TenChungChi { get; set; } = string.Empty;
        public string CapBoi { get; set; } = string.Empty;
        public int HoSoTimViecId { get; set; }
        public HoSoTimViec hoSoTimViec { get; set; }

    }
}
