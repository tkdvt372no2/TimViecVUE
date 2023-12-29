using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NguoiTimViecDTO;

namespace TimViec.Application.Services.Interface
{
    public interface IHoSoTimViecService
    {
        List<HoSoTimViecDto> GetAll();
        HoSoTimViecDto Get(int id);
        bool Add(HoSoTimViecDto taiKhoanDto);
        bool Update(HoSoTimViecDto taiKhoanDto);
        bool Delete(int id);
    }
}
