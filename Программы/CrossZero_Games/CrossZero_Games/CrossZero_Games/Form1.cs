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

namespace CrossZero_Games{
    public partial class Form1 : Form{
        string USER_CHAR, AI_CHAR, EMPTY_CHAR = "_";
        byte sizePole, winerSize;
        bool AI_TURN = true, USER_TURN = false;
        Button[,] pole2;
        Dictionary<string,int> scores = new Dictionary<string,int>();

        public Form1(){
            InitializeComponent();
        }

        private bool GetWiner2(Button[,] copyPole, int x, int y) {
            bool checkWays;
            string CHECK_CHAR = copyPole[x, y].Text;
            //------------------Right--------------------
            checkWays = true;
            if (y + winerSize <= sizePole) {
                for (int k = y + 1; k < y + winerSize; k++) {
                    if (copyPole[x, k].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                }
                if (checkWays) return true;
            }
            //------------------Left--------------------
            checkWays = true;
            if (y + 1 - winerSize >= 0) {
                for (int k = y - 1; k > y - winerSize; k--) {
                    if (copyPole[x, k].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                }
                if (checkWays) return true;
            }
            //------------------Down--------------------
            checkWays = true;
            if (x + winerSize <= sizePole) {
                for (int k = x + 1; k < x + winerSize; k++) {
                    if (copyPole[k, y].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                }
                if (checkWays) return true;
            }
            //------------------Up--------------------
            checkWays = true;
            if (x + 1 - winerSize >= 0) {
                for (int k = x - 1; k > x - winerSize; k--) {
                    if (copyPole[k, y].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                }
                if (checkWays) return true;
            }
            //------------------Right and Up--------------------
            checkWays = true;
            if (y + winerSize <= sizePole && x + 1 - winerSize >= 0) {
                byte k1 = 1;
                while (k1 < winerSize) {
                    if (copyPole[x - k1, y + k1].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                    k1++;
                }
                if (checkWays) return true;
            }
            //------------------Left and Up--------------------
            checkWays = true;
            if (y + 1 - winerSize >= 0 && x + 1 - winerSize >= 0) {
                byte k1 = 1;
                while (k1 < winerSize) {
                    if (copyPole[x - k1, y - k1].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                    k1++;
                }
                if (checkWays) return true;
            }
            //------------------Left and Down--------------------
            checkWays = true;
            if (y + 1 - winerSize >= 0 && x + winerSize <= sizePole) {
                byte k1 = 1;
                while (k1 < winerSize) {
                    if (copyPole[x + k1, y - k1].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                    k1++;
                }
                if (checkWays) return true;
            }
            //------------------Right and Down--------------------
            checkWays = true;
            if (y + winerSize <= sizePole && x + winerSize <= sizePole) {
                byte k1 = 1;
                while (k1 < winerSize) {
                    if (copyPole[x + k1, y + k1].Text != CHECK_CHAR) {
                        checkWays = false;
                        break;
                    }
                    k1++;
                }
                if (checkWays) return true;
            }
            return false;
        }

        private string GetMoveAI(){

            string move = null;
            List<string> possibleMoves = new List<string>();
            for (int i = 0; i < sizePole; i++)
                for (int j = 0; j < sizePole; j++)
                    if (pole2[i, j].Text == EMPTY_CHAR) possibleMoves.Add(pole2[i, j].Name);
            Random random = new Random();
            return possibleMoves[random.Next(0,possibleMoves.Count)];
        }

        private void buttonPoleClick(object sender, EventArgs e){

            sender.GetType().GetProperty("Text").SetValue(sender,USER_CHAR);
            sender.GetType().GetProperty("Enabled").SetValue(sender, false);
            string s = sender.GetType().GetProperty("Name").GetValue(sender).ToString();
            bool is_user_winer = GetWiner2(pole2, System.Convert.ToInt32(s.Split(' ')[0]), System.Convert.ToInt32(s.Split(' ')[1]));

            if (is_user_winer){
                this.label4.Text = "User is winer";
                MessageBox.Show("User is winer");
                for (int i = 0; i < sizePole; i++)
                    for (int j = 0; j < sizePole; j++)
                        pole2[i, j].Visible = false;
            }
            else{
                for (int i = 0; i < sizePole; i++)
                    for (int j = 0; j < sizePole; j++)
                        if (pole2[i, j].Enabled) pole2[i, j].Visible = false;
                string AIMove = GetMoveAI();
                for (int i = 0; i < sizePole; i++){
                    for (int j = 0; j < sizePole; j++){
                        if (pole2[i, j].Text == EMPTY_CHAR && pole2[i, j].Name == AIMove) {
                            pole2[i, j].Text = AI_CHAR;
                            pole2[i, j].Enabled = false;
                        }
                        pole2[i, j].Visible = true;
                    }
                }
                bool winer = GetWiner2(pole2,System.Convert.ToInt32(AIMove.Split(' ')[0]), System.Convert.ToInt32(AIMove.Split(' ')[1]));
                if (winer){
                    this.label4.Text = "AI is winer";
                    MessageBox.Show("AI is winer");
                    for (int i = 0; i < sizePole; i++)
                        for (int j = 0; j < sizePole; j++)
                            if (pole2[i, j].Enabled) pole2[i, j].Enabled = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e){

            if (radioButton1.Checked || radioButton2.Checked){
                if (this.radioButton1.Checked){
                    USER_CHAR = radioButton1.Text;
                    AI_CHAR = radioButton2.Text;
                }
                else{
                    USER_CHAR = radioButton2.Text;
                    AI_CHAR = radioButton1.Text;
                }

                scores.Add(USER_CHAR, -100);
                scores.Add(AI_CHAR, 100);
                scores.Add("DRAW", 0);

                sizePole = System.Convert.ToByte(this.numericUpDown1.Value);
                winerSize = System.Convert.ToByte(this.numericUpDown2.Value);
                int heightButtons = this.groupBox2.Height / sizePole - 3;
                Size buttonSize = new Size(this.groupBox2.Width / sizePole - 3, heightButtons);
                Font buttonsFont = new Font("Arial", heightButtons / 2);
                pole2 = new Button[sizePole, sizePole];

                this.groupBox2.Visible = false;
                for (int i = 0; i < sizePole; i++){
                    for (int j = 0; j < sizePole; j++){
                        Button button = new Button();
                        button.Name = i + " " + j;
                        button.Font = buttonsFont;
                        button.Text = "_";
                        button.Size = buttonSize;
                        button.Location = new Point(this.groupBox2.Location.X + j * button.Size.Width, this.groupBox2.Location.Y + i * button.Size.Height);
                        button.Click += buttonPoleClick;
                        pole2[i, j] = button;
                        this.groupBox2.Controls.Add(button);
                    }
                }
                this.button1.Enabled = false;
                this.groupBox2.Visible = true;
            }
            else {
                MessageBox.Show("Выберите символ, чтобы начать игру!!!");
            }
        }

        private void numericUpDown2_Click(object sender, EventArgs e){
            this.numericUpDown2.Maximum = this.numericUpDown1.Value;
        }

        private void numericUpDown1_Click(object sender, EventArgs e){
            if (this.numericUpDown2.Value > this.numericUpDown1.Value){
                this.numericUpDown2.Value = this.numericUpDown1.Value;
            }
        }
    }
}