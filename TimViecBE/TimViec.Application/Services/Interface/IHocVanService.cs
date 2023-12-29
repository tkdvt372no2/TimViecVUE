using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NguoiTimViecDTO;

namespace TimViec.Application.Services.Interface
{
    public interface IHocVanService
    {
        List<HocVanDto> GetAll();
        HocVanDto Get(int id);
        bool Add(HocVanDto taiKhoanDto);
        bool Update(HocVanDto taiKhoanDto);
        bool Delete(int id);
    }
}
