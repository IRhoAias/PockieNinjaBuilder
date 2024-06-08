using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class WingForm : Form
	{
		private MainForm mainform;

		private IContainer components;

		private ComboBox WingType;

		private NumericUpDown WingEnhance;

		private ComboBox WingRefine;

		private NumericUpDown WingRefineVal;

		private Label label1;

		private Label label2;

		private Button SaveButton;

		public WingForm(MainForm main)
		{
			mainform = main;
			InitializeComponent();
			Wing[] wings = DataLibrary.wings;
			foreach (Wing item in wings)
			{
				WingType.Items.Add(item);
			}
		}

		private void WingType_SelectedIndexChanged(object sender, EventArgs e)
		{
			string[] array = new string[8] { "Hit Enhancement", "Pierce Enhancement", "Armor Break Enhancement", "Constitution Enhancement", "Defense Enhancement", "Dodge Enhancement", "Block Enhancement", "Critical Enhancement" };
			Wing wing = (Wing)WingType.SelectedItem;
			WingRefine.Items.Clear();
			for (int i = 0; i < wing.bonus; i++)
			{
				WingRefine.Items.Add(array[i]);
			}
			if (wing.bonus > 0)
			{
				label2.Visible = true;
				WingRefine.Visible = true;
				WingRefineVal.Visible = true;
			}
			else
			{
				label2.Visible = false;
				WingRefine.Visible = false;
				WingRefineVal.Visible = false;
			}
		}

		public void fillWing(int[] w)
		{
			if (w[0] != -1)
			{
				WingType.SelectedIndex = w[0];
				WingEnhance.Value = w[1];
				if (w[2] != -1)
				{
					WingRefine.SelectedIndex = w[2];
					WingRefineVal.Value = w[3];
				}
			}
		}

		private void WingType_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index >= 0)
			{
				Rectangle rect = bounds;
				rect.Width = rect.Height;
				Rectangle rectangle = bounds;
				rectangle.X = rect.Right;
				rectangle.Width = bounds.Width - rect.Width;
				rectangle.Height = 13;
				Rectangle rectangle2 = bounds;
				rectangle2.X = rect.Right;
				rectangle2.Y = rectangle.Bottom;
				Wing wing = (Wing)WingType.Items[e.Index];
				StringFormat format = new StringFormat();
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Near;
				StringFormat stringFormat2 = new StringFormat();
				stringFormat2.Alignment = StringAlignment.Far;
				Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
				Font font2 = new Font(e.Font.FontFamily, (float)((double)e.Font.Size * 0.8), FontStyle.Regular);
				Brush brush = new SolidBrush(e.ForeColor);
				Brush brush2 = new SolidBrush(Color.DarkBlue);
				e.Graphics.FillRectangle(new SolidBrush(e.BackColor), bounds);
				e.Graphics.DrawImage(wing.image, rect);
				e.Graphics.DrawString(wing.name + " +" + (int)WingEnhance.Value, font, brush, rectangle, format);
				string text = "";
				for (int i = 0; i < wing.values[0].Length; i++)
				{
					text = text + wing.values[0][i].ToString() + ((WingEnhance.Value > 0m) ? (" (+" + (wing.values[(int)WingEnhance.Value][i].value - wing.values[0][i].value) + ")") : "") + "\n";
				}
				e.Graphics.DrawString(text, font2, brush2, rectangle2, stringFormat);
				e.DrawFocusRectangle();
			}
		}

		private void WingEnhance_ValueChanged(object sender, EventArgs e)
		{
			WingType.Refresh();
		}

		private void WingForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (WingType.SelectedIndex != -1)
			{
				mainform.ProfileManager.currentProfile.wings[0] = ((Wing)WingType.SelectedItem).id;
				mainform.ProfileManager.currentProfile.wings[1] = (int)WingEnhance.Value;
				if (((Wing)WingType.SelectedItem).bonus > 0)
				{
					mainform.ProfileManager.currentProfile.wings[2] = WingRefine.SelectedIndex;
					mainform.ProfileManager.currentProfile.wings[3] = (int)WingRefineVal.Value;
				}
				else
				{
					mainform.ProfileManager.currentProfile.wings[2] = -1;
					mainform.ProfileManager.currentProfile.wings[3] = 0;
				}
				mainform.UpdateBuild();
				Hide();
			}
			else
			{
				MessageBox.Show("No wings selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.WingForm));
			this.WingType = new System.Windows.Forms.ComboBox();
			this.WingEnhance = new System.Windows.Forms.NumericUpDown();
			this.WingRefine = new System.Windows.Forms.ComboBox();
			this.WingRefineVal = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.WingEnhance).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.WingRefineVal).BeginInit();
			base.SuspendLayout();
			this.WingType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.WingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WingType.FormattingEnabled = true;
			this.WingType.ItemHeight = 56;
			this.WingType.Location = new System.Drawing.Point(15, 25);
			this.WingType.Name = "WingType";
			this.WingType.Size = new System.Drawing.Size(249, 62);
			this.WingType.TabIndex = 0;
			this.WingType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(WingType_DrawItem);
			this.WingType.SelectedIndexChanged += new System.EventHandler(WingType_SelectedIndexChanged);
			this.WingEnhance.Location = new System.Drawing.Point(270, 46);
			this.WingEnhance.Maximum = new decimal(new int[4] { 24, 0, 0, 0 });
			this.WingEnhance.Name = "WingEnhance";
			this.WingEnhance.Size = new System.Drawing.Size(69, 20);
			this.WingEnhance.TabIndex = 1;
			this.WingEnhance.ValueChanged += new System.EventHandler(WingEnhance_ValueChanged);
			this.WingRefine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.WingRefine.FormattingEnabled = true;
			this.WingRefine.Items.AddRange(new object[6] { "", "Hit Enhancement", "Pierce Enhancement", "Armor Break Enhancement", "Constitution Enhancement", "Defense Enhancement" });
			this.WingRefine.Location = new System.Drawing.Point(15, 114);
			this.WingRefine.Name = "WingRefine";
			this.WingRefine.Size = new System.Drawing.Size(249, 21);
			this.WingRefine.TabIndex = 2;
			this.WingRefine.Visible = false;
			this.WingRefineVal.Location = new System.Drawing.Point(270, 114);
			this.WingRefineVal.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.WingRefineVal.Minimum = new decimal(new int[4] { 3, 0, 0, 0 });
			this.WingRefineVal.Name = "WingRefineVal";
			this.WingRefineVal.Size = new System.Drawing.Size(69, 20);
			this.WingRefineVal.TabIndex = 3;
			this.WingRefineVal.Value = new decimal(new int[4] { 3, 0, 0, 0 });
			this.WingRefineVal.Visible = false;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Wings:";
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Refining: ";
			this.label2.Visible = false;
			this.SaveButton.Location = new System.Drawing.Point(128, 141);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(94, 23);
			this.SaveButton.TabIndex = 6;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(SaveButton_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(351, 179);
			base.Controls.Add(this.SaveButton);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.WingRefineVal);
			base.Controls.Add(this.WingRefine);
			base.Controls.Add(this.WingEnhance);
			base.Controls.Add(this.WingType);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "WingForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wings";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(WingForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)this.WingEnhance).EndInit();
			((System.ComponentModel.ISupportInitialize)this.WingRefineVal).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
