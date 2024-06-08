using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;
using PockieNinjaBuilder.Properties;

namespace PockieNinjaBuilder
{
	public class MainForm : Form
	{
		private const int MRUnumber = 6;

		private IContainer components;

		private TabControl MainwindowTabs;

		private TabPage Equipment;

		private TabPage Pet;

		private TabPage Bloodline;

		private TabPage overview;

		private PictureBox EquipBackgroud;

		private Button OutfitButton;

		private Button EquipBL;

		private Button EquipWeapon;

		private Button EquipTitle;

		private Button EquipBoot;

		private Button EquipBelt;

		private Button EquipArmor;

		private Button EquipHelm;

		private Button EquipTalisman;

		private Button EquipRing;

		private Button EquipPet;

		private Button EquipGlove;

		private MenuStrip MainwindowStrip;

		private ToolStripMenuItem MainwindowStripMenu;

		private ToolStripMenuItem MenuItem_new;

		private ToolStripMenuItem MenuItem_open;

		private ToolStripMenuItem MenuItem_save;

		private ToolStripMenuItem MenuItem_recent;

		private GroupBox BL1Box;

		private Button BS11;

		private Button BL1;

		private GroupBox BL3Box;

		private Label BS35Label;

		private Button BS35;

		private Label BS34Label;

		private Button BS34;

		private Label BS33Label;

		private Button BS33;

		private Label BS32Label;

		private Button BS32;

		private Label BS31Label;

		private GroupBox BLPray3;

		private NumericUpDown PrayStaCount3;

		private NumericUpDown PrayAgiCount3;

		private NumericUpDown PrayStrCount3;

		private Label PrayStaLabel3;

		private Label PrayAgiLabel3;

		private Label PrayStrLabel3;

		private Button BS31;

		private Button BL3;

		private GroupBox BL2Box;

		private Label BS25Label;

		private Button BS25;

		private Label BS24Label;

		private Button BS24;

		private Label BS23Label;

		private Button BS23;

		private Label BS22Label;

		private Button BS22;

		private Label BS21Label;

		private GroupBox BLPray2;

		private NumericUpDown PrayStaCount2;

		private NumericUpDown PrayAgiCount2;

		private NumericUpDown PrayStrCount2;

		private Label PrayStaLabel2;

		private Label PrayAgiLabel2;

		private Label PrayStrLabel2;

		private Button BS21;

		private Button BL2;

		private Label BS15Label;

		private Button BS15;

		private Label BS14Label;

		private Button BS14;

		private Label BS13Label;

		private Button BS13;

		private Label BS12Label;

		private Button BS12;

		private Label BS11Label;

		private GroupBox BLPray1;

		private NumericUpDown PrayStaCount1;

		private NumericUpDown PrayAgiCount1;

		private NumericUpDown PrayStrCount1;

		private Label PrayStaLabel1;

		private Label PrayAgiLabel1;

		private Label PrayStrLabel1;

		private GroupBox groupBox1;

		private TextBox oconstitution;

		private TextBox ocritical;

		private TextBox odefense;

		private TextBox oarmorbreak;

		private TextBox ohit;

		private TextBox opierce;

		private TextBox ochakra;

		private TextBox ohp;

		private TextBox osta;

		private TextBox ododge;

		private TextBox ospeed;

		private TextBox oagi;

		private TextBox oblock;

		private TextBox oatk;

		private TextBox ostr;

		private Label oconslabel;

		private Label ocriticallabel;

		private Label odefenselabel;

		private Label oarmorbreaklabel;

		private Label ohitlabel;

		private Label opiercelabel;

		private Label ochakralabel;

		private Label ohplabel;

		private Label ostalabel;

		private Label ododgelabel;

		private Label ospeedlabel;

		private Label oagilabel;

		private Label oblocklabel;

		private Label oatklabel;

		private Label ostrlabel;

		private Button overviewupdate;

		private GroupBox charactergroup;

		private Label levellabel;

		private Label villagelabel;

		private ComboBox charactervillage;

		private NumericUpDown characterlevel;

		private NumericUpDown tsubook;

		private Label charactertsubook;

		private GroupBox ReleaseGroup;

		private Label label10;

		private Label label9;

		private Label label8;

		private Label label7;

		private Label label6;

		private Label label5;

		private Label label4;

		private Label label3;

		private Label label2;

		private Label label1;

		private TextBox windfield;

		private TextBox waterfield;

		private TextBox toolfield;

		private TextBox taijutsufield;

		private TextBox sealingfield;

		private TextBox lightningfield;

		private TextBox illusionfield;

		private TextBox healingfield;

		private TextBox firefield;

		private TextBox earthfield;

		private GroupBox detailgroup;

		private Label label14;

		private Label label13;

		private Label label12;

		private Label label11;

		private TextBox critmultiplier;

		private TextBox defreduction;

		private TextBox critchance;

		private TextBox dodgechance;

		private ComboBox TitleSelect;

		private Button ZanButton;

		private ComboBox PetSkill1;

		private ComboBox PetComboBox;

		private ComboBox PetSkill6;

		private ComboBox PetSkill4;

		private ComboBox PetSkill2;

		private ComboBox PetSkill5;

		private ComboBox PetSkill3;

		private PictureBox OutfitPose;

		private Label label15;

		private ComboBox NinjaRank;

		private SaveFileDialog saveFile;

		private OpenFileDialog openFile;

		private Label AboutLabel;

		private FlowLayoutPanel SetFlowControl;

		private PrintDialog printDialog;

		private PrintDocument printDocument;

		private ToolStripMenuItem exportBuildToolStripMenuItem;

		private Button BanButton;

		private GroupBox groupBox2;

		private TextBox hpabsorb;

		private TextBox dmgreduction;

		private Label label17;

		private Label label18;

		private Label label16;

		private TextBox blockchance;

		private TextBox counteratk;

		private Label label19;

		private Button WingButton;

		private Label ChineseLabel;

		private string progname = DataLibrary.progname + " v" + DataLibrary.version + "beta";

		public bool chinesemode;

		public bool loading;

		private bool saved;

		private OutfitForm outfitform;

		private WingForm wingform;

		private BloodlineForm bloodline;

		private BloodsoulForm bloodsoul;

		private EquipForm eqweapon;

		private EquipForm eqglove;

		private EquipForm eqring;

		private EquipForm eqtalisman;

		private EquipForm eqhelm;

		private EquipForm eqarmor;

		private EquipForm eqbelt;

		private EquipForm eqboots;

		private ZanpakutoForm zanform;

		private BankaiForm banform;

		private AboutBox about;

		public PnpProfileManager ProfileManager;

		private Queue<string> MRUlist = new Queue<string>();

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.MainForm));
			this.MainwindowTabs = new System.Windows.Forms.TabControl();
			this.Equipment = new System.Windows.Forms.TabPage();
			this.WingButton = new System.Windows.Forms.Button();
			this.BanButton = new System.Windows.Forms.Button();
			this.ZanButton = new System.Windows.Forms.Button();
			this.SetFlowControl = new System.Windows.Forms.FlowLayoutPanel();
			this.EquipBL = new System.Windows.Forms.Button();
			this.OutfitPose = new System.Windows.Forms.PictureBox();
			this.EquipTitle = new System.Windows.Forms.Button();
			this.TitleSelect = new System.Windows.Forms.ComboBox();
			this.charactergroup = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.NinjaRank = new System.Windows.Forms.ComboBox();
			this.tsubook = new System.Windows.Forms.NumericUpDown();
			this.charactertsubook = new System.Windows.Forms.Label();
			this.levellabel = new System.Windows.Forms.Label();
			this.villagelabel = new System.Windows.Forms.Label();
			this.charactervillage = new System.Windows.Forms.ComboBox();
			this.characterlevel = new System.Windows.Forms.NumericUpDown();
			this.EquipBoot = new System.Windows.Forms.Button();
			this.EquipBelt = new System.Windows.Forms.Button();
			this.EquipArmor = new System.Windows.Forms.Button();
			this.EquipHelm = new System.Windows.Forms.Button();
			this.EquipTalisman = new System.Windows.Forms.Button();
			this.EquipRing = new System.Windows.Forms.Button();
			this.EquipPet = new System.Windows.Forms.Button();
			this.EquipGlove = new System.Windows.Forms.Button();
			this.EquipWeapon = new System.Windows.Forms.Button();
			this.OutfitButton = new System.Windows.Forms.Button();
			this.EquipBackgroud = new System.Windows.Forms.PictureBox();
			this.Pet = new System.Windows.Forms.TabPage();
			this.PetSkill6 = new System.Windows.Forms.ComboBox();
			this.PetSkill4 = new System.Windows.Forms.ComboBox();
			this.PetSkill2 = new System.Windows.Forms.ComboBox();
			this.PetSkill5 = new System.Windows.Forms.ComboBox();
			this.PetSkill3 = new System.Windows.Forms.ComboBox();
			this.PetSkill1 = new System.Windows.Forms.ComboBox();
			this.PetComboBox = new System.Windows.Forms.ComboBox();
			this.Bloodline = new System.Windows.Forms.TabPage();
			this.BL3Box = new System.Windows.Forms.GroupBox();
			this.BS35Label = new System.Windows.Forms.Label();
			this.BS35 = new System.Windows.Forms.Button();
			this.BS34Label = new System.Windows.Forms.Label();
			this.BS34 = new System.Windows.Forms.Button();
			this.BS33Label = new System.Windows.Forms.Label();
			this.BS33 = new System.Windows.Forms.Button();
			this.BS32Label = new System.Windows.Forms.Label();
			this.BS32 = new System.Windows.Forms.Button();
			this.BS31Label = new System.Windows.Forms.Label();
			this.BLPray3 = new System.Windows.Forms.GroupBox();
			this.PrayStaCount3 = new System.Windows.Forms.NumericUpDown();
			this.PrayAgiCount3 = new System.Windows.Forms.NumericUpDown();
			this.PrayStrCount3 = new System.Windows.Forms.NumericUpDown();
			this.PrayStaLabel3 = new System.Windows.Forms.Label();
			this.PrayAgiLabel3 = new System.Windows.Forms.Label();
			this.PrayStrLabel3 = new System.Windows.Forms.Label();
			this.BS31 = new System.Windows.Forms.Button();
			this.BL3 = new System.Windows.Forms.Button();
			this.BL2Box = new System.Windows.Forms.GroupBox();
			this.BS25Label = new System.Windows.Forms.Label();
			this.BS25 = new System.Windows.Forms.Button();
			this.BS24Label = new System.Windows.Forms.Label();
			this.BS24 = new System.Windows.Forms.Button();
			this.BS23Label = new System.Windows.Forms.Label();
			this.BS23 = new System.Windows.Forms.Button();
			this.BS22Label = new System.Windows.Forms.Label();
			this.BS22 = new System.Windows.Forms.Button();
			this.BS21Label = new System.Windows.Forms.Label();
			this.BLPray2 = new System.Windows.Forms.GroupBox();
			this.PrayStaCount2 = new System.Windows.Forms.NumericUpDown();
			this.PrayAgiCount2 = new System.Windows.Forms.NumericUpDown();
			this.PrayStrCount2 = new System.Windows.Forms.NumericUpDown();
			this.PrayStaLabel2 = new System.Windows.Forms.Label();
			this.PrayAgiLabel2 = new System.Windows.Forms.Label();
			this.PrayStrLabel2 = new System.Windows.Forms.Label();
			this.BS21 = new System.Windows.Forms.Button();
			this.BL2 = new System.Windows.Forms.Button();
			this.BL1Box = new System.Windows.Forms.GroupBox();
			this.BS15Label = new System.Windows.Forms.Label();
			this.BS15 = new System.Windows.Forms.Button();
			this.BS14Label = new System.Windows.Forms.Label();
			this.BS14 = new System.Windows.Forms.Button();
			this.BS13Label = new System.Windows.Forms.Label();
			this.BS13 = new System.Windows.Forms.Button();
			this.BS12Label = new System.Windows.Forms.Label();
			this.BS12 = new System.Windows.Forms.Button();
			this.BS11Label = new System.Windows.Forms.Label();
			this.BLPray1 = new System.Windows.Forms.GroupBox();
			this.PrayStaCount1 = new System.Windows.Forms.NumericUpDown();
			this.PrayAgiCount1 = new System.Windows.Forms.NumericUpDown();
			this.PrayStrCount1 = new System.Windows.Forms.NumericUpDown();
			this.PrayStaLabel1 = new System.Windows.Forms.Label();
			this.PrayAgiLabel1 = new System.Windows.Forms.Label();
			this.PrayStrLabel1 = new System.Windows.Forms.Label();
			this.BS11 = new System.Windows.Forms.Button();
			this.BL1 = new System.Windows.Forms.Button();
			this.overview = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.hpabsorb = new System.Windows.Forms.TextBox();
			this.counteratk = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.dmgreduction = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.detailgroup = new System.Windows.Forms.GroupBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.critmultiplier = new System.Windows.Forms.TextBox();
			this.defreduction = new System.Windows.Forms.TextBox();
			this.critchance = new System.Windows.Forms.TextBox();
			this.blockchance = new System.Windows.Forms.TextBox();
			this.dodgechance = new System.Windows.Forms.TextBox();
			this.ReleaseGroup = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.windfield = new System.Windows.Forms.TextBox();
			this.waterfield = new System.Windows.Forms.TextBox();
			this.toolfield = new System.Windows.Forms.TextBox();
			this.taijutsufield = new System.Windows.Forms.TextBox();
			this.sealingfield = new System.Windows.Forms.TextBox();
			this.lightningfield = new System.Windows.Forms.TextBox();
			this.illusionfield = new System.Windows.Forms.TextBox();
			this.healingfield = new System.Windows.Forms.TextBox();
			this.firefield = new System.Windows.Forms.TextBox();
			this.earthfield = new System.Windows.Forms.TextBox();
			this.overviewupdate = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.oconstitution = new System.Windows.Forms.TextBox();
			this.ocritical = new System.Windows.Forms.TextBox();
			this.odefense = new System.Windows.Forms.TextBox();
			this.oarmorbreak = new System.Windows.Forms.TextBox();
			this.ohit = new System.Windows.Forms.TextBox();
			this.opierce = new System.Windows.Forms.TextBox();
			this.ochakra = new System.Windows.Forms.TextBox();
			this.ohp = new System.Windows.Forms.TextBox();
			this.osta = new System.Windows.Forms.TextBox();
			this.ododge = new System.Windows.Forms.TextBox();
			this.ospeed = new System.Windows.Forms.TextBox();
			this.oagi = new System.Windows.Forms.TextBox();
			this.oblock = new System.Windows.Forms.TextBox();
			this.oatk = new System.Windows.Forms.TextBox();
			this.ostr = new System.Windows.Forms.TextBox();
			this.oconslabel = new System.Windows.Forms.Label();
			this.ocriticallabel = new System.Windows.Forms.Label();
			this.odefenselabel = new System.Windows.Forms.Label();
			this.oarmorbreaklabel = new System.Windows.Forms.Label();
			this.ohitlabel = new System.Windows.Forms.Label();
			this.opiercelabel = new System.Windows.Forms.Label();
			this.ochakralabel = new System.Windows.Forms.Label();
			this.ohplabel = new System.Windows.Forms.Label();
			this.ostalabel = new System.Windows.Forms.Label();
			this.ododgelabel = new System.Windows.Forms.Label();
			this.ospeedlabel = new System.Windows.Forms.Label();
			this.oagilabel = new System.Windows.Forms.Label();
			this.oblocklabel = new System.Windows.Forms.Label();
			this.oatklabel = new System.Windows.Forms.Label();
			this.ostrlabel = new System.Windows.Forms.Label();
			this.MainwindowStrip = new System.Windows.Forms.MenuStrip();
			this.MainwindowStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_new = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_open = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_save = new System.Windows.Forms.ToolStripMenuItem();
			this.exportBuildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_recent = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.AboutLabel = new System.Windows.Forms.Label();
			this.printDialog = new System.Windows.Forms.PrintDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.ChineseLabel = new System.Windows.Forms.Label();
			this.MainwindowTabs.SuspendLayout();
			this.Equipment.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.OutfitPose).BeginInit();
			this.charactergroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.tsubook).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.characterlevel).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.EquipBackgroud).BeginInit();
			this.Pet.SuspendLayout();
			this.Bloodline.SuspendLayout();
			this.BL3Box.SuspendLayout();
			this.BLPray3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PrayStaCount3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrayAgiCount3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrayStrCount3).BeginInit();
			this.BL2Box.SuspendLayout();
			this.BLPray2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PrayStaCount2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrayAgiCount2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrayStrCount2).BeginInit();
			this.BL1Box.SuspendLayout();
			this.BLPray1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PrayStaCount1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrayAgiCount1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrayStrCount1).BeginInit();
			this.overview.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.detailgroup.SuspendLayout();
			this.ReleaseGroup.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.MainwindowStrip.SuspendLayout();
			base.SuspendLayout();
			this.MainwindowTabs.Controls.Add(this.Equipment);
			this.MainwindowTabs.Controls.Add(this.Pet);
			this.MainwindowTabs.Controls.Add(this.Bloodline);
			this.MainwindowTabs.Controls.Add(this.overview);
			this.MainwindowTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainwindowTabs.Location = new System.Drawing.Point(0, 24);
			this.MainwindowTabs.Name = "MainwindowTabs";
			this.MainwindowTabs.SelectedIndex = 0;
			this.MainwindowTabs.Size = new System.Drawing.Size(552, 416);
			this.MainwindowTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.MainwindowTabs.TabIndex = 0;
			this.Equipment.Controls.Add(this.WingButton);
			this.Equipment.Controls.Add(this.BanButton);
			this.Equipment.Controls.Add(this.ZanButton);
			this.Equipment.Controls.Add(this.SetFlowControl);
			this.Equipment.Controls.Add(this.EquipBL);
			this.Equipment.Controls.Add(this.OutfitPose);
			this.Equipment.Controls.Add(this.EquipTitle);
			this.Equipment.Controls.Add(this.TitleSelect);
			this.Equipment.Controls.Add(this.charactergroup);
			this.Equipment.Controls.Add(this.EquipBoot);
			this.Equipment.Controls.Add(this.EquipBelt);
			this.Equipment.Controls.Add(this.EquipArmor);
			this.Equipment.Controls.Add(this.EquipHelm);
			this.Equipment.Controls.Add(this.EquipTalisman);
			this.Equipment.Controls.Add(this.EquipRing);
			this.Equipment.Controls.Add(this.EquipPet);
			this.Equipment.Controls.Add(this.EquipGlove);
			this.Equipment.Controls.Add(this.EquipWeapon);
			this.Equipment.Controls.Add(this.OutfitButton);
			this.Equipment.Controls.Add(this.EquipBackgroud);
			this.Equipment.Location = new System.Drawing.Point(4, 22);
			this.Equipment.Name = "Equipment";
			this.Equipment.Padding = new System.Windows.Forms.Padding(3);
			this.Equipment.Size = new System.Drawing.Size(544, 390);
			this.Equipment.TabIndex = 0;
			this.Equipment.Text = "Equipment";
			this.Equipment.UseVisualStyleBackColor = true;
			this.WingButton.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipWing;
			this.WingButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WingButton.FlatAppearance.BorderSize = 0;
			this.WingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.WingButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.WingButton.Location = new System.Drawing.Point(75, 104);
			this.WingButton.Name = "WingButton";
			this.WingButton.Size = new System.Drawing.Size(55, 55);
			this.WingButton.TabIndex = 23;
			this.WingButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.WingButton.UseVisualStyleBackColor = true;
			this.WingButton.Click += new System.EventHandler(WingButton_Click);
			this.BanButton.Location = new System.Drawing.Point(362, 168);
			this.BanButton.Name = "BanButton";
			this.BanButton.Size = new System.Drawing.Size(161, 26);
			this.BanButton.TabIndex = 22;
			this.BanButton.Text = "Bankai";
			this.BanButton.UseVisualStyleBackColor = true;
			this.BanButton.Click += new System.EventHandler(BanButton_Click);
			this.ZanButton.Location = new System.Drawing.Point(362, 136);
			this.ZanButton.Name = "ZanButton";
			this.ZanButton.Size = new System.Drawing.Size(161, 26);
			this.ZanButton.TabIndex = 0;
			this.ZanButton.Text = "Zanpakuto";
			this.ZanButton.UseVisualStyleBackColor = true;
			this.ZanButton.Click += new System.EventHandler(ZanButton_Click);
			this.SetFlowControl.AutoScroll = true;
			this.SetFlowControl.Location = new System.Drawing.Point(8, 275);
			this.SetFlowControl.Name = "SetFlowControl";
			this.SetFlowControl.Size = new System.Drawing.Size(528, 107);
			this.SetFlowControl.TabIndex = 21;
			this.EquipBL.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipBloodline;
			this.EquipBL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipBL.FlatAppearance.BorderSize = 0;
			this.EquipBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipBL.Location = new System.Drawing.Point(79, 55);
			this.EquipBL.Name = "EquipBL";
			this.EquipBL.Size = new System.Drawing.Size(45, 43);
			this.EquipBL.TabIndex = 12;
			this.EquipBL.UseVisualStyleBackColor = true;
			this.EquipBL.Click += new System.EventHandler(EquipBL_Click);
			this.OutfitPose.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipOutfitBack;
			this.OutfitPose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.OutfitPose.Location = new System.Drawing.Point(75, 50);
			this.OutfitPose.Name = "OutfitPose";
			this.OutfitPose.Size = new System.Drawing.Size(199, 218);
			this.OutfitPose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.OutfitPose.TabIndex = 20;
			this.OutfitPose.TabStop = false;
			this.EquipTitle.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipTitle;
			this.EquipTitle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipTitle.FlatAppearance.BorderSize = 0;
			this.EquipTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipTitle.Location = new System.Drawing.Point(93, 9);
			this.EquipTitle.Name = "EquipTitle";
			this.EquipTitle.Size = new System.Drawing.Size(164, 37);
			this.EquipTitle.TabIndex = 11;
			this.EquipTitle.UseVisualStyleBackColor = true;
			this.EquipTitle.Click += new System.EventHandler(EquipTitle_Click);
			this.TitleSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.TitleSelect.DropDownHeight = 350;
			this.TitleSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.TitleSelect.FormattingEnabled = true;
			this.TitleSelect.IntegralHeight = false;
			this.TitleSelect.Location = new System.Drawing.Point(96, 22);
			this.TitleSelect.Name = "TitleSelect";
			this.TitleSelect.Size = new System.Drawing.Size(159, 21);
			this.TitleSelect.TabIndex = 18;
			this.TitleSelect.DrawItem += new System.Windows.Forms.DrawItemEventHandler(TitleSelect_DrawItem);
			this.TitleSelect.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(TitleSelect_MeasureItem);
			this.TitleSelect.SelectedValueChanged += new System.EventHandler(TitleSelect_SelectedValueChanged);
			this.charactergroup.Controls.Add(this.label15);
			this.charactergroup.Controls.Add(this.NinjaRank);
			this.charactergroup.Controls.Add(this.tsubook);
			this.charactergroup.Controls.Add(this.charactertsubook);
			this.charactergroup.Controls.Add(this.levellabel);
			this.charactergroup.Controls.Add(this.villagelabel);
			this.charactergroup.Controls.Add(this.charactervillage);
			this.charactergroup.Controls.Add(this.characterlevel);
			this.charactergroup.Location = new System.Drawing.Point(362, 6);
			this.charactergroup.Name = "charactergroup";
			this.charactergroup.Size = new System.Drawing.Size(161, 124);
			this.charactergroup.TabIndex = 17;
			this.charactergroup.TabStop = false;
			this.charactergroup.Text = "Character: ";
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(6, 97);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(50, 13);
			this.label15.TabIndex = 20;
			this.label15.Text = "N. Rank:";
			this.NinjaRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.NinjaRank.FormattingEnabled = true;
			this.NinjaRank.Items.AddRange(new object[21]
			{
				"Elementary Student", "Primary Student", "Junior Student", "Senior Student", "Prep Genin", "Genin", "Special Genin", "Prep Chunin", "Chunin", "Special Chunin",
				"Prep ANBU", "ANBU", "Special ANBU", "Prep Jonin", "Jonin", "Special Jonin", "Twelve Guardian Ninja", "Elder", "Akatsuki", "Kage",
				"Head of Five Kages"
			});
			this.NinjaRank.Location = new System.Drawing.Point(56, 93);
			this.NinjaRank.Name = "NinjaRank";
			this.NinjaRank.Size = new System.Drawing.Size(95, 21);
			this.NinjaRank.TabIndex = 19;
			this.NinjaRank.SelectedIndexChanged += new System.EventHandler(NinjaRank_SelectedIndexChanged);
			this.tsubook.Location = new System.Drawing.Point(107, 67);
			this.tsubook.Maximum = new decimal(new int[4] { 3, 0, 0, 0 });
			this.tsubook.Name = "tsubook";
			this.tsubook.Size = new System.Drawing.Size(44, 20);
			this.tsubook.TabIndex = 18;
			this.tsubook.ValueChanged += new System.EventHandler(tsubook_ValueChanged);
			this.charactertsubook.AutoSize = true;
			this.charactertsubook.Location = new System.Drawing.Point(6, 69);
			this.charactertsubook.Name = "charactertsubook";
			this.charactertsubook.Size = new System.Drawing.Size(105, 13);
			this.charactertsubook.TabIndex = 17;
			this.charactertsubook.Text = "Tsunade Notebook: ";
			this.levellabel.AutoSize = true;
			this.levellabel.Location = new System.Drawing.Point(6, 16);
			this.levellabel.Name = "levellabel";
			this.levellabel.Size = new System.Drawing.Size(39, 13);
			this.levellabel.TabIndex = 13;
			this.levellabel.Text = "Level: ";
			this.villagelabel.AutoSize = true;
			this.villagelabel.Location = new System.Drawing.Point(6, 43);
			this.villagelabel.Name = "villagelabel";
			this.villagelabel.Size = new System.Drawing.Size(44, 13);
			this.villagelabel.TabIndex = 15;
			this.villagelabel.Text = "Village: ";
			this.charactervillage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.charactervillage.FormattingEnabled = true;
			this.charactervillage.Items.AddRange(new object[5] { "Fire", "Wind", "Lightning", "Water", "Earth" });
			this.charactervillage.Location = new System.Drawing.Point(56, 40);
			this.charactervillage.Name = "charactervillage";
			this.charactervillage.Size = new System.Drawing.Size(95, 21);
			this.charactervillage.TabIndex = 16;
			this.charactervillage.SelectedIndexChanged += new System.EventHandler(charactervillage_SelectedIndexChanged);
			this.characterlevel.Location = new System.Drawing.Point(56, 14);
			this.characterlevel.Maximum = new decimal(new int[4] { 110, 0, 0, 0 });
			this.characterlevel.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
			this.characterlevel.Name = "characterlevel";
			this.characterlevel.Size = new System.Drawing.Size(95, 20);
			this.characterlevel.TabIndex = 14;
			this.characterlevel.Value = new decimal(new int[4] { 1, 0, 0, 0 });
			this.characterlevel.ValueChanged += new System.EventHandler(characterlevel_ValueChanged);
			this.EquipBoot.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipBoot;
			this.EquipBoot.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipBoot.FlatAppearance.BorderSize = 0;
			this.EquipBoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipBoot.Location = new System.Drawing.Point(282, 210);
			this.EquipBoot.Name = "EquipBoot";
			this.EquipBoot.Size = new System.Drawing.Size(55, 55);
			this.EquipBoot.TabIndex = 10;
			this.EquipBoot.UseVisualStyleBackColor = true;
			this.EquipBoot.Click += new System.EventHandler(EquipBoot_Click);
			this.EquipBelt.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipBelt;
			this.EquipBelt.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipBelt.FlatAppearance.BorderSize = 0;
			this.EquipBelt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipBelt.Location = new System.Drawing.Point(282, 153);
			this.EquipBelt.Name = "EquipBelt";
			this.EquipBelt.Size = new System.Drawing.Size(55, 55);
			this.EquipBelt.TabIndex = 9;
			this.EquipBelt.UseVisualStyleBackColor = true;
			this.EquipBelt.Click += new System.EventHandler(EquipBelt_Click);
			this.EquipArmor.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipArmor;
			this.EquipArmor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipArmor.FlatAppearance.BorderSize = 0;
			this.EquipArmor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipArmor.Location = new System.Drawing.Point(282, 96);
			this.EquipArmor.Name = "EquipArmor";
			this.EquipArmor.Size = new System.Drawing.Size(55, 55);
			this.EquipArmor.TabIndex = 8;
			this.EquipArmor.UseVisualStyleBackColor = true;
			this.EquipArmor.Click += new System.EventHandler(EquipArmor_Click);
			this.EquipHelm.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipHelm;
			this.EquipHelm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipHelm.FlatAppearance.BorderSize = 0;
			this.EquipHelm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipHelm.Location = new System.Drawing.Point(282, 39);
			this.EquipHelm.Name = "EquipHelm";
			this.EquipHelm.Size = new System.Drawing.Size(55, 55);
			this.EquipHelm.TabIndex = 7;
			this.EquipHelm.UseVisualStyleBackColor = true;
			this.EquipHelm.Click += new System.EventHandler(EquipHelm_Click);
			this.EquipTalisman.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipTalisman;
			this.EquipTalisman.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipTalisman.FlatAppearance.BorderSize = 0;
			this.EquipTalisman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipTalisman.Location = new System.Drawing.Point(310, 9);
			this.EquipTalisman.Name = "EquipTalisman";
			this.EquipTalisman.Size = new System.Drawing.Size(28, 29);
			this.EquipTalisman.TabIndex = 6;
			this.EquipTalisman.UseVisualStyleBackColor = true;
			this.EquipTalisman.Click += new System.EventHandler(EquipTalisman_Click);
			this.EquipRing.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipRing;
			this.EquipRing.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipRing.FlatAppearance.BorderSize = 0;
			this.EquipRing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipRing.Location = new System.Drawing.Point(281, 9);
			this.EquipRing.Name = "EquipRing";
			this.EquipRing.Size = new System.Drawing.Size(28, 29);
			this.EquipRing.TabIndex = 5;
			this.EquipRing.UseVisualStyleBackColor = true;
			this.EquipRing.Click += new System.EventHandler(EquipRing_Click);
			this.EquipPet.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipPet;
			this.EquipPet.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipPet.FlatAppearance.BorderSize = 0;
			this.EquipPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipPet.Location = new System.Drawing.Point(12, 210);
			this.EquipPet.Name = "EquipPet";
			this.EquipPet.Size = new System.Drawing.Size(55, 55);
			this.EquipPet.TabIndex = 4;
			this.EquipPet.UseVisualStyleBackColor = true;
			this.EquipPet.Click += new System.EventHandler(EquipPet_Click);
			this.EquipGlove.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipGlove;
			this.EquipGlove.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipGlove.FlatAppearance.BorderSize = 0;
			this.EquipGlove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipGlove.Location = new System.Drawing.Point(12, 153);
			this.EquipGlove.Name = "EquipGlove";
			this.EquipGlove.Size = new System.Drawing.Size(55, 55);
			this.EquipGlove.TabIndex = 3;
			this.EquipGlove.UseVisualStyleBackColor = true;
			this.EquipGlove.Click += new System.EventHandler(EquipGlove_Click);
			this.EquipWeapon.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipWeapon;
			this.EquipWeapon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.EquipWeapon.FlatAppearance.BorderSize = 0;
			this.EquipWeapon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.EquipWeapon.Location = new System.Drawing.Point(12, 68);
			this.EquipWeapon.Name = "EquipWeapon";
			this.EquipWeapon.Size = new System.Drawing.Size(55, 83);
			this.EquipWeapon.TabIndex = 2;
			this.EquipWeapon.UseVisualStyleBackColor = true;
			this.EquipWeapon.Click += new System.EventHandler(EquipWeapon_Click);
			this.OutfitButton.BackgroundImage = PockieNinjaBuilder.Properties.Resources.EquipOutfit;
			this.OutfitButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.OutfitButton.FlatAppearance.BorderSize = 0;
			this.OutfitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OutfitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.OutfitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.OutfitButton.Location = new System.Drawing.Point(12, 11);
			this.OutfitButton.Name = "OutfitButton";
			this.OutfitButton.Size = new System.Drawing.Size(55, 55);
			this.OutfitButton.TabIndex = 1;
			this.OutfitButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.OutfitButton.UseVisualStyleBackColor = true;
			this.OutfitButton.Click += new System.EventHandler(OutfitButton_Click);
			this.EquipBackgroud.Image = PockieNinjaBuilder.Properties.Resources.EquipWindow;
			this.EquipBackgroud.Location = new System.Drawing.Point(8, 6);
			this.EquipBackgroud.Name = "EquipBackgroud";
			this.EquipBackgroud.Size = new System.Drawing.Size(333, 263);
			this.EquipBackgroud.TabIndex = 0;
			this.EquipBackgroud.TabStop = false;
			this.Pet.Controls.Add(this.PetSkill6);
			this.Pet.Controls.Add(this.PetSkill4);
			this.Pet.Controls.Add(this.PetSkill2);
			this.Pet.Controls.Add(this.PetSkill5);
			this.Pet.Controls.Add(this.PetSkill3);
			this.Pet.Controls.Add(this.PetSkill1);
			this.Pet.Controls.Add(this.PetComboBox);
			this.Pet.Location = new System.Drawing.Point(4, 22);
			this.Pet.Name = "Pet";
			this.Pet.Padding = new System.Windows.Forms.Padding(3);
			this.Pet.Size = new System.Drawing.Size(544, 390);
			this.Pet.TabIndex = 1;
			this.Pet.Text = "Pet";
			this.Pet.UseVisualStyleBackColor = true;
			this.PetSkill6.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PetSkill6.DropDownHeight = 350;
			this.PetSkill6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetSkill6.Enabled = false;
			this.PetSkill6.FormattingEnabled = true;
			this.PetSkill6.IntegralHeight = false;
			this.PetSkill6.ItemHeight = 15;
			this.PetSkill6.Location = new System.Drawing.Point(290, 193);
			this.PetSkill6.Name = "PetSkill6";
			this.PetSkill6.Size = new System.Drawing.Size(182, 21);
			this.PetSkill6.TabIndex = 1;
			this.PetSkill6.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetSkill_DrawItem);
			this.PetSkill6.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(PetSkill_MeasureItem);
			this.PetSkill6.SelectedIndexChanged += new System.EventHandler(PetSkill_SelectedIndexChanged);
			this.PetSkill4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PetSkill4.DropDownHeight = 350;
			this.PetSkill4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetSkill4.Enabled = false;
			this.PetSkill4.FormattingEnabled = true;
			this.PetSkill4.IntegralHeight = false;
			this.PetSkill4.ItemHeight = 15;
			this.PetSkill4.Location = new System.Drawing.Point(290, 166);
			this.PetSkill4.Name = "PetSkill4";
			this.PetSkill4.Size = new System.Drawing.Size(182, 21);
			this.PetSkill4.TabIndex = 1;
			this.PetSkill4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetSkill_DrawItem);
			this.PetSkill4.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(PetSkill_MeasureItem);
			this.PetSkill4.SelectedIndexChanged += new System.EventHandler(PetSkill_SelectedIndexChanged);
			this.PetSkill2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PetSkill2.DropDownHeight = 350;
			this.PetSkill2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetSkill2.Enabled = false;
			this.PetSkill2.FormattingEnabled = true;
			this.PetSkill2.IntegralHeight = false;
			this.PetSkill2.ItemHeight = 15;
			this.PetSkill2.Location = new System.Drawing.Point(290, 139);
			this.PetSkill2.Name = "PetSkill2";
			this.PetSkill2.Size = new System.Drawing.Size(182, 21);
			this.PetSkill2.TabIndex = 1;
			this.PetSkill2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetSkill_DrawItem);
			this.PetSkill2.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(PetSkill_MeasureItem);
			this.PetSkill2.SelectedIndexChanged += new System.EventHandler(PetSkill_SelectedIndexChanged);
			this.PetSkill5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PetSkill5.DropDownHeight = 350;
			this.PetSkill5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetSkill5.Enabled = false;
			this.PetSkill5.FormattingEnabled = true;
			this.PetSkill5.IntegralHeight = false;
			this.PetSkill5.ItemHeight = 15;
			this.PetSkill5.Location = new System.Drawing.Point(73, 193);
			this.PetSkill5.Name = "PetSkill5";
			this.PetSkill5.Size = new System.Drawing.Size(182, 21);
			this.PetSkill5.TabIndex = 1;
			this.PetSkill5.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetSkill_DrawItem);
			this.PetSkill5.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(PetSkill_MeasureItem);
			this.PetSkill5.SelectedIndexChanged += new System.EventHandler(PetSkill_SelectedIndexChanged);
			this.PetSkill3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PetSkill3.DropDownHeight = 350;
			this.PetSkill3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetSkill3.Enabled = false;
			this.PetSkill3.FormattingEnabled = true;
			this.PetSkill3.IntegralHeight = false;
			this.PetSkill3.ItemHeight = 15;
			this.PetSkill3.Location = new System.Drawing.Point(73, 166);
			this.PetSkill3.Name = "PetSkill3";
			this.PetSkill3.Size = new System.Drawing.Size(182, 21);
			this.PetSkill3.TabIndex = 1;
			this.PetSkill3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetSkill_DrawItem);
			this.PetSkill3.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(PetSkill_MeasureItem);
			this.PetSkill3.SelectedIndexChanged += new System.EventHandler(PetSkill_SelectedIndexChanged);
			this.PetSkill1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.PetSkill1.DropDownHeight = 350;
			this.PetSkill1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetSkill1.Enabled = false;
			this.PetSkill1.FormattingEnabled = true;
			this.PetSkill1.IntegralHeight = false;
			this.PetSkill1.ItemHeight = 15;
			this.PetSkill1.Location = new System.Drawing.Point(73, 139);
			this.PetSkill1.Name = "PetSkill1";
			this.PetSkill1.Size = new System.Drawing.Size(182, 21);
			this.PetSkill1.TabIndex = 1;
			this.PetSkill1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetSkill_DrawItem);
			this.PetSkill1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(PetSkill_MeasureItem);
			this.PetSkill1.SelectedIndexChanged += new System.EventHandler(PetSkill_SelectedIndexChanged);
			this.PetComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.PetComboBox.DropDownHeight = 300;
			this.PetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PetComboBox.FormattingEnabled = true;
			this.PetComboBox.IntegralHeight = false;
			this.PetComboBox.ItemHeight = 51;
			this.PetComboBox.Location = new System.Drawing.Point(170, 46);
			this.PetComboBox.Name = "PetComboBox";
			this.PetComboBox.Size = new System.Drawing.Size(204, 57);
			this.PetComboBox.TabIndex = 0;
			this.PetComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(PetComboBox_DrawItem);
			this.PetComboBox.SelectedIndexChanged += new System.EventHandler(PetComboBox_SelectedIndexChanged);
			this.Bloodline.Controls.Add(this.BL3Box);
			this.Bloodline.Controls.Add(this.BL2Box);
			this.Bloodline.Controls.Add(this.BL1Box);
			this.Bloodline.Location = new System.Drawing.Point(4, 22);
			this.Bloodline.Name = "Bloodline";
			this.Bloodline.Size = new System.Drawing.Size(544, 390);
			this.Bloodline.TabIndex = 2;
			this.Bloodline.Text = "Bloodline";
			this.Bloodline.UseVisualStyleBackColor = true;
			this.BL3Box.Controls.Add(this.BS35Label);
			this.BL3Box.Controls.Add(this.BS35);
			this.BL3Box.Controls.Add(this.BS34Label);
			this.BL3Box.Controls.Add(this.BS34);
			this.BL3Box.Controls.Add(this.BS33Label);
			this.BL3Box.Controls.Add(this.BS33);
			this.BL3Box.Controls.Add(this.BS32Label);
			this.BL3Box.Controls.Add(this.BS32);
			this.BL3Box.Controls.Add(this.BS31Label);
			this.BL3Box.Controls.Add(this.BLPray3);
			this.BL3Box.Controls.Add(this.BS31);
			this.BL3Box.Controls.Add(this.BL3);
			this.BL3Box.Location = new System.Drawing.Point(8, 237);
			this.BL3Box.Name = "BL3Box";
			this.BL3Box.Size = new System.Drawing.Size(525, 111);
			this.BL3Box.TabIndex = 5;
			this.BL3Box.TabStop = false;
			this.BL3Box.Text = "Bloodline3";
			this.BS35Label.Location = new System.Drawing.Point(447, 83);
			this.BS35Label.Name = "BS35Label";
			this.BS35Label.Size = new System.Drawing.Size(61, 18);
			this.BS35Label.TabIndex = 13;
			this.BS35Label.Text = "-";
			this.BS35Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS35.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS35.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS35.Location = new System.Drawing.Point(454, 34);
			this.BS35.Name = "BS35";
			this.BS35.Size = new System.Drawing.Size(46, 46);
			this.BS35.TabIndex = 12;
			this.BS35.UseVisualStyleBackColor = true;
			this.BS35.Click += new System.EventHandler(BS35_Click);
			this.BS34Label.Location = new System.Drawing.Point(385, 83);
			this.BS34Label.Name = "BS34Label";
			this.BS34Label.Size = new System.Drawing.Size(61, 18);
			this.BS34Label.TabIndex = 11;
			this.BS34Label.Text = "-";
			this.BS34Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS34.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS34.Location = new System.Drawing.Point(392, 34);
			this.BS34.Name = "BS34";
			this.BS34.Size = new System.Drawing.Size(46, 46);
			this.BS34.TabIndex = 10;
			this.BS34.UseVisualStyleBackColor = true;
			this.BS34.Click += new System.EventHandler(BS34_Click);
			this.BS33Label.Location = new System.Drawing.Point(324, 83);
			this.BS33Label.Name = "BS33Label";
			this.BS33Label.Size = new System.Drawing.Size(61, 18);
			this.BS33Label.TabIndex = 9;
			this.BS33Label.Text = "-";
			this.BS33Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS33.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS33.Location = new System.Drawing.Point(331, 34);
			this.BS33.Name = "BS33";
			this.BS33.Size = new System.Drawing.Size(46, 46);
			this.BS33.TabIndex = 8;
			this.BS33.UseVisualStyleBackColor = true;
			this.BS33.Click += new System.EventHandler(BS33_Click);
			this.BS32Label.Location = new System.Drawing.Point(262, 83);
			this.BS32Label.Name = "BS32Label";
			this.BS32Label.Size = new System.Drawing.Size(61, 18);
			this.BS32Label.TabIndex = 7;
			this.BS32Label.Text = "-";
			this.BS32Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS32.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS32.Location = new System.Drawing.Point(269, 34);
			this.BS32.Name = "BS32";
			this.BS32.Size = new System.Drawing.Size(46, 46);
			this.BS32.TabIndex = 6;
			this.BS32.UseVisualStyleBackColor = true;
			this.BS32.Click += new System.EventHandler(BS32_Click);
			this.BS31Label.Location = new System.Drawing.Point(201, 83);
			this.BS31Label.Name = "BS31Label";
			this.BS31Label.Size = new System.Drawing.Size(61, 18);
			this.BS31Label.TabIndex = 5;
			this.BS31Label.Text = "-";
			this.BS31Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BLPray3.Controls.Add(this.PrayStaCount3);
			this.BLPray3.Controls.Add(this.PrayAgiCount3);
			this.BLPray3.Controls.Add(this.PrayStrCount3);
			this.BLPray3.Controls.Add(this.PrayStaLabel3);
			this.BLPray3.Controls.Add(this.PrayAgiLabel3);
			this.BLPray3.Controls.Add(this.PrayStrLabel3);
			this.BLPray3.Location = new System.Drawing.Point(64, 9);
			this.BLPray3.Name = "BLPray3";
			this.BLPray3.Size = new System.Drawing.Size(119, 92);
			this.BLPray3.TabIndex = 4;
			this.BLPray3.TabStop = false;
			this.BLPray3.Text = "Prayer";
			this.PrayStaCount3.Location = new System.Drawing.Point(59, 66);
			this.PrayStaCount3.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayStaCount3.Name = "PrayStaCount3";
			this.PrayStaCount3.Size = new System.Drawing.Size(48, 20);
			this.PrayStaCount3.TabIndex = 5;
			this.PrayStaCount3.ValueChanged += new System.EventHandler(PrayCount3_ValueChanged);
			this.PrayAgiCount3.Location = new System.Drawing.Point(59, 40);
			this.PrayAgiCount3.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayAgiCount3.Name = "PrayAgiCount3";
			this.PrayAgiCount3.Size = new System.Drawing.Size(48, 20);
			this.PrayAgiCount3.TabIndex = 4;
			this.PrayAgiCount3.ValueChanged += new System.EventHandler(PrayCount3_ValueChanged);
			this.PrayStrCount3.Location = new System.Drawing.Point(59, 14);
			this.PrayStrCount3.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayStrCount3.Name = "PrayStrCount3";
			this.PrayStrCount3.Size = new System.Drawing.Size(48, 20);
			this.PrayStrCount3.TabIndex = 3;
			this.PrayStrCount3.ValueChanged += new System.EventHandler(PrayCount3_ValueChanged);
			this.PrayStaLabel3.AutoSize = true;
			this.PrayStaLabel3.Location = new System.Drawing.Point(8, 68);
			this.PrayStaLabel3.Name = "PrayStaLabel3";
			this.PrayStaLabel3.Size = new System.Drawing.Size(45, 13);
			this.PrayStaLabel3.TabIndex = 2;
			this.PrayStaLabel3.Text = "Stamina";
			this.PrayAgiLabel3.AutoSize = true;
			this.PrayAgiLabel3.Location = new System.Drawing.Point(8, 42);
			this.PrayAgiLabel3.Name = "PrayAgiLabel3";
			this.PrayAgiLabel3.Size = new System.Drawing.Size(34, 13);
			this.PrayAgiLabel3.TabIndex = 1;
			this.PrayAgiLabel3.Text = "Agility";
			this.PrayStrLabel3.AutoSize = true;
			this.PrayStrLabel3.Location = new System.Drawing.Point(6, 16);
			this.PrayStrLabel3.Name = "PrayStrLabel3";
			this.PrayStrLabel3.Size = new System.Drawing.Size(47, 13);
			this.PrayStrLabel3.TabIndex = 0;
			this.PrayStrLabel3.Text = "Strength";
			this.BS31.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS31.Location = new System.Drawing.Point(208, 34);
			this.BS31.Name = "BS31";
			this.BS31.Size = new System.Drawing.Size(46, 46);
			this.BS31.TabIndex = 3;
			this.BS31.UseVisualStyleBackColor = true;
			this.BS31.Click += new System.EventHandler(BS31_Click);
			this.BL3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BL3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BL3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			this.BL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BL3.Location = new System.Drawing.Point(6, 31);
			this.BL3.Name = "BL3";
			this.BL3.Size = new System.Drawing.Size(52, 52);
			this.BL3.TabIndex = 0;
			this.BL3.UseVisualStyleBackColor = true;
			this.BL3.Click += new System.EventHandler(BL3_Click);
			this.BL2Box.Controls.Add(this.BS25Label);
			this.BL2Box.Controls.Add(this.BS25);
			this.BL2Box.Controls.Add(this.BS24Label);
			this.BL2Box.Controls.Add(this.BS24);
			this.BL2Box.Controls.Add(this.BS23Label);
			this.BL2Box.Controls.Add(this.BS23);
			this.BL2Box.Controls.Add(this.BS22Label);
			this.BL2Box.Controls.Add(this.BS22);
			this.BL2Box.Controls.Add(this.BS21Label);
			this.BL2Box.Controls.Add(this.BLPray2);
			this.BL2Box.Controls.Add(this.BS21);
			this.BL2Box.Controls.Add(this.BL2);
			this.BL2Box.Location = new System.Drawing.Point(8, 120);
			this.BL2Box.Name = "BL2Box";
			this.BL2Box.Size = new System.Drawing.Size(525, 111);
			this.BL2Box.TabIndex = 4;
			this.BL2Box.TabStop = false;
			this.BL2Box.Text = "Bloodline2";
			this.BS25Label.Location = new System.Drawing.Point(447, 83);
			this.BS25Label.Name = "BS25Label";
			this.BS25Label.Size = new System.Drawing.Size(61, 18);
			this.BS25Label.TabIndex = 13;
			this.BS25Label.Text = "-";
			this.BS25Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS25.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS25.Location = new System.Drawing.Point(454, 34);
			this.BS25.Name = "BS25";
			this.BS25.Size = new System.Drawing.Size(46, 46);
			this.BS25.TabIndex = 12;
			this.BS25.UseVisualStyleBackColor = true;
			this.BS25.Click += new System.EventHandler(BS25_Click);
			this.BS24Label.Location = new System.Drawing.Point(385, 83);
			this.BS24Label.Name = "BS24Label";
			this.BS24Label.Size = new System.Drawing.Size(61, 18);
			this.BS24Label.TabIndex = 11;
			this.BS24Label.Text = "-";
			this.BS24Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS24.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS24.Location = new System.Drawing.Point(392, 34);
			this.BS24.Name = "BS24";
			this.BS24.Size = new System.Drawing.Size(46, 46);
			this.BS24.TabIndex = 10;
			this.BS24.UseVisualStyleBackColor = true;
			this.BS24.Click += new System.EventHandler(BS24_Click);
			this.BS23Label.Location = new System.Drawing.Point(324, 83);
			this.BS23Label.Name = "BS23Label";
			this.BS23Label.Size = new System.Drawing.Size(61, 18);
			this.BS23Label.TabIndex = 9;
			this.BS23Label.Text = "-";
			this.BS23Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS23.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS23.Location = new System.Drawing.Point(331, 34);
			this.BS23.Name = "BS23";
			this.BS23.Size = new System.Drawing.Size(46, 46);
			this.BS23.TabIndex = 8;
			this.BS23.UseVisualStyleBackColor = true;
			this.BS23.Click += new System.EventHandler(BS23_Click);
			this.BS22Label.Location = new System.Drawing.Point(262, 83);
			this.BS22Label.Name = "BS22Label";
			this.BS22Label.Size = new System.Drawing.Size(61, 18);
			this.BS22Label.TabIndex = 7;
			this.BS22Label.Text = "-";
			this.BS22Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS22.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS22.Location = new System.Drawing.Point(269, 34);
			this.BS22.Name = "BS22";
			this.BS22.Size = new System.Drawing.Size(46, 46);
			this.BS22.TabIndex = 6;
			this.BS22.UseVisualStyleBackColor = true;
			this.BS22.Click += new System.EventHandler(BS22_Click);
			this.BS21Label.Location = new System.Drawing.Point(201, 83);
			this.BS21Label.Name = "BS21Label";
			this.BS21Label.Size = new System.Drawing.Size(61, 18);
			this.BS21Label.TabIndex = 5;
			this.BS21Label.Text = "-";
			this.BS21Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BLPray2.Controls.Add(this.PrayStaCount2);
			this.BLPray2.Controls.Add(this.PrayAgiCount2);
			this.BLPray2.Controls.Add(this.PrayStrCount2);
			this.BLPray2.Controls.Add(this.PrayStaLabel2);
			this.BLPray2.Controls.Add(this.PrayAgiLabel2);
			this.BLPray2.Controls.Add(this.PrayStrLabel2);
			this.BLPray2.Location = new System.Drawing.Point(64, 9);
			this.BLPray2.Name = "BLPray2";
			this.BLPray2.Size = new System.Drawing.Size(119, 92);
			this.BLPray2.TabIndex = 4;
			this.BLPray2.TabStop = false;
			this.BLPray2.Text = "Prayer";
			this.PrayStaCount2.Location = new System.Drawing.Point(59, 66);
			this.PrayStaCount2.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayStaCount2.Name = "PrayStaCount2";
			this.PrayStaCount2.Size = new System.Drawing.Size(48, 20);
			this.PrayStaCount2.TabIndex = 5;
			this.PrayStaCount2.ValueChanged += new System.EventHandler(PrayCount2_ValueChanged);
			this.PrayAgiCount2.Location = new System.Drawing.Point(59, 40);
			this.PrayAgiCount2.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayAgiCount2.Name = "PrayAgiCount2";
			this.PrayAgiCount2.Size = new System.Drawing.Size(48, 20);
			this.PrayAgiCount2.TabIndex = 4;
			this.PrayAgiCount2.ValueChanged += new System.EventHandler(PrayCount2_ValueChanged);
			this.PrayStrCount2.Location = new System.Drawing.Point(59, 14);
			this.PrayStrCount2.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayStrCount2.Name = "PrayStrCount2";
			this.PrayStrCount2.Size = new System.Drawing.Size(48, 20);
			this.PrayStrCount2.TabIndex = 3;
			this.PrayStrCount2.ValueChanged += new System.EventHandler(PrayCount2_ValueChanged);
			this.PrayStaLabel2.AutoSize = true;
			this.PrayStaLabel2.Location = new System.Drawing.Point(8, 68);
			this.PrayStaLabel2.Name = "PrayStaLabel2";
			this.PrayStaLabel2.Size = new System.Drawing.Size(45, 13);
			this.PrayStaLabel2.TabIndex = 2;
			this.PrayStaLabel2.Text = "Stamina";
			this.PrayAgiLabel2.AutoSize = true;
			this.PrayAgiLabel2.Location = new System.Drawing.Point(8, 42);
			this.PrayAgiLabel2.Name = "PrayAgiLabel2";
			this.PrayAgiLabel2.Size = new System.Drawing.Size(34, 13);
			this.PrayAgiLabel2.TabIndex = 1;
			this.PrayAgiLabel2.Text = "Agility";
			this.PrayStrLabel2.AutoSize = true;
			this.PrayStrLabel2.Location = new System.Drawing.Point(6, 16);
			this.PrayStrLabel2.Name = "PrayStrLabel2";
			this.PrayStrLabel2.Size = new System.Drawing.Size(47, 13);
			this.PrayStrLabel2.TabIndex = 0;
			this.PrayStrLabel2.Text = "Strength";
			this.BS21.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS21.Location = new System.Drawing.Point(208, 34);
			this.BS21.Name = "BS21";
			this.BS21.Size = new System.Drawing.Size(46, 46);
			this.BS21.TabIndex = 3;
			this.BS21.UseVisualStyleBackColor = true;
			this.BS21.Click += new System.EventHandler(BS21_Click);
			this.BL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BL2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BL2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			this.BL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BL2.Location = new System.Drawing.Point(6, 31);
			this.BL2.Name = "BL2";
			this.BL2.Size = new System.Drawing.Size(52, 52);
			this.BL2.TabIndex = 0;
			this.BL2.UseVisualStyleBackColor = true;
			this.BL2.Click += new System.EventHandler(BL2_Click);
			this.BL1Box.Controls.Add(this.BS15Label);
			this.BL1Box.Controls.Add(this.BS15);
			this.BL1Box.Controls.Add(this.BS14Label);
			this.BL1Box.Controls.Add(this.BS14);
			this.BL1Box.Controls.Add(this.BS13Label);
			this.BL1Box.Controls.Add(this.BS13);
			this.BL1Box.Controls.Add(this.BS12Label);
			this.BL1Box.Controls.Add(this.BS12);
			this.BL1Box.Controls.Add(this.BS11Label);
			this.BL1Box.Controls.Add(this.BLPray1);
			this.BL1Box.Controls.Add(this.BS11);
			this.BL1Box.Controls.Add(this.BL1);
			this.BL1Box.Location = new System.Drawing.Point(8, 3);
			this.BL1Box.Name = "BL1Box";
			this.BL1Box.Size = new System.Drawing.Size(525, 111);
			this.BL1Box.TabIndex = 3;
			this.BL1Box.TabStop = false;
			this.BL1Box.Text = "Bloodline1";
			this.BS15Label.Location = new System.Drawing.Point(447, 83);
			this.BS15Label.Name = "BS15Label";
			this.BS15Label.Size = new System.Drawing.Size(61, 18);
			this.BS15Label.TabIndex = 13;
			this.BS15Label.Text = "-";
			this.BS15Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS15.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS15.Location = new System.Drawing.Point(454, 34);
			this.BS15.Name = "BS15";
			this.BS15.Size = new System.Drawing.Size(46, 46);
			this.BS15.TabIndex = 12;
			this.BS15.UseVisualStyleBackColor = true;
			this.BS15.Click += new System.EventHandler(BS15_Click);
			this.BS14Label.Location = new System.Drawing.Point(385, 83);
			this.BS14Label.Name = "BS14Label";
			this.BS14Label.Size = new System.Drawing.Size(61, 18);
			this.BS14Label.TabIndex = 11;
			this.BS14Label.Text = "-";
			this.BS14Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS14.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS14.Location = new System.Drawing.Point(392, 34);
			this.BS14.Name = "BS14";
			this.BS14.Size = new System.Drawing.Size(46, 46);
			this.BS14.TabIndex = 10;
			this.BS14.UseVisualStyleBackColor = true;
			this.BS14.Click += new System.EventHandler(BS14_Click);
			this.BS13Label.Location = new System.Drawing.Point(324, 83);
			this.BS13Label.Name = "BS13Label";
			this.BS13Label.Size = new System.Drawing.Size(61, 18);
			this.BS13Label.TabIndex = 9;
			this.BS13Label.Text = "-";
			this.BS13Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS13.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS13.Location = new System.Drawing.Point(331, 34);
			this.BS13.Name = "BS13";
			this.BS13.Size = new System.Drawing.Size(46, 46);
			this.BS13.TabIndex = 8;
			this.BS13.UseVisualStyleBackColor = true;
			this.BS13.Click += new System.EventHandler(BS13_Click);
			this.BS12Label.Location = new System.Drawing.Point(262, 83);
			this.BS12Label.Name = "BS12Label";
			this.BS12Label.Size = new System.Drawing.Size(61, 18);
			this.BS12Label.TabIndex = 7;
			this.BS12Label.Text = "-";
			this.BS12Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BS12.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS12.Location = new System.Drawing.Point(269, 34);
			this.BS12.Name = "BS12";
			this.BS12.Size = new System.Drawing.Size(46, 46);
			this.BS12.TabIndex = 6;
			this.BS12.UseVisualStyleBackColor = true;
			this.BS12.Click += new System.EventHandler(BS12_Click);
			this.BS11Label.Location = new System.Drawing.Point(201, 83);
			this.BS11Label.Name = "BS11Label";
			this.BS11Label.Size = new System.Drawing.Size(61, 18);
			this.BS11Label.TabIndex = 5;
			this.BS11Label.Text = "-";
			this.BS11Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.BLPray1.Controls.Add(this.PrayStaCount1);
			this.BLPray1.Controls.Add(this.PrayAgiCount1);
			this.BLPray1.Controls.Add(this.PrayStrCount1);
			this.BLPray1.Controls.Add(this.PrayStaLabel1);
			this.BLPray1.Controls.Add(this.PrayAgiLabel1);
			this.BLPray1.Controls.Add(this.PrayStrLabel1);
			this.BLPray1.Location = new System.Drawing.Point(64, 9);
			this.BLPray1.Name = "BLPray1";
			this.BLPray1.Size = new System.Drawing.Size(119, 92);
			this.BLPray1.TabIndex = 4;
			this.BLPray1.TabStop = false;
			this.BLPray1.Text = "Prayer";
			this.PrayStaCount1.Location = new System.Drawing.Point(59, 66);
			this.PrayStaCount1.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayStaCount1.Name = "PrayStaCount1";
			this.PrayStaCount1.Size = new System.Drawing.Size(48, 20);
			this.PrayStaCount1.TabIndex = 5;
			this.PrayStaCount1.ValueChanged += new System.EventHandler(PrayCount1_ValueChanged);
			this.PrayAgiCount1.Location = new System.Drawing.Point(59, 40);
			this.PrayAgiCount1.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayAgiCount1.Name = "PrayAgiCount1";
			this.PrayAgiCount1.Size = new System.Drawing.Size(48, 20);
			this.PrayAgiCount1.TabIndex = 4;
			this.PrayAgiCount1.ValueChanged += new System.EventHandler(PrayCount1_ValueChanged);
			this.PrayStrCount1.Location = new System.Drawing.Point(59, 14);
			this.PrayStrCount1.Maximum = new decimal(new int[4] { 20, 0, 0, 0 });
			this.PrayStrCount1.Name = "PrayStrCount1";
			this.PrayStrCount1.Size = new System.Drawing.Size(48, 20);
			this.PrayStrCount1.TabIndex = 3;
			this.PrayStrCount1.ValueChanged += new System.EventHandler(PrayCount1_ValueChanged);
			this.PrayStaLabel1.AutoSize = true;
			this.PrayStaLabel1.Location = new System.Drawing.Point(8, 68);
			this.PrayStaLabel1.Name = "PrayStaLabel1";
			this.PrayStaLabel1.Size = new System.Drawing.Size(45, 13);
			this.PrayStaLabel1.TabIndex = 2;
			this.PrayStaLabel1.Text = "Stamina";
			this.PrayAgiLabel1.AutoSize = true;
			this.PrayAgiLabel1.Location = new System.Drawing.Point(8, 42);
			this.PrayAgiLabel1.Name = "PrayAgiLabel1";
			this.PrayAgiLabel1.Size = new System.Drawing.Size(34, 13);
			this.PrayAgiLabel1.TabIndex = 1;
			this.PrayAgiLabel1.Text = "Agility";
			this.PrayStrLabel1.AutoSize = true;
			this.PrayStrLabel1.Location = new System.Drawing.Point(6, 16);
			this.PrayStrLabel1.Name = "PrayStrLabel1";
			this.PrayStrLabel1.Size = new System.Drawing.Size(47, 13);
			this.PrayStrLabel1.TabIndex = 0;
			this.PrayStrLabel1.Text = "Strength";
			this.BS11.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BS11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BS11.Location = new System.Drawing.Point(208, 34);
			this.BS11.Name = "BS11";
			this.BS11.Size = new System.Drawing.Size(46, 46);
			this.BS11.TabIndex = 3;
			this.BS11.UseVisualStyleBackColor = true;
			this.BS11.Click += new System.EventHandler(BS11_Click);
			this.BL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.BL1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.BL1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
			this.BL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BL1.Location = new System.Drawing.Point(6, 31);
			this.BL1.Name = "BL1";
			this.BL1.Size = new System.Drawing.Size(52, 52);
			this.BL1.TabIndex = 0;
			this.BL1.UseVisualStyleBackColor = true;
			this.BL1.Click += new System.EventHandler(BL1_Click);
			this.overview.Controls.Add(this.groupBox2);
			this.overview.Controls.Add(this.detailgroup);
			this.overview.Controls.Add(this.ReleaseGroup);
			this.overview.Controls.Add(this.overviewupdate);
			this.overview.Controls.Add(this.groupBox1);
			this.overview.Location = new System.Drawing.Point(4, 22);
			this.overview.Name = "overview";
			this.overview.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.overview.Size = new System.Drawing.Size(544, 390);
			this.overview.TabIndex = 4;
			this.overview.Text = "Overview";
			this.overview.UseVisualStyleBackColor = true;
			this.groupBox2.Controls.Add(this.hpabsorb);
			this.groupBox2.Controls.Add(this.counteratk);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Controls.Add(this.dmgreduction);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Location = new System.Drawing.Point(330, 265);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(207, 94);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Advanced details";
			this.hpabsorb.Cursor = System.Windows.Forms.Cursors.Default;
			this.hpabsorb.Location = new System.Drawing.Point(114, 19);
			this.hpabsorb.Name = "hpabsorb";
			this.hpabsorb.ReadOnly = true;
			this.hpabsorb.Size = new System.Drawing.Size(74, 20);
			this.hpabsorb.TabIndex = 15;
			this.hpabsorb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.counteratk.Cursor = System.Windows.Forms.Cursors.Default;
			this.counteratk.Location = new System.Drawing.Point(114, 65);
			this.counteratk.Name = "counteratk";
			this.counteratk.ReadOnly = true;
			this.counteratk.Size = new System.Drawing.Size(74, 20);
			this.counteratk.TabIndex = 15;
			this.counteratk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(15, 68);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(77, 13);
			this.label19.TabIndex = 0;
			this.label19.Text = "Counterattack:";
			this.dmgreduction.Cursor = System.Windows.Forms.Cursors.Default;
			this.dmgreduction.Location = new System.Drawing.Point(114, 42);
			this.dmgreduction.Name = "dmgreduction";
			this.dmgreduction.ReadOnly = true;
			this.dmgreduction.Size = new System.Drawing.Size(74, 20);
			this.dmgreduction.TabIndex = 15;
			this.dmgreduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(15, 45);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(97, 13);
			this.label17.TabIndex = 0;
			this.label17.Text = "Damage reduction:";
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(15, 22);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(60, 13);
			this.label18.TabIndex = 0;
			this.label18.Text = "HP absorb:";
			this.detailgroup.Controls.Add(this.label14);
			this.detailgroup.Controls.Add(this.label13);
			this.detailgroup.Controls.Add(this.label12);
			this.detailgroup.Controls.Add(this.label16);
			this.detailgroup.Controls.Add(this.label11);
			this.detailgroup.Controls.Add(this.critmultiplier);
			this.detailgroup.Controls.Add(this.defreduction);
			this.detailgroup.Controls.Add(this.critchance);
			this.detailgroup.Controls.Add(this.blockchance);
			this.detailgroup.Controls.Add(this.dodgechance);
			this.detailgroup.Location = new System.Drawing.Point(8, 265);
			this.detailgroup.Name = "detailgroup";
			this.detailgroup.Size = new System.Drawing.Size(316, 120);
			this.detailgroup.TabIndex = 3;
			this.detailgroup.TabStop = false;
			this.detailgroup.Text = "Details";
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(213, 45);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(88, 13);
			this.label14.TabIndex = 16;
			this.label14.Text = "Critical Multiplier: ";
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(6, 91);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(105, 13);
			this.label13.TabIndex = 2;
			this.label13.Text = "Defense Reduction: ";
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 68);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 13);
			this.label12.TabIndex = 1;
			this.label12.Text = "Critical Chance: ";
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(6, 22);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(79, 13);
			this.label16.TabIndex = 0;
			this.label16.Text = "Block chance: ";
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(6, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 13);
			this.label11.TabIndex = 0;
			this.label11.Text = "Dodge chance: ";
			this.critmultiplier.Cursor = System.Windows.Forms.Cursors.Default;
			this.critmultiplier.Location = new System.Drawing.Point(216, 65);
			this.critmultiplier.Name = "critmultiplier";
			this.critmultiplier.ReadOnly = true;
			this.critmultiplier.Size = new System.Drawing.Size(74, 20);
			this.critmultiplier.TabIndex = 15;
			this.critmultiplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.defreduction.Cursor = System.Windows.Forms.Cursors.Default;
			this.defreduction.Location = new System.Drawing.Point(115, 88);
			this.defreduction.Name = "defreduction";
			this.defreduction.ReadOnly = true;
			this.defreduction.Size = new System.Drawing.Size(74, 20);
			this.defreduction.TabIndex = 15;
			this.defreduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.critchance.Cursor = System.Windows.Forms.Cursors.Default;
			this.critchance.Location = new System.Drawing.Point(115, 65);
			this.critchance.Name = "critchance";
			this.critchance.ReadOnly = true;
			this.critchance.Size = new System.Drawing.Size(74, 20);
			this.critchance.TabIndex = 15;
			this.critchance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.blockchance.Cursor = System.Windows.Forms.Cursors.Default;
			this.blockchance.Location = new System.Drawing.Point(115, 19);
			this.blockchance.Name = "blockchance";
			this.blockchance.ReadOnly = true;
			this.blockchance.Size = new System.Drawing.Size(74, 20);
			this.blockchance.TabIndex = 15;
			this.blockchance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.dodgechance.Cursor = System.Windows.Forms.Cursors.Default;
			this.dodgechance.Location = new System.Drawing.Point(115, 42);
			this.dodgechance.Name = "dodgechance";
			this.dodgechance.ReadOnly = true;
			this.dodgechance.Size = new System.Drawing.Size(74, 20);
			this.dodgechance.TabIndex = 15;
			this.dodgechance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ReleaseGroup.Controls.Add(this.label10);
			this.ReleaseGroup.Controls.Add(this.label9);
			this.ReleaseGroup.Controls.Add(this.label8);
			this.ReleaseGroup.Controls.Add(this.label7);
			this.ReleaseGroup.Controls.Add(this.label6);
			this.ReleaseGroup.Controls.Add(this.label5);
			this.ReleaseGroup.Controls.Add(this.label4);
			this.ReleaseGroup.Controls.Add(this.label3);
			this.ReleaseGroup.Controls.Add(this.label2);
			this.ReleaseGroup.Controls.Add(this.label1);
			this.ReleaseGroup.Controls.Add(this.windfield);
			this.ReleaseGroup.Controls.Add(this.waterfield);
			this.ReleaseGroup.Controls.Add(this.toolfield);
			this.ReleaseGroup.Controls.Add(this.taijutsufield);
			this.ReleaseGroup.Controls.Add(this.sealingfield);
			this.ReleaseGroup.Controls.Add(this.lightningfield);
			this.ReleaseGroup.Controls.Add(this.illusionfield);
			this.ReleaseGroup.Controls.Add(this.healingfield);
			this.ReleaseGroup.Controls.Add(this.firefield);
			this.ReleaseGroup.Controls.Add(this.earthfield);
			this.ReleaseGroup.Location = new System.Drawing.Point(330, 3);
			this.ReleaseGroup.Name = "ReleaseGroup";
			this.ReleaseGroup.Size = new System.Drawing.Size(207, 256);
			this.ReleaseGroup.TabIndex = 2;
			this.ReleaseGroup.TabStop = false;
			this.ReleaseGroup.Text = "Releases";
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(50, 227);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(38, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "Wind: ";
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(46, 204);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 24;
			this.label9.Text = "Water: ";
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(27, 181);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 13);
			this.label8.TabIndex = 23;
			this.label8.Text = "Ninja Tool: ";
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(38, 158);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 22;
			this.label7.Text = "Taijutsu: ";
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(40, 135);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Sealing: ";
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(32, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 20;
			this.label5.Text = "Lightning: ";
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(43, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 19;
			this.label4.Text = "Illusion: ";
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 18;
			this.label3.Text = "Healing: ";
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(58, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Fire: ";
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Earth: ";
			this.windfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.windfield.Location = new System.Drawing.Point(101, 224);
			this.windfield.Name = "windfield";
			this.windfield.ReadOnly = true;
			this.windfield.Size = new System.Drawing.Size(74, 20);
			this.windfield.TabIndex = 15;
			this.windfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.waterfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.waterfield.Location = new System.Drawing.Point(101, 201);
			this.waterfield.Name = "waterfield";
			this.waterfield.ReadOnly = true;
			this.waterfield.Size = new System.Drawing.Size(74, 20);
			this.waterfield.TabIndex = 15;
			this.waterfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.toolfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.toolfield.Location = new System.Drawing.Point(101, 178);
			this.toolfield.Name = "toolfield";
			this.toolfield.ReadOnly = true;
			this.toolfield.Size = new System.Drawing.Size(74, 20);
			this.toolfield.TabIndex = 15;
			this.toolfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.taijutsufield.Cursor = System.Windows.Forms.Cursors.Default;
			this.taijutsufield.Location = new System.Drawing.Point(101, 155);
			this.taijutsufield.Name = "taijutsufield";
			this.taijutsufield.ReadOnly = true;
			this.taijutsufield.Size = new System.Drawing.Size(74, 20);
			this.taijutsufield.TabIndex = 15;
			this.taijutsufield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.sealingfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.sealingfield.Location = new System.Drawing.Point(101, 132);
			this.sealingfield.Name = "sealingfield";
			this.sealingfield.ReadOnly = true;
			this.sealingfield.Size = new System.Drawing.Size(74, 20);
			this.sealingfield.TabIndex = 15;
			this.sealingfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.lightningfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.lightningfield.Location = new System.Drawing.Point(101, 109);
			this.lightningfield.Name = "lightningfield";
			this.lightningfield.ReadOnly = true;
			this.lightningfield.Size = new System.Drawing.Size(74, 20);
			this.lightningfield.TabIndex = 15;
			this.lightningfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.illusionfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.illusionfield.Location = new System.Drawing.Point(101, 86);
			this.illusionfield.Name = "illusionfield";
			this.illusionfield.ReadOnly = true;
			this.illusionfield.Size = new System.Drawing.Size(74, 20);
			this.illusionfield.TabIndex = 15;
			this.illusionfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.healingfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.healingfield.Location = new System.Drawing.Point(101, 63);
			this.healingfield.Name = "healingfield";
			this.healingfield.ReadOnly = true;
			this.healingfield.Size = new System.Drawing.Size(74, 20);
			this.healingfield.TabIndex = 15;
			this.healingfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.firefield.Cursor = System.Windows.Forms.Cursors.Default;
			this.firefield.Location = new System.Drawing.Point(101, 40);
			this.firefield.Name = "firefield";
			this.firefield.ReadOnly = true;
			this.firefield.Size = new System.Drawing.Size(74, 20);
			this.firefield.TabIndex = 15;
			this.firefield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.earthfield.Cursor = System.Windows.Forms.Cursors.Default;
			this.earthfield.Location = new System.Drawing.Point(101, 17);
			this.earthfield.Name = "earthfield";
			this.earthfield.ReadOnly = true;
			this.earthfield.Size = new System.Drawing.Size(74, 20);
			this.earthfield.TabIndex = 15;
			this.earthfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.overviewupdate.Enabled = false;
			this.overviewupdate.Location = new System.Drawing.Point(383, 364);
			this.overviewupdate.Name = "overviewupdate";
			this.overviewupdate.Size = new System.Drawing.Size(102, 22);
			this.overviewupdate.TabIndex = 1;
			this.overviewupdate.Text = "Update";
			this.overviewupdate.UseVisualStyleBackColor = true;
			this.overviewupdate.Click += new System.EventHandler(overviewupdate_Click);
			this.groupBox1.Controls.Add(this.oconstitution);
			this.groupBox1.Controls.Add(this.ocritical);
			this.groupBox1.Controls.Add(this.odefense);
			this.groupBox1.Controls.Add(this.oarmorbreak);
			this.groupBox1.Controls.Add(this.ohit);
			this.groupBox1.Controls.Add(this.opierce);
			this.groupBox1.Controls.Add(this.ochakra);
			this.groupBox1.Controls.Add(this.ohp);
			this.groupBox1.Controls.Add(this.osta);
			this.groupBox1.Controls.Add(this.ododge);
			this.groupBox1.Controls.Add(this.ospeed);
			this.groupBox1.Controls.Add(this.oagi);
			this.groupBox1.Controls.Add(this.oblock);
			this.groupBox1.Controls.Add(this.oatk);
			this.groupBox1.Controls.Add(this.ostr);
			this.groupBox1.Controls.Add(this.oconslabel);
			this.groupBox1.Controls.Add(this.ocriticallabel);
			this.groupBox1.Controls.Add(this.odefenselabel);
			this.groupBox1.Controls.Add(this.oarmorbreaklabel);
			this.groupBox1.Controls.Add(this.ohitlabel);
			this.groupBox1.Controls.Add(this.opiercelabel);
			this.groupBox1.Controls.Add(this.ochakralabel);
			this.groupBox1.Controls.Add(this.ohplabel);
			this.groupBox1.Controls.Add(this.ostalabel);
			this.groupBox1.Controls.Add(this.ododgelabel);
			this.groupBox1.Controls.Add(this.ospeedlabel);
			this.groupBox1.Controls.Add(this.oagilabel);
			this.groupBox1.Controls.Add(this.oblocklabel);
			this.groupBox1.Controls.Add(this.oatklabel);
			this.groupBox1.Controls.Add(this.ostrlabel);
			this.groupBox1.Location = new System.Drawing.Point(8, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(316, 256);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Character";
			this.oconstitution.Cursor = System.Windows.Forms.Cursors.Default;
			this.oconstitution.Location = new System.Drawing.Point(230, 225);
			this.oconstitution.Name = "oconstitution";
			this.oconstitution.ReadOnly = true;
			this.oconstitution.Size = new System.Drawing.Size(74, 20);
			this.oconstitution.TabIndex = 15;
			this.oconstitution.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ocritical.Cursor = System.Windows.Forms.Cursors.Default;
			this.ocritical.Location = new System.Drawing.Point(76, 225);
			this.ocritical.Name = "ocritical";
			this.ocritical.ReadOnly = true;
			this.ocritical.Size = new System.Drawing.Size(74, 20);
			this.ocritical.TabIndex = 15;
			this.ocritical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.odefense.Cursor = System.Windows.Forms.Cursors.Default;
			this.odefense.Location = new System.Drawing.Point(230, 202);
			this.odefense.Name = "odefense";
			this.odefense.ReadOnly = true;
			this.odefense.Size = new System.Drawing.Size(74, 20);
			this.odefense.TabIndex = 15;
			this.odefense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.oarmorbreak.Cursor = System.Windows.Forms.Cursors.Default;
			this.oarmorbreak.Location = new System.Drawing.Point(76, 202);
			this.oarmorbreak.Name = "oarmorbreak";
			this.oarmorbreak.ReadOnly = true;
			this.oarmorbreak.Size = new System.Drawing.Size(74, 20);
			this.oarmorbreak.TabIndex = 15;
			this.oarmorbreak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ohit.Cursor = System.Windows.Forms.Cursors.Default;
			this.ohit.Location = new System.Drawing.Point(230, 179);
			this.ohit.Name = "ohit";
			this.ohit.ReadOnly = true;
			this.ohit.Size = new System.Drawing.Size(74, 20);
			this.ohit.TabIndex = 15;
			this.ohit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.opierce.Cursor = System.Windows.Forms.Cursors.Default;
			this.opierce.Location = new System.Drawing.Point(76, 179);
			this.opierce.Name = "opierce";
			this.opierce.ReadOnly = true;
			this.opierce.Size = new System.Drawing.Size(74, 20);
			this.opierce.TabIndex = 15;
			this.opierce.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ochakra.Cursor = System.Windows.Forms.Cursors.Default;
			this.ochakra.Location = new System.Drawing.Point(230, 148);
			this.ochakra.Name = "ochakra";
			this.ochakra.ReadOnly = true;
			this.ochakra.Size = new System.Drawing.Size(74, 20);
			this.ochakra.TabIndex = 15;
			this.ochakra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ohp.Cursor = System.Windows.Forms.Cursors.Default;
			this.ohp.Location = new System.Drawing.Point(230, 125);
			this.ohp.Name = "ohp";
			this.ohp.ReadOnly = true;
			this.ohp.Size = new System.Drawing.Size(74, 20);
			this.ohp.TabIndex = 15;
			this.ohp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.osta.Cursor = System.Windows.Forms.Cursors.Default;
			this.osta.Location = new System.Drawing.Point(76, 125);
			this.osta.Name = "osta";
			this.osta.ReadOnly = true;
			this.osta.Size = new System.Drawing.Size(74, 20);
			this.osta.TabIndex = 15;
			this.osta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ododge.Cursor = System.Windows.Forms.Cursors.Default;
			this.ododge.Location = new System.Drawing.Point(230, 94);
			this.ododge.Name = "ododge";
			this.ododge.ReadOnly = true;
			this.ododge.Size = new System.Drawing.Size(74, 20);
			this.ododge.TabIndex = 15;
			this.ododge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ospeed.Cursor = System.Windows.Forms.Cursors.Default;
			this.ospeed.Location = new System.Drawing.Point(230, 71);
			this.ospeed.Name = "ospeed";
			this.ospeed.ReadOnly = true;
			this.ospeed.Size = new System.Drawing.Size(74, 20);
			this.ospeed.TabIndex = 15;
			this.ospeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.oagi.Cursor = System.Windows.Forms.Cursors.Default;
			this.oagi.Location = new System.Drawing.Point(76, 71);
			this.oagi.Name = "oagi";
			this.oagi.ReadOnly = true;
			this.oagi.Size = new System.Drawing.Size(74, 20);
			this.oagi.TabIndex = 15;
			this.oagi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.oblock.Cursor = System.Windows.Forms.Cursors.Default;
			this.oblock.Location = new System.Drawing.Point(230, 40);
			this.oblock.Name = "oblock";
			this.oblock.ReadOnly = true;
			this.oblock.Size = new System.Drawing.Size(74, 20);
			this.oblock.TabIndex = 15;
			this.oblock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.oatk.Cursor = System.Windows.Forms.Cursors.Default;
			this.oatk.Location = new System.Drawing.Point(230, 17);
			this.oatk.Name = "oatk";
			this.oatk.ReadOnly = true;
			this.oatk.Size = new System.Drawing.Size(74, 20);
			this.oatk.TabIndex = 15;
			this.oatk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ostr.Cursor = System.Windows.Forms.Cursors.Default;
			this.ostr.Location = new System.Drawing.Point(76, 17);
			this.ostr.Name = "ostr";
			this.ostr.ReadOnly = true;
			this.ostr.Size = new System.Drawing.Size(74, 20);
			this.ostr.TabIndex = 15;
			this.ostr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.oconslabel.AutoSize = true;
			this.oconslabel.Location = new System.Drawing.Point(163, 228);
			this.oconslabel.Name = "oconslabel";
			this.oconslabel.Size = new System.Drawing.Size(68, 13);
			this.oconslabel.TabIndex = 14;
			this.oconslabel.Text = "Constitution: ";
			this.ocriticallabel.AutoSize = true;
			this.ocriticallabel.Location = new System.Drawing.Point(7, 228);
			this.ocriticallabel.Name = "ocriticallabel";
			this.ocriticallabel.Size = new System.Drawing.Size(44, 13);
			this.ocriticallabel.TabIndex = 13;
			this.ocriticallabel.Text = "Critical: ";
			this.odefenselabel.AutoSize = true;
			this.odefenselabel.Location = new System.Drawing.Point(163, 205);
			this.odefenselabel.Name = "odefenselabel";
			this.odefenselabel.Size = new System.Drawing.Size(53, 13);
			this.odefenselabel.TabIndex = 12;
			this.odefenselabel.Text = "Defense: ";
			this.oarmorbreaklabel.AutoSize = true;
			this.oarmorbreaklabel.Location = new System.Drawing.Point(7, 205);
			this.oarmorbreaklabel.Name = "oarmorbreaklabel";
			this.oarmorbreaklabel.Size = new System.Drawing.Size(71, 13);
			this.oarmorbreaklabel.TabIndex = 11;
			this.oarmorbreaklabel.Text = "Armor Break: ";
			this.ohitlabel.AutoSize = true;
			this.ohitlabel.Location = new System.Drawing.Point(165, 182);
			this.ohitlabel.Name = "ohitlabel";
			this.ohitlabel.Size = new System.Drawing.Size(26, 13);
			this.ohitlabel.TabIndex = 10;
			this.ohitlabel.Text = "Hit: ";
			this.opiercelabel.AutoSize = true;
			this.opiercelabel.Location = new System.Drawing.Point(7, 182);
			this.opiercelabel.Name = "opiercelabel";
			this.opiercelabel.Size = new System.Drawing.Size(43, 13);
			this.opiercelabel.TabIndex = 9;
			this.opiercelabel.Text = "Pierce: ";
			this.ochakralabel.AutoSize = true;
			this.ochakralabel.Location = new System.Drawing.Point(163, 151);
			this.ochakralabel.Name = "ochakralabel";
			this.ochakralabel.Size = new System.Drawing.Size(47, 13);
			this.ochakralabel.TabIndex = 8;
			this.ochakralabel.Text = "Chakra: ";
			this.ohplabel.AutoSize = true;
			this.ohplabel.Location = new System.Drawing.Point(163, 128);
			this.ohplabel.Name = "ohplabel";
			this.ohplabel.Size = new System.Drawing.Size(28, 13);
			this.ohplabel.TabIndex = 7;
			this.ohplabel.Text = "HP: ";
			this.ostalabel.AutoSize = true;
			this.ostalabel.Location = new System.Drawing.Point(7, 128);
			this.ostalabel.Name = "ostalabel";
			this.ostalabel.Size = new System.Drawing.Size(51, 13);
			this.ostalabel.TabIndex = 6;
			this.ostalabel.Text = "Stamina: ";
			this.ododgelabel.AutoSize = true;
			this.ododgelabel.Location = new System.Drawing.Point(163, 97);
			this.ododgelabel.Name = "ododgelabel";
			this.ododgelabel.Size = new System.Drawing.Size(45, 13);
			this.ododgelabel.TabIndex = 5;
			this.ododgelabel.Text = "Dodge: ";
			this.ospeedlabel.AutoSize = true;
			this.ospeedlabel.Location = new System.Drawing.Point(163, 74);
			this.ospeedlabel.Name = "ospeedlabel";
			this.ospeedlabel.Size = new System.Drawing.Size(44, 13);
			this.ospeedlabel.TabIndex = 4;
			this.ospeedlabel.Text = "Speed: ";
			this.oagilabel.AutoSize = true;
			this.oagilabel.Location = new System.Drawing.Point(7, 74);
			this.oagilabel.Name = "oagilabel";
			this.oagilabel.Size = new System.Drawing.Size(40, 13);
			this.oagilabel.TabIndex = 3;
			this.oagilabel.Text = "Agility: ";
			this.oblocklabel.AutoSize = true;
			this.oblocklabel.Location = new System.Drawing.Point(163, 43);
			this.oblocklabel.Name = "oblocklabel";
			this.oblocklabel.Size = new System.Drawing.Size(40, 13);
			this.oblocklabel.TabIndex = 2;
			this.oblocklabel.Text = "Block: ";
			this.oatklabel.AutoSize = true;
			this.oatklabel.Location = new System.Drawing.Point(163, 20);
			this.oatklabel.Name = "oatklabel";
			this.oatklabel.Size = new System.Drawing.Size(41, 13);
			this.oatklabel.TabIndex = 1;
			this.oatklabel.Text = "Attack:";
			this.ostrlabel.AutoSize = true;
			this.ostrlabel.Location = new System.Drawing.Point(7, 20);
			this.ostrlabel.Name = "ostrlabel";
			this.ostrlabel.Size = new System.Drawing.Size(50, 13);
			this.ostrlabel.TabIndex = 0;
			this.ostrlabel.Text = "Strength:\r\n";
			this.MainwindowStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.MainwindowStripMenu });
			this.MainwindowStrip.Location = new System.Drawing.Point(0, 0);
			this.MainwindowStrip.Name = "MainwindowStrip";
			this.MainwindowStrip.Size = new System.Drawing.Size(552, 24);
			this.MainwindowStrip.TabIndex = 1;
			this.MainwindowStrip.Text = "Menu";
			this.MainwindowStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.MenuItem_new, this.MenuItem_open, this.MenuItem_save, this.exportBuildToolStripMenuItem, this.MenuItem_recent });
			this.MainwindowStripMenu.Name = "MainwindowStripMenu";
			this.MainwindowStripMenu.Size = new System.Drawing.Size(50, 20);
			this.MainwindowStripMenu.Text = "Menu";
			this.MenuItem_new.Name = "MenuItem_new";
			this.MenuItem_new.ShortcutKeys = System.Windows.Forms.Keys.N | System.Windows.Forms.Keys.Control;
			this.MenuItem_new.Size = new System.Drawing.Size(179, 22);
			this.MenuItem_new.Text = "New";
			this.MenuItem_new.Click += new System.EventHandler(MenuItem_new_Click);
			this.MenuItem_open.Name = "MenuItem_open";
			this.MenuItem_open.ShortcutKeys = System.Windows.Forms.Keys.O | System.Windows.Forms.Keys.Control;
			this.MenuItem_open.Size = new System.Drawing.Size(179, 22);
			this.MenuItem_open.Text = "Open";
			this.MenuItem_open.Click += new System.EventHandler(MenuItem_open_Click);
			this.MenuItem_save.Name = "MenuItem_save";
			this.MenuItem_save.ShortcutKeys = System.Windows.Forms.Keys.S | System.Windows.Forms.Keys.Control;
			this.MenuItem_save.Size = new System.Drawing.Size(179, 22);
			this.MenuItem_save.Text = "Save Build";
			this.MenuItem_save.Click += new System.EventHandler(MenuItem_save_Click);
			this.exportBuildToolStripMenuItem.Name = "exportBuildToolStripMenuItem";
			this.exportBuildToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.E | System.Windows.Forms.Keys.Control;
			this.exportBuildToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.exportBuildToolStripMenuItem.Text = "Export Build";
			this.exportBuildToolStripMenuItem.Visible = false;
			this.exportBuildToolStripMenuItem.Click += new System.EventHandler(exportBuildToolStripMenuItem_Click);
			this.MenuItem_recent.Enabled = false;
			this.MenuItem_recent.Name = "MenuItem_recent";
			this.MenuItem_recent.Size = new System.Drawing.Size(179, 22);
			this.MenuItem_recent.Text = "Recent Builds";
			this.saveFile.FileName = "unnamed";
			this.saveFile.Filter = "PNB-Dateien|*.pnb";
			this.saveFile.Title = "Save File ...";
			this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(saveFile_FileOk);
			this.openFile.Filter = "PNB-Dateien|*.pnb";
			this.openFile.Title = "Open file ...";
			this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(openFile_FileOk);
			this.AboutLabel.AutoSize = true;
			this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
			this.AboutLabel.Cursor = System.Windows.Forms.Cursors.Help;
			this.AboutLabel.Location = new System.Drawing.Point(458, 25);
			this.AboutLabel.Name = "AboutLabel";
			this.AboutLabel.Size = new System.Drawing.Size(87, 13);
			this.AboutLabel.TabIndex = 2;
			this.AboutLabel.Text = "by Psychomaster";
			this.AboutLabel.Click += new System.EventHandler(AboutLabel_Click);
			this.printDialog.UseEXDialog = true;
			this.ChineseLabel.AutoSize = true;
			this.ChineseLabel.Location = new System.Drawing.Point(425, 25);
			this.ChineseLabel.Name = "ChineseLabel";
			this.ChineseLabel.Size = new System.Drawing.Size(31, 13);
			this.ChineseLabel.TabIndex = 3;
			this.ChineseLabel.Text = "启用";
			this.ChineseLabel.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(552, 440);
			base.Controls.Add(this.ChineseLabel);
			base.Controls.Add(this.AboutLabel);
			base.Controls.Add(this.MainwindowTabs);
			base.Controls.Add(this.MainwindowStrip);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MainMenuStrip = this.MainwindowStrip;
			base.MaximizeBox = false;
			base.Name = "MainForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pockie Ninja Builder";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainForm_FormClosing);
			base.Load += new System.EventHandler(MainForm_Load);
			this.MainwindowTabs.ResumeLayout(false);
			this.Equipment.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.OutfitPose).EndInit();
			this.charactergroup.ResumeLayout(false);
			this.charactergroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.tsubook).EndInit();
			((System.ComponentModel.ISupportInitialize)this.characterlevel).EndInit();
			((System.ComponentModel.ISupportInitialize)this.EquipBackgroud).EndInit();
			this.Pet.ResumeLayout(false);
			this.Bloodline.ResumeLayout(false);
			this.BL3Box.ResumeLayout(false);
			this.BLPray3.ResumeLayout(false);
			this.BLPray3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PrayStaCount3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrayAgiCount3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrayStrCount3).EndInit();
			this.BL2Box.ResumeLayout(false);
			this.BLPray2.ResumeLayout(false);
			this.BLPray2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PrayStaCount2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrayAgiCount2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrayStrCount2).EndInit();
			this.BL1Box.ResumeLayout(false);
			this.BLPray1.ResumeLayout(false);
			this.BLPray1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PrayStaCount1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrayAgiCount1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrayStrCount1).EndInit();
			this.overview.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.detailgroup.ResumeLayout(false);
			this.detailgroup.PerformLayout();
			this.ReleaseGroup.ResumeLayout(false);
			this.ReleaseGroup.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.MainwindowStrip.ResumeLayout(false);
			this.MainwindowStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public MainForm()
		{
			ProfileManager = new PnpProfileManager();
			outfitform = new OutfitForm();
			wingform = new WingForm(this);
			bloodline = new BloodlineForm(this);
			bloodsoul = new BloodsoulForm(this);
			eqweapon = new EquipForm(this, 0);
			eqglove = new EquipForm(this, 1);
			eqring = new EquipForm(this, 2);
			eqtalisman = new EquipForm(this, 3);
			eqhelm = new EquipForm(this, 4);
			eqarmor = new EquipForm(this, 5);
			eqbelt = new EquipForm(this, 6);
			eqboots = new EquipForm(this, 7);
			zanform = new ZanpakutoForm(this);
			banform = new BankaiForm(this);
			outfitform.InitializeForm(this);
			InitializeComponent();
			Title[] titles = DataLibrary.titles;
			foreach (Title item in titles)
			{
				TitleSelect.Items.Add(item);
			}
			Pet[] pets = DataLibrary.pets;
			foreach (Pet item2 in pets)
			{
				PetComboBox.Items.Add(item2);
			}
			NinjaRank.SelectedIndex = 0;
			Text = progname;
			saved = true;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == (Keys.C | Keys.Control | Keys.Alt))
			{
				if (chinesemode)
				{
					DialogResult dialogResult = MessageBox.Show("Deactivate Developer-Mode?", "Developer Mode", MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						chinesemode = false;
					}
					loadChinese();
				}
				else
				{
					ChineseForm chineseForm = new ChineseForm(this);
					chineseForm.Show();
				}
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		public void loadChinese()
		{
			ChineseLabel.Visible = chinesemode;
			loadCurrent();
		}

		public void UpdateBuild()
		{
			PnpProfile currentProfile = ProfileManager.currentProfile;
			if (currentProfile.outfit != -1)
			{
				Outfit outfit = null;
				Outfit[] outfits = DataLibrary.outfits;
				foreach (Outfit outfit2 in outfits)
				{
					if (outfit2.id == currentProfile.outfit)
					{
						outfit = outfit2;
					}
				}
				OutfitButton.Image = outfit.image;
				OutfitButton.Text = "+" + ProfileManager.currentProfile.outfitlevel;
				overviewupdate.Enabled = true;
				Bitmap pimage = outfit.pimage;
				OutfitPose.Image = pimage;
			}
			else
			{
				OutfitButton.Image = null;
				OutfitPose.Image = null;
				OutfitButton.Text = "";
			}
			if (currentProfile.wings[0] != -1)
			{
				Wing wing = null;
				Wing[] wings = DataLibrary.wings;
				foreach (Wing wing2 in wings)
				{
					if (wing2.id == currentProfile.wings[0])
					{
						wing = wing2;
					}
				}
				WingButton.Image = wing.image;
				WingButton.Text = "+" + currentProfile.wings[1];
			}
			else
			{
				WingButton.Image = null;
				WingButton.Text = "";
			}
			if (currentProfile.weapon[0] != -1)
			{
				EquipWeapon.Image = DataLibrary.equipment[currentProfile.weapon[0]].image;
			}
			else
			{
				EquipWeapon.Image = null;
			}
			if (currentProfile.glove[0] != -1)
			{
				EquipGlove.Image = DataLibrary.equipment[currentProfile.glove[0]].image;
			}
			else
			{
				EquipGlove.Image = null;
			}
			if (currentProfile.ring[0] != -1)
			{
				EquipRing.Image = DataLibrary.equipment[currentProfile.ring[0]].image;
			}
			else
			{
				EquipRing.Image = null;
			}
			if (currentProfile.talisman[0] != -1)
			{
				EquipTalisman.Image = DataLibrary.equipment[currentProfile.talisman[0]].image;
			}
			else
			{
				EquipTalisman.Image = null;
			}
			if (currentProfile.helm[0] != -1)
			{
				EquipHelm.Image = DataLibrary.equipment[currentProfile.helm[0]].image;
			}
			else
			{
				EquipHelm.Image = null;
			}
			if (currentProfile.armor[0] != -1)
			{
				EquipArmor.Image = DataLibrary.equipment[currentProfile.armor[0]].image;
			}
			else
			{
				EquipArmor.Image = null;
			}
			if (currentProfile.belt[0] != -1)
			{
				EquipBelt.Image = DataLibrary.equipment[currentProfile.belt[0]].image;
			}
			else
			{
				EquipBelt.Image = null;
			}
			if (currentProfile.boots[0] != -1)
			{
				EquipBoot.Image = DataLibrary.equipment[currentProfile.boots[0]].image;
			}
			else
			{
				EquipBoot.Image = null;
			}
			if (currentProfile.bloodline1 != -1)
			{
				BL1.BackgroundImage = DataLibrary.bloodlines[currentProfile.bloodline1].image;
			}
			else
			{
				BL1.BackgroundImage = null;
			}
			if (currentProfile.bloodline2 != -1)
			{
				BL2.BackgroundImage = DataLibrary.bloodlines[currentProfile.bloodline2].image;
			}
			else
			{
				BL2.BackgroundImage = null;
			}
			if (currentProfile.bloodline3 != -1)
			{
				BL3.BackgroundImage = DataLibrary.bloodlines[currentProfile.bloodline3].image;
			}
			else
			{
				BL3.BackgroundImage = null;
			}
			if (currentProfile.bloodsoul1[0] != -1)
			{
				BS11.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul1[0]][currentProfile.bloodsoullvl1[0]].image;
				BS11Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul1[0]][currentProfile.bloodsoullvl1[0]].name;
			}
			else
			{
				BS11.BackgroundImage = null;
				BS11Label.Text = "-";
			}
			if (currentProfile.bloodsoul1[1] != -1)
			{
				BS12.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul1[1]][currentProfile.bloodsoullvl1[1]].image;
				BS12Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul1[1]][currentProfile.bloodsoullvl1[1]].name;
			}
			else
			{
				BS12.BackgroundImage = null;
				BS12Label.Text = "-";
			}
			if (currentProfile.bloodsoul1[2] != -1)
			{
				BS13.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul1[2]][currentProfile.bloodsoullvl1[2]].image;
				BS13Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul1[2]][currentProfile.bloodsoullvl1[2]].name;
			}
			else
			{
				BS13.BackgroundImage = null;
				BS13Label.Text = "-";
			}
			if (currentProfile.bloodsoul1[3] != -1)
			{
				BS14.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul1[3]][currentProfile.bloodsoullvl1[3]].image;
				BS14Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul1[3]][currentProfile.bloodsoullvl1[3]].name;
			}
			else
			{
				BS14.BackgroundImage = null;
				BS14Label.Text = "-";
			}
			if (currentProfile.bloodsoul1[4] != -1)
			{
				BS15.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul1[4]][currentProfile.bloodsoullvl1[4]].image;
				BS15Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul1[4]][currentProfile.bloodsoullvl1[4]].name;
			}
			else
			{
				BS15.BackgroundImage = null;
				BS15Label.Text = "-";
			}
			if (currentProfile.bloodsoul2[0] != -1)
			{
				BS21.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul2[0]][currentProfile.bloodsoullvl2[0]].image;
				BS21Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul2[0]][currentProfile.bloodsoullvl2[0]].name;
			}
			else
			{
				BS21.BackgroundImage = null;
				BS21Label.Text = "-";
			}
			if (currentProfile.bloodsoul2[1] != -1)
			{
				BS22.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul2[1]][currentProfile.bloodsoullvl2[1]].image;
				BS22Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul2[1]][currentProfile.bloodsoullvl2[1]].name;
			}
			else
			{
				BS22.BackgroundImage = null;
				BS22Label.Text = "-";
			}
			if (currentProfile.bloodsoul2[2] != -1)
			{
				BS23.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul2[2]][currentProfile.bloodsoullvl2[2]].image;
				BS23Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul2[2]][currentProfile.bloodsoullvl2[2]].name;
			}
			else
			{
				BS23.BackgroundImage = null;
				BS23Label.Text = "-";
			}
			if (currentProfile.bloodsoul2[3] != -1)
			{
				BS24.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul2[3]][currentProfile.bloodsoullvl2[3]].image;
				BS24Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul2[3]][currentProfile.bloodsoullvl2[3]].name;
			}
			else
			{
				BS24.BackgroundImage = null;
				BS24Label.Text = "-";
			}
			if (currentProfile.bloodsoul2[4] != -1)
			{
				BS25.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul2[4]][currentProfile.bloodsoullvl2[4]].image;
				BS25Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul2[4]][currentProfile.bloodsoullvl2[4]].name;
			}
			else
			{
				BS25.BackgroundImage = null;
				BS25Label.Text = "-";
			}
			if (currentProfile.bloodsoul3[0] != -1)
			{
				BS31.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul3[0]][currentProfile.bloodsoullvl3[0]].image;
				BS31Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul3[0]][currentProfile.bloodsoullvl3[0]].name;
			}
			else
			{
				BS31.BackgroundImage = null;
				BS31Label.Text = "-";
			}
			if (currentProfile.bloodsoul3[1] != -1)
			{
				BS32.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul3[1]][currentProfile.bloodsoullvl3[1]].image;
				BS32Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul3[1]][currentProfile.bloodsoullvl3[1]].name;
			}
			else
			{
				BS32.BackgroundImage = null;
				BS32Label.Text = "-";
			}
			if (currentProfile.bloodsoul3[2] != -1)
			{
				BS33.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul3[2]][currentProfile.bloodsoullvl3[2]].image;
				BS33Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul3[2]][currentProfile.bloodsoullvl3[2]].name;
			}
			else
			{
				BS33.BackgroundImage = null;
				BS33Label.Text = "-";
			}
			if (currentProfile.bloodsoul3[3] != -1)
			{
				BS34.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul3[3]][currentProfile.bloodsoullvl3[3]].image;
				BS34Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul3[3]][currentProfile.bloodsoullvl3[3]].name;
			}
			else
			{
				BS34.BackgroundImage = null;
				BS34Label.Text = "-";
			}
			if (currentProfile.bloodsoul3[4] != -1)
			{
				BS35.BackgroundImage = DataLibrary.bloodsouls[currentProfile.bloodsoul3[4]][currentProfile.bloodsoullvl3[4]].image;
				BS35Label.Text = DataLibrary.bloodsouls[currentProfile.bloodsoul3[4]][currentProfile.bloodsoullvl3[4]].name;
			}
			else
			{
				BS35.BackgroundImage = null;
				BS35Label.Text = "-";
			}
			List<int> list = new List<int>();
			SetFlowControl.Controls.Clear();
			if (currentProfile.weapon[0] != -1 && DataLibrary.equipment[currentProfile.weapon[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.weapon[0]].set);
			}
			if (currentProfile.glove[0] != -1 && DataLibrary.equipment[currentProfile.glove[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.glove[0]].set);
			}
			if (currentProfile.helm[0] != -1 && DataLibrary.equipment[currentProfile.helm[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.helm[0]].set);
			}
			if (currentProfile.armor[0] != -1 && DataLibrary.equipment[currentProfile.armor[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.armor[0]].set);
			}
			if (currentProfile.belt[0] != -1 && DataLibrary.equipment[currentProfile.belt[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.belt[0]].set);
			}
			if (currentProfile.boots[0] != -1 && DataLibrary.equipment[currentProfile.boots[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.boots[0]].set);
			}
			if (currentProfile.ring[0] != -1 && DataLibrary.equipment[currentProfile.ring[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.ring[0]].set);
			}
			if (currentProfile.talisman[0] != -1 && DataLibrary.equipment[currentProfile.talisman[0]].set != 0)
			{
				list.Add(DataLibrary.equipment[currentProfile.talisman[0]].set);
			}
			if (list.Count > 0)
			{
				List<int[]> list2 = new List<int[]>();
				for (int k = 0; k < list.Count; k++)
				{
					int num = -1;
					for (int l = 0; l < list2.Count; l++)
					{
						if (list2[l][0] == list[k])
						{
							num = l;
						}
					}
					if (num != -1)
					{
						list2[num][1]++;
						continue;
					}
					list2.Add(new int[2]
					{
						list[k],
						1
					});
				}
				for (int m = 0; m < list2.Count; m++)
				{
					GroupBox groupBox = new GroupBox();
					groupBox.Width = 140;
					groupBox.Height = 73;
					groupBox.Text = DataLibrary.sets[list2[m][0]].name + " Set";
					groupBox.ForeColor = Color.Green;
					groupBox.Font = new Font(groupBox.Font, FontStyle.Bold);
					int num2 = 0;
					for (int n = 0; n < 8; n++)
					{
						if (DataLibrary.sets[list2[m][0]].bonus[n] != null)
						{
							Label label = new Label();
							label.Font = new Font(label.Font, FontStyle.Regular);
							label.Text = n + 1 + " Parts: " + DataLibrary.sets[list2[m][0]].bonus[n].ToString();
							if (n >= list2[m][1])
							{
								label.ForeColor = Color.Gray;
							}
							else
							{
								label.ForeColor = Color.Black;
							}
							label.Left = 5;
							label.Width = 140;
							label.Height = 13;
							label.Top = 14 + 14 * num2;
							groupBox.Controls.Add(label);
							num2++;
						}
					}
					SetFlowControl.Controls.Add(groupBox);
				}
			}
			if (currentProfile.title != -1)
			{
				EquipTitle.Image = DataLibrary.titles[currentProfile.title].image;
			}
			else
			{
				EquipTitle.Image = Resources.EquipTitle;
			}
			if (currentProfile.pet != -1)
			{
				EquipPet.Image = DataLibrary.pets[currentProfile.pet].image;
			}
			else
			{
				EquipPet.Image = null;
			}
			saved = false;
			Text = currentProfile.filename + "* - " + progname;
		}

		private Values getValCopy(Values val, int i)
		{
			switch (val.GetType().Name)
			{
			case "Strength":
				return new Strength(i);
			case "Agility":
				return new Agility(i);
			case "Stamina":
				return new Stamina(i);
			case "ArmorBreak":
				return new ArmorBreak(i);
			case "Block":
				return new Block(i);
			case "Chakra":
				return new Chakra(i);
			case "Constitution":
				return new Constitution(i);
			case "Critical":
				return new Critical(i);
			case "Defense":
				return new Defense(i);
			case "Dodge":
				return new Dodge(i);
			case "Hit":
				return new Hit(i);
			case "HP":
				return new HP(i);
			case "MaxAtk":
				return new MaxAtk(i);
			case "MinAtk":
				return new MinAtk(i);
			case "PAtk":
				return new PAtk(i);
			case "PChakra":
				return new PChakra(i);
			case "PHP":
				return new PHP(i);
			case "Pierce":
				return new Pierce(i);
			case "Speed":
				return new Speed(i);
			case "EArmorBreak":
				return new EArmorBreak(i);
			case "EBlock":
				return new EBlock(i);
			case "EConstitution":
				return new EConstitution(i);
			case "ECritical":
				return new ECritical(i);
			case "EDefense":
				return new EDefense(i);
			case "EDodge":
				return new EDodge(i);
			case "EHit":
				return new EHit(i);
			case "EPierce":
				return new EPierce(i);
			case "Earth":
				return new Earth(i);
			case "Fire":
				return new Fire(i);
			case "FiveElement":
				return new FiveElement(i);
			case "Healing":
				return new Healing(i);
			case "Illusion":
				return new Illusion(i);
			case "Lightning":
				return new Lightning(i);
			case "Sealing":
				return new Sealing(i);
			case "Taijutsu":
				return new Taijutsu(i);
			case "Tool":
				return new Tool(i);
			case "Water":
				return new Water(i);
			case "Wind":
				return new Wind(i);
			default:
				return new Values();
			}
		}

		private Values getValClass(int valnum, int val)
		{
			switch (valnum)
			{
			case 0:
				return new Strength(val);
			case 1:
				return new Agility(val);
			case 2:
				return new Stamina(val);
			case 3:
				return new PAtk(val);
			case 4:
				return new MinAtk(val);
			case 5:
				return new MaxAtk(val);
			case 6:
				return new ArmorBreak(val);
			case 7:
				return new Hit(val);
			case 8:
				return new Speed(val);
			case 9:
				return new Dodge(val);
			case 10:
				return new HP(val);
			case 11:
				return new PHP(val);
			case 12:
				return new Chakra(val);
			case 13:
				return new PChakra(val);
			case 14:
				return new Critical(val);
			case 15:
				return new Constitution(val);
			case 16:
				return new Block(val);
			case 17:
				return new Pierce(val);
			case 18:
				return new Defense(val);
			case 19:
				return new EBlock(val);
			case 20:
				return new EPierce(val);
			case 21:
				return new EConstitution(val);
			case 22:
				return new ECritical(val);
			case 23:
				return new EDodge(val);
			case 24:
				return new EHit(val);
			case 25:
				return new EDefense(val);
			case 26:
				return new EArmorBreak(val);
			default:
				return null;
			}
		}

		public int[] getStatcollection()
		{
			PnpProfile currentProfile = ProfileManager.currentProfile;
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 0;
			int num8 = 0;
			int num9 = 0;
			int num10 = 0;
			int num11 = 0;
			int num12 = 0;
			int num13 = 0;
			int num14 = 0;
			int num15 = 0;
			int num16 = 0;
			int num17 = 0;
			int num18 = 0;
			int num19 = 0;
			int num20 = 0;
			int num21 = 0;
			int num22 = 0;
			int num23 = 0;
			int num24 = 0;
			int num25 = 0;
			int num26 = 0;
			int num27 = 0;
			int num28 = 0;
			int num29 = 0;
			int num30 = 0;
			int num31 = 0;
			int num32 = 0;
			int num33 = 0;
			int num34 = 0;
			int num35 = 0;
			int num36 = 0;
			int num37 = 0;
			int num38 = 0;
			int num39 = 0;
			int num40 = 0;
			int num41 = 0;
			int num42 = 0;
			int num43 = 0;
			int num44 = 0;
			LinkedList<Values> linkedList = new LinkedList<Values>();
			num = currentProfile.level;
			linkedList.AddLast(new HP(200 + num * 20));
			linkedList.AddLast(new Chakra(200 + num * 20));
			if (currentProfile.village != -1)
			{
				switch (currentProfile.village)
				{
				case 0:
					linkedList.AddLast(new Fire(50));
					break;
				case 1:
					linkedList.AddLast(new Wind(50));
					break;
				case 2:
					linkedList.AddLast(new Lightning(50));
					break;
				case 3:
					linkedList.AddLast(new Water(50));
					break;
				case 4:
					linkedList.AddLast(new Earth(50));
					break;
				}
			}
			if (currentProfile.tsunadebook > 0)
			{
				linkedList.AddLast(new HP((currentProfile.tsunadebook == 3) ? 550 : ((currentProfile.tsunadebook == 2) ? 400 : 200)));
			}
			if (currentProfile.title > -1)
			{
				Values[] values = DataLibrary.titles[currentProfile.title].values;
				foreach (Values value in values)
				{
					linkedList.AddLast(value);
				}
			}
			linkedList.AddLast(new HP(DataLibrary.ninjarank[currentProfile.ninjarank]));
			if (currentProfile.outfit != -1)
			{
				Outfit outfit = DataLibrary.outfits[currentProfile.outfit];
				linkedList.AddLast(new Strength(outfit.str_init + (int)((double)currentProfile.outfitlevel * 8.0 * (outfit.str_mul_init + currentProfile.outfitstr))));
				linkedList.AddLast(new Agility(outfit.agi_init + (int)((double)currentProfile.outfitlevel * 8.0 * (outfit.agi_mul_init + currentProfile.outfitagi))));
				linkedList.AddLast(new Stamina(outfit.sta_init + (int)((double)currentProfile.outfitlevel * 8.0 * (outfit.sta_mul_init + currentProfile.outfitsta))));
				linkedList.AddLast(new Strength((int)((double)num * (outfit.str_mul_init + currentProfile.outfitstr))));
				linkedList.AddLast(new Agility((int)((double)num * (outfit.agi_mul_init + currentProfile.outfitagi))));
				linkedList.AddLast(new Stamina((int)((double)num * (outfit.sta_mul_init + currentProfile.outfitsta))));
				num39 = outfit.bmv_str;
				num40 = outfit.bmv_agi;
				num41 = outfit.bmv_sta;
				int num45 = 0;
				if (currentProfile.outfitstr == 0.3)
				{
					num45++;
				}
				if (currentProfile.outfitagi == 0.3)
				{
					num45++;
				}
				if (currentProfile.outfitsta == 0.3)
				{
					num45++;
				}
				if (outfit.release.Equals("Earth"))
				{
					int val;
					switch (num45)
					{
					default:
						val = 150;
						break;
					case 2:
						val = 200;
						break;
					case 3:
						val = 300;
						break;
					}
					linkedList.AddLast(new Earth(val));
				}
				else if (outfit.release.Equals("Fire"))
				{
					int val2;
					switch (num45)
					{
					default:
						val2 = 150;
						break;
					case 2:
						val2 = 200;
						break;
					case 3:
						val2 = 300;
						break;
					}
					linkedList.AddLast(new Fire(val2));
				}
				else if (outfit.release.Equals("Healing"))
				{
					int val3;
					switch (num45)
					{
					default:
						val3 = 150;
						break;
					case 2:
						val3 = 200;
						break;
					case 3:
						val3 = 300;
						break;
					}
					linkedList.AddLast(new Healing(val3));
				}
				else if (outfit.release.Equals("Illusion"))
				{
					int val4;
					switch (num45)
					{
					default:
						val4 = 150;
						break;
					case 2:
						val4 = 200;
						break;
					case 3:
						val4 = 300;
						break;
					}
					linkedList.AddLast(new Illusion(val4));
				}
				else if (outfit.release.Equals("Lightning"))
				{
					int val5;
					switch (num45)
					{
					default:
						val5 = 150;
						break;
					case 2:
						val5 = 200;
						break;
					case 3:
						val5 = 300;
						break;
					}
					linkedList.AddLast(new Lightning(val5));
				}
				else if (outfit.release.Equals("Sealing"))
				{
					int val6;
					switch (num45)
					{
					default:
						val6 = 150;
						break;
					case 2:
						val6 = 200;
						break;
					case 3:
						val6 = 300;
						break;
					}
					linkedList.AddLast(new Sealing(val6));
				}
				else if (outfit.release.Equals("Taijutsu"))
				{
					int val7;
					switch (num45)
					{
					default:
						val7 = 150;
						break;
					case 2:
						val7 = 200;
						break;
					case 3:
						val7 = 300;
						break;
					}
					linkedList.AddLast(new Taijutsu(val7));
				}
				else if (outfit.release.Equals("Tool"))
				{
					int val8;
					switch (num45)
					{
					default:
						val8 = 150;
						break;
					case 2:
						val8 = 200;
						break;
					case 3:
						val8 = 300;
						break;
					}
					linkedList.AddLast(new Tool(val8));
				}
				else if (outfit.release.Equals("Water"))
				{
					int val9;
					switch (num45)
					{
					default:
						val9 = 150;
						break;
					case 2:
						val9 = 200;
						break;
					case 3:
						val9 = 300;
						break;
					}
					linkedList.AddLast(new Water(val9));
				}
				else if (outfit.release.Equals("Wind"))
				{
					int val10;
					switch (num45)
					{
					default:
						val10 = 150;
						break;
					case 2:
						val10 = 200;
						break;
					case 3:
						val10 = 300;
						break;
					}
					linkedList.AddLast(new Wind(val10));
				}
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
				int[] array3 = array2;
				int num46 = 0;
				for (int j = array[0]; j < array[1]; j++)
				{
					if (currentProfile.record[j] == 1)
					{
						num46++;
						array3[0] += DataLibrary.outfits[j].record[0];
						array3[1] += DataLibrary.outfits[j].record[1];
						array3[2] += DataLibrary.outfits[j].record[2];
					}
				}
				linkedList.AddLast(new Strength(array3[0]));
				linkedList.AddLast(new Agility(array3[1]));
				linkedList.AddLast(new Stamina(array3[2]));
				Values[] values = DataLibrary.records[(num46 / 5 > 12) ? 12 : (num46 / 5)];
				foreach (Values value2 in values)
				{
					linkedList.AddLast(value2);
				}
			}
			if (currentProfile.wings[0] != -1)
			{
				Wing wing = null;
				Wing[] wings = DataLibrary.wings;
				foreach (Wing wing2 in wings)
				{
					if (wing2.id == currentProfile.wings[0])
					{
						wing = wing2;
					}
				}
				Values[] values = wing.values[currentProfile.wings[1]];
				foreach (Values value3 in values)
				{
					linkedList.AddLast(value3);
				}
				if (wing.bonus != -1)
				{
					switch (currentProfile.wings[2])
					{
					case 0:
						linkedList.AddLast(new EHit(currentProfile.wings[3]));
						break;
					case 1:
						linkedList.AddLast(new EPierce(currentProfile.wings[3]));
						break;
					case 2:
						linkedList.AddLast(new EArmorBreak(currentProfile.wings[3]));
						break;
					case 3:
						linkedList.AddLast(new EConstitution(currentProfile.wings[3]));
						break;
					case 4:
						linkedList.AddLast(new EDefense(currentProfile.wings[3]));
						break;
					case 5:
						linkedList.AddLast(new EDodge(currentProfile.wings[3]));
						break;
					case 6:
						linkedList.AddLast(new EBlock(currentProfile.wings[3]));
						break;
					case 7:
						linkedList.AddLast(new ECritical(currentProfile.wings[3]));
						break;
					}
				}
			}
			for (int k = 0; k < 18; k++)
			{
				if (currentProfile.zantype[k] != -1)
				{
					linkedList.AddLast(getValClass(currentProfile.zantype[k], currentProfile.zanval[k]));
				}
			}
			if (currentProfile.ban1[0] == 1)
			{
				Values[] values = DataLibrary.bankaistats[0][currentProfile.ban1[17] - 1];
				foreach (Values value4 in values)
				{
					linkedList.AddLast(value4);
				}
			}
			if (currentProfile.ban2[0] == 1)
			{
				Values[] values = DataLibrary.bankaistats[1][currentProfile.ban2[17] - 1];
				foreach (Values value5 in values)
				{
					linkedList.AddLast(value5);
				}
			}
			if (currentProfile.ban3[0] == 1)
			{
				Values[] values = DataLibrary.bankaistats[2][currentProfile.ban3[17] - 1];
				foreach (Values value6 in values)
				{
					linkedList.AddLast(value6);
				}
			}
			if (currentProfile.ban1[1] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[1]].value, (currentProfile.ban1[2] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[1]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[1]].value.value));
			}
			if (currentProfile.ban1[3] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[3]].value, (currentProfile.ban1[4] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[3]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[3]].value.value));
			}
			if (currentProfile.ban1[5] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[5]].value, (currentProfile.ban1[6] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[5]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[5]].value.value));
			}
			if (currentProfile.ban1[7] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[7]].value, (currentProfile.ban1[8] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[7]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[7]].value.value));
			}
			if (currentProfile.ban1[9] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[9]].value, (currentProfile.ban1[10] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[9]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[9]].value.value));
			}
			if (currentProfile.ban1[11] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[11]].value, (currentProfile.ban1[12] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[11]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[11]].value.value));
			}
			if (currentProfile.ban1[13] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[13]].value, (currentProfile.ban1[14] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[13]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[13]].value.value));
			}
			if (currentProfile.ban1[15] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban1[15]].value, (currentProfile.ban1[16] - 1) * DataLibrary.bankaicrystal[currentProfile.ban1[15]].growth + DataLibrary.bankaicrystal[currentProfile.ban1[15]].value.value));
			}
			if (currentProfile.ban2[1] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[1]].value, (currentProfile.ban2[2] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[1]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[1]].value.value));
			}
			if (currentProfile.ban2[3] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[3]].value, (currentProfile.ban2[4] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[3]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[3]].value.value));
			}
			if (currentProfile.ban2[5] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[5]].value, (currentProfile.ban2[6] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[5]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[5]].value.value));
			}
			if (currentProfile.ban2[7] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[7]].value, (currentProfile.ban2[8] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[7]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[7]].value.value));
			}
			if (currentProfile.ban2[9] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[9]].value, (currentProfile.ban2[10] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[9]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[9]].value.value));
			}
			if (currentProfile.ban2[11] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[11]].value, (currentProfile.ban2[12] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[11]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[11]].value.value));
			}
			if (currentProfile.ban2[13] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[13]].value, (currentProfile.ban2[14] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[13]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[13]].value.value));
			}
			if (currentProfile.ban2[15] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban2[15]].value, (currentProfile.ban2[16] - 1) * DataLibrary.bankaicrystal[currentProfile.ban2[15]].growth + DataLibrary.bankaicrystal[currentProfile.ban2[15]].value.value));
			}
			if (currentProfile.ban3[1] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[1]].value, (currentProfile.ban3[2] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[1]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[1]].value.value));
			}
			if (currentProfile.ban3[3] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[3]].value, (currentProfile.ban3[4] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[3]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[3]].value.value));
			}
			if (currentProfile.ban3[5] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[5]].value, (currentProfile.ban3[6] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[5]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[5]].value.value));
			}
			if (currentProfile.ban3[7] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[7]].value, (currentProfile.ban3[8] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[7]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[7]].value.value));
			}
			if (currentProfile.ban3[9] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[9]].value, (currentProfile.ban3[10] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[9]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[9]].value.value));
			}
			if (currentProfile.ban3[11] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[11]].value, (currentProfile.ban3[12] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[11]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[11]].value.value));
			}
			if (currentProfile.ban3[13] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[13]].value, (currentProfile.ban3[14] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[13]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[13]].value.value));
			}
			if (currentProfile.ban3[15] >= 0)
			{
				linkedList.AddLast(getValCopy(DataLibrary.bankaicrystal[currentProfile.ban3[15]].value, (currentProfile.ban3[16] - 1) * DataLibrary.bankaicrystal[currentProfile.ban3[15]].growth + DataLibrary.bankaicrystal[currentProfile.ban3[15]].value.value));
			}
			List<int> list = new List<int>();
			if (currentProfile.weapon[0] != -1)
			{
				linkedList.AddLast(new MinAtk(DataLibrary.equipment[currentProfile.weapon[0]].attack[0]));
				linkedList.AddLast(new MaxAtk(DataLibrary.equipment[currentProfile.weapon[0]].attack[1]));
				if (DataLibrary.equipment[currentProfile.weapon[0]].bonus != null)
				{
					Values[] values = DataLibrary.equipment[currentProfile.weapon[0]].bonus;
					foreach (Values value7 in values)
					{
						linkedList.AddLast(value7);
					}
				}
				if (DataLibrary.equipment[currentProfile.weapon[0]].set != 0)
				{
					list.Add(DataLibrary.equipment[currentProfile.weapon[0]].set);
				}
				if (currentProfile.weapon[1] != -1)
				{
					linkedList.AddLast(getValClass(currentProfile.weapon[1], currentProfile.weapon[2]));
				}
				if (currentProfile.weapon[3] != -1)
				{
					linkedList.AddLast(getValClass(currentProfile.weapon[3], currentProfile.weapon[4]));
				}
				if (currentProfile.weapon[5] != -1)
				{
					linkedList.AddLast(getValClass(currentProfile.weapon[5], currentProfile.weapon[6]));
				}
				if (currentProfile.weapon[7] != -1)
				{
					linkedList.AddLast(getValClass(currentProfile.weapon[7], currentProfile.weapon[8]));
				}
				if (currentProfile.weapon[9] != -1)
				{
					Values[] values = DataLibrary.gems[currentProfile.weapon[9]].values;
					foreach (Values value8 in values)
					{
						linkedList.AddLast(value8);
					}
				}
				if (currentProfile.weapon[10] != -1)
				{
					Values[] values = DataLibrary.gems[currentProfile.weapon[10]].values;
					foreach (Values value9 in values)
					{
						linkedList.AddLast(value9);
					}
				}
				if (currentProfile.weapon[11] != -1)
				{
					Values[] values = DataLibrary.gems[currentProfile.weapon[11]].values;
					foreach (Values value10 in values)
					{
						linkedList.AddLast(value10);
					}
				}
				linkedList.AddLast(new MinAtk((int)((double)DataLibrary.equipment[currentProfile.weapon[0]].attack[0] * DataLibrary.inscription[currentProfile.weapon[12]])));
				linkedList.AddLast(new MaxAtk((int)((double)DataLibrary.equipment[currentProfile.weapon[0]].attack[1] * DataLibrary.inscription[currentProfile.weapon[12]])));
				linkedList.AddLast(new MinAtk((int)Math.Round((double)DataLibrary.equipment[currentProfile.weapon[0]].attack[0] * DataLibrary.enhancementweapon[currentProfile.weapon[13]][0], 0)));
				linkedList.AddLast(new MaxAtk((int)Math.Round((double)DataLibrary.equipment[currentProfile.weapon[0]].attack[1] * DataLibrary.enhancementweapon[currentProfile.weapon[13]][1], 0)));
				if (currentProfile.weapon[14] != -1)
				{
					Values[] values = DataLibrary.enchantments[currentProfile.weapon[14]].values;
					foreach (Values value11 in values)
					{
						linkedList.AddLast(value11);
					}
				}
			}
			int[][] array4 = new int[7][] { currentProfile.glove, currentProfile.ring, currentProfile.talisman, currentProfile.helm, currentProfile.armor, currentProfile.belt, currentProfile.boots };
			int[][] array5 = array4;
			foreach (int[] array6 in array5)
			{
				if (array6[0] == -1)
				{
					continue;
				}
				linkedList.AddLast(new Defense(DataLibrary.equipment[array6[0]].defense));
				if (DataLibrary.equipment[array6[0]].bonus != null)
				{
					Values[] values = DataLibrary.equipment[array6[0]].bonus;
					foreach (Values value12 in values)
					{
						linkedList.AddLast(value12);
					}
				}
				if (DataLibrary.equipment[array6[0]].set != 0)
				{
					list.Add(DataLibrary.equipment[array6[0]].set);
				}
				if (array6[1] != -1)
				{
					linkedList.AddLast(getValClass(array6[1], array6[2]));
				}
				if (array6[3] != -1)
				{
					linkedList.AddLast(getValClass(array6[3], array6[4]));
				}
				if (array6[5] != -1)
				{
					linkedList.AddLast(getValClass(array6[5], array6[6]));
				}
				if (array6[7] != -1)
				{
					linkedList.AddLast(getValClass(array6[7], array6[8]));
				}
				if (array6[9] != -1)
				{
					Values[] values = DataLibrary.gems[array6[9]].values;
					foreach (Values value13 in values)
					{
						linkedList.AddLast(value13);
					}
				}
				if (array6[10] != -1)
				{
					Values[] values = DataLibrary.gems[array6[10]].values;
					foreach (Values value14 in values)
					{
						linkedList.AddLast(value14);
					}
				}
				if (array6[11] != -1)
				{
					Values[] values = DataLibrary.gems[array6[11]].values;
					foreach (Values value15 in values)
					{
						linkedList.AddLast(value15);
					}
				}
				linkedList.AddLast(new Defense((int)((double)DataLibrary.equipment[array6[0]].defense * DataLibrary.inscription[array6[12]])));
				linkedList.AddLast(new HP(DataLibrary.enhancementgear[(((DataLibrary.equipment[array6[0]].vlevel != 0) ? DataLibrary.equipment[array6[0]].vlevel : DataLibrary.equipment[array6[0]].level) - 1) / 5][array6[13]]));
				if (array6[14] != -1)
				{
					Values[] values = DataLibrary.enchantments[array6[14]].values;
					foreach (Values value16 in values)
					{
						linkedList.AddLast(value16);
					}
				}
			}
			if (currentProfile.forge[0] != -1)
			{
				linkedList.AddLast(new MinAtk(DataLibrary.forgeatk[(DataLibrary.equipment[currentProfile.weapon[0]].level - 30) / 10][currentProfile.forge[0]][0]));
			}
			if (currentProfile.forge[0] != -1)
			{
				linkedList.AddLast(new MaxAtk(DataLibrary.forgeatk[(DataLibrary.equipment[currentProfile.weapon[0]].level - 30) / 10][currentProfile.forge[0]][1]));
			}
			if (currentProfile.forge[2] != -1)
			{
				linkedList.AddLast(new Defense(DataLibrary.forgedef[1][(DataLibrary.equipment[currentProfile.glove[0]].level - 30) / 10][currentProfile.forge[2]]));
			}
			if (currentProfile.forge[8] != -1)
			{
				linkedList.AddLast(new Defense(DataLibrary.forgedef[4][(DataLibrary.equipment[currentProfile.helm[0]].level - 30) / 10][currentProfile.forge[8]]));
			}
			if (currentProfile.forge[10] != -1)
			{
				linkedList.AddLast(new Defense(DataLibrary.forgedef[5][(DataLibrary.equipment[currentProfile.armor[0]].level - 30) / 10][currentProfile.forge[10]]));
			}
			if (currentProfile.forge[12] != -1)
			{
				linkedList.AddLast(new Defense(DataLibrary.forgedef[6][(DataLibrary.equipment[currentProfile.belt[0]].level - 30) / 10][currentProfile.forge[12]]));
			}
			if (currentProfile.forge[14] != -1)
			{
				linkedList.AddLast(new Defense(DataLibrary.forgedef[7][(DataLibrary.equipment[currentProfile.boots[0]].level - 30) / 10][currentProfile.forge[14]]));
			}
			if (currentProfile.forge[1] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[1]].values[0]);
			}
			if (currentProfile.forge[3] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[3]].values[0]);
			}
			if (currentProfile.forge[5] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[5]].values[0]);
			}
			if (currentProfile.forge[7] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[7]].values[0]);
			}
			if (currentProfile.forge[9] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[9]].values[0]);
			}
			if (currentProfile.forge[11] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[11]].values[0]);
			}
			if (currentProfile.forge[13] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[13]].values[0]);
			}
			if (currentProfile.forge[15] != -1)
			{
				linkedList.AddLast(DataLibrary.gems[currentProfile.forge[15]].values[0]);
			}
			if (list.Count > 0)
			{
				List<int[]> list2 = new List<int[]>();
				for (int m = 0; m < list.Count; m++)
				{
					int num47 = -1;
					for (int n = 0; n < list2.Count; n++)
					{
						if (list2[n][0] == list[m])
						{
							num47 = n;
						}
					}
					if (num47 != -1)
					{
						list2[num47][1]++;
						continue;
					}
					list2.Add(new int[2]
					{
						list[m],
						1
					});
				}
				for (int num48 = 0; num48 < list2.Count; num48++)
				{
					for (int num49 = 0; num49 < list2[num48][1]; num49++)
					{
						if (DataLibrary.sets[list2[num48][0]].bonus[num49] != null)
						{
							linkedList.AddLast(DataLibrary.sets[list2[num48][0]].bonus[num49]);
						}
					}
				}
			}
			if (currentProfile.bloodline1 != -1)
			{
				int level = DataLibrary.bloodlines[currentProfile.bloodline1].level;
				int num50 = ((level >= 36) ? ((level < 51) ? 1 : ((level < 71) ? 2 : ((level < 81) ? 3 : ((level < 91) ? 4 : 5)))) : 0);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline1].str);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline1].agi);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline1].sta);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline1].release);
				Values[] values = DataLibrary.bloodlines[currentProfile.bloodline1].values;
				foreach (Values value17 in values)
				{
					linkedList.AddLast(value17);
				}
				linkedList.AddLast(new Strength(DataLibrary.pray[num50][currentProfile.prayerstr1]));
				linkedList.AddLast(new Agility(DataLibrary.pray[num50][currentProfile.prayeragi1]));
				linkedList.AddLast(new Stamina(DataLibrary.pray[num50][currentProfile.prayersta1]));
				for (int num51 = 0; num51 < 5; num51++)
				{
					if (currentProfile.bloodsoul1[num51] != -1)
					{
						linkedList.AddLast(DataLibrary.bloodsouls[currentProfile.bloodsoul1[num51]][currentProfile.bloodsoullvl1[num51]].value);
					}
				}
			}
			if (currentProfile.bloodline2 != -1)
			{
				int level2 = DataLibrary.bloodlines[currentProfile.bloodline2].level;
				int num52 = ((level2 >= 36) ? ((level2 < 51) ? 1 : ((level2 < 71) ? 2 : ((level2 < 81) ? 3 : ((level2 < 91) ? 4 : 5)))) : 0);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline2].str);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline2].agi);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline2].sta);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline2].release);
				Values[] values = DataLibrary.bloodlines[currentProfile.bloodline2].values;
				foreach (Values value18 in values)
				{
					linkedList.AddLast(value18);
				}
				linkedList.AddLast(new Strength(DataLibrary.pray[num52][currentProfile.prayerstr2]));
				linkedList.AddLast(new Agility(DataLibrary.pray[num52][currentProfile.prayeragi2]));
				linkedList.AddLast(new Stamina(DataLibrary.pray[num52][currentProfile.prayersta2]));
				for (int num53 = 0; num53 < 5; num53++)
				{
					if (currentProfile.bloodsoul2[num53] != -1)
					{
						linkedList.AddLast(DataLibrary.bloodsouls[currentProfile.bloodsoul2[num53]][currentProfile.bloodsoullvl2[num53]].value);
					}
				}
			}
			if (currentProfile.bloodline3 != -1)
			{
				int level3 = DataLibrary.bloodlines[currentProfile.bloodline3].level;
				int num54 = ((level3 >= 36) ? ((level3 < 51) ? 1 : ((level3 < 71) ? 2 : ((level3 < 81) ? 3 : ((level3 < 91) ? 4 : 5)))) : 0);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline3].str);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline3].agi);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline3].sta);
				linkedList.AddLast(DataLibrary.bloodlines[currentProfile.bloodline3].release);
				Values[] values = DataLibrary.bloodlines[currentProfile.bloodline3].values;
				foreach (Values value19 in values)
				{
					linkedList.AddLast(value19);
				}
				linkedList.AddLast(new Strength(DataLibrary.pray[num54][currentProfile.prayerstr3]));
				linkedList.AddLast(new Agility(DataLibrary.pray[num54][currentProfile.prayeragi3]));
				linkedList.AddLast(new Stamina(DataLibrary.pray[num54][currentProfile.prayersta3]));
				for (int num55 = 0; num55 < 5; num55++)
				{
					if (currentProfile.bloodsoul3[num55] != -1)
					{
						linkedList.AddLast(DataLibrary.bloodsouls[currentProfile.bloodsoul3[num55]][currentProfile.bloodsoullvl3[num55]].value);
					}
				}
			}
			if (currentProfile.pet != -1)
			{
				for (int num56 = 0; num56 < 6; num56++)
				{
					if (currentProfile.petskills[num56] != -1)
					{
						Values[] values = DataLibrary.petskills[currentProfile.petskills[num56]].value;
						foreach (Values value20 in values)
						{
							linkedList.AddLast(value20);
						}
					}
				}
			}
			Values[] array7 = linkedList.ToArray();
			for (int num57 = 0; num57 < array7.Length; num57++)
			{
				switch (array7[num57].GetType().Name)
				{
				case "Strength":
					num2 += array7[num57].value;
					break;
				case "Agility":
					num3 += array7[num57].value;
					break;
				case "Stamina":
					num4 += array7[num57].value;
					break;
				case "Speed":
					num6 += array7[num57].value;
					break;
				case "ArmorBreak":
					num10 += array7[num57].value;
					break;
				case "Defense":
					num11 += array7[num57].value;
					break;
				case "Pierce":
					num8 += array7[num57].value;
					break;
				case "Block":
					num5 += array7[num57].value;
					break;
				case "Critical":
					num12 += array7[num57].value;
					break;
				case "Constitution":
					num13 += array7[num57].value;
					break;
				case "Hit":
					num9 += array7[num57].value;
					break;
				case "Dodge":
					num7 += array7[num57].value;
					break;
				case "HP":
					num15 += array7[num57].value;
					break;
				case "PHP":
					num14 += array7[num57].value;
					break;
				case "Chakra":
					num17 += array7[num57].value;
					break;
				case "PChakra":
					num16 += array7[num57].value;
					break;
				case "MinAtk":
					num19 += array7[num57].value;
					break;
				case "MaxAtk":
					num20 += array7[num57].value;
					break;
				case "PAtk":
					num18 += array7[num57].value;
					break;
				case "Earth":
					num29 += array7[num57].value;
					break;
				case "Fire":
					num30 += array7[num57].value;
					break;
				case "Healing":
					num31 += array7[num57].value;
					break;
				case "Illusion":
					num32 += array7[num57].value;
					break;
				case "Lightning":
					num33 += array7[num57].value;
					break;
				case "Sealing":
					num34 += array7[num57].value;
					break;
				case "Taijutsu":
					num35 += array7[num57].value;
					break;
				case "Tool":
					num36 += array7[num57].value;
					break;
				case "Water":
					num37 += array7[num57].value;
					break;
				case "Wind":
					num38 += array7[num57].value;
					break;
				case "EArmorBreak":
					num21 += array7[num57].value;
					break;
				case "EBlock":
					num22 += array7[num57].value;
					break;
				case "EConstitution":
					num23 += array7[num57].value;
					break;
				case "ECritical":
					num24 += array7[num57].value;
					break;
				case "EDefense":
					num25 += array7[num57].value;
					break;
				case "EDodge":
					num26 += array7[num57].value;
					break;
				case "EHit":
					num27 += array7[num57].value;
					break;
				case "EPierce":
					num28 += array7[num57].value;
					break;
				case "FiveElement":
					num37 += array7[num57].value;
					num38 += array7[num57].value;
					num30 += array7[num57].value;
					num29 += array7[num57].value;
					num33 += array7[num57].value;
					break;
				case "HPAbsorb":
					num42 += array7[num57].value;
					break;
				case "DmgReduction":
					num43 += array7[num57].value;
					break;
				case "Counterattack":
					num44 += array7[num57].value;
					break;
				}
			}
			return new int[44]
			{
				num, num2, num3, num4, num6, num10, num11, num8, num5, num12,
				num13, num9, num7, num15, num14, num17, num16, num19, num20, num18,
				num21, num22, num23, num24, num25, num26, num27, num28, num29, num30,
				num31, num32, num33, num34, num35, num36, num37, num38, num39, num40,
				num41, num42, num43, num44
			};
		}

		private void overviewupdate_Click(object sender, EventArgs e)
		{
			overviewupdate.Enabled = false;
			int[] statcollection = getStatcollection();
			int num = statcollection[8] + statcollection[1] / statcollection[38];
			num = (int)((double)num * (1.0 + (double)statcollection[21] / 100.0));
			int num2 = statcollection[17] + 1;
			num2 = (int)((double)num2 * (1.0 + (double)statcollection[19] / 1000.0 + (double)statcollection[1] / (double)statcollection[38] / 100.0));
			int num3 = statcollection[18] + 1;
			num3 = (int)((double)num3 * (1.0 + (double)statcollection[19] / 1000.0 + (double)statcollection[1] / (double)statcollection[38] / 100.0));
			double num4 = 1.0;
			num4 += (double)statcollection[4] / 1000.0;
			num4 += (double)statcollection[2] / (double)statcollection[39] / 100.0;
			num4 = Math.Round(num4, 2);
			int num5 = statcollection[12];
			num5 += (int)((double)statcollection[2] / (double)statcollection[39]);
			num5 = (int)((double)num5 * (1.0 + (double)statcollection[25] / 100.0));
			int num6 = statcollection[13];
			num6 = (int)((double)num6 * (1.0 + (double)statcollection[14] / 1000.0 + (double)statcollection[3] / (double)statcollection[40] / 100.0));
			int num7 = statcollection[15];
			num7 = (int)((double)num7 * (1.0 + (double)statcollection[16] / 1000.0 + (double)statcollection[3] / (double)statcollection[40] / 100.0));
			int num8 = statcollection[7];
			num8 = (int)((double)num8 * (1.0 + (double)statcollection[27] / 100.0));
			int num9 = statcollection[11];
			num9 = (int)((double)num9 * (1.0 + (double)statcollection[26] / 100.0));
			int num10 = statcollection[5];
			num10 = (int)((double)num10 * (1.0 + (double)statcollection[20] / 100.0));
			int num11 = statcollection[6];
			num11 = (int)((double)num11 * (1.0 + (double)statcollection[24] / 100.0));
			int num12 = statcollection[9];
			num12 = (int)((double)num12 * (1.0 + (double)statcollection[23] / 100.0));
			int num13 = statcollection[10];
			num13 = (int)((double)num13 * (1.0 + (double)statcollection[22] / 100.0));
			ostr.Text = statcollection[1].ToString();
			oatk.Text = num2 + "-" + num3;
			oblock.Text = num.ToString();
			oagi.Text = statcollection[2].ToString();
			ospeed.Text = num4.ToString();
			ododge.Text = num5.ToString();
			osta.Text = statcollection[3].ToString();
			ohp.Text = num6.ToString();
			ochakra.Text = num7.ToString();
			opierce.Text = num8.ToString();
			ohit.Text = num9.ToString();
			oarmorbreak.Text = num10.ToString();
			odefense.Text = num11.ToString();
			ocritical.Text = num12.ToString();
			oconstitution.Text = num13.ToString();
			earthfield.Text = statcollection[28] / 10 + "%";
			firefield.Text = statcollection[29] / 10 + "%";
			healingfield.Text = statcollection[30] / 10 + "%";
			illusionfield.Text = statcollection[31] / 10 + "%";
			lightningfield.Text = statcollection[32] / 10 + "%";
			sealingfield.Text = statcollection[33] / 10 + "%";
			taijutsufield.Text = statcollection[34] / 10 + "%";
			toolfield.Text = statcollection[35] / 10 + "%";
			waterfield.Text = statcollection[36] / 10 + "%";
			windfield.Text = statcollection[37] / 10 + "%";
			blockchance.Text = num / 16 + "%";
			dodgechance.Text = num5 / 16 + "%";
			critchance.Text = num12 / 16 + "%";
			critmultiplier.Text = Math.Round(2.3 + (double)num12 / 16.0 * 0.02, 2).ToString();
			defreduction.Text = (int)((double)num11 / 11.0 / (1.25 + 0.01 * (double)num11 / 11.0)) + "%";
			hpabsorb.Text = statcollection[41] / 10 + "%";
			dmgreduction.Text = statcollection[42] / 10 + "%";
			counteratk.Text = statcollection[43] / 10 + "%";
			overviewupdate.Enabled = true;
		}

		private void EquipWeapon_Click(object sender, EventArgs e)
		{
			eqweapon.Show();
		}

		private void EquipGlove_Click(object sender, EventArgs e)
		{
			eqglove.Show();
		}

		private void EquipRing_Click(object sender, EventArgs e)
		{
			eqring.Show();
		}

		private void EquipTalisman_Click(object sender, EventArgs e)
		{
			eqtalisman.Show();
		}

		private void EquipHelm_Click(object sender, EventArgs e)
		{
			eqhelm.Show();
		}

		private void EquipArmor_Click(object sender, EventArgs e)
		{
			eqarmor.Show();
		}

		private void EquipBelt_Click(object sender, EventArgs e)
		{
			eqbelt.Show();
		}

		private void EquipBoot_Click(object sender, EventArgs e)
		{
			eqboots.Show();
		}

		private void EquipPet_Click(object sender, EventArgs e)
		{
			MainwindowTabs.SelectTab(1);
		}

		private void EquipBL_Click(object sender, EventArgs e)
		{
			MainwindowTabs.SelectTab(2);
		}

		private void OutfitButton_Click(object sender, EventArgs e)
		{
			outfitform.Show();
		}

		private void WingButton_Click(object sender, EventArgs e)
		{
			wingform.Show();
		}

		private void EquipTitle_Click(object sender, EventArgs e)
		{
			TitleSelect.DroppedDown = true;
		}

		private void ZanButton_Click(object sender, EventArgs e)
		{
			zanform.Show();
		}

		private void BanButton_Click(object sender, EventArgs e)
		{
			banform.Show();
		}

		private void characterlevel_ValueChanged(object sender, EventArgs e)
		{
			ProfileManager.currentProfile.level = (int)characterlevel.Value;
			UpdateBuild();
		}

		private void charactervillage_SelectedIndexChanged(object sender, EventArgs e)
		{
			ProfileManager.currentProfile.village = charactervillage.SelectedIndex;
			UpdateBuild();
		}

		private void tsubook_ValueChanged(object sender, EventArgs e)
		{
			ProfileManager.currentProfile.tsunadebook = (int)tsubook.Value;
			UpdateBuild();
		}

		private void TitleSelect_SelectedValueChanged(object sender, EventArgs e)
		{
			if (TitleSelect.SelectedIndex != -1)
			{
				ProfileManager.currentProfile.title = ((Title)TitleSelect.Items[TitleSelect.SelectedIndex]).id;
			}
			UpdateBuild();
		}

		private void NinjaRank_SelectedIndexChanged(object sender, EventArgs e)
		{
			ProfileManager.currentProfile.ninjarank = NinjaRank.SelectedIndex;
			UpdateBuild();
		}

		private void PetComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			PetSkill1.Enabled = false;
			PetSkill2.Enabled = false;
			PetSkill3.Enabled = false;
			PetSkill4.Enabled = false;
			PetSkill5.Enabled = false;
			PetSkill6.Enabled = false;
			PetSkill1.Items.Clear();
			PetSkill2.Items.Clear();
			PetSkill3.Items.Clear();
			PetSkill4.Items.Clear();
			PetSkill5.Items.Clear();
			PetSkill6.Items.Clear();
			if (PetComboBox.SelectedIndex != -1)
			{
				PetSkill1.Enabled = true;
				PetSkill2.Enabled = true;
				PetSkill3.Enabled = true;
				PetSkill4.Enabled = true;
				PetSkill5.Enabled = true;
				PetSkill6.Enabled = true;
				PetSkill[] petskills = DataLibrary.petskills;
				foreach (PetSkill petSkill in petskills)
				{
					if (petSkill.type == ((Pet)PetComboBox.SelectedItem).type || petSkill.type == 0)
					{
						PetSkill1.Items.Add(petSkill);
						PetSkill2.Items.Add(petSkill);
						PetSkill3.Items.Add(petSkill);
						PetSkill4.Items.Add(petSkill);
						PetSkill5.Items.Add(petSkill);
						PetSkill6.Items.Add(petSkill);
					}
				}
			}
			if (PetComboBox.SelectedIndex != -1)
			{
				ProfileManager.currentProfile.pet = ((Pet)PetComboBox.SelectedItem).id;
			}
			UpdateBuild();
		}

		private void PetSkill_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!loading)
			{
				if (PetSkill1.SelectedIndex != -1)
				{
					ProfileManager.currentProfile.petskills[0] = ((PetSkill)PetSkill1.SelectedItem).id;
				}
				else
				{
					ProfileManager.currentProfile.petskills[0] = -1;
				}
				if (PetSkill2.SelectedIndex != -1)
				{
					ProfileManager.currentProfile.petskills[1] = ((PetSkill)PetSkill2.SelectedItem).id;
				}
				else
				{
					ProfileManager.currentProfile.petskills[1] = -1;
				}
				if (PetSkill3.SelectedIndex != -1)
				{
					ProfileManager.currentProfile.petskills[2] = ((PetSkill)PetSkill3.SelectedItem).id;
				}
				else
				{
					ProfileManager.currentProfile.petskills[2] = -1;
				}
				if (PetSkill4.SelectedIndex != -1)
				{
					ProfileManager.currentProfile.petskills[3] = ((PetSkill)PetSkill4.SelectedItem).id;
				}
				else
				{
					ProfileManager.currentProfile.petskills[3] = -1;
				}
				if (PetSkill5.SelectedIndex != -1)
				{
					ProfileManager.currentProfile.petskills[4] = ((PetSkill)PetSkill5.SelectedItem).id;
				}
				else
				{
					ProfileManager.currentProfile.petskills[4] = -1;
				}
				if (PetSkill6.SelectedIndex != -1)
				{
					ProfileManager.currentProfile.petskills[5] = ((PetSkill)PetSkill6.SelectedItem).id;
				}
				else
				{
					ProfileManager.currentProfile.petskills[5] = -1;
				}
			}
		}

		private void BL1_Click(object sender, EventArgs e)
		{
			bloodline.resetFilter();
			bloodline.loadBLs(1);
			bloodline.Show();
		}

		private void BL2_Click(object sender, EventArgs e)
		{
			bloodline.resetFilter();
			bloodline.loadBLs(2);
			bloodline.Show();
		}

		private void BL3_Click(object sender, EventArgs e)
		{
			bloodline.resetFilter();
			bloodline.loadBLs(3);
			bloodline.Show();
		}

		private void PrayCount1_ValueChanged(object sender, EventArgs e)
		{
			decimal num = 20m;
			num -= PrayStrCount1.Value;
			num -= PrayAgiCount1.Value;
			num -= PrayStaCount1.Value;
			PrayStrCount1.Maximum = PrayStrCount1.Value + num;
			PrayAgiCount1.Maximum = PrayAgiCount1.Value + num;
			PrayStaCount1.Maximum = PrayStaCount1.Value + num;
			if (!loading)
			{
				ProfileManager.currentProfile.prayerstr1 = (int)PrayStrCount1.Value;
				ProfileManager.currentProfile.prayeragi1 = (int)PrayAgiCount1.Value;
				ProfileManager.currentProfile.prayersta1 = (int)PrayStaCount1.Value;
			}
		}

		private void PrayCount2_ValueChanged(object sender, EventArgs e)
		{
			decimal num = 20m;
			num -= PrayStrCount2.Value;
			num -= PrayAgiCount2.Value;
			num -= PrayStaCount2.Value;
			PrayStrCount2.Maximum = PrayStrCount2.Value + num;
			PrayAgiCount2.Maximum = PrayAgiCount2.Value + num;
			PrayStaCount2.Maximum = PrayStaCount2.Value + num;
			if (!loading)
			{
				ProfileManager.currentProfile.prayerstr2 = (int)PrayStrCount2.Value;
				ProfileManager.currentProfile.prayeragi2 = (int)PrayAgiCount2.Value;
				ProfileManager.currentProfile.prayersta2 = (int)PrayStaCount2.Value;
			}
		}

		private void PrayCount3_ValueChanged(object sender, EventArgs e)
		{
			decimal num = 20m;
			num -= PrayStrCount3.Value;
			num -= PrayAgiCount3.Value;
			num -= PrayStaCount3.Value;
			PrayStrCount3.Maximum = PrayStrCount3.Value + num;
			PrayAgiCount3.Maximum = PrayAgiCount3.Value + num;
			PrayStaCount3.Maximum = PrayStaCount3.Value + num;
			if (!loading)
			{
				ProfileManager.currentProfile.prayerstr3 = (int)PrayStrCount3.Value;
				ProfileManager.currentProfile.prayeragi3 = (int)PrayAgiCount3.Value;
				ProfileManager.currentProfile.prayersta3 = (int)PrayStaCount3.Value;
			}
		}

		private void BS11_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(11);
			bloodsoul.Show();
		}

		private void BS12_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(12);
			bloodsoul.Show();
		}

		private void BS13_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(13);
			bloodsoul.Show();
		}

		private void BS14_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(14);
			bloodsoul.Show();
		}

		private void BS15_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(15);
			bloodsoul.Show();
		}

		private void BS21_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(21);
			bloodsoul.Show();
		}

		private void BS22_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(22);
			bloodsoul.Show();
		}

		private void BS23_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(23);
			bloodsoul.Show();
		}

		private void BS24_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(24);
			bloodsoul.Show();
		}

		private void BS25_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(25);
			bloodsoul.Show();
		}

		private void BS31_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(31);
			bloodsoul.Show();
		}

		private void BS32_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(32);
			bloodsoul.Show();
		}

		private void BS33_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(33);
			bloodsoul.Show();
		}

		private void BS34_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(34);
			bloodsoul.Show();
		}

		private void BS35_Click(object sender, EventArgs e)
		{
			bloodsoul.loadBS(35);
			bloodsoul.Show();
		}

		private void TitleSelect_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index < 0)
			{
				return;
			}
			Rectangle rectangle = bounds;
			rectangle.Height = 13;
			Rectangle rectangle2 = bounds;
			rectangle2.Y = rectangle.Bottom;
			Title title = (Title)TitleSelect.Items[e.Index];
			StringFormat format = new StringFormat();
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
			Font font2 = new Font(e.Font.FontFamily, (float)((double)e.Font.Size * 0.8), FontStyle.Regular);
			Brush brush = new SolidBrush(e.ForeColor);
			Brush brush2 = new SolidBrush(Color.DarkBlue);
			e.Graphics.FillRectangle(new SolidBrush(e.BackColor), bounds);
			e.Graphics.DrawString(title.name, font, brush, rectangle, format);
			string text = "";
			for (int i = 0; i < title.values.Length; i++)
			{
				text += title.values[i].ToString();
				if (i + 1 < title.values.Length)
				{
					text += "\n";
				}
			}
			e.Graphics.DrawString(text, font2, brush2, rectangle2, stringFormat);
			e.DrawFocusRectangle();
		}

		private void TitleSelect_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			Title title = (Title)TitleSelect.Items[e.Index];
			e.ItemHeight = 17 + title.values.Length * 10;
		}

		private void PetComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index >= 0)
			{
				Rectangle rect = bounds;
				rect.Width = rect.Left + rect.Height;
				Rectangle rectangle = bounds;
				rectangle.X = rect.Right;
				rectangle.Width = bounds.Width - rect.Width - 25;
				rectangle.Height = 13;
				Rectangle rectangle2 = bounds;
				rectangle2.X = rect.Right;
				rectangle2.Y = rectangle.Bottom;
				Pet pet = (Pet)PetComboBox.Items[e.Index];
				StringFormat format = new StringFormat();
				StringFormat stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Near;
				Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
				Font font2 = new Font(e.Font.FontFamily, (float)((double)e.Font.Size * 0.8), FontStyle.Regular);
				Brush brush = new SolidBrush(e.ForeColor);
				Brush brush2 = new SolidBrush(Color.DarkBlue);
				e.Graphics.FillRectangle(new SolidBrush(e.BackColor), bounds);
				e.Graphics.DrawImage(pet.image, rect);
				e.Graphics.DrawString(pet.name, font, brush, rectangle, format);
				e.Graphics.DrawString(DataLibrary.petcategories[pet.type], font2, brush2, rectangle2, stringFormat);
				e.DrawFocusRectangle();
			}
		}

		private void PetSkill_DrawItem(object sender, DrawItemEventArgs e)
		{
			Graphics graphic = e.Graphics;
			Rectangle bounds = e.Bounds;
			if (e.Index < 0)
			{
				return;
			}
			Rectangle rectangle = bounds;
			rectangle.Height = 13;
			Rectangle rectangle2 = bounds;
			rectangle2.Y = rectangle.Bottom;
			PetSkill petSkill = (PetSkill)((ComboBox)sender).Items[e.Index];
			StringFormat format = new StringFormat();
			StringFormat stringFormat = new StringFormat();
			stringFormat.Alignment = StringAlignment.Near;
			Font font = new Font(e.Font.FontFamily, e.Font.Size, FontStyle.Bold);
			Font font2 = new Font(e.Font.FontFamily, (float)((double)e.Font.Size * 0.8), FontStyle.Regular);
			Brush brush = new SolidBrush(e.ForeColor);
			Brush brush2 = new SolidBrush(Color.DarkBlue);
			e.Graphics.FillRectangle(new SolidBrush(e.BackColor), bounds);
			e.Graphics.DrawString(petSkill.name, font, brush, rectangle, format);
			string text = "";
			for (int i = 0; i < petSkill.value.Length; i++)
			{
				text += petSkill.value[i].ToString();
				if (i + 1 < petSkill.value.Length)
				{
					text += "\n";
				}
			}
			e.Graphics.DrawString(text, font2, brush2, rectangle2, stringFormat);
			e.DrawFocusRectangle();
		}

		private void PetSkill_MeasureItem(object sender, MeasureItemEventArgs e)
		{
			PetSkill petSkill = (PetSkill)((ComboBox)sender).Items[e.Index];
			e.ItemHeight = 17 + petSkill.value.Length * 10;
		}

		private void MenuItem_new_Click(object sender, EventArgs e)
		{
			if (!saved)
			{
				switch (MessageBox.Show("You have an unsaved Build open\nDo you want to save before?", "Unsaved Build", MessageBoxButtons.YesNoCancel))
				{
				case DialogResult.Cancel:
					return;
				case DialogResult.Yes:
					saveFile.ShowDialog();
					break;
				}
			}
			ProfileManager.currentProfile = new PnpProfile();
			overviewupdate.Enabled = false;
			loadCurrent();
		}

		private void MenuItem_open_Click(object sender, EventArgs e)
		{
			if (!saved)
			{
				switch (MessageBox.Show("You have an unsaved Build open\nDo you want to save before?", "Unsaved Build", MessageBoxButtons.YesNoCancel))
				{
				case DialogResult.Cancel:
					return;
				case DialogResult.Yes:
					saveFile.ShowDialog();
					break;
				}
			}
			openFile.ShowDialog();
		}

		private void MenuItem_save_Click(object sender, EventArgs e)
		{
			if (!ProfileManager.currentProfile.filename.Equals("unsaved"))
			{
				saveFile.FileName = ProfileManager.currentProfile.filename;
			}
			saveFile.ShowDialog();
		}

		private void saveFile_FileOk(object sender, CancelEventArgs e)
		{
			ProfileManager.saveProfile(saveFile.FileName);
			saved = true;
			Text = ProfileManager.currentProfile.filename + " - " + progname;
		}

		private void openFile_FileOk(object sender, CancelEventArgs e)
		{
			ProfileManager.loadProfile(openFile.FileName);
			loadCurrent();
			SaveRecentFile(openFile.FileName);
		}

		private void RecentFile_click(object sender, EventArgs e)
		{
			ProfileManager.loadProfile(sender.ToString());
			loadCurrent();
		}

		public void loadCurrent()
		{
			loading = true;
			PnpProfile currentProfile = ProfileManager.currentProfile;
			characterlevel.Value = currentProfile.level;
			tsubook.Value = currentProfile.tsunadebook;
			charactervillage.SelectedIndex = currentProfile.village;
			TitleSelect.SelectedIndex = currentProfile.title;
			NinjaRank.SelectedIndex = currentProfile.ninjarank;
			PrayStrCount1.Value = currentProfile.prayerstr1;
			PrayStrCount2.Value = currentProfile.prayerstr2;
			PrayStrCount3.Value = currentProfile.prayerstr3;
			PrayAgiCount1.Value = currentProfile.prayeragi1;
			PrayAgiCount2.Value = currentProfile.prayeragi2;
			PrayAgiCount3.Value = currentProfile.prayeragi3;
			PrayStaCount1.Value = currentProfile.prayersta1;
			PrayStaCount2.Value = currentProfile.prayersta2;
			PrayStaCount3.Value = currentProfile.prayersta3;
			PetComboBox.SelectedIndex = currentProfile.pet;
			for (int i = 0; i < PetSkill1.Items.Count; i++)
			{
				if (((PetSkill)PetSkill1.Items[i]).id == currentProfile.petskills[0])
				{
					PetSkill1.SelectedIndex = i;
				}
			}
			for (int j = 0; j < PetSkill2.Items.Count; j++)
			{
				if (((PetSkill)PetSkill2.Items[j]).id == currentProfile.petskills[1])
				{
					PetSkill2.SelectedIndex = j;
				}
			}
			for (int k = 0; k < PetSkill3.Items.Count; k++)
			{
				if (((PetSkill)PetSkill3.Items[k]).id == currentProfile.petskills[2])
				{
					PetSkill3.SelectedIndex = k;
				}
			}
			for (int l = 0; l < PetSkill4.Items.Count; l++)
			{
				if (((PetSkill)PetSkill4.Items[l]).id == currentProfile.petskills[3])
				{
					PetSkill4.SelectedIndex = l;
				}
			}
			for (int m = 0; m < PetSkill5.Items.Count; m++)
			{
				if (((PetSkill)PetSkill5.Items[m]).id == currentProfile.petskills[4])
				{
					PetSkill5.SelectedIndex = m;
				}
			}
			for (int n = 0; n < PetSkill6.Items.Count; n++)
			{
				if (((PetSkill)PetSkill6.Items[n]).id == currentProfile.petskills[5])
				{
					PetSkill6.SelectedIndex = n;
				}
			}
			outfitform = new OutfitForm();
			wingform = new WingForm(this);
			bloodline = new BloodlineForm(this);
			bloodsoul = new BloodsoulForm(this);
			eqweapon = new EquipForm(this, 0);
			eqglove = new EquipForm(this, 1);
			eqring = new EquipForm(this, 2);
			eqtalisman = new EquipForm(this, 3);
			eqhelm = new EquipForm(this, 4);
			eqarmor = new EquipForm(this, 5);
			eqbelt = new EquipForm(this, 6);
			eqboots = new EquipForm(this, 7);
			zanform = new ZanpakutoForm(this);
			banform = new BankaiForm(this);
			outfitform.InitializeForm(this);
			eqweapon.fillEq(currentProfile.weapon, currentProfile.forge);
			eqglove.fillEq(currentProfile.glove, currentProfile.forge);
			eqring.fillEq(currentProfile.ring, currentProfile.forge);
			eqtalisman.fillEq(currentProfile.talisman, currentProfile.forge);
			eqhelm.fillEq(currentProfile.helm, currentProfile.forge);
			eqarmor.fillEq(currentProfile.armor, currentProfile.forge);
			eqbelt.fillEq(currentProfile.belt, currentProfile.forge);
			eqboots.fillEq(currentProfile.boots, currentProfile.forge);
			zanform.fillZan(currentProfile.zantype, currentProfile.zanval);
			outfitform.fillOutfit(currentProfile.outfit, currentProfile.outfitlevel, currentProfile.outfitstr, currentProfile.outfitagi, currentProfile.outfitsta, currentProfile.record);
			banform.fillBan(currentProfile.ban1, currentProfile.ban2, currentProfile.ban3);
			wingform.fillWing(currentProfile.wings);
			UpdateBuild();
			saved = true;
			Text = currentProfile.filename + " - " + progname;
			loading = false;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!saved)
			{
				switch (MessageBox.Show("You have an unsaved Build open\nDo you want to save before?", "Unsaved Build", MessageBoxButtons.YesNoCancel))
				{
				case DialogResult.Cancel:
					e.Cancel = true;
					break;
				case DialogResult.Yes:
					saveFile.ShowDialog();
					break;
				}
			}
		}

		private void SaveRecentFile(string path)
		{
			MenuItem_recent.DropDownItems.Clear();
			LoadRecentList();
			if (!MRUlist.Contains(path))
			{
				MRUlist.Enqueue(path);
			}
			while (MRUlist.Count > 6)
			{
				MRUlist.Dequeue();
			}
			foreach (string item in MRUlist)
			{
				ToolStripMenuItem value = new ToolStripMenuItem(item, null, RecentFile_click);
				MenuItem_recent.DropDownItems.Add(value);
			}
			StreamWriter streamWriter = new StreamWriter(Environment.CurrentDirectory + "\\Recent.txt");
			foreach (string item2 in MRUlist)
			{
				streamWriter.WriteLine(item2);
			}
			streamWriter.Flush();
			streamWriter.Close();
		}

		private void LoadRecentList()
		{
			MRUlist.Clear();
			try
			{
				StreamReader streamReader = new StreamReader(Environment.CurrentDirectory + "\\Recent.txt");
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					MRUlist.Enqueue(item);
				}
				streamReader.Close();
			}
			catch (Exception)
			{
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadRecentList();
			foreach (string item in MRUlist)
			{
				MenuItem_recent.Enabled = true;
				ToolStripMenuItem value = new ToolStripMenuItem(item, null, RecentFile_click);
				MenuItem_recent.DropDownItems.Add(value);
			}
		}

		private void AboutLabel_Click(object sender, EventArgs e)
		{
			about = new AboutBox();
			about.Show();
		}

		private void exportBuildToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ExportForm exportForm = new ExportForm(this);
			exportForm.ShowDialog();
		}
	}
}
