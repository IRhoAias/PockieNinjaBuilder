using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class ListControlItem : UserControl
	{
		public delegate void SelectionChangedEventHandler(object sender);

		private enum MouseCapture
		{
			Outside,
			Inside
		}

		private enum ButtonState
		{
			ButtonUp,
			ButtonDown,
			Disabled
		}

		public Image iIcon;

		private string iName;

		private string iValues;

		private string iLevel;

		private Bloodline iTag;

		private bool iSelected;

		private ButtonState bState;

		private MouseCapture bMouse;

		private IContainer components;

		public Image Icon
		{
			get
			{
				return iIcon;
			}
			set
			{
				iIcon = value;
				Refresh();
			}
		}

		public new string Name
		{
			get
			{
				return iName;
			}
			set
			{
				iName = value;
				Refresh();
			}
		}

		public string Values
		{
			get
			{
				return iValues;
			}
			set
			{
				iValues = value;
				Refresh();
			}
		}

		public string Level
		{
			get
			{
				return iLevel;
			}
			set
			{
				iLevel = value;
				Refresh();
			}
		}

		public new Bloodline Tag
		{
			get
			{
				return iTag;
			}
			set
			{
				iTag = value;
			}
		}

		public bool Selected
		{
			get
			{
				return iSelected;
			}
			set
			{
				iSelected = value;
				Refresh();
			}
		}

		public event SelectionChangedEventHandler SelectionChanged;

		public ListControlItem()
		{
			InitializeComponent();
		}

		public void setSelected()
		{
			Selected = true;
			this.SelectionChanged(this);
		}

		private void ListControlItem_MouseClick(object sender, MouseEventArgs e)
		{
			if (!Selected)
			{
				Selected = true;
				if (this.SelectionChanged != null)
				{
					this.SelectionChanged(this);
				}
			}
		}

		private void metroRadioGroup_MouseDown(object sender, MouseEventArgs e)
		{
			bState = ButtonState.ButtonDown;
			Refresh();
		}

		private void metroRadioGroup_MouseEnter(object sender, EventArgs e)
		{
			bMouse = MouseCapture.Inside;
			Refresh();
		}

		private void metroRadioGroup_MouseUp(object sender, MouseEventArgs e)
		{
			bState = ButtonState.ButtonUp;
			Refresh();
		}

		private void metroRadioGroup_MouseLeave(object sender, EventArgs e)
		{
			bMouse = MouseCapture.Outside;
			Refresh();
		}

		private void Paint_DrawBackground(Graphics gfx)
		{
			Rectangle rect = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			GraphicsPath graphicsPath = new GraphicsPath();
			dynamic val = 5;
			graphicsPath.StartFigure();
			graphicsPath.AddArc(new Rectangle(rect.Left, rect.Top, val, val), 180f, 90f);
			graphicsPath.AddLine(rect.Left + val, 0, rect.Right - val, 0);
			graphicsPath.AddArc(new Rectangle(rect.Right - val, 0, val, val), -90f, 90f);
			graphicsPath.AddLine(rect.Right, val, rect.Right, rect.Bottom - val);
			graphicsPath.AddArc(new Rectangle(rect.Right - val, rect.Bottom - val, val, val), 0f, 90f);
			graphicsPath.AddLine(rect.Right - val, rect.Bottom, rect.Left + val, rect.Bottom);
			graphicsPath.AddArc(new Rectangle(rect.Left, rect.Height - val, val, val), 90f, 90f);
			graphicsPath.CloseFigure();
			Color[] colors = null;
			SolidBrush solidBrush = null;
			if (bState == ButtonState.Disabled)
			{
				solidBrush = ColorSchemes.DisabledBorder;
				colors = ColorSchemes.DisabledAllColor;
			}
			else if (Selected)
			{
				solidBrush = ColorSchemes.SelectedBorder;
				if ((bState == ButtonState.ButtonUp) & (bMouse == MouseCapture.Outside))
				{
					colors = ColorSchemes.SelectedNormal;
				}
				else if ((bState == ButtonState.ButtonUp) & (bMouse == MouseCapture.Inside))
				{
					colors = ColorSchemes.SelectedHover;
				}
				else
				{
					if ((bState == ButtonState.ButtonDown) & (bMouse == MouseCapture.Outside))
					{
						return;
					}
					if ((bState == ButtonState.ButtonDown) & (bMouse == MouseCapture.Inside))
					{
						colors = ColorSchemes.SelectedPressed;
					}
				}
			}
			else
			{
				solidBrush = ColorSchemes.UnSelectedBorder;
				if ((bState == ButtonState.ButtonUp) & (bMouse == MouseCapture.Outside))
				{
					solidBrush = ColorSchemes.DisabledBorder;
					colors = ColorSchemes.UnSelectedNormal;
				}
				else if ((bState == ButtonState.ButtonUp) & (bMouse == MouseCapture.Inside))
				{
					colors = ColorSchemes.UnSelectedHover;
				}
				else
				{
					if ((bState == ButtonState.ButtonDown) & (bMouse == MouseCapture.Outside))
					{
						return;
					}
					if ((bState == ButtonState.ButtonDown) & (bMouse == MouseCapture.Inside))
					{
						colors = ColorSchemes.UnSelectedPressed;
					}
				}
			}
			LinearGradientBrush linearGradientBrush = new LinearGradientBrush(rect, Color.White, Color.Black, LinearGradientMode.Vertical);
			ColorBlend colorBlend = new ColorBlend();
			colorBlend.Colors = colors;
			colorBlend.Positions = new float[5] { 0f, 0.1f, 0.9f, 0.95f, 1f };
			linearGradientBrush.InterpolationColors = colorBlend;
			gfx.FillPath(linearGradientBrush, graphicsPath);
			gfx.DrawPath(new Pen(solidBrush), graphicsPath);
			if (bMouse == MouseCapture.Outside)
			{
				rect = new Rectangle(rect.Left, base.Height - 1, rect.Width, 1);
				linearGradientBrush = new LinearGradientBrush(rect, Color.Blue, Color.Yellow, LinearGradientMode.Horizontal);
				colorBlend = new ColorBlend();
				colorBlend.Colors = new Color[3]
				{
					Color.White,
					Color.LightGray,
					Color.White
				};
				colorBlend.Positions = new float[3] { 0f, 0.5f, 1f };
				linearGradientBrush.InterpolationColors = colorBlend;
				gfx.FillRectangle(linearGradientBrush, rect);
			}
		}

		private void Paint_DrawButton(Graphics gfx)
		{
			RectangleF rectangleF = default(RectangleF);
			StringFormat stringFormat = new StringFormat();
			stringFormat.Trimming = StringTrimming.EllipsisCharacter;
			StringFormat format = stringFormat;
			Rectangle rectangle = new Rectangle(60, 0, base.Width - 60, base.Height);
			Brush brush = ((iTag.level < 36) ? Brushes.Green : ((iTag.level < 51) ? Brushes.Blue : ((iTag.level < 71) ? Brushes.Purple : ((iTag.level < 81) ? Brushes.Orange : ((iTag.level < 91) ? Brushes.Red : ((iTag.level >= 101) ? Brushes.Magenta : Brushes.DarkGoldenrod))))));
			Font font = new Font("Microsoft Sans Serif", 13f, FontStyle.Bold);
			gfx.DrawString(layoutRectangle: new RectangleF(height: gfx.MeasureString(iName, font).Height, x: 61f, y: 0f, width: rectangle.Width), s: iName, font: font, brush: brush, format: format);
			font = new Font("Microsoft Sans Serif", 8.25f);
			gfx.DrawString(layoutRectangle: new RectangleF(height: gfx.MeasureString(iValues, font).Height, x: 64f, y: 19f, width: rectangle.Width), s: iValues, font: font, brush: Brushes.Black, format: format);
			font = new Font("Microsoft Sans Serif", 8.25f);
			gfx.DrawString(layoutRectangle: new RectangleF(height: gfx.MeasureString(iLevel, font).Height, x: 160f, y: 59f, width: rectangle.Width), s: iLevel, font: font, brush: Brushes.Black, format: format);
			gfx.DrawImage(iIcon, 9, 15, 46, 46);
		}

		private void PaintEvent(object sender, PaintEventArgs e)
		{
			dynamic graphics = e.Graphics;
			Paint_DrawBackground(graphics);
			Paint_DrawButton(graphics);
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
			base.SuspendLayout();
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.DoubleBuffered = true;
			this.Name = "ListControlItem";
			base.Size = new System.Drawing.Size(200, 75);
			base.Paint += new System.Windows.Forms.PaintEventHandler(PaintEvent);
			base.MouseClick += new System.Windows.Forms.MouseEventHandler(ListControlItem_MouseClick);
			base.MouseDown += new System.Windows.Forms.MouseEventHandler(metroRadioGroup_MouseDown);
			base.MouseEnter += new System.EventHandler(metroRadioGroup_MouseEnter);
			base.MouseLeave += new System.EventHandler(metroRadioGroup_MouseLeave);
			base.MouseUp += new System.Windows.Forms.MouseEventHandler(metroRadioGroup_MouseUp);
			base.ResumeLayout(false);
		}
	}
}
