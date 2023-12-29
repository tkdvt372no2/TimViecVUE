namespace TimViec.API.Model
{
    public class CongTyModel
    {
        public int CongTyId { get; set; }
        public string TenCongTy { get; set; }
        public string SoNhanVien { get; set; }
        public string QuocGia { get; set; }
        public string DiaChi { get; set; }
        public string SoLuoc { get; set; }
        public IFormFile? HinhAnh { get; set; }
    }
}
