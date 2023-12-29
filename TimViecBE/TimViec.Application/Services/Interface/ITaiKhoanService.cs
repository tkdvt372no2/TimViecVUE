using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NhaTuyenDungDTO;

namespace TimViec.Application.Services.Interface
{
    public interface ITaiKhoanService
    {
        List<TaiKhoanDto> GetAll();
        TaiKhoanDto Get(int id);
        bool Add(TaiKhoanDto taiKhoanDto);
        bool Update(TaiKhoanDto taiKhoanDto);
        bool Delete(int id);
    }
}
