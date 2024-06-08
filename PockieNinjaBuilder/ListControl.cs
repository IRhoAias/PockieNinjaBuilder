using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class ListControl : UserControl
	{
		public delegate void ItemClickEventHandler(object sender, int Index);

		private IContainer components;

		private FlowLayoutPanel flpListBox;

		private ListControlItem iLastSelected;

		public event ItemClickEventHandler ItemClick;

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
			this.flpListBox = new System.Windows.Forms.FlowLayoutPanel();
			base.SuspendLayout();
			this.flpListBox.AutoScroll = true;
			this.flpListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpListBox.Location = new System.Drawing.Point(0, 0);
			this.flpListBox.Margin = new System.Windows.Forms.Padding(0);
			this.flpListBox.Name = "flpListBox";
			this.flpListBox.Size = new System.Drawing.Size(246, 176);
			this.flpListBox.TabIndex = 0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			base.Controls.Add(this.flpListBox);
			base.Name = "ListControl";
			base.Size = new System.Drawing.Size(246, 176);
			base.ResumeLayout(false);
		}

		public ListControl()
		{
			InitializeComponent();
		}

		public ListControlItem Add(Bloodline bl)
		{
			ListControlItem listControlItem = new ListControlItem();
			listControlItem.Margin = new Padding(0);
			listControlItem.Name = bl.name;
			listControlItem.Values = string.Format("{0} / {1} / {2}\n{3}\n{4}\n{5}", bl.str.value, bl.agi.value, bl.sta.value, bl.release.ToString(), bl.values[0].ToString(), bl.values[1].ToString());
			listControlItem.Level = "Lvl." + bl.level;
			listControlItem.Icon = bl.image;
			listControlItem.Tag = bl;
			listControlItem.SelectionChanged += SelectionChanged;
			listControlItem.Click += ItemClicked;
			flpListBox.Controls.Add(listControlItem);
			return listControlItem;
		}

		public void Remove(int Index)
		{
			flpListBox.Controls.RemoveAt(Index);
		}

		public void Clear()
		{
			flpListBox.Controls.Clear();
		}

		public int Count()
		{
			return flpListBox.Controls.Count;
		}

		public ListControlItem getSelection()
		{
			return iLastSelected;
		}

		public void setSelection(ListControlItem c)
		{
			iLastSelected = c;
		}

		private void SelectionChanged(object sender)
		{
			if (iLastSelected != null)
			{
				iLastSelected.Selected = false;
			}
			iLastSelected = (ListControlItem)sender;
		}

		private void ItemClicked(object sender, EventArgs e)
		{
			if (this.ItemClick != null)
			{
				this.ItemClick(this, flpListBox.Controls.IndexOf((ListControlItem)sender));
			}
		}
	}
}
