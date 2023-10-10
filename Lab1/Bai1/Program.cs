using System;
namespace Bai01
{
    public class Diem
    {
        private float x;
        private float y;
        public float GetX()
        { 
            return x; 
        }
        public float GetY() 
        {
            return y;
        }
        public void Nhap()
        {
            Console.Write("Nhap toa do x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
        public double KhoangCach(Diem A)
        {
            return Math.Sqrt(Math.Pow(A.x - x, 2) + Math.Pow(A.y - y, 2));
        }
        
    }
    public abstract class Shape
    {
        protected Diem[] sodinh;
        protected string ten;
        public abstract void Nhap();
        public abstract float DienTich();
        public abstract void Ve();
    }
    public class HinhChuNhat : Shape
    {
        public HinhChuNhat()
        {
            sodinh = new Diem[4];
            ten = "Hinh Chu Nhat";
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap toa do cho 4 dinh");
            for (int i = 0; i < sodinh.Length; i++)
            {
                sodinh[i] = new Diem();
                sodinh[i].Nhap();
            }
        }
        public override float DienTich()
        {
            float dai = Math.Abs(sodinh[1].GetX() - sodinh[0].GetX());
            float rong = Math.Abs(sodinh[1].GetY() - sodinh[0].GetY());
            return dai * rong;
        }
        public override void Ve()
        {
            Console.WriteLine("Hinh chu nhat nay co cac tinh chat sau:");
            Console.WriteLine("\tToa do 4 dinh lan luot la: ");
            for (int i = 0; i < sodinh.Length; i++)
                sodinh[i].Xuat();
        }
    }
    public class HinhTamGiac : Shape
    {
        public HinhTamGiac()
        {
            sodinh = new Diem[3];
            ten = "Hinh Tam Giac";
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap toa do cho 3 dinh");
            for (int i = 0; i < sodinh.Length; i++)
            {
                sodinh[i] = new Diem();
                sodinh[i].Nhap();
            }
        }
        public override float DienTich()
        {
            float x1 = sodinh[0].GetX();
            float y1 = sodinh[0].GetY();
            float x2 = sodinh[1].GetX();
            float y2 = sodinh[1].GetY();
            float x3 = sodinh[2].GetX();
            float y3 = sodinh[2].GetY();
            float s = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2f);
            return s;
        }
        public override void Ve()
        {
            Console.WriteLine("Hinh tam giac nay co cac tinh chat sau:");
            Console.WriteLine("\tToa do 3 dinh lan luot la: ");
            for (int i = 0; i < sodinh.Length; i++)
                sodinh[i].Xuat();
        }
    }
    public class HinhTron  : Shape
    {
        private float r;
        public HinhTron()
        {
            sodinh = new Diem[1];
            ten = "Hinh Tron";
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap toa do tam: ");
            sodinh[0] = new Diem();
            sodinh[0].Nhap();
            Console.Write("Nhap ban kinh: ");
            r = float.Parse(Console.ReadLine());
        }
        public override float DienTich()
        {
            float s = 3.14f * r * r;
            return s;
        }
        public override void Ve()
        {
            Console.WriteLine("Hinh tron nay co cac tinh chat sau:");
            Console.Write("\tToa do tam la: ");
            sodinh[0].Xuat();
            Console.WriteLine("\tBan kinh: " + r);
        }
    }
    public class HinhVuong : HinhChuNhat
    {
        public HinhVuong()
        {
            sodinh = new Diem[4];
            ten = "Hinh Vuong";
        }
        public override void Nhap()
        {
            Console.WriteLine("Nhap toa do cho 4 dinh");
            for (int i = 0; i < sodinh.Length; i++)
            {
                sodinh[i] = new Diem();
                sodinh[i].Nhap();
            }
        }
        public override float DienTich()
        {
            float canh = Math.Abs(sodinh[1].GetX() - sodinh[0].GetX());
            return canh * canh;
        }
        public override void Ve()
        {
            Console.WriteLine("Hinh vuong nay co cac tinh chat sau:");
            Console.WriteLine("\tToa do 4 dinh lan luot la: ");
            for (int i = 0; i < sodinh.Length; i++)
                sodinh[i].Xuat();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so luong hinh muon tao:");
            n = int.Parse(Console.ReadLine());
            Random random = new Random();
            Shape[] shape = new Shape[n];
            //Các đỉnh được nhập theo ngược chiều kim đồng hồ
            for (int i = 0; i < n; i++)
            {
                int randomType = random.Next(1, 5); //1.hình chữ nhật 2.hình tam giác 3.hình tròn 4.hình vuông
                switch (randomType)
                {
                    case 1:
                        Console.WriteLine("Hinh Chu Nhat");
                        shape[i] = new HinhChuNhat();
                        break;
                    case 2:
                        Console.WriteLine("Hinh Tam Giac");
                        shape[i] = new HinhTamGiac();
                        break;
                    case 3:
                        Console.WriteLine("Hinh Tron");
                        shape[i] = new HinhTron();
                        break;
                    case 4:
                        Console.WriteLine("Hinh Vuong");
                        shape[i] = new HinhVuong();
                        break;
                    default: 
                        break;
                }
                shape[i].Nhap();
            }
            foreach (Shape h in shape)
            {
                h.Ve();
                Console.WriteLine("\tDien tich: " + h.DienTich());
                Console.ReadKey();
            }
        }
    }
}