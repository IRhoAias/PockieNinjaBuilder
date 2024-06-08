using System;
using System.Collections;
using System.Windows.Forms;

namespace PockieNinjaBuilder
{
	public class ListViewColumnSorter : IComparer
	{
		private int ColumnToSort;

		private SortOrder OrderOfSort;

		private CaseInsensitiveComparer ObjectCompare;

		public int SortColumn
		{
			get
			{
				return ColumnToSort;
			}
			set
			{
				ColumnToSort = value;
			}
		}

		public SortOrder Order
		{
			get
			{
				return OrderOfSort;
			}
			set
			{
				OrderOfSort = value;
			}
		}

		public ListViewColumnSorter()
		{
			ColumnToSort = 0;
			OrderOfSort = SortOrder.None;
			ObjectCompare = new CaseInsensitiveComparer();
		}

		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = (ListViewItem)x;
			ListViewItem listViewItem2 = (ListViewItem)y;
			int num = ((ColumnToSort != 0 && ColumnToSort != 1) ? ObjectCompare.Compare(Convert.ToDouble(listViewItem.SubItems[ColumnToSort].Text), Convert.ToDouble(listViewItem2.SubItems[ColumnToSort].Text)) : ObjectCompare.Compare(listViewItem.SubItems[ColumnToSort].Text, listViewItem2.SubItems[ColumnToSort].Text));
			if (OrderOfSort == SortOrder.Ascending)
			{
				return num;
			}
			if (OrderOfSort == SortOrder.Descending)
			{
				return -num;
			}
			return 0;
		}
	}
}
