using System.Drawing;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Wing
	{
		public int id { get; set; }

		public string name { get; set; }

		public Bitmap image { get; set; }

		public Values[][] values { get; set; }

		public int bonus { get; set; }
	}
}
