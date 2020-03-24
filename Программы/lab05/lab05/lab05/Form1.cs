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
    public partial class Form1 : Form {
        Graphics g;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CX.Maximum = pictureBox1.Width;
            CY.Maximum = pictureBox1.Height;
            R.Maximum = Math.Ceiling(CX.Maximum / 2);
        }

        private void button1_Click(object sender, EventArgs e) {
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.Red), new Rectangle(new Point((int)(CX.Value - R.Value), (int)(CY.Value - R.Value)), new Size((int)(2 * R.Value), (int)(2 * R.Value))));
        }
    }
}
