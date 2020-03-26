using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06 {
    public partial class Form3 : Form {
        Graphics g;
        Point prev;
        Pen pen;

        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            g = CreateGraphics();
            pen = new Pen(new SolidBrush(Color.Red));
            prev = new Point();
        }

        private void Form3_MouseEnter(object sender, EventArgs e) {
            prev = PointToClient(Control.MousePosition);
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e) {
            g.DrawLine(pen, prev, e.Location);
            prev = e.Location;
        }
    }
}
