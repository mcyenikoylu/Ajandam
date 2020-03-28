using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Ajandam
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Ajandam : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_kullaniciismi;
		private System.Windows.Forms.TextBox txt_parola;
		private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_iptal;
        private Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Ajandam()
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
				if (components != null) 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajandam));
            this.txt_kullaniciismi = new System.Windows.Forms.TextBox();
            this.txt_parola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txt_kullaniciismi
            // 
            this.txt_kullaniciismi.Location = new System.Drawing.Point(136, 101);
            this.txt_kullaniciismi.Name = "txt_kullaniciismi";
            this.txt_kullaniciismi.Size = new System.Drawing.Size(168, 20);
            this.txt_kullaniciismi.TabIndex = 0;
            // 
            // txt_parola
            // 
            this.txt_parola.Location = new System.Drawing.Point(136, 125);
            this.txt_parola.Name = "txt_parola";
            this.txt_parola.Size = new System.Drawing.Size(168, 20);
            this.txt_parola.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(144, 157);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 23);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Login";
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_iptal
            // 
            this.btn_iptal.Location = new System.Drawing.Point(224, 157);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(75, 23);
            this.btn_iptal.TabIndex = 6;
            this.btn_iptal.Text = "Cancel";
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 69);
            this.panel1.TabIndex = 7;
            // 
            // Ajandam
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(344, 207);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_parola);
            this.Controls.Add(this.txt_kullaniciismi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ajandam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajandam";
            this.Load += new System.EventHandler(this.Ajandam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.Run(new Ajandam());
        }

        public static string d_name;
        public static string d_pass;
		private void btn_giris_Click(object sender, System.EventArgs e)
		{

            int onay = 0;

            string kaynak = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ajandam.mdb";
            OleDbConnection baglanti = new OleDbConnection(kaynak);
            OleDbDataAdapter verial = new OleDbDataAdapter("SELECT * FROM login WHERE name ='" + txt_kullaniciismi.Text + "' AND pass ='" + txt_parola.Text + "'",baglanti);
            DataSet al = new DataSet();
            verial.Fill(al, "login");
            DataTable myDataTable = al.Tables ["login"];
            foreach (DataRow myDataRow in myDataTable.Rows)
            {
                d_name = myDataRow["name"].ToString();
                d_pass = myDataRow["pass"].ToString();
                onay = 1;
            }
            if (onay == 1)
            {
                frm_anasayfa ac = new frm_anasayfa();
                ac.Show();
                this.Hide();
            }
            if (onay == 0)
            {
                MessageBox.Show(this, "Hatalý kullanýcý ismi ve þifre!", "Hata");
            }

			
		}

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ajandam_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            txt_parola.PasswordChar='*';
            txt_kullaniciismi.Focus();
            this.AcceptButton = btn_giris;
        }
	}
}
