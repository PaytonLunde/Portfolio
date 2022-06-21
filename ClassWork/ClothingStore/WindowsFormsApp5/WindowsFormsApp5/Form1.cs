using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] username = { "username1", "username2" };
        string[] password = { "password1", "password2" };
        private void btnShopping_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            groupBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (username.Contains(txtusernameS.Text) && password.Contains(txtpasswordS.Text) && Array.IndexOf(username, txtusernameS.Text) == Array.IndexOf(password, txtpasswordS.Text))
            {
                groupBox3.Visible = true;
                groupBox2.Visible = false;

            }
            
        }

        private void txtusernameS_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtpasswordS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
