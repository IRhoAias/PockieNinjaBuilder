using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PockieNinjaBuilder
{
	public class ChineseForm : Form
	{
		private MainForm main;

		private IContainer components;

		private Label label1;

		private MaskedTextBox pwField;

		private Button EnterMode;

		public ChineseForm(MainForm main)
		{
			this.main = main;
			InitializeComponent();
		}

		private void EnterMode_Click(object sender, EventArgs e)
		{
			if (pwField.Text == "enterchinesemode")
			{
				main.chinesemode = true;
			}
			main.loadChinese();
			Close();
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
			this.label1 = new System.Windows.Forms.Label();
			this.pwField = new System.Windows.Forms.MaskedTextBox();
			this.EnterMode = new System.Windows.Forms.Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Do you like to activate the Developer-Mode?\r\nPlease insert password:";
			this.pwField.Location = new System.Drawing.Point(59, 48);
			this.pwField.Name = "pwField";
			this.pwField.Size = new System.Drawing.Size(125, 20);
			this.pwField.TabIndex = 1;
			this.EnterMode.Location = new System.Drawing.Point(84, 74);
			this.EnterMode.Name = "EnterMode";
			this.EnterMode.Size = new System.Drawing.Size(75, 23);
			this.EnterMode.TabIndex = 2;
			this.EnterMode.Text = "Enter";
			this.EnterMode.UseVisualStyleBackColor = true;
			this.EnterMode.Click += new System.EventHandler(EnterMode_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(243, 104);
			base.Controls.Add(this.EnterMode);
			base.Controls.Add(this.pwField);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ChineseForm";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Developer Mode";
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
