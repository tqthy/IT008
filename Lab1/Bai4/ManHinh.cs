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
            Console.WriteLine("Nhiet do hien tai la: " + nhietDoHienTai.NhietDoHT + " doC");
        }

        public void sub(NhietKe dangKy)
        {
            dangKy.suKienThayDoiNhietDo += HienThi;
        }
    }
}
