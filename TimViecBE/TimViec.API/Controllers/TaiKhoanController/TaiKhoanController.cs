using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TimViec.Application.DTO;
using TimViec.Application.Services.Interface;
using TimViec.Domain.Entities;
using TimViec.Infrastructure.Context;
using TimViec.API.Model;
using System.Data;
using Microsoft.AspNetCore.Authorization;
using TimViec.Domain.Repositories;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Application.DTO.NguoiTimViecDTO;
using TimViec.Domain.Entities.NhaTuyenDung;

namespace TimViec.API.Controllers.TaiKhoanController
{

    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly TimViecContext _context;
        private readonly IConfiguration configuration;
        private readonly ITaiKhoanService _taiKhoanService;
        private readonly Cloudinary _cloudinary;
        private readonly IViecLamService _viecLamService;
        private readonly ICongViecDaNopService _congViecDaNopService;

        public TaiKhoanController(TimViecContext context, IConfiguration configuration, ITaiKhoanService taiKhoanService, Cloudinary cloudinary, ICongViecDaNopService congViecDaNopService, IViecLamService viecLamService)
        {
            this._context = context;
            this.configuration = configuration;
            this._taiKhoanService = taiKhoanService;
            this._cloudinary = cloudinary;
            this._viecLamService = viecLamService;
            this._congViecDaNopService = congViecDaNopService;
        }
        [HttpPost("Login")]
        public IActionResult KiemTra(TaiKhoanWebAPI taikhoan)
        {
            var taiKhoan = _context.TaiKhoans.
                SingleOrDefault(p => p.UserName == taikhoan.UserName
                                    && p.Password == taikhoan.Password);
            if (taiKhoan == null)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message = "Tài khoản hoặc mật khẩu không chính xác",
                });
            }
            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Xác minh thành công",
                Data = TaoToken(taiKhoan)
            });
        }
        [HttpPost("DecodeToken")]
        public IActionResult DecodeToken(string token)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var tokenHandler = new JwtSecurityTokenHandler();

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ValidIssuer = configuration["Jwt:Issuer"],
                ValidAudience = configuration["Jwt:Audience"]
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out var securityToken);

                var userId = principal.FindFirst("Id")?.Value;
                var role = principal.FindFirst("Role")?.Value;
                var email = principal.FindFirst(ClaimTypes.Email)?.Value;
                var hoTen = principal.FindFirst(ClaimTypes.Name)?.Value;
                var hinhAnh = principal.FindFirst("HinhAnh")?.Value;
                var password = principal.FindFirst("Password")?.Value;
                var userName = principal.FindFirst("UserName")?.Value;
                var response = new
                {
                    HinhAnh = hinhAnh,
                    UserId = userId,
                    Role = role,
                    HoTen = hoTen,
                    Password = password,
                    Email = email,
                    UserName = userName,

                };
                return Ok(response);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private string TaoToken(TaiKhoan nguoiDung)
        {
            var key = configuration["Jwt:Key"];
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var signingCredential = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, nguoiDung.Email),
                    new Claim(ClaimTypes.Name, nguoiDung.HoTen),
                    new Claim("UserName", nguoiDung.UserName),
                    new Claim("Id", nguoiDung.TaiKhoanId.ToString()),
                    new Claim("Role",nguoiDung.Role),
                    new Claim("HinhAnh",nguoiDung.HinhAnh),
                    new Claim("Password",nguoiDung.Password),


            };
            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                expires: DateTime.Now.AddHours(1),
                signingCredentials: signingCredential,
                claims: claims
                );
            var dvttoken = new JwtSecurityTokenHandler().WriteToken(token);
            return dvttoken;

        }

        [HttpGet]
        public ActionResult GetAllTaiKhoan()
        {
            return Ok(_taiKhoanService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult GetTaiKhoan(int id)
        {
            var category = _taiKhoanService.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost("DangKy")]
        public IActionResult PostTaiKhoan([FromForm] TaiKhoanModel taikhoan)
        {
            var tk = new TaiKhoanDto()
            {
                HoTen = taikhoan.HoTen,
                Email = taikhoan.Email,
                Password = taikhoan.Password,
                Role = taikhoan.Role,
                UserName = taikhoan.UserName,
                SoDienThoai = taikhoan.SoDienThoai
            };
            if (taikhoan.HinhAnh == null)
            {
                tk.HinhAnh = "https://www.pngkit.com/png/full/88-885453_login-white-on-clear-user-icon.png";
            }
            else
            {
                tk.HinhAnh = ImageUpload(taikhoan.HinhAnh);
            }


            if (_taiKhoanService.Add(tk))
            {
                return CreatedAtAction("GetTaiKhoan", new { id = taikhoan.TaiKhoanId }, taikhoan);
            }
            return Ok("Tài khoản đã tồn tại");
        }
        [HttpPut("{id}")]
        public IActionResult PutTaiKhoan([FromForm] TaiKhoanModel taikhoan)
        {
            var tk = new TaiKhoanDto()
            {
                TaiKhoanId = taikhoan.TaiKhoanId,
                Password = taikhoan.Password,
                HoTen = taikhoan.HoTen,
                Email = taikhoan.Email,
                Role = taikhoan.Role,
                UserName = taikhoan.UserName,
                SoDienThoai = taikhoan.SoDienThoai
            };

            if (taikhoan.HinhAnh == null)
            {
                tk.HinhAnh = "https://www.pngkit.com/png/full/88-885453_login-white-on-clear-user-icon.png";
            }
            else
            {
                tk.HinhAnh = ImageUpload(taikhoan.HinhAnh);
            }


            if (_taiKhoanService.Update(tk))
            {
                return CreatedAtAction("GetTaiKhoan", new { id = taikhoan.TaiKhoanId }, taikhoan);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTaiKhoan(int id)
        {
            var taiKhoan = _context.TaiKhoans.Find(id);
            var hinhAnhUrl = taiKhoan.HinhAnh;
            if (_taiKhoanService.Delete(id))
            {
                DeleteImage(hinhAnhUrl);
                return NoContent();
            }
            return NotFound("Không tìm thấy tài khoản");
        }
        [HttpPost("UngTuyen")]
        public IActionResult UngTuyen(int taiKhoanId, int congViecId)
        {
            var daNop = new CongViecDaNopDto()
            {
                IdNguoiNop = taiKhoanId,
                CongViecId = congViecId
            };
            var viec = new ViecLamDto()
            {
                TaiKhoanId = taiKhoanId,
                ViecLamNop = congViecId

            };
            if (_congViecDaNopService.Add(daNop) && _viecLamService.Add(viec))
            {
                return Ok(new ApiResponse
                {
                    Success = true,
                    Message = "Ứng tuyển thành công",
                });
            }
            return Ok(new ApiResponse
            {
                Success = false,
                Message = "Ứng tuyển lỗi",
            });
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
