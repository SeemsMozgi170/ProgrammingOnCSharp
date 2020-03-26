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
    public partial class Form2 : Form {
        Graphics g;
        Pen pen;
        public Form2() {
            InitializeComponent();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                g.DrawLine(pen, 0, 0, e.X, e.Y);
            }
        }

        private void Form2_Load(object sender, EventArgs e) {
            g = CreateGraphics();
            pen = new Pen(new SolidBrush(Color.Red));
        }
    }
}
