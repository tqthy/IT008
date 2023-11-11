using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2._4
{
    public partial class frmPaint : Form
    {
        public frmPaint()
        {
            InitializeComponent();
        }

        private void frmPaint_Paint(object sender, PaintEventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, this.Width);
            int y = random.Next(0, this.Height);

            Font drawfont = new Font("Arial", 14);

            SolidBrush drawbrush = new SolidBrush(Color.Red);

            Graphics graphics = e.Graphics;
            graphics.DrawString("Paint event", drawfont, drawbrush, new PointF(x, y));
        }
    }
}
