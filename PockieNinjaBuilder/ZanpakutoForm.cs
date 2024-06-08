using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PockieNinjaBuilder.PockieNinjaLibrary;

namespace PockieNinjaBuilder
{
	public class ZanpakutoForm : Form
	{
		private MainForm main;

		private IContainer components;

		private Label ZanLabel61;

		private Label ZanLabel51;

		private Label ZanLabel41;

		private Label ZanLabel31;

		private Label ZanLabel21;

		private Label ZanLabel11;

		private TrackBar ZanNum61;

		private ComboBox ZanVal61;

		private TrackBar ZanNum51;

		private ComboBox ZanVal51;

		private TrackBar ZanNum41;

		private ComboBox ZanVal41;

		private TrackBar ZanNum31;

		private ComboBox ZanColor6;

		private ComboBox ZanVal31;

		private ComboBox ZanColor5;

		private TrackBar ZanNum21;

		private ComboBox ZanColor4;

		private ComboBox ZanVal21;

		private ComboBox ZanColor3;

		private TrackBar ZanNum11;

		private ComboBox ZanColor2;

		private ComboBox ZanVal11;

		private ComboBox ZanColor1;

		private Label label1;

		private Label label2;

		private ComboBox ZanVal12;

		private TrackBar ZanNum12;

		private Label ZanLabel12;

		private ComboBox ZanVal13;

		private TrackBar ZanNum13;

		private Label ZanLabel13;

		private ComboBox ZanVal22;

		private TrackBar ZanNum22;

		private Label ZanLabel22;

		private ComboBox ZanVal23;

		private TrackBar ZanNum23;

		private Label ZanLabel23;

		private ComboBox ZanVal32;

		private TrackBar ZanNum32;

		private Label ZanLabel32;

		private ComboBox ZanVal33;

		private TrackBar ZanNum33;

		private Label ZanLabel33;

		private ComboBox ZanVal42;

		private TrackBar ZanNum42;

		private Label ZanLabel42;

		private ComboBox ZanVal43;

		private TrackBar ZanNum43;

		private Label ZanLabel43;

		private ComboBox ZanVal52;

		private TrackBar ZanNum52;

		private Label ZanLabel52;

		private ComboBox ZanVal53;

		private TrackBar ZanNum53;

		private Label ZanLabel53;

		private ComboBox ZanVal62;

		private TrackBar ZanNum62;

		private Label ZanLabel62;

		private ComboBox ZanVal63;

		private TrackBar ZanNum63;

		private Label ZanLabel63;

		private Button SaveButton;

		public ZanpakutoForm(MainForm main)
		{
			this.main = main;
			InitializeComponent();
			string[] array = new string[19]
			{
				"Strength", "Agility", "Stamina", "Attack+%", "Min Attack", "Max Attack", "Armor Break", "Hit", "Speed", "Dodge",
				"Max HP", "HP+%", "Max Chakra", "Chakra+%", "Critical Strike", "Constitution", "Block", "Pierce", "Defense"
			};
			for (int i = 0; i < 19; i++)
			{
				ZanVal11.Items.Add(array[i]);
				ZanVal12.Items.Add(array[i]);
				ZanVal13.Items.Add(array[i]);
				ZanVal21.Items.Add(array[i]);
				ZanVal22.Items.Add(array[i]);
				ZanVal23.Items.Add(array[i]);
				ZanVal31.Items.Add(array[i]);
				ZanVal32.Items.Add(array[i]);
				ZanVal33.Items.Add(array[i]);
				ZanVal41.Items.Add(array[i]);
				ZanVal42.Items.Add(array[i]);
				ZanVal43.Items.Add(array[i]);
				ZanVal51.Items.Add(array[i]);
				ZanVal52.Items.Add(array[i]);
				ZanVal53.Items.Add(array[i]);
				ZanVal61.Items.Add(array[i]);
				ZanVal62.Items.Add(array[i]);
				ZanVal63.Items.Add(array[i]);
			}
		}

		private void ZanpakutoForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Hide();
			e.Cancel = true;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			PnpProfile currentProfile = main.ProfileManager.currentProfile;
			currentProfile.zantype[0] = ZanVal11.SelectedIndex;
			currentProfile.zantype[1] = ZanVal12.SelectedIndex;
			currentProfile.zantype[2] = ZanVal13.SelectedIndex;
			currentProfile.zantype[3] = ZanVal21.SelectedIndex;
			currentProfile.zantype[4] = ZanVal22.SelectedIndex;
			currentProfile.zantype[5] = ZanVal23.SelectedIndex;
			currentProfile.zantype[6] = ZanVal31.SelectedIndex;
			currentProfile.zantype[7] = ZanVal32.SelectedIndex;
			currentProfile.zantype[8] = ZanVal33.SelectedIndex;
			currentProfile.zantype[9] = ZanVal41.SelectedIndex;
			currentProfile.zantype[10] = ZanVal42.SelectedIndex;
			currentProfile.zantype[11] = ZanVal43.SelectedIndex;
			currentProfile.zantype[12] = ZanVal51.SelectedIndex;
			currentProfile.zantype[13] = ZanVal52.SelectedIndex;
			currentProfile.zantype[14] = ZanVal53.SelectedIndex;
			currentProfile.zantype[15] = ZanVal61.SelectedIndex;
			currentProfile.zantype[16] = ZanVal62.SelectedIndex;
			currentProfile.zantype[17] = ZanVal63.SelectedIndex;
			currentProfile.zanval[0] = ZanNum11.Value;
			currentProfile.zanval[1] = ZanNum12.Value;
			currentProfile.zanval[2] = ZanNum13.Value;
			currentProfile.zanval[3] = ZanNum21.Value;
			currentProfile.zanval[4] = ZanNum22.Value;
			currentProfile.zanval[5] = ZanNum23.Value;
			currentProfile.zanval[6] = ZanNum31.Value;
			currentProfile.zanval[7] = ZanNum32.Value;
			currentProfile.zanval[8] = ZanNum33.Value;
			currentProfile.zanval[9] = ZanNum41.Value;
			currentProfile.zanval[10] = ZanNum42.Value;
			currentProfile.zanval[11] = ZanNum43.Value;
			currentProfile.zanval[12] = ZanNum51.Value;
			currentProfile.zanval[13] = ZanNum52.Value;
			currentProfile.zanval[14] = ZanNum53.Value;
			currentProfile.zanval[15] = ZanNum61.Value;
			currentProfile.zanval[16] = ZanNum62.Value;
			currentProfile.zanval[17] = ZanNum63.Value;
			main.UpdateBuild();
			Hide();
		}

		private void ZanColor1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanVal11.Enabled = true;
			ZanVal12.Enabled = true;
			ZanVal13.Enabled = true;
		}

		private void ZanColor2_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanVal21.Enabled = true;
			ZanVal22.Enabled = true;
			ZanVal23.Enabled = true;
		}

		private void ZanColor3_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanVal31.Enabled = true;
			ZanVal32.Enabled = true;
			ZanVal33.Enabled = true;
		}

		private void ZanColor4_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanVal41.Enabled = true;
			ZanVal42.Enabled = true;
			ZanVal43.Enabled = true;
		}

		private void ZanColor5_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanVal51.Enabled = true;
			ZanVal52.Enabled = true;
			ZanVal53.Enabled = true;
		}

		private void ZanColor6_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanVal61.Enabled = true;
			ZanVal62.Enabled = true;
			ZanVal63.Enabled = true;
		}

		private void ZanVal11_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum11.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal11.SelectedIndex][ZanColor1.SelectedIndex];
			ZanNum11.Minimum = array[0];
			ZanNum11.Maximum = array[1];
		}

		private void ZanVal12_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum12.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal12.SelectedIndex][ZanColor1.SelectedIndex];
			ZanNum12.Minimum = array[0];
			ZanNum12.Maximum = array[1];
		}

		private void ZanVal13_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum13.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal13.SelectedIndex][ZanColor1.SelectedIndex];
			ZanNum13.Minimum = array[0];
			ZanNum13.Maximum = array[1];
		}

		private void ZanVal21_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum21.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal21.SelectedIndex][ZanColor2.SelectedIndex];
			ZanNum21.Minimum = array[0];
			ZanNum21.Maximum = array[1];
		}

		private void ZanVal22_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum22.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal22.SelectedIndex][ZanColor2.SelectedIndex];
			ZanNum22.Minimum = array[0];
			ZanNum22.Maximum = array[1];
		}

		private void ZanVal23_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum23.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal23.SelectedIndex][ZanColor2.SelectedIndex];
			ZanNum23.Minimum = array[0];
			ZanNum23.Maximum = array[1];
		}

		private void ZanVal31_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum31.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal31.SelectedIndex][ZanColor3.SelectedIndex];
			ZanNum31.Minimum = array[0];
			ZanNum31.Maximum = array[1];
		}

		private void ZanVal32_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum32.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal32.SelectedIndex][ZanColor3.SelectedIndex];
			ZanNum32.Minimum = array[0];
			ZanNum32.Maximum = array[1];
		}

		private void ZanVal33_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum33.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal33.SelectedIndex][ZanColor3.SelectedIndex];
			ZanNum33.Minimum = array[0];
			ZanNum33.Maximum = array[1];
		}

		private void ZanVal41_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum41.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal41.SelectedIndex][ZanColor4.SelectedIndex];
			ZanNum41.Minimum = array[0];
			ZanNum41.Maximum = array[1];
		}

		private void ZanVal42_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum42.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal42.SelectedIndex][ZanColor4.SelectedIndex];
			ZanNum42.Minimum = array[0];
			ZanNum42.Maximum = array[1];
		}

		private void ZanVal43_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum43.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal43.SelectedIndex][ZanColor4.SelectedIndex];
			ZanNum43.Minimum = array[0];
			ZanNum43.Maximum = array[1];
		}

		private void ZanVal51_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum51.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal51.SelectedIndex][ZanColor5.SelectedIndex];
			ZanNum51.Minimum = array[0];
			ZanNum51.Maximum = array[1];
		}

		private void ZanVal52_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum52.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal52.SelectedIndex][ZanColor5.SelectedIndex];
			ZanNum52.Minimum = array[0];
			ZanNum52.Maximum = array[1];
		}

		private void ZanVal53_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum53.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal53.SelectedIndex][ZanColor5.SelectedIndex];
			ZanNum53.Minimum = array[0];
			ZanNum53.Maximum = array[1];
		}

		private void ZanVal61_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum61.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal61.SelectedIndex][ZanColor6.SelectedIndex];
			ZanNum61.Minimum = array[0];
			ZanNum61.Maximum = array[1];
		}

		private void ZanVal62_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum62.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal62.SelectedIndex][ZanColor6.SelectedIndex];
			ZanNum62.Minimum = array[0];
			ZanNum62.Maximum = array[1];
		}

		private void ZanVal63_SelectedIndexChanged(object sender, EventArgs e)
		{
			ZanNum63.Enabled = true;
			int[] array = DataLibrary.zanpakuto[ZanVal63.SelectedIndex][ZanColor6.SelectedIndex];
			ZanNum63.Minimum = array[0];
			ZanNum63.Maximum = array[1];
		}

		private void ZanNum11_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal11.SelectedIndex][1];
			ZanLabel11.Text = ZanNum11.Value.ToString();
			switch ((ZanNum11.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel11.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel11.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel11.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel11.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum12_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal12.SelectedIndex][1];
			ZanLabel12.Text = ZanNum12.Value.ToString();
			switch ((ZanNum12.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel12.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel12.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel12.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel12.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum13_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal13.SelectedIndex][1];
			ZanLabel13.Text = ZanNum13.Value.ToString();
			switch ((ZanNum13.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel13.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel13.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel13.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel13.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum21_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal21.SelectedIndex][1];
			ZanLabel21.Text = ZanNum21.Value.ToString();
			switch ((ZanNum21.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel21.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel21.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel21.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel21.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum22_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal22.SelectedIndex][1];
			ZanLabel22.Text = ZanNum22.Value.ToString();
			switch ((ZanNum22.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel22.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel22.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel22.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel22.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum23_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal23.SelectedIndex][1];
			ZanLabel23.Text = ZanNum23.Value.ToString();
			switch ((ZanNum23.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel23.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel23.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel23.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel23.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum31_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal31.SelectedIndex][1];
			ZanLabel31.Text = ZanNum31.Value.ToString();
			switch ((ZanNum31.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel31.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel31.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel31.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel31.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum32_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal32.SelectedIndex][1];
			ZanLabel32.Text = ZanNum32.Value.ToString();
			switch ((ZanNum32.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel32.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel32.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel32.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel32.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum33_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal33.SelectedIndex][1];
			ZanLabel33.Text = ZanNum33.Value.ToString();
			switch ((ZanNum33.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel33.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel33.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel33.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel33.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum41_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal41.SelectedIndex][1];
			ZanLabel41.Text = ZanNum41.Value.ToString();
			switch ((ZanNum41.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel41.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel41.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel41.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel41.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum42_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal42.SelectedIndex][1];
			ZanLabel42.Text = ZanNum42.Value.ToString();
			switch ((ZanNum42.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel42.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel42.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel42.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel42.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum43_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal43.SelectedIndex][1];
			ZanLabel43.Text = ZanNum43.Value.ToString();
			switch ((ZanNum43.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel43.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel43.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel43.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel43.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum51_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal51.SelectedIndex][1];
			ZanLabel51.Text = ZanNum51.Value.ToString();
			switch ((ZanNum51.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel51.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel51.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel51.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel51.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum52_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal52.SelectedIndex][1];
			ZanLabel52.Text = ZanNum52.Value.ToString();
			switch ((ZanNum52.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel52.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel52.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel52.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel52.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum53_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal53.SelectedIndex][1];
			ZanLabel53.Text = ZanNum53.Value.ToString();
			switch ((ZanNum53.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel53.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel53.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel53.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel53.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum61_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal61.SelectedIndex][1];
			ZanLabel61.Text = ZanNum61.Value.ToString();
			switch ((ZanNum61.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel61.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel61.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel61.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel61.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum62_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal62.SelectedIndex][1];
			ZanLabel62.Text = ZanNum62.Value.ToString();
			switch ((ZanNum62.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel62.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel62.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel62.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel62.ForeColor = Color.Purple;
				break;
			}
		}

		private void ZanNum63_ValueChanged(object sender, EventArgs e)
		{
			int[] array = DataLibrary.zanpakuto[ZanVal63.SelectedIndex][1];
			ZanLabel63.Text = ZanNum63.Value.ToString();
			switch ((ZanNum63.Value - array[0]) / ((array[1] - array[0]) / 4))
			{
			case 0:
				ZanLabel63.ForeColor = Color.Gray;
				break;
			case 1:
				ZanLabel63.ForeColor = Color.Green;
				break;
			case 2:
				ZanLabel63.ForeColor = Color.Blue;
				break;
			case 3:
				ZanLabel63.ForeColor = Color.Purple;
				break;
			}
		}

		internal void fillZan(int[] type, int[] val)
		{
			ZanColor1.SelectedIndex = 1;
			ZanColor2.SelectedIndex = 1;
			ZanColor3.SelectedIndex = 1;
			ZanColor4.SelectedIndex = 1;
			ZanColor5.SelectedIndex = 1;
			ZanColor6.SelectedIndex = 1;
			if (type[0] != -1)
			{
				ZanColor1_SelectedIndexChanged(null, null);
			}
			if (type[3] != -1)
			{
				ZanColor2_SelectedIndexChanged(null, null);
			}
			if (type[6] != -1)
			{
				ZanColor3_SelectedIndexChanged(null, null);
			}
			if (type[9] != -1)
			{
				ZanColor4_SelectedIndexChanged(null, null);
			}
			if (type[12] != -1)
			{
				ZanColor5_SelectedIndexChanged(null, null);
			}
			if (type[15] != -1)
			{
				ZanColor6_SelectedIndexChanged(null, null);
			}
			ZanVal11.SelectedIndex = type[0];
			ZanVal12.SelectedIndex = type[1];
			ZanVal13.SelectedIndex = type[2];
			ZanVal21.SelectedIndex = type[3];
			ZanVal22.SelectedIndex = type[4];
			ZanVal23.SelectedIndex = type[5];
			ZanVal31.SelectedIndex = type[6];
			ZanVal32.SelectedIndex = type[7];
			ZanVal33.SelectedIndex = type[8];
			ZanVal41.SelectedIndex = type[9];
			ZanVal42.SelectedIndex = type[10];
			ZanVal43.SelectedIndex = type[11];
			ZanVal51.SelectedIndex = type[12];
			ZanVal52.SelectedIndex = type[13];
			ZanVal53.SelectedIndex = type[14];
			ZanVal61.SelectedIndex = type[15];
			ZanVal62.SelectedIndex = type[16];
			ZanVal63.SelectedIndex = type[17];
			if (type[0] != -1)
			{
				ZanVal11_SelectedIndexChanged(null, null);
				ZanNum11.Value = val[0];
				ZanNum11_ValueChanged(null, null);
			}
			if (type[1] != -1)
			{
				ZanVal12_SelectedIndexChanged(null, null);
				ZanNum12.Value = val[1];
				ZanNum12_ValueChanged(null, null);
			}
			if (type[2] != -1)
			{
				ZanVal13_SelectedIndexChanged(null, null);
				ZanNum13.Value = val[2];
				ZanNum13_ValueChanged(null, null);
			}
			if (type[3] != -1)
			{
				ZanVal21_SelectedIndexChanged(null, null);
				ZanNum21.Value = val[3];
				ZanNum21_ValueChanged(null, null);
			}
			if (type[4] != -1)
			{
				ZanVal22_SelectedIndexChanged(null, null);
				ZanNum22.Value = val[4];
				ZanNum22_ValueChanged(null, null);
			}
			if (type[5] != -1)
			{
				ZanVal23_SelectedIndexChanged(null, null);
				ZanNum23.Value = val[5];
				ZanNum23_ValueChanged(null, null);
			}
			if (type[6] != -1)
			{
				ZanVal31_SelectedIndexChanged(null, null);
				ZanNum31.Value = val[6];
				ZanNum31_ValueChanged(null, null);
			}
			if (type[7] != -1)
			{
				ZanVal32_SelectedIndexChanged(null, null);
				ZanNum32.Value = val[7];
				ZanNum32_ValueChanged(null, null);
			}
			if (type[8] != -1)
			{
				ZanVal33_SelectedIndexChanged(null, null);
				ZanNum33.Value = val[8];
				ZanNum33_ValueChanged(null, null);
			}
			if (type[9] != -1)
			{
				ZanVal41_SelectedIndexChanged(null, null);
				ZanNum41.Value = val[9];
				ZanNum41_ValueChanged(null, null);
			}
			if (type[10] != -1)
			{
				ZanVal42_SelectedIndexChanged(null, null);
				ZanNum42.Value = val[10];
				ZanNum42_ValueChanged(null, null);
			}
			if (type[11] != -1)
			{
				ZanVal43_SelectedIndexChanged(null, null);
				ZanNum43.Value = val[11];
				ZanNum43_ValueChanged(null, null);
			}
			if (type[12] != -1)
			{
				ZanVal51_SelectedIndexChanged(null, null);
				ZanNum51.Value = val[12];
				ZanNum51_ValueChanged(null, null);
			}
			if (type[13] != -1)
			{
				ZanVal52_SelectedIndexChanged(null, null);
				ZanNum52.Value = val[13];
				ZanNum52_ValueChanged(null, null);
			}
			if (type[14] != -1)
			{
				ZanVal53_SelectedIndexChanged(null, null);
				ZanNum53.Value = val[14];
				ZanNum53_ValueChanged(null, null);
			}
			if (type[15] != -1)
			{
				ZanVal61_SelectedIndexChanged(null, null);
				ZanNum61.Value = val[15];
				ZanNum61_ValueChanged(null, null);
			}
			if (type[16] != -1)
			{
				ZanVal62_SelectedIndexChanged(null, null);
				ZanNum62.Value = val[16];
				ZanNum62_ValueChanged(null, null);
			}
			if (type[17] != -1)
			{
				ZanVal63_SelectedIndexChanged(null, null);
				ZanNum63.Value = val[17];
				ZanNum63_ValueChanged(null, null);
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PockieNinjaBuilder.ZanpakutoForm));
			this.ZanLabel61 = new System.Windows.Forms.Label();
			this.ZanLabel51 = new System.Windows.Forms.Label();
			this.ZanLabel41 = new System.Windows.Forms.Label();
			this.ZanLabel31 = new System.Windows.Forms.Label();
			this.ZanLabel21 = new System.Windows.Forms.Label();
			this.ZanLabel11 = new System.Windows.Forms.Label();
			this.ZanNum61 = new System.Windows.Forms.TrackBar();
			this.ZanVal61 = new System.Windows.Forms.ComboBox();
			this.ZanNum51 = new System.Windows.Forms.TrackBar();
			this.ZanVal51 = new System.Windows.Forms.ComboBox();
			this.ZanNum41 = new System.Windows.Forms.TrackBar();
			this.ZanVal41 = new System.Windows.Forms.ComboBox();
			this.ZanNum31 = new System.Windows.Forms.TrackBar();
			this.ZanColor6 = new System.Windows.Forms.ComboBox();
			this.ZanVal31 = new System.Windows.Forms.ComboBox();
			this.ZanColor5 = new System.Windows.Forms.ComboBox();
			this.ZanNum21 = new System.Windows.Forms.TrackBar();
			this.ZanColor4 = new System.Windows.Forms.ComboBox();
			this.ZanVal21 = new System.Windows.Forms.ComboBox();
			this.ZanColor3 = new System.Windows.Forms.ComboBox();
			this.ZanNum11 = new System.Windows.Forms.TrackBar();
			this.ZanColor2 = new System.Windows.Forms.ComboBox();
			this.ZanVal11 = new System.Windows.Forms.ComboBox();
			this.ZanColor1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ZanVal12 = new System.Windows.Forms.ComboBox();
			this.ZanNum12 = new System.Windows.Forms.TrackBar();
			this.ZanLabel12 = new System.Windows.Forms.Label();
			this.ZanVal13 = new System.Windows.Forms.ComboBox();
			this.ZanNum13 = new System.Windows.Forms.TrackBar();
			this.ZanLabel13 = new System.Windows.Forms.Label();
			this.ZanVal22 = new System.Windows.Forms.ComboBox();
			this.ZanNum22 = new System.Windows.Forms.TrackBar();
			this.ZanLabel22 = new System.Windows.Forms.Label();
			this.ZanVal23 = new System.Windows.Forms.ComboBox();
			this.ZanNum23 = new System.Windows.Forms.TrackBar();
			this.ZanLabel23 = new System.Windows.Forms.Label();
			this.ZanVal32 = new System.Windows.Forms.ComboBox();
			this.ZanNum32 = new System.Windows.Forms.TrackBar();
			this.ZanLabel32 = new System.Windows.Forms.Label();
			this.ZanVal33 = new System.Windows.Forms.ComboBox();
			this.ZanNum33 = new System.Windows.Forms.TrackBar();
			this.ZanLabel33 = new System.Windows.Forms.Label();
			this.ZanVal42 = new System.Windows.Forms.ComboBox();
			this.ZanNum42 = new System.Windows.Forms.TrackBar();
			this.ZanLabel42 = new System.Windows.Forms.Label();
			this.ZanVal43 = new System.Windows.Forms.ComboBox();
			this.ZanNum43 = new System.Windows.Forms.TrackBar();
			this.ZanLabel43 = new System.Windows.Forms.Label();
			this.ZanVal52 = new System.Windows.Forms.ComboBox();
			this.ZanNum52 = new System.Windows.Forms.TrackBar();
			this.ZanLabel52 = new System.Windows.Forms.Label();
			this.ZanVal53 = new System.Windows.Forms.ComboBox();
			this.ZanNum53 = new System.Windows.Forms.TrackBar();
			this.ZanLabel53 = new System.Windows.Forms.Label();
			this.ZanVal62 = new System.Windows.Forms.ComboBox();
			this.ZanNum62 = new System.Windows.Forms.TrackBar();
			this.ZanLabel62 = new System.Windows.Forms.Label();
			this.ZanVal63 = new System.Windows.Forms.ComboBox();
			this.ZanNum63 = new System.Windows.Forms.TrackBar();
			this.ZanLabel63 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.ZanNum61).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum51).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum41).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum31).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum21).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum11).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum12).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum13).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum22).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum23).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum32).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum33).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum42).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum43).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum52).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum53).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum62).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum63).BeginInit();
			base.SuspendLayout();
			this.ZanLabel61.AutoSize = true;
			this.ZanLabel61.Location = new System.Drawing.Point(405, 437);
			this.ZanLabel61.Name = "ZanLabel61";
			this.ZanLabel61.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel61.TabIndex = 22;
			this.ZanLabel61.Text = "0";
			this.ZanLabel51.AutoSize = true;
			this.ZanLabel51.Location = new System.Drawing.Point(405, 356);
			this.ZanLabel51.Name = "ZanLabel51";
			this.ZanLabel51.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel51.TabIndex = 24;
			this.ZanLabel51.Text = "0";
			this.ZanLabel41.AutoSize = true;
			this.ZanLabel41.Location = new System.Drawing.Point(405, 275);
			this.ZanLabel41.Name = "ZanLabel41";
			this.ZanLabel41.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel41.TabIndex = 23;
			this.ZanLabel41.Text = "0";
			this.ZanLabel31.AutoSize = true;
			this.ZanLabel31.Location = new System.Drawing.Point(405, 194);
			this.ZanLabel31.Name = "ZanLabel31";
			this.ZanLabel31.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel31.TabIndex = 27;
			this.ZanLabel31.Text = "0";
			this.ZanLabel21.AutoSize = true;
			this.ZanLabel21.Location = new System.Drawing.Point(405, 113);
			this.ZanLabel21.Name = "ZanLabel21";
			this.ZanLabel21.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel21.TabIndex = 26;
			this.ZanLabel21.Text = "0";
			this.ZanLabel11.AutoSize = true;
			this.ZanLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.ZanLabel11.Location = new System.Drawing.Point(405, 32);
			this.ZanLabel11.Name = "ZanLabel11";
			this.ZanLabel11.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel11.TabIndex = 25;
			this.ZanLabel11.Text = "0";
			this.ZanNum61.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum61.Enabled = false;
			this.ZanNum61.Location = new System.Drawing.Point(256, 434);
			this.ZanNum61.Maximum = 0;
			this.ZanNum61.Name = "ZanNum61";
			this.ZanNum61.Size = new System.Drawing.Size(143, 45);
			this.ZanNum61.TabIndex = 17;
			this.ZanNum61.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum61.ValueChanged += new System.EventHandler(ZanNum61_ValueChanged);
			this.ZanVal61.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal61.Enabled = false;
			this.ZanVal61.FormattingEnabled = true;
			this.ZanVal61.Location = new System.Drawing.Point(129, 434);
			this.ZanVal61.Name = "ZanVal61";
			this.ZanVal61.Size = new System.Drawing.Size(121, 21);
			this.ZanVal61.TabIndex = 15;
			this.ZanVal61.SelectedIndexChanged += new System.EventHandler(ZanVal61_SelectedIndexChanged);
			this.ZanNum51.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum51.Enabled = false;
			this.ZanNum51.Location = new System.Drawing.Point(256, 353);
			this.ZanNum51.Maximum = 0;
			this.ZanNum51.Name = "ZanNum51";
			this.ZanNum51.Size = new System.Drawing.Size(143, 45);
			this.ZanNum51.TabIndex = 21;
			this.ZanNum51.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum51.ValueChanged += new System.EventHandler(ZanNum51_ValueChanged);
			this.ZanVal51.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal51.Enabled = false;
			this.ZanVal51.FormattingEnabled = true;
			this.ZanVal51.Location = new System.Drawing.Point(129, 353);
			this.ZanVal51.Name = "ZanVal51";
			this.ZanVal51.Size = new System.Drawing.Size(121, 21);
			this.ZanVal51.TabIndex = 14;
			this.ZanVal51.SelectedIndexChanged += new System.EventHandler(ZanVal51_SelectedIndexChanged);
			this.ZanNum41.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum41.Enabled = false;
			this.ZanNum41.Location = new System.Drawing.Point(256, 272);
			this.ZanNum41.Maximum = 0;
			this.ZanNum41.Name = "ZanNum41";
			this.ZanNum41.Size = new System.Drawing.Size(143, 45);
			this.ZanNum41.TabIndex = 19;
			this.ZanNum41.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum41.ValueChanged += new System.EventHandler(ZanNum41_ValueChanged);
			this.ZanVal41.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal41.Enabled = false;
			this.ZanVal41.FormattingEnabled = true;
			this.ZanVal41.Location = new System.Drawing.Point(129, 272);
			this.ZanVal41.Name = "ZanVal41";
			this.ZanVal41.Size = new System.Drawing.Size(121, 21);
			this.ZanVal41.TabIndex = 10;
			this.ZanVal41.SelectedIndexChanged += new System.EventHandler(ZanVal41_SelectedIndexChanged);
			this.ZanNum31.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum31.Enabled = false;
			this.ZanNum31.Location = new System.Drawing.Point(256, 191);
			this.ZanNum31.Maximum = 0;
			this.ZanNum31.Name = "ZanNum31";
			this.ZanNum31.Size = new System.Drawing.Size(143, 45);
			this.ZanNum31.TabIndex = 20;
			this.ZanNum31.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum31.ValueChanged += new System.EventHandler(ZanNum31_ValueChanged);
			this.ZanColor6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanColor6.FormattingEnabled = true;
			this.ZanColor6.Items.AddRange(new object[2] { "Blue", "Purple" });
			this.ZanColor6.Location = new System.Drawing.Point(12, 434);
			this.ZanColor6.Name = "ZanColor6";
			this.ZanColor6.Size = new System.Drawing.Size(111, 21);
			this.ZanColor6.TabIndex = 4;
			this.ZanColor6.SelectedIndexChanged += new System.EventHandler(ZanColor6_SelectedIndexChanged);
			this.ZanVal31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal31.Enabled = false;
			this.ZanVal31.FormattingEnabled = true;
			this.ZanVal31.Location = new System.Drawing.Point(129, 191);
			this.ZanVal31.Name = "ZanVal31";
			this.ZanVal31.Size = new System.Drawing.Size(121, 21);
			this.ZanVal31.TabIndex = 11;
			this.ZanVal31.SelectedIndexChanged += new System.EventHandler(ZanVal31_SelectedIndexChanged);
			this.ZanColor5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanColor5.FormattingEnabled = true;
			this.ZanColor5.Items.AddRange(new object[2] { "Blue", "Purple" });
			this.ZanColor5.Location = new System.Drawing.Point(12, 353);
			this.ZanColor5.Name = "ZanColor5";
			this.ZanColor5.Size = new System.Drawing.Size(111, 21);
			this.ZanColor5.TabIndex = 6;
			this.ZanColor5.SelectedIndexChanged += new System.EventHandler(ZanColor5_SelectedIndexChanged);
			this.ZanNum21.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum21.Enabled = false;
			this.ZanNum21.Location = new System.Drawing.Point(256, 110);
			this.ZanNum21.Maximum = 0;
			this.ZanNum21.Name = "ZanNum21";
			this.ZanNum21.Size = new System.Drawing.Size(143, 45);
			this.ZanNum21.TabIndex = 18;
			this.ZanNum21.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum21.ValueChanged += new System.EventHandler(ZanNum21_ValueChanged);
			this.ZanColor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanColor4.FormattingEnabled = true;
			this.ZanColor4.Items.AddRange(new object[2] { "Blue", "Purple" });
			this.ZanColor4.Location = new System.Drawing.Point(12, 272);
			this.ZanColor4.Name = "ZanColor4";
			this.ZanColor4.Size = new System.Drawing.Size(111, 21);
			this.ZanColor4.TabIndex = 5;
			this.ZanColor4.SelectedIndexChanged += new System.EventHandler(ZanColor4_SelectedIndexChanged);
			this.ZanVal21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal21.Enabled = false;
			this.ZanVal21.FormattingEnabled = true;
			this.ZanVal21.Location = new System.Drawing.Point(129, 110);
			this.ZanVal21.Name = "ZanVal21";
			this.ZanVal21.Size = new System.Drawing.Size(121, 21);
			this.ZanVal21.TabIndex = 13;
			this.ZanVal21.SelectedIndexChanged += new System.EventHandler(ZanVal21_SelectedIndexChanged);
			this.ZanColor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanColor3.FormattingEnabled = true;
			this.ZanColor3.Items.AddRange(new object[2] { "Blue", "Purple" });
			this.ZanColor3.Location = new System.Drawing.Point(12, 191);
			this.ZanColor3.Name = "ZanColor3";
			this.ZanColor3.Size = new System.Drawing.Size(111, 21);
			this.ZanColor3.TabIndex = 7;
			this.ZanColor3.SelectedIndexChanged += new System.EventHandler(ZanColor3_SelectedIndexChanged);
			this.ZanNum11.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum11.Enabled = false;
			this.ZanNum11.Location = new System.Drawing.Point(256, 29);
			this.ZanNum11.Maximum = 0;
			this.ZanNum11.Name = "ZanNum11";
			this.ZanNum11.Size = new System.Drawing.Size(143, 45);
			this.ZanNum11.TabIndex = 16;
			this.ZanNum11.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum11.ValueChanged += new System.EventHandler(ZanNum11_ValueChanged);
			this.ZanColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanColor2.FormattingEnabled = true;
			this.ZanColor2.Items.AddRange(new object[2] { "Blue", "Purple" });
			this.ZanColor2.Location = new System.Drawing.Point(12, 110);
			this.ZanColor2.Name = "ZanColor2";
			this.ZanColor2.Size = new System.Drawing.Size(111, 21);
			this.ZanColor2.TabIndex = 9;
			this.ZanColor2.SelectedIndexChanged += new System.EventHandler(ZanColor2_SelectedIndexChanged);
			this.ZanVal11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal11.Enabled = false;
			this.ZanVal11.FormattingEnabled = true;
			this.ZanVal11.Location = new System.Drawing.Point(129, 29);
			this.ZanVal11.Name = "ZanVal11";
			this.ZanVal11.Size = new System.Drawing.Size(121, 21);
			this.ZanVal11.TabIndex = 12;
			this.ZanVal11.SelectedIndexChanged += new System.EventHandler(ZanVal11_SelectedIndexChanged);
			this.ZanColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanColor1.FormattingEnabled = true;
			this.ZanColor1.Items.AddRange(new object[2] { "Blue", "Purple" });
			this.ZanColor1.Location = new System.Drawing.Point(12, 29);
			this.ZanColor1.Name = "ZanColor1";
			this.ZanColor1.Size = new System.Drawing.Size(111, 21);
			this.ZanColor1.TabIndex = 8;
			this.ZanColor1.SelectedIndexChanged += new System.EventHandler(ZanColor1_SelectedIndexChanged);
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Color:";
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(129, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Value:";
			this.ZanVal12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal12.Enabled = false;
			this.ZanVal12.FormattingEnabled = true;
			this.ZanVal12.Location = new System.Drawing.Point(129, 56);
			this.ZanVal12.Name = "ZanVal12";
			this.ZanVal12.Size = new System.Drawing.Size(121, 21);
			this.ZanVal12.TabIndex = 12;
			this.ZanVal12.SelectedIndexChanged += new System.EventHandler(ZanVal12_SelectedIndexChanged);
			this.ZanNum12.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum12.Enabled = false;
			this.ZanNum12.Location = new System.Drawing.Point(256, 56);
			this.ZanNum12.Maximum = 0;
			this.ZanNum12.Name = "ZanNum12";
			this.ZanNum12.Size = new System.Drawing.Size(143, 45);
			this.ZanNum12.TabIndex = 16;
			this.ZanNum12.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum12.ValueChanged += new System.EventHandler(ZanNum12_ValueChanged);
			this.ZanLabel12.AutoSize = true;
			this.ZanLabel12.Location = new System.Drawing.Point(405, 59);
			this.ZanLabel12.Name = "ZanLabel12";
			this.ZanLabel12.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel12.TabIndex = 25;
			this.ZanLabel12.Text = "0";
			this.ZanVal13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal13.Enabled = false;
			this.ZanVal13.FormattingEnabled = true;
			this.ZanVal13.Location = new System.Drawing.Point(129, 83);
			this.ZanVal13.Name = "ZanVal13";
			this.ZanVal13.Size = new System.Drawing.Size(121, 21);
			this.ZanVal13.TabIndex = 12;
			this.ZanVal13.SelectedIndexChanged += new System.EventHandler(ZanVal13_SelectedIndexChanged);
			this.ZanNum13.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum13.Enabled = false;
			this.ZanNum13.Location = new System.Drawing.Point(256, 83);
			this.ZanNum13.Maximum = 0;
			this.ZanNum13.Name = "ZanNum13";
			this.ZanNum13.Size = new System.Drawing.Size(143, 45);
			this.ZanNum13.TabIndex = 16;
			this.ZanNum13.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum13.ValueChanged += new System.EventHandler(ZanNum13_ValueChanged);
			this.ZanLabel13.AutoSize = true;
			this.ZanLabel13.Location = new System.Drawing.Point(405, 86);
			this.ZanLabel13.Name = "ZanLabel13";
			this.ZanLabel13.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel13.TabIndex = 25;
			this.ZanLabel13.Text = "0";
			this.ZanVal22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal22.Enabled = false;
			this.ZanVal22.FormattingEnabled = true;
			this.ZanVal22.Location = new System.Drawing.Point(129, 137);
			this.ZanVal22.Name = "ZanVal22";
			this.ZanVal22.Size = new System.Drawing.Size(121, 21);
			this.ZanVal22.TabIndex = 13;
			this.ZanVal22.SelectedIndexChanged += new System.EventHandler(ZanVal22_SelectedIndexChanged);
			this.ZanNum22.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum22.Enabled = false;
			this.ZanNum22.Location = new System.Drawing.Point(256, 137);
			this.ZanNum22.Maximum = 0;
			this.ZanNum22.Name = "ZanNum22";
			this.ZanNum22.Size = new System.Drawing.Size(143, 45);
			this.ZanNum22.TabIndex = 18;
			this.ZanNum22.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum22.ValueChanged += new System.EventHandler(ZanNum22_ValueChanged);
			this.ZanLabel22.AutoSize = true;
			this.ZanLabel22.Location = new System.Drawing.Point(405, 140);
			this.ZanLabel22.Name = "ZanLabel22";
			this.ZanLabel22.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel22.TabIndex = 26;
			this.ZanLabel22.Text = "0";
			this.ZanVal23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal23.Enabled = false;
			this.ZanVal23.FormattingEnabled = true;
			this.ZanVal23.Location = new System.Drawing.Point(129, 164);
			this.ZanVal23.Name = "ZanVal23";
			this.ZanVal23.Size = new System.Drawing.Size(121, 21);
			this.ZanVal23.TabIndex = 13;
			this.ZanVal23.SelectedIndexChanged += new System.EventHandler(ZanVal23_SelectedIndexChanged);
			this.ZanNum23.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum23.Enabled = false;
			this.ZanNum23.Location = new System.Drawing.Point(256, 164);
			this.ZanNum23.Maximum = 0;
			this.ZanNum23.Name = "ZanNum23";
			this.ZanNum23.Size = new System.Drawing.Size(143, 45);
			this.ZanNum23.TabIndex = 18;
			this.ZanNum23.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum23.ValueChanged += new System.EventHandler(ZanNum23_ValueChanged);
			this.ZanLabel23.AutoSize = true;
			this.ZanLabel23.Location = new System.Drawing.Point(405, 167);
			this.ZanLabel23.Name = "ZanLabel23";
			this.ZanLabel23.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel23.TabIndex = 26;
			this.ZanLabel23.Text = "0";
			this.ZanVal32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal32.Enabled = false;
			this.ZanVal32.FormattingEnabled = true;
			this.ZanVal32.Location = new System.Drawing.Point(129, 218);
			this.ZanVal32.Name = "ZanVal32";
			this.ZanVal32.Size = new System.Drawing.Size(121, 21);
			this.ZanVal32.TabIndex = 11;
			this.ZanVal32.SelectedIndexChanged += new System.EventHandler(ZanVal32_SelectedIndexChanged);
			this.ZanNum32.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum32.Enabled = false;
			this.ZanNum32.Location = new System.Drawing.Point(256, 218);
			this.ZanNum32.Maximum = 0;
			this.ZanNum32.Name = "ZanNum32";
			this.ZanNum32.Size = new System.Drawing.Size(143, 45);
			this.ZanNum32.TabIndex = 20;
			this.ZanNum32.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum32.ValueChanged += new System.EventHandler(ZanNum32_ValueChanged);
			this.ZanLabel32.AutoSize = true;
			this.ZanLabel32.Location = new System.Drawing.Point(405, 221);
			this.ZanLabel32.Name = "ZanLabel32";
			this.ZanLabel32.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel32.TabIndex = 27;
			this.ZanLabel32.Text = "0";
			this.ZanVal33.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal33.Enabled = false;
			this.ZanVal33.FormattingEnabled = true;
			this.ZanVal33.Location = new System.Drawing.Point(129, 245);
			this.ZanVal33.Name = "ZanVal33";
			this.ZanVal33.Size = new System.Drawing.Size(121, 21);
			this.ZanVal33.TabIndex = 11;
			this.ZanVal33.SelectedIndexChanged += new System.EventHandler(ZanVal33_SelectedIndexChanged);
			this.ZanNum33.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum33.Enabled = false;
			this.ZanNum33.Location = new System.Drawing.Point(256, 245);
			this.ZanNum33.Maximum = 0;
			this.ZanNum33.Name = "ZanNum33";
			this.ZanNum33.Size = new System.Drawing.Size(143, 45);
			this.ZanNum33.TabIndex = 20;
			this.ZanNum33.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum33.ValueChanged += new System.EventHandler(ZanNum33_ValueChanged);
			this.ZanLabel33.AutoSize = true;
			this.ZanLabel33.Location = new System.Drawing.Point(405, 248);
			this.ZanLabel33.Name = "ZanLabel33";
			this.ZanLabel33.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel33.TabIndex = 27;
			this.ZanLabel33.Text = "0";
			this.ZanVal42.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal42.Enabled = false;
			this.ZanVal42.FormattingEnabled = true;
			this.ZanVal42.Location = new System.Drawing.Point(129, 299);
			this.ZanVal42.Name = "ZanVal42";
			this.ZanVal42.Size = new System.Drawing.Size(121, 21);
			this.ZanVal42.TabIndex = 10;
			this.ZanVal42.SelectedIndexChanged += new System.EventHandler(ZanVal42_SelectedIndexChanged);
			this.ZanNum42.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum42.Enabled = false;
			this.ZanNum42.Location = new System.Drawing.Point(256, 299);
			this.ZanNum42.Maximum = 0;
			this.ZanNum42.Name = "ZanNum42";
			this.ZanNum42.Size = new System.Drawing.Size(143, 45);
			this.ZanNum42.TabIndex = 19;
			this.ZanNum42.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum42.ValueChanged += new System.EventHandler(ZanNum42_ValueChanged);
			this.ZanLabel42.AutoSize = true;
			this.ZanLabel42.Location = new System.Drawing.Point(405, 302);
			this.ZanLabel42.Name = "ZanLabel42";
			this.ZanLabel42.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel42.TabIndex = 23;
			this.ZanLabel42.Text = "0";
			this.ZanVal43.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal43.Enabled = false;
			this.ZanVal43.FormattingEnabled = true;
			this.ZanVal43.Location = new System.Drawing.Point(129, 326);
			this.ZanVal43.Name = "ZanVal43";
			this.ZanVal43.Size = new System.Drawing.Size(121, 21);
			this.ZanVal43.TabIndex = 10;
			this.ZanVal43.SelectedIndexChanged += new System.EventHandler(ZanVal43_SelectedIndexChanged);
			this.ZanNum43.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum43.Enabled = false;
			this.ZanNum43.Location = new System.Drawing.Point(256, 326);
			this.ZanNum43.Maximum = 0;
			this.ZanNum43.Name = "ZanNum43";
			this.ZanNum43.Size = new System.Drawing.Size(143, 45);
			this.ZanNum43.TabIndex = 19;
			this.ZanNum43.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum43.ValueChanged += new System.EventHandler(ZanNum43_ValueChanged);
			this.ZanLabel43.AutoSize = true;
			this.ZanLabel43.Location = new System.Drawing.Point(405, 329);
			this.ZanLabel43.Name = "ZanLabel43";
			this.ZanLabel43.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel43.TabIndex = 23;
			this.ZanLabel43.Text = "0";
			this.ZanVal52.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal52.Enabled = false;
			this.ZanVal52.FormattingEnabled = true;
			this.ZanVal52.Location = new System.Drawing.Point(129, 380);
			this.ZanVal52.Name = "ZanVal52";
			this.ZanVal52.Size = new System.Drawing.Size(121, 21);
			this.ZanVal52.TabIndex = 14;
			this.ZanVal52.SelectedIndexChanged += new System.EventHandler(ZanVal52_SelectedIndexChanged);
			this.ZanNum52.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum52.Enabled = false;
			this.ZanNum52.Location = new System.Drawing.Point(256, 380);
			this.ZanNum52.Maximum = 0;
			this.ZanNum52.Name = "ZanNum52";
			this.ZanNum52.Size = new System.Drawing.Size(143, 45);
			this.ZanNum52.TabIndex = 21;
			this.ZanNum52.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum52.ValueChanged += new System.EventHandler(ZanNum52_ValueChanged);
			this.ZanLabel52.AutoSize = true;
			this.ZanLabel52.Location = new System.Drawing.Point(405, 383);
			this.ZanLabel52.Name = "ZanLabel52";
			this.ZanLabel52.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel52.TabIndex = 24;
			this.ZanLabel52.Text = "0";
			this.ZanVal53.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal53.Enabled = false;
			this.ZanVal53.FormattingEnabled = true;
			this.ZanVal53.Location = new System.Drawing.Point(129, 407);
			this.ZanVal53.Name = "ZanVal53";
			this.ZanVal53.Size = new System.Drawing.Size(121, 21);
			this.ZanVal53.TabIndex = 14;
			this.ZanVal53.SelectedIndexChanged += new System.EventHandler(ZanVal53_SelectedIndexChanged);
			this.ZanNum53.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum53.Enabled = false;
			this.ZanNum53.Location = new System.Drawing.Point(256, 407);
			this.ZanNum53.Maximum = 0;
			this.ZanNum53.Name = "ZanNum53";
			this.ZanNum53.Size = new System.Drawing.Size(143, 45);
			this.ZanNum53.TabIndex = 21;
			this.ZanNum53.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum53.ValueChanged += new System.EventHandler(ZanNum53_ValueChanged);
			this.ZanLabel53.AutoSize = true;
			this.ZanLabel53.Location = new System.Drawing.Point(405, 410);
			this.ZanLabel53.Name = "ZanLabel53";
			this.ZanLabel53.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel53.TabIndex = 24;
			this.ZanLabel53.Text = "0";
			this.ZanVal62.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal62.Enabled = false;
			this.ZanVal62.FormattingEnabled = true;
			this.ZanVal62.Location = new System.Drawing.Point(129, 461);
			this.ZanVal62.Name = "ZanVal62";
			this.ZanVal62.Size = new System.Drawing.Size(121, 21);
			this.ZanVal62.TabIndex = 15;
			this.ZanVal62.SelectedIndexChanged += new System.EventHandler(ZanVal62_SelectedIndexChanged);
			this.ZanNum62.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum62.Enabled = false;
			this.ZanNum62.Location = new System.Drawing.Point(256, 461);
			this.ZanNum62.Maximum = 0;
			this.ZanNum62.Name = "ZanNum62";
			this.ZanNum62.Size = new System.Drawing.Size(143, 45);
			this.ZanNum62.TabIndex = 17;
			this.ZanNum62.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum62.ValueChanged += new System.EventHandler(ZanNum62_ValueChanged);
			this.ZanLabel62.AutoSize = true;
			this.ZanLabel62.Location = new System.Drawing.Point(405, 464);
			this.ZanLabel62.Name = "ZanLabel62";
			this.ZanLabel62.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel62.TabIndex = 22;
			this.ZanLabel62.Text = "0";
			this.ZanVal63.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ZanVal63.Enabled = false;
			this.ZanVal63.FormattingEnabled = true;
			this.ZanVal63.Location = new System.Drawing.Point(129, 488);
			this.ZanVal63.Name = "ZanVal63";
			this.ZanVal63.Size = new System.Drawing.Size(121, 21);
			this.ZanVal63.TabIndex = 15;
			this.ZanVal63.SelectedIndexChanged += new System.EventHandler(ZanVal63_SelectedIndexChanged);
			this.ZanNum63.BackColor = System.Drawing.SystemColors.Control;
			this.ZanNum63.Enabled = false;
			this.ZanNum63.Location = new System.Drawing.Point(256, 488);
			this.ZanNum63.Maximum = 0;
			this.ZanNum63.Name = "ZanNum63";
			this.ZanNum63.Size = new System.Drawing.Size(143, 45);
			this.ZanNum63.TabIndex = 17;
			this.ZanNum63.TickStyle = System.Windows.Forms.TickStyle.None;
			this.ZanNum63.ValueChanged += new System.EventHandler(ZanNum63_ValueChanged);
			this.ZanLabel63.AutoSize = true;
			this.ZanLabel63.Location = new System.Drawing.Point(405, 491);
			this.ZanLabel63.Name = "ZanLabel63";
			this.ZanLabel63.Size = new System.Drawing.Size(13, 13);
			this.ZanLabel63.TabIndex = 22;
			this.ZanLabel63.Text = "0";
			this.SaveButton.Location = new System.Drawing.Point(136, 520);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(148, 23);
			this.SaveButton.TabIndex = 30;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(SaveButton_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(427, 548);
			base.Controls.Add(this.SaveButton);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.ZanLabel63);
			base.Controls.Add(this.ZanLabel62);
			base.Controls.Add(this.ZanLabel61);
			base.Controls.Add(this.ZanLabel53);
			base.Controls.Add(this.ZanLabel52);
			base.Controls.Add(this.ZanLabel51);
			base.Controls.Add(this.ZanLabel43);
			base.Controls.Add(this.ZanLabel42);
			base.Controls.Add(this.ZanLabel41);
			base.Controls.Add(this.ZanLabel33);
			base.Controls.Add(this.ZanLabel32);
			base.Controls.Add(this.ZanLabel31);
			base.Controls.Add(this.ZanLabel23);
			base.Controls.Add(this.ZanLabel22);
			base.Controls.Add(this.ZanLabel21);
			base.Controls.Add(this.ZanLabel13);
			base.Controls.Add(this.ZanLabel12);
			base.Controls.Add(this.ZanLabel11);
			base.Controls.Add(this.ZanNum63);
			base.Controls.Add(this.ZanNum62);
			base.Controls.Add(this.ZanNum61);
			base.Controls.Add(this.ZanVal63);
			base.Controls.Add(this.ZanVal62);
			base.Controls.Add(this.ZanVal61);
			base.Controls.Add(this.ZanNum53);
			base.Controls.Add(this.ZanNum52);
			base.Controls.Add(this.ZanNum51);
			base.Controls.Add(this.ZanVal53);
			base.Controls.Add(this.ZanVal52);
			base.Controls.Add(this.ZanVal51);
			base.Controls.Add(this.ZanNum43);
			base.Controls.Add(this.ZanNum42);
			base.Controls.Add(this.ZanNum41);
			base.Controls.Add(this.ZanVal43);
			base.Controls.Add(this.ZanVal42);
			base.Controls.Add(this.ZanVal41);
			base.Controls.Add(this.ZanNum33);
			base.Controls.Add(this.ZanNum32);
			base.Controls.Add(this.ZanNum31);
			base.Controls.Add(this.ZanColor6);
			base.Controls.Add(this.ZanVal33);
			base.Controls.Add(this.ZanVal32);
			base.Controls.Add(this.ZanVal31);
			base.Controls.Add(this.ZanColor5);
			base.Controls.Add(this.ZanNum23);
			base.Controls.Add(this.ZanNum22);
			base.Controls.Add(this.ZanNum21);
			base.Controls.Add(this.ZanColor4);
			base.Controls.Add(this.ZanVal23);
			base.Controls.Add(this.ZanVal22);
			base.Controls.Add(this.ZanVal21);
			base.Controls.Add(this.ZanColor3);
			base.Controls.Add(this.ZanNum13);
			base.Controls.Add(this.ZanNum12);
			base.Controls.Add(this.ZanNum11);
			base.Controls.Add(this.ZanColor2);
			base.Controls.Add(this.ZanVal13);
			base.Controls.Add(this.ZanVal12);
			base.Controls.Add(this.ZanVal11);
			base.Controls.Add(this.ZanColor1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.Name = "ZanpakutoForm";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Zanpakuto";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ZanpakutoForm_FormClosing);
			((System.ComponentModel.ISupportInitialize)this.ZanNum61).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum51).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum41).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum31).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum21).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum11).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum12).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum13).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum22).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum23).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum32).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum33).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum42).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum43).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum52).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum53).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum62).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ZanNum63).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}
