using System.Drawing;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Bloodline
	{
		public int id { get; set; }

		public string name { get; set; }

		public int level { get; set; }

		public Strength str { get; set; }

		public Agility agi { get; set; }

		public Stamina sta { get; set; }

		public Values release { get; set; }

		public Bitmap image { get; set; }

		public Values[] values { get; set; }
	}
}
