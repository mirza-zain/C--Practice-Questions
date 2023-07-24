using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void additionbtn_Click(object sender, EventArgs e)
        {
            float num1 = Single.Parse(Message1lbl.Text);
            float num2 = Single.Parse(Message2txt.Text);
            float result = num1 + num2;
            Resulttxt.Text = result.ToString();

        }

        private void subtractionbtn_Click(object sender, EventArgs e)
        {
            float num1 = Single.Parse(Message1lbl.Text);
            float num2 = Single.Parse(Message2txt.Text);
            float result = num1 - num2;
            Resulttxt.Text = result.ToString();
        }

        private void multiplicationbtn_Click(object sender, EventArgs e)
        {
            float num1 = Single.Parse(Message1lbl.Text);
            float num2 = Single.Parse(Message2txt.Text);
            float result = num1 * num2;
            Resulttxt.Text = result.ToString();
        }

        private void Dividebtn_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Message1lbl.Text);
            int num2 = Int32.Parse(Message2txt.Text);
            int result = num1 / num2;
            Resulttxt.Text = result.ToString();
        }

        private void Reminderbtn_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(Message1lbl.Text);
            int num2 = Int32.Parse(Message2txt.Text);
            int result = num1 % num2;
            Resulttxt.Text = result.ToString();
        }

        private void Resulttxt_TextChanged(object sender, EventArgs e)
        {
            Resulttxt.ReadOnly = true;
        }
    }
}
