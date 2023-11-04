using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._6
{
    public class SinhVien
    {
        private string mssv;
        private string hoten;
        private string gioitinh;
        private string ngaysinh;
        private string diachi;
        private string sdt;
        private string email;
        public SinhVien(string mssv = "null", string hoten = "null", string gioitinh = "null", string ngaysinh = "null",
                            string diachi = "null", string sdt = "null", string email = "null")
        {
            this.mssv = mssv;
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            this.sdt = sdt;
            this.email = email;
        }
        public string Mssv
        {
            get
            {
                return mssv;
            }
            set
            {
                mssv = value;
            }
        }
        public string Hoten
        { get 
            { 
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
      

    }
}
