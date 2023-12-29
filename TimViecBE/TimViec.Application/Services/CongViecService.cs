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
    public class CongViecService : ICongViecService
    {
        private readonly ICongViecRepo _congViecRepo;
        private readonly IMapper _mapper;

        public CongViecService(ICongViecRepo congViecRepo,IMapper mapper)
        {
            this._congViecRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(CongViecDto congViecDto)
        {
            return _congViecRepo.Add(_mapper.Map<CongViec>(congViecDto));
        }

        public bool Delete(int id)
        {
            return _congViecRepo.Delete(id);
        }

        public CongViecDto Get(int id)
        {
            return _mapper.Map<CongViecDto>(_congViecRepo.Get(id));
        }

        public List<CongViecDto> GetAll()
        {
            return _mapper.Map<List<CongViecDto>>(_congViecRepo.getAll());
        }

        public bool Update(CongViecDto congViecDto)
        {
            return _congViecRepo.Update(_mapper.Map<CongViec>(congViecDto));
        }
    }
}
