namespace WindowsFormsApplication1
{
    partial class HomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnCertificate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnupdateDonater = new System.Windows.Forms.Button();
            this.btnAddDonater = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.home1 = new WindowsFormsApplication1.Home();
            this.addDonation1 = new WindowsFormsApplication1.AddDonation();
            this.updateData1 = new WindowsFormsApplication1.UpdateData();
            this.searchData1 = new WindowsFormsApplication1.SearchData();
            this.reportOfData1 = new WindowsFormsApplication1.ReportOfData();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.PanelSide);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnCertificate);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnupdateDonater);
            this.panel1.Controls.Add(this.btnAddDonater);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 799);
            this.panel1.TabIndex = 2;
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.White;
            this.PanelSide.Location = new System.Drawing.Point(0, 203);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(10, 64);
            this.PanelSide.TabIndex = 18;
            // 
            // btnlogout
            // 
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(3, 553);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(210, 64);
            this.btnlogout.TabIndex = 16;
            this.btnlogout.Text = "LogOut";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnCertificate
            // 
            this.btnCertificate.FlatAppearance.BorderSize = 0;
            this.btnCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCertificate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnCertificate.ForeColor = System.Drawing.Color.White;
            this.btnCertificate.Location = new System.Drawing.Point(3, 483);
            this.btnCertificate.Name = "btnCertificate";
            this.btnCertificate.Size = new System.Drawing.Size(210, 64);
            this.btnCertificate.TabIndex = 15;
            this.btnCertificate.Text = "Certificate";
            this.btnCertificate.UseVisualStyleBackColor = true;
            this.btnCertificate.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(0, 413);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(210, 64);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search blood Donater";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnupdateDonater
            // 
            this.btnupdateDonater.FlatAppearance.BorderSize = 0;
            this.btnupdateDonater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateDonater.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnupdateDonater.ForeColor = System.Drawing.Color.White;
            this.btnupdateDonater.Location = new System.Drawing.Point(0, 343);
            this.btnupdateDonater.Name = "btnupdateDonater";
            this.btnupdateDonater.Size = new System.Drawing.Size(210, 64);
            this.btnupdateDonater.TabIndex = 13;
            this.btnupdateDonater.Text = "Update Donater";
            this.btnupdateDonater.UseVisualStyleBackColor = true;
            this.btnupdateDonater.Click += new System.EventHandler(this.btnupdateDonater_Click);
            // 
            // btnAddDonater
            // 
            this.btnAddDonater.FlatAppearance.BorderSize = 0;
            this.btnAddDonater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDonater.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnAddDonater.ForeColor = System.Drawing.Color.White;
            this.btnAddDonater.Location = new System.Drawing.Point(3, 273);
            this.btnAddDonater.Name = "btnAddDonater";
            this.btnAddDonater.Size = new System.Drawing.Size(210, 64);
            this.btnAddDonater.TabIndex = 12;
            this.btnAddDonater.Text = "Add Donater";
            this.btnAddDonater.UseVisualStyleBackColor = true;
            this.btnAddDonater.Click += new System.EventHandler(this.btnAddDonater_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 203);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 64);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PanelHead
            // 
            this.PanelHead.Controls.Add(this.panel2);
            this.PanelHead.Location = new System.Drawing.Point(210, 1);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1214, 101);
            this.PanelHead.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 101);
            this.panel2.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_close_window_50px;
            this.pictureBox2.Location = new System.Drawing.Point(1154, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Donation";
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.home1);
            this.PanelMain.Controls.Add(this.addDonation1);
            this.PanelMain.Controls.Add(this.updateData1);
            this.PanelMain.Controls.Add(this.searchData1);
            this.PanelMain.Controls.Add(this.reportOfData1);
            this.PanelMain.Location = new System.Drawing.Point(213, 98);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1208, 701);
            this.PanelMain.TabIndex = 4;
            // 
            // home1
            // 
            this.home1.Location = new System.Drawing.Point(-3, 0);
            this.home1.Name = "home1";
            this.home1.Size = new System.Drawing.Size(1208, 701);
            this.home1.TabIndex = 4;
            this.home1.Load += new System.EventHandler(this.home1_Load);
            // 
            // addDonation1
            // 
            this.addDonation1.Location = new System.Drawing.Point(0, 0);
            this.addDonation1.Name = "addDonation1";
            this.addDonation1.Size = new System.Drawing.Size(1208, 701);
            this.addDonation1.TabIndex = 3;
            // 
            // updateData1
            // 
            this.updateData1.Location = new System.Drawing.Point(0, 0);
            this.updateData1.Name = "updateData1";
            this.updateData1.Size = new System.Drawing.Size(1208, 701);
            this.updateData1.TabIndex = 2;
            // 
            // searchData1
            // 
            this.searchData1.Location = new System.Drawing.Point(0, 0);
            this.searchData1.Name = "searchData1";
            this.searchData1.Size = new System.Drawing.Size(1208, 701);
            this.searchData1.TabIndex = 1;
            // 
            // reportOfData1
            // 
            this.reportOfData1.Location = new System.Drawing.Point(0, 0);
            this.reportOfData1.Name = "reportOfData1";
            this.reportOfData1.Size = new System.Drawing.Size(1208, 701);
            this.reportOfData1.TabIndex = 0;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 799);
            this.ControlBox = false;
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.PanelHead);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnCertificate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnupdateDonater;
        private System.Windows.Forms.Button btnAddDonater;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Home home1;
        private AddDonation addDonation1;
        private UpdateData updateData1;
        private SearchData searchData1;
        private ReportOfData reportOfData1;

    }
}