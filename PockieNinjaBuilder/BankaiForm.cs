using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class BankaiForm : Form
	{
		private IContainer components;

		private Panel Ban1Panel;

		private NumericUpDown Val11UpDown;

		private ComboBox Val11;

		private CheckBox Ban1Checkbox;

		private NumericUpDown Val18UpDown;

		private NumericUpDown Val17UpDown;

		private NumericUpDown Val16UpDown;

		private NumericUpDown Val15UpDown;

		private NumericUpDown Val14UpDown;

		private NumericUpDown Val13UpDown;

		private NumericUpDown Val12UpDown;

		private ComboBox Val18;

		private ComboBox Val17;

		private ComboBox Val16;

		private ComboBox Val15;

		private ComboBox Val14;

		private ComboBox Val13;

		private ComboBox Val12;

		private Panel Ban2Panel;

		private NumericUpDown Val28UpDown;

		private NumericUpDown Val27UpDown;

		private NumericUpDown Val26UpDown;

		private NumericUpDown Val25UpDown;

		private NumericUpDown Val24UpDown;

		private NumericUpDown Val23UpDown;

		private NumericUpDown Val22UpDown;

		private NumericUpDown Val21UpDown;

		private ComboBox Val28;

		private ComboBox Val27;

		private ComboBox Val26;

		private ComboBox Val25;

		private ComboBox Val24;

		private ComboBox Val23;

		private ComboBox Val22;

		private ComboBox Val21;

		private CheckBox Ban2Checkbox;

		private Panel Ban3Panel;

		private NumericUpDown Val38UpDown;

		private NumericUpDown Val37UpDown;

		private NumericUpDown Val36UpDown;

		private NumericUpDown Val35UpDown;

		private NumericUpDown Val34UpDown;

		private NumericUpDown Val33UpDown;

		private NumericUpDown Val32UpDown;

		private NumericUpDown Val31UpDown;

		private ComboBox Val38;

		private ComboBox Val37;

		private ComboBox Val36;

		private ComboBox Val35;

		private ComboBox Val34;

		private ComboBox Val33;

		private ComboBox Val32;

		private ComboBox Val31;

		private CheckBox Ban3Checkbox;

		private Button BanSave;

		private NumericUpDown Ban1Level;

		private NumericUpDown Ban2Level;

		private NumericUpDown Ban3Level;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.BankaiForm));
			this.Ban1Panel = new System.Windows.Forms.Panel();
			this.Val18UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val17UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val16UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val15UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val14UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val13UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val12UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val11UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val18 = new System.Windows.Forms.ComboBox();
			this.Val17 = new System.Windows.Forms.ComboBox();
			this.Val16 = new System.Windows.Forms.ComboBox();
			this.Val15 = new System.Windows.Forms.ComboBox();
			this.Val14 = new System.Windows.Forms.ComboBox();
			this.Val13 = new System.Windows.Forms.ComboBox();
			this.Val12 = new System.Windows.Forms.ComboBox();
			this.Val11 = new System.Windows.Forms.ComboBox();
			this.Ban1Checkbox = new System.Windows.Forms.CheckBox();
			this.Ban2Panel = new System.Windows.Forms.Panel();
			this.Val28UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val27UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val26UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val25UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val24UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val23UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val22UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val21UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val28 = new System.Windows.Forms.ComboBox();
			this.Val27 = new System.Windows.Forms.ComboBox();
			this.Val26 = new System.Windows.Forms.ComboBox();
			this.Val25 = new System.Windows.Forms.ComboBox();
			this.Val24 = new System.Windows.Forms.ComboBox();
			this.Val23 = new System.Windows.Forms.ComboBox();
			this.Val22 = new System.Windows.Forms.ComboBox();
			this.Val21 = new System.Windows.Forms.ComboBox();
			this.Ban2Checkbox = new System.Windows.Forms.CheckBox();
			this.Ban3Panel = new System.Windows.Forms.Panel();
			this.Val38UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val37UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val36UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val35UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val34UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val33UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val32UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val31UpDown = new System.Windows.Forms.NumericUpDown();
			this.Val38 = new System.Windows.Forms.ComboBox();
			this.Val37 = new System.Windows.Forms.ComboBox();
			this.Val36 = new System.Windows.Forms.ComboBox();
			this.Val35 = new System.Windows.Forms.ComboBox();
			this.Val34 = new System.Windows.Forms.ComboBox();
			this.Val33 = new System.Windows.Forms.ComboBox();
			this.Val32 = new System.Windows.Forms.ComboBox();
			this.Val31 = new System.Windows.Forms.ComboBox();
			this.Ban3Checkbox = new System.Windows.Forms.CheckBox();
			this.BanSave = new System.Windows.Forms.Button();
			this.Ban1Level = new System.Windows.Forms.NumericUpDown();
			this.Ban2Level = new System.Windows.Forms.NumericUpDown();
			this.Ban3Level = new System.Windows.Forms.NumericUpDown();
			this.Ban1Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Val18UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val17UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val16UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val15UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val14UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val13UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val12UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val11UpDown).BeginInit();
			this.Ban2Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Val28UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val27UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val26UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val25UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val24UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val23UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val22UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val21UpDown).BeginInit();
			this.Ban3Panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.Val38UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val37UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val36UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val35UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val34UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val33UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val32UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Val31UpDown).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Ban1Level).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Ban2Level).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.Ban3Level).BeginInit();
			base.SuspendLayout();
			this.Ban1Panel.Controls.Add(this.Val18UpDown);
			this.Ban1Panel.Controls.Add(this.Val17UpDown);
			this.Ban1Panel.Controls.Add(this.Val16UpDown);
			this.Ban1Panel.Controls.Add(this.Val15UpDown);
			this.Ban1Panel.Controls.Add(this.Val14UpDown);
			this.Ban1Panel.Controls.Add(this.Val13UpDown);
			this.Ban1Panel.Controls.Add(this.Val12UpDown);
			this.Ban1Panel.Controls.Add(this.Val11UpDown);
			this.Ban1Panel.Controls.Add(this.Val18);
			this.Ban1Panel.Controls.Add(this.Val17);
			this.Ban1Panel.Controls.Add(this.Val16);
			this.Ban1Panel.Controls.Add(this.Val15);
			this.Ban1Panel.Controls.Add(this.Val14);
			this.Ban1Panel.Controls.Add(this.Val13);
			this.Ban1Panel.Controls.Add(this.Val12);
			this.Ban1Panel.Controls.Add(this.Val11);
			this.Ban1Panel.Enabled = false;
			this.Ban1Panel.Location = new System.Drawing.Point(12, 35);
			this.Ban1Panel.Name = "Ban1Panel";
			this.Ban1Panel.Size = new System.Drawing.Size(165, 298);
			this.Ban1Panel.TabIndex = 0;
			this.Val18UpDown.Location = new System.Drawing.Point(120, 267);
			this.Val18UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val18UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val18UpDown.Name = "Val18UpDown";
			this.Val18UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val18UpDown.TabIndex = 1;
			this.Val18UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val18UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val17UpDown.Location = new System.Drawing.Point(120, 230);
			this.Val17UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val17UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val17UpDown.Name = "Val17UpDown";
			this.Val17UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val17UpDown.TabIndex = 1;
			this.Val17UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val17UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val16UpDown.Location = new System.Drawing.Point(120, 193);
			this.Val16UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val16UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val16UpDown.Name = "Val16UpDown";
			this.Val16UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val16UpDown.TabIndex = 1;
			this.Val16UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val16UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val15UpDown.Location = new System.Drawing.Point(120, 156);
			this.Val15UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val15UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val15UpDown.Name = "Val15UpDown";
			this.Val15UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val15UpDown.TabIndex = 1;
			this.Val15UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val15UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val14UpDown.Location = new System.Drawing.Point(120, 119);
			this.Val14UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val14UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val14UpDown.Name = "Val14UpDown";
			this.Val14UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val14UpDown.TabIndex = 1;
			this.Val14UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val14UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val13UpDown.Location = new System.Drawing.Point(120, 82);
			this.Val13UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val13UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val13UpDown.Name = "Val13UpDown";
			this.Val13UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val13UpDown.TabIndex = 1;
			this.Val13UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val13UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val12UpDown.Location = new System.Drawing.Point(120, 45);
			this.Val12UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val12UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val12UpDown.Name = "Val12UpDown";
			this.Val12UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val12UpDown.TabIndex = 1;
			this.Val12UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val12UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val11UpDown.Location = new System.Drawing.Point(120, 8);
			this.Val11UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val11UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val11UpDown.Name = "Val11UpDown";
			this.Val11UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val11UpDown.TabIndex = 1;
			this.Val11UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val11UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val18.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val18.FormattingEnabled = true;
			this.Val18.ItemHeight = 25;
			this.Val18.Location = new System.Drawing.Point(3, 262);
			this.Val18.Name = "Val18";
			this.Val18.Size = new System.Drawing.Size(111, 31);
			this.Val18.TabIndex = 0;
			this.Val18.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val17.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val17.FormattingEnabled = true;
			this.Val17.ItemHeight = 25;
			this.Val17.Location = new System.Drawing.Point(3, 225);
			this.Val17.Name = "Val17";
			this.Val17.Size = new System.Drawing.Size(111, 31);
			this.Val17.TabIndex = 0;
			this.Val17.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val16.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val16.FormattingEnabled = true;
			this.Val16.ItemHeight = 25;
			this.Val16.Location = new System.Drawing.Point(3, 188);
			this.Val16.Name = "Val16";
			this.Val16.Size = new System.Drawing.Size(111, 31);
			this.Val16.TabIndex = 0;
			this.Val16.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val15.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val15.FormattingEnabled = true;
			this.Val15.ItemHeight = 25;
			this.Val15.Location = new System.Drawing.Point(3, 151);
			this.Val15.Name = "Val15";
			this.Val15.Size = new System.Drawing.Size(111, 31);
			this.Val15.TabIndex = 0;
			this.Val15.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val14.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val14.FormattingEnabled = true;
			this.Val14.ItemHeight = 25;
			this.Val14.Location = new System.Drawing.Point(3, 114);
			this.Val14.Name = "Val14";
			this.Val14.Size = new System.Drawing.Size(111, 31);
			this.Val14.TabIndex = 0;
			this.Val14.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val13.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val13.FormattingEnabled = true;
			this.Val13.ItemHeight = 25;
			this.Val13.Location = new System.Drawing.Point(3, 77);
			this.Val13.Name = "Val13";
			this.Val13.Size = new System.Drawing.Size(111, 31);
			this.Val13.TabIndex = 0;
			this.Val13.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val12.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val12.FormattingEnabled = true;
			this.Val12.ItemHeight = 25;
			this.Val12.Location = new System.Drawing.Point(3, 40);
			this.Val12.Name = "Val12";
			this.Val12.Size = new System.Drawing.Size(111, 31);
			this.Val12.TabIndex = 0;
			this.Val12.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val11.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val11.FormattingEnabled = true;
			this.Val11.ItemHeight = 25;
			this.Val11.Location = new System.Drawing.Point(3, 3);
			this.Val11.Name = "Val11";
			this.Val11.Size = new System.Drawing.Size(111, 31);
			this.Val11.TabIndex = 0;
			this.Val11.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Ban1Checkbox.AutoSize = true;
			this.Ban1Checkbox.Location = new System.Drawing.Point(39, 12);
			this.Ban1Checkbox.Name = "Ban1Checkbox";
			this.Ban1Checkbox.Size = new System.Drawing.Size(91, 17);
			this.Ban1Checkbox.TabIndex = 1;
			this.Ban1Checkbox.Text = "Zangetsu Lvl.";
			this.Ban1Checkbox.UseVisualStyleBackColor = true;
			this.Ban1Checkbox.CheckedChanged += new System.EventHandler(Ban1Checkbox_CheckedChanged);
			this.Ban2Panel.Controls.Add(this.Val28UpDown);
			this.Ban2Panel.Controls.Add(this.Val27UpDown);
			this.Ban2Panel.Controls.Add(this.Val26UpDown);
			this.Ban2Panel.Controls.Add(this.Val25UpDown);
			this.Ban2Panel.Controls.Add(this.Val24UpDown);
			this.Ban2Panel.Controls.Add(this.Val23UpDown);
			this.Ban2Panel.Controls.Add(this.Val22UpDown);
			this.Ban2Panel.Controls.Add(this.Val21UpDown);
			this.Ban2Panel.Controls.Add(this.Val28);
			this.Ban2Panel.Controls.Add(this.Val27);
			this.Ban2Panel.Controls.Add(this.Val26);
			this.Ban2Panel.Controls.Add(this.Val25);
			this.Ban2Panel.Controls.Add(this.Val24);
			this.Ban2Panel.Controls.Add(this.Val23);
			this.Ban2Panel.Controls.Add(this.Val22);
			this.Ban2Panel.Controls.Add(this.Val21);
			this.Ban2Panel.Enabled = false;
			this.Ban2Panel.Location = new System.Drawing.Point(183, 35);
			this.Ban2Panel.Name = "Ban2Panel";
			this.Ban2Panel.Size = new System.Drawing.Size(165, 298);
			this.Ban2Panel.TabIndex = 0;
			this.Val28UpDown.Location = new System.Drawing.Point(120, 267);
			this.Val28UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val28UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val28UpDown.Name = "Val28UpDown";
			this.Val28UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val28UpDown.TabIndex = 1;
			this.Val28UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val28UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val27UpDown.Location = new System.Drawing.Point(120, 230);
			this.Val27UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val27UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val27UpDown.Name = "Val27UpDown";
			this.Val27UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val27UpDown.TabIndex = 1;
			this.Val27UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val27UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val26UpDown.Location = new System.Drawing.Point(120, 193);
			this.Val26UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val26UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val26UpDown.Name = "Val26UpDown";
			this.Val26UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val26UpDown.TabIndex = 1;
			this.Val26UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val26UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val25UpDown.Location = new System.Drawing.Point(120, 156);
			this.Val25UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val25UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val25UpDown.Name = "Val25UpDown";
			this.Val25UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val25UpDown.TabIndex = 1;
			this.Val25UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val25UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val24UpDown.Location = new System.Drawing.Point(120, 119);
			this.Val24UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val24UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val24UpDown.Name = "Val24UpDown";
			this.Val24UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val24UpDown.TabIndex = 1;
			this.Val24UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val24UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val23UpDown.Location = new System.Drawing.Point(120, 82);
			this.Val23UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val23UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val23UpDown.Name = "Val23UpDown";
			this.Val23UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val23UpDown.TabIndex = 1;
			this.Val23UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val23UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val22UpDown.Location = new System.Drawing.Point(120, 45);
			this.Val22UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val22UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val22UpDown.Name = "Val22UpDown";
			this.Val22UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val22UpDown.TabIndex = 1;
			this.Val22UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val22UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val21UpDown.Location = new System.Drawing.Point(120, 8);
			this.Val21UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val21UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val21UpDown.Name = "Val21UpDown";
			this.Val21UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val21UpDown.TabIndex = 1;
			this.Val21UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val21UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val28.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val28.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val28.FormattingEnabled = true;
			this.Val28.ItemHeight = 25;
			this.Val28.Location = new System.Drawing.Point(3, 262);
			this.Val28.Name = "Val28";
			this.Val28.Size = new System.Drawing.Size(111, 31);
			this.Val28.TabIndex = 0;
			this.Val28.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val27.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val27.FormattingEnabled = true;
			this.Val27.ItemHeight = 25;
			this.Val27.Location = new System.Drawing.Point(3, 225);
			this.Val27.Name = "Val27";
			this.Val27.Size = new System.Drawing.Size(111, 31);
			this.Val27.TabIndex = 0;
			this.Val27.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val26.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val26.FormattingEnabled = true;
			this.Val26.ItemHeight = 25;
			this.Val26.Location = new System.Drawing.Point(3, 188);
			this.Val26.Name = "Val26";
			this.Val26.Size = new System.Drawing.Size(111, 31);
			this.Val26.TabIndex = 0;
			this.Val26.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val25.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val25.FormattingEnabled = true;
			this.Val25.ItemHeight = 25;
			this.Val25.Location = new System.Drawing.Point(3, 151);
			this.Val25.Name = "Val25";
			this.Val25.Size = new System.Drawing.Size(111, 31);
			this.Val25.TabIndex = 0;
			this.Val25.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val24.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val24.FormattingEnabled = true;
			this.Val24.ItemHeight = 25;
			this.Val24.Location = new System.Drawing.Point(3, 114);
			this.Val24.Name = "Val24";
			this.Val24.Size = new System.Drawing.Size(111, 31);
			this.Val24.TabIndex = 0;
			this.Val24.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val23.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val23.FormattingEnabled = true;
			this.Val23.ItemHeight = 25;
			this.Val23.Location = new System.Drawing.Point(3, 77);
			this.Val23.Name = "Val23";
			this.Val23.Size = new System.Drawing.Size(111, 31);
			this.Val23.TabIndex = 0;
			this.Val23.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val22.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val22.FormattingEnabled = true;
			this.Val22.ItemHeight = 25;
			this.Val22.Location = new System.Drawing.Point(3, 40);
			this.Val22.Name = "Val22";
			this.Val22.Size = new System.Drawing.Size(111, 31);
			this.Val22.TabIndex = 0;
			this.Val22.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val21.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val21.FormattingEnabled = true;
			this.Val21.ItemHeight = 25;
			this.Val21.Location = new System.Drawing.Point(3, 3);
			this.Val21.Name = "Val21";
			this.Val21.Size = new System.Drawing.Size(111, 31);
			this.Val21.TabIndex = 0;
			this.Val21.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Ban2Checkbox.AutoSize = true;
			this.Ban2Checkbox.Enabled = false;
			this.Ban2Checkbox.Location = new System.Drawing.Point(197, 12);
			this.Ban2Checkbox.Name = "Ban2Checkbox";
			this.Ban2Checkbox.Size = new System.Drawing.Size(115, 17);
			this.Ban2Checkbox.TabIndex = 1;
			this.Ban2Checkbox.Text = "Senbonzakura Lvl.";
			this.Ban2Checkbox.UseVisualStyleBackColor = true;
			this.Ban2Checkbox.CheckedChanged += new System.EventHandler(Ban2Checkbox_CheckedChanged);
			this.Ban3Panel.Controls.Add(this.Val38UpDown);
			this.Ban3Panel.Controls.Add(this.Val37UpDown);
			this.Ban3Panel.Controls.Add(this.Val36UpDown);
			this.Ban3Panel.Controls.Add(this.Val35UpDown);
			this.Ban3Panel.Controls.Add(this.Val34UpDown);
			this.Ban3Panel.Controls.Add(this.Val33UpDown);
			this.Ban3Panel.Controls.Add(this.Val32UpDown);
			this.Ban3Panel.Controls.Add(this.Val31UpDown);
			this.Ban3Panel.Controls.Add(this.Val38);
			this.Ban3Panel.Controls.Add(this.Val37);
			this.Ban3Panel.Controls.Add(this.Val36);
			this.Ban3Panel.Controls.Add(this.Val35);
			this.Ban3Panel.Controls.Add(this.Val34);
			this.Ban3Panel.Controls.Add(this.Val33);
			this.Ban3Panel.Controls.Add(this.Val32);
			this.Ban3Panel.Controls.Add(this.Val31);
			this.Ban3Panel.Enabled = false;
			this.Ban3Panel.Location = new System.Drawing.Point(354, 35);
			this.Ban3Panel.Name = "Ban3Panel";
			this.Ban3Panel.Size = new System.Drawing.Size(165, 298);
			this.Ban3Panel.TabIndex = 0;
			this.Val38UpDown.Location = new System.Drawing.Point(120, 267);
			this.Val38UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val38UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val38UpDown.Name = "Val38UpDown";
			this.Val38UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val38UpDown.TabIndex = 1;
			this.Val38UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val38UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val37UpDown.Location = new System.Drawing.Point(120, 230);
			this.Val37UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val37UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val37UpDown.Name = "Val37UpDown";
			this.Val37UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val37UpDown.TabIndex = 1;
			this.Val37UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val37UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val36UpDown.Location = new System.Drawing.Point(120, 193);
			this.Val36UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val36UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val36UpDown.Name = "Val36UpDown";
			this.Val36UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val36UpDown.TabIndex = 1;
			this.Val36UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val36UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val35UpDown.Location = new System.Drawing.Point(120, 156);
			this.Val35UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val35UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val35UpDown.Name = "Val35UpDown";
			this.Val35UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val35UpDown.TabIndex = 1;
			this.Val35UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val35UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val34UpDown.Location = new System.Drawing.Point(120, 119);
			this.Val34UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val34UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val34UpDown.Name = "Val34UpDown";
			this.Val34UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val34UpDown.TabIndex = 1;
			this.Val34UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val34UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val33UpDown.Location = new System.Drawing.Point(120, 82);
			this.Val33UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val33UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val33UpDown.Name = "Val33UpDown";
			this.Val33UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val33UpDown.TabIndex = 1;
			this.Val33UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val33UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val32UpDown.Location = new System.Drawing.Point(120, 45);
			this.Val32UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val32UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val32UpDown.Name = "Val32UpDown";
			this.Val32UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val32UpDown.TabIndex = 1;
			this.Val32UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val32UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val31UpDown.Location = new System.Drawing.Point(120, 8);
			this.Val31UpDown.Maximum = new decimal(new int[4] { 10, 0, 0, 0 });
			this.Val31UpDown.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val31UpDown.Name = "Val31UpDown";
			this.Val31UpDown.Size = new System.Drawing.Size(40, 20);
			this.Val31UpDown.TabIndex = 1;
			this.Val31UpDown.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Val31UpDown.ValueChanged += new System.EventHandler(ValUpDown_ValueChanged);
			this.Val38.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val38.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val38.FormattingEnabled = true;
			this.Val38.ItemHeight = 25;
			this.Val38.Location = new System.Drawing.Point(3, 262);
			this.Val38.Name = "Val38";
			this.Val38.Size = new System.Drawing.Size(111, 31);
			this.Val38.TabIndex = 0;
			this.Val38.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val37.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val37.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val37.FormattingEnabled = true;
			this.Val37.ItemHeight = 25;
			this.Val37.Location = new System.Drawing.Point(3, 225);
			this.Val37.Name = "Val37";
			this.Val37.Size = new System.Drawing.Size(111, 31);
			this.Val37.TabIndex = 0;
			this.Val37.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val36.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val36.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val36.FormattingEnabled = true;
			this.Val36.ItemHeight = 25;
			this.Val36.Location = new System.Drawing.Point(3, 188);
			this.Val36.Name = "Val36";
			this.Val36.Size = new System.Drawing.Size(111, 31);
			this.Val36.TabIndex = 0;
			this.Val36.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val35.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val35.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val35.FormattingEnabled = true;
			this.Val35.ItemHeight = 25;
			this.Val35.Location = new System.Drawing.Point(3, 151);
			this.Val35.Name = "Val35";
			this.Val35.Size = new System.Drawing.Size(111, 31);
			this.Val35.TabIndex = 0;
			this.Val35.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val34.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val34.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val34.FormattingEnabled = true;
			this.Val34.ItemHeight = 25;
			this.Val34.Location = new System.Drawing.Point(3, 114);
			this.Val34.Name = "Val34";
			this.Val34.Size = new System.Drawing.Size(111, 31);
			this.Val34.TabIndex = 0;
			this.Val34.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val33.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val33.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val33.FormattingEnabled = true;
			this.Val33.ItemHeight = 25;
			this.Val33.Location = new System.Drawing.Point(3, 77);
			this.Val33.Name = "Val33";
			this.Val33.Size = new System.Drawing.Size(111, 31);
			this.Val33.TabIndex = 0;
			this.Val33.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val32.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val32.FormattingEnabled = true;
			this.Val32.ItemHeight = 25;
			this.Val32.Location = new System.Drawing.Point(3, 40);
			this.Val32.Name = "Val32";
			this.Val32.Size = new System.Drawing.Size(111, 31);
			this.Val32.TabIndex = 0;
			this.Val32.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Val31.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.Val31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Val31.FormattingEnabled = true;
			this.Val31.ItemHeight = 25;
			this.Val31.Location = new System.Drawing.Point(3, 3);
			this.Val31.Name = "Val31";
			this.Val31.Size = new System.Drawing.Size(111, 31);
			this.Val31.TabIndex = 0;
			this.Val31.DrawItem += new System.Windows.Forms.DrawItemEventHandler(Val_DrawItem);
			this.Ban3Checkbox.AutoSize = true;
			this.Ban3Checkbox.Enabled = false;
			this.Ban3Checkbox.Location = new System.Drawing.Point(384, 12);
			this.Ban3Checkbox.Name = "Ban3Checkbox";
			this.Ban3Checkbox.Size = new System.Drawing.Size(86, 17);
			this.Ban3Checkbox.TabIndex = 1;
			this.Ban3Checkbox.Text = "Ice Ring Lvl.";
			this.Ban3Checkbox.UseVisualStyleBackColor = true;
			this.Ban3Checkbox.CheckedChanged += new System.EventHandler(Ban3Checkbox_CheckedChanged);
			this.BanSave.Location = new System.Drawing.Point(228, 339);
			this.BanSave.Name = "BanSave";
			this.BanSave.Size = new System.Drawing.Size(75, 23);
			this.BanSave.TabIndex = 2;
			this.BanSave.Text = "Save";
			this.BanSave.UseVisualStyleBackColor = true;
			this.BanSave.Click += new System.EventHandler(BanSave_Click);
			this.Ban1Level.BackColor = System.Drawing.SystemColors.Control;
			this.Ban1Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Ban1Level.Enabled = false;
			this.Ban1Level.Location = new System.Drawing.Point(122, 13);
			this.Ban1Level.Maximum = new decimal(new int[4] { 8, 0, 0, 0 });
			this.Ban1Level.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Ban1Level.Name = "Ban1Level";
			this.Ban1Level.Size = new System.Drawing.Size(29, 16);
			this.Ban1Level.TabIndex = 3;
			this.Ban1Level.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Ban2Level.BackColor = System.Drawing.SystemColors.Control;
			this.Ban2Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Ban2Level.Enabled = false;
			this.Ban2Level.Location = new System.Drawing.Point(304, 13);
			this.Ban2Level.Maximum = new decimal(new int[4] { 8, 0, 0, 0 });
			this.Ban2Level.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Ban2Level.Name = "Ban2Level";
			this.Ban2Level.Size = new System.Drawing.Size(29, 16);
			this.Ban2Level.TabIndex = 3;
			this.Ban2Level.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Ban3Level.BackColor = System.Drawing.SystemColors.Control;
			this.Ban3Level.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Ban3Level.Enabled = false;
			this.Ban3Level.Location = new System.Drawing.Point(462, 13);
			this.Ban3Level.Maximum = new decimal(new int[4] { 8, 0, 0, 0 });
			this.Ban3Level.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.Ban3Level.Name = "Ban3Level";
			this.Ban3Level.Size = new System.Drawing.Size(29, 16);
			this.Ban3Level.TabIndex = 3;
			this.Ban3Level.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(529, 370);
			base.Controls.Add(this.Ban3Level);
			base.Controls.Add(this.Ban2Level);
			base.Controls.Add(this.Ban1Level);
			base.Controls.Add(this.BanSave);
			base.Controls.Add(this.Ban3Checkbox);
			base.Controls.Add(this.Ban2Checkbox);
			base.Controls.Add(this.Ban3Panel);
			base.Controls.Add(this.Ban2Panel);
			base.Controls.Add(this.Ban1Checkbox);
			base.Controls.Add(this.Ban1Panel);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "BankaiForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bankai";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(BankaiForm_FormClosing);
			this.Ban1Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.Val18UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val17UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val16UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val15UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val14UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val13UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val12UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val11UpDown).EndInit();
			this.Ban2Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.Val28UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val27UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val26UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val25UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val24UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val23UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val22UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val21UpDown).EndInit();
			this.Ban3Panel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.Val38UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val37UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val36UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val35UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val34UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val33UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val32UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Val31UpDown).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Ban1Level).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Ban2Level).EndInit();
			((System.ComponentModel.ISupportInitialize)this.Ban3Level).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public BankaiForm(MainForm main)
		{
			this.main = main;
			InitializeComponent();
			Val11.Tag = Val11UpDown;
			Val12.Tag = Val12UpDown;
			Val13.Tag = Val13UpDown;
			Val14.Tag = Val14UpDown;
			Val15.Tag = Val15UpDown;
			Val16.Tag = Val16UpDown;
			Val17.Tag = Val17UpDown;
			Val18.Tag = Val18UpDown;
			Val21.Tag = Val21UpDown;
			Val22.Tag = Val22UpDown;
			Val23.Tag = Val23UpDown;
			Val24.Tag = Val24UpDown;
			Val25.Tag = Val25UpDown;
			Val26.Tag = Val26UpDown;
			Val27.Tag = Val27UpDown;
			Val28.Tag = Val28UpDown;
			Val31.Tag = Val31UpDown;
			Val32.Tag = Val32UpDown;
			Val33.Tag = Val33UpDown;
			Val34.Tag = Val34UpDown;
			Val35.Tag = Val35UpDown;
			Val36.Tag = Val36UpDown;
			Val37.Tag = Val37UpDown;
			Val38.Tag = Val38UpDown;
			for (int i = 0; i < DataLibrary.bankaicrystal.Length; i++)
			{
				Val11.Items.Add(DataLibrary.bankaicrystal[i]);
				Val12.Items.Add(DataLibrary.bankaicrystal[i]);
				Val13.Items.Add(DataLibrary.bankaicrystal[i]);
				Val14.Items.Add(DataLibrary.bankaicrystal[i]);
				Val15.Items.Add(DataLibrary.bankaicrystal[i]);
				Val16.Items.Add(DataLibrary.bankaicrystal[i]);
				Val17.Items.Add(DataLibrary.bankaicrystal[i]);
				Val18.Items.Add(DataLibrary.bankaicrystal[i]);
				Val21.Items.Add(DataLibrary.bankaicrystal[i]);
				Val22.Items.Add(DataLibrary.bankaicrystal[i]);
				Val23.Items.Add(DataLibrary.bankaicrystal[i]);
				Val24.Items.Add(DataLibrary.bankaicrystal[i]);
				Val25.Items.Add(DataLibrary.bankaicrystal[i]);
				Val26.Items.Add(DataLibrary.bankaicrystal[i]);
				Val27.Items.Add(DataLibrary.bankaicrystal[i]);
				Val28.Items.Add(DataLibrary.bankaicrystal[i]);
				Val31.Items.Add(DataLibrary.bankaicrystal[i]);
				Val32.Items.Add(DataLibrary.bankaicrystal[i]);
				Val33.Items.Add(DataLibrary.bankaicrystal[i]);
				Val34.Items.Add(DataLibrary.bankaicrystal[i]);
				Val35.Items.Add(DataLibrary.bankaicrystal[i]);
				Val36.Items.Add(DataLibrary.bankaicrystal[i]);
				Val37.Items.Add(DataLibrary.bankaicrystal[i]);
				Val38.Items.Add(DataLibrary.bankaicrystal[i]);
			}
		}

		private void Val_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index >= 0)
			{
				Rectangle rectangle = bounds;
				rectangle.Width = 0;
				Rectangle rectangle2 = bounds;
				rectangle2.X = rectangle.Right;
				rectangle2.Width = bounds.Width - rectangle.Width - 25;
				rectangle2.Height = 13;
				Rectangle rectangle3 = bounds;
				rectangle3.X = rectangle.Right;
				rectangle3.Y = rectangle2.Bottom;
				SoulCrystal soulCrystal = (SoulCrystal)((ComboBox)sender).Items[e.Index];
				StringFormat format = new StringFormat();
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Near;
				Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
				Font font2 = new Font(e.Font.FontFamily, (float)((double)e.Font.Size * 0.8), FontStyle.Regular);
				Brush brush = new SolidBrush(e.ForeColor);
				if (soulCrystal.rarity == 0)
				{
					brush = new SolidBrush(Color.Green);
				}
				if (soulCrystal.rarity == 1)
				{
					brush = new SolidBrush(Color.Blue);
				}
				if (soulCrystal.rarity == 2)
				{
					brush = new SolidBrush(Color.Purple);
				}
				if (soulCrystal.rarity == 3)
				{
					brush = new SolidBrush(Color.DarkOrange);
				}
				Brush brush2 = new SolidBrush(Color.DarkBlue);
				e.Graphics.FillRectangle(new SolidBrush(e.BackColor), bounds);
				e.Graphics.DrawString(soulCrystal.name, font, brush, rectangle2, format);
				e.Graphics.DrawString(soulCrystal.ToStringVal((int)((NumericUpDown)((ComboBox)sender).Tag).Value), font2, brush2, rectangle3, stringFormat);
				e.DrawFocusRectangle();
			}
		}

		private void ValUpDown_ValueChanged(object sender, EventArgs e)
		{
			Val11.Refresh();
			Val12.Refresh();
			Val13.Refresh();
			Val14.Refresh();
			Val15.Refresh();
			Val16.Refresh();
			Val17.Refresh();
			Val18.Refresh();
			Val21.Refresh();
			Val22.Refresh();
			Val23.Refresh();
			Val24.Refresh();
			Val25.Refresh();
			Val26.Refresh();
			Val27.Refresh();
			Val28.Refresh();
			Val31.Refresh();
			Val32.Refresh();
			Val33.Refresh();
			Val34.Refresh();
			Val35.Refresh();
			Val36.Refresh();
			Val37.Refresh();
			Val38.Refresh();
		}

		private void Ban1Checkbox_CheckedChanged(object sender, EventArgs e)
		{
			Ban1Panel.Enabled = Ban1Checkbox.Checked;
			Ban1Level.Enabled = Ban1Checkbox.Checked;
			Ban2Checkbox.Enabled = Ban1Checkbox.Checked;
			if (!Ban1Checkbox.Checked)
			{
				Ban2Checkbox.Checked = false;
			}
		}

		private void Ban2Checkbox_CheckedChanged(object sender, EventArgs e)
		{
			Ban2Panel.Enabled = Ban2Checkbox.Checked;
			Ban2Level.Enabled = Ban2Checkbox.Checked;
			Ban3Checkbox.Enabled = Ban2Checkbox.Checked;
			if (!Ban2Checkbox.Checked)
			{
				Ban3Checkbox.Checked = false;
			}
		}

		private void Ban3Checkbox_CheckedChanged(object sender, EventArgs e)
		{
			Ban3Panel.Enabled = Ban3Checkbox.Checked;
			Ban3Level.Enabled = Ban1Checkbox.Checked;
		}

		public void fillBan(int[] ban1, int[] ban2, int[] ban3)
		{
			if (ban1[0] == 1)
			{
				Ban1Checkbox.Checked = true;
			}
			Val11.SelectedIndex = ban1[1];
			Val11UpDown.Value = ban1[2];
			Val12.SelectedIndex = ban1[3];
			Val12UpDown.Value = ban1[4];
			Val13.SelectedIndex = ban1[5];
			Val13UpDown.Value = ban1[6];
			Val14.SelectedIndex = ban1[7];
			Val14UpDown.Value = ban1[8];
			Val15.SelectedIndex = ban1[9];
			Val15UpDown.Value = ban1[10];
			Val16.SelectedIndex = ban1[11];
			Val16UpDown.Value = ban1[12];
			Val17.SelectedIndex = ban1[13];
			Val17UpDown.Value = ban1[14];
			Val18.SelectedIndex = ban1[15];
			Val18UpDown.Value = ban1[16];
			Ban1Level.Value = ((ban1[17] > 8) ? 8 : ban1[17]);
			if (ban2[0] == 1)
			{
				Ban2Checkbox.Checked = true;
			}
			Val21.SelectedIndex = ban2[1];
			Val21UpDown.Value = ban2[2];
			Val22.SelectedIndex = ban2[3];
			Val22UpDown.Value = ban2[4];
			Val23.SelectedIndex = ban2[5];
			Val23UpDown.Value = ban2[6];
			Val24.SelectedIndex = ban2[7];
			Val24UpDown.Value = ban2[8];
			Val25.SelectedIndex = ban2[9];
			Val25UpDown.Value = ban2[10];
			Val26.SelectedIndex = ban2[11];
			Val26UpDown.Value = ban2[12];
			Val27.SelectedIndex = ban2[13];
			Val27UpDown.Value = ban2[14];
			Val28.SelectedIndex = ban2[15];
			Val28UpDown.Value = ban2[16];
			Ban2Level.Value = ((ban2[17] > 8) ? 8 : ban2[17]);
			if (ban3[0] == 1)
			{
				Ban3Checkbox.Checked = true;
			}
			Val31.SelectedIndex = ban3[1];
			Val31UpDown.Value = ban3[2];
			Val32.SelectedIndex = ban3[3];
			Val32UpDown.Value = ban3[4];
			Val33.SelectedIndex = ban3[5];
			Val33UpDown.Value = ban3[6];
			Val34.SelectedIndex = ban3[7];
			Val34UpDown.Value = ban3[8];
			Val35.SelectedIndex = ban3[9];
			Val35UpDown.Value = ban3[10];
			Val36.SelectedIndex = ban3[11];
			Val36UpDown.Value = ban3[12];
			Val37.SelectedIndex = ban3[13];
			Val37UpDown.Value = ban3[14];
			Val38.SelectedIndex = ban3[15];
			Val38UpDown.Value = ban3[16];
			Ban3Level.Value = ((ban3[17] > 8) ? 8 : ban3[17]);
		}

		private void BankaiForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void BanSave_Click(object sender, EventArgs e)
		{
			int[] ban = new int[18]
			{
				Ban1Checkbox.Checked ? 1 : 0,
				Val11.SelectedIndex,
				(int)Val11UpDown.Value,
				Val12.SelectedIndex,
				(int)Val12UpDown.Value,
				Val13.SelectedIndex,
				(int)Val13UpDown.Value,
				Val14.SelectedIndex,
				(int)Val14UpDown.Value,
				Val15.SelectedIndex,
				(int)Val15UpDown.Value,
				Val16.SelectedIndex,
				(int)Val16UpDown.Value,
				Val17.SelectedIndex,
				(int)Val17UpDown.Value,
				Val18.SelectedIndex,
				(int)Val18UpDown.Value,
				(int)Ban1Level.Value
			};
			int[] ban2 = new int[18]
			{
				Ban2Checkbox.Checked ? 1 : 0,
				Val21.SelectedIndex,
				(int)Val21UpDown.Value,
				Val22.SelectedIndex,
				(int)Val22UpDown.Value,
				Val23.SelectedIndex,
				(int)Val23UpDown.Value,
				Val24.SelectedIndex,
				(int)Val24UpDown.Value,
				Val25.SelectedIndex,
				(int)Val25UpDown.Value,
				Val26.SelectedIndex,
				(int)Val26UpDown.Value,
				Val27.SelectedIndex,
				(int)Val27UpDown.Value,
				Val28.SelectedIndex,
				(int)Val28UpDown.Value,
				(int)Ban2Level.Value
			};
			int[] ban3 = new int[18]
			{
				Ban3Checkbox.Checked ? 1 : 0,
				Val31.SelectedIndex,
				(int)Val31UpDown.Value,
				Val32.SelectedIndex,
				(int)Val32UpDown.Value,
				Val33.SelectedIndex,
				(int)Val33UpDown.Value,
				Val34.SelectedIndex,
				(int)Val34UpDown.Value,
				Val35.SelectedIndex,
				(int)Val35UpDown.Value,
				Val36.SelectedIndex,
				(int)Val36UpDown.Value,
				Val37.SelectedIndex,
				(int)Val37UpDown.Value,
				Val38.SelectedIndex,
				(int)Val38UpDown.Value,
				(int)Ban3Level.Value
			};
			main.ProfileManager.currentProfile.ban1 = ban;
			main.ProfileManager.currentProfile.ban2 = ban2;
			main.ProfileManager.currentProfile.ban3 = ban3;
			Hide();
		}
	}
}
