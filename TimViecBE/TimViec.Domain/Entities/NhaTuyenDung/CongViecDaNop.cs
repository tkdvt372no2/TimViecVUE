using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimViec.Domain.Entities.NhaTuyenDung
{
    public class CongViecDaNop
    {
        [Key]
        public int CongViecDaNopId { get; set; }
        public int IdNguoiNop { get; set; }
        public int CongViecId { get; set; }
        public CongViec CongViec { get; set; }
    }
}
