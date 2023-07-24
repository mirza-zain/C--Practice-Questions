using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            string query;
            query = "Update User_Details set user_name ='" + nametxt.Text + "',user_reg =" + regtxt.Text + ",user_email ='" + emailtxt.Text + "' where user_ID = '"+idtxt.Text+"'";
            Database db = new Database();
            db.Insert_Delete_Update(query);
            bool check = true;
            if (check != true)
            {
                MessageBox.Show("Data not Updated");
            }
            else
            {
                MessageBox.Show("Data Updated");
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            String query;
            query = "Insert into User_Details values('" + nametxt.Text + "'," + regtxt.Text + ",'" + emailtxt.Text + "')";
            Database db = new Database();
            db.Insert_Delete_Update(query);
            bool check = true;
            if (check != true)
            {
                MessageBox.Show("Data not Inserted");
            }
            else
            {
                MessageBox.Show("Data Inserted");
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            String query;
            query = "delete from User_Details where user_ID = '" + idtxt.Text + "'";
            Database db = new Database();
            db.Insert_Delete_Update(query);
            bool check = true;
            if (check != true)
            {
                MessageBox.Show("Data not Deleted");
            }
            else
            {
                MessageBox.Show("Data Deleted");
            }
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            String query;
            query = "Select * from User_Details from where user_ID = '"+idtxt.Text+"'";
            Database db = new Database();
            db.select(query);
            bool check = true;
            if(check != true)
            {
                MessageBox.Show("Data not Selected");
            }
            else
            {
                MessageBox.Show("Data Selected");
            }
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
