using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder
{
	public class BloodlineForm : Form
	{
		private IContainer components;

		private ListControl BLListControl;

		private Button BLSave;

		private ComboBox BLtype;

		private GroupBox BLFilterBox;

		private Button FilterShow;

		private ComboBox BLValTwo;

		private Label label2;

		private Label label1;

		private ComboBox BLValOne;

		private ComboBox BLEffect;

		private Label label3;

		private Button BLFilterReset;

		private MainForm form;

		private int clicked;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.BloodlineForm));
			this.BLSave = new System.Windows.Forms.Button();
			this.BLtype = new System.Windows.Forms.ComboBox();
			this.BLFilterBox = new System.Windows.Forms.GroupBox();
			this.BLEffect = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BLFilterReset = new System.Windows.Forms.Button();
			this.FilterShow = new System.Windows.Forms.Button();
			this.BLValTwo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BLValOne = new System.Windows.Forms.ComboBox();
			this.BLListControl = new PockieNinjaBuilder.ListControl();
			this.BLFilterBox.SuspendLayout();
			base.SuspendLayout();
			this.BLSave.Location = new System.Drawing.Point(163, 380);
			this.BLSave.Name = "BLSave";
			this.BLSave.Size = new System.Drawing.Size(94, 23);
			this.BLSave.TabIndex = 2;
			this.BLSave.Text = "Save";
			this.BLSave.UseVisualStyleBackColor = true;
			this.BLSave.Click += new System.EventHandler(BLSave_Click);
			this.BLtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BLtype.FormattingEnabled = true;
			this.BLtype.Items.AddRange(new object[8] { "", "Green", "Blue", "Purple", "Orange", "Dark Red", "Dark Gold", "Pink" });
			this.BLtype.Location = new System.Drawing.Point(9, 36);
			this.BLtype.Name = "BLtype";
			this.BLtype.Size = new System.Drawing.Size(94, 21);
			this.BLtype.TabIndex = 3;
			this.BLFilterBox.Controls.Add(this.BLEffect);
			this.BLFilterBox.Controls.Add(this.label3);
			this.BLFilterBox.Controls.Add(this.BLFilterReset);
			this.BLFilterBox.Controls.Add(this.FilterShow);
			this.BLFilterBox.Controls.Add(this.BLValTwo);
			this.BLFilterBox.Controls.Add(this.label2);
			this.BLFilterBox.Controls.Add(this.label1);
			this.BLFilterBox.Controls.Add(this.BLValOne);
			this.BLFilterBox.Controls.Add(this.BLtype);
			this.BLFilterBox.Location = new System.Drawing.Point(12, 12);
			this.BLFilterBox.Name = "BLFilterBox";
			this.BLFilterBox.Size = new System.Drawing.Size(399, 130);
			this.BLFilterBox.TabIndex = 4;
			this.BLFilterBox.TabStop = false;
			this.BLFilterBox.Text = "Filter";
			this.BLEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BLEffect.FormattingEnabled = true;
			this.BLEffect.Items.AddRange(new object[11]
			{
				"", "Ninja Tools", "Taijutsu", "Healing", "Sealing Jutsu", "Illusion", "Water", "Wind", "Earth", "Fire",
				"Lightning"
			});
			this.BLEffect.Location = new System.Drawing.Point(272, 36);
			this.BLEffect.Name = "BLEffect";
			this.BLEffect.Size = new System.Drawing.Size(121, 21);
			this.BLEffect.TabIndex = 11;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(269, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Effect:";
			this.BLFilterReset.Location = new System.Drawing.Point(241, 98);
			this.BLFilterReset.Name = "BLFilterReset";
			this.BLFilterReset.Size = new System.Drawing.Size(58, 23);
			this.BLFilterReset.TabIndex = 9;
			this.BLFilterReset.Text = "reset";
			this.BLFilterReset.UseVisualStyleBackColor = true;
			this.BLFilterReset.Click += new System.EventHandler(BLFilterReset_Click);
			this.FilterShow.Location = new System.Drawing.Point(139, 98);
			this.FilterShow.Name = "FilterShow";
			this.FilterShow.Size = new System.Drawing.Size(96, 23);
			this.FilterShow.TabIndex = 8;
			this.FilterShow.Text = "show";
			this.FilterShow.UseVisualStyleBackColor = true;
			this.FilterShow.Click += new System.EventHandler(FilterShow_Click);
			this.BLValTwo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BLValTwo.FormattingEnabled = true;
			this.BLValTwo.Items.AddRange(new object[14]
			{
				"", "Agility", "Armor Break", "Block", "Constitution", "Critical Strike", "Defense", "Dodge", "Hit", "HP",
				"Pierce", "Speed", "Stamina", "Strength"
			});
			this.BLValTwo.Location = new System.Drawing.Point(128, 63);
			this.BLValTwo.Name = "BLValTwo";
			this.BLValTwo.Size = new System.Drawing.Size(121, 21);
			this.BLValTwo.TabIndex = 7;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Attributes:";
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Grade:";
			this.BLValOne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BLValOne.FormattingEnabled = true;
			this.BLValOne.Items.AddRange(new object[14]
			{
				"", "Agility", "Armor Break", "Block", "Constitution", "Critical Strike", "Defense", "Dodge", "Hit", "HP",
				"Pierce", "Speed", "Stamina", "Strength"
			});
			this.BLValOne.Location = new System.Drawing.Point(128, 36);
			this.BLValOne.Name = "BLValOne";
			this.BLValOne.Size = new System.Drawing.Size(121, 21);
			this.BLValOne.TabIndex = 4;
			this.BLListControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BLListControl.Location = new System.Drawing.Point(0, 148);
			this.BLListControl.Name = "BLListControl";
			this.BLListControl.Size = new System.Drawing.Size(423, 226);
			this.BLListControl.TabIndex = 1;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(423, 415);
			base.Controls.Add(this.BLFilterBox);
			base.Controls.Add(this.BLSave);
			base.Controls.Add(this.BLListControl);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "BloodlineForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bloodlines";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(BloodlineForm_FormClosing);
			this.BLFilterBox.ResumeLayout(false);
			this.BLFilterBox.PerformLayout();
			base.ResumeLayout(false);
		}

		public BloodlineForm(MainForm f)
		{
			InitializeComponent();
			form = f;
		}

		public void resetFilter()
		{
			BLtype.SelectedIndex = 0;
			BLValOne.SelectedIndex = 0;
			BLValTwo.SelectedIndex = 0;
			BLEffect.SelectedIndex = 0;
			loadBLs(clicked);
		}

		private bool isFiltered(Bloodline bl)
		{
			bool flag = true;
			if (BLtype.SelectedIndex != 0)
			{
				if (BLtype.SelectedIndex != 1 && bl.level >= 25 && bl.level < 36)
				{
					flag = false;
				}
				else if (BLtype.SelectedIndex != 2 && bl.level >= 36 && bl.level < 51)
				{
					flag = false;
				}
				else if (BLtype.SelectedIndex != 3 && bl.level >= 51 && bl.level < 71)
				{
					flag = false;
				}
				else if (BLtype.SelectedIndex != 4 && bl.level >= 71 && bl.level < 81)
				{
					flag = false;
				}
				else if (BLtype.SelectedIndex != 5 && bl.level >= 81 && bl.level < 91)
				{
					flag = false;
				}
				else if (BLtype.SelectedIndex != 6 && bl.level >= 91 && bl.level < 101)
				{
					flag = false;
				}
				else if (BLtype.SelectedIndex != 7 && bl.level >= 101 && bl.level < 111)
				{
					flag = false;
				}
			}
			if (BLEffect.SelectedIndex != 0)
			{
				if (BLEffect.SelectedIndex == 1 && !bl.release.name.Equals("Ninja Tools"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 2 && !bl.release.name.Equals("Taijutsu"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 3 && !bl.release.name.Equals("Healing"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 4 && !bl.release.name.Equals("Sealing Jutsu"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 5 && !bl.release.name.Equals("Illusion"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 6 && !bl.release.name.Equals("Water"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 7 && !bl.release.name.Equals("Wind"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 8 && !bl.release.name.Equals("Earth"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 9 && !bl.release.name.Equals("Fire"))
				{
					flag = false;
				}
				else if (BLEffect.SelectedIndex == 10 && !bl.release.name.Equals("Lightning"))
				{
					flag = false;
				}
			}
			if (BLValOne.SelectedIndex != 0)
			{
				if (BLValOne.SelectedIndex == 1 && !bl.values[0].GetType().Equals(typeof(Agility)) && !bl.values[1].GetType().Equals(typeof(Agility)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 2 && !bl.values[0].GetType().Equals(typeof(ArmorBreak)) && !bl.values[1].GetType().Equals(typeof(ArmorBreak)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 3 && !bl.values[0].GetType().Equals(typeof(Block)) && !bl.values[1].GetType().Equals(typeof(Block)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 4 && !bl.values[0].GetType().Equals(typeof(Constitution)) && !bl.values[1].GetType().Equals(typeof(Constitution)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 5 && !bl.values[0].GetType().Equals(typeof(Critical)) && !bl.values[1].GetType().Equals(typeof(Critical)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 6 && !bl.values[0].GetType().Equals(typeof(Defense)) && !bl.values[1].GetType().Equals(typeof(Defense)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 7 && !bl.values[0].GetType().Equals(typeof(Dodge)) && !bl.values[1].GetType().Equals(typeof(Dodge)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 8 && !bl.values[0].GetType().Equals(typeof(Hit)) && !bl.values[1].GetType().Equals(typeof(Hit)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 9 && !bl.values[0].GetType().Equals(typeof(HP)) && !bl.values[1].GetType().Equals(typeof(HP)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 10 && !bl.values[0].GetType().Equals(typeof(Pierce)) && !bl.values[1].GetType().Equals(typeof(Pierce)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 11 && !bl.values[0].GetType().Equals(typeof(Speed)) && !bl.values[1].GetType().Equals(typeof(Speed)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 12 && !bl.values[0].GetType().Equals(typeof(Stamina)) && !bl.values[1].GetType().Equals(typeof(Stamina)))
				{
					flag = false;
				}
				else if (BLValOne.SelectedIndex == 13 && !bl.values[0].GetType().Equals(typeof(Strength)) && !bl.values[1].GetType().Equals(typeof(Strength)))
				{
					flag = false;
				}
			}
			if (BLValTwo.SelectedIndex != 0)
			{
				if (BLValTwo.SelectedIndex == 1 && !bl.values[1].GetType().Equals(typeof(Agility)) && !bl.values[1].GetType().Equals(typeof(Agility)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 2 && !bl.values[0].GetType().Equals(typeof(ArmorBreak)) && !bl.values[1].GetType().Equals(typeof(ArmorBreak)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 3 && !bl.values[0].GetType().Equals(typeof(Block)) && !bl.values[1].GetType().Equals(typeof(Block)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 4 && !bl.values[0].GetType().Equals(typeof(Constitution)) && !bl.values[1].GetType().Equals(typeof(Constitution)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 5 && !bl.values[0].GetType().Equals(typeof(Critical)) && !bl.values[1].GetType().Equals(typeof(Critical)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 6 && !bl.values[0].GetType().Equals(typeof(Defense)) && !bl.values[1].GetType().Equals(typeof(Defense)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 7 && !bl.values[0].GetType().Equals(typeof(Dodge)) && !bl.values[1].GetType().Equals(typeof(Dodge)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 8 && !bl.values[0].GetType().Equals(typeof(Hit)) && !bl.values[1].GetType().Equals(typeof(Hit)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 9 && !bl.values[0].GetType().Equals(typeof(HP)) && !bl.values[1].GetType().Equals(typeof(HP)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 10 && !bl.values[0].GetType().Equals(typeof(Pierce)) && !bl.values[1].GetType().Equals(typeof(Pierce)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 11 && !bl.values[0].GetType().Equals(typeof(Speed)) && !bl.values[1].GetType().Equals(typeof(Speed)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 12 && !bl.values[0].GetType().Equals(typeof(Stamina)) && !bl.values[1].GetType().Equals(typeof(Stamina)))
				{
					flag = false;
				}
				else if (BLValTwo.SelectedIndex == 13 && !bl.values[0].GetType().Equals(typeof(Strength)) && !bl.values[1].GetType().Equals(typeof(Strength)))
				{
					flag = false;
				}
			}
			if (BLValTwo.SelectedIndex == BLValOne.SelectedIndex && BLValOne.SelectedIndex != 0 && flag && !bl.values[0].GetType().Equals(bl.values[1].GetType()))
			{
				flag = false;
			}
			return flag;
		}

		public void loadBLs(int clicked)
		{
			this.clicked = clicked;
			Bloodline[] bloodlines = DataLibrary.bloodlines;
			BLListControl.Clear();
			BLListControl.setSelection(null);
			for (int i = 0; i < bloodlines.Length; i++)
			{
				if (isFiltered(bloodlines[i]))
				{
					int num = 0;
					if ((clicked == 1 && form.ProfileManager.currentProfile.bloodline1 == bloodlines[i].id) || (clicked == 2 && form.ProfileManager.currentProfile.bloodline2 == bloodlines[i].id) || (clicked == 3 && form.ProfileManager.currentProfile.bloodline3 == bloodlines[i].id))
					{
						num = 1;
					}
					if ((clicked != 1 && form.ProfileManager.currentProfile.bloodline1 == bloodlines[i].id) || (clicked != 2 && form.ProfileManager.currentProfile.bloodline2 == bloodlines[i].id) || (clicked != 3 && form.ProfileManager.currentProfile.bloodline3 == bloodlines[i].id))
					{
						num = 2;
					}
					ListControlItem listControlItem = null;
					if (num == 1 || num == 0)
					{
						listControlItem = BLListControl.Add(bloodlines[i]);
					}
					if (num == 1)
					{
						listControlItem.setSelected();
					}
				}
			}
		}

		private void BloodlineForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void BLSave_Click(object sender, EventArgs e)
		{
			if (BLListControl.getSelection() != null)
			{
				int id = BLListControl.getSelection().Tag.id;
				if (clicked == 1)
				{
					form.ProfileManager.currentProfile.bloodline1 = id;
				}
				if (clicked == 2)
				{
					form.ProfileManager.currentProfile.bloodline2 = id;
				}
				if (clicked == 3)
				{
					form.ProfileManager.currentProfile.bloodline3 = id;
				}
				form.UpdateBuild();
				Hide();
			}
			else
			{
				MessageBox.Show("No bloodline selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void BLFilterReset_Click(object sender, EventArgs e)
		{
			resetFilter();
		}

		private void FilterShow_Click(object sender, EventArgs e)
		{
			loadBLs(clicked);
		}
	}
}
