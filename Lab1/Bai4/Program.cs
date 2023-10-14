using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            NhietKe nhietKe = new NhietKe();
            ManHinh manHinh = new ManHinh();
            manHinh.sub(nhietKe);

            for(int i = 0; i < 20; i++)
            {
                Random rnd = new Random();
                nhietKe.NhietDo = rnd.Next(-30, 50);
                Thread.Sleep(1000);
            }
        }
    }
}
