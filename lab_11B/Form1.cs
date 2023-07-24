using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_11B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subtotaltxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            int subtotal = Convert.ToInt32(subtotaltxt.Text);
            int discount = Convert.ToInt32(discounttxt.Text);
            int discountAmt = subtotal * discount / 100;
            int total = subtotal - discountAmt;
            int ptotal = total;
            subtotaltxt.Text = subtotal.ToString();
            discountAmtxt.Text = discountAmt.ToString();
            totaltxt.Text = total.ToString();
            ptotaltxt.Text = ptotal.ToString();
        }

        private void discounttxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void discountAmtxt_TextChanged(object sender, EventArgs e)
        {
            int discount = Convert.ToInt32(discounttxt.Text);
            int subtotal = Convert.ToInt32(subtotaltxt.Text);
            int discountAmt = subtotal * discount / 100;
            discountAmtxt.Text = discountAmt.ToString();
        }

        private void totaltxt_TextChanged(object sender, EventArgs e)
        {
            int total = Convert.ToInt32(subtotaltxt.Text) - Convert.ToInt32(discountAmtxt.Text);
            totaltxt.Text = total.ToString();
        }

        private void ptotaltxt_TextChanged(object sender, EventArgs e)
        {
            int ptotal = Convert.ToInt32(totaltxt.Text);
            ptotaltxt.Text = ptotal.ToString();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
