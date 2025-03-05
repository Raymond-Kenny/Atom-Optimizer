using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Atom_Optimizer.Properties;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;


namespace Atom_Optimizer
{
	public class Form1 : Form
	{

		private IContainer components;

		private Guna2DragControl guna2DragControl1;

		private PictureBox pictureBox1;

		private PictureBox pictureBox2;

		private Guna2TextBox username;

		private Guna2TextBox password;

		private Guna2Button activate;

		private Label sta;

		private Label label1;

		private Label label2;

		private Guna2AnimateWindow guna2AnimateWindow1;

		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		public Form1()
		{
			InitializeComponent();
			base.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void activate_Click(object sender, EventArgs e)
		{
		}

		private void LoginSuccess()
		{
			Hide();
			Form2 form = new Form2();
			form.Show();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Atom_Optimizer.Form1));
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.sta = new System.Windows.Forms.Label();
			this.activate = new Guna.UI2.WinForms.Guna2Button();
			this.password = new Guna.UI2.WinForms.Guna2TextBox();
			this.username = new Guna.UI2.WinForms.Guna2TextBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(9, 535);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Status :";
			this.sta.AutoSize = true;
			this.sta.Font = new System.Drawing.Font("Nirmala UI", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.sta.ForeColor = System.Drawing.Color.White;
			this.sta.Location = new System.Drawing.Point(56, 535);
			this.sta.Name = "sta";
			this.sta.Size = new System.Drawing.Size(29, 15);
			this.sta.TabIndex = 5;
			this.sta.Text = "N/A";
			this.activate.Animated = true;
			this.activate.AutoRoundedCorners = true;
			this.activate.BackColor = System.Drawing.Color.Transparent;
			this.activate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.activate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.activate.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
			this.activate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
			this.activate.FillColor = System.Drawing.Color.DimGray;
			this.activate.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold);
			this.activate.ForeColor = System.Drawing.Color.White;
			this.activate.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
			this.activate.Location = new System.Drawing.Point(123, 356);
			this.activate.Name = "activate";
			this.activate.Size = new System.Drawing.Size(141, 45);
			this.activate.TabIndex = 6;
			this.activate.Text = "Login";
			this.activate.Click += new System.EventHandler(activate_Click);
			this.password.Animated = true;
			this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.password.DefaultText = "";
			this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			this.password.FillColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			this.password.IconLeft = Atom_Optimizer.Properties.Resources.icons8_password_100;
			this.password.Location = new System.Drawing.Point(61, 266);
			this.password.Name = "password";
			this.password.PlaceholderText = "Enter Your Password";
			this.password.SelectedText = "";
			this.password.Size = new System.Drawing.Size(273, 44);
			this.password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.password.TabIndex = 3;
			this.password.UseSystemPasswordChar = true;
			this.username.Animated = true;
			this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.username.DefaultText = "";
			this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
			this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
			this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
			this.username.FillColor = System.Drawing.Color.FromArgb(32, 36, 41);
			this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.Font = new System.Drawing.Font("Nirmala UI", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
			this.username.IconLeft = Atom_Optimizer.Properties.Resources.icons8_user_100;
			this.username.Location = new System.Drawing.Point(61, 204);
			this.username.Name = "username";
			this.username.PlaceholderText = "Enter Your Username";
			this.username.SelectedText = "";
			this.username.Size = new System.Drawing.Size(273, 44);
			this.username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
			this.username.TabIndex = 2;
			this.pictureBox2.Image = Atom_Optimizer.Properties.Resources.text_1740551747993;
			this.pictureBox2.Location = new System.Drawing.Point(61, 23);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(273, 21);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Image = Atom_Optimizer.Properties.Resources.icons8_close_26;
			this.pictureBox1.Location = new System.Drawing.Point(365, 9);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 20);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(pictureBox1_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(160, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Login";
			this.guna2AnimateWindow1.TargetForm = this;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(32, 36, 41);
			base.ClientSize = new System.Drawing.Size(395, 558);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.activate);
			base.Controls.Add(this.sta);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.password);
			base.Controls.Add(this.username);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "Form1";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
