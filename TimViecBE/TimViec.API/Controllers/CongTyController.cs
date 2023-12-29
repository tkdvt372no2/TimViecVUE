using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Application.Services.Interface;
using TimViec.API.Model;
using TimViec.Application.DTO;
using TimViec.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TimViec.Infrastructure.Context;

namespace TimViec.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CongTyController : ControllerBase
    {
        private readonly ICongtyService _congTyService;
        private readonly Cloudinary _cloudinary;
        private readonly TimViecContext _context;

        public CongTyController(ICongtyService congTyService, Cloudinary cloudinary, TimViecContext context)
        {
            this._congTyService = congTyService;
            _cloudinary = cloudinary;
            _context = context;
        }
        [HttpGet]

        public ActionResult GetAllCongTy()
        {
            return Ok(_congTyService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetCongTy(int id)
        {
            var category = _congTyService.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]

        public IActionResult PostCongTy([FromForm] CongTyModel congty)
        {
            var ct = new CongTyDto()
            {
                TenCongTy = congty.TenCongTy,
                DiaChi = congty.DiaChi,
                QuocGia = congty.QuocGia,
                SoLuoc = congty.SoLuoc,
                SoNhanVien = congty.SoNhanVien
            };
            if (congty.HinhAnh == null)
            {
                ct.HinhAnh = "https://freedesignfile.com/upload/2017/08/White-office-space-meeting-room-table-Stock-Photo-16.jpg";
            }
            else
            {
                ct.HinhAnh = ImageUpload(congty.HinhAnh);
            }
            if (_congTyService.Add(ct))
            {
                return CreatedAtAction("getCongTy", new { id = congty.CongTyId }, congty);
            }
            return Ok("Công ty đã tồn tại");
        }
        [HttpPut("{id}")]
        public IActionResult PutCongTy([FromForm] CongTyModel congty)
        {
            var ct = new CongTyDto()
            {
                CongTyId = congty.CongTyId,
                TenCongTy = congty.TenCongTy,
                DiaChi = congty.DiaChi,
                QuocGia = congty.QuocGia,
                SoLuoc = congty.SoLuoc,
                SoNhanVien = congty.SoNhanVien
            };

            if (congty.HinhAnh == null)
            {
                ct.HinhAnh = "https://freedesignfile.com/upload/2017/08/White-office-space-meeting-room-table-Stock-Photo-16.jpg";
            }
            else
            {
                ct.HinhAnh = ImageUpload(congty.HinhAnh);
            }
            if (_congTyService.Update(ct))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete]
        public IActionResult DeleteCongTy(int id)
        {
            var congty = _context.CongTys.Find(id);
            var hinhAnhUrl = congty.HinhAnh;
            if (_congTyService.Delete(id))
            {
                DeleteImage(hinhAnhUrl);
                return NoContent();
            }
            return NotFound("Không tìm thấy ");
        }
        [NonAction]
        public string ImageUpload(IFormFile? hinhAnh)
        {
            if (hinhAnh != null && hinhAnh.Length > 0)
            {
                using (var stream = hinhAnh.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(hinhAnh.FileName, stream),
                        Transformation = new Transformation().Width(500).Height(500).Crop("fill"),
                    };

                    try
                    {
                        var uploadResult = _cloudinary.Upload(uploadParams);
                        return uploadResult.SecureUrl.ToString();
                    }
                    catch (Exception ex)
                    {
                        return ex.ToString();
                    }
                }
            }

            return null;
        }
        [NonAction]
        private bool DeleteImage(string imageUrl)
        {
            try
            {
                var publicId = GetPublicIdFromImageUrl(imageUrl);
                var deleteParams = new DeletionParams(publicId);

                var result = _cloudinary.Destroy(deleteParams);
                return result.Result == "ok";
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string GetPublicIdFromImageUrl(string imageUrl)
        {
            var uri = new Uri(imageUrl);
            var segments = uri.Segments;
            var filename = segments.Last();

            return Path.GetFileNameWithoutExtension(filename);
        }
    }
}
