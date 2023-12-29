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
    public class ChungChiService: IChungChiService
    {
        private readonly IChungChiRepo _chungChiRepo;
        private readonly IMapper _mapper;

        public ChungChiService(IChungChiRepo congViecRepo, IMapper mapper)
        {
            this._chungChiRepo = congViecRepo;
            this._mapper = mapper;
        }
        public bool Add(ChungChiDto chungChiDto)
        {
            return _chungChiRepo.Add(_mapper.Map<ChungChi>(chungChiDto));
        }

        public bool Delete(int id)
        {
            return _chungChiRepo.Delete(id);
        }

        public ChungChiDto Get(int id)
        {
            return _mapper.Map<ChungChiDto>(_chungChiRepo.Get(id));
        }

        public List<ChungChiDto> GetAll()
        {
            return _mapper.Map<List<ChungChiDto>>(_chungChiRepo.getAll());
        }

        public bool Update(ChungChiDto chungChiDto)
        {
            return _chungChiRepo.Update(_mapper.Map<ChungChi>(chungChiDto));
        }
    }
}
