using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             if (txtuname.Text == "Admin" && txtpass.Text=="123")
            {
                HomePage ob = new HomePage();
                ob.Show();
                MessageBox.Show("Welcome To Blood Donation Camp");

            }
            else { string msg = "Please Check the User name and Password";
            string msg2 = "LogIn";
            MessageBoxButtons btn=MessageBoxButtons.OKCancel;
            DialogResult rs = MessageBox.Show(msg, msg2, btn, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK)
            {
               
            }
            else
            {
                
            }  
            }
             if (txtuname.Text == "")
             {
                // MessageBox.Show("Please Enter the user name");
                // errorProvider1.ToString();
                 txtuname.Focus();
             }
             if (txtpass.Text == "")
             {
                 MessageBox.Show("Please Enter the Password");
                 txtpass.Focus();
             }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
