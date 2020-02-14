using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossZero_Games
{
    public partial class Form1 : Form
    {
        string USER_CHAR;
        string AI_CHAR;
        string EMPTY_CHAR = "_";
        byte size;
        ArrayList pole = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonPoleClick(object sender, EventArgs e)
        {
            sender.GetType().GetProperty("Text").SetValue(sender,USER_CHAR);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!this.radioButton1.Checked && !this.radioButton2.Checked)
            {
                MessageBox.Show("Выберите символ, чтобы начать игру!!!");
            }
            else
            {
                if (this.radioButton1.Checked)
                {
                    USER_CHAR = radioButton1.Text;
                    AI_CHAR = radioButton2.Text;
                }
                else
                {
                    USER_CHAR = radioButton2.Text;
                    AI_CHAR = radioButton1.Text;
                }

                size = System.Convert.ToByte(this.numericUpDown1.Value);
                int heightButtons = this.groupBox2.Height / size - 3;
                Size buttonSize = new Size(this.groupBox2.Width / size - 3, heightButtons);
                Font buttonsFont = new Font("Arial", heightButtons/2);

                for (int i = 0; i < size; i++)
                {
                    pole.Add(new ArrayList());
                    for (int j = 0; j < size; j++)
                    {
                        Button button = new Button();
                        button.Name = i + " " + j;
                        button.Font = buttonsFont;
                        button.Text = "_";
                        button.Size = buttonSize;
                        button.Location = new Point(this.groupBox2.Location.X + j * button.Size.Width, this.groupBox2.Location.Y + i * button.Size.Height);
                        button.Click += buttonPoleClick;
                        pole.Add(button);
                        this.groupBox2.Controls.Add(button);
                    }
                }
                this.button1.Enabled = false;
            }
        }
    }
}
