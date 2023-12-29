using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NhaTuyenDungDTO;

namespace TimViec.Application.Services.Interface
{
    public interface ICongtyService
    {
        List<CongTyDto> GetAll();
        CongTyDto Get(int id);
        bool Add(CongTyDto congTyDto);
        bool Update(CongTyDto congTyDto);
        bool Delete(int id);
    }
}
