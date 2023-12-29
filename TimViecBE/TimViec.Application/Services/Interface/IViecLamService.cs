using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NguoiTimViecDTO;

namespace TimViec.Application.Services.Interface
{
    public interface IViecLamService
    {
        List<ViecLamDto> GetAll();
        ViecLamDto Get(int id);
        bool Add(ViecLamDto taiKhoanDto);
        bool Update(ViecLamDto taiKhoanDto);
        bool Delete(int id);
    }
}
