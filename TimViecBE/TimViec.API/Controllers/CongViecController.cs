using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TimViec.Application.DTO.NhaTuyenDungDTO;
using TimViec.Application.Services.Interface;

namespace TimViec.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CongViecController : ControllerBase
    {
        private readonly ICongViecService _congViecService;
        private readonly ICongtyService _congtyService;

        public CongViecController(ICongViecService congViecService, ICongtyService congtyService)
        {
            this._congViecService = congViecService;
            _congtyService = congtyService;
        }
        [HttpGet]
       
        public ActionResult GetAllCongViec() {
            return Ok(_congViecService.GetAll());
        }
       
        [HttpGet("{id}")]
        public ActionResult GetCongViec(int id)
        {
            var category = _congViecService.Get(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }
        [HttpPost]
        
        public IActionResult PostCongViec(CongViecDto congviec,int taiKhoanId,int congTyId)
        {

            if (_congViecService.Add(congviec))
            {
                return CreatedAtAction("getCongViec", new { id = congviec.CongViecId }, congviec);
            }
            return Ok("Công việc đã tồn tại");
        }
        [HttpPut("{id}")]
        public IActionResult PutCongViec(CongViecDto congviec)
        {
            if (_congViecService.Update(congviec))
            {
                return NoContent();
            }
            return NotFound();
        }
        [HttpDelete]
        public IActionResult DeleteCongViec(int id)
        {
            if (_congViecService.Delete(id))
            {
                return NoContent();
            }
            return NotFound("Không tìm thấy ");
        }
    }
}
