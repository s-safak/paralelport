using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace paralelport
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox sekiz;
		private System.Windows.Forms.PictureBox yedi;
		private System.Windows.Forms.PictureBox altý;
		private System.Windows.Forms.PictureBox bes;
		private System.Windows.Forms.PictureBox dort;
		private System.Windows.Forms.PictureBox uc;
		private System.Windows.Forms.PictureBox iki;
		private System.Windows.Forms.PictureBox bir;
		private System.Windows.Forms.PictureBox sonuk;
		private System.Windows.Forms.PictureBox yanýk;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.sekiz = new System.Windows.Forms.PictureBox();
			this.yedi = new System.Windows.Forms.PictureBox();
			this.altý = new System.Windows.Forms.PictureBox();
			this.bes = new System.Windows.Forms.PictureBox();
			this.dort = new System.Windows.Forms.PictureBox();
			this.uc = new System.Windows.Forms.PictureBox();
			this.iki = new System.Windows.Forms.PictureBox();
			this.bir = new System.Windows.Forms.PictureBox();
			this.sonuk = new System.Windows.Forms.PictureBox();
			this.yanýk = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sekiz
			// 
			this.sekiz.Image = ((System.Drawing.Bitmap)(resources.GetObject("sekiz.Image")));
			this.sekiz.Location = new System.Drawing.Point(24, 8);
			this.sekiz.Name = "sekiz";
			this.sekiz.Size = new System.Drawing.Size(32, 32);
			this.sekiz.TabIndex = 0;
			this.sekiz.TabStop = false;
			// 
			// yedi
			// 
			this.yedi.Image = ((System.Drawing.Bitmap)(resources.GetObject("yedi.Image")));
			this.yedi.Location = new System.Drawing.Point(104, 8);
			this.yedi.Name = "yedi";
			this.yedi.Size = new System.Drawing.Size(32, 32);
			this.yedi.TabIndex = 1;
			this.yedi.TabStop = false;
			// 
			// altý
			// 
			this.altý.Image = ((System.Drawing.Bitmap)(resources.GetObject("altý.Image")));
			this.altý.Location = new System.Drawing.Point(176, 8);
			this.altý.Name = "altý";
			this.altý.Size = new System.Drawing.Size(32, 40);
			this.altý.TabIndex = 2;
			this.altý.TabStop = false;
			// 
			// bes
			// 
			this.bes.Image = ((System.Drawing.Bitmap)(resources.GetObject("bes.Image")));
			this.bes.Location = new System.Drawing.Point(256, 8);
			this.bes.Name = "bes";
			this.bes.Size = new System.Drawing.Size(32, 40);
			this.bes.TabIndex = 3;
			this.bes.TabStop = false;
			// 
			// dort
			// 
			this.dort.Image = ((System.Drawing.Bitmap)(resources.GetObject("dort.Image")));
			this.dort.Location = new System.Drawing.Point(336, 8);
			this.dort.Name = "dort";
			this.dort.Size = new System.Drawing.Size(32, 32);
			this.dort.TabIndex = 4;
			this.dort.TabStop = false;
			// 
			// uc
			// 
			this.uc.Image = ((System.Drawing.Bitmap)(resources.GetObject("uc.Image")));
			this.uc.Location = new System.Drawing.Point(424, 8);
			this.uc.Name = "uc";
			this.uc.Size = new System.Drawing.Size(32, 40);
			this.uc.TabIndex = 5;
			this.uc.TabStop = false;
			// 
			// iki
			// 
			this.iki.Image = ((System.Drawing.Bitmap)(resources.GetObject("iki.Image")));
			this.iki.Location = new System.Drawing.Point(504, 8);
			this.iki.Name = "iki";
			this.iki.Size = new System.Drawing.Size(32, 40);
			this.iki.TabIndex = 6;
			this.iki.TabStop = false;
			// 
			// bir
			// 
			this.bir.Image = ((System.Drawing.Bitmap)(resources.GetObject("bir.Image")));
			this.bir.Location = new System.Drawing.Point(576, 8);
			this.bir.Name = "bir";
			this.bir.Size = new System.Drawing.Size(32, 40);
			this.bir.TabIndex = 7;
			this.bir.TabStop = false;
			// 
			// sonuk
			// 
			this.sonuk.Image = ((System.Drawing.Bitmap)(resources.GetObject("sonuk.Image")));
			this.sonuk.Location = new System.Drawing.Point(576, 232);
			this.sonuk.Name = "sonuk";
			this.sonuk.Size = new System.Drawing.Size(32, 32);
			this.sonuk.TabIndex = 8;
			this.sonuk.TabStop = false;
			this.sonuk.Visible = false;
			// 
			// yanýk
			// 
			this.yanýk.Image = ((System.Drawing.Bitmap)(resources.GetObject("yanýk.Image")));
			this.yanýk.Location = new System.Drawing.Point(616, 232);
			this.yanýk.Name = "yanýk";
			this.yanýk.Size = new System.Drawing.Size(32, 32);
			this.yanýk.TabIndex = 9;
			this.yanýk.TabStop = false;
			this.yanýk.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 80);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(248, 20);
			this.textBox1.TabIndex = 10;
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 120);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 32);
			this.button1.TabIndex = 11;
			this.button1.Text = "Yolla";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(144, 120);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 32);
			this.button2.TabIndex = 12;
			this.button2.Text = "Ledleri söndür";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(312, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 23);
			this.label1.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "8.bit";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label3.Location = new System.Drawing.Point(104, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "7.bit";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label4.Location = new System.Drawing.Point(176, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 23);
			this.label4.TabIndex = 16;
			this.label4.Text = "6.bit";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label5.Location = new System.Drawing.Point(256, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "5.bit";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label6.Location = new System.Drawing.Point(336, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 23);
			this.label6.TabIndex = 18;
			this.label6.Text = "4.bit";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label7.Location = new System.Drawing.Point(424, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "3.bit";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label8.Location = new System.Drawing.Point(504, 48);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(40, 23);
			this.label8.TabIndex = 20;
			this.label8.Text = "2.bit";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label9.Location = new System.Drawing.Point(576, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "1.bit";
			// 
			// Form1
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 157);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label9,
																		  this.label8,
																		  this.label7,
																		  this.label6,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.button2,
																		  this.button1,
																		  this.textBox1,
																		  this.yanýk,
																		  this.sonuk,
																		  this.bir,
																		  this.iki,
																		  this.uc,
																		  this.dort,
																		  this.bes,
																		  this.altý,
																		  this.yedi,
																		  this.sekiz});
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "paralel port";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			byte bit,and;
			byte[]donusum=new byte[8];//0-255 arasý girilen sayýmýzýn bitler ayýrdýðýmýz zaman aktaracaðýmýz dizi
			if(textBox1.Text=="")
			{
				MessageBox.Show("Sayý girmeniz gerekiyor");
				return;
			}
			long degeregec=Convert.ToInt64(textBox1.Text);
			if(degeregec>255)
			{
				MessageBox.Show("0-255 arasý veri giriniz");
				if(textBox1.CanFocus)
				{
					textBox1.Focus();
				}
				return;
			}
            byte deger=Convert.ToByte(textBox1.Text);
			for(byte k=8;k>=1;k--)
			{
				and=1;
				for(int l=1;l<=k-1;l++)
				{
					and*=2;
				}
				bit=(byte)((deger&and)>>k-1);
				donusum[k-1]=bit;
			}
			
			if(donusum[7]==1)
			{
				sekiz.Image=yanýk.Image;
			}
			else if(donusum[7]==0)
			{
				sekiz.Image=sonuk.Image;
			}
			if(donusum[6]==1)
			{
				yedi.Image=yanýk.Image;
			}
			else if(donusum[6]==0)
			{
				yedi.Image=sonuk.Image;
			}
			if(donusum[5]==1)
			{
				altý.Image=yanýk.Image;
			}
			else if(donusum[5]==0)
			{
				altý.Image=sonuk.Image;
			}
			if(donusum[4]==1)
			{
				bes.Image=yanýk.Image;
			}
			else if(donusum[4]==0)
			{
				bes.Image=sonuk.Image;
			}
			if(donusum[3]==1)
			{
				dort.Image=yanýk.Image;
			}
			else if(donusum[3]==0)
			{
				dort.Image=sonuk.Image;
			}
			if(donusum[2]==1)
			{
				uc.Image=yanýk.Image;
			}
			else if(donusum[2]==0)
			{
				uc.Image=sonuk.Image;
			}
			if(donusum[1]==1)
			{
				iki.Image=yanýk.Image;
			}
			else if(donusum[1]==0)
			{
				iki.Image=sonuk.Image;
			}
			if(donusum[0]==1)
			{
				bir.Image=yanýk.Image;
			}
			else
			{
				bir.Image=sonuk.Image;
			}
			try
			{
				gonder.verigonder(888,deger);
				label1.Text="Veri baþarýyla gönderildi";
				textBox1.ResetText();
			}
			catch(Exception hata)
			{
				string error=hata.Message;
				MessageBox.Show("Veri gönderilirken hata oluþtu","hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			}

			

		
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			gonder.verigonder(888,0);
			sekiz.Image=sonuk.Image;
			yedi.Image=sonuk.Image;
			altý.Image=sonuk.Image;
			bes.Image=sonuk.Image;
			dort.Image=sonuk.Image;
			uc.Image=sonuk.Image;
			iki.Image=sonuk.Image;
			bir.Image=sonuk.Image;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			gonder.verigonder(888,0);
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			gonder.verigonder(888,0);
		}
		
	}
	public class gonder
	{
		[DllImport("inpout32.dll", EntryPoint="Out32")]
		public static extern void verigonder(int portno,int sayi);
	}
}
