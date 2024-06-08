using System.Drawing;
using PockieNinjaBuilder.PockieNinjaLibrary.Status;

namespace PockieNinjaBuilder.PockieNinjaLibrary
{
	public class Title
	{
		public int id { get; set; }

		public string name { get; set; }

		public Values[] values { get; set; }

		public Bitmap image { get; set; }
	}
}
