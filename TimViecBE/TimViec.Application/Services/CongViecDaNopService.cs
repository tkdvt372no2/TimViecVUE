using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Application.Services.Interface;
using TimViec.Domain.Entities.NhaTuyenDung;
using TimViec.Domain.Repositories;

namespace TimViec.Application.Services
{
    public class CongViecDaNopService:ICongViecDaNopService
    {
        private readonly ICongViecDaNopRepo _congViecDaNopRepo;
        private readonly IMapper _mapper;

        public CongViecDaNopService(ICongViecDaNopRepo congViecRepo, IMapper mapper)
        {
            this._congViecDaNopRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(CongViecDaNopDto congViecDto)
        {
            return _congViecDaNopRepo.Add(_mapper.Map<CongViecDaNop>(congViecDto));
        }

        public bool Delete(int id)
        {
            return _congViecDaNopRepo.Delete(id);
        }

        public CongViecDaNopDto Get(int id)
        {
            return _mapper.Map<CongViecDaNopDto>(_congViecDaNopRepo.Get(id));
        }

        public List<CongViecDaNopDto> GetAll()
        {
            return _mapper.Map<List<CongViecDaNopDto>>(_congViecDaNopRepo.getAll());
        }

        public bool Update(CongViecDaNopDto congViecDto)
        {
            return _congViecDaNopRepo.Update(_mapper.Map<CongViecDaNop>(congViecDto));
        }
    }
}
