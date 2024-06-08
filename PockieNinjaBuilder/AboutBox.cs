using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;
using PockieNinjaBuilder.Properties;

namespace PockieNinjaBuilder
{
	public class AboutBox : Form
	{
		private IContainer components;

		private PictureBox pictureBox1;

		private Label label1;

		private PictureBox pictureBox2;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.AboutBox));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(243, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 26);
			this.label1.TabIndex = 1;
			this.label1.Text = "Version: 0.9 beta\r\nCreator: Psychomaster";
			this.pictureBox2.Image = PockieNinjaBuilder.Properties.Resources.icon_512;
			this.pictureBox2.Location = new System.Drawing.Point(228, 11);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(139, 129);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox1.Image = PockieNinjaBuilder.Properties.Resources.PShunsuiKyoraku;
			this.pictureBox1.Location = new System.Drawing.Point(-3, -31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(229, 287);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(373, 216);
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutBox";
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About";
			base.Load += new System.EventHandler(AboutBox_Load);
			((System.ComponentModel.ISupportInitialize)this.pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public AboutBox()
		{
			InitializeComponent();
		}

		private void AboutBox_Load(object sender, EventArgs e)
		{
			label1.Text = "Version: " + DataLibrary.version + " beta\nCreator: Psychomaster";
		}
	}
}
