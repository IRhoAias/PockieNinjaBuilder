using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class ExportForm : Form
	{
		private IContainer components;

		private SaveFileDialog exportFile;

		private TextBox PathField;

		private Button PathButton;

		private Button FinishButton;

		private Label label1;

		private TrackBar QualityBar;

		private Label label2;

		private PictureBox PreviewPicture;

		private ComboBox ExportChoose;

		private Label label3;

		private FlowLayoutPanel ExportFlow;

		private MainForm main;

		private RadioButton[] radio;

		private CheckBox[] check;

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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.ExportForm));
			this.exportFile = new System.Windows.Forms.SaveFileDialog();
			this.PathField = new System.Windows.Forms.TextBox();
			this.PathButton = new System.Windows.Forms.Button();
			this.FinishButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.QualityBar = new System.Windows.Forms.TrackBar();
			this.label2 = new System.Windows.Forms.Label();
			this.PreviewPicture = new System.Windows.Forms.PictureBox();
			this.ExportChoose = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ExportFlow = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)this.QualityBar).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PreviewPicture).BeginInit();
			base.SuspendLayout();
			this.exportFile.DefaultExt = "jpg";
			this.exportFile.Filter = "JPEG-Datei|*.jpg|GIF-Datei|*.gif|PNG-Datei|*.png";
			this.exportFile.FileOk += new System.ComponentModel.CancelEventHandler(exportFile_FileOk);
			this.PathField.Location = new System.Drawing.Point(12, 45);
			this.PathField.Name = "PathField";
			this.PathField.Size = new System.Drawing.Size(118, 20);
			this.PathField.TabIndex = 0;
			this.PathButton.Location = new System.Drawing.Point(136, 43);
			this.PathButton.Name = "PathButton";
			this.PathButton.Size = new System.Drawing.Size(24, 23);
			this.PathButton.TabIndex = 1;
			this.PathButton.Text = "...";
			this.PathButton.UseVisualStyleBackColor = true;
			this.PathButton.Click += new System.EventHandler(PathButton_Click);
			this.FinishButton.Location = new System.Drawing.Point(412, 342);
			this.FinishButton.Name = "FinishButton";
			this.FinishButton.Size = new System.Drawing.Size(108, 23);
			this.FinishButton.TabIndex = 2;
			this.FinishButton.Text = "Finish";
			this.FinishButton.UseVisualStyleBackColor = true;
			this.FinishButton.Click += new System.EventHandler(FinishButton_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Export-Path:";
			this.QualityBar.LargeChange = 10;
			this.QualityBar.Location = new System.Drawing.Point(12, 101);
			this.QualityBar.Maximum = 100;
			this.QualityBar.Minimum = 50;
			this.QualityBar.Name = "QualityBar";
			this.QualityBar.Size = new System.Drawing.Size(148, 45);
			this.QualityBar.TabIndex = 4;
			this.QualityBar.TickFrequency = 10;
			this.QualityBar.Value = 80;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Quality:";
			this.PreviewPicture.Location = new System.Drawing.Point(166, 12);
			this.PreviewPicture.Name = "PreviewPicture";
			this.PreviewPicture.Size = new System.Drawing.Size(354, 324);
			this.PreviewPicture.TabIndex = 6;
			this.PreviewPicture.TabStop = false;
			this.ExportChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ExportChoose.FormattingEnabled = true;
			this.ExportChoose.Items.AddRange(new object[3] { "Complete", "Part", "Custom" });
			this.ExportChoose.Location = new System.Drawing.Point(15, 165);
			this.ExportChoose.Name = "ExportChoose";
			this.ExportChoose.Size = new System.Drawing.Size(145, 21);
			this.ExportChoose.TabIndex = 7;
			this.ExportChoose.SelectedIndexChanged += new System.EventHandler(ExportChoose_SelectedIndexChanged);
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Export: ";
			this.ExportFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.ExportFlow.Location = new System.Drawing.Point(15, 192);
			this.ExportFlow.Name = "ExportFlow";
			this.ExportFlow.Size = new System.Drawing.Size(145, 168);
			this.ExportFlow.TabIndex = 11;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(532, 377);
			base.Controls.Add(this.ExportFlow);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.ExportChoose);
			base.Controls.Add(this.PreviewPicture);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.QualityBar);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.FinishButton);
			base.Controls.Add(this.PathButton);
			base.Controls.Add(this.PathField);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "ExportForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Exporting...";
			((System.ComponentModel.ISupportInitialize)this.QualityBar).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PreviewPicture).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		public ExportForm(MainForm main)
		{
			this.main = main;
			InitializeComponent();
			ExportChoose.SelectedIndex = 0;
			string[] array = new string[6] { "Outfit", "Equipment", "Pet", "Zanpakuto", "Bloodline", "Others" };
			radio = new RadioButton[6]
			{
				new RadioButton(),
				new RadioButton(),
				new RadioButton(),
				new RadioButton(),
				new RadioButton(),
				new RadioButton()
			};
			check = new CheckBox[6]
			{
				new CheckBox(),
				new CheckBox(),
				new CheckBox(),
				new CheckBox(),
				new CheckBox(),
				new CheckBox()
			};
			for (int i = 0; i < array.Length; i++)
			{
				radio[i].Height = 18;
				check[i].Height = 18;
				radio[i].Text = array[i];
				check[i].Text = array[i];
			}
		}

		private void PathButton_Click(object sender, EventArgs e)
		{
			exportFile.ShowDialog();
		}

		private void exportFile_FileOk(object sender, CancelEventArgs e)
		{
			PathField.Text = exportFile.FileName;
		}

		public Bitmap createExport()
		{
			PnpProfile currentProfile = main.ProfileManager.currentProfile;
			int num = 20;
			Size size = new Size(400, 600);
			int num2 = 12;
			int num3 = 7;
			Font font = new Font("Arial", num2, FontStyle.Bold);
			Font font2 = new Font("Arial", num3);
			Color black = Color.Black;
			Color white = Color.White;
			Color green = Color.Green;
			Brush brush = new SolidBrush(black);
			Bitmap bitmap = new Bitmap(size.Width, size.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.HighSpeed;
			graphics.FillRectangle(new SolidBrush(white), graphics.ClipBounds);
			int num4 = (int)graphics.MeasureString("Psychomaster", font2).Height;
			Rectangle rectangle = new Rectangle(num + 51, num, size.Width - 2 * num, 51);
			Rectangle rectangle2 = new Rectangle(num, rectangle.Bottom, 100, 200);
			Rectangle rect = new Rectangle(rectangle2.Right, rectangle2.Top, 100, rectangle2.Height);
			new Rectangle(rect.Right, rectangle2.Top, 100, rectangle2.Height);
			new Rectangle(num, new Rectangle(num, new Rectangle(num, rectangle2.Bottom, size.Width - 2 * num, 100).Bottom, size.Width - 2 * num, 100).Bottom, size.Width - 2 * num, 50);
			Outfit outfit = DataLibrary.outfits[currentProfile.outfit];
			graphics.DrawString(currentProfile.filename, font, new SolidBrush(green), rectangle);
			graphics.DrawString(outfit.name + " +" + currentProfile.outfitlevel, new Font(font2.FontFamily, num2 - 3), new SolidBrush(green), rectangle.Left, (float)rectangle.Top + graphics.MeasureString("Tg", font).Height);
			graphics.DrawImage(outfit.image, num, num, outfit.image.Width, outfit.image.Height);
			graphics.DrawString("Strength\t" + (outfit.str_init + (int)((double)currentProfile.outfitlevel * 8.0 * (outfit.str_mul_init + currentProfile.outfitstr))) + " (" + (outfit.str_mul_init + currentProfile.outfitstr) + ") / Max(" + (outfit.str_mul_init + 0.3) + ")", font2, brush, rectangle2.Left, rectangle2.Top);
			graphics.DrawString("Agility\t" + (outfit.agi_init + (int)((double)currentProfile.outfitlevel * 8.0 * (outfit.agi_mul_init + currentProfile.outfitagi))) + " (" + (outfit.agi_mul_init + currentProfile.outfitagi) + ") / Max(" + (outfit.agi_mul_init + 0.3) + ")", font2, brush, rectangle2.Left, rectangle2.Top + num4);
			graphics.DrawString("Stamina\t" + (outfit.sta_init + (int)((double)currentProfile.outfitlevel * 8.0 * (outfit.sta_mul_init + currentProfile.outfitsta))) + " (" + (outfit.sta_mul_init + currentProfile.outfitsta) + ") / Max(" + (outfit.sta_mul_init + 0.3) + ")", font2, brush, rectangle2.Left, rectangle2.Top + 2 * num4);
			graphics.DrawString("BMV\t" + outfit.bmv_str + " / " + outfit.bmv_agi + " / " + outfit.bmv_sta, font2, brush, rectangle2.Left, rectangle2.Top + 3 * num4);
			graphics.DrawImageUnscaled(DataLibrary.pets[currentProfile.pet].image, rect);
			graphics.DrawString(DataLibrary.pets[currentProfile.pet].name, font2, brush, rect.Left + 51, rect.Top + (51 - num4) / 2);
			graphics.DrawString(DataLibrary.petskills[currentProfile.petskills[0]].name, font2, brush, rect.Left, rect.Top + 51);
			graphics.DrawString(DataLibrary.petskills[currentProfile.petskills[1]].name, font2, brush, rect.Left, rect.Top + 51 + num4);
			graphics.DrawString(DataLibrary.petskills[currentProfile.petskills[2]].name, font2, brush, rect.Left, rect.Top + 51 + num4 * 2);
			graphics.DrawString(DataLibrary.petskills[currentProfile.petskills[3]].name, font2, brush, rect.Left, rect.Top + 51 + num4 * 3);
			graphics.DrawString(DataLibrary.petskills[currentProfile.petskills[4]].name, font2, brush, rect.Left, rect.Top + 51 + num4 * 4);
			graphics.DrawString(DataLibrary.petskills[currentProfile.petskills[5]].name, font2, brush, rect.Left, rect.Top + 51 + num4 * 5);
			graphics.Flush();
			return bitmap;
		}

		private ImageCodecInfo GetEncoder(ImageFormat format)
		{
			ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
			ImageCodecInfo[] array = imageDecoders;
			foreach (ImageCodecInfo imageCodecInfo in array)
			{
				if (imageCodecInfo.FormatID == format.Guid)
				{
					return imageCodecInfo;
				}
			}
			return null;
		}

		private void FinishButton_Click(object sender, EventArgs e)
		{
			string extension = Path.GetExtension(exportFile.FileName);
			Bitmap bitmap = createExport();
			EncoderParameters encoderParameters = new EncoderParameters();
			encoderParameters.Param = new EncoderParameter[1]
			{
				new EncoderParameter(Encoder.Quality, QualityBar.Value)
			};
			if (extension.Equals(".jpg"))
			{
				bitmap.Save(exportFile.FileName, GetEncoder(ImageFormat.Jpeg), encoderParameters);
			}
			else if (extension.Equals(".gif"))
			{
				bitmap.Save(exportFile.FileName, GetEncoder(ImageFormat.Gif), encoderParameters);
			}
			else
			{
				bitmap.Save(exportFile.FileName, GetEncoder(ImageFormat.Png), encoderParameters);
			}
			Close();
		}

		private void ExportChoose_SelectedIndexChanged(object sender, EventArgs e)
		{
			ExportFlow.Controls.Clear();
			if (ExportChoose.SelectedIndex == 1)
			{
				ExportFlow.Controls.AddRange(radio);
			}
			else if (ExportChoose.SelectedIndex == 2)
			{
				ExportFlow.Controls.AddRange(check);
			}
		}
	}
}
