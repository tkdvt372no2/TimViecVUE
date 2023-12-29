using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Application.Services.Interface;
using TimViec.Domain.Entities;
using TimViec.Domain.Repositories;

namespace TimViec.Application.Services
{
    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly IMapper _mapper;
        private readonly ITaiKhoanRepo _taiKhoanRepo;

        public TaiKhoanService(IMapper mapper,ITaiKhoanRepo taiKhoanRepo)
        {
            this._mapper = mapper;
            this._taiKhoanRepo = taiKhoanRepo;
        }
        public bool Add(TaiKhoanDto taiKhoanDto)
        {
            return _taiKhoanRepo.Add(_mapper.Map<TaiKhoan>(taiKhoanDto));
        }

        public bool Delete(int id)
        {
            return _taiKhoanRepo.Delete(id);
        }

        public TaiKhoanDto Get(int id)
        {
            return _mapper.Map<TaiKhoanDto>(_taiKhoanRepo.Get(id));
        }

        public List<TaiKhoanDto> GetAll()
        {
            return _mapper.Map<List<TaiKhoanDto>>(_taiKhoanRepo.getAll());
        }

        public bool Update(TaiKhoanDto taiKhoanDto)
        {
            return _taiKhoanRepo.Update(_mapper.Map<TaiKhoan>(taiKhoanDto));
        }
    }
}
