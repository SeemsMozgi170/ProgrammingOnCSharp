using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05 {
    public partial class Form5 : Form {
        Graphics g;
        Size size = new Size(50, 50);
        Point loc;
        public Form5() {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e) {
            loc = new Point(size.Width, size.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(loc, size));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            loc = e.Location;
            pictureBox1.Refresh();
        }
    }
}
