using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentUserControl.Services
{
    internal class KhachHangDTO
    {
        public string MaKhachHang { get; set; } = null!;
        public string? TenKhachHang { get; set; }
        public bool? DuocDuyet { get; set; }
        public string? Email { get; set; }
        public string? SoDt { get; set; }
        public bool? TrangThaiHoatDong { get; set; }
        public string? CodeMonet { get; set; }
        public string? MaKhachHangB2b { get; set; }
        public string? MaKhachHangB2c { get; set; }
        public string? MaPhuongThuc { get; set; }
        public string? MaKhoQuaTang { get; set; }
        public string? MaLoaiThe { get; set; }
        public string? MaTtXuatHd { get; set; }
        public string? MaKhachHangGonsa { get; set; }
        public string? DoUuTien { get; set; }
        public string? GhiChu { get; set; }
        public string? TenChuNhaThuoc { get; set; }
        public string? DiaChi { get; set; }
    }
}
