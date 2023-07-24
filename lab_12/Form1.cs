using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_12
{
    public partial class Loginfrm : Form
    {
        public Loginfrm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if(usertxt .Text == "Mirza" && passtxt .Text == "786")
            {
                MessageBox.Show("Login Successfull");
                Registerfrm frm = new Registerfrm();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }   
        }
    }
}
