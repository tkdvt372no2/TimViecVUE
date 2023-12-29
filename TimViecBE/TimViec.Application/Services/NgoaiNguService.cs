using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO.NguoiTimViecDTO;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Application.Services.Interface;
using TimViec.Domain.Entities.NguoiTimViec;
using TimViec.Domain.Entities.NhaTuyenDung;
using TimViec.Domain.Repositories;

namespace TimViec.Application.Services
{
    public class NgoaiNguService :INgoaiNguService
    {
        private readonly INgoaiNguRepo _ngoaiNguRepo;
        private readonly IMapper _mapper;

        public NgoaiNguService(INgoaiNguRepo congViecRepo, IMapper mapper)
        {
            this._ngoaiNguRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(NgoaiNguDto congViecDto)
        {
            return _ngoaiNguRepo.Add(_mapper.Map<NgoaiNgu>(congViecDto));
        }

        public bool Delete(int id)
        {
            return _ngoaiNguRepo.Delete(id);
        }

        public NgoaiNguDto Get(int id)
        {
            return _mapper.Map<NgoaiNguDto>(_ngoaiNguRepo.Get(id));
        }

        public List<NgoaiNguDto> GetAll()
        {
            return _mapper.Map<List<NgoaiNguDto>>(_ngoaiNguRepo.getAll());
        }

        public bool Update(NgoaiNguDto congViecDto)
        {
            return _ngoaiNguRepo.Update(_mapper.Map<NgoaiNgu>(congViecDto));
        }
    }
}
