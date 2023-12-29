using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO.NhaTuyenDungDTO;

namespace TimViec.Application.Services.Interface
{
    public interface ICongViecService
    {
        List<CongViecDto> GetAll();
        CongViecDto Get(int id);
        bool Add(CongViecDto congViecDto);
        bool Update(CongViecDto congViecDto);
        bool Delete(int id);
    }
}
