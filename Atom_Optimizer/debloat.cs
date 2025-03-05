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
	public class debloat : Form
	{
		private IContainer components;

		private Label label2;

		private Guna2TileButton guna2TileButton7;

		private PictureBox pictureBox1;

		private Label label1;

		private PictureBox pictureBox2;

		public debloat()
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
				string text = Path.Combine(Path.GetTempPath(), "debloat.bat");
				using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Atom_Optimizer.debloat.bat"))
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
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.guna2TileButton7 = new Guna.UI2.WinForms.Guna2TileButton();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 20.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 37);
			this.label2.TabIndex = 9;
			this.label2.Text = "Debloat";
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(61, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(651, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "This will remove all unnecessary bloatware, optimizing your system for better performance.";
			this.pictureBox2.Image = Atom_Optimizer.Properties.Resources.icons8_close_26;
			this.pictureBox2.Location = new System.Drawing.Point(916, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 22;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			this.pictureBox1.Image = Atom_Optimizer.Properties.Resources.info;
			this.pictureBox1.Location = new System.Drawing.Point(36, 87);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
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
			this.guna2TileButton7.Image = Atom_Optimizer.Properties.Resources.trash;
			this.guna2TileButton7.ImageSize = new System.Drawing.Size(53, 53);
			this.guna2TileButton7.Location = new System.Drawing.Point(378, 231);
			this.guna2TileButton7.Name = "guna2TileButton7";
			this.guna2TileButton7.Size = new System.Drawing.Size(163, 153);
			this.guna2TileButton7.TabIndex = 15;
			this.guna2TileButton7.Text = "Remove All Bloatwares";
			this.guna2TileButton7.Click += new System.EventHandler(guna2TileButton7_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(32, 36, 41);
			base.ClientSize = new System.Drawing.Size(948, 666);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.guna2TileButton7);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "debloat";
			this.Text = "debloat";
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
