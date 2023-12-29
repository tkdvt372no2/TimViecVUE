using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NguoiTimViecDTO;

namespace TimViec.Application.Services.Interface
{
    public interface INgoaiNguService
    {
        List<NgoaiNguDto> GetAll();
        NgoaiNguDto Get(int id);
        bool Add(NgoaiNguDto taiKhoanDto);
        bool Update(NgoaiNguDto taiKhoanDto);
        bool Delete(int id);
    }
}
