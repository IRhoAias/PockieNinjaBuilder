using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder
{
	public class EquipForm : Form
	{
		private IContainer components;

		private GroupBox groupBox1;

		private ComboBox EqName;

		private ComboBox EqLevel;

		private GroupBox groupBox2;

		private NumericUpDown EqVal4Num;

		private NumericUpDown EqVal3Num;

		private NumericUpDown EqVal2Num;

		private NumericUpDown EqVal1Num;

		private ComboBox EqVal4;

		private ComboBox EqVal3;

		private ComboBox EqVal2;

		private ComboBox EqVal1;

		private GroupBox groupBox3;

		private Label label3;

		private NumericUpDown EqEnhan;

		private Label label2;

		private NumericUpDown EqInscrip;

		private Label label1;

		private GroupBox groupBox4;

		private ComboBox EqGem3;

		private ComboBox EqGem2;

		private ComboBox EqGem1;

		private ListBox EqEnchant;

		private Button EqSave;

		private Label BonusLabel;

		private GroupBox SetGroup;

		private Label SetTitle;

		private Label SetBonus;

		private ComboBox ForgeGem;

		private ComboBox ForgeVal;

		private int type;

		private int[] range = new int[2];

		private int level;

		private MainForm main;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.EquipForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.ForgeGem = new System.Windows.Forms.ComboBox();
			this.ForgeVal = new System.Windows.Forms.ComboBox();
			this.BonusLabel = new System.Windows.Forms.Label();
			this.EqName = new System.Windows.Forms.ComboBox();
			this.EqLevel = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.EqVal4Num = new System.Windows.Forms.NumericUpDown();
			this.EqVal3Num = new System.Windows.Forms.NumericUpDown();
			this.EqVal2Num = new System.Windows.Forms.NumericUpDown();
			this.EqVal1Num = new System.Windows.Forms.NumericUpDown();
			this.EqVal4 = new System.Windows.Forms.ComboBox();
			this.EqVal3 = new System.Windows.Forms.ComboBox();
			this.EqVal2 = new System.Windows.Forms.ComboBox();
			this.EqVal1 = new System.Windows.Forms.ComboBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.EqEnchant = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EqEnhan = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.EqInscrip = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.EqGem3 = new System.Windows.Forms.ComboBox();
			this.EqGem2 = new System.Windows.Forms.ComboBox();
			this.EqGem1 = new System.Windows.Forms.ComboBox();
			this.EqSave = new System.Windows.Forms.Button();
			this.SetGroup = new System.Windows.Forms.GroupBox();
			this.SetTitle = new System.Windows.Forms.Label();
			this.SetBonus = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.EqVal4Num).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.EqVal3Num).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.EqVal2Num).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.EqVal1Num).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.EqEnhan).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.EqInscrip).BeginInit();
			this.groupBox4.SuspendLayout();
			this.SetGroup.SuspendLayout();
			base.SuspendLayout();
			this.groupBox1.Controls.Add(this.ForgeGem);
			this.groupBox1.Controls.Add(this.ForgeVal);
			this.groupBox1.Controls.Add(this.BonusLabel);
			this.groupBox1.Controls.Add(this.EqName);
			this.groupBox1.Controls.Add(this.EqLevel);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 122);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item";
			this.ForgeGem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.ForgeGem.DropDownHeight = 300;
			this.ForgeGem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ForgeGem.FormattingEnabled = true;
			this.ForgeGem.IntegralHeight = false;
			this.ForgeGem.ItemHeight = 15;
			this.ForgeGem.Location = new System.Drawing.Point(33, 95);
			this.ForgeGem.Name = "ForgeGem";
			this.ForgeGem.Size = new System.Drawing.Size(160, 21);
			this.ForgeGem.TabIndex = 4;
			this.ForgeGem.Visible = false;
			this.ForgeGem.DrawItem += new System.Windows.Forms.DrawItemEventHandler(EqGem_DrawItem);
			this.ForgeGem.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(ForgeGem_MeasureItem);
			this.ForgeVal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ForgeVal.FormattingEnabled = true;
			this.ForgeVal.Location = new System.Drawing.Point(33, 70);
			this.ForgeVal.Name = "ForgeVal";
			this.ForgeVal.Size = new System.Drawing.Size(160, 21);
			this.ForgeVal.TabIndex = 3;
			this.ForgeVal.Visible = false;
			this.BonusLabel.AutoSize = true;
			this.BonusLabel.Location = new System.Drawing.Point(6, 70);
			this.BonusLabel.Name = "BonusLabel";
			this.BonusLabel.Size = new System.Drawing.Size(0, 13);
			this.BonusLabel.TabIndex = 2;
			this.EqName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.EqName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqName.Enabled = false;
			this.EqName.FormattingEnabled = true;
			this.EqName.Location = new System.Drawing.Point(7, 46);
			this.EqName.Name = "EqName";
			this.EqName.Size = new System.Drawing.Size(187, 21);
			this.EqName.TabIndex = 1;
			this.EqName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(EqName_DrawItem);
			this.EqName.SelectedIndexChanged += new System.EventHandler(EqName_SelectedIndexChanged);
			this.EqLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqLevel.FormattingEnabled = true;
			this.EqLevel.Items.AddRange(new object[11]
			{
				"1-10", "11-20", "21-30", "31-40", "41-50", "51-60", "61-70", "71-80", "81-90", "91-100",
				"101-110"
			});
			this.EqLevel.Location = new System.Drawing.Point(7, 19);
			this.EqLevel.Name = "EqLevel";
			this.EqLevel.Size = new System.Drawing.Size(79, 21);
			this.EqLevel.TabIndex = 0;
			this.EqLevel.SelectedValueChanged += new System.EventHandler(EqLevel_SelectedValueChanged);
			this.groupBox2.Controls.Add(this.EqVal4Num);
			this.groupBox2.Controls.Add(this.EqVal3Num);
			this.groupBox2.Controls.Add(this.EqVal2Num);
			this.groupBox2.Controls.Add(this.EqVal1Num);
			this.groupBox2.Controls.Add(this.EqVal4);
			this.groupBox2.Controls.Add(this.EqVal3);
			this.groupBox2.Controls.Add(this.EqVal2);
			this.groupBox2.Controls.Add(this.EqVal1);
			this.groupBox2.Location = new System.Drawing.Point(12, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 130);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Values";
			this.EqVal4Num.Enabled = false;
			this.EqVal4Num.Location = new System.Drawing.Point(134, 102);
			System.Windows.Forms.NumericUpDown eqVal4Num = this.EqVal4Num;
			int[] bits = new int[4];
			eqVal4Num.Maximum = new decimal(bits);
			this.EqVal4Num.Name = "EqVal4Num";
			this.EqVal4Num.Size = new System.Drawing.Size(60, 20);
			this.EqVal4Num.TabIndex = 9;
			this.EqVal3Num.Enabled = false;
			this.EqVal3Num.Location = new System.Drawing.Point(134, 75);
			System.Windows.Forms.NumericUpDown eqVal3Num = this.EqVal3Num;
			int[] bits2 = new int[4];
			eqVal3Num.Maximum = new decimal(bits2);
			this.EqVal3Num.Name = "EqVal3Num";
			this.EqVal3Num.Size = new System.Drawing.Size(60, 20);
			this.EqVal3Num.TabIndex = 8;
			this.EqVal2Num.Enabled = false;
			this.EqVal2Num.Location = new System.Drawing.Point(134, 48);
			System.Windows.Forms.NumericUpDown eqVal2Num = this.EqVal2Num;
			int[] bits3 = new int[4];
			eqVal2Num.Maximum = new decimal(bits3);
			this.EqVal2Num.Name = "EqVal2Num";
			this.EqVal2Num.Size = new System.Drawing.Size(60, 20);
			this.EqVal2Num.TabIndex = 7;
			this.EqVal1Num.Enabled = false;
			this.EqVal1Num.Location = new System.Drawing.Point(134, 21);
			System.Windows.Forms.NumericUpDown eqVal1Num = this.EqVal1Num;
			int[] bits4 = new int[4];
			eqVal1Num.Maximum = new decimal(bits4);
			this.EqVal1Num.Name = "EqVal1Num";
			this.EqVal1Num.Size = new System.Drawing.Size(60, 20);
			this.EqVal1Num.TabIndex = 6;
			this.EqVal4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqVal4.Enabled = false;
			this.EqVal4.FormattingEnabled = true;
			this.EqVal4.Location = new System.Drawing.Point(7, 101);
			this.EqVal4.Name = "EqVal4";
			this.EqVal4.Size = new System.Drawing.Size(121, 21);
			this.EqVal4.TabIndex = 5;
			this.EqVal4.SelectedIndexChanged += new System.EventHandler(EqVal4_SelectedIndexChanged);
			this.EqVal3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqVal3.Enabled = false;
			this.EqVal3.FormattingEnabled = true;
			this.EqVal3.Location = new System.Drawing.Point(7, 74);
			this.EqVal3.Name = "EqVal3";
			this.EqVal3.Size = new System.Drawing.Size(121, 21);
			this.EqVal3.TabIndex = 4;
			this.EqVal3.SelectedIndexChanged += new System.EventHandler(EqVal3_SelectedIndexChanged);
			this.EqVal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqVal2.Enabled = false;
			this.EqVal2.FormattingEnabled = true;
			this.EqVal2.Location = new System.Drawing.Point(7, 47);
			this.EqVal2.Name = "EqVal2";
			this.EqVal2.Size = new System.Drawing.Size(121, 21);
			this.EqVal2.TabIndex = 2;
			this.EqVal2.SelectedIndexChanged += new System.EventHandler(EqVal2_SelectedIndexChanged);
			this.EqVal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqVal1.Enabled = false;
			this.EqVal1.FormattingEnabled = true;
			this.EqVal1.Location = new System.Drawing.Point(7, 20);
			this.EqVal1.Name = "EqVal1";
			this.EqVal1.Size = new System.Drawing.Size(121, 21);
			this.EqVal1.TabIndex = 0;
			this.EqVal1.SelectedIndexChanged += new System.EventHandler(EqVal1_SelectedIndexChanged);
			this.groupBox3.Controls.Add(this.EqEnchant);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.EqEnhan);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.EqInscrip);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Location = new System.Drawing.Point(218, 108);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 306);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Modifications";
			this.EqEnchant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.EqEnchant.FormattingEnabled = true;
			this.EqEnchant.ItemHeight = 36;
			this.EqEnchant.Location = new System.Drawing.Point(7, 92);
			this.EqEnchant.Name = "EqEnchant";
			this.EqEnchant.Size = new System.Drawing.Size(187, 184);
			this.EqEnchant.TabIndex = 5;
			this.EqEnchant.DrawItem += new System.Windows.Forms.DrawItemEventHandler(EqEnchant_DrawItem);
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Enchantment:";
			this.EqEnhan.Enabled = false;
			this.EqEnhan.Location = new System.Drawing.Point(71, 44);
			this.EqEnhan.Maximum = new decimal(new int[4] { 16, 0, 0, 0 });
			this.EqEnhan.Name = "EqEnhan";
			this.EqEnhan.Size = new System.Drawing.Size(53, 20);
			this.EqEnhan.TabIndex = 3;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Enhance:";
			this.EqInscrip.Enabled = false;
			this.EqInscrip.Location = new System.Drawing.Point(71, 18);
			this.EqInscrip.Maximum = new decimal(new int[4] { 16, 0, 0, 0 });
			this.EqInscrip.Name = "EqInscrip";
			this.EqInscrip.Size = new System.Drawing.Size(53, 20);
			this.EqInscrip.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inscription:";
			this.groupBox4.Controls.Add(this.EqGem3);
			this.groupBox4.Controls.Add(this.EqGem2);
			this.groupBox4.Controls.Add(this.EqGem1);
			this.groupBox4.Location = new System.Drawing.Point(12, 276);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(200, 138);
			this.groupBox4.TabIndex = 6;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Gems";
			this.EqGem3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.EqGem3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqGem3.Enabled = false;
			this.EqGem3.FormattingEnabled = true;
			this.EqGem3.ItemHeight = 27;
			this.EqGem3.Location = new System.Drawing.Point(6, 98);
			this.EqGem3.Name = "EqGem3";
			this.EqGem3.Size = new System.Drawing.Size(187, 33);
			this.EqGem3.TabIndex = 2;
			this.EqGem3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(EqGem_DrawItem);
			this.EqGem2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.EqGem2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqGem2.Enabled = false;
			this.EqGem2.FormattingEnabled = true;
			this.EqGem2.ItemHeight = 27;
			this.EqGem2.Location = new System.Drawing.Point(7, 59);
			this.EqGem2.Name = "EqGem2";
			this.EqGem2.Size = new System.Drawing.Size(187, 33);
			this.EqGem2.TabIndex = 1;
			this.EqGem2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(EqGem_DrawItem);
			this.EqGem1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.EqGem1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.EqGem1.Enabled = false;
			this.EqGem1.FormattingEnabled = true;
			this.EqGem1.ItemHeight = 27;
			this.EqGem1.Location = new System.Drawing.Point(7, 20);
			this.EqGem1.Name = "EqGem1";
			this.EqGem1.Size = new System.Drawing.Size(187, 33);
			this.EqGem1.TabIndex = 0;
			this.EqGem1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(EqGem_DrawItem);
			this.EqSave.Location = new System.Drawing.Point(165, 420);
			this.EqSave.Name = "EqSave";
			this.EqSave.Size = new System.Drawing.Size(96, 25);
			this.EqSave.TabIndex = 7;
			this.EqSave.Text = "Save";
			this.EqSave.UseVisualStyleBackColor = true;
			this.EqSave.Click += new System.EventHandler(EqSave_Click);
			this.SetGroup.Controls.Add(this.SetTitle);
			this.SetGroup.Controls.Add(this.SetBonus);
			this.SetGroup.Location = new System.Drawing.Point(218, 12);
			this.SetGroup.Name = "SetGroup";
			this.SetGroup.Size = new System.Drawing.Size(200, 90);
			this.SetGroup.TabIndex = 8;
			this.SetGroup.TabStop = false;
			this.SetGroup.Text = "Setbonus";
			this.SetGroup.Visible = false;
			this.SetTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.SetTitle.ForeColor = System.Drawing.Color.Green;
			this.SetTitle.Location = new System.Drawing.Point(7, 15);
			this.SetTitle.Name = "SetTitle";
			this.SetTitle.Size = new System.Drawing.Size(187, 16);
			this.SetTitle.TabIndex = 1;
			this.SetTitle.Text = "- Set";
			this.SetTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.SetBonus.AutoSize = true;
			this.SetBonus.Location = new System.Drawing.Point(23, 32);
			this.SetBonus.Name = "SetBonus";
			this.SetBonus.Size = new System.Drawing.Size(46, 52);
			this.SetBonus.TabIndex = 0;
			this.SetBonus.Text = "1 Parts: \r\n2 Parts:\r\n3 Parts:\r\n4 Parts:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(427, 452);
			base.Controls.Add(this.SetGroup);
			base.Controls.Add(this.EqSave);
			base.Controls.Add(this.groupBox4);
			base.Controls.Add(this.groupBox3);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "EquipForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Equipment";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(EquipForm_FormClosing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.EqVal4Num).EndInit();
			((System.ComponentModel.ISupportInitialize)this.EqVal3Num).EndInit();
			((System.ComponentModel.ISupportInitialize)this.EqVal2Num).EndInit();
			((System.ComponentModel.ISupportInitialize)this.EqVal1Num).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.EqEnhan).EndInit();
			((System.ComponentModel.ISupportInitialize)this.EqInscrip).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.SetGroup.ResumeLayout(false);
			this.SetGroup.PerformLayout();
			base.ResumeLayout(false);
		}

		public EquipForm(MainForm main, int type)
		{
			this.main = main;
			this.type = type;
			InitializeComponent();
			if (type == 2 || type == 3)
			{
				label1.Visible = false;
				label2.Visible = false;
				EqInscrip.Visible = false;
				EqEnhan.Visible = false;
			}
			loadValues();
		}

		private void EqLevel_SelectedValueChanged(object sender, EventArgs e)
		{
			switch (EqLevel.SelectedIndex)
			{
			case 0:
				range[0] = 1;
				range[1] = 10;
				break;
			case 1:
				range[0] = 11;
				range[1] = 20;
				break;
			case 2:
				range[0] = 21;
				range[1] = 30;
				break;
			case 3:
				range[0] = 31;
				range[1] = 40;
				break;
			case 4:
				range[0] = 41;
				range[1] = 50;
				break;
			case 5:
				range[0] = 51;
				range[1] = 60;
				break;
			case 6:
				range[0] = 61;
				range[1] = 70;
				break;
			case 7:
				range[0] = 71;
				range[1] = 80;
				break;
			case 8:
				range[0] = 81;
				range[1] = 90;
				break;
			case 9:
				range[0] = 91;
				range[1] = 100;
				break;
			case 10:
				range[0] = 101;
				range[1] = 110;
				break;
			}
			EqInscrip.Enabled = true;
			EqEnhan.Enabled = true;
			EqVal1.Enabled = true;
			EqVal2.Enabled = true;
			EqVal3.Enabled = true;
			EqVal4.Enabled = true;
			EqVal1Num.Enabled = true;
			EqVal2Num.Enabled = true;
			EqVal3Num.Enabled = true;
			EqVal4Num.Enabled = true;
			loadItems();
			EqName.SelectedIndex = 0;
			loadGems();
			loadEnchantment();
		}

		private void loadItems()
		{
			EqName.Enabled = true;
			EqName.Items.Clear();
			Equipment[] equipment = DataLibrary.equipment;
			foreach (Equipment equipment2 in equipment)
			{
				if (equipment2.level >= range[0] && equipment2.level <= range[1] && equipment2.type == type)
				{
					EqName.Items.Add(equipment2);
				}
			}
		}

		private void loadEnchantment()
		{
			EqEnchant.Items.Clear();
			Enchantment[] enchantments = DataLibrary.enchantments;
			foreach (Enchantment enchantment in enchantments)
			{
				if (enchantment.level <= range[1] && enchantment.position[type].Equals('1'))
				{
					EqEnchant.Items.Add(enchantment);
				}
			}
		}

		private void loadGems()
		{
			EqGem1.Enabled = true;
			EqGem2.Enabled = true;
			EqGem3.Enabled = true;
			EqGem1.Items.Clear();
			EqGem2.Items.Clear();
			EqGem3.Items.Clear();
			Gem[] gems = DataLibrary.gems;
			foreach (Gem gem in gems)
			{
				if (gem.level <= range[1])
				{
					EqGem1.Items.Add(gem);
					EqGem2.Items.Add(gem);
					EqGem3.Items.Add(gem);
				}
			}
		}

		private void loadValues()
		{
			string[] array = new string[27]
			{
				"Strength", "Agility", "Stamina", "Attack+%", "Min Attack", "Max Attack", "Armor Break", "Hit", "Speed", "Dodge",
				"Max HP", "HP+%", "Max Chakra", "Chakra+%", "Critical Strike", "Constitution", "Block", "Pierce", "Defense", "Block Enhance",
				"Pierce Enhance", "Constitution Enhance", "Critical Enhance", "Dodge Enhance", "Hit Enhance", "Defense Enhance", "Armor Break Enhance"
			};
			for (int i = 0; i < 19; i++)
			{
				EqVal1.Items.Add(array[i]);
				EqVal2.Items.Add(array[i]);
				EqVal3.Items.Add(array[i]);
				EqVal4.Items.Add(array[i]);
			}
			if (type == 0)
			{
				for (int j = 19; j < 27; j++)
				{
					EqVal4.Items.Add(array[j]);
				}
			}
			for (int k = 0; k < 78; k++)
			{
				if (DataLibrary.gems[k].level < 110)
				{
					ForgeGem.Items.Add(DataLibrary.gems[k]);
				}
			}
		}

		private void updateStatValues(int sender)
		{
			level = ((((Equipment)EqName.SelectedItem).vlevel != 0) ? ((Equipment)EqName.SelectedItem).vlevel : ((Equipment)EqName.SelectedItem).level);
			int num = (level - 1) / 5;
			if (sender == 0)
			{
				if (EqVal1.SelectedIndex >= 0)
				{
					EqVal1Num.Maximum = DataLibrary.maxValMatrix[EqVal1.SelectedIndex][num];
					EqVal1Num.Minimum = (int)((double)DataLibrary.maxValMatrix[EqVal1.SelectedIndex][num] * 0.75);
				}
				if (EqVal2.SelectedIndex >= 0)
				{
					EqVal2Num.Maximum = DataLibrary.maxValMatrix[EqVal2.SelectedIndex][num];
					EqVal2Num.Minimum = (int)((double)DataLibrary.maxValMatrix[EqVal2.SelectedIndex][num] * 0.75);
				}
				if (EqVal3.SelectedIndex >= 0)
				{
					EqVal3Num.Maximum = DataLibrary.maxValMatrix[EqVal3.SelectedIndex][num];
					EqVal3Num.Minimum = (int)((double)DataLibrary.maxValMatrix[EqVal3.SelectedIndex][num] * 0.75);
				}
				if (EqVal4.SelectedIndex >= 0)
				{
					double num2 = ((EqVal4.SelectedIndex >= 19) ? 1.0 : 1.3);
					EqVal4Num.Maximum = (int)((double)DataLibrary.maxValMatrix[EqVal4.SelectedIndex][num] * num2);
					EqVal4Num.Minimum = (int)((double)DataLibrary.maxValMatrix[EqVal4.SelectedIndex][num] * num2 * 0.75);
				}
				ForgeVal.Items.Clear();
				string[] array = new string[5] { "GF", "HRF", "MBF", "CSF", "SSF" };
				if (type == 0 && ((Equipment)EqName.SelectedItem).forge > 0)
				{
					int num3 = 0;
					int[][] array2 = DataLibrary.forgeatk[(level - 30) / 10];
					foreach (int[] array3 in array2)
					{
						ForgeVal.Items.Add(array[num3] + ": Min Atk: +" + array3[0] + "/Max Atk: +" + array3[1]);
						num3++;
					}
				}
				else if (type != 2 && ((Equipment)EqName.SelectedItem).forge > 0)
				{
					int num4 = 0;
					int[] array4 = DataLibrary.forgedef[type][(level - 30) / 10];
					foreach (int num5 in array4)
					{
						ForgeVal.Items.Add(array[num4] + ": Defense: +" + num5);
						num4++;
					}
				}
				if (((Equipment)EqName.SelectedItem).forge > 0 && type != 2 && type != 3)
				{
					ForgeVal.Visible = true;
				}
				else
				{
					ForgeVal.Visible = false;
				}
				if (((Equipment)EqName.SelectedItem).forge > 1)
				{
					ForgeGem.Visible = true;
				}
				else
				{
					ForgeGem.Visible = false;
				}
				Set set = DataLibrary.sets[((Equipment)EqName.SelectedItem).set];
				if (set.id > 0)
				{
					SetTitle.Text = set.name + " Set";
					SetBonus.Text = "";
					for (int k = 0; k < 8; k++)
					{
						if (set.bonus[k] != null)
						{
							Label setBonus = SetBonus;
							object obj = setBonus.Text;
							setBonus.Text = string.Concat(obj, k + 1, " Parts:            ", set.bonus[k].ToString(), "\n");
						}
					}
					SetGroup.Visible = true;
				}
				else
				{
					SetGroup.Visible = false;
				}
				if (((Equipment)EqName.SelectedItem).bonus != null)
				{
					string text = "Bonus: \t";
					Values[] bonus = ((Equipment)EqName.SelectedItem).bonus;
					foreach (Values values in bonus)
					{
						text = text + values.ToString() + "\n\t\t";
					}
					BonusLabel.Text = text;
				}
				else
				{
					BonusLabel.Text = "";
				}
			}
			if (EqVal1.SelectedIndex >= 0 && sender == 1)
			{
				int selectedIndex = EqVal1.SelectedIndex;
				EqVal1Num.Maximum = DataLibrary.maxValMatrix[selectedIndex][num];
				EqVal1Num.Minimum = (int)((double)DataLibrary.maxValMatrix[selectedIndex][num] * 0.75);
				EqVal1Num.Value = (int)((double)DataLibrary.maxValMatrix[selectedIndex][num] * 0.88);
			}
			if (EqVal2.SelectedIndex >= 0 && sender == 2)
			{
				int selectedIndex2 = EqVal2.SelectedIndex;
				EqVal2Num.Maximum = DataLibrary.maxValMatrix[selectedIndex2][num];
				EqVal2Num.Minimum = (int)((double)DataLibrary.maxValMatrix[selectedIndex2][num] * 0.75);
				EqVal2Num.Value = (int)((double)DataLibrary.maxValMatrix[selectedIndex2][num] * 0.88);
			}
			if (EqVal3.SelectedIndex >= 0 && sender == 3)
			{
				int selectedIndex3 = EqVal3.SelectedIndex;
				EqVal3Num.Maximum = DataLibrary.maxValMatrix[selectedIndex3][num];
				EqVal3Num.Minimum = (int)((double)DataLibrary.maxValMatrix[selectedIndex3][num] * 0.75);
				EqVal3Num.Value = (int)((double)DataLibrary.maxValMatrix[selectedIndex3][num] * 0.88);
			}
			if (EqVal4.SelectedIndex >= 0 && sender == 4)
			{
				int selectedIndex4 = EqVal4.SelectedIndex;
				double num6 = ((selectedIndex4 >= 19) ? 1.0 : 1.3);
				EqVal4Num.Maximum = (int)((double)DataLibrary.maxValMatrix[selectedIndex4][num] * num6);
				EqVal4Num.Minimum = (int)((double)DataLibrary.maxValMatrix[selectedIndex4][num] * num6 * 0.75);
				EqVal4Num.Value = (int)((double)DataLibrary.maxValMatrix[selectedIndex4][num] * num6 * 0.88);
			}
		}

		private void EqVal1_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateStatValues(1);
		}

		private void EqVal2_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateStatValues(2);
		}

		private void EqVal3_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateStatValues(3);
		}

		private void EqVal4_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateStatValues(4);
		}

		private void EqName_SelectedIndexChanged(object sender, EventArgs e)
		{
			updateStatValues(0);
		}

		private void EqGem_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index >= 0)
			{
				Rectangle rectangle = bounds;
				rectangle.Width = rectangle.Left + 2;
				Rectangle rectangle2 = bounds;
				rectangle2.X = rectangle.Right;
				rectangle2.Width = bounds.Width - rectangle.Width - 30;
				rectangle2.Height = 13;
				Rectangle rectangle3 = bounds;
				rectangle3.X = rectangle2.Right;
				rectangle3.Width = bounds.Width - rectangle2.Right;
				rectangle3.Height = rectangle2.Height;
				Rectangle rectangle4 = bounds;
				rectangle4.X = rectangle.Right;
				rectangle4.Y = rectangle2.Bottom;
				Gem gem = (Gem)((ComboBox)sender).Items[e.Index];
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
				e.Graphics.DrawString(gem.name, font, brush, rectangle2, format);
				e.Graphics.DrawString("L." + gem.level, font2, brush2, rectangle3, stringFormat2);
				string text = "";
				text += gem.values[0].ToString();
				if (gem.values.Length > 1)
				{
					text = text + " / " + gem.values[1].ToString();
				}
				e.Graphics.DrawString(text, font2, brush2, rectangle4, stringFormat);
				e.DrawFocusRectangle();
			}
		}

		private void EqName_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index >= 0)
			{
				Rectangle rectangle = bounds;
				Rectangle rectangle2 = bounds;
				rectangle2.X = rectangle.Right - 50;
				rectangle2.Width = bounds.Width - rectangle2.X;
				Equipment equipment = (Equipment)EqName.Items[e.Index];
				StringFormat format = new StringFormat();
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Far;
				Font font = e.Font;
				Font font2 = new Font(e.Font.FontFamily, (float)((double)e.Font.Size * 0.8), FontStyle.Regular);
				Brush brush = new SolidBrush(e.ForeColor);
				Brush brush2 = new SolidBrush(Color.Black);
				string s = "";
				if (equipment.forge >= 1 && equipment.set <= 0)
				{
					brush2 = new SolidBrush(Color.Green);
					s = "FORGE";
				}
				else if (equipment.set > 0 && equipment.set <= 14)
				{
					brush2 = new SolidBrush(Color.DarkRed);
					s = "ARENA";
				}
				else if (equipment.set > 14 && equipment.set <= 26)
				{
					brush2 = new SolidBrush(Color.Brown);
					s = "TRIAL";
				}
				else if (equipment.set > 26 && equipment.set <= 31)
				{
					brush2 = new SolidBrush(Color.Blue);
					s = "KAGE";
				}
				else if (equipment.set > 31 && equipment.set <= 57)
				{
					brush2 = new SolidBrush(Color.DarkOrange);
					s = "TB";
				}
				else if (equipment.set > 57 && equipment.set <= 110)
				{
					brush2 = new SolidBrush(Color.Purple);
					s = "SPECIAL";
				}
				else if (equipment.set > 110 && equipment.set <= 116)
				{
					brush2 = new SolidBrush(Color.DarkGreen);
					s = "DEVIL F.";
				}
				e.Graphics.FillRectangle(new SolidBrush(e.BackColor), bounds);
				if (equipment.set != 0 || equipment.forge != 0)
				{
					e.Graphics.DrawString(s, font2, brush2, rectangle2, stringFormat);
				}
				e.Graphics.DrawString(equipment.name, font, brush, rectangle, format);
				e.DrawFocusRectangle();
			}
		}

		private void EqEnchant_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index >= 0)
			{
				Rectangle rectangle = bounds;
				rectangle.Width = 0;
				Rectangle rectangle2 = bounds;
				rectangle2.X = rectangle.Right;
				rectangle2.Width = bounds.Width - rectangle.Width - 30;
				rectangle2.Height = 13;
				Rectangle rectangle3 = bounds;
				rectangle3.X = rectangle2.Right;
				rectangle3.Width = bounds.Width - rectangle2.Width;
				rectangle3.Height = rectangle2.Height;
				Rectangle rectangle4 = bounds;
				rectangle4.X = rectangle.Right;
				rectangle4.Y = rectangle2.Bottom;
				Enchantment enchantment = (Enchantment)EqEnchant.Items[e.Index];
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
				e.Graphics.DrawString(enchantment.name, font, brush, rectangle2, format);
				e.Graphics.DrawString("L." + enchantment.level, font2, brush2, rectangle3, stringFormat2);
				string text = "";
				text += enchantment.values[0].ToString();
				if (enchantment.values.Length > 1)
				{
					text = text + ((enchantment.values.Length > 2) ? "  /  " : "\n") + enchantment.values[1].ToString();
				}
				if (enchantment.values.Length > 2)
				{
					text = text + "\n" + enchantment.values[2].ToString();
				}
				e.Graphics.DrawString(text, font2, brush2, rectangle4, stringFormat);
				e.DrawFocusRectangle();
			}
		}

		private void EqSave_Click(object sender, EventArgs e)
		{
			if (EqName.SelectedIndex >= 0)
			{
				int[] array = new int[16]
				{
					((Equipment)EqName.SelectedItem).id,
					EqVal1.SelectedIndex,
					(int)EqVal1Num.Value,
					EqVal2.SelectedIndex,
					(int)EqVal2Num.Value,
					EqVal3.SelectedIndex,
					(int)EqVal3Num.Value,
					EqVal4.SelectedIndex,
					(int)EqVal4Num.Value,
					(EqGem1.SelectedIndex >= 0) ? ((Gem)EqGem1.SelectedItem).id : (-1),
					(EqGem2.SelectedIndex >= 0) ? ((Gem)EqGem2.SelectedItem).id : (-1),
					(EqGem3.SelectedIndex >= 0) ? ((Gem)EqGem3.SelectedItem).id : (-1),
					(int)EqInscrip.Value,
					(int)EqEnhan.Value,
					(EqEnchant.SelectedIndex >= 0) ? ((Enchantment)EqEnchant.SelectedItem).id : (-1),
					0
				};
				switch (type)
				{
				case 0:
					main.ProfileManager.currentProfile.weapon = array;
					break;
				case 1:
					main.ProfileManager.currentProfile.glove = array;
					break;
				case 2:
					main.ProfileManager.currentProfile.ring = array;
					break;
				case 3:
					main.ProfileManager.currentProfile.talisman = array;
					break;
				case 4:
					main.ProfileManager.currentProfile.helm = array;
					break;
				case 5:
					main.ProfileManager.currentProfile.armor = array;
					break;
				case 6:
					main.ProfileManager.currentProfile.belt = array;
					break;
				case 7:
					main.ProfileManager.currentProfile.boots = array;
					break;
				}
				if (((Equipment)EqName.SelectedItem).forge > 0)
				{
					main.ProfileManager.currentProfile.forge[type * 2] = ForgeVal.SelectedIndex;
				}
				if (((Equipment)EqName.SelectedItem).forge > 1)
				{
					main.ProfileManager.currentProfile.forge[type * 2 + 1] = ForgeGem.SelectedIndex;
				}
				main.UpdateBuild();
				Hide();
			}
			else
			{
				MessageBox.Show("No equipment selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void EquipForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		internal void fillEq(int[] eqv, int[] frg)
		{
			if (eqv[0] == -1)
			{
				return;
			}
			EqLevel.SelectedIndex = (DataLibrary.equipment[eqv[0]].level - 1) / 10;
			EqLevel_SelectedValueChanged(null, null);
			for (int i = 0; i < EqName.Items.Count; i++)
			{
				if (((Equipment)EqName.Items[i]).id == eqv[0])
				{
					EqName.SelectedIndex = i;
				}
			}
			EqVal1.SelectedIndex = eqv[1];
			EqVal1Num.Value = eqv[2];
			EqVal2.SelectedIndex = eqv[3];
			EqVal2Num.Value = eqv[4];
			EqVal3.SelectedIndex = eqv[5];
			EqVal3Num.Value = eqv[6];
			EqVal4.SelectedIndex = eqv[7];
			EqVal4Num.Value = eqv[8];
			for (int j = 0; j < EqGem1.Items.Count; j++)
			{
				if (((Gem)EqGem1.Items[j]).id == eqv[9])
				{
					EqGem1.SelectedIndex = j;
				}
			}
			for (int k = 0; k < EqGem2.Items.Count; k++)
			{
				if (((Gem)EqGem2.Items[k]).id == eqv[10])
				{
					EqGem2.SelectedIndex = k;
				}
			}
			for (int l = 0; l < EqGem3.Items.Count; l++)
			{
				if (((Gem)EqGem3.Items[l]).id == eqv[11])
				{
					EqGem3.SelectedIndex = l;
				}
			}
			EqInscrip.Value = eqv[12];
			EqEnhan.Value = eqv[13];
			for (int m = 0; m < EqEnchant.Items.Count; m++)
			{
				if (((Enchantment)EqEnchant.Items[m]).id == eqv[14])
				{
					EqEnchant.SelectedIndex = m;
				}
			}
			if (frg[type * 2] != -1)
			{
				ForgeVal.SelectedIndex = frg[type * 2];
			}
			if (frg[type * 2 + 1] != -1)
			{
				ForgeGem.SelectedIndex = frg[type * 2 + 1];
			}
		}

		private void ForgeGem_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			e.ItemHeight = 27;
		}
	}
}
