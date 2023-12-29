using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NguoiTimViecDTO;

namespace TimViec.Application.Services.Interface
{
    public interface IChungChiService
    {
        List<ChungChiDto> GetAll();
        ChungChiDto Get(int id);
        bool Add(ChungChiDto taiKhoanDto);
        bool Update(ChungChiDto taiKhoanDto);
        bool Delete(int id);
    }
}
