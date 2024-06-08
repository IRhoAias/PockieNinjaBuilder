using System.Drawing;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Gem
	{
		public int id { get; set; }

		public string name { get; set; }

		public int level { get; set; }

		public Values[] values { get; set; }

		public Bitmap image { get; set; }
	}
}
