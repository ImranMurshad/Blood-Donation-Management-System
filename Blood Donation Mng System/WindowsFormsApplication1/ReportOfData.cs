using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace WindowsFormsApplication1
{
    public partial class ReportOfData : UserControl
    {
        public ReportOfData()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select fullname from DonaterData ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbSearchType.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.Visible = true;

            string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
            SqlConnection con = new SqlConnection(constring);
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            //  reportpages.SetPage(((Control)sender).Text);
            if (cbSearchType.Text != "")
            {
                try
                {


                    adp = new SqlDataAdapter("select * from DonaterData where fullname='" + cbSearchType.Text + "' ", con);
                    // adp = new SqlDataAdapter("Select * from tbl_Billing", con);
                    adp.Fill(ds);
                    ReportDocument rd = new ReportDocument();
                    rd.Load(@"E:\Projects\ADO.NET Projects\Blood Donation Mng sys(Akash Patil 1740)\Blood Donation Mng System\WindowsFormsApplication1\CrystalReport1.rpt");
                    rd.SetDataSource(ds.Tables[0]);
                    crystalReportViewer1.ReportSource = rd;
                    crystalReportViewer1.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}
