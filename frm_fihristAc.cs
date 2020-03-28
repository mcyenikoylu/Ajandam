using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ajandam
{
	/// <summary>
	/// Summary description for frm_anasayfa.
	/// </summary>
	public class frm_fihristAc : System.Windows.Forms.Form
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.DateTimePicker dtp_dgunu;
		private System.Windows.Forms.Button btn_kaydet;
		private System.Windows.Forms.Button btn_iptal;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.CheckBox chb_dgunu;
		private System.Windows.Forms.TextBox txt_1ad;
		private System.Windows.Forms.TextBox txt_2ad;
		private System.Windows.Forms.TextBox txt_soyad;
		private System.Windows.Forms.TextBox txt_rumuz;
		private System.Windows.Forms.TextBox txt_adres;
		private System.Windows.Forms.TextBox txt_il;
		private System.Windows.Forms.TextBox txt_ilce;
		private System.Windows.Forms.TextBox txt_postaKodu;
		private System.Windows.Forms.TextBox txt_evTel;
		private System.Windows.Forms.TextBox txt_isTel;
		private System.Windows.Forms.TextBox txt_1cepTel;
		private System.Windows.Forms.TextBox txt_2cepTel;
		private System.Windows.Forms.TextBox txt_web;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.TextBox txt_msn;
		private System.Windows.Forms.TextBox txt_icq;
        private System.Windows.Forms.RichTextBox rtb_not;
        private MenuItem menuItem13;
        private MenuItem menuItem14;
        private MenuItem menuItem15;
        private MenuItem menuItem16;
        private MenuItem menuItem17;
        private IContainer components;

		public frm_fihristAc()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_fihristAc));
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
            this.txt_1ad = new System.Windows.Forms.TextBox();
            this.txt_2ad = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_rumuz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.txt_il = new System.Windows.Forms.TextBox();
            this.txt_ilce = new System.Windows.Forms.TextBox();
            this.txt_postaKodu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_evTel = new System.Windows.Forms.TextBox();
            this.txt_isTel = new System.Windows.Forms.TextBox();
            this.txt_1cepTel = new System.Windows.Forms.TextBox();
            this.txt_2cepTel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_web = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_msn = new System.Windows.Forms.TextBox();
            this.txt_icq = new System.Windows.Forms.TextBox();
            this.rtb_not = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtp_dgunu = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.chb_dgunu = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // txt_1ad
            // 
            this.txt_1ad.Location = new System.Drawing.Point(112, 88);
            this.txt_1ad.Name = "txt_1ad";
            this.txt_1ad.Size = new System.Drawing.Size(144, 20);
            this.txt_1ad.TabIndex = 7;
            // 
            // txt_2ad
            // 
            this.txt_2ad.Location = new System.Drawing.Point(112, 112);
            this.txt_2ad.Name = "txt_2ad";
            this.txt_2ad.Size = new System.Drawing.Size(144, 20);
            this.txt_2ad.TabIndex = 8;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(112, 136);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(144, 20);
            this.txt_soyad.TabIndex = 9;
            // 
            // txt_rumuz
            // 
            this.txt_rumuz.Location = new System.Drawing.Point(112, 160);
            this.txt_rumuz.Name = "txt_rumuz";
            this.txt_rumuz.Size = new System.Drawing.Size(144, 20);
            this.txt_rumuz.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Middle Name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Last Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nick Name :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Location = new System.Drawing.Point(624, 304);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 15;
            this.btn_kaydet.Text = "OK";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iptal.Location = new System.Drawing.Point(704, 304);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 16;
            this.btn_iptal.Text = "Cancel";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(8, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Address :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Country :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(8, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "District :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(8, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Post Code :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(112, 200);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(144, 20);
            this.txt_adres.TabIndex = 21;
            // 
            // txt_il
            // 
            this.txt_il.Location = new System.Drawing.Point(112, 224);
            this.txt_il.Name = "txt_il";
            this.txt_il.Size = new System.Drawing.Size(144, 20);
            this.txt_il.TabIndex = 22;
            // 
            // txt_ilce
            // 
            this.txt_ilce.Location = new System.Drawing.Point(112, 248);
            this.txt_ilce.Name = "txt_ilce";
            this.txt_ilce.Size = new System.Drawing.Size(144, 20);
            this.txt_ilce.TabIndex = 23;
            // 
            // txt_postaKodu
            // 
            this.txt_postaKodu.Location = new System.Drawing.Point(112, 272);
            this.txt_postaKodu.Name = "txt_postaKodu";
            this.txt_postaKodu.Size = new System.Drawing.Size(144, 20);
            this.txt_postaKodu.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(264, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Home Number :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(264, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Work Number :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(264, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 23);
            this.label11.TabIndex = 27;
            this.label11.Text = "1. Mobil Number :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(264, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "2. Mobil Munber :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_evTel
            // 
            this.txt_evTel.Location = new System.Drawing.Point(368, 88);
            this.txt_evTel.Name = "txt_evTel";
            this.txt_evTel.Size = new System.Drawing.Size(136, 20);
            this.txt_evTel.TabIndex = 29;
            // 
            // txt_isTel
            // 
            this.txt_isTel.Location = new System.Drawing.Point(368, 112);
            this.txt_isTel.Name = "txt_isTel";
            this.txt_isTel.Size = new System.Drawing.Size(136, 20);
            this.txt_isTel.TabIndex = 30;
            // 
            // txt_1cepTel
            // 
            this.txt_1cepTel.Location = new System.Drawing.Point(368, 136);
            this.txt_1cepTel.Name = "txt_1cepTel";
            this.txt_1cepTel.Size = new System.Drawing.Size(136, 20);
            this.txt_1cepTel.TabIndex = 31;
            // 
            // txt_2cepTel
            // 
            this.txt_2cepTel.Location = new System.Drawing.Point(368, 160);
            this.txt_2cepTel.Name = "txt_2cepTel";
            this.txt_2cepTel.Size = new System.Drawing.Size(136, 20);
            this.txt_2cepTel.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(264, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 33;
            this.label13.Text = "Web :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(264, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "E-Mail :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(264, 248);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "MSN :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(264, 272);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "ICQ :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_web
            // 
            this.txt_web.Location = new System.Drawing.Point(368, 200);
            this.txt_web.Name = "txt_web";
            this.txt_web.Size = new System.Drawing.Size(136, 20);
            this.txt_web.TabIndex = 37;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(368, 224);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(136, 20);
            this.txt_email.TabIndex = 38;
            // 
            // txt_msn
            // 
            this.txt_msn.Location = new System.Drawing.Point(368, 248);
            this.txt_msn.Name = "txt_msn";
            this.txt_msn.Size = new System.Drawing.Size(136, 20);
            this.txt_msn.TabIndex = 39;
            // 
            // txt_icq
            // 
            this.txt_icq.Location = new System.Drawing.Point(368, 272);
            this.txt_icq.Name = "txt_icq";
            this.txt_icq.Size = new System.Drawing.Size(136, 20);
            this.txt_icq.TabIndex = 40;
            // 
            // rtb_not
            // 
            this.rtb_not.Location = new System.Drawing.Point(600, 144);
            this.rtb_not.Name = "rtb_not";
            this.rtb_not.Size = new System.Drawing.Size(184, 152);
            this.rtb_not.TabIndex = 41;
            this.rtb_not.Text = "";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(512, 88);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 23);
            this.label17.TabIndex = 42;
            this.label17.Text = "Birthday :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_dgunu
            // 
            this.dtp_dgunu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dgunu.Location = new System.Drawing.Point(600, 88);
            this.dtp_dgunu.Name = "dtp_dgunu";
            this.dtp_dgunu.Size = new System.Drawing.Size(184, 20);
            this.dtp_dgunu.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(512, 144);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 23);
            this.label18.TabIndex = 44;
            this.label18.Text = "Note :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chb_dgunu
            // 
            this.chb_dgunu.Location = new System.Drawing.Point(608, 112);
            this.chb_dgunu.Name = "chb_dgunu";
            this.chb_dgunu.Size = new System.Drawing.Size(144, 24);
            this.chb_dgunu.TabIndex = 45;
            this.chb_dgunu.Text = "to remind";
            // 
            // frm_fihristAc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.chb_dgunu);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtp_dgunu);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.rtb_not);
            this.Controls.Add(this.txt_icq);
            this.Controls.Add(this.txt_msn);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_web);
            this.Controls.Add(this.txt_2cepTel);
            this.Controls.Add(this.txt_1cepTel);
            this.Controls.Add(this.txt_isTel);
            this.Controls.Add(this.txt_evTel);
            this.Controls.Add(this.txt_postaKodu);
            this.Controls.Add(this.txt_ilce);
            this.Controls.Add(this.txt_il);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.txt_rumuz);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_2ad);
            this.Controls.Add(this.txt_1ad);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.statusBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "frm_fihristAc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajandam";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_fihristAc_FormClosed);
            this.Load += new System.EventHandler(this.frm_anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void frm_anasayfa_Load(object sender, System.EventArgs e)
		{
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
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

        public static int fac_dhatirlat;
		private void btn_kaydet_Click(object sender, System.EventArgs e)
		{
            if (chb_dgunu.Checked == true)
            {
                fac_dhatirlat = 1;
            }
            else
            {
                fac_dhatirlat = 0;
            }
            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbCommand veri = new OleDbCommand();
            veri.Connection = baglanti;
            veri.CommandText = "INSERT INTO fihrist (ad1,ad2,soyad,rumuz,adres,il,ilce,postakodu,evtel,istel,1ceptel,2ceptel,web,email,msn,icq,notlar,dhatirlat,dgunu) VALUES ('" + txt_1ad.Text + "','" + txt_2ad.Text + "','" + txt_soyad.Text + "','" + txt_rumuz.Text + "','" + txt_adres.Text + "','" + txt_il.Text + "','" + txt_ilce.Text + "','" + txt_postaKodu.Text + "','" + txt_evTel.Text + "','" + txt_isTel.Text + "','" + txt_1cepTel.Text + "','" + txt_2cepTel.Text + "','" + txt_web.Text + "','" + txt_email.Text + "','" + txt_msn.Text + "','" + txt_icq.Text + "','" + rtb_not.Text + "','" + fac_dhatirlat + "','" + dtp_dgunu.Value.ToShortDateString() + "')";
            try
            {
                baglanti.Open();
                veri.ExecuteNonQuery();
                baglanti.Close();
                //MessageBox.Show(this, "Kayýt iþlemi baþarýlý.", "Onay");
                MessageBox.Show(this, "The record procedure successful.", "Approval Message");
                txt_1ad.Clear();
                txt_1cepTel.Clear();
                txt_2ad.Clear();
                txt_2cepTel.Clear();
                txt_adres.Clear();
                txt_email.Clear();
                txt_evTel.Clear();
                txt_icq.Clear();
                txt_il.Clear();
                txt_ilce.Clear();
                txt_isTel.Clear();
                txt_msn.Clear();
                txt_postaKodu.Clear();
                txt_rumuz.Clear();
                txt_soyad.Clear();
                txt_web.Clear();
                rtb_not.Clear();
                chb_dgunu.Checked = false;
                
            }
            catch
            {
                MessageBox.Show(this, "Veri Tabanýna Baðlanýlýrken Bir Hata Oluþtu.", "Hata");
            }
		}

        private void menuItem7_Click(object sender, EventArgs e)
        {
            frm_fihristAra ac = new frm_fihristAra();
            ac.Show();
            this.Hide();
        }

        private void frm_fihristAc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "Are you sure to cancel the procedure?", "Approval Message", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                try
                {
                    txt_1ad.Clear();
                    txt_1cepTel.Clear();
                    txt_2ad.Clear();
                    txt_2cepTel.Clear();
                    txt_adres.Clear();
                    txt_email.Clear();
                    txt_evTel.Clear();
                    txt_icq.Clear();
                    txt_il.Clear();
                    txt_ilce.Clear();
                    txt_isTel.Clear();
                    txt_msn.Clear();
                    txt_postaKodu.Clear();
                    txt_rumuz.Clear();
                    txt_soyad.Clear();
                    txt_web.Clear();
                    rtb_not.Clear();
                    chb_dgunu.Checked = false;
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

        private void menuItem9_Click(object sender, EventArgs e)
        {
            frm_hareketAc ac = new frm_hareketAc();
            ac.Show();
            this.Hide();
            
        }
	}
}
