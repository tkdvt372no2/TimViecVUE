using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimViec.Application.DTO;
using TimViec.Application.DTO.NguoiTimViecDTO;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Domain.Entities;
using TimViec.Domain.Entities.NguoiTimViec;
using TimViec.Domain.Entities.NhaTuyenDung;

namespace TimViec.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CongViec, CongViecDto>().ReverseMap();
            CreateMap<TaiKhoan,TaiKhoanDto>().ReverseMap();
            CreateMap<CongTy,CongTyDto>().ReverseMap();
            CreateMap<CongViecDaNop, CongViecDaNopDto>().ReverseMap();
            CreateMap<ChungChi, ChungChiDto>().ReverseMap();
            CreateMap<HocVan, HocVanDto>().ReverseMap();
            CreateMap<HoSoTimViec, HoSoTimViecDto>().ReverseMap();
            CreateMap<NgoaiNgu, NgoaiNguDto>().ReverseMap();
            CreateMap<ViecLam, ViecLamDto>().ReverseMap();
        }
    }
}
