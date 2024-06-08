using System.Drawing;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Equipment
	{
		public int id { get; set; }

		public string name { get; set; }

		public int level { get; set; }

		public int vlevel { get; set; }

		public Values[] bonus { get; set; }

		public int set { get; set; }

		public int type { get; set; }

		public int defense { get; set; }

		public int[] attack { get; set; }

		public Bitmap image { get; set; }

		public int forge { get; set; }
	}
}
