using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class AddDonation : UserControl
    {
        public AddDonation()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            txtfullname.Text = "";
            txtfathername.Text = "";
            txtmothername.Text = "";

            txtmobno.Text = "";
            txtemailid.Text = "";
            cbbloodgr.Text = "";
            txtcityname.Text = "";
            txtaddress.Text = "";
            cbGender.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {


                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring); 
                string sql = "insert into DonaterData values(@fullname,@fathername,@mothername,@dob,@mobno,@gender,@emailid,@bloodgr,@city,@address)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
                cmd.Parameters.AddWithValue("@fathername", txtfathername.Text);
                cmd.Parameters.AddWithValue("@mothername", txtmothername.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);

                cmd.Parameters.AddWithValue("@mobno", txtmobno.Text);
                cmd.Parameters.AddWithValue("@gender", cbGender.Text);
                cmd.Parameters.AddWithValue("@emailid", txtemailid.Text);
                cmd.Parameters.AddWithValue("@bloodgr", cbbloodgr.Text);
                cmd.Parameters.AddWithValue("@city", txtcityname.Text);
                cmd.Parameters.AddWithValue("@address", txtaddress.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                //  SqlCommand cmd = new SqlCommand(sql, con);
                int x = cmd.ExecuteNonQuery();
                con.Close();


                // pictureBox1.Image = null;
                MessageBox.Show(x.ToString() + "   Record Insrted");
                Clear();

              




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
