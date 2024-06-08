using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder
{
	public class OutfitForm : Form
	{
		private IContainer components;

		private NumericUpDown OutfitUpDown;

		private ListView OutfitList;

		private ColumnHeader BMVStr;

		private ColumnHeader BMVAgi;

		private ColumnHeader BMVSta;

		private ColumnHeader Strength;

		private ColumnHeader Agility;

		private ColumnHeader Stamina;

		private Button OutfitSave;

		private TrackBar StrBar;

		private Label StrLabel;

		private Label AgiLabel;

		private Label StaLabel;

		private TrackBar AgiBar;

		private TrackBar StaBar;

		private GroupBox RecastingGroup;

		private GroupBox OutfitLevelGroup;

		private ColumnHeader OutfitName;

		private ColumnHeader StrMod;

		private ColumnHeader AgiMod;

		private ColumnHeader StaMod;

		private ColumnHeader OutfitType;

		private Label LevelReq;

		private PictureBox OutfitPicture;

		private GroupBox RecordBox;

		private Label RecordLabel;

		private Label RecordLevelBonus;

		private Label RecordBonus;

		private MainForm mainform;

		private ListViewColumnSorter lvwColumnSorter;

		private int[] rec = new int[DataLibrary.outfits.Length];

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.OutfitForm));
			this.OutfitUpDown = new System.Windows.Forms.NumericUpDown();
			this.OutfitList = new System.Windows.Forms.ListView();
			this.OutfitName = new System.Windows.Forms.ColumnHeader();
			this.OutfitType = new System.Windows.Forms.ColumnHeader();
			this.BMVStr = new System.Windows.Forms.ColumnHeader();
			this.BMVAgi = new System.Windows.Forms.ColumnHeader();
			this.BMVSta = new System.Windows.Forms.ColumnHeader();
			this.StrMod = new System.Windows.Forms.ColumnHeader();
			this.AgiMod = new System.Windows.Forms.ColumnHeader();
			this.StaMod = new System.Windows.Forms.ColumnHeader();
			this.Strength = new System.Windows.Forms.ColumnHeader();
			this.Agility = new System.Windows.Forms.ColumnHeader();
			this.Stamina = new System.Windows.Forms.ColumnHeader();
			this.OutfitSave = new System.Windows.Forms.Button();
			this.StrBar = new System.Windows.Forms.TrackBar();
			this.StrLabel = new System.Windows.Forms.Label();
			this.AgiLabel = new System.Windows.Forms.Label();
			this.StaLabel = new System.Windows.Forms.Label();
			this.AgiBar = new System.Windows.Forms.TrackBar();
			this.StaBar = new System.Windows.Forms.TrackBar();
			this.RecastingGroup = new System.Windows.Forms.GroupBox();
			this.OutfitLevelGroup = new System.Windows.Forms.GroupBox();
			this.LevelReq = new System.Windows.Forms.Label();
			this.OutfitPicture = new System.Windows.Forms.PictureBox();
			this.RecordBox = new System.Windows.Forms.GroupBox();
			this.RecordLabel = new System.Windows.Forms.Label();
			this.RecordBonus = new System.Windows.Forms.Label();
			this.RecordLevelBonus = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.OutfitUpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.StrBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.AgiBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.StaBar).BeginInit();
			this.RecastingGroup.SuspendLayout();
			this.OutfitLevelGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.OutfitPicture).BeginInit();
			this.RecordBox.SuspendLayout();
			base.SuspendLayout();
			this.OutfitUpDown.Location = new System.Drawing.Point(22, 19);
			this.OutfitUpDown.Maximum = new decimal(new int[4] { 37, 0, 0, 0 });
			this.OutfitUpDown.Name = "OutfitUpDown";
			this.OutfitUpDown.Size = new System.Drawing.Size(60, 20);
			this.OutfitUpDown.TabIndex = 0;
			this.OutfitUpDown.ValueChanged += new System.EventHandler(OutfitUpDown_ValueChanged);
			this.OutfitList.CheckBoxes = true;
			this.OutfitList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[11]
			{
				this.OutfitName, this.OutfitType, this.BMVStr, this.BMVAgi, this.BMVSta, this.StrMod, this.AgiMod, this.StaMod, this.Strength, this.Agility,
				this.Stamina
			});
			this.OutfitList.FullRowSelect = true;
			this.OutfitList.GridLines = true;
			this.OutfitList.HideSelection = false;
			this.OutfitList.Location = new System.Drawing.Point(12, 135);
			this.OutfitList.MultiSelect = false;
			this.OutfitList.Name = "OutfitList";
			this.OutfitList.Size = new System.Drawing.Size(701, 251);
			this.OutfitList.TabIndex = 1;
			this.OutfitList.UseCompatibleStateImageBehavior = false;
			this.OutfitList.View = System.Windows.Forms.View.Details;
			this.OutfitList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(OutfitList_ColumnClick);
			this.OutfitList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(OutfitList_ItemChecked);
			this.OutfitList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(OutfitList_ItemSelectionChanged);
			this.OutfitName.Text = "Rec / Character";
			this.OutfitName.Width = 120;
			this.OutfitType.Text = "Rank";
			this.OutfitType.Width = 65;
			this.BMVStr.Text = "BMV Strength";
			this.BMVStr.Width = 44;
			this.BMVAgi.Text = "BMV Agility";
			this.BMVAgi.Width = 44;
			this.BMVSta.Text = "BMV Stamina";
			this.BMVSta.Width = 44;
			this.StrMod.Text = "Strength Modifier";
			this.StrMod.Width = 65;
			this.AgiMod.Text = "Agility Modifier";
			this.AgiMod.Width = 65;
			this.StaMod.Text = "Stamina Modifier";
			this.StaMod.Width = 65;
			this.Strength.Text = "Strength";
			this.Strength.Width = 55;
			this.Agility.Text = "Agility";
			this.Agility.Width = 55;
			this.Stamina.Text = "Stamina";
			this.Stamina.Width = 55;
			this.OutfitSave.Location = new System.Drawing.Point(297, 392);
			this.OutfitSave.Name = "OutfitSave";
			this.OutfitSave.Size = new System.Drawing.Size(123, 27);
			this.OutfitSave.TabIndex = 3;
			this.OutfitSave.Text = "Save";
			this.OutfitSave.UseVisualStyleBackColor = true;
			this.OutfitSave.Click += new System.EventHandler(OutfitSave_Click);
			this.StrBar.Location = new System.Drawing.Point(60, 17);
			this.StrBar.Maximum = 30;
			this.StrBar.Name = "StrBar";
			this.StrBar.Size = new System.Drawing.Size(312, 45);
			this.StrBar.TabIndex = 5;
			this.StrBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.StrBar.ValueChanged += new System.EventHandler(StrBar_ValueChanged);
			this.StrLabel.AutoSize = true;
			this.StrLabel.Location = new System.Drawing.Point(6, 20);
			this.StrLabel.Name = "StrLabel";
			this.StrLabel.Size = new System.Drawing.Size(47, 13);
			this.StrLabel.TabIndex = 7;
			this.StrLabel.Text = "Strength";
			this.AgiLabel.AutoSize = true;
			this.AgiLabel.Location = new System.Drawing.Point(6, 45);
			this.AgiLabel.Name = "AgiLabel";
			this.AgiLabel.Size = new System.Drawing.Size(34, 13);
			this.AgiLabel.TabIndex = 8;
			this.AgiLabel.Text = "Agility";
			this.StaLabel.AutoSize = true;
			this.StaLabel.Location = new System.Drawing.Point(6, 70);
			this.StaLabel.Name = "StaLabel";
			this.StaLabel.Size = new System.Drawing.Size(45, 13);
			this.StaLabel.TabIndex = 9;
			this.StaLabel.Text = "Stamina";
			this.AgiBar.Location = new System.Drawing.Point(60, 42);
			this.AgiBar.Maximum = 30;
			this.AgiBar.Name = "AgiBar";
			this.AgiBar.Size = new System.Drawing.Size(312, 45);
			this.AgiBar.TabIndex = 10;
			this.AgiBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.AgiBar.ValueChanged += new System.EventHandler(AgiBar_ValueChanged);
			this.StaBar.Location = new System.Drawing.Point(60, 67);
			this.StaBar.Maximum = 30;
			this.StaBar.Name = "StaBar";
			this.StaBar.Size = new System.Drawing.Size(312, 45);
			this.StaBar.TabIndex = 11;
			this.StaBar.TickStyle = System.Windows.Forms.TickStyle.None;
			this.StaBar.ValueChanged += new System.EventHandler(StaBar_ValueChanged);
			this.RecastingGroup.Controls.Add(this.StrLabel);
			this.RecastingGroup.Controls.Add(this.StaBar);
			this.RecastingGroup.Controls.Add(this.AgiLabel);
			this.RecastingGroup.Controls.Add(this.AgiBar);
			this.RecastingGroup.Controls.Add(this.StaLabel);
			this.RecastingGroup.Controls.Add(this.StrBar);
			this.RecastingGroup.Location = new System.Drawing.Point(144, 12);
			this.RecastingGroup.Name = "RecastingGroup";
			this.RecastingGroup.Size = new System.Drawing.Size(378, 117);
			this.RecastingGroup.TabIndex = 12;
			this.RecastingGroup.TabStop = false;
			this.RecastingGroup.Text = "Recasting";
			this.OutfitLevelGroup.Controls.Add(this.LevelReq);
			this.OutfitLevelGroup.Controls.Add(this.OutfitUpDown);
			this.OutfitLevelGroup.Location = new System.Drawing.Point(17, 27);
			this.OutfitLevelGroup.Name = "OutfitLevelGroup";
			this.OutfitLevelGroup.Size = new System.Drawing.Size(105, 83);
			this.OutfitLevelGroup.TabIndex = 13;
			this.OutfitLevelGroup.TabStop = false;
			this.OutfitLevelGroup.Text = "Outfit-level";
			this.LevelReq.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.LevelReq.Location = new System.Drawing.Point(3, 56);
			this.LevelReq.Name = "LevelReq";
			this.LevelReq.Size = new System.Drawing.Size(99, 24);
			this.LevelReq.TabIndex = 1;
			this.LevelReq.Text = "Requires Lvl. 0";
			this.LevelReq.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.OutfitPicture.Location = new System.Drawing.Point(714, 53);
			this.OutfitPicture.Name = "OutfitPicture";
			this.OutfitPicture.Size = new System.Drawing.Size(232, 315);
			this.OutfitPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.OutfitPicture.TabIndex = 14;
			this.OutfitPicture.TabStop = false;
			this.RecordBox.Controls.Add(this.RecordLevelBonus);
			this.RecordBox.Controls.Add(this.RecordBonus);
			this.RecordBox.Controls.Add(this.RecordLabel);
			this.RecordBox.Location = new System.Drawing.Point(528, 12);
			this.RecordBox.Name = "RecordBox";
			this.RecordBox.Size = new System.Drawing.Size(180, 112);
			this.RecordBox.TabIndex = 15;
			this.RecordBox.TabStop = false;
			this.RecordBox.Text = "Recording";
			this.RecordLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.RecordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.RecordLabel.Location = new System.Drawing.Point(3, 16);
			this.RecordLabel.Name = "RecordLabel";
			this.RecordLabel.Size = new System.Drawing.Size(174, 38);
			this.RecordLabel.TabIndex = 0;
			this.RecordLabel.Text = "0 +2 recorded";
			this.RecordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RecordBonus.Dock = System.Windows.Forms.DockStyle.Left;
			this.RecordBonus.Location = new System.Drawing.Point(3, 54);
			this.RecordBonus.Name = "RecordBonus";
			this.RecordBonus.Size = new System.Drawing.Size(89, 55);
			this.RecordBonus.TabIndex = 1;
			this.RecordBonus.Text = "Strength: +0\r\nAgility: +0\r\nStamina: +0";
			this.RecordLevelBonus.Dock = System.Windows.Forms.DockStyle.Right;
			this.RecordLevelBonus.Location = new System.Drawing.Point(98, 54);
			this.RecordLevelBonus.Name = "RecordLevelBonus";
			this.RecordLevelBonus.Size = new System.Drawing.Size(79, 55);
			this.RecordLevelBonus.TabIndex = 2;
			this.RecordLevelBonus.Text = "Atk: 0%\r\nSpeed: 0%\r\nHP: 0%";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(950, 431);
			base.Controls.Add(this.RecordBox);
			base.Controls.Add(this.OutfitLevelGroup);
			base.Controls.Add(this.RecastingGroup);
			base.Controls.Add(this.OutfitSave);
			base.Controls.Add(this.OutfitList);
			base.Controls.Add(this.OutfitPicture);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "OutfitForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Outfits";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(OutfitForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)this.OutfitUpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.StrBar).EndInit();
			((System.ComponentModel.ISupportInitialize)this.AgiBar).EndInit();
			((System.ComponentModel.ISupportInitialize)this.StaBar).EndInit();
			this.RecastingGroup.ResumeLayout(false);
			this.RecastingGroup.PerformLayout();
			this.OutfitLevelGroup.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.OutfitPicture).EndInit();
			this.RecordBox.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		public OutfitForm()
		{
			InitializeComponent();
			lvwColumnSorter = new ListViewColumnSorter();
			OutfitList.ListViewItemSorter = lvwColumnSorter;
		}

		public void InitializeForm(MainForm main)
		{
			mainform = main;
			Outfit[] outfits = DataLibrary.outfits;
			foreach (Outfit outfit in outfits)
			{
				if (main.chinesemode || !outfit.chinese)
				{
					ListViewItem listViewItem = new ListViewItem(new string[11]
					{
						"+0 " + outfit.name,
						outfit.type,
						outfit.bmv_str.ToString(),
						outfit.bmv_agi.ToString(),
						outfit.bmv_sta.ToString(),
						outfit.str_mul_init.ToString(),
						outfit.agi_mul_init.ToString(),
						outfit.sta_mul_init.ToString(),
						getVal(0, outfit.str_init, outfit.str_mul_init).ToString(),
						getVal(0, outfit.agi_init, outfit.agi_mul_init).ToString(),
						getVal(0, outfit.sta_init, outfit.sta_mul_init).ToString()
					});
					listViewItem.UseItemStyleForSubItems = false;
					switch (outfit.type)
					{
					case "Grey":
						listViewItem.SubItems[0].ForeColor = Color.DarkGray;
						listViewItem.SubItems[0].Font = new Font(listViewItem.Font, FontStyle.Bold);
						break;
					case "Blue":
						listViewItem.SubItems[0].ForeColor = Color.DarkBlue;
						listViewItem.SubItems[0].Font = new Font(listViewItem.Font, FontStyle.Bold);
						break;
					default:
						listViewItem.SubItems[0].ForeColor = Color.DarkOrange;
						listViewItem.SubItems[0].Font = new Font(listViewItem.Font, FontStyle.Bold);
						break;
					}
					listViewItem.Tag = outfit;
					OutfitList.Items.Add(listViewItem);
				}
			}
		}

		private void StrBar_ValueChanged(object sender, EventArgs e)
		{
			double num = (double)StrBar.Value / 100.0;
			for (int i = 0; i < OutfitList.Items.Count; i++)
			{
				OutfitList.Items[i].SubItems[5].Text = (((Outfit)OutfitList.Items[i].Tag).str_mul_init + num).ToString();
				OutfitList.Items[i].SubItems[8].Text = getVal((int)OutfitUpDown.Value, ((Outfit)OutfitList.Items[i].Tag).str_init, ((Outfit)OutfitList.Items[i].Tag).str_mul_init + num).ToString();
			}
		}

		private void AgiBar_ValueChanged(object sender, EventArgs e)
		{
			double num = (double)AgiBar.Value / 100.0;
			for (int i = 0; i < OutfitList.Items.Count; i++)
			{
				OutfitList.Items[i].SubItems[6].Text = (((Outfit)OutfitList.Items[i].Tag).agi_mul_init + num).ToString();
				OutfitList.Items[i].SubItems[9].Text = getVal((int)OutfitUpDown.Value, ((Outfit)OutfitList.Items[i].Tag).agi_init, ((Outfit)OutfitList.Items[i].Tag).agi_mul_init + num).ToString();
			}
		}

		private void StaBar_ValueChanged(object sender, EventArgs e)
		{
			double num = (double)StaBar.Value / 100.0;
			for (int i = 0; i < OutfitList.Items.Count; i++)
			{
				OutfitList.Items[i].SubItems[7].Text = (((Outfit)OutfitList.Items[i].Tag).sta_mul_init + num).ToString();
				OutfitList.Items[i].SubItems[10].Text = getVal((int)OutfitUpDown.Value, ((Outfit)OutfitList.Items[i].Tag).sta_init, ((Outfit)OutfitList.Items[i].Tag).sta_mul_init + num).ToString();
			}
		}

		private void OutfitUpDown_ValueChanged(object sender, EventArgs e)
		{
			double num = (double)StrBar.Value / 100.0;
			double num2 = (double)AgiBar.Value / 100.0;
			double num3 = (double)StaBar.Value / 100.0;
			if (OutfitUpDown.Value == 0m)
			{
				LevelReq.Text = "Requires Lvl. 0";
			}
			else
			{
				LevelReq.Text = "Requires Lvl. " + (OutfitUpDown.Value - 1m) * 3m;
			}
			for (int i = 0; i < OutfitList.Items.Count; i++)
			{
				OutfitList.Items[i].SubItems[0].Text = "+" + OutfitUpDown.Value + " " + ((Outfit)OutfitList.Items[i].Tag).name;
				OutfitList.Items[i].SubItems[8].Text = getVal((int)OutfitUpDown.Value, ((Outfit)OutfitList.Items[i].Tag).str_init, ((Outfit)OutfitList.Items[i].Tag).str_mul_init + num).ToString();
				OutfitList.Items[i].SubItems[9].Text = getVal((int)OutfitUpDown.Value, ((Outfit)OutfitList.Items[i].Tag).agi_init, ((Outfit)OutfitList.Items[i].Tag).agi_mul_init + num2).ToString();
				OutfitList.Items[i].SubItems[10].Text = getVal((int)OutfitUpDown.Value, ((Outfit)OutfitList.Items[i].Tag).sta_init, ((Outfit)OutfitList.Items[i].Tag).sta_mul_init + num3).ToString();
			}
		}

		private int getVal(int level, int baseval, double recast)
		{
			return (int)((double)baseval + (double)(level * 8) * recast);
		}

		private void OutfitForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void OutfitSave_Click(object sender, EventArgs e)
		{
			if (OutfitList.SelectedItems.Count != 0)
			{
				mainform.ProfileManager.currentProfile.outfit = ((Outfit)OutfitList.SelectedItems[0].Tag).id;
				int[] array = new int[200];
				foreach (ListViewItem checkedItem in OutfitList.CheckedItems)
				{
					array[((Outfit)checkedItem.Tag).id] = 1;
				}
				mainform.ProfileManager.currentProfile.record = array;
				mainform.ProfileManager.currentProfile.outfitlevel = (int)OutfitUpDown.Value;
				mainform.ProfileManager.currentProfile.outfitstr = (double)StrBar.Value / 100.0;
				mainform.ProfileManager.currentProfile.outfitagi = (double)AgiBar.Value / 100.0;
				mainform.ProfileManager.currentProfile.outfitsta = (double)StaBar.Value / 100.0;
				mainform.UpdateBuild();
				Hide();
			}
			else
			{
				MessageBox.Show("No outfit selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void OutfitList_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == lvwColumnSorter.SortColumn)
			{
				if (lvwColumnSorter.Order == SortOrder.Ascending)
				{
					lvwColumnSorter.Order = SortOrder.Descending;
				}
				else
				{
					lvwColumnSorter.Order = SortOrder.Ascending;
				}
			}
			else
			{
				lvwColumnSorter.SortColumn = e.Column;
				lvwColumnSorter.Order = SortOrder.Ascending;
			}
			OutfitList.Sort();
		}

		private void OutfitList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (OutfitList.SelectedItems.Count > 0)
			{
				OutfitPicture.Image = ((Outfit)OutfitList.SelectedItems[0].Tag).pimage;
			}
			updateRecord();
		}

		private void OutfitList_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			Outfit outfit = (Outfit)e.Item.Tag;
			if (outfit != null)
			{
				if (e.Item.Checked)
				{
					rec[outfit.id] = 1;
				}
				else
				{
					rec[outfit.id] = 0;
				}
				updateRecord();
			}
		}

		private void updateRecord()
		{
			if (OutfitList.SelectedItems.Count <= 0)
			{
				return;
			}
			Outfit outfit = (Outfit)OutfitList.SelectedItems[0].Tag;
			int[] array = new int[2];
			switch (outfit.type)
			{
			case "Grey":
				array = new int[2] { 0, 18 };
				break;
			case "Blue":
				array = new int[2] { 18, 38 };
				break;
			default:
				array = new int[2]
				{
					38,
					DataLibrary.outfits.Length
				};
				break;
			}
			int[] array2 = new int[3];
			int num = 0;
			for (int i = array[0]; i < array[1]; i++)
			{
				if (rec[i] == 1)
				{
					num++;
					array2[0] += DataLibrary.outfits[i].record[0];
					array2[1] += DataLibrary.outfits[i].record[1];
					array2[2] += DataLibrary.outfits[i].record[2];
				}
			}
			RecordLabel.Text = num + " +2 recorded";
			RecordBonus.Text = "Strength:\t+" + array2[0] + "\nAgility:\t+" + array2[1] + "\nStamina:\t+" + array2[2];
			Values[] array3 = DataLibrary.records[(num / 5 > 12) ? 12 : (num / 5)];
			RecordLevelBonus.Text = "Atk:\t+" + (double)array3[0].value / 10.0 + "%\nSpeed:\t+" + (double)array3[1].value / 10.0 + "%\nHP:\t+" + (double)array3[2].value / 10.0 + "%";
		}

		internal void fillOutfit(int outfit, int level, double str, double agi, double sta, int[] record)
		{
			foreach (ListViewItem item in OutfitList.Items)
			{
				if (record[((Outfit)item.Tag).id] == 1)
				{
					OutfitList.Items[item.Index].Checked = true;
				}
				if (((Outfit)item.Tag).id == outfit)
				{
					OutfitList.Items[item.Index].Selected = true;
				}
			}
			OutfitUpDown.Value = level;
			StrBar.Value = (int)(str * 100.0);
			AgiBar.Value = (int)(agi * 100.0);
			StaBar.Value = (int)(sta * 100.0);
			OutfitUpDown_ValueChanged(OutfitUpDown, null);
			StrBar_ValueChanged(StrBar, null);
			AgiBar_ValueChanged(AgiBar, null);
			StaBar_ValueChanged(StaBar, null);
		}
	}
}
