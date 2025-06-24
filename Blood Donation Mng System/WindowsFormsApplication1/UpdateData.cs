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
    public partial class UpdateData : UserControl
    {
        public UpdateData()
        {
            InitializeComponent();
        }

        private void UpdateData_Load(object sender, EventArgs e)
        {
            /*try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                //DataTable donater = new DataTable();
                con.Open();
                SqlCommand cmd = new SqlCommand("select fullname from DonaterData ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbName.Items.Add(dr[0].ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/
        }
        public void VisibilityTrue()
        {
            lblfullname.Visible = true;
            txtfullname.Visible = true;

        }
        public void clear()
        {
            txtfullname.Text = "";
            txtfathername.Text = "";
            txtmothername.Text = "";
            txtmobno.Text = "";
            cbGender.Text = "";
            txtemailid.Text = "";
            cbbloodgr.Text = "";
            txtcityname.Text = "";
            txtaddress.Text = "";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(cbSearchType.Text=="Name")
            {
                lblType.Text = "Enter the Full Name:";
                cbName.Visible = true;
                cbemail.Visible = false;
                cbmobno.Visible = false;
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
                        cbName.Items.Add(dr[0].ToString());
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
                if(cbSearchType.Text=="E-mail")
                {
                    lblType.Text = "Enter the E-mail ID:";
                    cbemail.Visible = true;
                    cbName.Visible = false;
                    cbmobno.Visible = false;
                    try
                    {
                        string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                        SqlConnection con = new SqlConnection(constring);
                        //DataTable donater = new DataTable();
                        con.Open();
                        SqlCommand cmd = new SqlCommand("select emailid from DonaterData ", con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            cbemail.Items.Add(dr[0].ToString());
                        }

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                    if(cbSearchType.Text=="MobileNo.")
                    {
                        lblType.Text = "Enter the Mobile No.";
                        cbmobno.Visible = true;
                        cbemail.Visible = false;
                        cbName.Visible = false;
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
                                cbmobno.Items.Add(dr[0].ToString());
                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
           
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (cbSearchType.Text == "Name")
            {

                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring); 
                    string sql = "select * from DonaterData where fullname='" + cbName.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    //  SqlCommand cmd = new SqlCommand(sql, con);
                    int x = cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                        lblid.Text = dr[0].ToString();
                        txtfullname.Text = dr[1].ToString();
                        txtfathername.Text = dr[2].ToString();
                        txtmothername.Text = dr[3].ToString();
                        dateTimePicker1.Text = dr[4].ToString();
                        txtmobno.Text = dr[5].ToString();
                        cbGender.Text=dr[6].ToString();
                        txtemailid.Text = dr[7].ToString();
                        cbbloodgr.Text = dr[8].ToString();
                        txtcityname.Text = dr[9].ToString();
                        txtaddress.Text = dr[10].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Data not Availebel");


                    }
                    con.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (cbSearchType.Text == "E-mail")
            {

                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring); 
                    string sql = "select * from DonaterData where emailid='" + cbemail.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    //  SqlCommand cmd = new SqlCommand(sql, con);
                    int x = cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                        lblid.Text = dr[0].ToString();
                        txtfullname.Text = dr[1].ToString();
                        txtfathername.Text = dr[2].ToString();
                        txtmothername.Text = dr[3].ToString();
                        dateTimePicker1.Text = dr[4].ToString();
                        txtmobno.Text = dr[5].ToString();
                        txtemailid.Text = dr[7].ToString();
                        cbbloodgr.Text = dr[8].ToString();
                        txtcityname.Text = dr[9].ToString();
                        txtaddress.Text = dr[10].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Data not Availebel");


                    }
                    con.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            if (cbSearchType.Text == "MobileNo.")
            {

                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring); 
                    string sql = "select * from DonaterData where mobno='" + cbmobno.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    //  SqlCommand cmd = new SqlCommand(sql, con);
                    int x = cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {
                        lblid.Text = dr[0].ToString();
                        txtfullname.Text = dr[1].ToString();
                        txtfathername.Text = dr[2].ToString();
                        txtmothername.Text = dr[3].ToString();
                        dateTimePicker1.Text = dr[4].ToString();
                        txtmobno.Text = dr[5].ToString();
                        txtemailid.Text = dr[7].ToString();
                        cbbloodgr.Text = dr[8].ToString();
                        txtcityname.Text = dr[9].ToString();
                        txtaddress.Text = dr[10].ToString();


                    }
                    else
                    {
                        MessageBox.Show("Data not Availebel");


                    }
                    con.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
             try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "update DonaterData set fullname=@fullname,fathername=@fathername,mothername=@mothername,dob=@dob,mobno=@mobno,gender=@gender,emailid=@emailid,bloodgr=@bloodgr,city=@city,address=@address where ID='" + lblid.Text + "'";
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
                MessageBox.Show(x.ToString() + "   Record updated");


                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
