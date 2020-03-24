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
    public partial class Form7 : Form {
        Graphics g;
        Size size = new Size(50, 50);
        Point loc;
        double step = 1;

        public Form7() {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.BlueViolet), new Rectangle(loc, size));
        }

        private void Form7_Load(object sender, EventArgs e) {
            loc = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
        }

        private void Form7_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Left) loc = new Point((int)(loc.X - step), loc.Y);
            if (e.KeyCode == Keys.Right) loc = new Point((int)(loc.X + step), loc.Y);
            if (e.KeyCode == Keys.Down) loc = new Point(loc.X, (int)(loc.Y + step));
            if (e.KeyCode == Keys.Up) loc = new Point(loc.X, (int)(loc.Y - step));
            pictureBox1.Refresh();
        }
    }
}
