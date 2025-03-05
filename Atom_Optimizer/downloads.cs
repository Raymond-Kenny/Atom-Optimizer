using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Atom_Optimizer.Properties;
using Guna.UI2.WinForms;

namespace Atom_Optimizer
{
	public class downloads : Form
	{
		private IContainer components;

		private Label label2;

		private Guna2TileButton guna2TileButton1;

		private Guna2TileButton guna2TileButton2;

		private Guna2TileButton guna2TileButton3;

		private Guna2TileButton guna2TileButton4;

		private Guna2TileButton guna2TileButton5;

		private Guna2TileButton guna2TileButton6;

		private Guna2TileButton guna2TileButton7;

		private Guna2TileButton guna2TileButton8;

		private Guna2TileButton guna2TileButton9;

		private Guna2TileButton guna2TileButton10;

		private Guna2TileButton guna2TileButton11;

		private Guna2TileButton guna2TileButton12;

		private PictureBox pictureBox1;

		public downloads()
		{
			InitializeComponent();
		}

		private void guna2TileButton1_Click(object sender, EventArgs e)
		{
			DownloadFile("https://referrals.brave.com/latest/BraveBrowserSetup-BRV010.exe");
		}

		private void DownloadFile(string url)
		{
			try
			{
				string text = "C:\\AtomDownloads\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				string fileName = Path.GetFileName(new Uri(url).AbsolutePath);
				string text2 = Path.Combine(text, fileName);
				using (WebClient webClient = new WebClient())
				{
					webClient.DownloadFile(url, text2);
				}
				MessageBox.Show("Download Successful!\nFile saved at:\n" + text2, "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Download Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void guna2TileButton7_Click(object sender, EventArgs e)
		{
			DownloadFile("https://github.com/notimmortal546/Downloads/releases/download/v1/TimerRes.rar");
		}

		private void guna2TileButton2_Click(object sender, EventArgs e)
		{
			DownloadFile("https://github.com/notimmortal546/Downloads/releases/download/v1/ChromeSetup.exe");
		}

		private void guna2TileButton3_Click(object sender, EventArgs e)
		{
			DownloadFile("https://github.com/notimmortal546/Downloads/releases/download/v1/IObit.Driver.Booster.11.5.0.85.zip");
		}

		private void guna2TileButton4_Click(object sender, EventArgs e)
		{
			DownloadFile("https://github.com/notimmortal546/Downloads/releases/download/v1/MicrosoftEdgeSetup.exe");
		}

		private void guna2TileButton8_Click(object sender, EventArgs e)
		{
			DownloadFile("https://download.msi.com/uti_exe/vga/MSIAfterburnerSetup.zip?__token__=exp=1740549798~acl=/*~hmac=acaf256be3fa5e18cd8bf3bc2241ebcea807844e26a28c7cc24672337dfcc361");
		}

		private void guna2TileButton6_Click(object sender, EventArgs e)
		{
			DownloadFile("https://cdn-fastly.obsproject.com/downloads/OBS-Studio-31.0.1-Windows-Installer.exe");
		}

		private void guna2TileButton5_Click(object sender, EventArgs e)
		{
			DownloadFile("https://github.com/notimmortal546/Downloads/releases/download/v1/NVCleanstall_1.18.0.exe");
		}

		private void guna2TileButton12_Click(object sender, EventArgs e)
		{
			DownloadFile("https://www.7-zip.org/a/7z2409-x64.exe");
		}

		private void guna2TileButton11_Click(object sender, EventArgs e)
		{
			DownloadFile("https://stable.dl2.discordapp.net/distro/app/stable/win/x64/1.0.9183/DiscordSetup.exe");
		}

		private void guna2TileButton10_Click(object sender, EventArgs e)
		{
			DownloadFile("https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe");
		}

		private void guna2TileButton9_Click(object sender, EventArgs e)
		{
			DownloadFile("https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi");
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
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
			this.label2 = new System.Windows.Forms.Label();
			this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton4 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton5 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton6 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton7 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton8 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton9 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton10 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton11 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton12 = new Guna.UI2.WinForms.Guna2TileButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(161, 37);
			this.label2.TabIndex = 8;
			this.label2.Text = "Downloads";
			this.guna2TileButton1.Animated = true;
			this.guna2TileButton1.AutoRoundedCorners = true;
			this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton1.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton1.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton1.Location = new System.Drawing.Point(96, 82);
			this.guna2TileButton1.Name = "guna2TileButton1";
			this.guna2TileButton1.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton1.TabIndex = 9;
			this.guna2TileButton1.Text = "Brave Browser";
			this.guna2TileButton1.Click += new System.EventHandler(guna2TileButton1_Click);
			this.guna2TileButton2.Animated = true;
			this.guna2TileButton2.AutoRoundedCorners = true;
			this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton2.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton2.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton2.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton2.Location = new System.Drawing.Point(288, 82);
			this.guna2TileButton2.Name = "guna2TileButton2";
			this.guna2TileButton2.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton2.TabIndex = 10;
			this.guna2TileButton2.Text = "Chrome Browser";
			this.guna2TileButton2.Click += new System.EventHandler(guna2TileButton2_Click);
			this.guna2TileButton3.Animated = true;
			this.guna2TileButton3.AutoRoundedCorners = true;
			this.guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton3.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton3.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton3.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton3.Location = new System.Drawing.Point(478, 82);
			this.guna2TileButton3.Name = "guna2TileButton3";
			this.guna2TileButton3.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton3.TabIndex = 11;
			this.guna2TileButton3.Text = "Driver Booster";
			this.guna2TileButton3.Click += new System.EventHandler(guna2TileButton3_Click);
			this.guna2TileButton4.Animated = true;
			this.guna2TileButton4.AutoRoundedCorners = true;
			this.guna2TileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton4.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton4.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton4.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton4.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton4.Location = new System.Drawing.Point(666, 82);
			this.guna2TileButton4.Name = "guna2TileButton4";
			this.guna2TileButton4.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton4.TabIndex = 12;
			this.guna2TileButton4.Text = "Edge Browser";
			this.guna2TileButton4.Click += new System.EventHandler(guna2TileButton4_Click);
			this.guna2TileButton5.Animated = true;
			this.guna2TileButton5.AutoRoundedCorners = true;
			this.guna2TileButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton5.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton5.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton5.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton5.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton5.Location = new System.Drawing.Point(666, 261);
			this.guna2TileButton5.Name = "guna2TileButton5";
			this.guna2TileButton5.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton5.TabIndex = 16;
			this.guna2TileButton5.Text = "NVCleanstall";
			this.guna2TileButton5.Click += new System.EventHandler(guna2TileButton5_Click);
			this.guna2TileButton6.Animated = true;
			this.guna2TileButton6.AutoRoundedCorners = true;
			this.guna2TileButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton6.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton6.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton6.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton6.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton6.Location = new System.Drawing.Point(478, 261);
			this.guna2TileButton6.Name = "guna2TileButton6";
			this.guna2TileButton6.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton6.TabIndex = 15;
			this.guna2TileButton6.Text = "OBS Studio";
			this.guna2TileButton6.Click += new System.EventHandler(guna2TileButton6_Click);
			this.guna2TileButton7.Animated = true;
			this.guna2TileButton7.AutoRoundedCorners = true;
			this.guna2TileButton7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton7.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton7.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton7.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton7.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton7.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton7.Location = new System.Drawing.Point(288, 261);
			this.guna2TileButton7.Name = "guna2TileButton7";
			this.guna2TileButton7.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton7.TabIndex = 14;
			this.guna2TileButton7.Text = "Timer Resolution";
			this.guna2TileButton7.Click += new System.EventHandler(guna2TileButton7_Click);
			this.guna2TileButton8.Animated = true;
			this.guna2TileButton8.AutoRoundedCorners = true;
			this.guna2TileButton8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton8.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton8.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton8.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton8.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton8.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton8.Location = new System.Drawing.Point(96, 261);
			this.guna2TileButton8.Name = "guna2TileButton8";
			this.guna2TileButton8.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton8.TabIndex = 13;
			this.guna2TileButton8.Text = "Msi Afterburner";
			this.guna2TileButton8.Click += new System.EventHandler(guna2TileButton8_Click);
			this.guna2TileButton9.Animated = true;
			this.guna2TileButton9.AutoRoundedCorners = true;
			this.guna2TileButton9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton9.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton9.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton9.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton9.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton9.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton9.Location = new System.Drawing.Point(666, 436);
			this.guna2TileButton9.Name = "guna2TileButton9";
			this.guna2TileButton9.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton9.TabIndex = 20;
			this.guna2TileButton9.Text = "Epic Games";
			this.guna2TileButton9.Click += new System.EventHandler(guna2TileButton9_Click);
			this.guna2TileButton10.Animated = true;
			this.guna2TileButton10.AutoRoundedCorners = true;
			this.guna2TileButton10.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton10.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton10.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton10.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton10.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton10.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton10.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton10.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton10.Location = new System.Drawing.Point(478, 436);
			this.guna2TileButton10.Name = "guna2TileButton10";
			this.guna2TileButton10.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton10.TabIndex = 19;
			this.guna2TileButton10.Text = "Steam";
			this.guna2TileButton10.Click += new System.EventHandler(guna2TileButton10_Click);
			this.guna2TileButton11.Animated = true;
			this.guna2TileButton11.AutoRoundedCorners = true;
			this.guna2TileButton11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton11.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton11.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton11.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton11.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton11.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton11.Location = new System.Drawing.Point(288, 436);
			this.guna2TileButton11.Name = "guna2TileButton11";
			this.guna2TileButton11.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton11.TabIndex = 18;
			this.guna2TileButton11.Text = "Discord";
			this.guna2TileButton11.Click += new System.EventHandler(guna2TileButton11_Click);
			this.guna2TileButton12.Animated = true;
			this.guna2TileButton12.AutoRoundedCorners = true;
			this.guna2TileButton12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2TileButton12.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2TileButton12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2TileButton12.FillColor = System.Drawing.Color.FromArgb(38, 41, 49);
			this.guna2TileButton12.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.guna2TileButton12.ForeColor = System.Drawing.Color.White;
			this.guna2TileButton12.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.guna2TileButton12.Location = new System.Drawing.Point(96, 436);
			this.guna2TileButton12.Name = "guna2TileButton12";
			this.guna2TileButton12.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton12.TabIndex = 17;
			this.guna2TileButton12.Text = "7zip";
			this.guna2TileButton12.Click += new System.EventHandler(guna2TileButton12_Click);
			this.pictureBox1.Image = Atom_Optimizer.Properties.Resources.icons8_close_26;
			this.pictureBox1.Location = new System.Drawing.Point(916, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(32, 36, 41);
			base.ClientSize = new System.Drawing.Size(948, 666);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.guna2TileButton9);
			base.Controls.Add(this.guna2TileButton10);
			base.Controls.Add(this.guna2TileButton11);
			base.Controls.Add(this.guna2TileButton12);
			base.Controls.Add(this.guna2TileButton5);
			base.Controls.Add(this.guna2TileButton6);
			base.Controls.Add(this.guna2TileButton7);
			base.Controls.Add(this.guna2TileButton8);
			base.Controls.Add(this.guna2TileButton4);
			base.Controls.Add(this.guna2TileButton3);
			base.Controls.Add(this.guna2TileButton2);
			base.Controls.Add(this.guna2TileButton1);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "downloads";
			this.Text = "downloads";
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
