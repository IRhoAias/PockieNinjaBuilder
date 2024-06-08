using System.Drawing;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Enchantment
	{
		public int id { get; set; }

		public string name { get; set; }

		public int level { get; set; }

		public string position { get; set; }

		public Values[] values { get; set; }

		public Bitmap image { get; set; }
	}
}
