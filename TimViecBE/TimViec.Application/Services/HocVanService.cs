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
    public class HocVanService: IHocVanService
    {
        private readonly IHocVanRepo _hocVanRepo;
        private readonly IMapper _mapper;

        public HocVanService(IHocVanRepo congViecRepo, IMapper mapper)
        {
            this._hocVanRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(HocVanDto congViecDto)
        {
            return _hocVanRepo.Add(_mapper.Map<HocVan>(congViecDto));
        }

        public bool Delete(int id)
        {
            return _hocVanRepo.Delete(id);
        }

        public HocVanDto Get(int id)
        {
            return _mapper.Map<HocVanDto>(_hocVanRepo.Get(id));
        }

        public List<HocVanDto> GetAll()
        {
            return _mapper.Map<List<HocVanDto>>(_hocVanRepo.getAll());
        }

        public bool Update(HocVanDto congViecDto)
        {
            return _hocVanRepo.Update(_mapper.Map<HocVan>(congViecDto));
        }
    }
}
