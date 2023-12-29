using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NhaTuyenDungDTO;

namespace TimViec.Application.Services.Interface
{
    public interface ICongViecDaNopService
    {
        List<CongViecDaNopDto> GetAll();
        CongViecDaNopDto Get(int id);
        bool Add(CongViecDaNopDto taiKhoanDto);
        bool Update(CongViecDaNopDto taiKhoanDto);
        bool Delete(int id);
    }
}
