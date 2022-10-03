using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class PhongBan
    {
        public string tenPB { get; set; }
        public float luongPhuCap { get; set; }

        public PhongBan(string ten)
        {
            tenPB = ten;
        }
        public float TinhPhuCap()
        {
            float luongpc = 0;
            switch (tenPB)
            {
                case "NS":
                    {
                        luongpc = 1490000 * 0.3f;
                        break;
                    }
                case "HC":
                    {
                        luongpc = 1490000 * 0.3f;
                        break;
                    }
                case "KT":
                    {
                        luongpc = 1490000 * 0.3f;
                        break;
                    }
            }
            return luongpc;
        }
    }
    public class ChucDanh
    {
        public string tenCD { get; set; }
        public float hesoCD { get; set; }

        public ChucDanh(string ten)
        {
            tenCD = ten;
        }
        public float TinhHeSoChucDanh()
        {
            float hs = 1;
            switch (tenCD)
            {
                case "GD":
                    {
                        hs = 5.0f;
                        break;
                    }
                case "PGD":
                    {
                        hs = 4.0f;
                        break;
                    }
                case "TP":
                    {
                        hs = 3.0f;
                        break;
                    }
                case "PP":
                    {
                        hs = 2.0f;
                        break;
                    }
                case "NV":
                    {
                        hs = 1.0f;
                        break;
                    }
            }
            return hs;
        }
    }
}
