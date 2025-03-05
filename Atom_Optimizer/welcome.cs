using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Atom_Optimizer.Properties;

namespace Atom_Optimizer
{
	public class welcome : Form
	{
		private IContainer components;

		private Label label2;

		private PictureBox pictureBox2;

		private PictureBox pictureBox1;

		private Label label1;

		public welcome()
		{
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			Application.Exit();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atom_Optimizer.welcome));
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(227, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(501, 45);
			this.label2.TabIndex = 28;
			this.label2.Text = "Welcome To Atom Optimizer V2";
			this.pictureBox2.Image = Atom_Optimizer.Properties.Resources.icons8_close_26;
			this.pictureBox2.Location = new System.Drawing.Point(916, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 29;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(pictureBox2_Click);
			this.pictureBox1.Image = Atom_Optimizer.Properties.Resources.info;
			this.pictureBox1.Location = new System.Drawing.Point(60, 153);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(91, 155);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(742, 240);
			this.label1.TabIndex = 31;
			this.label1.Text = resources.GetString("label1.Text");
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(32, 36, 41);
			base.ClientSize = new System.Drawing.Size(948, 666);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.label2);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "welcome";
			this.Text = "welcome";
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
