using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class BloodsoulForm : Form
	{
		private MainForm form;

		private int clicked;

		private ListViewItem[] itembackup;

		private IContainer components;

		private ImageList ImageList;

		private ListView BloodsoulList;

		private ComboBox BSStage;

		private Label ValueLabel;

		private Label LevelLabel;

		private Button BSSaveButton;

		public BloodsoulForm(MainForm f)
		{
			InitializeComponent();
			form = f;
			itembackup = new ListViewItem[13];
			BloodsoulList.Items.CopyTo(itembackup, 0);
		}

		public void loadBS(int clicked)
		{
			this.clicked = clicked;
			BloodsoulList.Clear();
			int selectedIndex;
			int[] array;
			if (clicked / 10 == 1)
			{
				selectedIndex = form.ProfileManager.currentProfile.bloodsoullvl1[clicked % 10 - 1];
				array = form.ProfileManager.currentProfile.bloodsoul1;
			}
			else if (clicked / 10 == 2)
			{
				selectedIndex = form.ProfileManager.currentProfile.bloodsoullvl2[clicked % 10 - 1];
				array = form.ProfileManager.currentProfile.bloodsoul2;
			}
			else
			{
				selectedIndex = form.ProfileManager.currentProfile.bloodsoullvl3[clicked % 10 - 1];
				array = form.ProfileManager.currentProfile.bloodsoul3;
			}
			BSStage.SelectedIndex = selectedIndex;
			if (array[clicked % 10 - 1] != -1)
			{
				itembackup[array[clicked % 10 - 1]].Selected = true;
			}
			ListViewItem[] array2 = itembackup;
			foreach (ListViewItem listViewItem in array2)
			{
				bool flag = false;
				for (int j = 0; j < 5; j++)
				{
					if (clicked % 10 - 1 != j && array[j] == Convert.ToInt32(listViewItem.Tag))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					BloodsoulList.Items.Add(listViewItem);
				}
			}
			updateLabels();
		}

		private void selectionChanged(object sender, EventArgs e)
		{
			updateLabels();
		}

		private void updateLabels()
		{
			int selectedIndex = BSStage.SelectedIndex;
			int num = ((BloodsoulList.SelectedIndices.Count <= 0) ? (-1) : Convert.ToInt32(BloodsoulList.SelectedItems[0].Tag));
			Bloodline bloodline = ((form.ProfileManager.currentProfile.bloodline1 == -1) ? null : DataLibrary.bloodlines[form.ProfileManager.currentProfile.bloodline1]);
			int level = DataLibrary.bloodsouls[0][selectedIndex].level;
			int num2 = ((num != -1) ? DataLibrary.bloodsouls[num][selectedIndex].value.value : 0);
			if (num != 12)
			{
				ValueLabel.Text = "Gives: +" + num2;
			}
			else
			{
				ValueLabel.Text = "Gives: +" + (double)num2 / 10.0 + "%";
			}
			if (bloodline == null || level > bloodline.level)
			{
				LevelLabel.ForeColor = Color.Red;
			}
			else
			{
				LevelLabel.ForeColor = Color.Black;
			}
			if (bloodline == null)
			{
				LevelLabel.Text = "Requires: Lvl." + level + "\nNeed to select BL";
				return;
			}
			LevelLabel.Text = "Requires: Lvl." + level + "\nBloodline: Lvl." + bloodline.level;
		}

		private void BloodsoulForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void BSSaveButton_Click(object sender, EventArgs e)
		{
			if (BloodsoulList.SelectedItems.Count > 0)
			{
				if (clicked / 10 == 1)
				{
					form.ProfileManager.currentProfile.bloodsoul1[clicked % 10 - 1] = Convert.ToInt32(BloodsoulList.SelectedItems[0].Tag);
					form.ProfileManager.currentProfile.bloodsoullvl1[clicked % 10 - 1] = BSStage.SelectedIndex;
				}
				else if (clicked / 10 == 2)
				{
					form.ProfileManager.currentProfile.bloodsoul2[clicked % 10 - 1] = Convert.ToInt32(BloodsoulList.SelectedItems[0].Tag);
					form.ProfileManager.currentProfile.bloodsoullvl2[clicked % 10 - 1] = BSStage.SelectedIndex;
				}
				else
				{
					form.ProfileManager.currentProfile.bloodsoul3[clicked % 10 - 1] = Convert.ToInt32(BloodsoulList.SelectedItems[0].Tag);
					form.ProfileManager.currentProfile.bloodsoullvl3[clicked % 10 - 1] = BSStage.SelectedIndex;
				}
				form.UpdateBuild();
				Hide();
			}
			else
			{
				MessageBox.Show("No bloodsoul selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.BloodsoulForm));
			System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem("Armor Break", 0);
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Block", 1);
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Chakra", 2);
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Constitution", 3);
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Critical", 4);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Defense", 5);
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Dodge", 6);
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Hit", 7);
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("HP", 8);
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Max Atk", 9);
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Min Atk", 10);
			System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Pierce", 11);
			System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Speed", 12);
			this.ImageList = new System.Windows.Forms.ImageList(this.components);
			this.BloodsoulList = new System.Windows.Forms.ListView();
			this.BSStage = new System.Windows.Forms.ComboBox();
			this.ValueLabel = new System.Windows.Forms.Label();
			this.LevelLabel = new System.Windows.Forms.Label();
			this.BSSaveButton = new System.Windows.Forms.Button();
			base.SuspendLayout();
			this.ImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList.ImageStream");
			this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList.Images.SetKeyName(0, "BSArmorBreak.png");
			this.ImageList.Images.SetKeyName(1, "BSBlock.png");
			this.ImageList.Images.SetKeyName(2, "BSChakra.png");
			this.ImageList.Images.SetKeyName(3, "BSConstitution.png");
			this.ImageList.Images.SetKeyName(4, "BSCritical.png");
			this.ImageList.Images.SetKeyName(5, "BSDefense.png");
			this.ImageList.Images.SetKeyName(6, "BSDodge.png");
			this.ImageList.Images.SetKeyName(7, "BSHit.png");
			this.ImageList.Images.SetKeyName(8, "BSHP.png");
			this.ImageList.Images.SetKeyName(9, "BSMaxAtk.png");
			this.ImageList.Images.SetKeyName(10, "BSMinAtk.png");
			this.ImageList.Images.SetKeyName(11, "BSPierce.png");
			this.ImageList.Images.SetKeyName(12, "BSSpeed.png");
			this.BloodsoulList.BackColor = System.Drawing.SystemColors.Control;
			this.BloodsoulList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.BloodsoulList.HideSelection = false;
			listViewItem.Tag = "0";
			listViewItem2.Tag = "1";
			listViewItem3.Tag = "2";
			listViewItem4.Tag = "3";
			listViewItem5.Tag = "4";
			listViewItem6.Tag = "5";
			listViewItem7.Tag = "6";
			listViewItem8.Tag = "7";
			listViewItem9.Tag = "8";
			listViewItem10.Tag = "9";
			listViewItem11.Tag = "10";
			listViewItem12.Tag = "11";
			listViewItem13.Tag = "12";
			this.BloodsoulList.Items.AddRange(new System.Windows.Forms.ListViewItem[13]
			{
				listViewItem, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10,
				listViewItem11, listViewItem12, listViewItem13
			});
			this.BloodsoulList.LargeImageList = this.ImageList;
			this.BloodsoulList.Location = new System.Drawing.Point(12, 12);
			this.BloodsoulList.MultiSelect = false;
			this.BloodsoulList.Name = "BloodsoulList";
			this.BloodsoulList.Size = new System.Drawing.Size(412, 104);
			this.BloodsoulList.SmallImageList = this.ImageList;
			this.BloodsoulList.TabIndex = 0;
			this.BloodsoulList.UseCompatibleStateImageBehavior = false;
			this.BloodsoulList.View = System.Windows.Forms.View.SmallIcon;
			this.BloodsoulList.SelectedIndexChanged += new System.EventHandler(selectionChanged);
			this.BSStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BSStage.Items.AddRange(new object[10] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" });
			this.BSStage.Location = new System.Drawing.Point(183, 122);
			this.BSStage.Name = "BSStage";
			this.BSStage.Size = new System.Drawing.Size(65, 21);
			this.BSStage.TabIndex = 1;
			this.BSStage.SelectedIndexChanged += new System.EventHandler(selectionChanged);
			this.ValueLabel.AutoSize = true;
			this.ValueLabel.Location = new System.Drawing.Point(307, 130);
			this.ValueLabel.Name = "ValueLabel";
			this.ValueLabel.Size = new System.Drawing.Size(53, 13);
			this.ValueLabel.TabIndex = 2;
			this.ValueLabel.Text = "Gives: +X";
			this.LevelLabel.AutoSize = true;
			this.LevelLabel.Location = new System.Drawing.Point(62, 130);
			this.LevelLabel.Name = "LevelLabel";
			this.LevelLabel.Size = new System.Drawing.Size(63, 13);
			this.LevelLabel.TabIndex = 3;
			this.LevelLabel.Text = "Need: Lvl.X";
			this.BSSaveButton.Location = new System.Drawing.Point(172, 149);
			this.BSSaveButton.Name = "BSSaveButton";
			this.BSSaveButton.Size = new System.Drawing.Size(90, 23);
			this.BSSaveButton.TabIndex = 4;
			this.BSSaveButton.Text = "Save";
			this.BSSaveButton.UseVisualStyleBackColor = true;
			this.BSSaveButton.Click += new System.EventHandler(BSSaveButton_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(436, 182);
			base.Controls.Add(this.BSSaveButton);
			base.Controls.Add(this.LevelLabel);
			base.Controls.Add(this.ValueLabel);
			base.Controls.Add(this.BSStage);
			base.Controls.Add(this.BloodsoulList);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "BloodsoulForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bloodsouls";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(BloodsoulForm_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
