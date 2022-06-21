using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace WindowsFormsApp5
    
{
    public partial class Form1 : Form
    {
        string[] password = System.IO.File.ReadAllLines(@"...\...\\passwords.txt");
        string[] username = System.IO.File.ReadAllLines(@"...\...\\usernames.txt");
        string[] cashString = System.IO.File.ReadAllLines(@"...\...\\Cash.txt");
        
        


        public Form1()
        {
            InitializeComponent();
        }
        
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

            string[] password = System.IO.File.ReadAllLines(@"...\...\\passwords.txt");
            string[] usernames = System.IO.File.ReadAllLines(@"...\...\\usernames.txt");

            
            List<string> passwordS = new List<string>(password);
            foreach (string str in password)
            {
                passwordS.Add(str);    
            }
            List<string> usernameS = new List<string>(username);
            foreach (string str in password)
            {
                usernameS.Add(str);
            }
            Console.ReadLine();
            groupBox2.Visible = false;
            foreach (string item in usernameS)
            {
                MessageBox.Show(item);
            }



        }

        private void txtusernameS_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtpasswordS_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            bool login = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (textBox2.Text == username[i] || txtusernameS.Text == "Username: " + username[i])
                {
                    if (textBox4.Text == password[i] || txtpasswordS.Text == "Password: " + password[i])
                    {
                        
                        login = true;
                        groupBox4.Visible = true;

                        
                    }
                }
            }
            if (login == false)
            {
                
                MessageBox.Show("Wrong username and/or password is incorrect.");
                txtpasswordS.Clear();
                txtusernameS.Clear();
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<double> Cash = new List<double>(cashString);
            
            //    foreach (string item in cashString)
            //{

            //}
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter(@"...\...\\Cash.txt"))
            {
                foreach (var Cash in cashString)
                {
                    sr.WriteLine(Cash);
                }

            }
        }

        private void btnPantsformpopup_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"GroupWindowsApp\GroupWindowsApp\bin\Debug\GroupWindowsApp.exe";
            startInfo.Arguments = "header.h";
            Process.Start(startInfo);
        }

        private void btnShirtsformpopup_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"ShirtSiteThing\WindowsFormsApp1\bin\Debug\WindowsFormsApp1.exe";
            startInfo.Arguments = "header.h";
            Process.Start(startInfo);
        }
    }
}
