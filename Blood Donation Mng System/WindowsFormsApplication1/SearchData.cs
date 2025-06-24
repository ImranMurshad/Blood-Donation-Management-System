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

namespace WindowsFormsApplication1
{
    public partial class SearchData : UserControl
    {
        public SearchData()
        {
            InitializeComponent();
        }

        private void SearchData_Load(object sender, EventArgs e)
        {

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable donater = new DataTable();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from DonaterData", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                dataGridView1.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable donater = new DataTable();
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //con.ConnectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from DonaterData where mobno='" + cbMobNo.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                dataGridView1.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select mobno from DonaterData ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbMobNo.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
