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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PanelSide.Height = btnHome.Height;
            PanelSide.Top = btnHome.Top;
            home1.BringToFront();
        }

        private void btnAddDonater_Click(object sender, EventArgs e)
        {
            PanelSide.Height = btnAddDonater.Height;
            PanelSide.Top = btnAddDonater.Top;
            addDonation1.BringToFront();
           
        }

        private void btnupdateDonater_Click(object sender, EventArgs e)
        {
            PanelSide.Height = btnupdateDonater.Height;
            PanelSide.Top = btnupdateDonater.Top;
            updateData1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PanelSide.Height = btnSearch.Height;
            PanelSide.Top = btnSearch.Top;
            searchData1.BringToFront();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            PanelSide.Height = btnCertificate.Height;
            PanelSide.Top = btnCertificate.Top;
            reportOfData1.BringToFront();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            string msg = "Do you want to logout the account?";
            string msg2 = "LOGOUT";
            MessageBoxButtons btn=MessageBoxButtons.OKCancel;
            DialogResult rs = MessageBox.Show(msg, msg2, btn, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
