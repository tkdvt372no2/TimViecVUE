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
    public class HoSoTimViecService: IHoSoTimViecService
    {
        private readonly IHoSoTimViecRepo _hoSoTimViecRepo;
        private readonly IMapper _mapper;

        public HoSoTimViecService(IHoSoTimViecRepo congViecRepo, IMapper mapper)
        {
            this._hoSoTimViecRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(HoSoTimViecDto congViecDto)
        {
            return _hoSoTimViecRepo.Add(_mapper.Map<HoSoTimViec>(congViecDto));
        }

        public bool Delete(int id)
        {
            return _hoSoTimViecRepo.Delete(id);
        }

        public HoSoTimViecDto Get(int id)
        {
            return _mapper.Map<HoSoTimViecDto>(_hoSoTimViecRepo.Get(id));
        }

        public List<HoSoTimViecDto> GetAll()
        {
            return _mapper.Map<List<HoSoTimViecDto>>(_hoSoTimViecRepo.getAll());
        }

        public bool Update(HoSoTimViecDto congViecDto)
        {
            return _hoSoTimViecRepo.Update(_mapper.Map<HoSoTimViec>(congViecDto));
        }
    }
}
