using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Atom_Optimizer.Properties;
using Guna.UI2.WinForms;

namespace Atom_Optimizer
{
	public class cpu : Form
	{
		private IContainer components;

		private PictureBox pictureBox2;

		private Label label2;

		private Guna2TileButton guna2TileButton1;

		private Guna2TileButton guna2TileButton7;

		private Guna2TileButton guna2TileButton2;

		public cpu()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void guna2TileButton7_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to continue...?", "Optimization Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult != DialogResult.Yes)
			{
				return;
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "intel.bat");
				using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Atom_Optimizer.intel.bat"))
				{
					using (FileStream destination = new FileStream(text, FileMode.Create, FileAccess.Write))
					{
						stream.CopyTo(destination);
					}
				}
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = text,
					UseShellExecute = true,
					CreateNoWindow = false,
					WindowStyle = ProcessWindowStyle.Normal
				};
				using (Process process = Process.Start(startInfo))
				{
					process.WaitForExit();
					MessageBox.Show("Operation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				Thread.Sleep(2000);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to start optimization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void guna2TileButton1_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you want to continue...?", "Optimization Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult != DialogResult.Yes)
			{
				return;
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "amd.bat");
				using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Atom_Optimizer.amd.bat"))
				{
					using (FileStream destination = new FileStream(text, FileMode.Create, FileAccess.Write))
					{
						stream.CopyTo(destination);
					}
				}
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = text,
					UseShellExecute = true,
					CreateNoWindow = false,
					WindowStyle = ProcessWindowStyle.Normal
				};
				using (Process process = Process.Start(startInfo))
				{
					process.WaitForExit();
					MessageBox.Show("Operation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				Thread.Sleep(2000);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to start optimization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void guna2TileButton2_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("This will disable some features that you might need...", "Optimization Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult != DialogResult.Yes)
			{
				return;
			}
			try
			{
				string text = Path.Combine(Path.GetTempPath(), "process.bat");
				using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Atom_Optimizer.process.bat"))
				{
					using (FileStream destination = new FileStream(text, FileMode.Create, FileAccess.Write))
					{
						stream.CopyTo(destination);
					}
				}
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = text,
					UseShellExecute = true,
					CreateNoWindow = false,
					WindowStyle = ProcessWindowStyle.Normal
				};
				using (Process process = Process.Start(startInfo))
				{
					process.WaitForExit();
					MessageBox.Show("Operation Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				Thread.Sleep(2000);
				if (File.Exists(text))
				{
					File.Delete(text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to start optimization: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
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
			this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
			this.guna2TileButton7 = new Guna.UI2.WinForms.Guna2TileButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 37);
			this.label2.TabIndex = 25;
			this.label2.Text = "Cpu Tweaks";
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
			this.guna2TileButton2.Image = Atom_Optimizer.Properties.Resources.synergy;
			this.guna2TileButton2.ImageSize = new System.Drawing.Size(53, 53);
			this.guna2TileButton2.Location = new System.Drawing.Point(389, 323);
			this.guna2TileButton2.Name = "guna2TileButton2";
			this.guna2TileButton2.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton2.TabIndex = 28;
			this.guna2TileButton2.Text = "Processes Lower";
			this.guna2TileButton2.Click += new System.EventHandler(guna2TileButton2_Click);
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
			this.guna2TileButton1.Image = Atom_Optimizer.Properties.Resources.amd;
			this.guna2TileButton1.ImageSize = new System.Drawing.Size(53, 53);
			this.guna2TileButton1.Location = new System.Drawing.Point(493, 164);
			this.guna2TileButton1.Name = "guna2TileButton1";
			this.guna2TileButton1.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton1.TabIndex = 27;
			this.guna2TileButton1.Text = "AMD Tweaks";
			this.guna2TileButton1.Click += new System.EventHandler(guna2TileButton1_Click);
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
			this.guna2TileButton7.Image = Atom_Optimizer.Properties.Resources.intel;
			this.guna2TileButton7.ImageSize = new System.Drawing.Size(53, 53);
			this.guna2TileButton7.Location = new System.Drawing.Point(282, 164);
			this.guna2TileButton7.Name = "guna2TileButton7";
			this.guna2TileButton7.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton7.TabIndex = 26;
			this.guna2TileButton7.Text = "Intel Tweaks";
			this.guna2TileButton7.Click += new System.EventHandler(guna2TileButton7_Click);
			this.pictureBox2.Image = Atom_Optimizer.Properties.Resources.icons8_close_26;
			this.pictureBox2.Location = new System.Drawing.Point(916, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 24;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(32, 36, 41);
			base.ClientSize = new System.Drawing.Size(948, 666);
			base.Controls.Add(this.guna2TileButton2);
			base.Controls.Add(this.guna2TileButton1);
			base.Controls.Add(this.guna2TileButton7);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.pictureBox2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "cpu";
			this.Text = "cpu";
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
