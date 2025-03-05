using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Atom_Optimizer.Properties;
using Guna.UI2.WinForms;

namespace Atom_Optimizer
{
	public class Form2 : Form
	{
		private IContainer components;

		private Panel panel1;

		private Guna2Button guna2Button1;

		private Guna2Button guna2Button2;

		private Guna2Button guna2Button3;

		private Guna2Button guna2Button4;

		private PictureBox pictureBox1;

		private Panel mainpnl;

		private Guna2Button guna2Button5;

		private Label label2;

		private Label label1;

		private Guna2Button guna2Button7;

		private Guna2Button guna2Button6;

		private Guna2Button guna2Button8;

		private Guna2Button guna2Button9;

		private Guna2DragControl guna2DragControl1;

		private Guna2AnimateWindow guna2AnimateWindow1;

		private Guna2Button guna2Button10;

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		public Form2()
		{
			InitializeComponent();
			base.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
			mainpnl.Controls.Clear();
			welcome welcome2 = new welcome
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			welcome2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(welcome2);
			welcome2.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void guna2Button5_Click(object sender, EventArgs e)
		{
			string fileName = "https://dsc.gg/projectatom/";
			Process.Start(new ProcessStartInfo
			{
				FileName = fileName,
				UseShellExecute = true
			});
		}

		private void guna2Button9_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			downloads downloads2 = new downloads
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			downloads2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(downloads2);
			downloads2.Show();
		}

		private void guna2Button8_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			debloat debloat2 = new debloat
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			debloat2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(debloat2);
			debloat2.Show();
		}

		private void guna2Button6_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			power power2 = new power
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			power2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(power2);
			power2.Show();
		}

		private void guna2Button4_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			ram ram2 = new ram
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			ram2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(ram2);
			ram2.Show();
		}

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			cpu cpu2 = new cpu
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			cpu2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(cpu2);
			cpu2.Show();
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			network network2 = new network
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			network2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(network2);
			network2.Show();
		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			windows windows2 = new windows
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			windows2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(windows2);
			windows2.Show();
		}

		private void guna2Button7_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			general general2 = new general
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			general2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(general2);
			general2.Show();
		}

		private void guna2Button10_Click(object sender, EventArgs e)
		{
			mainpnl.Controls.Clear();
			gpu gpu2 = new gpu
			{
				Dock = DockStyle.Fill,
				TopLevel = false,
				TopMost = true
			};
			gpu2.FormBorderStyle = FormBorderStyle.None;
			mainpnl.Controls.Add(gpu2);
			gpu2.Show();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atom_Optimizer.Form2));
			this.panel1 = new System.Windows.Forms.Panel();
			this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.mainpnl = new System.Windows.Forms.Panel();
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.panel1.Controls.Add(this.guna2Button10);
			this.panel1.Controls.Add(this.guna2Button9);
			this.panel1.Controls.Add(this.guna2Button8);
			this.panel1.Controls.Add(this.guna2Button7);
			this.panel1.Controls.Add(this.guna2Button6);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.guna2Button5);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.guna2Button4);
			this.panel1.Controls.Add(this.guna2Button3);
			this.panel1.Controls.Add(this.guna2Button2);
			this.panel1.Controls.Add(this.guna2Button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(182, 666);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			this.guna2Button9.Animated = true;
			this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button9.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button9.ForeColor = System.Drawing.Color.White;
			this.guna2Button9.Image = Atom_Optimizer.Properties.Resources.icons8_downloads_100;
			this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button9.Location = new System.Drawing.Point(0, 554);
			this.guna2Button9.Name = "guna2Button9";
			this.guna2Button9.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button9.Size = new System.Drawing.Size(182, 45);
			this.guna2Button9.TabIndex = 11;
			this.guna2Button9.Text = "Downloads";
			this.guna2Button9.Click += new System.EventHandler(guna2Button9_Click);
			this.guna2Button8.Animated = true;
			this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button8.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button8.ForeColor = System.Drawing.Color.White;
			this.guna2Button8.Image = Atom_Optimizer.Properties.Resources.icons8_trash_100__1_;
			this.guna2Button8.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button8.Location = new System.Drawing.Point(0, 503);
			this.guna2Button8.Name = "guna2Button8";
			this.guna2Button8.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button8.Size = new System.Drawing.Size(182, 45);
			this.guna2Button8.TabIndex = 10;
			this.guna2Button8.Text = "Debloat ";
			this.guna2Button8.Click += new System.EventHandler(guna2Button8_Click);
			this.guna2Button7.Animated = true;
			this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button7.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button7.ForeColor = System.Drawing.Color.White;
			this.guna2Button7.Image = Atom_Optimizer.Properties.Resources.icons8_settings_100;
			this.guna2Button7.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button7.Location = new System.Drawing.Point(0, 146);
			this.guna2Button7.Name = "guna2Button7";
			this.guna2Button7.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button7.Size = new System.Drawing.Size(182, 45);
			this.guna2Button7.TabIndex = 9;
			this.guna2Button7.Text = "    General Tweaks";
			this.guna2Button7.Click += new System.EventHandler(guna2Button7_Click);
			this.guna2Button6.Animated = true;
			this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button6.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button6.ForeColor = System.Drawing.Color.White;
			this.guna2Button6.Image = Atom_Optimizer.Properties.Resources.icons8_power_100;
			this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button6.Location = new System.Drawing.Point(-1, 452);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button6.Size = new System.Drawing.Size(183, 45);
			this.guna2Button6.TabIndex = 8;
			this.guna2Button6.Text = "Power Tweaks";
			this.guna2Button6.Click += new System.EventHandler(guna2Button6_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(27, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Optimizer V2";
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(59, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Atom";
			this.guna2Button5.Animated = true;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button5.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button5.ForeColor = System.Drawing.Color.White;
			this.guna2Button5.Image = Atom_Optimizer.Properties.Resources.discord;
			this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button5.Location = new System.Drawing.Point(0, 621);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button5.Size = new System.Drawing.Size(182, 45);
			this.guna2Button5.TabIndex = 5;
			this.guna2Button5.Text = "Need Support ?";
			this.guna2Button5.Click += new System.EventHandler(guna2Button5_Click);
			this.pictureBox1.Image = Atom_Optimizer.Properties.Resources.logo;
			this.pictureBox1.Location = new System.Drawing.Point(-3, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(185, 55);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			this.guna2Button4.Animated = true;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button4.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button4.ForeColor = System.Drawing.Color.White;
			this.guna2Button4.Image = Atom_Optimizer.Properties.Resources.icons8_ram_100;
			this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button4.Location = new System.Drawing.Point(-1, 350);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button4.Size = new System.Drawing.Size(183, 45);
			this.guna2Button4.TabIndex = 3;
			this.guna2Button4.Text = "Ram Tweaks";
			this.guna2Button4.Click += new System.EventHandler(guna2Button4_Click);
			this.guna2Button3.Animated = true;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button3.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button3.ForeColor = System.Drawing.Color.White;
			this.guna2Button3.Image = Atom_Optimizer.Properties.Resources.icons8_processor_100__2_;
			this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button3.Location = new System.Drawing.Point(-1, 299);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button3.Size = new System.Drawing.Size(183, 45);
			this.guna2Button3.TabIndex = 2;
			this.guna2Button3.Text = "Cpu Tweaks";
			this.guna2Button3.Click += new System.EventHandler(guna2Button3_Click);
			this.guna2Button2.Animated = true;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button2.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button2.ForeColor = System.Drawing.Color.White;
			this.guna2Button2.Image = Atom_Optimizer.Properties.Resources.icons8_internet_100;
			this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button2.Location = new System.Drawing.Point(-1, 248);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button2.Size = new System.Drawing.Size(183, 45);
			this.guna2Button2.TabIndex = 1;
			this.guna2Button2.Text = "  Network Tweaks";
			this.guna2Button2.Click += new System.EventHandler(guna2Button2_Click);
			this.guna2Button1.Animated = true;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button1.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button1.ForeColor = System.Drawing.Color.White;
			this.guna2Button1.Image = Atom_Optimizer.Properties.Resources.icons8_windows_100;
			this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button1.Location = new System.Drawing.Point(0, 197);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button1.Size = new System.Drawing.Size(182, 45);
			this.guna2Button1.TabIndex = 0;
			this.guna2Button1.Text = "    Windows Tweaks";
			this.guna2Button1.Click += new System.EventHandler(guna2Button1_Click);
			this.mainpnl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainpnl.Location = new System.Drawing.Point(182, 0);
			this.mainpnl.Name = "mainpnl";
			this.mainpnl.Size = new System.Drawing.Size(948, 666);
			this.mainpnl.TabIndex = 1;
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.guna2AnimateWindow1.TargetForm = this;
			this.guna2Button10.Animated = true;
			this.guna2Button10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button10.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button10.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2Button10.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Button10.ForeColor = System.Drawing.Color.White;
			this.guna2Button10.Image = Atom_Optimizer.Properties.Resources.icons8_gpu_100;
			this.guna2Button10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button10.Location = new System.Drawing.Point(-1, 401);
			this.guna2Button10.Name = "guna2Button10";
			this.guna2Button10.PressedColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.guna2Button10.Size = new System.Drawing.Size(183, 45);
			this.guna2Button10.TabIndex = 12;
			this.guna2Button10.Text = "Gpu Tweaks";
			this.guna2Button10.Click += new System.EventHandler(guna2Button10_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(32, 36, 41);
			base.ClientSize = new System.Drawing.Size(1130, 666);
			base.Controls.Add(this.mainpnl);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form2";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Atom Optimizer V2";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}
	}
}
