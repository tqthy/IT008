using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class NhietDoHienTai : EventArgs
    {
        private double nhietDoHT;
        public double NhietDoHT
        {
            set { nhietDoHT = value; }
            get { return nhietDoHT; }
        }

        public NhietDoHienTai(double nhietDoHT)
        {
            this.NhietDoHT=nhietDoHT;
        }
    }
}
