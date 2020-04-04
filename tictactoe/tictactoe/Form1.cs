using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        public static char put = 'X';
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void restartGame()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label1.Text = "X Turn";

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        public char turnPut(char x)
        {
            label1.Text = turn();
            return (x == 'X') ? 'O' : 'X';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = put.ToString();
            button1.Enabled = false;
            put = turnPut(put);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = put.ToString();
            button2.Enabled = false;
            put = turnPut(put);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = put.ToString();
            button3.Enabled = false;
            put = turnPut(put);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = put.ToString();
            button4.Enabled = false;
            put = turnPut(put);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = put.ToString();
            button5.Enabled = false;
            put = turnPut(put);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = put.ToString();
            button6.Enabled = false;
            put = turnPut(put);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = put.ToString();
            button7.Enabled = false;
            put = turnPut(put);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = put.ToString();
            button8.Enabled = false;
            put = turnPut(put);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = put.ToString();
            button9.Enabled = false;
            put = turnPut(put);
        }

        public int checkWin()
        {
            string t1, t2, t3, t4, t5, t6, t7, t8, t9;
            t1 = button1.Text;
            t2 = button2.Text;
            t3 = button3.Text;
            t4 = button4.Text;
            t5 = button5.Text;
            t6 = button6.Text;
            t7 = button7.Text;
            t8 = button8.Text;
            t9 = button9.Text;

            if ((t1 == "X" && t2 == "X"  && t3 == "X" ) || (t4 =="X" && t5 == "X" && t6 == "X")  || (t7 =="X" && t8 == "X" && t9 == "X")  || (t1 =="X" && t4 == "X" && t7 == "X")  || (t2 =="X" && t5 == "X" && t8 == "X")  || (t3 =="X" && t6 == "X" && t9 == "X")  || (t1 =="X" && t5 == "X" && t9 == "X") || (t3 =="X" && t5 == "X" && t7 == "X"))
                return 1;
            if ((t1 == "O" && t2 == "X" && t3 == "O") || (t4 == "O" && t5 == "O" && t6 == "O") || (t7 == "O" && t8 == "O" && t9 == "O") || (t1 == "O" && t4 == "O" && t7 == "O") || (t2 == "O" && t5 == "O" && t8 == "O") || (t3 == "O" && t6 == "O" && t9 == "O") || (t1 == "O" && t5 == "O" && t9 == "O") || (t3 == "O" && t5 == "O" && t7 == "O"))
                return 2;
            return 0;
        }

        public string turn()
        {
            if (checkWin() == 1)
            {
                disableAll();
                MessageBox.Show("X win!");
                return "X Win!";
            }
             if (checkWin() == 2)
                {
                    disableAll();
                    MessageBox.Show("O Win!");
                    return "O Win!";
                }
              
            if (label1.Text == "X Turn")
                return "O Turn";
            else
                return "X Turn";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            restartGame();
            put = 'X';
        }

        public void disableAll()
        {
            
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }
    }
}
