using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class NhietKe
    {
        private double nhietDo;
        public event EventHandler suKienThayDoiNhietDo;
        public double NhietDo
        {
            get { return nhietDo; }
            set
            {
                nhietDo= value;
                suKienThayDoiNhietDo?.Invoke(this, new NhietDoHienTai(value));
            }
        }
    }
}
