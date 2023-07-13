using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentUserControl.Services
{
    public class ChiTietDonHangDTO
    {
        public string MaChiTiet { get; set; } = null!;
        public string MaDonHang { get; set; } = null!;
        public string MaSanPham { get; set; } = null!;
        public decimal? DonGiaHopKoVat { get; set; }
        public decimal? DonViHopCoVat { get; set; }
        public decimal? DonGiaDviKoVat { get; set; }
        public decimal? DonGiaDviCoVat { get; set; }
        public decimal? ThanhTienTrcCkKoVat { get; set; }
        public decimal? ThanhTienTrcCkCoVat { get; set; }
        public decimal? ThanhTienSauCkKoVat { get; set; }
        public decimal? ThueVat { get; set; }
        public decimal? TienVat { get; set; }
        public decimal? TienCkSanPham { get; set; }
        public decimal? PhanTramCkSp { get; set; }
        public decimal? TienCkThe { get; set; }
        public decimal? PhanTramCkThe { get; set; }
        public decimal? TienThanhToan { get; set; }
    }
}
