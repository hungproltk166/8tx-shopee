using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ThamNien
    {
        public DateTime ngayGiaNhap { get; set; }
        public DateTime hesoThamNien { get; set; }

        public ThamNien(DateTime namGN)
        {
            ngayGiaNhap = namGN;
        }
        public float TinhHeSoThamNien()
        {
            DateTime homnay = DateTime.Now;
            int sonam = homnay.Year - ngayGiaNhap.Year;
            return (1 + sonam * 0.1f);
        }
    }
}
