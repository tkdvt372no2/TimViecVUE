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
    public class ViecLamService:IViecLamService
    {
        private readonly IViecLamRepo _viecLamRepo;
        private readonly IMapper _mapper;

        public ViecLamService(IViecLamRepo congViecRepo, IMapper mapper)
        {
            this._viecLamRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(ViecLamDto congViecDto)
        {
            return _viecLamRepo.Add(_mapper.Map<ViecLam>(congViecDto));
        }

        public bool Delete(int id)
        {
            return _viecLamRepo.Delete(id);
        }

        public ViecLamDto Get(int id)
        {
            return _mapper.Map<ViecLamDto>(_viecLamRepo.Get(id));
        }

        public List<ViecLamDto> GetAll()
        {
            return _mapper.Map<List<ViecLamDto>>(_viecLamRepo.getAll());
        }

        public bool Update(ViecLamDto congViecDto)
        {
            return _viecLamRepo.Update(_mapper.Map<ViecLam>(congViecDto));
        }
    }
}
