using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class BangCap
    {
        public string tenBC { get; set; }
        public float hesoBC { get; set; }

        public BangCap(string tBC)
        {
            tenBC = tBC;
        }
        //Tinh theo he so bang cap
        public float TinhHeSoBC()
        {
            float hs = 0;
            switch (tenBC)
            {
                case "DuoiTH":
                    {
                        hs = 1.0f;
                        break;
                    }
                case "TH":
                    {
                        hs = 1.2f;
                        break;
                    }
                case "CD":
                    {
                        hs = 1.5f;
                        break;
                    }
                case "DH":
                    {
                        hs = 2.0f;
                        break;
                    }
                case "THS":
                    {
                        hs = 3.0f;
                        break;
                    }
                case "TS":
                    {
                        hs = 4.5f;
                        break;
                    }
            }
            return hs;
        }
    }
}
