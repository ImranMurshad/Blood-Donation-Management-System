namespace WindowsFormsApplication1
{
    partial class UpdateData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblid = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtcityname = new System.Windows.Forms.TextBox();
            this.cbbloodgr = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemailid = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblcityname = new System.Windows.Forms.Label();
            this.lblbloodgr = new System.Windows.Forms.Label();
            this.lblemailid = new System.Windows.Forms.Label();
            this.txtmobno = new System.Windows.Forms.TextBox();
            this.txtmothername = new System.Windows.Forms.TextBox();
            this.txtfathername = new System.Windows.Forms.TextBox();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmobno = new System.Windows.Forms.Label();
            this.lblmothername = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblfathername = new System.Windows.Forms.Label();
            this.lblfullname = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchType = new System.Windows.Forms.ComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.cbemail = new System.Windows.Forms.ComboBox();
            this.cbmobno = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(53, 181);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 17);
            this.lblid.TabIndex = 144;
            this.lblid.Visible = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(813, 156);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(138, 37);
            this.btnsearch.TabIndex = 143;
            this.btnsearch.Text = "SEARCH";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(472, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "UPDATE DONER";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Lime;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(465, 649);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(138, 48);
            this.btnupdate.TabIndex = 139;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(371, 405);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 22);
            this.dateTimePicker1.TabIndex = 138;
            // 
            // txtcityname
            // 
            this.txtcityname.Location = new System.Drawing.Point(833, 337);
            this.txtcityname.Name = "txtcityname";
            this.txtcityname.Size = new System.Drawing.Size(238, 22);
            this.txtcityname.TabIndex = 137;
            // 
            // cbbloodgr
            // 
            this.cbbloodgr.FormattingEnabled = true;
            this.cbbloodgr.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cbbloodgr.Location = new System.Drawing.Point(833, 278);
            this.cbbloodgr.Name = "cbbloodgr";
            this.cbbloodgr.Size = new System.Drawing.Size(238, 24);
            this.cbbloodgr.TabIndex = 136;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(790, 649);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(138, 48);
            this.btnreset.TabIndex = 135;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(833, 423);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(341, 157);
            this.txtaddress.TabIndex = 134;
            // 
            // txtemailid
            // 
            this.txtemailid.Location = new System.Drawing.Point(833, 225);
            this.txtemailid.Name = "txtemailid";
            this.txtemailid.Size = new System.Drawing.Size(238, 22);
            this.txtemailid.TabIndex = 133;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbladdress.Location = new System.Drawing.Point(703, 422);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(88, 22);
            this.lbladdress.TabIndex = 132;
            this.lbladdress.Text = "Address:";
            // 
            // lblcityname
            // 
            this.lblcityname.AutoSize = true;
            this.lblcityname.BackColor = System.Drawing.Color.Transparent;
            this.lblcityname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcityname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcityname.Location = new System.Drawing.Point(721, 336);
            this.lblcityname.Name = "lblcityname";
            this.lblcityname.Size = new System.Drawing.Size(51, 22);
            this.lblcityname.TabIndex = 131;
            this.lblcityname.Text = "City:";
            // 
            // lblbloodgr
            // 
            this.lblbloodgr.AutoSize = true;
            this.lblbloodgr.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbloodgr.Location = new System.Drawing.Point(686, 280);
            this.lblbloodgr.Name = "lblbloodgr";
            this.lblbloodgr.Size = new System.Drawing.Size(131, 22);
            this.lblbloodgr.TabIndex = 130;
            this.lblbloodgr.Text = "Blood Group:";
            // 
            // lblemailid
            // 
            this.lblemailid.AutoSize = true;
            this.lblemailid.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailid.Location = new System.Drawing.Point(703, 224);
            this.lblemailid.Name = "lblemailid";
            this.lblemailid.Size = new System.Drawing.Size(85, 22);
            this.lblemailid.TabIndex = 129;
            this.lblemailid.Text = "Email ID:";
            // 
            // txtmobno
            // 
            this.txtmobno.Location = new System.Drawing.Point(371, 481);
            this.txtmobno.Name = "txtmobno";
            this.txtmobno.Size = new System.Drawing.Size(238, 22);
            this.txtmobno.TabIndex = 125;
            // 
            // txtmothername
            // 
            this.txtmothername.Location = new System.Drawing.Point(371, 340);
            this.txtmothername.Name = "txtmothername";
            this.txtmothername.Size = new System.Drawing.Size(238, 22);
            this.txtmothername.TabIndex = 124;
            // 
            // txtfathername
            // 
            this.txtfathername.Location = new System.Drawing.Point(371, 281);
            this.txtfathername.Name = "txtfathername";
            this.txtfathername.Size = new System.Drawing.Size(238, 22);
            this.txtfathername.TabIndex = 123;
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(371, 225);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(238, 22);
            this.txtfullname.TabIndex = 122;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(180, 537);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(87, 22);
            this.lblgender.TabIndex = 121;
            this.lblgender.Text = "Gender:";
            // 
            // lblmobno
            // 
            this.lblmobno.AutoSize = true;
            this.lblmobno.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmobno.Location = new System.Drawing.Point(180, 481);
            this.lblmobno.Name = "lblmobno";
            this.lblmobno.Size = new System.Drawing.Size(106, 22);
            this.lblmobno.TabIndex = 120;
            this.lblmobno.Text = "Mobile No:";
            // 
            // lblmothername
            // 
            this.lblmothername.AutoSize = true;
            this.lblmothername.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmothername.Location = new System.Drawing.Point(180, 340);
            this.lblmothername.Name = "lblmothername";
            this.lblmothername.Size = new System.Drawing.Size(142, 22);
            this.lblmothername.TabIndex = 119;
            this.lblmothername.Text = "Mother Name:";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(180, 405);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(133, 22);
            this.lbldob.TabIndex = 118;
            this.lbldob.Text = "Date Of Birth:";
            // 
            // lblfathername
            // 
            this.lblfathername.AutoSize = true;
            this.lblfathername.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfathername.Location = new System.Drawing.Point(180, 280);
            this.lblfathername.Name = "lblfathername";
            this.lblfathername.Size = new System.Drawing.Size(135, 22);
            this.lblfathername.TabIndex = 117;
            this.lblfathername.Text = "Father Name:";
            // 
            // lblfullname
            // 
            this.lblfullname.AutoSize = true;
            this.lblfullname.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfullname.Location = new System.Drawing.Point(180, 225);
            this.lblfullname.Name = "lblfullname";
            this.lblfullname.Size = new System.Drawing.Size(103, 22);
            this.lblfullname.TabIndex = 116;
            this.lblfullname.Text = "Full Name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 79);
            this.panel1.TabIndex = 115;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(550, 163);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(238, 24);
            this.cbName.TabIndex = 145;
            this.cbName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 146;
            this.label1.Text = "Select Search Type:";
            // 
            // cbSearchType
            // 
            this.cbSearchType.FormattingEnabled = true;
            this.cbSearchType.Items.AddRange(new object[] {
            "Name",
            "E-mail",
            "MobileNo."});
            this.cbSearchType.Location = new System.Drawing.Point(550, 96);
            this.cbSearchType.Name = "cbSearchType";
            this.cbSearchType.Size = new System.Drawing.Size(238, 24);
            this.cbSearchType.TabIndex = 147;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(813, 85);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(138, 44);
            this.btnNext.TabIndex = 148;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(325, 162);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 22);
            this.lblType.TabIndex = 141;
            this.lblType.Text = "None";
            // 
            // cbemail
            // 
            this.cbemail.FormattingEnabled = true;
            this.cbemail.Location = new System.Drawing.Point(550, 163);
            this.cbemail.Name = "cbemail";
            this.cbemail.Size = new System.Drawing.Size(238, 24);
            this.cbemail.TabIndex = 149;
            this.cbemail.Visible = false;
            // 
            // cbmobno
            // 
            this.cbmobno.FormattingEnabled = true;
            this.cbmobno.Location = new System.Drawing.Point(550, 163);
            this.cbmobno.Name = "cbmobno";
            this.cbmobno.Size = new System.Drawing.Size(238, 24);
            this.cbmobno.TabIndex = 150;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbGender.Location = new System.Drawing.Point(371, 538);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(238, 24);
            this.cbGender.TabIndex = 151;
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.cbmobno);
            this.Controls.Add(this.cbemail);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbSearchType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtcityname);
            this.Controls.Add(this.cbbloodgr);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemailid);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblcityname);
            this.Controls.Add(this.lblbloodgr);
            this.Controls.Add(this.lblemailid);
            this.Controls.Add(this.txtmobno);
            this.Controls.Add(this.txtmothername);
            this.Controls.Add(this.txtfathername);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblmobno);
            this.Controls.Add(this.lblmothername);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblfathername);
            this.Controls.Add(this.lblfullname);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateData";
            this.Size = new System.Drawing.Size(1208, 701);
            this.Load += new System.EventHandler(this.UpdateData_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtcityname;
        private System.Windows.Forms.ComboBox cbbloodgr;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemailid;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblcityname;
        private System.Windows.Forms.Label lblbloodgr;
        private System.Windows.Forms.Label lblemailid;
        private System.Windows.Forms.TextBox txtmobno;
        private System.Windows.Forms.TextBox txtmothername;
        private System.Windows.Forms.TextBox txtfathername;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmobno;
        private System.Windows.Forms.Label lblmothername;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblfathername;
        private System.Windows.Forms.Label lblfullname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchType;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbemail;
        private System.Windows.Forms.ComboBox cbmobno;
        private System.Windows.Forms.ComboBox cbGender;
    }
}
