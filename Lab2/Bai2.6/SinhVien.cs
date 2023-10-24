using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2._6
{
    public class SinhVien
    {
        private string mSSV;
        private string hoTen;
        private double diemToan;
        private double diemAnh;
        private double diemVan;

        public SinhVien(string mSSV = "unknown", string hoTen = "unknown", double diemToan = 0, double diemAnh = 0, double diemVan = 0)
        {
            this.mSSV = mSSV;
            this.hoTen = hoTen;
            this.diemToan = diemToan;
            this.diemAnh = diemAnh;
            this.diemVan = diemVan;
        }

        public string MSSV { get { return mSSV; } set { mSSV = value; } }
        public string HoTen { get { return hoTen; } set { hoTen = value; } }
        public double DiemToan
        {
            get { return diemToan; }
            set
            {
                if (value < 0 || value > 10)
                {
                    diemToan = 0;
                }
                else
                {
                    diemToan = value;
                }
            }
        }

        public double DiemAnh
        {
            get { return diemAnh; }
            set
            {
                if (value < 0 || value > 10)
                {
                    diemAnh = 0;
                }
                else
                {
                    diemAnh = value;
                }
            }
        }
        public double DiemVan
        {
            get { return diemVan; }
            set
            {
                if (value < 0 || value > 10)
                {
                    diemVan = 0;
                }
                else
                {
                    diemVan = value;
                }
            }
        }

        public double DiemTrungBinh()
        {
            return (diemToan + diemVan + diemAnh) / 3;
        }
    }
}
