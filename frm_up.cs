using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Ajandam
{
	/// <summary>
	/// Summary description for frm_up.
	/// </summary>
	public class frm_up : System.Windows.Forms.Form
	{
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
        private System.Windows.Forms.MenuItem menuItem12;
        private Label label1;
        private Label label2;
        private ComboBox cb_group;
        private Label label3;
        private TextBox txt_domain;
        private TextBox txt_url;
        private TextBox txt_ip;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel pnl_domain;
        private TextBox txt_cpanel;
        private TextBox txt_quota;
        private Label label8;
        private Label label7;
        private Button btn_iptal;
        private TextBox txt_serv4;
        private Button btn_kaydet;
        private TextBox txt_serv3;
        private TextBox txt_serv2;
        private TextBox txt_serv1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private DateTimePicker dtp_bitis;
        private DateTimePicker dtp_baslangic;
        private Label label14;
        private Label label13;
        private Panel pnl_forum;
        private Button btn_fiptal;
        private Button btn_fkaydet;
        private TextBox txt_furl;
        private Label label15;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem16;
        private TextBox txt_fpass;
        private TextBox txt_fuser;
        private Label label17;
        private Label label16;
        private MenuItem menuItem17;
        private Panel pnl_gsm;
        private Button btn_giptal;
        private Button btn_gkaydet;
        private Panel pnl_bank;
        private Button btn_biptal;
        private Button btn_bkaydet;
        private Panel pnl_web;
        private Panel pnl_computer;
        private Panel pnl_hosting;
        private Button btn_hiptal;
        private Button btn_hkaydet;
        private Button btn_ciptal;
        private Button btn_ckaydet;
        private Button btn_wiptal;
        private Button btn_wkaydet;
        private Panel pnl_email;
        private Button btn_eiptal;
        private Button btn_ekaydet;
        private TextBox txt_gpin1;
        private TextBox txt_gmodel;
        private TextBox txt_gmake;
        private TextBox txt_gnumber;
        private TextBox txt_gname;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label26;
        private Label label25;
        private Label label24;
        private Label label23;
        private TextBox txt_gcode;
        private TextBox txt_gpuk2;
        private TextBox txt_gpuk1;
        private TextBox txt_gpin2;
        private Label label29;
        private Label label28;
        private Label label27;
        private TextBox txt_epass;
        private TextBox txt_eaccound;
        private TextBox txt_edomain;
        private Label label32;
        private Label label31;
        private Label label30;
        private TextBox txt_wpass;
        private TextBox txt_wuser;
        private TextBox txt_wdomain;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private TextBox txt_bpass;
        private TextBox txt_buser;
        private TextBox txt_bcname;
        private TextBox txt_bccode;
        private TextBox txt_bcnumber;
        private TextBox txt_bbname;
        private Label label39;
        private Label label38;
        private Label label37;
        private TextBox txt_ccname;
        private Label label43;
        private Label label42;
        private Label label41;
        private Label label40;
        private TextBox txt_cvname;
        private TextBox txt_csname;
        private TextBox txt_cuname;
        private Label label44;
        private TextBox txt_cpass;
        private DateTimePicker dateTimePicker1;
        private IContainer components;

		public frm_up()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_up));
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.menuItem8 = new System.Windows.Forms.MenuItem();
            this.menuItem9 = new System.Windows.Forms.MenuItem();
            this.menuItem10 = new System.Windows.Forms.MenuItem();
            this.menuItem11 = new System.Windows.Forms.MenuItem();
            this.menuItem12 = new System.Windows.Forms.MenuItem();
            this.menuItem13 = new System.Windows.Forms.MenuItem();
            this.menuItem14 = new System.Windows.Forms.MenuItem();
            this.menuItem15 = new System.Windows.Forms.MenuItem();
            this.menuItem16 = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_group = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_domain = new System.Windows.Forms.TextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_domain = new System.Windows.Forms.Panel();
            this.dtp_bitis = new System.Windows.Forms.DateTimePicker();
            this.dtp_baslangic = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.txt_serv4 = new System.Windows.Forms.TextBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.txt_serv3 = new System.Windows.Forms.TextBox();
            this.txt_serv2 = new System.Windows.Forms.TextBox();
            this.txt_serv1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cpanel = new System.Windows.Forms.TextBox();
            this.txt_quota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnl_forum = new System.Windows.Forms.Panel();
            this.txt_fpass = new System.Windows.Forms.TextBox();
            this.txt_fuser = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_furl = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_fiptal = new System.Windows.Forms.Button();
            this.btn_fkaydet = new System.Windows.Forms.Button();
            this.pnl_gsm = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_gcode = new System.Windows.Forms.TextBox();
            this.txt_gpuk2 = new System.Windows.Forms.TextBox();
            this.txt_gpuk1 = new System.Windows.Forms.TextBox();
            this.txt_gpin2 = new System.Windows.Forms.TextBox();
            this.txt_gpin1 = new System.Windows.Forms.TextBox();
            this.txt_gmodel = new System.Windows.Forms.TextBox();
            this.txt_gmake = new System.Windows.Forms.TextBox();
            this.txt_gnumber = new System.Windows.Forms.TextBox();
            this.txt_gname = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_giptal = new System.Windows.Forms.Button();
            this.btn_gkaydet = new System.Windows.Forms.Button();
            this.pnl_bank = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_bpass = new System.Windows.Forms.TextBox();
            this.txt_buser = new System.Windows.Forms.TextBox();
            this.txt_bcname = new System.Windows.Forms.TextBox();
            this.txt_bccode = new System.Windows.Forms.TextBox();
            this.txt_bcnumber = new System.Windows.Forms.TextBox();
            this.txt_bbname = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btn_biptal = new System.Windows.Forms.Button();
            this.btn_bkaydet = new System.Windows.Forms.Button();
            this.pnl_web = new System.Windows.Forms.Panel();
            this.txt_wpass = new System.Windows.Forms.TextBox();
            this.txt_wuser = new System.Windows.Forms.TextBox();
            this.txt_wdomain = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_wiptal = new System.Windows.Forms.Button();
            this.btn_wkaydet = new System.Windows.Forms.Button();
            this.pnl_computer = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_cpass = new System.Windows.Forms.TextBox();
            this.txt_cvname = new System.Windows.Forms.TextBox();
            this.txt_csname = new System.Windows.Forms.TextBox();
            this.txt_cuname = new System.Windows.Forms.TextBox();
            this.txt_ccname = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.btn_ciptal = new System.Windows.Forms.Button();
            this.btn_ckaydet = new System.Windows.Forms.Button();
            this.pnl_hosting = new System.Windows.Forms.Panel();
            this.btn_hiptal = new System.Windows.Forms.Button();
            this.btn_hkaydet = new System.Windows.Forms.Button();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.txt_epass = new System.Windows.Forms.TextBox();
            this.txt_eaccound = new System.Windows.Forms.TextBox();
            this.txt_edomain = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_eiptal = new System.Windows.Forms.Button();
            this.btn_ekaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.pnl_domain.SuspendLayout();
            this.pnl_forum.SuspendLayout();
            this.pnl_gsm.SuspendLayout();
            this.pnl_bank.SuspendLayout();
            this.pnl_web.SuspendLayout();
            this.pnl_computer.SuspendLayout();
            this.pnl_hosting.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 551);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(792, 22);
            this.statusBar1.TabIndex = 0;
            // 
            // dataGrid1
            // 
            this.dataGrid1.CaptionText = "Today";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGrid1.Location = new System.Drawing.Point(0, 336);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(792, 208);
            this.dataGrid1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 70);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2,
            this.menuItem8,
            this.menuItem13});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem6});
            this.menuItem1.Text = "Ajandam";
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 0;
            this.menuItem6.Text = "Exit";
            this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.menuItem4,
            this.menuItem5,
            this.menuItem7});
            this.menuItem2.Text = "Person";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "Save";
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "Edit";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "Delete";
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 3;
            this.menuItem7.Text = "Search";
            this.menuItem7.Click += new System.EventHandler(this.menuItem7_Click);
            // 
            // menuItem8
            // 
            this.menuItem8.Index = 2;
            this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem9,
            this.menuItem10,
            this.menuItem11,
            this.menuItem12});
            this.menuItem8.Text = "Activity";
            // 
            // menuItem9
            // 
            this.menuItem9.Index = 0;
            this.menuItem9.Text = "Save";
            this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click);
            // 
            // menuItem10
            // 
            this.menuItem10.Index = 1;
            this.menuItem10.Text = "Edit";
            // 
            // menuItem11
            // 
            this.menuItem11.Index = 2;
            this.menuItem11.Text = "Delete";
            // 
            // menuItem12
            // 
            this.menuItem12.Index = 3;
            this.menuItem12.Text = "Search";
            // 
            // menuItem13
            // 
            this.menuItem13.Index = 3;
            this.menuItem13.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem14,
            this.menuItem15,
            this.menuItem16,
            this.menuItem17});
            this.menuItem13.Text = "U-P";
            // 
            // menuItem14
            // 
            this.menuItem14.Index = 0;
            this.menuItem14.Text = "Save";
            this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
            // 
            // menuItem15
            // 
            this.menuItem15.Index = 1;
            this.menuItem15.Text = "Edit";
            // 
            // menuItem16
            // 
            this.menuItem16.Index = 2;
            this.menuItem16.Text = "Delete";
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 3;
            this.menuItem17.Text = "Search";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(-8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 80);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Group :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Domain Name :";
            // 
            // cb_group
            // 
            this.cb_group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_group.FormattingEnabled = true;
            this.cb_group.Location = new System.Drawing.Point(103, 98);
            this.cb_group.Name = "cb_group";
            this.cb_group.Size = new System.Drawing.Size(195, 21);
            this.cb_group.TabIndex = 8;
            this.cb_group.SelectedIndexChanged += new System.EventHandler(this.cb_group_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "FTP URL Name :";
            // 
            // txt_domain
            // 
            this.txt_domain.Location = new System.Drawing.Point(103, 9);
            this.txt_domain.Name = "txt_domain";
            this.txt_domain.Size = new System.Drawing.Size(178, 20);
            this.txt_domain.TabIndex = 10;
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(103, 35);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(178, 20);
            this.txt_url.TabIndex = 11;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(103, 61);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(178, 20);
            this.txt_ip.TabIndex = 12;
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(103, 87);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(178, 20);
            this.txt_user.TabIndex = 13;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(103, 113);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(178, 20);
            this.txt_pass.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IP Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "User Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password :";
            // 
            // pnl_domain
            // 
            this.pnl_domain.Controls.Add(this.dtp_bitis);
            this.pnl_domain.Controls.Add(this.dtp_baslangic);
            this.pnl_domain.Controls.Add(this.label14);
            this.pnl_domain.Controls.Add(this.label13);
            this.pnl_domain.Controls.Add(this.btn_iptal);
            this.pnl_domain.Controls.Add(this.txt_serv4);
            this.pnl_domain.Controls.Add(this.btn_kaydet);
            this.pnl_domain.Controls.Add(this.txt_serv3);
            this.pnl_domain.Controls.Add(this.txt_serv2);
            this.pnl_domain.Controls.Add(this.txt_serv1);
            this.pnl_domain.Controls.Add(this.label12);
            this.pnl_domain.Controls.Add(this.label11);
            this.pnl_domain.Controls.Add(this.label10);
            this.pnl_domain.Controls.Add(this.label9);
            this.pnl_domain.Controls.Add(this.txt_cpanel);
            this.pnl_domain.Controls.Add(this.txt_quota);
            this.pnl_domain.Controls.Add(this.label8);
            this.pnl_domain.Controls.Add(this.label7);
            this.pnl_domain.Controls.Add(this.label2);
            this.pnl_domain.Controls.Add(this.label6);
            this.pnl_domain.Controls.Add(this.label3);
            this.pnl_domain.Controls.Add(this.label5);
            this.pnl_domain.Controls.Add(this.txt_domain);
            this.pnl_domain.Controls.Add(this.label4);
            this.pnl_domain.Controls.Add(this.txt_url);
            this.pnl_domain.Controls.Add(this.txt_pass);
            this.pnl_domain.Controls.Add(this.txt_ip);
            this.pnl_domain.Controls.Add(this.txt_user);
            this.pnl_domain.Location = new System.Drawing.Point(0, 125);
            this.pnl_domain.Name = "pnl_domain";
            this.pnl_domain.Size = new System.Drawing.Size(792, 205);
            this.pnl_domain.TabIndex = 18;
            this.pnl_domain.Visible = false;
            // 
            // dtp_bitis
            // 
            this.dtp_bitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_bitis.Location = new System.Drawing.Point(386, 138);
            this.dtp_bitis.Name = "dtp_bitis";
            this.dtp_bitis.Size = new System.Drawing.Size(212, 20);
            this.dtp_bitis.TabIndex = 33;
            // 
            // dtp_baslangic
            // 
            this.dtp_baslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_baslangic.Location = new System.Drawing.Point(386, 112);
            this.dtp_baslangic.Name = "dtp_baslangic";
            this.dtp_baslangic.Size = new System.Drawing.Size(212, 20);
            this.dtp_baslangic.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(297, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Finish Date :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(297, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Start Date :";
            // 
            // btn_iptal
            // 
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iptal.Location = new System.Drawing.Point(699, 179);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 20;
            this.btn_iptal.Text = "Cancel";
            this.btn_iptal.UseVisualStyleBackColor = true;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // txt_serv4
            // 
            this.txt_serv4.Location = new System.Drawing.Point(386, 87);
            this.txt_serv4.Name = "txt_serv4";
            this.txt_serv4.Size = new System.Drawing.Size(194, 20);
            this.txt_serv4.TabIndex = 29;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 19;
            this.btn_kaydet.Text = "OK";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_serv3
            // 
            this.txt_serv3.Location = new System.Drawing.Point(386, 61);
            this.txt_serv3.Name = "txt_serv3";
            this.txt_serv3.Size = new System.Drawing.Size(194, 20);
            this.txt_serv3.TabIndex = 28;
            // 
            // txt_serv2
            // 
            this.txt_serv2.Location = new System.Drawing.Point(386, 35);
            this.txt_serv2.Name = "txt_serv2";
            this.txt_serv2.Size = new System.Drawing.Size(194, 20);
            this.txt_serv2.TabIndex = 27;
            // 
            // txt_serv1
            // 
            this.txt_serv1.Location = new System.Drawing.Point(386, 9);
            this.txt_serv1.Name = "txt_serv1";
            this.txt_serv1.Size = new System.Drawing.Size(194, 20);
            this.txt_serv1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(297, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Name Server4 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name Server3 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Name Server2 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Name Server1 :";
            // 
            // txt_cpanel
            // 
            this.txt_cpanel.Location = new System.Drawing.Point(103, 165);
            this.txt_cpanel.Name = "txt_cpanel";
            this.txt_cpanel.Size = new System.Drawing.Size(178, 20);
            this.txt_cpanel.TabIndex = 21;
            // 
            // txt_quota
            // 
            this.txt_quota.Location = new System.Drawing.Point(103, 139);
            this.txt_quota.Name = "txt_quota";
            this.txt_quota.Size = new System.Drawing.Size(178, 20);
            this.txt_quota.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Control Panel :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quota :";
            // 
            // pnl_forum
            // 
            this.pnl_forum.Controls.Add(this.txt_fpass);
            this.pnl_forum.Controls.Add(this.txt_fuser);
            this.pnl_forum.Controls.Add(this.label17);
            this.pnl_forum.Controls.Add(this.label16);
            this.pnl_forum.Controls.Add(this.txt_furl);
            this.pnl_forum.Controls.Add(this.label15);
            this.pnl_forum.Controls.Add(this.btn_fiptal);
            this.pnl_forum.Controls.Add(this.btn_fkaydet);
            this.pnl_forum.Location = new System.Drawing.Point(0, 125);
            this.pnl_forum.Name = "pnl_forum";
            this.pnl_forum.Size = new System.Drawing.Size(792, 205);
            this.pnl_forum.TabIndex = 19;
            this.pnl_forum.Visible = false;
            // 
            // txt_fpass
            // 
            this.txt_fpass.Location = new System.Drawing.Point(103, 61);
            this.txt_fpass.Name = "txt_fpass";
            this.txt_fpass.Size = new System.Drawing.Size(178, 20);
            this.txt_fpass.TabIndex = 26;
            // 
            // txt_fuser
            // 
            this.txt_fuser.Location = new System.Drawing.Point(103, 35);
            this.txt_fuser.Name = "txt_fuser";
            this.txt_fuser.Size = new System.Drawing.Size(178, 20);
            this.txt_fuser.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Password :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 38);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "User Name :";
            // 
            // txt_furl
            // 
            this.txt_furl.Location = new System.Drawing.Point(103, 9);
            this.txt_furl.Name = "txt_furl";
            this.txt_furl.Size = new System.Drawing.Size(178, 20);
            this.txt_furl.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "URL Name :";
            // 
            // btn_fiptal
            // 
            this.btn_fiptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fiptal.Location = new System.Drawing.Point(699, 179);
            this.btn_fiptal.Name = "btn_fiptal";
            this.btn_fiptal.Size = new System.Drawing.Size(75, 23);
            this.btn_fiptal.TabIndex = 20;
            this.btn_fiptal.Text = "Cancel";
            this.btn_fiptal.UseVisualStyleBackColor = true;
            this.btn_fiptal.Click += new System.EventHandler(this.btn_fiptal_Click);
            // 
            // btn_fkaydet
            // 
            this.btn_fkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fkaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_fkaydet.Name = "btn_fkaydet";
            this.btn_fkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_fkaydet.TabIndex = 19;
            this.btn_fkaydet.Text = "OK";
            this.btn_fkaydet.UseVisualStyleBackColor = true;
            this.btn_fkaydet.Click += new System.EventHandler(this.btn_fkaydet_Click);
            // 
            // pnl_gsm
            // 
            this.pnl_gsm.Controls.Add(this.label26);
            this.pnl_gsm.Controls.Add(this.label25);
            this.pnl_gsm.Controls.Add(this.label24);
            this.pnl_gsm.Controls.Add(this.label23);
            this.pnl_gsm.Controls.Add(this.txt_gcode);
            this.pnl_gsm.Controls.Add(this.txt_gpuk2);
            this.pnl_gsm.Controls.Add(this.txt_gpuk1);
            this.pnl_gsm.Controls.Add(this.txt_gpin2);
            this.pnl_gsm.Controls.Add(this.txt_gpin1);
            this.pnl_gsm.Controls.Add(this.txt_gmodel);
            this.pnl_gsm.Controls.Add(this.txt_gmake);
            this.pnl_gsm.Controls.Add(this.txt_gnumber);
            this.pnl_gsm.Controls.Add(this.txt_gname);
            this.pnl_gsm.Controls.Add(this.label22);
            this.pnl_gsm.Controls.Add(this.label21);
            this.pnl_gsm.Controls.Add(this.label20);
            this.pnl_gsm.Controls.Add(this.label19);
            this.pnl_gsm.Controls.Add(this.label18);
            this.pnl_gsm.Controls.Add(this.btn_giptal);
            this.pnl_gsm.Controls.Add(this.btn_gkaydet);
            this.pnl_gsm.Location = new System.Drawing.Point(0, 125);
            this.pnl_gsm.Name = "pnl_gsm";
            this.pnl_gsm.Size = new System.Drawing.Size(792, 205);
            this.pnl_gsm.TabIndex = 27;
            this.pnl_gsm.Visible = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(297, 92);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(44, 13);
            this.label26.TabIndex = 19;
            this.label26.Text = "PUK 2 :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(297, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "PUK 1 :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(297, 39);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 17;
            this.label24.Text = "PIN 2 :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 116);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 16;
            this.label23.Text = "Security Code :";
            // 
            // txt_gcode
            // 
            this.txt_gcode.Location = new System.Drawing.Point(103, 113);
            this.txt_gcode.Name = "txt_gcode";
            this.txt_gcode.Size = new System.Drawing.Size(178, 20);
            this.txt_gcode.TabIndex = 15;
            // 
            // txt_gpuk2
            // 
            this.txt_gpuk2.Location = new System.Drawing.Point(383, 87);
            this.txt_gpuk2.Name = "txt_gpuk2";
            this.txt_gpuk2.Size = new System.Drawing.Size(179, 20);
            this.txt_gpuk2.TabIndex = 14;
            // 
            // txt_gpuk1
            // 
            this.txt_gpuk1.Location = new System.Drawing.Point(383, 61);
            this.txt_gpuk1.Name = "txt_gpuk1";
            this.txt_gpuk1.Size = new System.Drawing.Size(179, 20);
            this.txt_gpuk1.TabIndex = 13;
            // 
            // txt_gpin2
            // 
            this.txt_gpin2.Location = new System.Drawing.Point(383, 35);
            this.txt_gpin2.Name = "txt_gpin2";
            this.txt_gpin2.Size = new System.Drawing.Size(179, 20);
            this.txt_gpin2.TabIndex = 12;
            // 
            // txt_gpin1
            // 
            this.txt_gpin1.Location = new System.Drawing.Point(383, 9);
            this.txt_gpin1.Name = "txt_gpin1";
            this.txt_gpin1.Size = new System.Drawing.Size(179, 20);
            this.txt_gpin1.TabIndex = 11;
            // 
            // txt_gmodel
            // 
            this.txt_gmodel.Location = new System.Drawing.Point(103, 87);
            this.txt_gmodel.Name = "txt_gmodel";
            this.txt_gmodel.Size = new System.Drawing.Size(178, 20);
            this.txt_gmodel.TabIndex = 10;
            // 
            // txt_gmake
            // 
            this.txt_gmake.Location = new System.Drawing.Point(103, 61);
            this.txt_gmake.Name = "txt_gmake";
            this.txt_gmake.Size = new System.Drawing.Size(178, 20);
            this.txt_gmake.TabIndex = 9;
            // 
            // txt_gnumber
            // 
            this.txt_gnumber.Location = new System.Drawing.Point(103, 35);
            this.txt_gnumber.Name = "txt_gnumber";
            this.txt_gnumber.Size = new System.Drawing.Size(178, 20);
            this.txt_gnumber.TabIndex = 8;
            // 
            // txt_gname
            // 
            this.txt_gname.Location = new System.Drawing.Point(103, 9);
            this.txt_gname.Name = "txt_gname";
            this.txt_gname.Size = new System.Drawing.Size(178, 20);
            this.txt_gname.TabIndex = 7;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(297, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 6;
            this.label22.Text = "PIN 1 :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 90);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Model :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "Make :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "Number :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(82, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Operator Name:";
            // 
            // btn_giptal
            // 
            this.btn_giptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giptal.Location = new System.Drawing.Point(699, 179);
            this.btn_giptal.Name = "btn_giptal";
            this.btn_giptal.Size = new System.Drawing.Size(75, 23);
            this.btn_giptal.TabIndex = 1;
            this.btn_giptal.Text = "Cancel";
            this.btn_giptal.UseVisualStyleBackColor = true;
            this.btn_giptal.Click += new System.EventHandler(this.btn_giptal_Click);
            // 
            // btn_gkaydet
            // 
            this.btn_gkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gkaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_gkaydet.Name = "btn_gkaydet";
            this.btn_gkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_gkaydet.TabIndex = 0;
            this.btn_gkaydet.Text = "OK";
            this.btn_gkaydet.UseVisualStyleBackColor = true;
            this.btn_gkaydet.Click += new System.EventHandler(this.btn_gkaydet_Click);
            // 
            // pnl_bank
            // 
            this.pnl_bank.Controls.Add(this.dateTimePicker1);
            this.pnl_bank.Controls.Add(this.txt_bpass);
            this.pnl_bank.Controls.Add(this.txt_buser);
            this.pnl_bank.Controls.Add(this.txt_bcname);
            this.pnl_bank.Controls.Add(this.txt_bccode);
            this.pnl_bank.Controls.Add(this.txt_bcnumber);
            this.pnl_bank.Controls.Add(this.txt_bbname);
            this.pnl_bank.Controls.Add(this.label39);
            this.pnl_bank.Controls.Add(this.label38);
            this.pnl_bank.Controls.Add(this.label37);
            this.pnl_bank.Controls.Add(this.label36);
            this.pnl_bank.Controls.Add(this.label35);
            this.pnl_bank.Controls.Add(this.label34);
            this.pnl_bank.Controls.Add(this.label33);
            this.pnl_bank.Controls.Add(this.btn_biptal);
            this.pnl_bank.Controls.Add(this.btn_bkaydet);
            this.pnl_bank.Location = new System.Drawing.Point(0, 125);
            this.pnl_bank.Name = "pnl_bank";
            this.pnl_bank.Size = new System.Drawing.Size(792, 205);
            this.pnl_bank.TabIndex = 28;
            this.pnl_bank.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // txt_bpass
            // 
            this.txt_bpass.Location = new System.Drawing.Point(103, 165);
            this.txt_bpass.Name = "txt_bpass";
            this.txt_bpass.Size = new System.Drawing.Size(178, 20);
            this.txt_bpass.TabIndex = 15;
            // 
            // txt_buser
            // 
            this.txt_buser.Location = new System.Drawing.Point(103, 139);
            this.txt_buser.Name = "txt_buser";
            this.txt_buser.Size = new System.Drawing.Size(178, 20);
            this.txt_buser.TabIndex = 14;
            // 
            // txt_bcname
            // 
            this.txt_bcname.Location = new System.Drawing.Point(103, 113);
            this.txt_bcname.Name = "txt_bcname";
            this.txt_bcname.Size = new System.Drawing.Size(178, 20);
            this.txt_bcname.TabIndex = 13;
            // 
            // txt_bccode
            // 
            this.txt_bccode.Location = new System.Drawing.Point(103, 61);
            this.txt_bccode.Name = "txt_bccode";
            this.txt_bccode.Size = new System.Drawing.Size(178, 20);
            this.txt_bccode.TabIndex = 11;
            // 
            // txt_bcnumber
            // 
            this.txt_bcnumber.Location = new System.Drawing.Point(103, 36);
            this.txt_bcnumber.Name = "txt_bcnumber";
            this.txt_bcnumber.Size = new System.Drawing.Size(178, 20);
            this.txt_bcnumber.TabIndex = 10;
            // 
            // txt_bbname
            // 
            this.txt_bbname.Location = new System.Drawing.Point(103, 9);
            this.txt_bbname.Name = "txt_bbname";
            this.txt_bbname.Size = new System.Drawing.Size(178, 20);
            this.txt_bbname.TabIndex = 9;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 168);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(59, 13);
            this.label39.TabIndex = 8;
            this.label39.Text = "Password :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(12, 142);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(66, 13);
            this.label38.TabIndex = 7;
            this.label38.Text = "User Name :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(12, 116);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 13);
            this.label37.TabIndex = 6;
            this.label37.Text = "Card Name :";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(12, 90);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(61, 13);
            this.label36.TabIndex = 5;
            this.label36.Text = "Final Date :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(12, 65);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(85, 13);
            this.label35.TabIndex = 4;
            this.label35.Text = "Customer Code :";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 39);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(75, 13);
            this.label34.TabIndex = 3;
            this.label34.Text = "Card Number :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 12);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(69, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "Bank Name :";
            // 
            // btn_biptal
            // 
            this.btn_biptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_biptal.Location = new System.Drawing.Point(699, 179);
            this.btn_biptal.Name = "btn_biptal";
            this.btn_biptal.Size = new System.Drawing.Size(75, 23);
            this.btn_biptal.TabIndex = 1;
            this.btn_biptal.Text = "Cancel";
            this.btn_biptal.UseVisualStyleBackColor = true;
            this.btn_biptal.Click += new System.EventHandler(this.btn_biptal_Click);
            // 
            // btn_bkaydet
            // 
            this.btn_bkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bkaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_bkaydet.Name = "btn_bkaydet";
            this.btn_bkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_bkaydet.TabIndex = 0;
            this.btn_bkaydet.Text = "OK";
            this.btn_bkaydet.UseVisualStyleBackColor = true;
            this.btn_bkaydet.Click += new System.EventHandler(this.btn_bkaydet_Click);
            // 
            // pnl_web
            // 
            this.pnl_web.Controls.Add(this.txt_wpass);
            this.pnl_web.Controls.Add(this.txt_wuser);
            this.pnl_web.Controls.Add(this.txt_wdomain);
            this.pnl_web.Controls.Add(this.label32);
            this.pnl_web.Controls.Add(this.label31);
            this.pnl_web.Controls.Add(this.label30);
            this.pnl_web.Controls.Add(this.btn_wiptal);
            this.pnl_web.Controls.Add(this.btn_wkaydet);
            this.pnl_web.Location = new System.Drawing.Point(0, 125);
            this.pnl_web.Name = "pnl_web";
            this.pnl_web.Size = new System.Drawing.Size(792, 205);
            this.pnl_web.TabIndex = 29;
            this.pnl_web.Visible = false;
            // 
            // txt_wpass
            // 
            this.txt_wpass.Location = new System.Drawing.Point(103, 62);
            this.txt_wpass.Name = "txt_wpass";
            this.txt_wpass.Size = new System.Drawing.Size(178, 20);
            this.txt_wpass.TabIndex = 7;
            // 
            // txt_wuser
            // 
            this.txt_wuser.Location = new System.Drawing.Point(103, 35);
            this.txt_wuser.Name = "txt_wuser";
            this.txt_wuser.Size = new System.Drawing.Size(178, 20);
            this.txt_wuser.TabIndex = 6;
            // 
            // txt_wdomain
            // 
            this.txt_wdomain.Location = new System.Drawing.Point(103, 9);
            this.txt_wdomain.Name = "txt_wdomain";
            this.txt_wdomain.Size = new System.Drawing.Size(178, 20);
            this.txt_wdomain.TabIndex = 5;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(12, 65);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(59, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "Password :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(12, 38);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 13);
            this.label31.TabIndex = 3;
            this.label31.Text = "User Name :";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(12, 12);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 13);
            this.label30.TabIndex = 2;
            this.label30.Text = "Domain Name :";
            // 
            // btn_wiptal
            // 
            this.btn_wiptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wiptal.Location = new System.Drawing.Point(699, 179);
            this.btn_wiptal.Name = "btn_wiptal";
            this.btn_wiptal.Size = new System.Drawing.Size(75, 23);
            this.btn_wiptal.TabIndex = 1;
            this.btn_wiptal.Text = "Cancel";
            this.btn_wiptal.UseVisualStyleBackColor = true;
            this.btn_wiptal.Click += new System.EventHandler(this.btn_wiptal_Click);
            // 
            // btn_wkaydet
            // 
            this.btn_wkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_wkaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_wkaydet.Name = "btn_wkaydet";
            this.btn_wkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_wkaydet.TabIndex = 0;
            this.btn_wkaydet.Text = "OK";
            this.btn_wkaydet.UseVisualStyleBackColor = true;
            this.btn_wkaydet.Click += new System.EventHandler(this.btn_wkaydet_Click);
            // 
            // pnl_computer
            // 
            this.pnl_computer.Controls.Add(this.label44);
            this.pnl_computer.Controls.Add(this.txt_cpass);
            this.pnl_computer.Controls.Add(this.txt_cvname);
            this.pnl_computer.Controls.Add(this.txt_csname);
            this.pnl_computer.Controls.Add(this.txt_cuname);
            this.pnl_computer.Controls.Add(this.txt_ccname);
            this.pnl_computer.Controls.Add(this.label43);
            this.pnl_computer.Controls.Add(this.label42);
            this.pnl_computer.Controls.Add(this.label41);
            this.pnl_computer.Controls.Add(this.label40);
            this.pnl_computer.Controls.Add(this.btn_ciptal);
            this.pnl_computer.Controls.Add(this.btn_ckaydet);
            this.pnl_computer.Location = new System.Drawing.Point(0, 125);
            this.pnl_computer.Name = "pnl_computer";
            this.pnl_computer.Size = new System.Drawing.Size(792, 205);
            this.pnl_computer.TabIndex = 30;
            this.pnl_computer.Visible = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(12, 116);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(59, 13);
            this.label44.TabIndex = 11;
            this.label44.Text = "Password :";
            // 
            // txt_cpass
            // 
            this.txt_cpass.Location = new System.Drawing.Point(103, 113);
            this.txt_cpass.Name = "txt_cpass";
            this.txt_cpass.Size = new System.Drawing.Size(178, 20);
            this.txt_cpass.TabIndex = 10;
            // 
            // txt_cvname
            // 
            this.txt_cvname.Location = new System.Drawing.Point(103, 87);
            this.txt_cvname.Name = "txt_cvname";
            this.txt_cvname.Size = new System.Drawing.Size(178, 20);
            this.txt_cvname.TabIndex = 9;
            // 
            // txt_csname
            // 
            this.txt_csname.Location = new System.Drawing.Point(103, 62);
            this.txt_csname.Name = "txt_csname";
            this.txt_csname.Size = new System.Drawing.Size(178, 20);
            this.txt_csname.TabIndex = 8;
            // 
            // txt_cuname
            // 
            this.txt_cuname.Location = new System.Drawing.Point(103, 36);
            this.txt_cuname.Name = "txt_cuname";
            this.txt_cuname.Size = new System.Drawing.Size(178, 20);
            this.txt_cuname.TabIndex = 7;
            // 
            // txt_ccname
            // 
            this.txt_ccname.Location = new System.Drawing.Point(103, 9);
            this.txt_ccname.Name = "txt_ccname";
            this.txt_ccname.Size = new System.Drawing.Size(178, 20);
            this.txt_ccname.TabIndex = 6;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(12, 90);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(79, 13);
            this.label43.TabIndex = 5;
            this.label43.Text = "Version Name :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(12, 65);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(78, 13);
            this.label42.TabIndex = 4;
            this.label42.Text = "System Name :";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(12, 38);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(66, 13);
            this.label41.TabIndex = 3;
            this.label41.Text = "User Name :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(12, 12);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(89, 13);
            this.label40.TabIndex = 2;
            this.label40.Text = "Computer Name :";
            // 
            // btn_ciptal
            // 
            this.btn_ciptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ciptal.Location = new System.Drawing.Point(699, 179);
            this.btn_ciptal.Name = "btn_ciptal";
            this.btn_ciptal.Size = new System.Drawing.Size(75, 23);
            this.btn_ciptal.TabIndex = 1;
            this.btn_ciptal.Text = "Cancel";
            this.btn_ciptal.UseVisualStyleBackColor = true;
            this.btn_ciptal.Click += new System.EventHandler(this.btn_ciptal_Click);
            // 
            // btn_ckaydet
            // 
            this.btn_ckaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ckaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_ckaydet.Name = "btn_ckaydet";
            this.btn_ckaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_ckaydet.TabIndex = 0;
            this.btn_ckaydet.Text = "OK";
            this.btn_ckaydet.UseVisualStyleBackColor = true;
            this.btn_ckaydet.Click += new System.EventHandler(this.btn_ckaydet_Click);
            // 
            // pnl_hosting
            // 
            this.pnl_hosting.Controls.Add(this.btn_hiptal);
            this.pnl_hosting.Controls.Add(this.btn_hkaydet);
            this.pnl_hosting.Location = new System.Drawing.Point(0, 125);
            this.pnl_hosting.Name = "pnl_hosting";
            this.pnl_hosting.Size = new System.Drawing.Size(792, 205);
            this.pnl_hosting.TabIndex = 31;
            this.pnl_hosting.Visible = false;
            // 
            // btn_hiptal
            // 
            this.btn_hiptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hiptal.Location = new System.Drawing.Point(699, 179);
            this.btn_hiptal.Name = "btn_hiptal";
            this.btn_hiptal.Size = new System.Drawing.Size(75, 23);
            this.btn_hiptal.TabIndex = 1;
            this.btn_hiptal.Text = "Cancel";
            this.btn_hiptal.UseVisualStyleBackColor = true;
            this.btn_hiptal.Click += new System.EventHandler(this.btn_hiptal_Click);
            // 
            // btn_hkaydet
            // 
            this.btn_hkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hkaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_hkaydet.Name = "btn_hkaydet";
            this.btn_hkaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_hkaydet.TabIndex = 0;
            this.btn_hkaydet.Text = "OK";
            this.btn_hkaydet.UseVisualStyleBackColor = true;
            this.btn_hkaydet.Click += new System.EventHandler(this.btn_hkaydet_Click);
            // 
            // pnl_email
            // 
            this.pnl_email.Controls.Add(this.txt_epass);
            this.pnl_email.Controls.Add(this.txt_eaccound);
            this.pnl_email.Controls.Add(this.txt_edomain);
            this.pnl_email.Controls.Add(this.label29);
            this.pnl_email.Controls.Add(this.label28);
            this.pnl_email.Controls.Add(this.label27);
            this.pnl_email.Controls.Add(this.btn_eiptal);
            this.pnl_email.Controls.Add(this.btn_ekaydet);
            this.pnl_email.Location = new System.Drawing.Point(0, 125);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(792, 205);
            this.pnl_email.TabIndex = 32;
            this.pnl_email.Visible = false;
            // 
            // txt_epass
            // 
            this.txt_epass.Location = new System.Drawing.Point(103, 61);
            this.txt_epass.Name = "txt_epass";
            this.txt_epass.Size = new System.Drawing.Size(178, 20);
            this.txt_epass.TabIndex = 7;
            // 
            // txt_eaccound
            // 
            this.txt_eaccound.Location = new System.Drawing.Point(103, 35);
            this.txt_eaccound.Name = "txt_eaccound";
            this.txt_eaccound.Size = new System.Drawing.Size(178, 20);
            this.txt_eaccound.TabIndex = 6;
            // 
            // txt_edomain
            // 
            this.txt_edomain.Location = new System.Drawing.Point(103, 9);
            this.txt_edomain.Name = "txt_edomain";
            this.txt_edomain.Size = new System.Drawing.Size(178, 20);
            this.txt_edomain.TabIndex = 5;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(12, 64);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(59, 13);
            this.label29.TabIndex = 4;
            this.label29.Text = "Password :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(12, 38);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(56, 13);
            this.label28.TabIndex = 3;
            this.label28.Text = "Accound :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(12, 12);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "Domain Name :";
            // 
            // btn_eiptal
            // 
            this.btn_eiptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eiptal.Location = new System.Drawing.Point(699, 179);
            this.btn_eiptal.Name = "btn_eiptal";
            this.btn_eiptal.Size = new System.Drawing.Size(75, 23);
            this.btn_eiptal.TabIndex = 1;
            this.btn_eiptal.Text = "Cancel";
            this.btn_eiptal.UseVisualStyleBackColor = true;
            this.btn_eiptal.Click += new System.EventHandler(this.btn_eiptal_Click);
            // 
            // btn_ekaydet
            // 
            this.btn_ekaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ekaydet.Location = new System.Drawing.Point(618, 179);
            this.btn_ekaydet.Name = "btn_ekaydet";
            this.btn_ekaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_ekaydet.TabIndex = 0;
            this.btn_ekaydet.Text = "OK";
            this.btn_ekaydet.UseVisualStyleBackColor = true;
            this.btn_ekaydet.Click += new System.EventHandler(this.btn_ekaydet_Click);
            // 
            // frm_up
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.cb_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.pnl_hosting);
            this.Controls.Add(this.pnl_computer);
            this.Controls.Add(this.pnl_bank);
            this.Controls.Add(this.pnl_web);
            this.Controls.Add(this.pnl_email);
            this.Controls.Add(this.pnl_gsm);
            this.Controls.Add(this.pnl_forum);
            this.Controls.Add(this.pnl_domain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frm_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajandam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_anasayfa_FormClosed);
            this.Load += new System.EventHandler(this.frm_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.pnl_domain.ResumeLayout(false);
            this.pnl_domain.PerformLayout();
            this.pnl_forum.ResumeLayout(false);
            this.pnl_forum.PerformLayout();
            this.pnl_gsm.ResumeLayout(false);
            this.pnl_gsm.PerformLayout();
            this.pnl_bank.ResumeLayout(false);
            this.pnl_bank.PerformLayout();
            this.pnl_web.ResumeLayout(false);
            this.pnl_web.PerformLayout();
            this.pnl_computer.ResumeLayout(false);
            this.pnl_computer.PerformLayout();
            this.pnl_hosting.ResumeLayout(false);
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion



		private void frm_up_Load(object sender, System.EventArgs e)
		{
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            OleDbConnection oledbconn = new OleDbConnection();
            oledbconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            oledbconn.Open();
            OleDbCommand oledbcomm = new OleDbCommand();
            oledbcomm.Connection = oledbconn;
            OleDbDataAdapter verial = new OleDbDataAdapter("SELECT * FROM groups ORDER BY gp_name", oledbconn);
            DataSet al = new DataSet();
            verial.Fill(al, "groups");
            DataTable tek_table = al.Tables["groups"];
            foreach (DataRow tek_row in tek_table.Rows)
                {
                    cb_group.Items.Add(tek_row["gp_name"]);
                }
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			frm_fihristAc ac=new frm_fihristAc();
			ac.Show();
			this.Hide();
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			frm_hareketAc ac=new frm_hareketAc();
			ac.Show();
			this.Hide();
		}

        private void frm_anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            frm_fihristAra ac = new frm_fihristAra();
            ac.Show();
            this.Hide();
        }

        private void cb_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_group.Text == "Domain")
            {
                pnl_computer.Visible = false;
                pnl_bank.Visible = false;
                pnl_hosting.Visible = false;
                pnl_forum.Visible = false;
                pnl_web.Visible = false;
                pnl_email.Visible = false;
                pnl_gsm.Visible = false;
                pnl_domain.Visible = true;

                txt_bbname.Clear();
                txt_bccode.Clear();
                txt_bcname.Clear();
                txt_bcnumber.Clear();
                txt_bpass.Clear();
                txt_buser.Clear();
                txt_ccname.Clear();
                txt_cpanel.Clear();
                txt_cpass.Clear();
                txt_csname.Clear();
                txt_cuname.Clear();
                txt_cvname.Clear();
                txt_cvname.Clear();
                txt_domain.Clear();
                txt_eaccound.Clear();
                txt_edomain.Clear();
                txt_epass.Clear();
                txt_fpass.Clear();
                txt_furl.Clear();
                txt_fuser.Clear();
                txt_gcode.Clear();
                txt_gmake.Clear();
                txt_gmodel.Clear();
                txt_gname.Clear();
                txt_gnumber.Clear();
                txt_gpin1.Clear();
                txt_gpin2.Clear();
                txt_gpuk1.Clear();
                txt_gpuk2.Clear();
                txt_ip.Clear();
                txt_pass.Clear();
                txt_quota.Clear();
                txt_serv1.Clear();
                txt_serv2.Clear();
                txt_serv3.Clear();
                txt_serv4.Clear();
                txt_url.Clear();
                txt_user.Clear();
                txt_wdomain.Clear();
                txt_wpass.Clear();
                txt_wuser.Clear();
                //dtp_baslangic;
                //dtp_bitis;
                //dateTimePicker1;
                
            }
            if (cb_group.Text == "Forum")
            {
                pnl_domain.Visible = false;
                pnl_bank.Visible = false;
                pnl_computer.Visible = false;
                pnl_hosting.Visible = false;
                pnl_web.Visible = false;
                pnl_email.Visible = false;
                pnl_gsm.Visible = false;
                pnl_forum.Visible = true;
            }
            if (cb_group.Text == "Web Site")
            {
                pnl_domain.Visible = false;
                pnl_gsm.Visible = false;
                pnl_email.Visible = false;
                pnl_forum.Visible = false;
                pnl_computer.Visible = false;
                pnl_hosting.Visible = false;
                pnl_bank.Visible = false;
                pnl_web.Visible = true;
            }
            if (cb_group.Text == "E-Mail")
            {
                pnl_domain.Visible = false;
                pnl_bank.Visible = false;
                pnl_computer.Visible = false;
                pnl_hosting.Visible = false;
                pnl_web.Visible = false;
                pnl_gsm.Visible = false;
                pnl_forum.Visible = false;
                pnl_email.Visible = true;
            }
            if (cb_group.Text == "GSM")
            {
                pnl_domain.Visible = false;
                pnl_bank.Visible = false;
                pnl_computer.Visible = false;
                pnl_hosting.Visible = false;
                pnl_web.Visible = false;
                pnl_forum.Visible = false;
                pnl_email.Visible = false;
                pnl_gsm.Visible = true;
            }
            if (cb_group.Text == "Bank Card")
            {
                pnl_domain.Visible = false;
                pnl_computer.Visible = false;
                pnl_hosting.Visible = false;
                pnl_web.Visible = false;
                pnl_email.Visible = false;
                pnl_forum.Visible = false;
                pnl_gsm.Visible = false;
                pnl_bank.Visible = true;
            }
            if (cb_group.Text == "Computer")
            {
                pnl_domain.Visible = false;
                pnl_bank.Visible = false;
                pnl_email.Visible = false;
                pnl_forum.Visible = false;
                pnl_web.Visible = false;
                pnl_gsm.Visible = false;    
                pnl_hosting.Visible = false;
                pnl_computer.Visible = true;
            }
            if (cb_group.Text == "Hosting")
            {
                pnl_computer.Visible = false;
                pnl_domain.Visible = false;
                pnl_bank.Visible = false;
                pnl_email.Visible = false;
                pnl_web.Visible = false;
                pnl_forum.Visible = false;
                pnl_gsm.Visible = false;
                pnl_hosting.Visible = true;
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            //domain name
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_domain (dn_domain,dn_group,dn_url,dn_ip,dn_user,dn_pass,dn_cpanel,dn_serv1,dn_serv2,dn_serv3,dn_serv4,dn_quota,dn_baslangic,dn_bitis) values ('" + txt_domain.Text + "','" + cb_group.Text + "','" + txt_url.Text + "','" + txt_ip.Text + "','" + txt_user.Text + "','" + txt_pass.Text + "','" + txt_cpanel.Text + "','" + txt_serv1.Text + "','" + txt_serv2.Text + "','" + txt_serv3.Text + "','" + txt_serv4.Text + "','" + txt_quota.Text + "','" + dtp_baslangic.Value.ToShortDateString() + "','" + dtp_bitis.Value.ToShortDateString() + "')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_domain.Clear();
                txt_ip.Clear();
                txt_pass.Clear();
                txt_quota.Clear();
                txt_serv1.Clear();
                txt_serv2.Clear();
                txt_serv3.Clear();
                txt_serv4.Clear();
                txt_url.Clear();
                txt_user.Clear();
                txt_cpanel.Clear();
                //tarihleride clear yapman lasým janým..
            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }

        }

        private void btn_fkaydet_Click(object sender, EventArgs e)
        {
            //forum
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_forum (fr_url,fr_user,fr_pass,fr_group) values ('" + txt_furl.Text + "','" + txt_fuser.Text + "','" + txt_fpass.Text + "','" + cb_group.Text + "')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_fpass.Clear();
                txt_furl.Clear();
                txt_fuser.Clear();
            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            //domain name
            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_domain.Clear();
                    txt_ip.Clear();
                    txt_pass.Clear();
                    txt_quota.Clear();
                    txt_serv1.Clear();
                    txt_serv2.Clear();
                    txt_serv3.Clear();
                    txt_serv4.Clear();
                    txt_url.Clear();
                    txt_user.Clear();
                    txt_cpanel.Clear();
                    //tarihleride clear yapman lasým janým..
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void btn_fiptal_Click(object sender, EventArgs e)
        {
            //forum
     

            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_fpass.Clear();
                    txt_furl.Clear();
                    txt_fuser.Clear();
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void btn_gkaydet_Click(object sender, EventArgs e)
        {
            //gsm

            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_gsm (g_group,g_name,g_number,g_make,g_model,g_security,g_pin1,g_pin2,g_puk1,g_puk2) values ('"+cb_group.Text+"','"+txt_gname.Text+"','"+txt_gnumber.Text+"','"+txt_gmake.Text+"','"+txt_gmodel.Text+"','"+txt_gcode.Text+"','"+txt_gpin1.Text+"','"+txt_gpin2.Text+"','"+txt_gpuk1.Text+"','"+txt_gpuk2.Text+"')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_gpuk2.Clear();
                txt_gpuk1.Clear();
                txt_gpin2.Clear();
                txt_gpin1.Clear();
                txt_gnumber.Clear();
                txt_gname.Clear();
                txt_gmodel.Clear();
                txt_gmake.Clear();
                txt_gcode.Clear();
            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }
        }

        private void btn_giptal_Click(object sender, EventArgs e)
        {
            //gsm
          

            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_gpuk2.Clear();
                    txt_gpuk1.Clear();
                    txt_gpin2.Clear();
                    txt_gpin1.Clear();
                    txt_gnumber.Clear();
                    txt_gname.Clear();
                    txt_gmodel.Clear();
                    txt_gmake.Clear();
                    txt_gcode.Clear();
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void btn_bkaydet_Click(object sender, EventArgs e)
        {
            //bank
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_bank (b_group,b_name,b_cardn,b_ccode,b_date,b_cname,b_user,b_pass) values ('" + cb_group.Text + "','" + txt_bbname.Text + "','" + txt_bcnumber.Text + "','" + txt_bccode.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + txt_bcname.Text + "','" + txt_buser.Text + "','" + txt_bpass.Text + "')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_buser.Clear();
                txt_bpass.Clear();
                txt_bcnumber.Clear();
                txt_bcname.Clear();
                txt_bccode.Clear();
                txt_bbname.Clear();

            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }
        }

        private void btn_biptal_Click(object sender, EventArgs e)
        {
            //bank
        

            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_buser.Clear();
                    txt_bpass.Clear();
                    txt_bcnumber.Clear();
                    txt_bcname.Clear();
                    txt_bccode.Clear();
                    txt_bbname.Clear();
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void btn_wkaydet_Click(object sender, EventArgs e)
        {
            //web
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_web (w_group,w_domain,w_user,w_pass) values ('" + cb_group.Text + "','" + txt_wdomain.Text + "','" + txt_wuser.Text + "','" + txt_wpass.Text + "')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_wpass.Clear();
                txt_wdomain.Clear();
                txt_wuser.Clear();
            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }
        }

        private void btn_wiptal_Click(object sender, EventArgs e)
        {
            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_wpass.Clear();
                    txt_wdomain.Clear();
                    txt_wuser.Clear();
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void btn_ckaydet_Click(object sender, EventArgs e)
        {
            //computer
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_computer (cp_name,cp_system,cp_version,cp_pass,cp_user) values ('"+txt_ccname.Text+"','"+txt_csname.Text+"','"+txt_cvname.Text+"','"+txt_cpass.Text+"','"+txt_cuname.Text+"')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_ccname.Clear();
                txt_csname.Clear();
                txt_cvname.Clear();
                txt_cpass.Clear();
                txt_cuname.Clear();
            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }
        }

        private void btn_ciptal_Click(object sender, EventArgs e)
        {
            //computer
 

            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_ccname.Clear();
                    txt_csname.Clear();
                    txt_cvname.Clear();
                    txt_cpass.Clear();
                    txt_cuname.Clear();
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void btn_hkaydet_Click(object sender, EventArgs e)
        {
            //string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            //OleDbConnection baglanti = new OleDbConnection(kaynak);
            //OleDbCommand veri = new OleDbCommand();
            //veri.Connection = baglanti;
            //veri.CommandText = "insert into hareket () values ('"++"','"++"','"++"')";
            //try
            //{
            //    baglanti.Open();
            //    veri.ExecuteNonQuery();
            //    baglanti.Close();
            //    MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");

            //}
            //catch (System.Exception Error_Code)
            //{
            //    MessageBox.Show(this, "" + Error_Code, "Error");
            //}
        }

        private void btn_hiptal_Click(object sender, EventArgs e)
        {
            //DialogResult dugmesec;
            //dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            //if (dugmesec == DialogResult.Yes)
            //{
            //    try
            //    {
                   
            //        MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
            //    }
            //    catch (System.Exception Error_Code)
            //    {
            //        MessageBox.Show(this, "" + Error_Code, "Error");
            //    }
            //}
            //else if (dugmesec == DialogResult.No)
            //{
            //    //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
            //    MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            //}
        }

        private void btn_ekaydet_Click(object sender, EventArgs e)
        {
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "insert into up_email (e_domain,e_accound,e_pass) values ('"+txt_edomain.Text+"','"+txt_eaccound.Text+"','"+txt_epass.Text+"')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                txt_epass.Clear();
                txt_edomain.Clear();
                txt_eaccound.Clear();
            }
            catch (System.Exception Error_Code)
            {
                MessageBox.Show(this, "" + Error_Code, "Error");
            }
        }

        private void btn_eiptal_Click(object sender, EventArgs e)
        {
           

            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_epass.Clear();
                    txt_edomain.Clear();
                    txt_eaccound.Clear();
                    MessageBox.Show(this, "The cancellation procedure successful.", "Knowledge Message");
                }
                catch (System.Exception Error_Code)
                {
                    MessageBox.Show(this, "" + Error_Code, "Error");
                }
            }
            else if (dugmesec == DialogResult.No)
            {
                //MessageBox.Show(this, "Silme iþlemini iptal ettiniz.", "Bilgi Mesajý");
                MessageBox.Show(this, "The procedure was the cancellation.", "Knowledge Message");
            }
        }

        private void menuItem14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Zaten User&Password Sayfasýndasýnýz.", "Hata Mesajý");
        }
	}
}
