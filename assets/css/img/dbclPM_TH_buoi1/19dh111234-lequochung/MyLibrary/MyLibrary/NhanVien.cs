using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class NhanVien
    {
        public float lCB = 1490000;
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public float luongThang = 0;
        public DateTime ngaySinh { get; set; }
        public BangCap bangNV = null;
        public ThamNien thamNienNV = null;
        public ChucDanh cd = null;
        public PhongBan pb = null;
        public float luongPT = 0;
        public float luongGio = 0;
        public float luongOver = 0;
        public float giocong { get; set; }
        public float soGioOver { get; set; }
        public int soThangDongBHXH { get; set; }
        public int soThangBHXH { get; set; }
        public float timeBHXHtrc2014 { get; set; }
        public float timeBHXHsau2014 { get; set; }
        public float huongBHXH = 0;
        public float huongBHYT = 0;

        public NhanVien()
        {

        }
        public NhanVien(string ma, string ten, float luong, DateTime ngay, string tenBC, DateTime ngayVao, string tenCD, string tenPB)
        {
            maNV = ma;
            tenNV = ten;
            luongThang = luong;
            ngaySinh = ngay;
            bangNV = new BangCap(tenBC);
            thamNienNV = new ThamNien(ngayVao);
            cd = new ChucDanh(tenCD);
            pb = new PhongBan(tenPB);
        }

        public float TinhLuongThang()
        {
            luongThang = lCB * (thamNienNV.TinhHeSoThamNien() + bangNV.TinhHeSoBC() + cd.TinhHeSoChucDanh()) + pb.TinhPhuCap();
            return luongThang;
        }

        public float TinhLuongPartTime()
        {
            luongPT = lCB * 55 / 100;
            return luongPT;
        }
        public float TinhLuongGio()
        {
            luongGio = (TinhLuongThang() / (22 * 8)) * giocong;
            return luongGio;
        }
        public float TinhLuongOverTime(string leYesNO)
        {
            if (leYesNO == "YES")
            {
                luongOver = (TinhLuongGio() * 3);
                return luongOver;
            }
            else
            {
                luongOver = TinhLuongGio() * 1.5f;
                return luongOver;
            }
        }
        public float TinhBHXH()
        {
            float Mbqtl = (soThangDongBHXH * TinhLuongThang() * 1) / soThangBHXH;
            huongBHXH = (1.5f * Mbqtl * timeBHXHtrc2014) + (2.0f * Mbqtl * timeBHXHtrc2014);
            return huongBHXH;
        }
        public float TinhBHYT(int nguoithumay)
        {
            if (nguoithumay <= 1)
            {
                huongBHYT = lCB * 0.45f;
                return huongBHYT;
            }
            else if (nguoithumay > 1 && nguoithumay <= 2)
            {
                huongBHYT = lCB * 0.7f;
                return huongBHYT;
            }
            else if (nguoithumay > 2 && nguoithumay <= 3)
            {
                huongBHYT = lCB * 0.6f;
                return huongBHYT;
            }
            else if (nguoithumay > 3 && nguoithumay <= 4)
            {
                huongBHYT = lCB * 0.5f;
                return huongBHYT;
            }
            else
            {
                huongBHYT = lCB * 0.4f;
                return huongBHYT;
            }
        }
    }
}
