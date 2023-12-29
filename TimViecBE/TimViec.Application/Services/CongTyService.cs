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
    public class CongTyService: ICongtyService
    {
        private readonly ICongTyRepo _congTyRepo;
        private readonly IMapper _mapper;

        public CongTyService(ICongTyRepo congViecRepo, IMapper mapper)
        {
            this._congTyRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(CongTyDto congTyDto)
        {
            return _congTyRepo.Add(_mapper.Map<CongTy>(congTyDto));
        }


        public bool Delete(int id)
        {
            return _congTyRepo.Delete(id);
        }

        public CongTyDto Get(int id)
        {
            return _mapper.Map<CongTyDto>(_congTyRepo.Get(id));
        }

        public List<CongTyDto> GetAll()
        {
            return _mapper.Map<List<CongTyDto>>(_congTyRepo.getAll());
        }


        public bool Update(CongTyDto congViecDto)
        {
            return _congTyRepo.Update(_mapper.Map<CongTy>(congViecDto));
        }



    }
}
