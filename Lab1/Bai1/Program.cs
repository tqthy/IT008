using System;
namespace Bai01
{
    public class Diem
    {
        private float x;
        private float y;
        public void Nhap()
        {
            Console.Write("Nhap toa do x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y: ");
            y = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Toa do x: {0}, y: {1}", x, y);
        }
        public double KhoangCach(Diem A)
        {
            return Math.Sqrt(Math.Pow(A.x - x, 2) + Math.Pow(A.y - y, 2));
        }
    }


}