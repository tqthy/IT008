using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class ManHinh
    {
        public void HienThi(object sender,EventArgs e)
        {
            NhietDoHienTai nhietDoHienTai = (NhietDoHienTai)e;
            string format = nhietDoHienTai.NhietDoHT.ToString("F1");
            nhietDoHienTai.NhietDoHT=double.Parse(format);
            if (nhietDoHienTai.NhietDoHT > 70)
            {
                Console.WriteLine("Nhiet do qua cao.Nhiet ke tu dong tat sau 1s nua de khong bi hong");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (nhietDoHienTai.NhietDoHT < -50)
            {
                Console.WriteLine("Nhiet do qua thap.Nhiet ke tu dong tat sau 1s nua de khong bi hong");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            Console.WriteLine("Nhiet do hien tai la: " + nhietDoHienTai.NhietDoHT + " doC");
        }

        public void sub(NhietKe dangKy)
        {
            dangKy.suKienThayDoiNhietDo += HienThi;
        }
    }
}
